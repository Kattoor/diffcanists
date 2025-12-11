
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
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_41aad3dff3634e43991719f25b81469e());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_4d96523ac54b420fb24300861300cb8e());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_a0f55f42ff4b42398888d65e71c665a6());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_ebcceea2ea304559b5a8672c2f194dcf());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_380049b08eb04537bcc2d046bf3288ad());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_5c2cc4680a7a46189a5fad70f1a371fb());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_3feece40c5564920a6006ae6833b073a());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_a13ed638311d4fecbe84f4f4bdebb71c());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_8e65862ba35948b28dffc9d6cad328c5());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_bc494dbd60854f36ba970509b389e7be());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_304ef9aaeeb04ae19c4893dc48996cc4());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_787cdbfbaab04778b19baa42d837f9d7());
    }

    private sealed class TYPE_0785df8b0c1b49c39400daf5b8945926 : HardwiredUserDataDescriptor
    {
      internal TYPE_0785df8b0c1b49c39400daf5b8945926()
        : base(typeof (ContainerGame))
      {
        this.AddMember("getUser", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getUser", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_7af1d25122194981929b65bdb214217d()
        }));
        this.AddMember("getPlayers", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayers", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_59c157b042584049aeae516231e7a737()
        }));
        this.AddMember("getPlayerCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayerCount", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_44d2989b7f8a4dde823bd43df04a18ca()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_cfc59323e83f4fddb87000ba36443467()
        }));
        this.AddMember("findCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_1304df10b7a34746a3794a11f994f8e0()
        }));
        this.AddMember("findEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findEffectors", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_7bb86235ca3547169628e57a2937334e()
        }));
        this.AddMember("LineCast", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCast", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_36a4adee7d4746ceacac1c7a6a16f422()
        }));
        this.AddMember("LineCastOnlyCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_cc7dc499ef154e57a48cc14eacb86767()
        }));
        this.AddMember("LineCastOnlyTerrain", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyTerrain", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_e74228f8da364d02affd0d75bc1e0c27()
        }));
        this.AddMember("ShowInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ShowInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_c303fa0cc18d4d1da2b304ed62e416d4()
        }));
        this.AddMember("hideInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("hideInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_97660d0f5f544559b70792eba001d99b()
        }));
        this.AddMember("Talk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Talk", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_037377955a414f838e777dddbe009dba()
        }));
        this.AddMember("get_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_9ea022921ef744ddaa7bf317becd33fb()
        }));
        this.AddMember("set_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_646cbd23e93a4a509a569d1ab2c20605()
        }));
        this.AddMember("get_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_a51ef22e7a8441509f5ba437cb470abd()
        }));
        this.AddMember("set_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_bc1c826bc3944d0fa65d9c64c6025d18()
        }));
        this.AddMember("get_totalTimeElapsed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_totalTimeElapsed", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_98abdc68e05541d58887f9a7c9572f34()
        }));
        this.AddMember("get_turnTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnTime", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_58760565e4944429b6138ff18449363b()
        }));
        this.AddMember("get_frame", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frame", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_09516c77e70247be9900143713862bda()
        }));
        this.AddMember("random", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("random", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_4bcdd8ceeab544acac3638555c09cd64()
        }));
        this.AddMember("get_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_58a26b17546e4bf9ada26c9882253cd8()
        }));
        this.AddMember("set_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_f485c37426fa46d69b8d5ec6069c0a21()
        }));
        this.AddMember("get_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_a219f325a4424db69c13b1f7b9f03c2c()
        }));
        this.AddMember("set_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_f4b845111b274da1b4d67495d39e63f8()
        }));
        this.AddMember("get_allowMinionMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMinionMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_489d176e41e1488581b8d57d90acfc98()
        }));
        this.AddMember("set_allowMinionMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMinionMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_1c15f9f8088b47ea9312f28b8fab4e7f()
        }));
        this.AddMember("get_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_41cd3ab1c8784de2ab323643ccc3a9ef()
        }));
        this.AddMember("set_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_d8ccfa4d7875410bbc5e43d7a4203ea5()
        }));
        this.AddMember("get_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_5ae8512c5ce844928933b2c2650f2554()
        }));
        this.AddMember("set_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_154168ae5eb241039e20722427b8dac0()
        }));
        this.AddMember("get_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_b8831748d9f442bc874914da4c0abc76()
        }));
        this.AddMember("set_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_4cc1b8251b2a4188a1950e7bbb3a5f0e()
        }));
        this.AddMember("get_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_11379d8e61124628bf07af54ce05f479()
        }));
        this.AddMember("set_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_c3acb5a811c344c18cdb4508d785959b()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_896e3a90b1d1402a9a8588cd3b35ac0f()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_bf2ab995ed024e968dbda06a3e05f0fc()
        }));
        this.AddMember("get_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_7f23654805944ffe9d9ad0a6f883d6db()
        }));
        this.AddMember("set_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_e5f9d7ec48b044debb059148d576f4cb()
        }));
        this.AddMember("get_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_752c1f787594498dafb63749a135ba35()
        }));
        this.AddMember("set_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_8b4e9f274de548c295e6201771efe9d6()
        }));
        this.AddMember("get_waiting", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waiting", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_c1fa07b2adde4eb3ac70115d0e9ce1ba()
        }));
        this.AddMember("get_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_8812229273e845e1abb84a85a3bd4b7e()
        }));
        this.AddMember("set_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_e3e0e6573ca14d87b636872a59430e6c()
        }));
        this.AddMember("get_busy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_busy", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_15b9cae68b6943bc842f5c56d9448cf3()
        }));
        this.AddMember("get_ongoing", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_ongoing", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_1eb066f6cb5c49da9af6c57c7eaeb30e()
        }));
        this.AddMember("get_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_cf7889060dc54142b1c437ab73a05fd5()
        }));
        this.AddMember("set_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_3d624e8b8c564f3193627180d61ae024()
        }));
        this.AddMember("get_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_5dbef2bf57f0497389f63dafdc07d155()
        }));
        this.AddMember("set_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_282e94689a8140a4803d93ed58737987()
        }));
        this.AddMember("get_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_26c9bdf37c0a476ca359bea89d28cbcd()
        }));
        this.AddMember("set_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_d8fc67b775544e9986dda453d616781e()
        }));
        this.AddMember("get_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_90148e7ec7374c19aefbb17dce6e4834()
        }));
        this.AddMember("set_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_899c4cb63e7842928ebfd79aed608d5b()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_c6d8257e7a8a4774a724ca36bf7e5263()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_c530ebd599714765817151c83890fe4d()
        }));
        this.AddMember("get_mousePosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mousePosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_8e346e2c1f3d49aa8aadab68573ab9de()
        }));
        this.AddMember("get_mouseOverUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mouseOverUI", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_c8ad39bbc3634c539cb43293c2936b6e()
        }));
        this.AddMember("worldToCanvas", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("worldToCanvas", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_3cf7fc1192364d5aaee179894dd0be8d()
        }));
        this.AddMember("canvasToWorld", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("canvasToWorld", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_0223896e3e6b4c4d9d1cf083e39f2957()
        }));
        this.AddMember("get_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_52fbd3be75d640eba8f37fcd90dbdf54()
        }));
        this.AddMember("set_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_5e7ec71df83e4fa890507e14f01f2400()
        }));
        this.AddMember("get_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_02034f3cc59542cfa098a43cb4a5a908()
        }));
        this.AddMember("set_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_dc54133ed0dd4f7a91683837b3f128f8()
        }));
        this.AddMember("getMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_e53ced9d167d4a9d84d5c4dd917272ab()
        }));
        this.AddMember("setMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_cc211e8fe25e4b88a6804e26aff496bc()
        }));
        this.AddMember("Dispose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Dispose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_ebd325152a6b409f996afa028005c895()
        }));
        this.AddMember("drawImage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawImage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_d5621e75951a44aca881677d15adc71c()
        }));
        this.AddMember("drawRectangle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawRectangle", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_9143a437e90745f0955412f558a3d889()
        }));
        this.AddMember("drawEllipseOutline", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipseOutline", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_6fac09e0798d40dcba4e16c82182644f()
        }));
        this.AddMember("drawEllipse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipse", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_76d326b220b948aa81f5278a706f1feb()
        }));
        this.AddMember("blit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_73a0474fbd3a41738bfd47fffc127481()
        }));
        this.AddMember("blitRotate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blitRotate", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_4855e0021f5f40b189ddbca86acd5f92()
        }));
        this.AddMember("applyDraw", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("applyDraw", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_b616e0b80f44425484873d608c646ad2()
        }));
        this.AddMember("get_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_8846894cb57d40689684d8f0ffe2bb30()
        }));
        this.AddMember("set_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_e62bf8aa135a4d70b0aa28f18819b1fa()
        }));
        this.AddMember("get_isUsingTouchControls", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isUsingTouchControls", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_66b4ec2e05fd4b64a6459e38e8a4c53f()
        }));
        this.AddMember("clientRefreshSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clientRefreshSpells", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_8a241bc4ccb045d3a2960bc4cdf48a78()
        }));
        this.AddMember("startCoroutine", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("startCoroutine", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_ab3c59b7e6db4113b41e1bc82711c99a()
        }));
        this.AddMember("devCommand", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("devCommand", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_911076533da44c4aa062da74080cc88d()
        }));
        this.AddMember("win", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("win", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_69287b88ae004ab9b27a378894996de0()
        }));
        this.AddMember("lose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("lose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_944fd258241b4903a76723b7e0154046()
        }));
        this.AddMember("nextTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("nextTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_b13b63c383814d4fa52617308a950dd0()
        }));
        this.AddMember("resetMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("resetMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_3c55f105f432497a935ad585ebd87b41()
        }));
        this.AddMember("clearMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_ec2d36c14e2f4dbdbccefce9b599782b()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_6366f969011b4064aaac37bb52724589()
        }));
        this.AddMember("getSpellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellEnum", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_1d6246b133c5497cb90541b1aa26e78e()
        }));
        this.AddMember("getSpellName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_1e0d426c0aa742d69ee21ea97a6e0385()
        }));
        this.AddMember("getMapID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapID", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_5f5c9e3655ab4eefaf5c2d6f784d3577()
        }));
        this.AddMember("getMapRealName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapRealName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_a3b7e0e6ce2d4fffb494997556622827()
        }));
        this.AddMember("getMapShortName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapShortName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_ab95e3ca054e4cdfb3fb7af88aa25da9()
        }));
        this.AddMember("getArmageddonName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getArmageddonName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_290d2359894343ffb3427d7f21169b55()
        }));
        this.AddMember("panCamera", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("panCamera", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_88b0f44e6a9e4bb68900b962afe97b40()
        }));
        this.AddMember("cameraFollow", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("cameraFollow", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_de26b9cc481b432394baee0d2fdbcb84()
        }));
        this.AddMember("getInputString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getInputString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_a74b6d49cb2c4fdf89929f68ddd47303()
        }));
        this.AddMember("get_screenWidth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenWidth", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_88118f64f2324541b0500dfbf5168a2f()
        }));
        this.AddMember("get_screenHeight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenHeight", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_8706d423c8864d23a008c05d0601d626()
        }));
        this.AddMember("createCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createCreature", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_77866fcdc969466386c6c1d3b2f11939()
        }));
        this.AddMember("clearIndicators", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearIndicators", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_8765b4baa13a49179600ee817a0e53ef()
        }));
        this.AddMember("createIndicator", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createIndicator", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_41dd948cc2af48e3b3785d1cbda761c3(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_6fe3030598a64703af8ea51bdee91cf4()
        }));
        this.AddMember("getKeyBinds", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getKeyBinds", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_e890ba5c6d4d4b81a6fb0d3eb92bc91d()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_ac10ce7b3b054b12a7c39a7894e933cb()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_7cc5505385764b8790c4b10292482243()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_2006ef0b4f6f454fa395c6604a37fecc()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.MTHD_d99ee3bc96984566bca1face00fd95c1()
        }));
        this.AddMember("turn", (IMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.PROP_abe59ee7dd4b48b9870daaa6f9f186c1());
        this.AddMember("timeLimit", (IMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.PROP_b4332027a990408ca469516d93a905d0());
        this.AddMember("totalTimeElapsed", (IMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.PROP_67b51cf01be745b695cecd17573ebcfc());
        this.AddMember("turnTime", (IMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.PROP_bd99fa434e254009a213611799ce3f32());
        this.AddMember("frame", (IMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.PROP_30c2becb8b3a4f0b900d603c09cf264b());
        this.AddMember("winOnDeath", (IMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.PROP_721f821360344a2d85e2aaa992fe26c8());
        this.AddMember("allowMovement", (IMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.PROP_8c3daa07e39e40b0b620b483b7628be1());
        this.AddMember("allowMinionMovement", (IMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.PROP_3d9b2b228e364bbb88a2392dafa00f8a());
        this.AddMember("allowInput", (IMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.PROP_873a894cbfbf4b939fbbe89ec18a1ec5());
        this.AddMember("allowCallbacks", (IMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.PROP_4e8dac618dc74068bb71facc0709f51d());
        this.AddMember("allowSkipTurn", (IMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.PROP_dfb8275d599b4d99ad0c043de3232c7b());
        this.AddMember("terrainDestruction", (IMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.PROP_3272d5f9b1b94e59bc0833d1f7b30447());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.PROP_9339cf8c70a6446999a505bbaa3a53b6());
        this.AddMember("armageddon", (IMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.PROP_a70ead3d2d4442ca8c2e7bb698003582());
        this.AddMember("armageddonTurn", (IMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.PROP_175dff63687846938b0c43f71e4ff37c());
        this.AddMember("waiting", (IMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.PROP_a9669da5eda449dfa21193f1467c099c());
        this.AddMember("paused", (IMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.PROP_99b3c3e2caab4d2690cbcce31ffc9e1d());
        this.AddMember("busy", (IMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.PROP_e215fd2b671a4a1bb04c23485bf20948());
        this.AddMember("ongoing", (IMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.PROP_20ca7bbe1c99485092e8998e12b67adc());
        this.AddMember("gravity", (IMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.PROP_13317cdb503d43338d84009f756b3f51());
        this.AddMember("wind", (IMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.PROP_90cf34417b7149ad8d4395ba58d3ca1f());
        this.AddMember("windDir", (IMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.PROP_184a6da12b7341b587d033d74cc8c347());
        this.AddMember("windPower", (IMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.PROP_76662f9c240c4c0aacf604c6f0fa1364());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.PROP_0a6a123b197746178d35289c2bb868bd());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.PROP_4da15d61eb6c4139bfa87cf2b3f546de());
        this.AddMember("mousePosition", (IMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.PROP_d9929432c2694e8bbf8a07ea77656497());
        this.AddMember("mouseOverUI", (IMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.PROP_6d96b0b7238c4e4b82032813c251d12a());
        this.AddMember("cameraPosition", (IMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.PROP_8b93dadd34274235a1d3e05162908d26());
        this.AddMember("cameraZoom", (IMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.PROP_6454ab3d196a4864ad8c1658259bbb7f());
        this.AddMember("allowBounce", (IMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.PROP_372f18856b97408c9bda116e812a7982());
        this.AddMember("isUsingTouchControls", (IMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.PROP_6524097a2aea43e7bd501de42c34d425());
        this.AddMember("screenWidth", (IMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.PROP_f49f579566c24625a748bd91bda27468());
        this.AddMember("screenHeight", (IMemberDescriptor) new Bridge.TYPE_0785df8b0c1b49c39400daf5b8945926.PROP_acbc05317dd743d0805ba70a58ea94b4());
      }

      private sealed class MTHD_7af1d25122194981929b65bdb214217d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7af1d25122194981929b65bdb214217d()
        {
          this.Initialize("getUser", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getUser();
        }
      }

      private sealed class MTHD_59c157b042584049aeae516231e7a737 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_59c157b042584049aeae516231e7a737()
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

      private sealed class MTHD_44d2989b7f8a4dde823bd43df04a18ca : HardwiredMethodMemberDescriptor
      {
        internal MTHD_44d2989b7f8a4dde823bd43df04a18ca()
        {
          this.Initialize("getPlayerCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getPlayerCount();
        }
      }

      private sealed class MTHD_cfc59323e83f4fddb87000ba36443467 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cfc59323e83f4fddb87000ba36443467()
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

      private sealed class MTHD_1304df10b7a34746a3794a11f994f8e0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1304df10b7a34746a3794a11f994f8e0()
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

      private sealed class MTHD_7bb86235ca3547169628e57a2937334e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7bb86235ca3547169628e57a2937334e()
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

      private sealed class MTHD_36a4adee7d4746ceacac1c7a6a16f422 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_36a4adee7d4746ceacac1c7a6a16f422()
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

      private sealed class MTHD_cc7dc499ef154e57a48cc14eacb86767 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cc7dc499ef154e57a48cc14eacb86767()
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

      private sealed class MTHD_e74228f8da364d02affd0d75bc1e0c27 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e74228f8da364d02affd0d75bc1e0c27()
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

      private sealed class MTHD_c303fa0cc18d4d1da2b304ed62e416d4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c303fa0cc18d4d1da2b304ed62e416d4()
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

      private sealed class MTHD_97660d0f5f544559b70792eba001d99b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_97660d0f5f544559b70792eba001d99b()
        {
          this.Initialize("hideInfo", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).hideInfo();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_037377955a414f838e777dddbe009dba : HardwiredMethodMemberDescriptor
      {
        internal MTHD_037377955a414f838e777dddbe009dba()
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

      private sealed class MTHD_9ea022921ef744ddaa7bf317becd33fb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9ea022921ef744ddaa7bf317becd33fb()
        {
          this.Initialize("get_turn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turn;
        }
      }

      private sealed class MTHD_646cbd23e93a4a509a569d1ab2c20605 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_646cbd23e93a4a509a569d1ab2c20605()
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

      private sealed class MTHD_a51ef22e7a8441509f5ba437cb470abd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a51ef22e7a8441509f5ba437cb470abd()
        {
          this.Initialize("get_timeLimit", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).timeLimit;
        }
      }

      private sealed class MTHD_bc1c826bc3944d0fa65d9c64c6025d18 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bc1c826bc3944d0fa65d9c64c6025d18()
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

      private sealed class MTHD_98abdc68e05541d58887f9a7c9572f34 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_98abdc68e05541d58887f9a7c9572f34()
        {
          this.Initialize("get_totalTimeElapsed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class MTHD_58760565e4944429b6138ff18449363b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_58760565e4944429b6138ff18449363b()
        {
          this.Initialize("get_turnTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class MTHD_09516c77e70247be9900143713862bda : HardwiredMethodMemberDescriptor
      {
        internal MTHD_09516c77e70247be9900143713862bda()
        {
          this.Initialize("get_frame", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class MTHD_4bcdd8ceeab544acac3638555c09cd64 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4bcdd8ceeab544acac3638555c09cd64()
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

      private sealed class MTHD_58a26b17546e4bf9ada26c9882253cd8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_58a26b17546e4bf9ada26c9882253cd8()
        {
          this.Initialize("get_winOnDeath", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).winOnDeath;
        }
      }

      private sealed class MTHD_f485c37426fa46d69b8d5ec6069c0a21 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f485c37426fa46d69b8d5ec6069c0a21()
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

      private sealed class MTHD_a219f325a4424db69c13b1f7b9f03c2c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a219f325a4424db69c13b1f7b9f03c2c()
        {
          this.Initialize("get_allowMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMovement;
        }
      }

      private sealed class MTHD_f4b845111b274da1b4d67495d39e63f8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f4b845111b274da1b4d67495d39e63f8()
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

      private sealed class MTHD_489d176e41e1488581b8d57d90acfc98 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_489d176e41e1488581b8d57d90acfc98()
        {
          this.Initialize("get_allowMinionMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMinionMovement;
        }
      }

      private sealed class MTHD_1c15f9f8088b47ea9312f28b8fab4e7f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1c15f9f8088b47ea9312f28b8fab4e7f()
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

      private sealed class MTHD_41cd3ab1c8784de2ab323643ccc3a9ef : HardwiredMethodMemberDescriptor
      {
        internal MTHD_41cd3ab1c8784de2ab323643ccc3a9ef()
        {
          this.Initialize("get_allowInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowInput;
        }
      }

      private sealed class MTHD_d8ccfa4d7875410bbc5e43d7a4203ea5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d8ccfa4d7875410bbc5e43d7a4203ea5()
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

      private sealed class MTHD_5ae8512c5ce844928933b2c2650f2554 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5ae8512c5ce844928933b2c2650f2554()
        {
          this.Initialize("get_allowCallbacks", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowCallbacks;
        }
      }

      private sealed class MTHD_154168ae5eb241039e20722427b8dac0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_154168ae5eb241039e20722427b8dac0()
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

      private sealed class MTHD_b8831748d9f442bc874914da4c0abc76 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b8831748d9f442bc874914da4c0abc76()
        {
          this.Initialize("get_allowSkipTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowSkipTurn;
        }
      }

      private sealed class MTHD_4cc1b8251b2a4188a1950e7bbb3a5f0e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4cc1b8251b2a4188a1950e7bbb3a5f0e()
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

      private sealed class MTHD_11379d8e61124628bf07af54ce05f479 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_11379d8e61124628bf07af54ce05f479()
        {
          this.Initialize("get_terrainDestruction", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).terrainDestruction;
        }
      }

      private sealed class MTHD_c3acb5a811c344c18cdb4508d785959b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c3acb5a811c344c18cdb4508d785959b()
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

      private sealed class MTHD_896e3a90b1d1402a9a8588cd3b35ac0f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_896e3a90b1d1402a9a8588cd3b35ac0f()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).takeDamage;
        }
      }

      private sealed class MTHD_bf2ab995ed024e968dbda06a3e05f0fc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bf2ab995ed024e968dbda06a3e05f0fc()
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

      private sealed class MTHD_7f23654805944ffe9d9ad0a6f883d6db : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7f23654805944ffe9d9ad0a6f883d6db()
        {
          this.Initialize("get_armageddon", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddon;
        }
      }

      private sealed class MTHD_e5f9d7ec48b044debb059148d576f4cb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e5f9d7ec48b044debb059148d576f4cb()
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

      private sealed class MTHD_752c1f787594498dafb63749a135ba35 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_752c1f787594498dafb63749a135ba35()
        {
          this.Initialize("get_armageddonTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddonTurn;
        }
      }

      private sealed class MTHD_8b4e9f274de548c295e6201771efe9d6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8b4e9f274de548c295e6201771efe9d6()
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

      private sealed class MTHD_c1fa07b2adde4eb3ac70115d0e9ce1ba : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c1fa07b2adde4eb3ac70115d0e9ce1ba()
        {
          this.Initialize("get_waiting", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class MTHD_8812229273e845e1abb84a85a3bd4b7e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8812229273e845e1abb84a85a3bd4b7e()
        {
          this.Initialize("get_paused", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).paused;
        }
      }

      private sealed class MTHD_e3e0e6573ca14d87b636872a59430e6c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e3e0e6573ca14d87b636872a59430e6c()
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

      private sealed class MTHD_15b9cae68b6943bc842f5c56d9448cf3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_15b9cae68b6943bc842f5c56d9448cf3()
        {
          this.Initialize("get_busy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class MTHD_1eb066f6cb5c49da9af6c57c7eaeb30e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1eb066f6cb5c49da9af6c57c7eaeb30e()
        {
          this.Initialize("get_ongoing", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class MTHD_cf7889060dc54142b1c437ab73a05fd5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cf7889060dc54142b1c437ab73a05fd5()
        {
          this.Initialize("get_gravity", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).gravity;
        }
      }

      private sealed class MTHD_3d624e8b8c564f3193627180d61ae024 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3d624e8b8c564f3193627180d61ae024()
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

      private sealed class MTHD_5dbef2bf57f0497389f63dafdc07d155 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5dbef2bf57f0497389f63dafdc07d155()
        {
          this.Initialize("get_wind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).wind;
        }
      }

      private sealed class MTHD_282e94689a8140a4803d93ed58737987 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_282e94689a8140a4803d93ed58737987()
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

      private sealed class MTHD_26c9bdf37c0a476ca359bea89d28cbcd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_26c9bdf37c0a476ca359bea89d28cbcd()
        {
          this.Initialize("get_windDir", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windDir;
        }
      }

      private sealed class MTHD_d8fc67b775544e9986dda453d616781e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d8fc67b775544e9986dda453d616781e()
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

      private sealed class MTHD_90148e7ec7374c19aefbb17dce6e4834 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_90148e7ec7374c19aefbb17dce6e4834()
        {
          this.Initialize("get_windPower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windPower;
        }
      }

      private sealed class MTHD_899c4cb63e7842928ebfd79aed608d5b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_899c4cb63e7842928ebfd79aed608d5b()
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

      private sealed class MTHD_c6d8257e7a8a4774a724ca36bf7e5263 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c6d8257e7a8a4774a724ca36bf7e5263()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class MTHD_c530ebd599714765817151c83890fe4d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c530ebd599714765817151c83890fe4d()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class MTHD_8e346e2c1f3d49aa8aadab68573ab9de : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8e346e2c1f3d49aa8aadab68573ab9de()
        {
          this.Initialize("get_mousePosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class MTHD_c8ad39bbc3634c539cb43293c2936b6e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c8ad39bbc3634c539cb43293c2936b6e()
        {
          this.Initialize("get_mouseOverUI", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class MTHD_3cf7fc1192364d5aaee179894dd0be8d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3cf7fc1192364d5aaee179894dd0be8d()
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

      private sealed class MTHD_0223896e3e6b4c4d9d1cf083e39f2957 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0223896e3e6b4c4d9d1cf083e39f2957()
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

      private sealed class MTHD_52fbd3be75d640eba8f37fcd90dbdf54 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_52fbd3be75d640eba8f37fcd90dbdf54()
        {
          this.Initialize("get_cameraPosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraPosition;
        }
      }

      private sealed class MTHD_5e7ec71df83e4fa890507e14f01f2400 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5e7ec71df83e4fa890507e14f01f2400()
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

      private sealed class MTHD_02034f3cc59542cfa098a43cb4a5a908 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_02034f3cc59542cfa098a43cb4a5a908()
        {
          this.Initialize("get_cameraZoom", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraZoom;
        }
      }

      private sealed class MTHD_dc54133ed0dd4f7a91683837b3f128f8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dc54133ed0dd4f7a91683837b3f128f8()
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

      private sealed class MTHD_e53ced9d167d4a9d84d5c4dd917272ab : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e53ced9d167d4a9d84d5c4dd917272ab()
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

      private sealed class MTHD_cc211e8fe25e4b88a6804e26aff496bc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cc211e8fe25e4b88a6804e26aff496bc()
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

      private sealed class MTHD_ebd325152a6b409f996afa028005c895 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ebd325152a6b409f996afa028005c895()
        {
          this.Initialize("Dispose", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ContainerGame.Dispose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_d5621e75951a44aca881677d15adc71c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d5621e75951a44aca881677d15adc71c()
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

      private sealed class MTHD_9143a437e90745f0955412f558a3d889 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9143a437e90745f0955412f558a3d889()
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

      private sealed class MTHD_6fac09e0798d40dcba4e16c82182644f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6fac09e0798d40dcba4e16c82182644f()
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

      private sealed class MTHD_76d326b220b948aa81f5278a706f1feb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_76d326b220b948aa81f5278a706f1feb()
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

      private sealed class MTHD_73a0474fbd3a41738bfd47fffc127481 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_73a0474fbd3a41738bfd47fffc127481()
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

      private sealed class MTHD_4855e0021f5f40b189ddbca86acd5f92 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4855e0021f5f40b189ddbca86acd5f92()
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

      private sealed class MTHD_b616e0b80f44425484873d608c646ad2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b616e0b80f44425484873d608c646ad2()
        {
          this.Initialize("applyDraw", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).applyDraw();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_8846894cb57d40689684d8f0ffe2bb30 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8846894cb57d40689684d8f0ffe2bb30()
        {
          this.Initialize("get_allowBounce", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowBounce;
        }
      }

      private sealed class MTHD_e62bf8aa135a4d70b0aa28f18819b1fa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e62bf8aa135a4d70b0aa28f18819b1fa()
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

      private sealed class MTHD_66b4ec2e05fd4b64a6459e38e8a4c53f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_66b4ec2e05fd4b64a6459e38e8a4c53f()
        {
          this.Initialize("get_isUsingTouchControls", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class MTHD_8a241bc4ccb045d3a2960bc4cdf48a78 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8a241bc4ccb045d3a2960bc4cdf48a78()
        {
          this.Initialize("clientRefreshSpells", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clientRefreshSpells();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_ab3c59b7e6db4113b41e1bc82711c99a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ab3c59b7e6db4113b41e1bc82711c99a()
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

      private sealed class MTHD_911076533da44c4aa062da74080cc88d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_911076533da44c4aa062da74080cc88d()
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

      private sealed class MTHD_69287b88ae004ab9b27a378894996de0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_69287b88ae004ab9b27a378894996de0()
        {
          this.Initialize("win", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).win();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_944fd258241b4903a76723b7e0154046 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_944fd258241b4903a76723b7e0154046()
        {
          this.Initialize("lose", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).lose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_b13b63c383814d4fa52617308a950dd0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b13b63c383814d4fa52617308a950dd0()
        {
          this.Initialize("nextTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).nextTurn();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_3c55f105f432497a935ad585ebd87b41 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3c55f105f432497a935ad585ebd87b41()
        {
          this.Initialize("resetMap", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).resetMap();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_ec2d36c14e2f4dbdbccefce9b599782b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ec2d36c14e2f4dbdbccefce9b599782b()
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

      private sealed class MTHD_6366f969011b4064aaac37bb52724589 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6366f969011b4064aaac37bb52724589()
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

      private sealed class MTHD_1d6246b133c5497cb90541b1aa26e78e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1d6246b133c5497cb90541b1aa26e78e()
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

      private sealed class MTHD_1e0d426c0aa742d69ee21ea97a6e0385 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1e0d426c0aa742d69ee21ea97a6e0385()
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

      private sealed class MTHD_5f5c9e3655ab4eefaf5c2d6f784d3577 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5f5c9e3655ab4eefaf5c2d6f784d3577()
        {
          this.Initialize("getMapID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getMapID();
        }
      }

      private sealed class MTHD_a3b7e0e6ce2d4fffb494997556622827 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a3b7e0e6ce2d4fffb494997556622827()
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

      private sealed class MTHD_ab95e3ca054e4cdfb3fb7af88aa25da9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ab95e3ca054e4cdfb3fb7af88aa25da9()
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

      private sealed class MTHD_290d2359894343ffb3427d7f21169b55 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_290d2359894343ffb3427d7f21169b55()
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

      private sealed class MTHD_88b0f44e6a9e4bb68900b962afe97b40 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_88b0f44e6a9e4bb68900b962afe97b40()
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

      private sealed class MTHD_de26b9cc481b432394baee0d2fdbcb84 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_de26b9cc481b432394baee0d2fdbcb84()
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

      private sealed class MTHD_a74b6d49cb2c4fdf89929f68ddd47303 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a74b6d49cb2c4fdf89929f68ddd47303()
        {
          this.Initialize("getInputString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getInputString();
        }
      }

      private sealed class MTHD_88118f64f2324541b0500dfbf5168a2f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_88118f64f2324541b0500dfbf5168a2f()
        {
          this.Initialize("get_screenWidth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class MTHD_8706d423c8864d23a008c05d0601d626 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8706d423c8864d23a008c05d0601d626()
        {
          this.Initialize("get_screenHeight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }

      private sealed class MTHD_77866fcdc969466386c6c1d3b2f11939 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_77866fcdc969466386c6c1d3b2f11939()
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

      private sealed class MTHD_8765b4baa13a49179600ee817a0e53ef : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8765b4baa13a49179600ee817a0e53ef()
        {
          this.Initialize("clearIndicators", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clearIndicators();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_41dd948cc2af48e3b3785d1cbda761c3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_41dd948cc2af48e3b3785d1cbda761c3()
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

      private sealed class MTHD_6fe3030598a64703af8ea51bdee91cf4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6fe3030598a64703af8ea51bdee91cf4()
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

      private sealed class MTHD_e890ba5c6d4d4b81a6fb0d3eb92bc91d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e890ba5c6d4d4b81a6fb0d3eb92bc91d()
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

      private sealed class MTHD_ac10ce7b3b054b12a7c39a7894e933cb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ac10ce7b3b054b12a7c39a7894e933cb()
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

      private sealed class MTHD_7cc5505385764b8790c4b10292482243 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7cc5505385764b8790c4b10292482243()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_2006ef0b4f6f454fa395c6604a37fecc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2006ef0b4f6f454fa395c6604a37fecc()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_d99ee3bc96984566bca1face00fd95c1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d99ee3bc96984566bca1face00fd95c1()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_abe59ee7dd4b48b9870daaa6f9f186c1 : HardwiredMemberDescriptor
      {
        internal PROP_abe59ee7dd4b48b9870daaa6f9f186c1()
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

      private sealed class PROP_b4332027a990408ca469516d93a905d0 : HardwiredMemberDescriptor
      {
        internal PROP_b4332027a990408ca469516d93a905d0()
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

      private sealed class PROP_67b51cf01be745b695cecd17573ebcfc : HardwiredMemberDescriptor
      {
        internal PROP_67b51cf01be745b695cecd17573ebcfc()
          : base(typeof (double), "totalTimeElapsed", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class PROP_bd99fa434e254009a213611799ce3f32 : HardwiredMemberDescriptor
      {
        internal PROP_bd99fa434e254009a213611799ce3f32()
          : base(typeof (double), "turnTime", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class PROP_30c2becb8b3a4f0b900d603c09cf264b : HardwiredMemberDescriptor
      {
        internal PROP_30c2becb8b3a4f0b900d603c09cf264b()
          : base(typeof (int), "frame", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class PROP_721f821360344a2d85e2aaa992fe26c8 : HardwiredMemberDescriptor
      {
        internal PROP_721f821360344a2d85e2aaa992fe26c8()
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

      private sealed class PROP_8c3daa07e39e40b0b620b483b7628be1 : HardwiredMemberDescriptor
      {
        internal PROP_8c3daa07e39e40b0b620b483b7628be1()
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

      private sealed class PROP_3d9b2b228e364bbb88a2392dafa00f8a : HardwiredMemberDescriptor
      {
        internal PROP_3d9b2b228e364bbb88a2392dafa00f8a()
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

      private sealed class PROP_873a894cbfbf4b939fbbe89ec18a1ec5 : HardwiredMemberDescriptor
      {
        internal PROP_873a894cbfbf4b939fbbe89ec18a1ec5()
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

      private sealed class PROP_4e8dac618dc74068bb71facc0709f51d : HardwiredMemberDescriptor
      {
        internal PROP_4e8dac618dc74068bb71facc0709f51d()
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

      private sealed class PROP_dfb8275d599b4d99ad0c043de3232c7b : HardwiredMemberDescriptor
      {
        internal PROP_dfb8275d599b4d99ad0c043de3232c7b()
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

      private sealed class PROP_3272d5f9b1b94e59bc0833d1f7b30447 : HardwiredMemberDescriptor
      {
        internal PROP_3272d5f9b1b94e59bc0833d1f7b30447()
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

      private sealed class PROP_9339cf8c70a6446999a505bbaa3a53b6 : HardwiredMemberDescriptor
      {
        internal PROP_9339cf8c70a6446999a505bbaa3a53b6()
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

      private sealed class PROP_a70ead3d2d4442ca8c2e7bb698003582 : HardwiredMemberDescriptor
      {
        internal PROP_a70ead3d2d4442ca8c2e7bb698003582()
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

      private sealed class PROP_175dff63687846938b0c43f71e4ff37c : HardwiredMemberDescriptor
      {
        internal PROP_175dff63687846938b0c43f71e4ff37c()
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

      private sealed class PROP_a9669da5eda449dfa21193f1467c099c : HardwiredMemberDescriptor
      {
        internal PROP_a9669da5eda449dfa21193f1467c099c()
          : base(typeof (bool), "waiting", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class PROP_99b3c3e2caab4d2690cbcce31ffc9e1d : HardwiredMemberDescriptor
      {
        internal PROP_99b3c3e2caab4d2690cbcce31ffc9e1d()
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

      private sealed class PROP_e215fd2b671a4a1bb04c23485bf20948 : HardwiredMemberDescriptor
      {
        internal PROP_e215fd2b671a4a1bb04c23485bf20948()
          : base(typeof (bool), "busy", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class PROP_20ca7bbe1c99485092e8998e12b67adc : HardwiredMemberDescriptor
      {
        internal PROP_20ca7bbe1c99485092e8998e12b67adc()
          : base(typeof (bool), "ongoing", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class PROP_13317cdb503d43338d84009f756b3f51 : HardwiredMemberDescriptor
      {
        internal PROP_13317cdb503d43338d84009f756b3f51()
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

      private sealed class PROP_90cf34417b7149ad8d4395ba58d3ca1f : HardwiredMemberDescriptor
      {
        internal PROP_90cf34417b7149ad8d4395ba58d3ca1f()
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

      private sealed class PROP_184a6da12b7341b587d033d74cc8c347 : HardwiredMemberDescriptor
      {
        internal PROP_184a6da12b7341b587d033d74cc8c347()
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

      private sealed class PROP_76662f9c240c4c0aacf604c6f0fa1364 : HardwiredMemberDescriptor
      {
        internal PROP_76662f9c240c4c0aacf604c6f0fa1364()
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

      private sealed class PROP_0a6a123b197746178d35289c2bb868bd : HardwiredMemberDescriptor
      {
        internal PROP_0a6a123b197746178d35289c2bb868bd()
          : base(typeof (int), "width", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class PROP_4da15d61eb6c4139bfa87cf2b3f546de : HardwiredMemberDescriptor
      {
        internal PROP_4da15d61eb6c4139bfa87cf2b3f546de()
          : base(typeof (int), "height", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class PROP_d9929432c2694e8bbf8a07ea77656497 : HardwiredMemberDescriptor
      {
        internal PROP_d9929432c2694e8bbf8a07ea77656497()
          : base(typeof (Educative.Point), "mousePosition", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class PROP_6d96b0b7238c4e4b82032813c251d12a : HardwiredMemberDescriptor
      {
        internal PROP_6d96b0b7238c4e4b82032813c251d12a()
          : base(typeof (bool), "mouseOverUI", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class PROP_8b93dadd34274235a1d3e05162908d26 : HardwiredMemberDescriptor
      {
        internal PROP_8b93dadd34274235a1d3e05162908d26()
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

      private sealed class PROP_6454ab3d196a4864ad8c1658259bbb7f : HardwiredMemberDescriptor
      {
        internal PROP_6454ab3d196a4864ad8c1658259bbb7f()
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

      private sealed class PROP_372f18856b97408c9bda116e812a7982 : HardwiredMemberDescriptor
      {
        internal PROP_372f18856b97408c9bda116e812a7982()
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

      private sealed class PROP_6524097a2aea43e7bd501de42c34d425 : HardwiredMemberDescriptor
      {
        internal PROP_6524097a2aea43e7bd501de42c34d425()
          : base(typeof (bool), "isUsingTouchControls", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class PROP_f49f579566c24625a748bd91bda27468 : HardwiredMemberDescriptor
      {
        internal PROP_f49f579566c24625a748bd91bda27468()
          : base(typeof (double), "screenWidth", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class PROP_acbc05317dd743d0805ba70a58ea94b4 : HardwiredMemberDescriptor
      {
        internal PROP_acbc05317dd743d0805ba70a58ea94b4()
          : base(typeof (double), "screenHeight", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }
    }

    private sealed class TYPE_41aad3dff3634e43991719f25b81469e : HardwiredUserDataDescriptor
    {
      internal TYPE_41aad3dff3634e43991719f25b81469e()
        : base(typeof (ContainerPlayer))
      {
        this.AddMember("get_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_41aad3dff3634e43991719f25b81469e.MTHD_362003e266b34cecae8e36f3b2aa4f03()
        }));
        this.AddMember("set_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_41aad3dff3634e43991719f25b81469e.MTHD_c848b22ff02645bf997eaab49b5103a6()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_41aad3dff3634e43991719f25b81469e.MTHD_749815f16d3747ec86dfb8e64dc07e63()
        }));
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_41aad3dff3634e43991719f25b81469e.MTHD_ffe70b4f69344640bf470091469a2d57()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_41aad3dff3634e43991719f25b81469e.MTHD_53f7bf7362394abd8d0ec2f0bcd043f0()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_41aad3dff3634e43991719f25b81469e.MTHD_f8b609d43ef445a3968b1f529722588f()
        }));
        this.AddMember("getCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreature", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_41aad3dff3634e43991719f25b81469e.MTHD_f4c81fa59e404a7e9737f4899b0621a2()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_41aad3dff3634e43991719f25b81469e.MTHD_709e4a0b40e740d5b75cbd071404b622()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_41aad3dff3634e43991719f25b81469e.MTHD_d6291ef0fba7473daabea10d3ab06383()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_41aad3dff3634e43991719f25b81469e.MTHD_2443879880cc43f48540027c724babd3()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_41aad3dff3634e43991719f25b81469e.MTHD_1f1e1192aa0b48459669945e0b1d2ca0()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_41aad3dff3634e43991719f25b81469e.MTHD_2017166d668b40a890e95e6df8eceaf7()
        }));
        this.AddMember("localTurn", (IMemberDescriptor) new Bridge.TYPE_41aad3dff3634e43991719f25b81469e.PROP_92b7e38c5a264f44a523d3f36b531318());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_41aad3dff3634e43991719f25b81469e.PROP_58081341f8084bf69a7a5425600d9de1());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_41aad3dff3634e43991719f25b81469e.PROP_85e01e94a85040e78ae34e3588ff7fda());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_41aad3dff3634e43991719f25b81469e.PROP_cf89b17e097641e78f4dd174b278d0b5());
      }

      private sealed class MTHD_362003e266b34cecae8e36f3b2aa4f03 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_362003e266b34cecae8e36f3b2aa4f03()
        {
          this.Initialize("get_localTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).localTurn;
        }
      }

      private sealed class MTHD_c848b22ff02645bf997eaab49b5103a6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c848b22ff02645bf997eaab49b5103a6()
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

      private sealed class MTHD_749815f16d3747ec86dfb8e64dc07e63 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_749815f16d3747ec86dfb8e64dc07e63()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class MTHD_ffe70b4f69344640bf470091469a2d57 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ffe70b4f69344640bf470091469a2d57()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class MTHD_53f7bf7362394abd8d0ec2f0bcd043f0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_53f7bf7362394abd8d0ec2f0bcd043f0()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }

      private sealed class MTHD_f8b609d43ef445a3968b1f529722588f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f8b609d43ef445a3968b1f529722588f()
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

      private sealed class MTHD_f4c81fa59e404a7e9737f4899b0621a2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f4c81fa59e404a7e9737f4899b0621a2()
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

      private sealed class MTHD_709e4a0b40e740d5b75cbd071404b622 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_709e4a0b40e740d5b75cbd071404b622()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).getMinionCount();
        }
      }

      private sealed class MTHD_d6291ef0fba7473daabea10d3ab06383 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d6291ef0fba7473daabea10d3ab06383()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).GetHashCode();
        }
      }

      private sealed class MTHD_2443879880cc43f48540027c724babd3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2443879880cc43f48540027c724babd3()
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

      private sealed class MTHD_1f1e1192aa0b48459669945e0b1d2ca0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1f1e1192aa0b48459669945e0b1d2ca0()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_2017166d668b40a890e95e6df8eceaf7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2017166d668b40a890e95e6df8eceaf7()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_92b7e38c5a264f44a523d3f36b531318 : HardwiredMemberDescriptor
      {
        internal PROP_92b7e38c5a264f44a523d3f36b531318()
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

      private sealed class PROP_58081341f8084bf69a7a5425600d9de1 : HardwiredMemberDescriptor
      {
        internal PROP_58081341f8084bf69a7a5425600d9de1()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class PROP_85e01e94a85040e78ae34e3588ff7fda : HardwiredMemberDescriptor
      {
        internal PROP_85e01e94a85040e78ae34e3588ff7fda()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class PROP_cf89b17e097641e78f4dd174b278d0b5 : HardwiredMemberDescriptor
      {
        internal PROP_cf89b17e097641e78f4dd174b278d0b5()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }
    }

    private sealed class TYPE_06a80686a4504307ac14f35027e1d886 : HardwiredUserDataDescriptor
    {
      internal TYPE_06a80686a4504307ac14f35027e1d886()
        : base(typeof (ContainerCreature))
      {
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_d1c1622997344c128f44b5ee5f1972e7()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_724f1224e9eb45d2a2abdbe9c60731f2()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_97b6db8fc0d8487cb434330e8de2d459()
        }));
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_42c24730e610437da6bdd54f28261dc2()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_b5baa46368534de4bd9014e4aebda035()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_10dbda7e7c274334a876c9592d0b5f02()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_c84ef051a8614f1eb42814af257852b8()
        }));
        this.AddMember("get_healthAndTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_healthAndTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_311a5538f3184e61b881b38f5243f766()
        }));
        this.AddMember("get_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_5f383ce421b449a0b6dd563efea7affe()
        }));
        this.AddMember("set_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_bf19a19a8ed24b11bc7a48334b67a0a8()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_d825cd6f08ee4e7a8651a0c36c937b3f()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_d3e8b80dea034d338e6711ab4ca483c6()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_877b2e52bcc14b12a36f8760c0cb8987()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_cd22818fccc94e8ba57fa3c371b36311()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_b43e1c966a894de082db2df0cbc46cfd()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_87b18fc1a5ae47dbabba2233ff115393()
        }));
        this.AddMember("get_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_04f0b7f45cd043d5961760d5db3c8764()
        }));
        this.AddMember("set_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_a06b906fd38b466ebb83302ae105b796()
        }));
        this.AddMember("get_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_938cade07b0c41808404b1df22325936()
        }));
        this.AddMember("set_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_983ab6d26add468a8fd754ee38f994d8()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_4ebf3eb967b2439bae6d78d9b4ad98c8()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_9ea260d504d145af8e8e3d2dbd528a0a()
        }));
        this.AddMember("get_inTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_1ad2a1543690455fac7949021ef779ac()
        }));
        this.AddMember("get_isMoving", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMoving", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_9f3b99adeb9f4dc0ae32eab326daaa15()
        }));
        this.AddMember("get_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_bf97d53242b94944b30b4cf978da6ffe()
        }));
        this.AddMember("set_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_946d83fd2dfa4013a735c879f37a5545()
        }));
        this.AddMember("get_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_1a7bedd79b744e59a881a727fbc4ea46()
        }));
        this.AddMember("set_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_fbec61357f1049e6a6012ccb4540b466()
        }));
        this.AddMember("get_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_c8039ea5c8324f32b484b1adb35a2732()
        }));
        this.AddMember("set_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_e5b446a0539e4d7193bec86aeb25e7af()
        }));
        this.AddMember("get_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_d8511683c1524116aad0a84a74b5bd7f()
        }));
        this.AddMember("set_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_f9d40946bf1f4c0da63b80f449c6b648()
        }));
        this.AddMember("get_inWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_0c5be9d6e46e40d7b92dbb71b04f2184()
        }));
        this.AddMember("get_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_0148c8ce716e4da5bb600166b50c3224()
        }));
        this.AddMember("set_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_61096632ef314ee28bb4b3a978a5a0c1()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_9681c534622d49259d4fe48105f5886a()
        }));
        this.AddMember("set_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_3268258ad2214617a32b59c8ab04eb71()
        }));
        this.AddMember("get_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_3f9d90bf51bf4bb0aa5dec72643500d5()
        }));
        this.AddMember("set_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_108d44d0c69048938d69ad5aaaea65ae()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_42cfcfc72b73437cb5e3a9ea17e78394()
        }));
        this.AddMember("get_isRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_2006c80d2b194b788e2f3fa4862c7615()
        }));
        this.AddMember("get_isMounted", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMounted", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_f6de504467b64c278b131eacf6b9aab2()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_cf1e5f48823e45c5a24cb9cbd3272707()
        }));
        this.AddMember("get_isPawn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPawn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_0e5f645b9f444500ad3c17affd2b19c1()
        }));
        this.AddMember("get_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_9dc2cc0a4fb74b96995353768a852ac9()
        }));
        this.AddMember("set_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_ed3f952279bf4eb7b58e634dc2670db9()
        }));
        this.AddMember("get_isMountable", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMountable", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_e96e069b23e64a19a60d5b4d90f0c71d()
        }));
        this.AddMember("get_canMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_canMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_3ad5b04a90a74028bf57065c8adc24cb()
        }));
        this.AddMember("get_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_3fafacf2dae749c39565d38b98b15352()
        }));
        this.AddMember("set_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_1f0b3c53da5c4ee89b095241c420b1b9()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_eb2c8dd0a834416c97389250bc56ee40()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_76cadf17bc76465291e6d9534693d845()
        }));
        this.AddMember("getRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_b636efdeec45491586d0ef6cbfee460c()
        }));
        this.AddMember("getMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_c5b0440ecad948de95f7314cf0745385()
        }));
        this.AddMember("getTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_e7e91eb38db14e18a942c005fe30c7a4()
        }));
        this.AddMember("LongJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LongJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_f2bd55a9787c44b098fafc844dc3c756()
        }));
        this.AddMember("HighJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("HighJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_69a7381371654f908fdd7f15798e35c9()
        }));
        this.AddMember("Walk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Walk", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_86e04b4bd5e4425da04ce2bdc6a3aabf()
        }));
        this.AddMember("setDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_bc3975807cbd431dbd076415d8bd038f()
        }));
        this.AddMember("getDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_519e68700e2d4f9d8dda90fecd1ae531()
        }));
        this.AddMember("getFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_22b746809f7046ee99773dc95c925b56()
        }));
        this.AddMember("getActivateableFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_f854f78033a24b319ada423fb403c2da()
        }));
        this.AddMember("getActivateableFamiliarBookID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarBookID", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_f4b1e6420d94444e878279a46d9fc94b()
        }));
        this.AddMember("increaseFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("increaseFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_7f2d5cbb9a8e4fc1838151f57773d0f6()
        }));
        this.AddMember("inside", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("inside", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_10781b6da9934e12a50ab4c9f81171d7(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_bb34b58fcbf84d11aa9a04a341569c31()
        }));
        this.AddMember("overlap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("overlap", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_1595acc1633f4e25a0a73144cdc8ee83(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_acb134b73ddf4193aa0ef8dfa4559af5()
        }));
        this.AddMember("die", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("die", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_a9abdca3e9024937b1b33476f35d8ac3()
        }));
        this.AddMember("addSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_0beae083165b440b870db0cc414fe9bf()
        }));
        this.AddMember("removeSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("removeSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_b93356178b434186b3afa87bdd399f7f(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_9f05c52dd197428aa60ca165ca68ac86()
        }));
        this.AddMember("getSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpells", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_2570baab5fb74c26bc1f6b1f8b573ccf()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_b67c745948274ca5ab0b0b0cb64e8a2d()
        }));
        this.AddMember("getSpellCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_da929dd2e66c4ab0b9bb1a6824d114c0()
        }));
        this.AddMember("castedCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_58148ec96ac64bd2a6141acd3dcfb314()
        }));
        this.AddMember("castedCountThisTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCountThisTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_f5c871be4b374d2b8602407ad3ace32e()
        }));
        this.AddMember("castedDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_b95e1d18e27e4a428b8fca1c0838c5cf()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_2fab78c603bc4ff588dba8637e3c73b9()
        }));
        this.AddMember("castSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_7b72071494a546c1a27c0f45574ac078()
        }));
        this.AddMember("angleToFire", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("angleToFire", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_13d8f8a8310e4ed296728bd1cba3a37a()
        }));
        this.AddMember("powerToFire", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("powerToFire", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_dcb7e97b31614936874c0a1d43a310e7()
        }));
        this.AddMember("fireAt", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fireAt", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_69725915bed040d68dc0195157eb645b(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_defe8994d8974a31a58b463c4fe37856()
        }));
        this.AddMember("getEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getEffectors", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_4b126037c8f149cb919705be7b3f0389(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_0e0cede0fc7745c2ae32a09b8fadd4f3()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_5b8292a6146b498eb709e135f1e3d326()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_a6d0000b4b5b44cba78446ef7a26c215()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_57893e41f2cc4b1bb02c2b2809d26bb5()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_c10344850b924fdb8990ec42d8255064()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_7cc5a001de79456c8f7fb2b71e01bbbc()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.MTHD_b516fdaaec0a42f3aff308bbda0f67c6()
        }));
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.PROP_8a22bf5cba764cd383151b8f4fd94231());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.PROP_3ddc169339364856a9d7d25fe7cc3678());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.PROP_42bf7c49d99f48fbab3c827f957ed3ab());
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.PROP_9dc257a15def4f23888a0a28e835aa80());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.PROP_38ebecaba4494ebba3a9434bae6b2cfe());
        this.AddMember("healthAndTower", (IMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.PROP_ecbd421e67da426896341b9268e782de());
        this.AddMember("shield", (IMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.PROP_1d4ba6276f1d4028be8c9b57c12b4f2f());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.PROP_5ee0d7f0f24b451fa9426b3662138534());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.PROP_7606512b171649a5be90a38302e9849e());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.PROP_deafd4b21a5742ae8848be576850d518());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.PROP_c564a40a3312466f8bba5bd737675704());
        this.AddMember("weight", (IMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.PROP_61063067680840fcb362a8393bfcca1a());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.PROP_07b0af5a91244870a49f22de0dfff633());
        this.AddMember("inTower", (IMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.PROP_7500192a0b68489d982ec85e030fcf1b());
        this.AddMember("isMoving", (IMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.PROP_7a96ca175df84e5a84620776ef267394());
        this.AddMember("stunned", (IMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.PROP_1f405aac671f4b40ab856367e5021dd8());
        this.AddMember("superStunned", (IMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.PROP_f6fba6cb41e341c28a77d006c14df284());
        this.AddMember("waterWalking", (IMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.PROP_6f11079a170048ed8f3c3febe83cdc4b());
        this.AddMember("frostWalking", (IMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.PROP_ca69eb734d5e46e2abd144f865f520ec());
        this.AddMember("inWater", (IMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.PROP_52fcc10936b24bf6b918749d272b36ee());
        this.AddMember("diesInWater", (IMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.PROP_161bf78191ca4e558f8024d5f380e3ff());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.PROP_2168ee4d20f64cc68b0765dac1cdf75c());
        this.AddMember("race", (IMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.PROP_4eabf771c3a54c9b8a4e4515c0df5fb1());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.PROP_f12030aebf144c4aa74b2b83ee156d72());
        this.AddMember("isRider", (IMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.PROP_b23b3d65f24b4a89a2a054e7a6d961a5());
        this.AddMember("isMounted", (IMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.PROP_8e5d81f34ad548ccbd14bee68dcd7fb9());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.PROP_3ff0841a24a94038bbee2e95e19f4631());
        this.AddMember("isPawn", (IMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.PROP_2f56a6b4d3cc4d579247189a6dc37967());
        this.AddMember("isFlying", (IMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.PROP_4a7dc826e8964f76bc8b75f8c80e1976());
        this.AddMember("isMountable", (IMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.PROP_a57f4de475844359899cdb372a16e928());
        this.AddMember("canMount", (IMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.PROP_66bfc64dee71497385b5fb0aa7e0374c());
        this.AddMember("arcaneMonster", (IMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.PROP_460ff1a74efd468bb16ac3c97f8b015c());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_06a80686a4504307ac14f35027e1d886.PROP_b893692b9f444434b59317eddd03ba25());
      }

      private sealed class MTHD_d1c1622997344c128f44b5ee5f1972e7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d1c1622997344c128f44b5ee5f1972e7()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class MTHD_724f1224e9eb45d2a2abdbe9c60731f2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_724f1224e9eb45d2a2abdbe9c60731f2()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class MTHD_97b6db8fc0d8487cb434330e8de2d459 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_97b6db8fc0d8487cb434330e8de2d459()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class MTHD_42c24730e610437da6bdd54f28261dc2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_42c24730e610437da6bdd54f28261dc2()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).health;
        }
      }

      private sealed class MTHD_b5baa46368534de4bd9014e4aebda035 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b5baa46368534de4bd9014e4aebda035()
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

      private sealed class MTHD_10dbda7e7c274334a876c9592d0b5f02 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_10dbda7e7c274334a876c9592d0b5f02()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).maxHealth;
        }
      }

      private sealed class MTHD_c84ef051a8614f1eb42814af257852b8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c84ef051a8614f1eb42814af257852b8()
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

      private sealed class MTHD_311a5538f3184e61b881b38f5243f766 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_311a5538f3184e61b881b38f5243f766()
        {
          this.Initialize("get_healthAndTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class MTHD_5f383ce421b449a0b6dd563efea7affe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5f383ce421b449a0b6dd563efea7affe()
        {
          this.Initialize("get_shield", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).shield;
        }
      }

      private sealed class MTHD_bf19a19a8ed24b11bc7a48334b67a0a8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bf19a19a8ed24b11bc7a48334b67a0a8()
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

      private sealed class MTHD_d825cd6f08ee4e7a8651a0c36c937b3f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d825cd6f08ee4e7a8651a0c36c937b3f()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).x;
        }
      }

      private sealed class MTHD_d3e8b80dea034d338e6711ab4ca483c6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d3e8b80dea034d338e6711ab4ca483c6()
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

      private sealed class MTHD_877b2e52bcc14b12a36f8760c0cb8987 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_877b2e52bcc14b12a36f8760c0cb8987()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).y;
        }
      }

      private sealed class MTHD_cd22818fccc94e8ba57fa3c371b36311 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cd22818fccc94e8ba57fa3c371b36311()
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

      private sealed class MTHD_b43e1c966a894de082db2df0cbc46cfd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b43e1c966a894de082db2df0cbc46cfd()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).position;
        }
      }

      private sealed class MTHD_87b18fc1a5ae47dbabba2233ff115393 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_87b18fc1a5ae47dbabba2233ff115393()
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

      private sealed class MTHD_04f0b7f45cd043d5961760d5db3c8764 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_04f0b7f45cd043d5961760d5db3c8764()
        {
          this.Initialize("get_parent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).parent;
        }
      }

      private sealed class MTHD_a06b906fd38b466ebb83302ae105b796 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a06b906fd38b466ebb83302ae105b796()
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

      private sealed class MTHD_938cade07b0c41808404b1df22325936 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_938cade07b0c41808404b1df22325936()
        {
          this.Initialize("get_weight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).weight;
        }
      }

      private sealed class MTHD_983ab6d26add468a8fd754ee38f994d8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_983ab6d26add468a8fd754ee38f994d8()
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

      private sealed class MTHD_4ebf3eb967b2439bae6d78d9b4ad98c8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4ebf3eb967b2439bae6d78d9b4ad98c8()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).radius;
        }
      }

      private sealed class MTHD_9ea260d504d145af8e8e3d2dbd528a0a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9ea260d504d145af8e8e3d2dbd528a0a()
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

      private sealed class MTHD_1ad2a1543690455fac7949021ef779ac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1ad2a1543690455fac7949021ef779ac()
        {
          this.Initialize("get_inTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class MTHD_9f3b99adeb9f4dc0ae32eab326daaa15 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9f3b99adeb9f4dc0ae32eab326daaa15()
        {
          this.Initialize("get_isMoving", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class MTHD_bf97d53242b94944b30b4cf978da6ffe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bf97d53242b94944b30b4cf978da6ffe()
        {
          this.Initialize("get_stunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).stunned;
        }
      }

      private sealed class MTHD_946d83fd2dfa4013a735c879f37a5545 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_946d83fd2dfa4013a735c879f37a5545()
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

      private sealed class MTHD_1a7bedd79b744e59a881a727fbc4ea46 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1a7bedd79b744e59a881a727fbc4ea46()
        {
          this.Initialize("get_superStunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).superStunned;
        }
      }

      private sealed class MTHD_fbec61357f1049e6a6012ccb4540b466 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fbec61357f1049e6a6012ccb4540b466()
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

      private sealed class MTHD_c8039ea5c8324f32b484b1adb35a2732 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c8039ea5c8324f32b484b1adb35a2732()
        {
          this.Initialize("get_waterWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).waterWalking;
        }
      }

      private sealed class MTHD_e5b446a0539e4d7193bec86aeb25e7af : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e5b446a0539e4d7193bec86aeb25e7af()
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

      private sealed class MTHD_d8511683c1524116aad0a84a74b5bd7f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d8511683c1524116aad0a84a74b5bd7f()
        {
          this.Initialize("get_frostWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).frostWalking;
        }
      }

      private sealed class MTHD_f9d40946bf1f4c0da63b80f449c6b648 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f9d40946bf1f4c0da63b80f449c6b648()
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

      private sealed class MTHD_0c5be9d6e46e40d7b92dbb71b04f2184 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0c5be9d6e46e40d7b92dbb71b04f2184()
        {
          this.Initialize("get_inWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class MTHD_0148c8ce716e4da5bb600166b50c3224 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0148c8ce716e4da5bb600166b50c3224()
        {
          this.Initialize("get_diesInWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).diesInWater;
        }
      }

      private sealed class MTHD_61096632ef314ee28bb4b3a978a5a0c1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_61096632ef314ee28bb4b3a978a5a0c1()
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

      private sealed class MTHD_9681c534622d49259d4fe48105f5886a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9681c534622d49259d4fe48105f5886a()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).type;
        }
      }

      private sealed class MTHD_3268258ad2214617a32b59c8ab04eb71 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3268258ad2214617a32b59c8ab04eb71()
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

      private sealed class MTHD_3f9d90bf51bf4bb0aa5dec72643500d5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3f9d90bf51bf4bb0aa5dec72643500d5()
        {
          this.Initialize("get_race", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).race;
        }
      }

      private sealed class MTHD_108d44d0c69048938d69ad5aaaea65ae : HardwiredMethodMemberDescriptor
      {
        internal MTHD_108d44d0c69048938d69ad5aaaea65ae()
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

      private sealed class MTHD_42cfcfc72b73437cb5e3a9ea17e78394 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_42cfcfc72b73437cb5e3a9ea17e78394()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class MTHD_2006c80d2b194b788e2f3fa4862c7615 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2006c80d2b194b788e2f3fa4862c7615()
        {
          this.Initialize("get_isRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class MTHD_f6de504467b64c278b131eacf6b9aab2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f6de504467b64c278b131eacf6b9aab2()
        {
          this.Initialize("get_isMounted", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class MTHD_cf1e5f48823e45c5a24cb9cbd3272707 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cf1e5f48823e45c5a24cb9cbd3272707()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class MTHD_0e5f645b9f444500ad3c17affd2b19c1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0e5f645b9f444500ad3c17affd2b19c1()
        {
          this.Initialize("get_isPawn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class MTHD_9dc2cc0a4fb74b96995353768a852ac9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9dc2cc0a4fb74b96995353768a852ac9()
        {
          this.Initialize("get_isFlying", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isFlying;
        }
      }

      private sealed class MTHD_ed3f952279bf4eb7b58e634dc2670db9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ed3f952279bf4eb7b58e634dc2670db9()
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

      private sealed class MTHD_e96e069b23e64a19a60d5b4d90f0c71d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e96e069b23e64a19a60d5b4d90f0c71d()
        {
          this.Initialize("get_isMountable", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class MTHD_3ad5b04a90a74028bf57065c8adc24cb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3ad5b04a90a74028bf57065c8adc24cb()
        {
          this.Initialize("get_canMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class MTHD_3fafacf2dae749c39565d38b98b15352 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3fafacf2dae749c39565d38b98b15352()
        {
          this.Initialize("get_arcaneMonster", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).arcaneMonster;
        }
      }

      private sealed class MTHD_1f0b3c53da5c4ee89b095241c420b1b9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1f0b3c53da5c4ee89b095241c420b1b9()
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

      private sealed class MTHD_eb2c8dd0a834416c97389250bc56ee40 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eb2c8dd0a834416c97389250bc56ee40()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).takeDamage;
        }
      }

      private sealed class MTHD_76cadf17bc76465291e6d9534693d845 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_76cadf17bc76465291e6d9534693d845()
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

      private sealed class MTHD_b636efdeec45491586d0ef6cbfee460c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b636efdeec45491586d0ef6cbfee460c()
        {
          this.Initialize("getRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getRider();
        }
      }

      private sealed class MTHD_c5b0440ecad948de95f7314cf0745385 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c5b0440ecad948de95f7314cf0745385()
        {
          this.Initialize("getMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMount();
        }
      }

      private sealed class MTHD_e7e91eb38db14e18a942c005fe30c7a4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e7e91eb38db14e18a942c005fe30c7a4()
        {
          this.Initialize("getTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getTower();
        }
      }

      private sealed class MTHD_f2bd55a9787c44b098fafc844dc3c756 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f2bd55a9787c44b098fafc844dc3c756()
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

      private sealed class MTHD_69a7381371654f908fdd7f15798e35c9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_69a7381371654f908fdd7f15798e35c9()
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

      private sealed class MTHD_86e04b4bd5e4425da04ce2bdc6a3aabf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_86e04b4bd5e4425da04ce2bdc6a3aabf()
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

      private sealed class MTHD_bc3975807cbd431dbd076415d8bd038f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bc3975807cbd431dbd076415d8bd038f()
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

      private sealed class MTHD_519e68700e2d4f9d8dda90fecd1ae531 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_519e68700e2d4f9d8dda90fecd1ae531()
        {
          this.Initialize("getDirection", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getDirection();
        }
      }

      private sealed class MTHD_22b746809f7046ee99773dc95c925b56 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_22b746809f7046ee99773dc95c925b56()
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

      private sealed class MTHD_f854f78033a24b319ada423fb403c2da : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f854f78033a24b319ada423fb403c2da()
        {
          this.Initialize("getActivateableFamiliarLevel", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarLevel();
        }
      }

      private sealed class MTHD_f4b1e6420d94444e878279a46d9fc94b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f4b1e6420d94444e878279a46d9fc94b()
        {
          this.Initialize("getActivateableFamiliarBookID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarBookID();
        }
      }

      private sealed class MTHD_7f2d5cbb9a8e4fc1838151f57773d0f6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7f2d5cbb9a8e4fc1838151f57773d0f6()
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

      private sealed class MTHD_10781b6da9934e12a50ab4c9f81171d7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_10781b6da9934e12a50ab4c9f81171d7()
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

      private sealed class MTHD_bb34b58fcbf84d11aa9a04a341569c31 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bb34b58fcbf84d11aa9a04a341569c31()
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

      private sealed class MTHD_1595acc1633f4e25a0a73144cdc8ee83 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1595acc1633f4e25a0a73144cdc8ee83()
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

      private sealed class MTHD_acb134b73ddf4193aa0ef8dfa4559af5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_acb134b73ddf4193aa0ef8dfa4559af5()
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

      private sealed class MTHD_a9abdca3e9024937b1b33476f35d8ac3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a9abdca3e9024937b1b33476f35d8ac3()
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

      private sealed class MTHD_0beae083165b440b870db0cc414fe9bf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0beae083165b440b870db0cc414fe9bf()
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

      private sealed class MTHD_b93356178b434186b3afa87bdd399f7f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b93356178b434186b3afa87bdd399f7f()
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

      private sealed class MTHD_9f05c52dd197428aa60ca165ca68ac86 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9f05c52dd197428aa60ca165ca68ac86()
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

      private sealed class MTHD_2570baab5fb74c26bc1f6b1f8b573ccf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2570baab5fb74c26bc1f6b1f8b573ccf()
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

      private sealed class MTHD_b67c745948274ca5ab0b0b0cb64e8a2d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b67c745948274ca5ab0b0b0cb64e8a2d()
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

      private sealed class MTHD_da929dd2e66c4ab0b9bb1a6824d114c0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_da929dd2e66c4ab0b9bb1a6824d114c0()
        {
          this.Initialize("getSpellCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getSpellCount();
        }
      }

      private sealed class MTHD_58148ec96ac64bd2a6141acd3dcfb314 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_58148ec96ac64bd2a6141acd3dcfb314()
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

      private sealed class MTHD_f5c871be4b374d2b8602407ad3ace32e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f5c871be4b374d2b8602407ad3ace32e()
        {
          this.Initialize("castedCountThisTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).castedCountThisTurn();
        }
      }

      private sealed class MTHD_b95e1d18e27e4a428b8fca1c0838c5cf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b95e1d18e27e4a428b8fca1c0838c5cf()
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

      private sealed class MTHD_2fab78c603bc4ff588dba8637e3c73b9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2fab78c603bc4ff588dba8637e3c73b9()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMinionCount();
        }
      }

      private sealed class MTHD_7b72071494a546c1a27c0f45574ac078 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7b72071494a546c1a27c0f45574ac078()
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

      private sealed class MTHD_13d8f8a8310e4ed296728bd1cba3a37a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_13d8f8a8310e4ed296728bd1cba3a37a()
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

      private sealed class MTHD_dcb7e97b31614936874c0a1d43a310e7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dcb7e97b31614936874c0a1d43a310e7()
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

      private sealed class MTHD_69725915bed040d68dc0195157eb645b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_69725915bed040d68dc0195157eb645b()
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

      private sealed class MTHD_defe8994d8974a31a58b463c4fe37856 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_defe8994d8974a31a58b463c4fe37856()
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

      private sealed class MTHD_4b126037c8f149cb919705be7b3f0389 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4b126037c8f149cb919705be7b3f0389()
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

      private sealed class MTHD_0e0cede0fc7745c2ae32a09b8fadd4f3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0e0cede0fc7745c2ae32a09b8fadd4f3()
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

      private sealed class MTHD_5b8292a6146b498eb709e135f1e3d326 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5b8292a6146b498eb709e135f1e3d326()
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

      private sealed class MTHD_a6d0000b4b5b44cba78446ef7a26c215 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a6d0000b4b5b44cba78446ef7a26c215()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).GetHashCode();
        }
      }

      private sealed class MTHD_57893e41f2cc4b1bb02c2b2809d26bb5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_57893e41f2cc4b1bb02c2b2809d26bb5()
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

      private sealed class MTHD_c10344850b924fdb8990ec42d8255064 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c10344850b924fdb8990ec42d8255064()
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

      private sealed class MTHD_7cc5a001de79456c8f7fb2b71e01bbbc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7cc5a001de79456c8f7fb2b71e01bbbc()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_b516fdaaec0a42f3aff308bbda0f67c6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b516fdaaec0a42f3aff308bbda0f67c6()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_8a22bf5cba764cd383151b8f4fd94231 : HardwiredMemberDescriptor
      {
        internal PROP_8a22bf5cba764cd383151b8f4fd94231()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class PROP_3ddc169339364856a9d7d25fe7cc3678 : HardwiredMemberDescriptor
      {
        internal PROP_3ddc169339364856a9d7d25fe7cc3678()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class PROP_42bf7c49d99f48fbab3c827f957ed3ab : HardwiredMemberDescriptor
      {
        internal PROP_42bf7c49d99f48fbab3c827f957ed3ab()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class PROP_9dc257a15def4f23888a0a28e835aa80 : HardwiredMemberDescriptor
      {
        internal PROP_9dc257a15def4f23888a0a28e835aa80()
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

      private sealed class PROP_38ebecaba4494ebba3a9434bae6b2cfe : HardwiredMemberDescriptor
      {
        internal PROP_38ebecaba4494ebba3a9434bae6b2cfe()
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

      private sealed class PROP_ecbd421e67da426896341b9268e782de : HardwiredMemberDescriptor
      {
        internal PROP_ecbd421e67da426896341b9268e782de()
          : base(typeof (int), "healthAndTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class PROP_1d4ba6276f1d4028be8c9b57c12b4f2f : HardwiredMemberDescriptor
      {
        internal PROP_1d4ba6276f1d4028be8c9b57c12b4f2f()
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

      private sealed class PROP_5ee0d7f0f24b451fa9426b3662138534 : HardwiredMemberDescriptor
      {
        internal PROP_5ee0d7f0f24b451fa9426b3662138534()
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

      private sealed class PROP_7606512b171649a5be90a38302e9849e : HardwiredMemberDescriptor
      {
        internal PROP_7606512b171649a5be90a38302e9849e()
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

      private sealed class PROP_deafd4b21a5742ae8848be576850d518 : HardwiredMemberDescriptor
      {
        internal PROP_deafd4b21a5742ae8848be576850d518()
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

      private sealed class PROP_c564a40a3312466f8bba5bd737675704 : HardwiredMemberDescriptor
      {
        internal PROP_c564a40a3312466f8bba5bd737675704()
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

      private sealed class PROP_61063067680840fcb362a8393bfcca1a : HardwiredMemberDescriptor
      {
        internal PROP_61063067680840fcb362a8393bfcca1a()
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

      private sealed class PROP_07b0af5a91244870a49f22de0dfff633 : HardwiredMemberDescriptor
      {
        internal PROP_07b0af5a91244870a49f22de0dfff633()
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

      private sealed class PROP_7500192a0b68489d982ec85e030fcf1b : HardwiredMemberDescriptor
      {
        internal PROP_7500192a0b68489d982ec85e030fcf1b()
          : base(typeof (bool), "inTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class PROP_7a96ca175df84e5a84620776ef267394 : HardwiredMemberDescriptor
      {
        internal PROP_7a96ca175df84e5a84620776ef267394()
          : base(typeof (bool), "isMoving", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class PROP_1f405aac671f4b40ab856367e5021dd8 : HardwiredMemberDescriptor
      {
        internal PROP_1f405aac671f4b40ab856367e5021dd8()
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

      private sealed class PROP_f6fba6cb41e341c28a77d006c14df284 : HardwiredMemberDescriptor
      {
        internal PROP_f6fba6cb41e341c28a77d006c14df284()
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

      private sealed class PROP_6f11079a170048ed8f3c3febe83cdc4b : HardwiredMemberDescriptor
      {
        internal PROP_6f11079a170048ed8f3c3febe83cdc4b()
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

      private sealed class PROP_ca69eb734d5e46e2abd144f865f520ec : HardwiredMemberDescriptor
      {
        internal PROP_ca69eb734d5e46e2abd144f865f520ec()
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

      private sealed class PROP_52fcc10936b24bf6b918749d272b36ee : HardwiredMemberDescriptor
      {
        internal PROP_52fcc10936b24bf6b918749d272b36ee()
          : base(typeof (bool), "inWater", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class PROP_161bf78191ca4e558f8024d5f380e3ff : HardwiredMemberDescriptor
      {
        internal PROP_161bf78191ca4e558f8024d5f380e3ff()
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

      private sealed class PROP_2168ee4d20f64cc68b0765dac1cdf75c : HardwiredMemberDescriptor
      {
        internal PROP_2168ee4d20f64cc68b0765dac1cdf75c()
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

      private sealed class PROP_4eabf771c3a54c9b8a4e4515c0df5fb1 : HardwiredMemberDescriptor
      {
        internal PROP_4eabf771c3a54c9b8a4e4515c0df5fb1()
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

      private sealed class PROP_f12030aebf144c4aa74b2b83ee156d72 : HardwiredMemberDescriptor
      {
        internal PROP_f12030aebf144c4aa74b2b83ee156d72()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class PROP_b23b3d65f24b4a89a2a054e7a6d961a5 : HardwiredMemberDescriptor
      {
        internal PROP_b23b3d65f24b4a89a2a054e7a6d961a5()
          : base(typeof (bool), "isRider", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class PROP_8e5d81f34ad548ccbd14bee68dcd7fb9 : HardwiredMemberDescriptor
      {
        internal PROP_8e5d81f34ad548ccbd14bee68dcd7fb9()
          : base(typeof (bool), "isMounted", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class PROP_3ff0841a24a94038bbee2e95e19f4631 : HardwiredMemberDescriptor
      {
        internal PROP_3ff0841a24a94038bbee2e95e19f4631()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class PROP_2f56a6b4d3cc4d579247189a6dc37967 : HardwiredMemberDescriptor
      {
        internal PROP_2f56a6b4d3cc4d579247189a6dc37967()
          : base(typeof (bool), "isPawn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class PROP_4a7dc826e8964f76bc8b75f8c80e1976 : HardwiredMemberDescriptor
      {
        internal PROP_4a7dc826e8964f76bc8b75f8c80e1976()
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

      private sealed class PROP_a57f4de475844359899cdb372a16e928 : HardwiredMemberDescriptor
      {
        internal PROP_a57f4de475844359899cdb372a16e928()
          : base(typeof (bool), "isMountable", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class PROP_66bfc64dee71497385b5fb0aa7e0374c : HardwiredMemberDescriptor
      {
        internal PROP_66bfc64dee71497385b5fb0aa7e0374c()
          : base(typeof (bool), "canMount", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class PROP_460ff1a74efd468bb16ac3c97f8b015c : HardwiredMemberDescriptor
      {
        internal PROP_460ff1a74efd468bb16ac3c97f8b015c()
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

      private sealed class PROP_b893692b9f444434b59317eddd03ba25 : HardwiredMemberDescriptor
      {
        internal PROP_b893692b9f444434b59317eddd03ba25()
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

    private sealed class TYPE_4d96523ac54b420fb24300861300cb8e : HardwiredUserDataDescriptor
    {
      internal TYPE_4d96523ac54b420fb24300861300cb8e()
        : base(typeof (ContainerEffector))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4d96523ac54b420fb24300861300cb8e.MTHD_1ee7ea9bffb141c3983dbd4ae85b8852()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4d96523ac54b420fb24300861300cb8e.MTHD_1a7d19c3410d4e22ab9f9d7f067b8c64()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4d96523ac54b420fb24300861300cb8e.MTHD_a46bc55ae5664c058a990ebaa727400c()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4d96523ac54b420fb24300861300cb8e.MTHD_8b89c9c1ffbb441b93d5df5a28eae598()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4d96523ac54b420fb24300861300cb8e.MTHD_8162c68cfd2b4d4a8b4e8de5d6314ae9()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4d96523ac54b420fb24300861300cb8e.MTHD_1d6cee1378c64aad9533e528740f6676()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4d96523ac54b420fb24300861300cb8e.MTHD_c8a3d2329e9c44b18252b403d8c1f65d()
        }));
        this.AddMember("get_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4d96523ac54b420fb24300861300cb8e.MTHD_19ba7ee118324adcbd476d813709b1b5()
        }));
        this.AddMember("set_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4d96523ac54b420fb24300861300cb8e.MTHD_bda3e7a1197f4df594915a75f07726a5()
        }));
        this.AddMember("get_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4d96523ac54b420fb24300861300cb8e.MTHD_cb6ff4871d664661b80b6e439a0718dc()
        }));
        this.AddMember("set_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4d96523ac54b420fb24300861300cb8e.MTHD_4aab0b2a37f6401f8d62485adb7a8590()
        }));
        this.AddMember("get_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4d96523ac54b420fb24300861300cb8e.MTHD_b64eadff19ad408fafeca4f41caf1ecd()
        }));
        this.AddMember("set_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4d96523ac54b420fb24300861300cb8e.MTHD_e9df1c1815aa42d7822df07efd5d2c3e()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4d96523ac54b420fb24300861300cb8e.MTHD_fccdfbde3bca4c2d9994cab75ad290c9()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4d96523ac54b420fb24300861300cb8e.MTHD_d5e7742922324231966f5b3e97151022()
        }));
        this.AddMember("turnPassed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("turnPassed", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4d96523ac54b420fb24300861300cb8e.MTHD_8dc6ffa0f80e4e5cb5153d2dc980acae()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4d96523ac54b420fb24300861300cb8e.MTHD_deb2ca39eb7a48f29378dc7e7e06d11f()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4d96523ac54b420fb24300861300cb8e.MTHD_8f710ed30a11469496dc19daea221e1b()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4d96523ac54b420fb24300861300cb8e.MTHD_2a2ae45ff168433b8eb3a4c4164c09ad()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4d96523ac54b420fb24300861300cb8e.MTHD_2a2b755b93fc4c92a0ea60bd229d40e8()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_4d96523ac54b420fb24300861300cb8e.PROP_17e55dda57114ab8b0933f360575b164());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_4d96523ac54b420fb24300861300cb8e.PROP_56ed2307359946a3a36bf2d6c23fe69d());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_4d96523ac54b420fb24300861300cb8e.PROP_b98e8f01b40b42568079e5e7f8c45d75());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_4d96523ac54b420fb24300861300cb8e.PROP_cd21924e98b94cd2b000e28eea46c424());
        this.AddMember("turnsAlive", (IMemberDescriptor) new Bridge.TYPE_4d96523ac54b420fb24300861300cb8e.PROP_f386bc6dd44146bba7b76edf56350890());
        this.AddMember("maxTurnsAlive", (IMemberDescriptor) new Bridge.TYPE_4d96523ac54b420fb24300861300cb8e.PROP_6a3beace370e487a864b3d2a6ebf89fe());
        this.AddMember("active", (IMemberDescriptor) new Bridge.TYPE_4d96523ac54b420fb24300861300cb8e.PROP_0dcd2fc40b4c484e844df9faa164b4e5());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_4d96523ac54b420fb24300861300cb8e.PROP_223a7c29dca84372a51a42b1cd231579());
      }

      private sealed class MTHD_1ee7ea9bffb141c3983dbd4ae85b8852 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1ee7ea9bffb141c3983dbd4ae85b8852()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class MTHD_1a7d19c3410d4e22ab9f9d7f067b8c64 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1a7d19c3410d4e22ab9f9d7f067b8c64()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).x;
        }
      }

      private sealed class MTHD_a46bc55ae5664c058a990ebaa727400c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a46bc55ae5664c058a990ebaa727400c()
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

      private sealed class MTHD_8b89c9c1ffbb441b93d5df5a28eae598 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8b89c9c1ffbb441b93d5df5a28eae598()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).y;
        }
      }

      private sealed class MTHD_8162c68cfd2b4d4a8b4e8de5d6314ae9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8162c68cfd2b4d4a8b4e8de5d6314ae9()
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

      private sealed class MTHD_1d6cee1378c64aad9533e528740f6676 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1d6cee1378c64aad9533e528740f6676()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).position;
        }
      }

      private sealed class MTHD_c8a3d2329e9c44b18252b403d8c1f65d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c8a3d2329e9c44b18252b403d8c1f65d()
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

      private sealed class MTHD_19ba7ee118324adcbd476d813709b1b5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_19ba7ee118324adcbd476d813709b1b5()
        {
          this.Initialize("get_turnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).turnsAlive;
        }
      }

      private sealed class MTHD_bda3e7a1197f4df594915a75f07726a5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bda3e7a1197f4df594915a75f07726a5()
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

      private sealed class MTHD_cb6ff4871d664661b80b6e439a0718dc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cb6ff4871d664661b80b6e439a0718dc()
        {
          this.Initialize("get_maxTurnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).maxTurnsAlive;
        }
      }

      private sealed class MTHD_4aab0b2a37f6401f8d62485adb7a8590 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4aab0b2a37f6401f8d62485adb7a8590()
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

      private sealed class MTHD_b64eadff19ad408fafeca4f41caf1ecd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b64eadff19ad408fafeca4f41caf1ecd()
        {
          this.Initialize("get_active", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).active;
        }
      }

      private sealed class MTHD_e9df1c1815aa42d7822df07efd5d2c3e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e9df1c1815aa42d7822df07efd5d2c3e()
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

      private sealed class MTHD_fccdfbde3bca4c2d9994cab75ad290c9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fccdfbde3bca4c2d9994cab75ad290c9()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }

      private sealed class MTHD_d5e7742922324231966f5b3e97151022 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d5e7742922324231966f5b3e97151022()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_8dc6ffa0f80e4e5cb5153d2dc980acae : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8dc6ffa0f80e4e5cb5153d2dc980acae()
        {
          this.Initialize("turnPassed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).turnPassed();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_deb2ca39eb7a48f29378dc7e7e06d11f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_deb2ca39eb7a48f29378dc7e7e06d11f()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).GetHashCode();
        }
      }

      private sealed class MTHD_8f710ed30a11469496dc19daea221e1b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8f710ed30a11469496dc19daea221e1b()
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

      private sealed class MTHD_2a2ae45ff168433b8eb3a4c4164c09ad : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2a2ae45ff168433b8eb3a4c4164c09ad()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_2a2b755b93fc4c92a0ea60bd229d40e8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2a2b755b93fc4c92a0ea60bd229d40e8()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_17e55dda57114ab8b0933f360575b164 : HardwiredMemberDescriptor
      {
        internal PROP_17e55dda57114ab8b0933f360575b164()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class PROP_56ed2307359946a3a36bf2d6c23fe69d : HardwiredMemberDescriptor
      {
        internal PROP_56ed2307359946a3a36bf2d6c23fe69d()
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

      private sealed class PROP_b98e8f01b40b42568079e5e7f8c45d75 : HardwiredMemberDescriptor
      {
        internal PROP_b98e8f01b40b42568079e5e7f8c45d75()
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

      private sealed class PROP_cd21924e98b94cd2b000e28eea46c424 : HardwiredMemberDescriptor
      {
        internal PROP_cd21924e98b94cd2b000e28eea46c424()
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

      private sealed class PROP_f386bc6dd44146bba7b76edf56350890 : HardwiredMemberDescriptor
      {
        internal PROP_f386bc6dd44146bba7b76edf56350890()
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

      private sealed class PROP_6a3beace370e487a864b3d2a6ebf89fe : HardwiredMemberDescriptor
      {
        internal PROP_6a3beace370e487a864b3d2a6ebf89fe()
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

      private sealed class PROP_0dcd2fc40b4c484e844df9faa164b4e5 : HardwiredMemberDescriptor
      {
        internal PROP_0dcd2fc40b4c484e844df9faa164b4e5()
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

      private sealed class PROP_223a7c29dca84372a51a42b1cd231579 : HardwiredMemberDescriptor
      {
        internal PROP_223a7c29dca84372a51a42b1cd231579()
          : base(typeof (EffectorType), "type", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }
    }

    private sealed class TYPE_a0f55f42ff4b42398888d65e71c665a6 : HardwiredUserDataDescriptor
    {
      internal TYPE_a0f55f42ff4b42398888d65e71c665a6()
        : base(typeof (ContainerIndicator))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a0f55f42ff4b42398888d65e71c665a6.MTHD_144a119515d744fa8c5b210d3c1c3dd0()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a0f55f42ff4b42398888d65e71c665a6.MTHD_70887f97d15a4de4833e6ab322804e71()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a0f55f42ff4b42398888d65e71c665a6.MTHD_c63075a893c04df39ce1e5dc690d1585()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a0f55f42ff4b42398888d65e71c665a6.MTHD_ac009a4e75c2474e879f845be9ae53cf()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a0f55f42ff4b42398888d65e71c665a6.MTHD_87b20970730b41d6a57d2f470b2eacad()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a0f55f42ff4b42398888d65e71c665a6.MTHD_b9f9d64e1370473eafc1c0447a6c17be()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a0f55f42ff4b42398888d65e71c665a6.MTHD_ec3c7e5419ac474d9a257e4694864a23()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a0f55f42ff4b42398888d65e71c665a6.MTHD_01ee5c18250c4f7f8cff8687561c6775()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a0f55f42ff4b42398888d65e71c665a6.MTHD_764617363b454c619f4ab201b46e9f7d()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a0f55f42ff4b42398888d65e71c665a6.MTHD_d3304553c42846a98cf5cbae9fd92b65()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a0f55f42ff4b42398888d65e71c665a6.MTHD_52018cc84c7540a183703d2127eefd34()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a0f55f42ff4b42398888d65e71c665a6.MTHD_3dbfa189240a4cf3b0e09138f6aa14c3()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a0f55f42ff4b42398888d65e71c665a6.MTHD_8095decfeaec449b8bc119318df6ce2d()
        }));
        this.AddMember("get_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color2", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a0f55f42ff4b42398888d65e71c665a6.MTHD_76ef5f21a1cd49589365ed3ffd0e4d85()
        }));
        this.AddMember("set_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color2", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a0f55f42ff4b42398888d65e71c665a6.MTHD_e86fb8fb37514e6cb1d1618f3a490922()
        }));
        this.AddMember("get_kind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_kind", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a0f55f42ff4b42398888d65e71c665a6.MTHD_16929b58c47d4c9295a86f541cee9228()
        }));
        this.AddMember("setIcon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setIcon", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a0f55f42ff4b42398888d65e71c665a6.MTHD_3a8460fe77084d0ca29dcce800fbc098()
        }));
        this.AddMember("Destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Destroy", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a0f55f42ff4b42398888d65e71c665a6.MTHD_98fee74db72d46e0bc066cf54687cb98()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a0f55f42ff4b42398888d65e71c665a6.MTHD_37cffddfd9174fe5a98cbcc620dfcb5c()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a0f55f42ff4b42398888d65e71c665a6.MTHD_2b2ffd6337e64ddb9dfd0e248001c1c4()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a0f55f42ff4b42398888d65e71c665a6.MTHD_72a21be2dca94954ba151d30d7e793f9()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a0f55f42ff4b42398888d65e71c665a6.MTHD_b28da814420648ffb4bf1df9b0bb9f4e()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_a0f55f42ff4b42398888d65e71c665a6.PROP_d407449cfcbd4c15b6f8632e184ac414());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_a0f55f42ff4b42398888d65e71c665a6.PROP_eb3da2aad1c748f28dc5ef949c02cde8());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_a0f55f42ff4b42398888d65e71c665a6.PROP_0c4f879fce5b4a9d936d6657cef18a7e());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_a0f55f42ff4b42398888d65e71c665a6.PROP_a41c652f720e4e138345c8901022f73e());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_a0f55f42ff4b42398888d65e71c665a6.PROP_7ea7bbc6640646698bcfd5ebb25d2f00());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_a0f55f42ff4b42398888d65e71c665a6.PROP_baa5ec1b20cd4f938c1489e1eb408499());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_a0f55f42ff4b42398888d65e71c665a6.PROP_4d98ec1d27db4a53aeff157b91e45e7e());
        this.AddMember("color2", (IMemberDescriptor) new Bridge.TYPE_a0f55f42ff4b42398888d65e71c665a6.PROP_a934687d5483482991669e4821609fe1());
        this.AddMember("kind", (IMemberDescriptor) new Bridge.TYPE_a0f55f42ff4b42398888d65e71c665a6.PROP_49860b15fc804a1da7850d19bded8beb());
      }

      private sealed class MTHD_144a119515d744fa8c5b210d3c1c3dd0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_144a119515d744fa8c5b210d3c1c3dd0()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class MTHD_70887f97d15a4de4833e6ab322804e71 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_70887f97d15a4de4833e6ab322804e71()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).x;
        }
      }

      private sealed class MTHD_c63075a893c04df39ce1e5dc690d1585 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c63075a893c04df39ce1e5dc690d1585()
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

      private sealed class MTHD_ac009a4e75c2474e879f845be9ae53cf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ac009a4e75c2474e879f845be9ae53cf()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).y;
        }
      }

      private sealed class MTHD_87b20970730b41d6a57d2f470b2eacad : HardwiredMethodMemberDescriptor
      {
        internal MTHD_87b20970730b41d6a57d2f470b2eacad()
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

      private sealed class MTHD_b9f9d64e1370473eafc1c0447a6c17be : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b9f9d64e1370473eafc1c0447a6c17be()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).radius;
        }
      }

      private sealed class MTHD_ec3c7e5419ac474d9a257e4694864a23 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ec3c7e5419ac474d9a257e4694864a23()
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

      private sealed class MTHD_01ee5c18250c4f7f8cff8687561c6775 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_01ee5c18250c4f7f8cff8687561c6775()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).position;
        }
      }

      private sealed class MTHD_764617363b454c619f4ab201b46e9f7d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_764617363b454c619f4ab201b46e9f7d()
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

      private sealed class MTHD_d3304553c42846a98cf5cbae9fd92b65 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d3304553c42846a98cf5cbae9fd92b65()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).angle;
        }
      }

      private sealed class MTHD_52018cc84c7540a183703d2127eefd34 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_52018cc84c7540a183703d2127eefd34()
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

      private sealed class MTHD_3dbfa189240a4cf3b0e09138f6aa14c3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3dbfa189240a4cf3b0e09138f6aa14c3()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color;
        }
      }

      private sealed class MTHD_8095decfeaec449b8bc119318df6ce2d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8095decfeaec449b8bc119318df6ce2d()
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

      private sealed class MTHD_76ef5f21a1cd49589365ed3ffd0e4d85 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_76ef5f21a1cd49589365ed3ffd0e4d85()
        {
          this.Initialize("get_color2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color2;
        }
      }

      private sealed class MTHD_e86fb8fb37514e6cb1d1618f3a490922 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e86fb8fb37514e6cb1d1618f3a490922()
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

      private sealed class MTHD_16929b58c47d4c9295a86f541cee9228 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_16929b58c47d4c9295a86f541cee9228()
        {
          this.Initialize("get_kind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }

      private sealed class MTHD_3a8460fe77084d0ca29dcce800fbc098 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3a8460fe77084d0ca29dcce800fbc098()
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

      private sealed class MTHD_98fee74db72d46e0bc066cf54687cb98 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_98fee74db72d46e0bc066cf54687cb98()
        {
          this.Initialize("Destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerIndicator) obj).Destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_37cffddfd9174fe5a98cbcc620dfcb5c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_37cffddfd9174fe5a98cbcc620dfcb5c()
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

      private sealed class MTHD_2b2ffd6337e64ddb9dfd0e248001c1c4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2b2ffd6337e64ddb9dfd0e248001c1c4()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_72a21be2dca94954ba151d30d7e793f9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_72a21be2dca94954ba151d30d7e793f9()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_b28da814420648ffb4bf1df9b0bb9f4e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b28da814420648ffb4bf1df9b0bb9f4e()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_d407449cfcbd4c15b6f8632e184ac414 : HardwiredMemberDescriptor
      {
        internal PROP_d407449cfcbd4c15b6f8632e184ac414()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class PROP_eb3da2aad1c748f28dc5ef949c02cde8 : HardwiredMemberDescriptor
      {
        internal PROP_eb3da2aad1c748f28dc5ef949c02cde8()
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

      private sealed class PROP_0c4f879fce5b4a9d936d6657cef18a7e : HardwiredMemberDescriptor
      {
        internal PROP_0c4f879fce5b4a9d936d6657cef18a7e()
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

      private sealed class PROP_a41c652f720e4e138345c8901022f73e : HardwiredMemberDescriptor
      {
        internal PROP_a41c652f720e4e138345c8901022f73e()
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

      private sealed class PROP_7ea7bbc6640646698bcfd5ebb25d2f00 : HardwiredMemberDescriptor
      {
        internal PROP_7ea7bbc6640646698bcfd5ebb25d2f00()
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

      private sealed class PROP_baa5ec1b20cd4f938c1489e1eb408499 : HardwiredMemberDescriptor
      {
        internal PROP_baa5ec1b20cd4f938c1489e1eb408499()
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

      private sealed class PROP_4d98ec1d27db4a53aeff157b91e45e7e : HardwiredMemberDescriptor
      {
        internal PROP_4d98ec1d27db4a53aeff157b91e45e7e()
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

      private sealed class PROP_a934687d5483482991669e4821609fe1 : HardwiredMemberDescriptor
      {
        internal PROP_a934687d5483482991669e4821609fe1()
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

      private sealed class PROP_49860b15fc804a1da7850d19bded8beb : HardwiredMemberDescriptor
      {
        internal PROP_49860b15fc804a1da7850d19bded8beb()
          : base(typeof (IndicatorKind), "kind", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }
    }

    private sealed class TYPE_ebcceea2ea304559b5a8672c2f194dcf : HardwiredUserDataDescriptor
    {
      internal TYPE_ebcceea2ea304559b5a8672c2f194dcf()
        : base(typeof (ContainerSpell))
      {
        this.AddMember("get_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ebcceea2ea304559b5a8672c2f194dcf.MTHD_2c74706a93684ee79b7ec12956aae947()
        }));
        this.AddMember("set_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ebcceea2ea304559b5a8672c2f194dcf.MTHD_b63d04db8bea4ff9a34b64ee2d6e0393()
        }));
        this.AddMember("get_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ebcceea2ea304559b5a8672c2f194dcf.MTHD_a6387455fa1a46bda17ddef75e2caaee()
        }));
        this.AddMember("set_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ebcceea2ea304559b5a8672c2f194dcf.MTHD_edf8dcd6f7604565a9189e17b690fb03()
        }));
        this.AddMember("get_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ebcceea2ea304559b5a8672c2f194dcf.MTHD_2f93d81615a3438197ceb9d0ac25ac75()
        }));
        this.AddMember("set_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ebcceea2ea304559b5a8672c2f194dcf.MTHD_611c6cac11f74ca7a23c0a536a3644bf()
        }));
        this.AddMember("get_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ebcceea2ea304559b5a8672c2f194dcf.MTHD_dd7240ab49ff4119a55b8fa4aed6924b()
        }));
        this.AddMember("set_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ebcceea2ea304559b5a8672c2f194dcf.MTHD_170d21ac2aee420f828d336e20140221()
        }));
        this.AddMember("get_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ebcceea2ea304559b5a8672c2f194dcf.MTHD_99d1cc4833174d57bf740ab627cf7fdb()
        }));
        this.AddMember("set_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ebcceea2ea304559b5a8672c2f194dcf.MTHD_838e0738cee24b61954e69e1871329ce()
        }));
        this.AddMember("get_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ebcceea2ea304559b5a8672c2f194dcf.MTHD_9262af8545ea4eb195709050ded15de8()
        }));
        this.AddMember("set_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ebcceea2ea304559b5a8672c2f194dcf.MTHD_9e41d5bcf7be4110a768886b81ce7d5e()
        }));
        this.AddMember("get_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ebcceea2ea304559b5a8672c2f194dcf.MTHD_69b15425c73244feadcf6d56c341a283()
        }));
        this.AddMember("set_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ebcceea2ea304559b5a8672c2f194dcf.MTHD_bf98b50c7c4942a3b92de2f4ad3576fd()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ebcceea2ea304559b5a8672c2f194dcf.MTHD_4cd90b10f0e446aa93a74fb0f6534e7d()
        }));
        this.AddMember("get_castType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_castType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ebcceea2ea304559b5a8672c2f194dcf.MTHD_2070433bb969444280fdf6276e83d826()
        }));
        this.AddMember("get_damageType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damageType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ebcceea2ea304559b5a8672c2f194dcf.MTHD_a280ad301bcd4c129e7982dadcb8bbde()
        }));
        this.AddMember("get_book", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_book", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ebcceea2ea304559b5a8672c2f194dcf.MTHD_61fdafe337be40729d152414b796cecb()
        }));
        this.AddMember("get_damage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damage", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ebcceea2ea304559b5a8672c2f194dcf.MTHD_b42b293772cd4f999ef13b3e8d556f5a()
        }));
        this.AddMember("get_explosionRadius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_explosionRadius", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ebcceea2ea304559b5a8672c2f194dcf.MTHD_1f95cede7b0546b5bf7e0f25a9a13346()
        }));
        this.AddMember("get_description", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_description", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ebcceea2ea304559b5a8672c2f194dcf.MTHD_3474317bef964f108c8a1cce9a9f6bff()
        }));
        this.AddMember("get_descriptionOnly", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionOnly", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ebcceea2ea304559b5a8672c2f194dcf.MTHD_306e29ff8211459a9b780a7eeb4be6b4()
        }));
        this.AddMember("get_descriptionExtra", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionExtra", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ebcceea2ea304559b5a8672c2f194dcf.MTHD_20dbeee51f01483d93b76540c195a75d()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ebcceea2ea304559b5a8672c2f194dcf.MTHD_a968b140bb9b41b7bbce0595157c037a()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ebcceea2ea304559b5a8672c2f194dcf.MTHD_4fac4717f892491eb1884870d2284a5e()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ebcceea2ea304559b5a8672c2f194dcf.MTHD_9b0703f28c0c4072b1fe380bb64e17f7()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ebcceea2ea304559b5a8672c2f194dcf.MTHD_152fbaced8b247daa1723e51c457727b()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ebcceea2ea304559b5a8672c2f194dcf.MTHD_e4d0054d95e8406cacbc73baf85256ba()
        }));
        this.AddMember("uses", (IMemberDescriptor) new Bridge.TYPE_ebcceea2ea304559b5a8672c2f194dcf.PROP_01d283575fa744b493af8f81ebe6d0b0());
        this.AddMember("maxUses", (IMemberDescriptor) new Bridge.TYPE_ebcceea2ea304559b5a8672c2f194dcf.PROP_3c4a4a5d7fe449678c59d1e5f64a1c19());
        this.AddMember("rechargeTime", (IMemberDescriptor) new Bridge.TYPE_ebcceea2ea304559b5a8672c2f194dcf.PROP_9f91061d5e434d578fdfaa042c632dba());
        this.AddMember("lastTurnFired", (IMemberDescriptor) new Bridge.TYPE_ebcceea2ea304559b5a8672c2f194dcf.PROP_ef5b2957ee30473a8e3b22198dc4b6ee());
        this.AddMember("isPresent", (IMemberDescriptor) new Bridge.TYPE_ebcceea2ea304559b5a8672c2f194dcf.PROP_953af7cb886944ed9bf5f894e06caa53());
        this.AddMember("locked", (IMemberDescriptor) new Bridge.TYPE_ebcceea2ea304559b5a8672c2f194dcf.PROP_7711c57a199b46f89b1332558b076272());
        this.AddMember("turnsTillFirstUse", (IMemberDescriptor) new Bridge.TYPE_ebcceea2ea304559b5a8672c2f194dcf.PROP_db62d9451b87447aa754a85bf1f06787());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_ebcceea2ea304559b5a8672c2f194dcf.PROP_0387cd4e2e7540799bc00c47a1b089be());
        this.AddMember("castType", (IMemberDescriptor) new Bridge.TYPE_ebcceea2ea304559b5a8672c2f194dcf.PROP_a43bc8cbac6340d99d4519a1029f6c81());
        this.AddMember("damageType", (IMemberDescriptor) new Bridge.TYPE_ebcceea2ea304559b5a8672c2f194dcf.PROP_9875ad2d1cf1463dafe9f925443b4622());
        this.AddMember("book", (IMemberDescriptor) new Bridge.TYPE_ebcceea2ea304559b5a8672c2f194dcf.PROP_2bf6a9786484469dbde9af8d0baa91c8());
        this.AddMember("damage", (IMemberDescriptor) new Bridge.TYPE_ebcceea2ea304559b5a8672c2f194dcf.PROP_02e301137ba14c638c7e54802d927847());
        this.AddMember("explosionRadius", (IMemberDescriptor) new Bridge.TYPE_ebcceea2ea304559b5a8672c2f194dcf.PROP_687e7a2572894ff5acfcd91c8b664a48());
        this.AddMember("description", (IMemberDescriptor) new Bridge.TYPE_ebcceea2ea304559b5a8672c2f194dcf.PROP_41c82497880d4de497af92283c420060());
        this.AddMember("descriptionOnly", (IMemberDescriptor) new Bridge.TYPE_ebcceea2ea304559b5a8672c2f194dcf.PROP_38841d3cf5b6493199045d7043de390c());
        this.AddMember("descriptionExtra", (IMemberDescriptor) new Bridge.TYPE_ebcceea2ea304559b5a8672c2f194dcf.PROP_ca06218a138040a89b0b5228876c123b());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_ebcceea2ea304559b5a8672c2f194dcf.PROP_2b99bf2a043441f2b4c05caed7858325());
      }

      private sealed class MTHD_2c74706a93684ee79b7ec12956aae947 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2c74706a93684ee79b7ec12956aae947()
        {
          this.Initialize("get_uses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).uses;
        }
      }

      private sealed class MTHD_b63d04db8bea4ff9a34b64ee2d6e0393 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b63d04db8bea4ff9a34b64ee2d6e0393()
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

      private sealed class MTHD_a6387455fa1a46bda17ddef75e2caaee : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a6387455fa1a46bda17ddef75e2caaee()
        {
          this.Initialize("get_maxUses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).maxUses;
        }
      }

      private sealed class MTHD_edf8dcd6f7604565a9189e17b690fb03 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_edf8dcd6f7604565a9189e17b690fb03()
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

      private sealed class MTHD_2f93d81615a3438197ceb9d0ac25ac75 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2f93d81615a3438197ceb9d0ac25ac75()
        {
          this.Initialize("get_rechargeTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).rechargeTime;
        }
      }

      private sealed class MTHD_611c6cac11f74ca7a23c0a536a3644bf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_611c6cac11f74ca7a23c0a536a3644bf()
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

      private sealed class MTHD_dd7240ab49ff4119a55b8fa4aed6924b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dd7240ab49ff4119a55b8fa4aed6924b()
        {
          this.Initialize("get_lastTurnFired", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).lastTurnFired;
        }
      }

      private sealed class MTHD_170d21ac2aee420f828d336e20140221 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_170d21ac2aee420f828d336e20140221()
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

      private sealed class MTHD_99d1cc4833174d57bf740ab627cf7fdb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_99d1cc4833174d57bf740ab627cf7fdb()
        {
          this.Initialize("get_isPresent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).isPresent;
        }
      }

      private sealed class MTHD_838e0738cee24b61954e69e1871329ce : HardwiredMethodMemberDescriptor
      {
        internal MTHD_838e0738cee24b61954e69e1871329ce()
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

      private sealed class MTHD_9262af8545ea4eb195709050ded15de8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9262af8545ea4eb195709050ded15de8()
        {
          this.Initialize("get_locked", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).locked;
        }
      }

      private sealed class MTHD_9e41d5bcf7be4110a768886b81ce7d5e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9e41d5bcf7be4110a768886b81ce7d5e()
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

      private sealed class MTHD_69b15425c73244feadcf6d56c341a283 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_69b15425c73244feadcf6d56c341a283()
        {
          this.Initialize("get_turnsTillFirstUse", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).turnsTillFirstUse;
        }
      }

      private sealed class MTHD_bf98b50c7c4942a3b92de2f4ad3576fd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bf98b50c7c4942a3b92de2f4ad3576fd()
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

      private sealed class MTHD_4cd90b10f0e446aa93a74fb0f6534e7d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4cd90b10f0e446aa93a74fb0f6534e7d()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class MTHD_2070433bb969444280fdf6276e83d826 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2070433bb969444280fdf6276e83d826()
        {
          this.Initialize("get_castType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class MTHD_a280ad301bcd4c129e7982dadcb8bbde : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a280ad301bcd4c129e7982dadcb8bbde()
        {
          this.Initialize("get_damageType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class MTHD_61fdafe337be40729d152414b796cecb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_61fdafe337be40729d152414b796cecb()
        {
          this.Initialize("get_book", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class MTHD_b42b293772cd4f999ef13b3e8d556f5a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b42b293772cd4f999ef13b3e8d556f5a()
        {
          this.Initialize("get_damage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class MTHD_1f95cede7b0546b5bf7e0f25a9a13346 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1f95cede7b0546b5bf7e0f25a9a13346()
        {
          this.Initialize("get_explosionRadius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class MTHD_3474317bef964f108c8a1cce9a9f6bff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3474317bef964f108c8a1cce9a9f6bff()
        {
          this.Initialize("get_description", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class MTHD_306e29ff8211459a9b780a7eeb4be6b4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_306e29ff8211459a9b780a7eeb4be6b4()
        {
          this.Initialize("get_descriptionOnly", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class MTHD_20dbeee51f01483d93b76540c195a75d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_20dbeee51f01483d93b76540c195a75d()
        {
          this.Initialize("get_descriptionExtra", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class MTHD_a968b140bb9b41b7bbce0595157c037a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a968b140bb9b41b7bbce0595157c037a()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }

      private sealed class MTHD_4fac4717f892491eb1884870d2284a5e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4fac4717f892491eb1884870d2284a5e()
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

      private sealed class MTHD_9b0703f28c0c4072b1fe380bb64e17f7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9b0703f28c0c4072b1fe380bb64e17f7()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_152fbaced8b247daa1723e51c457727b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_152fbaced8b247daa1723e51c457727b()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_e4d0054d95e8406cacbc73baf85256ba : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e4d0054d95e8406cacbc73baf85256ba()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_01d283575fa744b493af8f81ebe6d0b0 : HardwiredMemberDescriptor
      {
        internal PROP_01d283575fa744b493af8f81ebe6d0b0()
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

      private sealed class PROP_3c4a4a5d7fe449678c59d1e5f64a1c19 : HardwiredMemberDescriptor
      {
        internal PROP_3c4a4a5d7fe449678c59d1e5f64a1c19()
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

      private sealed class PROP_9f91061d5e434d578fdfaa042c632dba : HardwiredMemberDescriptor
      {
        internal PROP_9f91061d5e434d578fdfaa042c632dba()
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

      private sealed class PROP_ef5b2957ee30473a8e3b22198dc4b6ee : HardwiredMemberDescriptor
      {
        internal PROP_ef5b2957ee30473a8e3b22198dc4b6ee()
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

      private sealed class PROP_953af7cb886944ed9bf5f894e06caa53 : HardwiredMemberDescriptor
      {
        internal PROP_953af7cb886944ed9bf5f894e06caa53()
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

      private sealed class PROP_7711c57a199b46f89b1332558b076272 : HardwiredMemberDescriptor
      {
        internal PROP_7711c57a199b46f89b1332558b076272()
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

      private sealed class PROP_db62d9451b87447aa754a85bf1f06787 : HardwiredMemberDescriptor
      {
        internal PROP_db62d9451b87447aa754a85bf1f06787()
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

      private sealed class PROP_0387cd4e2e7540799bc00c47a1b089be : HardwiredMemberDescriptor
      {
        internal PROP_0387cd4e2e7540799bc00c47a1b089be()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class PROP_a43bc8cbac6340d99d4519a1029f6c81 : HardwiredMemberDescriptor
      {
        internal PROP_a43bc8cbac6340d99d4519a1029f6c81()
          : base(typeof (CastType), "castType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class PROP_9875ad2d1cf1463dafe9f925443b4622 : HardwiredMemberDescriptor
      {
        internal PROP_9875ad2d1cf1463dafe9f925443b4622()
          : base(typeof (DamageType), "damageType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class PROP_2bf6a9786484469dbde9af8d0baa91c8 : HardwiredMemberDescriptor
      {
        internal PROP_2bf6a9786484469dbde9af8d0baa91c8()
          : base(typeof (BookOf), "book", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class PROP_02e301137ba14c638c7e54802d927847 : HardwiredMemberDescriptor
      {
        internal PROP_02e301137ba14c638c7e54802d927847()
          : base(typeof (int), "damage", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class PROP_687e7a2572894ff5acfcd91c8b664a48 : HardwiredMemberDescriptor
      {
        internal PROP_687e7a2572894ff5acfcd91c8b664a48()
          : base(typeof (int), "explosionRadius", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class PROP_41c82497880d4de497af92283c420060 : HardwiredMemberDescriptor
      {
        internal PROP_41c82497880d4de497af92283c420060()
          : base(typeof (string), "description", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class PROP_38841d3cf5b6493199045d7043de390c : HardwiredMemberDescriptor
      {
        internal PROP_38841d3cf5b6493199045d7043de390c()
          : base(typeof (string), "descriptionOnly", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class PROP_ca06218a138040a89b0b5228876c123b : HardwiredMemberDescriptor
      {
        internal PROP_ca06218a138040a89b0b5228876c123b()
          : base(typeof (string), "descriptionExtra", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class PROP_2b99bf2a043441f2b4c05caed7858325 : HardwiredMemberDescriptor
      {
        internal PROP_2b99bf2a043441f2b4c05caed7858325()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }
    }

    private sealed class TYPE_380049b08eb04537bcc2d046bf3288ad : HardwiredUserDataDescriptor
    {
      internal TYPE_380049b08eb04537bcc2d046bf3288ad()
        : base(typeof (ContainerTower))
      {
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_380049b08eb04537bcc2d046bf3288ad.MTHD_10efebd39c7a49998c0f9fffeb80246e()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_380049b08eb04537bcc2d046bf3288ad.MTHD_1e66cea912154e81b3c0a92dbf5ceb5d()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_380049b08eb04537bcc2d046bf3288ad.MTHD_cfeeb85c514e49b484e4d9786ea15d6b()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_380049b08eb04537bcc2d046bf3288ad.MTHD_e8f1983bc1b14d08b82655e0cb47701a()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_380049b08eb04537bcc2d046bf3288ad.MTHD_d1148f9ad9b642cca941c2d417a4f300()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_380049b08eb04537bcc2d046bf3288ad.MTHD_1fa2c2ec79ef4e7cbb00794ca55c1161()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_380049b08eb04537bcc2d046bf3288ad.MTHD_9915d2c3d111473eb6ea3d6fee1a1fd1()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_380049b08eb04537bcc2d046bf3288ad.MTHD_9fcf3a56e0d94c5b926e6756688a8a91()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_380049b08eb04537bcc2d046bf3288ad.MTHD_d5a3e319036d4e39a0aa2e95cb04b594()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_380049b08eb04537bcc2d046bf3288ad.MTHD_75be7d383267417db69ea40b68193f68()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_380049b08eb04537bcc2d046bf3288ad.MTHD_60dfdb3d6ddf418da9d8516b14dc5b7b()
        }));
        this.AddMember("getType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_380049b08eb04537bcc2d046bf3288ad.MTHD_7b6c8e3ee9d945a1a287a14e90cd8728()
        }));
        this.AddMember("kill", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("kill", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_380049b08eb04537bcc2d046bf3288ad.MTHD_69ec652b7ff44acc9767e5909012eef9()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_380049b08eb04537bcc2d046bf3288ad.MTHD_2b3bfb51ae534dc3a3d05e408d936261()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_380049b08eb04537bcc2d046bf3288ad.MTHD_68b1889161be409d8bf0f12bcaa192a4()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_380049b08eb04537bcc2d046bf3288ad.MTHD_4ded326b6bbb4d2687f16089fee783bb()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_380049b08eb04537bcc2d046bf3288ad.MTHD_40444e0e4ec74b7680081f97b97bc1b3()
        }));
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_380049b08eb04537bcc2d046bf3288ad.PROP_dfb7c0be2f004f198d13579cd5c678c8());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_380049b08eb04537bcc2d046bf3288ad.PROP_3003ab781d244097bcfac8639b2d3146());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_380049b08eb04537bcc2d046bf3288ad.PROP_7d1d8a82170048f1aa4b0ecfb65e0f61());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_380049b08eb04537bcc2d046bf3288ad.PROP_439a893f024b4440bf5e2dcd8341e44b());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_380049b08eb04537bcc2d046bf3288ad.PROP_3752127de4394da0a599773b6a8bf11b());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_380049b08eb04537bcc2d046bf3288ad.PROP_8416b058ab8f440aaa5411e2373d7a60());
      }

      private sealed class MTHD_10efebd39c7a49998c0f9fffeb80246e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_10efebd39c7a49998c0f9fffeb80246e()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).health;
        }
      }

      private sealed class MTHD_1e66cea912154e81b3c0a92dbf5ceb5d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1e66cea912154e81b3c0a92dbf5ceb5d()
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

      private sealed class MTHD_cfeeb85c514e49b484e4d9786ea15d6b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cfeeb85c514e49b484e4d9786ea15d6b()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).maxHealth;
        }
      }

      private sealed class MTHD_e8f1983bc1b14d08b82655e0cb47701a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e8f1983bc1b14d08b82655e0cb47701a()
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

      private sealed class MTHD_d1148f9ad9b642cca941c2d417a4f300 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d1148f9ad9b642cca941c2d417a4f300()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).x;
        }
      }

      private sealed class MTHD_1fa2c2ec79ef4e7cbb00794ca55c1161 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1fa2c2ec79ef4e7cbb00794ca55c1161()
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

      private sealed class MTHD_9915d2c3d111473eb6ea3d6fee1a1fd1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9915d2c3d111473eb6ea3d6fee1a1fd1()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).y;
        }
      }

      private sealed class MTHD_9fcf3a56e0d94c5b926e6756688a8a91 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9fcf3a56e0d94c5b926e6756688a8a91()
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

      private sealed class MTHD_d5a3e319036d4e39a0aa2e95cb04b594 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d5a3e319036d4e39a0aa2e95cb04b594()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).position;
        }
      }

      private sealed class MTHD_75be7d383267417db69ea40b68193f68 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_75be7d383267417db69ea40b68193f68()
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

      private sealed class MTHD_60dfdb3d6ddf418da9d8516b14dc5b7b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_60dfdb3d6ddf418da9d8516b14dc5b7b()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }

      private sealed class MTHD_7b6c8e3ee9d945a1a287a14e90cd8728 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7b6c8e3ee9d945a1a287a14e90cd8728()
        {
          this.Initialize("getType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).getType();
        }
      }

      private sealed class MTHD_69ec652b7ff44acc9767e5909012eef9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_69ec652b7ff44acc9767e5909012eef9()
        {
          this.Initialize("kill", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerTower) obj).kill();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_2b3bfb51ae534dc3a3d05e408d936261 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2b3bfb51ae534dc3a3d05e408d936261()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).GetHashCode();
        }
      }

      private sealed class MTHD_68b1889161be409d8bf0f12bcaa192a4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_68b1889161be409d8bf0f12bcaa192a4()
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

      private sealed class MTHD_4ded326b6bbb4d2687f16089fee783bb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4ded326b6bbb4d2687f16089fee783bb()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_40444e0e4ec74b7680081f97b97bc1b3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_40444e0e4ec74b7680081f97b97bc1b3()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_dfb7c0be2f004f198d13579cd5c678c8 : HardwiredMemberDescriptor
      {
        internal PROP_dfb7c0be2f004f198d13579cd5c678c8()
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

      private sealed class PROP_3003ab781d244097bcfac8639b2d3146 : HardwiredMemberDescriptor
      {
        internal PROP_3003ab781d244097bcfac8639b2d3146()
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

      private sealed class PROP_7d1d8a82170048f1aa4b0ecfb65e0f61 : HardwiredMemberDescriptor
      {
        internal PROP_7d1d8a82170048f1aa4b0ecfb65e0f61()
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

      private sealed class PROP_439a893f024b4440bf5e2dcd8341e44b : HardwiredMemberDescriptor
      {
        internal PROP_439a893f024b4440bf5e2dcd8341e44b()
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

      private sealed class PROP_3752127de4394da0a599773b6a8bf11b : HardwiredMemberDescriptor
      {
        internal PROP_3752127de4394da0a599773b6a8bf11b()
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

      private sealed class PROP_8416b058ab8f440aaa5411e2373d7a60 : HardwiredMemberDescriptor
      {
        internal PROP_8416b058ab8f440aaa5411e2373d7a60()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }
    }

    private sealed class TYPE_5c2cc4680a7a46189a5fad70f1a371fb : HardwiredUserDataDescriptor
    {
      internal TYPE_5c2cc4680a7a46189a5fad70f1a371fb()
        : base(typeof (Educative.Point))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c2cc4680a7a46189a5fad70f1a371fb.MTHD_9070ce3d41e647968405f12b9781dc2d(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c2cc4680a7a46189a5fad70f1a371fb.MTHD_bf47733f911c43f7809c7e1c259f3219()
        }));
        this.AddMember("distance", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("distance", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c2cc4680a7a46189a5fad70f1a371fb.MTHD_8b688f88326c4376ac815813bbe43bc2(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c2cc4680a7a46189a5fad70f1a371fb.MTHD_5142da2fcc9047bda13b1e7918a71628()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c2cc4680a7a46189a5fad70f1a371fb.MTHD_e39da9dd8c3e41ab84eb64d9b95262db()
        }));
        this.AddMember("copy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("copy", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c2cc4680a7a46189a5fad70f1a371fb.MTHD_20a541e6a3b3436e967b9a6123f3b8c9()
        }));
        this.AddMember("normalized", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalized", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c2cc4680a7a46189a5fad70f1a371fb.MTHD_f5968f290c574ac88a6ef66c725285c5()
        }));
        this.AddMember("normalize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalize", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c2cc4680a7a46189a5fad70f1a371fb.MTHD_a9853480a2fc45afa1f8cc6d3f53737b()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c2cc4680a7a46189a5fad70f1a371fb.MTHD_76c5240297284641ab44e4aae61e332c()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c2cc4680a7a46189a5fad70f1a371fb.MTHD_f90246cce37d4b70a78fb8e7acd6c40b()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c2cc4680a7a46189a5fad70f1a371fb.MTHD_9b8e533bffe14012ae2d00d4871e9b58()
        }));
        this.AddMember("op_Subtraction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Subtraction", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c2cc4680a7a46189a5fad70f1a371fb.MTHD_69c2e5ef2bd9411da784cc06943dff6c(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c2cc4680a7a46189a5fad70f1a371fb.MTHD_a5546472c5fe4a1a830cce62e8673b7d()
        }));
        this.AddMember("op_Addition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Addition", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c2cc4680a7a46189a5fad70f1a371fb.MTHD_6fa6b9203da54ba0a6dd2dcf68a05c7b(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c2cc4680a7a46189a5fad70f1a371fb.MTHD_36bfc7bf67b946dbbf64a2b75d059269()
        }));
        this.AddMember("op_Multiply", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Multiply", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c2cc4680a7a46189a5fad70f1a371fb.MTHD_f04b86b7cec24e1eaae70856b43ae1f1(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c2cc4680a7a46189a5fad70f1a371fb.MTHD_2590468885b7413fa306bb10165cba6f()
        }));
        this.AddMember("op_Division", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Division", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c2cc4680a7a46189a5fad70f1a371fb.MTHD_38940530d2184976a2566248e7dc8c99(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c2cc4680a7a46189a5fad70f1a371fb.MTHD_b715498d1ff2444492f90d71d8fccddc()
        }));
        this.AddMember("op_Modulus", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Modulus", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c2cc4680a7a46189a5fad70f1a371fb.MTHD_e6b53055a4f543aebeb39a465cd7816d(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c2cc4680a7a46189a5fad70f1a371fb.MTHD_0b8f61c698e34ab5a00ab06fd09a6b6b()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c2cc4680a7a46189a5fad70f1a371fb.MTHD_2a25aa42d75e48a8b530fe7fac641fbe()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c2cc4680a7a46189a5fad70f1a371fb.MTHD_1df42a3a58e74844948ab469fb027ead()
        }));
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_5c2cc4680a7a46189a5fad70f1a371fb.FLDV_3def8a740ad149dcbad907e919fffbb5());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_5c2cc4680a7a46189a5fad70f1a371fb.FLDV_dcc1e59e35de4854ba2db6b880516695());
      }

      private sealed class MTHD_9070ce3d41e647968405f12b9781dc2d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9070ce3d41e647968405f12b9781dc2d()
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

      private sealed class MTHD_bf47733f911c43f7809c7e1c259f3219 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bf47733f911c43f7809c7e1c259f3219()
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

      private sealed class MTHD_8b688f88326c4376ac815813bbe43bc2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8b688f88326c4376ac815813bbe43bc2()
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

      private sealed class MTHD_5142da2fcc9047bda13b1e7918a71628 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5142da2fcc9047bda13b1e7918a71628()
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

      private sealed class MTHD_e39da9dd8c3e41ab84eb64d9b95262db : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e39da9dd8c3e41ab84eb64d9b95262db()
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

      private sealed class MTHD_20a541e6a3b3436e967b9a6123f3b8c9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_20a541e6a3b3436e967b9a6123f3b8c9()
        {
          this.Initialize("copy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).copy();
        }
      }

      private sealed class MTHD_f5968f290c574ac88a6ef66c725285c5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f5968f290c574ac88a6ef66c725285c5()
        {
          this.Initialize("normalized", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).normalized();
        }
      }

      private sealed class MTHD_a9853480a2fc45afa1f8cc6d3f53737b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a9853480a2fc45afa1f8cc6d3f53737b()
        {
          this.Initialize("normalize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((Educative.Point) obj).normalize();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_76c5240297284641ab44e4aae61e332c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_76c5240297284641ab44e4aae61e332c()
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

      private sealed class MTHD_f90246cce37d4b70a78fb8e7acd6c40b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f90246cce37d4b70a78fb8e7acd6c40b()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).GetHashCode();
        }
      }

      private sealed class MTHD_9b8e533bffe14012ae2d00d4871e9b58 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9b8e533bffe14012ae2d00d4871e9b58()
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

      private sealed class MTHD_69c2e5ef2bd9411da784cc06943dff6c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_69c2e5ef2bd9411da784cc06943dff6c()
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

      private sealed class MTHD_a5546472c5fe4a1a830cce62e8673b7d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a5546472c5fe4a1a830cce62e8673b7d()
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

      private sealed class MTHD_6fa6b9203da54ba0a6dd2dcf68a05c7b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6fa6b9203da54ba0a6dd2dcf68a05c7b()
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

      private sealed class MTHD_36bfc7bf67b946dbbf64a2b75d059269 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_36bfc7bf67b946dbbf64a2b75d059269()
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

      private sealed class MTHD_f04b86b7cec24e1eaae70856b43ae1f1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f04b86b7cec24e1eaae70856b43ae1f1()
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

      private sealed class MTHD_2590468885b7413fa306bb10165cba6f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2590468885b7413fa306bb10165cba6f()
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

      private sealed class MTHD_38940530d2184976a2566248e7dc8c99 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_38940530d2184976a2566248e7dc8c99()
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

      private sealed class MTHD_b715498d1ff2444492f90d71d8fccddc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b715498d1ff2444492f90d71d8fccddc()
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

      private sealed class MTHD_e6b53055a4f543aebeb39a465cd7816d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e6b53055a4f543aebeb39a465cd7816d()
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

      private sealed class MTHD_0b8f61c698e34ab5a00ab06fd09a6b6b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0b8f61c698e34ab5a00ab06fd09a6b6b()
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

      private sealed class MTHD_2a25aa42d75e48a8b530fe7fac641fbe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2a25aa42d75e48a8b530fe7fac641fbe()
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

      private sealed class MTHD_1df42a3a58e74844948ab469fb027ead : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1df42a3a58e74844948ab469fb027ead()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_3def8a740ad149dcbad907e919fffbb5 : HardwiredMemberDescriptor
      {
        internal FLDV_3def8a740ad149dcbad907e919fffbb5()
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

      private sealed class FLDV_dcc1e59e35de4854ba2db6b880516695 : HardwiredMemberDescriptor
      {
        internal FLDV_dcc1e59e35de4854ba2db6b880516695()
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

    private sealed class TYPE_3feece40c5564920a6006ae6833b073a : HardwiredUserDataDescriptor
    {
      internal TYPE_3feece40c5564920a6006ae6833b073a()
        : base(typeof (Summon))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3feece40c5564920a6006ae6833b073a.MTHD_3b5ddb416fe2444ca0af1a44c9e8b477()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3feece40c5564920a6006ae6833b073a.MTHD_14fdb817de1349c090bad15b65e4ff1e()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3feece40c5564920a6006ae6833b073a.MTHD_24f9427b6cbb47d09c04a59952392517()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3feece40c5564920a6006ae6833b073a.MTHD_22eee5f1c46548bd82daa4a855eccc1a()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3feece40c5564920a6006ae6833b073a.MTHD_ece7cc5641024eb5a66514e9229311a4()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3feece40c5564920a6006ae6833b073a.MTHD_e5a49492a3d74164b98edf47b2c2d896()
        }));
        this.AddMember("spell", (IMemberDescriptor) new Bridge.TYPE_3feece40c5564920a6006ae6833b073a.FLDV_b5a932f44ab14e9099d758913e60df1c());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_3feece40c5564920a6006ae6833b073a.FLDV_301752c586054d6caa45a8da564be857());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_3feece40c5564920a6006ae6833b073a.FLDV_58cf1ad253ab41a29473d311c5cdd5eb());
        this.AddMember("onPlayersPanel", (IMemberDescriptor) new Bridge.TYPE_3feece40c5564920a6006ae6833b073a.FLDV_bb77921d657f4c4d9be739e27ae313cb());
        this.AddMember("useAI", (IMemberDescriptor) new Bridge.TYPE_3feece40c5564920a6006ae6833b073a.FLDV_be531716218748659985b1070e9cb482());
        this.AddMember("no_AI_still_use_turn", (IMemberDescriptor) new Bridge.TYPE_3feece40c5564920a6006ae6833b073a.FLDV_775f9de530514a9898fbe7e0daf2ed18());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_3feece40c5564920a6006ae6833b073a.FLDV_57c3fc5e2fc34e3e8d4ced4d6c813fad());
        this.AddMember("playSound", (IMemberDescriptor) new Bridge.TYPE_3feece40c5564920a6006ae6833b073a.FLDV_aba15481909341ceaa77ad8763cde9a7());
        this.AddMember("prestige", (IMemberDescriptor) new Bridge.TYPE_3feece40c5564920a6006ae6833b073a.FLDV_cf123d4d74e240d8bd47c7abfb6a2f84());
        this.AddMember("colors", (IMemberDescriptor) new Bridge.TYPE_3feece40c5564920a6006ae6833b073a.FLDV_2279b68cc452486f90009ee3e85cd38a());
        this.AddMember("spells", (IMemberDescriptor) new Bridge.TYPE_3feece40c5564920a6006ae6833b073a.FLDV_dacd6e095cb3432aab09979c1e9023fd());
        this.AddMember("outfit", (IMemberDescriptor) new Bridge.TYPE_3feece40c5564920a6006ae6833b073a.FLDV_55f0953b6a8e4d3797e23e77272b9b86());
        this.AddMember("elemental", (IMemberDescriptor) new Bridge.TYPE_3feece40c5564920a6006ae6833b073a.FLDV_bdd2b6bd3aa7456586b25f6b09a2bc8a());
      }

      private sealed class MTHD_3b5ddb416fe2444ca0af1a44c9e8b477 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3b5ddb416fe2444ca0af1a44c9e8b477()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new Summon();
        }
      }

      private sealed class MTHD_14fdb817de1349c090bad15b65e4ff1e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_14fdb817de1349c090bad15b65e4ff1e()
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

      private sealed class MTHD_24f9427b6cbb47d09c04a59952392517 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_24f9427b6cbb47d09c04a59952392517()
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

      private sealed class MTHD_22eee5f1c46548bd82daa4a855eccc1a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_22eee5f1c46548bd82daa4a855eccc1a()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_ece7cc5641024eb5a66514e9229311a4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ece7cc5641024eb5a66514e9229311a4()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_e5a49492a3d74164b98edf47b2c2d896 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e5a49492a3d74164b98edf47b2c2d896()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_b5a932f44ab14e9099d758913e60df1c : HardwiredMemberDescriptor
      {
        internal FLDV_b5a932f44ab14e9099d758913e60df1c()
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

      private sealed class FLDV_301752c586054d6caa45a8da564be857 : HardwiredMemberDescriptor
      {
        internal FLDV_301752c586054d6caa45a8da564be857()
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

      private sealed class FLDV_58cf1ad253ab41a29473d311c5cdd5eb : HardwiredMemberDescriptor
      {
        internal FLDV_58cf1ad253ab41a29473d311c5cdd5eb()
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

      private sealed class FLDV_bb77921d657f4c4d9be739e27ae313cb : HardwiredMemberDescriptor
      {
        internal FLDV_bb77921d657f4c4d9be739e27ae313cb()
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

      private sealed class FLDV_be531716218748659985b1070e9cb482 : HardwiredMemberDescriptor
      {
        internal FLDV_be531716218748659985b1070e9cb482()
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

      private sealed class FLDV_775f9de530514a9898fbe7e0daf2ed18 : HardwiredMemberDescriptor
      {
        internal FLDV_775f9de530514a9898fbe7e0daf2ed18()
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

      private sealed class FLDV_57c3fc5e2fc34e3e8d4ced4d6c813fad : HardwiredMemberDescriptor
      {
        internal FLDV_57c3fc5e2fc34e3e8d4ced4d6c813fad()
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

      private sealed class FLDV_aba15481909341ceaa77ad8763cde9a7 : HardwiredMemberDescriptor
      {
        internal FLDV_aba15481909341ceaa77ad8763cde9a7()
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

      private sealed class FLDV_cf123d4d74e240d8bd47c7abfb6a2f84 : HardwiredMemberDescriptor
      {
        internal FLDV_cf123d4d74e240d8bd47c7abfb6a2f84()
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

      private sealed class FLDV_2279b68cc452486f90009ee3e85cd38a : HardwiredMemberDescriptor
      {
        internal FLDV_2279b68cc452486f90009ee3e85cd38a()
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

      private sealed class FLDV_dacd6e095cb3432aab09979c1e9023fd : HardwiredMemberDescriptor
      {
        internal FLDV_dacd6e095cb3432aab09979c1e9023fd()
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

      private sealed class FLDV_55f0953b6a8e4d3797e23e77272b9b86 : HardwiredMemberDescriptor
      {
        internal FLDV_55f0953b6a8e4d3797e23e77272b9b86()
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

      private sealed class FLDV_bdd2b6bd3aa7456586b25f6b09a2bc8a : HardwiredMemberDescriptor
      {
        internal FLDV_bdd2b6bd3aa7456586b25f6b09a2bc8a()
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

    private sealed class TYPE_eb91b4b5592d44f5a83ae798a9de1655 : HardwiredUserDataDescriptor
    {
      internal TYPE_eb91b4b5592d44f5a83ae798a9de1655()
        : base(typeof (UIElement))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_2510eb4c08a14d9db599cb4f43c211b9()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_08cb25e36ff14a7aa51b4fdbf4fd407e()
        }));
        this.AddMember("get_visible", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_visible", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_dfc78580fe2c4a9383e3cc418a74bdc0()
        }));
        this.AddMember("set_visible", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_visible", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_f14a8e84da4f49d7aa6c76b9c1cca10a()
        }));
        this.AddMember("get_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_be675a3139a04a018b051bbdb0d0bb2c()
        }));
        this.AddMember("set_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_67fecfd276554c5c83a18aeb4cd54697()
        }));
        this.AddMember("get_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_99a405e600bd49758bdc60743a98cb4c()
        }));
        this.AddMember("set_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_f5c27183a52e4e4f80674c9d944e63ea()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_dc62bd1bac374330b95df5b712323880()
        }));
        this.AddMember("set_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_696ecab95a7340748bca28432bef418d()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_05886863a4b7419d9d785fe50a630de4()
        }));
        this.AddMember("set_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_0729990a39c34ede96bf0d02d3e2efa6()
        }));
        this.AddMember("get_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_d4aa50def5a14aecb32d4e3da94fc2dc()
        }));
        this.AddMember("set_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_cdb30faa524a4cd98f833fd5506a5c97()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_302b1d24150041d5adfdbbe67c8f8cca()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_eee97849c0dd4336a0f18a657be1581a()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_84ad7ae4734141d5a034b8912979a678()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_b50f66dc09e3468a964501cf6cc2d3fc()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_bc350408ff8d47b38091b02bdbf035ec()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_5d34273fba6a407f88e352835744202a()
        }));
        this.AddMember("get_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_7ca54635fd924dbb95f461d8c58622a3()
        }));
        this.AddMember("set_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_09696c759e744a6ea6c3e8c1f8791350()
        }));
        this.AddMember("get_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_c2de83fa7ff7421a91f37e4893f928a4()
        }));
        this.AddMember("set_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_b0d39f1fbd634deaa04acb769bf707a1()
        }));
        this.AddMember("get_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_f77ad7c09d1b40dd8e8109d24fb9cf8f()
        }));
        this.AddMember("set_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_e3f4e762fcd64d9ab62f2686c66654f1()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_ec640d7f554842a0890abdc7cc7ae2c1()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_52b9252017ba42bd89f170406a1deb5f()
        }));
        this.AddMember("get_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_ee2793ec3ba8419b86f89a49ce2b9f01()
        }));
        this.AddMember("set_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_791d172c8f7740c4ba9f3494c28b88fc()
        }));
        this.AddMember("get_onClick2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_0cca5f4bd1b84d6e84a8f3461aeb636e()
        }));
        this.AddMember("set_onClick2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_3be96649a66848679d6e5441b346a169()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_ed0ea35098a744cfb055da87a2874f91()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_8bb9afa70a2d42fa95379304777f7dc2()
        }));
        this.AddMember("get_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_9d919a55216c46cba3db539c430af2b8()
        }));
        this.AddMember("set_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_a66ccb64f77a4766976ab7264d0841b8()
        }));
        this.AddMember("get_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_6db64856b0cc49df9137449be6e0df70()
        }));
        this.AddMember("set_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_31af9656471742b4bc328a2f5e43c8eb()
        }));
        this.AddMember("get_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_567039acd1dc4e41a75214bc0edbf1f9()
        }));
        this.AddMember("set_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_dae2ed0e88924957ac71bd1da4254da7()
        }));
        this.AddMember("get_textColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_c4e53e9201cb40bfb6c352594ba6d196()
        }));
        this.AddMember("set_textColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_7fcbaa314dc24b8c8f9ecb28dc667df5()
        }));
        this.AddMember("get_highlightColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_highlightColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_2f943afe90f64e348be0ff80a398c6c0()
        }));
        this.AddMember("set_highlightColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_highlightColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_b5ccb02dedae4a2792e82a1e310d2a40()
        }));
        this.AddMember("get_highlightColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_highlightColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_1b0b8cb71b9d43d2ac43a27e35d2e0e5()
        }));
        this.AddMember("set_highlightColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_highlightColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_8d7c10836cc84537bbcc8a797dd2456c()
        }));
        this.AddMember("get_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_86e66e0a5ab34c60889aa013d2f63263()
        }));
        this.AddMember("set_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_fb0e59c5ebdb4747af01f335cddb8ce9()
        }));
        this.AddMember("get_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_153a574308f64927bf41c758bdcf7595()
        }));
        this.AddMember("set_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_970031d84ba7455a91e982ed61186411()
        }));
        this.AddMember("activateInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("activateInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_8271478369f14482bd88ca56523727f9()
        }));
        this.AddMember("createUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createUI", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_c3a0a33dd4094ee29e7e2b2e9a6e2236()
        }));
        this.AddMember("createInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_437744babdd745cd913d804930675dd6()
        }));
        this.AddMember("duplicate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("duplicate", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_07fa08efdaf84375bf60d5bbd89e6cf6()
        }));
        this.AddMember("destroyHierarchy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroyHierarchy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_ee47976fbe314f009003bf47ed413963()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_5033a12545e74c1d8075400f8a8b565e()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_a8449ac3f42e445290f1a446a662217f()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_57fb05daf04d4831990dc9e4d11a4fcf()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_685ae3884f604453bac89790926a6e61()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.MTHD_016a513aeb89419987f4b4b991db76a7()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.PROP_c97c8df647ff4c4b9087f829e3432ed1());
        this.AddMember("visible", (IMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.PROP_d0ef9b94f3694e41960192b3d8ee1893());
        this.AddMember("graphic", (IMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.PROP_de0e689686ea4544833179f28eb516fb());
        this.AddMember("anchor", (IMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.PROP_75c0af5eee2741f388da3e598d21c6c6());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.PROP_229ecb49dc6f4f248678405bc0aca4fd());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.PROP_61287101816d4c408b3339624017934f());
        this.AddMember("size", (IMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.PROP_43d2339b8d504f479b834dc8f3afbe57());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.PROP_017abe4f581a4883ba63fab6aa286864());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.PROP_b8204d14a43e4c01bb592d1836a2e069());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.PROP_af205887a1244f33990607aec223500f());
        this.AddMember("pivot_x", (IMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.PROP_7e9921262d2144fd811827701eb6ed09());
        this.AddMember("pivot_y", (IMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.PROP_08ab762f07194a278ba697225b920ea9());
        this.AddMember("pivot", (IMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.PROP_d47ade0888ab46e0b913f91c3f64b40c());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.PROP_980db4132c5d4e688e8321ea87507a80());
        this.AddMember("onClick", (IMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.PROP_15f1e58fb6f24ca9b857ffcc675dd934());
        this.AddMember("onClick2", (IMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.PROP_c30835353b5b4300b4a57346ecc3dae1());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.PROP_6a73288cc2b445619ae2c270d0742359());
        this.AddMember("color2", (IMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.PROP_d9c85e1043d14c9eb73a7d8a4230f031());
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.PROP_7884e152208c49669833bbee8de9a1af());
        this.AddMember("textColor", (IMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.PROP_0a803d786f5d498bab753935988612a3());
        this.AddMember("textColor2", (IMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.PROP_fe91eb19d81c43159c811a1438583619());
        this.AddMember("highlightColor", (IMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.PROP_68e0e60bffca443db1ce8bc69bb8ffc7());
        this.AddMember("highlightColor2", (IMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.PROP_273d681e90f845c3a1cbf6d4cbfc49df());
        this.AddMember("textStyle", (IMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.PROP_c2f66743fb104d47b36bb840d101e1e5());
        this.AddMember("textSize", (IMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.PROP_b179013ef32f471e98563121a80a78ca());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.FLDV_0403135fd68049b8be2ff5bd92d4304b());
        this.AddMember("clickID", (IMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.FLDV_a5c442abc42442e1ab414266f0b85d61());
        this.AddMember("clickDestroy", (IMemberDescriptor) new Bridge.TYPE_eb91b4b5592d44f5a83ae798a9de1655.FLDV_6ed273b2b7e54c55855da8511f836b07());
      }

      private sealed class MTHD_2510eb4c08a14d9db599cb4f43c211b9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2510eb4c08a14d9db599cb4f43c211b9()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new UIElement();
        }
      }

      private sealed class MTHD_08cb25e36ff14a7aa51b4fdbf4fd407e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_08cb25e36ff14a7aa51b4fdbf4fd407e()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class MTHD_dfc78580fe2c4a9383e3cc418a74bdc0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dfc78580fe2c4a9383e3cc418a74bdc0()
        {
          this.Initialize("get_visible", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).visible;
        }
      }

      private sealed class MTHD_f14a8e84da4f49d7aa6c76b9c1cca10a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f14a8e84da4f49d7aa6c76b9c1cca10a()
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

      private sealed class MTHD_be675a3139a04a018b051bbdb0d0bb2c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_be675a3139a04a018b051bbdb0d0bb2c()
        {
          this.Initialize("get_graphic", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return ((UIElement) obj).graphic;
        }
      }

      private sealed class MTHD_67fecfd276554c5c83a18aeb4cd54697 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_67fecfd276554c5c83a18aeb4cd54697()
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

      private sealed class MTHD_99a405e600bd49758bdc60743a98cb4c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_99a405e600bd49758bdc60743a98cb4c()
        {
          this.Initialize("get_anchor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).anchor;
        }
      }

      private sealed class MTHD_f5c27183a52e4e4f80674c9d944e63ea : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f5c27183a52e4e4f80674c9d944e63ea()
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

      private sealed class MTHD_dc62bd1bac374330b95df5b712323880 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dc62bd1bac374330b95df5b712323880()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).width;
        }
      }

      private sealed class MTHD_696ecab95a7340748bca28432bef418d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_696ecab95a7340748bca28432bef418d()
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

      private sealed class MTHD_05886863a4b7419d9d785fe50a630de4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_05886863a4b7419d9d785fe50a630de4()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).height;
        }
      }

      private sealed class MTHD_0729990a39c34ede96bf0d02d3e2efa6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0729990a39c34ede96bf0d02d3e2efa6()
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

      private sealed class MTHD_d4aa50def5a14aecb32d4e3da94fc2dc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d4aa50def5a14aecb32d4e3da94fc2dc()
        {
          this.Initialize("get_size", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).size;
        }
      }

      private sealed class MTHD_cdb30faa524a4cd98f833fd5506a5c97 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cdb30faa524a4cd98f833fd5506a5c97()
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

      private sealed class MTHD_302b1d24150041d5adfdbbe67c8f8cca : HardwiredMethodMemberDescriptor
      {
        internal MTHD_302b1d24150041d5adfdbbe67c8f8cca()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).x;
        }
      }

      private sealed class MTHD_eee97849c0dd4336a0f18a657be1581a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eee97849c0dd4336a0f18a657be1581a()
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

      private sealed class MTHD_84ad7ae4734141d5a034b8912979a678 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_84ad7ae4734141d5a034b8912979a678()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).y;
        }
      }

      private sealed class MTHD_b50f66dc09e3468a964501cf6cc2d3fc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b50f66dc09e3468a964501cf6cc2d3fc()
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

      private sealed class MTHD_bc350408ff8d47b38091b02bdbf035ec : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bc350408ff8d47b38091b02bdbf035ec()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).position;
        }
      }

      private sealed class MTHD_5d34273fba6a407f88e352835744202a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5d34273fba6a407f88e352835744202a()
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

      private sealed class MTHD_7ca54635fd924dbb95f461d8c58622a3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7ca54635fd924dbb95f461d8c58622a3()
        {
          this.Initialize("get_pivot_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_x;
        }
      }

      private sealed class MTHD_09696c759e744a6ea6c3e8c1f8791350 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_09696c759e744a6ea6c3e8c1f8791350()
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

      private sealed class MTHD_c2de83fa7ff7421a91f37e4893f928a4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c2de83fa7ff7421a91f37e4893f928a4()
        {
          this.Initialize("get_pivot_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_y;
        }
      }

      private sealed class MTHD_b0d39f1fbd634deaa04acb769bf707a1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b0d39f1fbd634deaa04acb769bf707a1()
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

      private sealed class MTHD_f77ad7c09d1b40dd8e8109d24fb9cf8f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f77ad7c09d1b40dd8e8109d24fb9cf8f()
        {
          this.Initialize("get_pivot", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot;
        }
      }

      private sealed class MTHD_e3f4e762fcd64d9ab62f2686c66654f1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e3f4e762fcd64d9ab62f2686c66654f1()
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

      private sealed class MTHD_ec640d7f554842a0890abdc7cc7ae2c1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ec640d7f554842a0890abdc7cc7ae2c1()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).angle;
        }
      }

      private sealed class MTHD_52b9252017ba42bd89f170406a1deb5f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_52b9252017ba42bd89f170406a1deb5f()
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

      private sealed class MTHD_ee2793ec3ba8419b86f89a49ce2b9f01 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ee2793ec3ba8419b86f89a49ce2b9f01()
        {
          this.Initialize("get_onClick", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick;
        }
      }

      private sealed class MTHD_791d172c8f7740c4ba9f3494c28b88fc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_791d172c8f7740c4ba9f3494c28b88fc()
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

      private sealed class MTHD_0cca5f4bd1b84d6e84a8f3461aeb636e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0cca5f4bd1b84d6e84a8f3461aeb636e()
        {
          this.Initialize("get_onClick2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick2;
        }
      }

      private sealed class MTHD_3be96649a66848679d6e5441b346a169 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3be96649a66848679d6e5441b346a169()
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

      private sealed class MTHD_ed0ea35098a744cfb055da87a2874f91 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ed0ea35098a744cfb055da87a2874f91()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color;
        }
      }

      private sealed class MTHD_8bb9afa70a2d42fa95379304777f7dc2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8bb9afa70a2d42fa95379304777f7dc2()
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

      private sealed class MTHD_9d919a55216c46cba3db539c430af2b8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9d919a55216c46cba3db539c430af2b8()
        {
          this.Initialize("get_color2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color2;
        }
      }

      private sealed class MTHD_a66ccb64f77a4766976ab7264d0841b8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a66ccb64f77a4766976ab7264d0841b8()
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

      private sealed class MTHD_6db64856b0cc49df9137449be6e0df70 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6db64856b0cc49df9137449be6e0df70()
        {
          this.Initialize("get_text", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).text;
        }
      }

      private sealed class MTHD_31af9656471742b4bc328a2f5e43c8eb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_31af9656471742b4bc328a2f5e43c8eb()
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

      private sealed class MTHD_567039acd1dc4e41a75214bc0edbf1f9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_567039acd1dc4e41a75214bc0edbf1f9()
        {
          this.Initialize("get_textColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor;
        }
      }

      private sealed class MTHD_dae2ed0e88924957ac71bd1da4254da7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dae2ed0e88924957ac71bd1da4254da7()
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

      private sealed class MTHD_c4e53e9201cb40bfb6c352594ba6d196 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c4e53e9201cb40bfb6c352594ba6d196()
        {
          this.Initialize("get_textColor2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor2;
        }
      }

      private sealed class MTHD_7fcbaa314dc24b8c8f9ecb28dc667df5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7fcbaa314dc24b8c8f9ecb28dc667df5()
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

      private sealed class MTHD_2f943afe90f64e348be0ff80a398c6c0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2f943afe90f64e348be0ff80a398c6c0()
        {
          this.Initialize("get_highlightColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).highlightColor;
        }
      }

      private sealed class MTHD_b5ccb02dedae4a2792e82a1e310d2a40 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b5ccb02dedae4a2792e82a1e310d2a40()
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

      private sealed class MTHD_1b0b8cb71b9d43d2ac43a27e35d2e0e5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1b0b8cb71b9d43d2ac43a27e35d2e0e5()
        {
          this.Initialize("get_highlightColor2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).highlightColor2;
        }
      }

      private sealed class MTHD_8d7c10836cc84537bbcc8a797dd2456c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8d7c10836cc84537bbcc8a797dd2456c()
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

      private sealed class MTHD_86e66e0a5ab34c60889aa013d2f63263 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_86e66e0a5ab34c60889aa013d2f63263()
        {
          this.Initialize("get_textStyle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textStyle;
        }
      }

      private sealed class MTHD_fb0e59c5ebdb4747af01f335cddb8ce9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fb0e59c5ebdb4747af01f335cddb8ce9()
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

      private sealed class MTHD_153a574308f64927bf41c758bdcf7595 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_153a574308f64927bf41c758bdcf7595()
        {
          this.Initialize("get_textSize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textSize;
        }
      }

      private sealed class MTHD_970031d84ba7455a91e982ed61186411 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_970031d84ba7455a91e982ed61186411()
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

      private sealed class MTHD_8271478369f14482bd88ca56523727f9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8271478369f14482bd88ca56523727f9()
        {
          this.Initialize("activateInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).activateInput();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_c3a0a33dd4094ee29e7e2b2e9a6e2236 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c3a0a33dd4094ee29e7e2b2e9a6e2236()
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

      private sealed class MTHD_437744babdd745cd913d804930675dd6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_437744babdd745cd913d804930675dd6()
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

      private sealed class MTHD_07fa08efdaf84375bf60d5bbd89e6cf6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_07fa08efdaf84375bf60d5bbd89e6cf6()
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

      private sealed class MTHD_ee47976fbe314f009003bf47ed413963 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ee47976fbe314f009003bf47ed413963()
        {
          this.Initialize("destroyHierarchy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroyHierarchy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_5033a12545e74c1d8075400f8a8b565e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5033a12545e74c1d8075400f8a8b565e()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_a8449ac3f42e445290f1a446a662217f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a8449ac3f42e445290f1a446a662217f()
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

      private sealed class MTHD_57fb05daf04d4831990dc9e4d11a4fcf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_57fb05daf04d4831990dc9e4d11a4fcf()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_685ae3884f604453bac89790926a6e61 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_685ae3884f604453bac89790926a6e61()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_016a513aeb89419987f4b4b991db76a7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_016a513aeb89419987f4b4b991db76a7()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_c97c8df647ff4c4b9087f829e3432ed1 : HardwiredMemberDescriptor
      {
        internal PROP_c97c8df647ff4c4b9087f829e3432ed1()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class PROP_d0ef9b94f3694e41960192b3d8ee1893 : HardwiredMemberDescriptor
      {
        internal PROP_d0ef9b94f3694e41960192b3d8ee1893()
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

      private sealed class PROP_de0e689686ea4544833179f28eb516fb : HardwiredMemberDescriptor
      {
        internal PROP_de0e689686ea4544833179f28eb516fb()
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

      private sealed class PROP_75c0af5eee2741f388da3e598d21c6c6 : HardwiredMemberDescriptor
      {
        internal PROP_75c0af5eee2741f388da3e598d21c6c6()
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

      private sealed class PROP_229ecb49dc6f4f248678405bc0aca4fd : HardwiredMemberDescriptor
      {
        internal PROP_229ecb49dc6f4f248678405bc0aca4fd()
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

      private sealed class PROP_61287101816d4c408b3339624017934f : HardwiredMemberDescriptor
      {
        internal PROP_61287101816d4c408b3339624017934f()
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

      private sealed class PROP_43d2339b8d504f479b834dc8f3afbe57 : HardwiredMemberDescriptor
      {
        internal PROP_43d2339b8d504f479b834dc8f3afbe57()
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

      private sealed class PROP_017abe4f581a4883ba63fab6aa286864 : HardwiredMemberDescriptor
      {
        internal PROP_017abe4f581a4883ba63fab6aa286864()
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

      private sealed class PROP_b8204d14a43e4c01bb592d1836a2e069 : HardwiredMemberDescriptor
      {
        internal PROP_b8204d14a43e4c01bb592d1836a2e069()
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

      private sealed class PROP_af205887a1244f33990607aec223500f : HardwiredMemberDescriptor
      {
        internal PROP_af205887a1244f33990607aec223500f()
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

      private sealed class PROP_7e9921262d2144fd811827701eb6ed09 : HardwiredMemberDescriptor
      {
        internal PROP_7e9921262d2144fd811827701eb6ed09()
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

      private sealed class PROP_08ab762f07194a278ba697225b920ea9 : HardwiredMemberDescriptor
      {
        internal PROP_08ab762f07194a278ba697225b920ea9()
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

      private sealed class PROP_d47ade0888ab46e0b913f91c3f64b40c : HardwiredMemberDescriptor
      {
        internal PROP_d47ade0888ab46e0b913f91c3f64b40c()
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

      private sealed class PROP_980db4132c5d4e688e8321ea87507a80 : HardwiredMemberDescriptor
      {
        internal PROP_980db4132c5d4e688e8321ea87507a80()
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

      private sealed class PROP_15f1e58fb6f24ca9b857ffcc675dd934 : HardwiredMemberDescriptor
      {
        internal PROP_15f1e58fb6f24ca9b857ffcc675dd934()
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

      private sealed class PROP_c30835353b5b4300b4a57346ecc3dae1 : HardwiredMemberDescriptor
      {
        internal PROP_c30835353b5b4300b4a57346ecc3dae1()
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

      private sealed class PROP_6a73288cc2b445619ae2c270d0742359 : HardwiredMemberDescriptor
      {
        internal PROP_6a73288cc2b445619ae2c270d0742359()
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

      private sealed class PROP_d9c85e1043d14c9eb73a7d8a4230f031 : HardwiredMemberDescriptor
      {
        internal PROP_d9c85e1043d14c9eb73a7d8a4230f031()
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

      private sealed class PROP_7884e152208c49669833bbee8de9a1af : HardwiredMemberDescriptor
      {
        internal PROP_7884e152208c49669833bbee8de9a1af()
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

      private sealed class PROP_0a803d786f5d498bab753935988612a3 : HardwiredMemberDescriptor
      {
        internal PROP_0a803d786f5d498bab753935988612a3()
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

      private sealed class PROP_fe91eb19d81c43159c811a1438583619 : HardwiredMemberDescriptor
      {
        internal PROP_fe91eb19d81c43159c811a1438583619()
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

      private sealed class PROP_68e0e60bffca443db1ce8bc69bb8ffc7 : HardwiredMemberDescriptor
      {
        internal PROP_68e0e60bffca443db1ce8bc69bb8ffc7()
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

      private sealed class PROP_273d681e90f845c3a1cbf6d4cbfc49df : HardwiredMemberDescriptor
      {
        internal PROP_273d681e90f845c3a1cbf6d4cbfc49df()
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

      private sealed class PROP_c2f66743fb104d47b36bb840d101e1e5 : HardwiredMemberDescriptor
      {
        internal PROP_c2f66743fb104d47b36bb840d101e1e5()
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

      private sealed class PROP_b179013ef32f471e98563121a80a78ca : HardwiredMemberDescriptor
      {
        internal PROP_b179013ef32f471e98563121a80a78ca()
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

      private sealed class FLDV_0403135fd68049b8be2ff5bd92d4304b : HardwiredMemberDescriptor
      {
        internal FLDV_0403135fd68049b8be2ff5bd92d4304b()
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

      private sealed class FLDV_a5c442abc42442e1ab414266f0b85d61 : HardwiredMemberDescriptor
      {
        internal FLDV_a5c442abc42442e1ab414266f0b85d61()
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

      private sealed class FLDV_6ed273b2b7e54c55855da8511f836b07 : HardwiredMemberDescriptor
      {
        internal FLDV_6ed273b2b7e54c55855da8511f836b07()
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

    private sealed class TYPE_a13ed638311d4fecbe84f4f4bdebb71c : HardwiredUserDataDescriptor
    {
      internal TYPE_a13ed638311d4fecbe84f4f4bdebb71c()
        : base(typeof (MyPoll.Item))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a13ed638311d4fecbe84f4f4bdebb71c.MTHD_1bab98da1ad94e4c85805656d7cdd83d()
        }));
        this.AddMember("addAnswer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addAnswer", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a13ed638311d4fecbe84f4f4bdebb71c.MTHD_dc505bb6daa4416b8c4eb7b22da9fc14()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a13ed638311d4fecbe84f4f4bdebb71c.MTHD_d21fe8db520a48ed928c295480f272c0()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a13ed638311d4fecbe84f4f4bdebb71c.MTHD_45744c4301714645b887217b0d26b03d()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a13ed638311d4fecbe84f4f4bdebb71c.MTHD_ab13213d4243436a86716bd8e8d8ed24()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a13ed638311d4fecbe84f4f4bdebb71c.MTHD_ea2615c6f8ad48eea44a5a3ceac7bb5c()
        }));
        this.AddMember("question", (IMemberDescriptor) new Bridge.TYPE_a13ed638311d4fecbe84f4f4bdebb71c.FLDV_53689f8be0364a85994f6039a208331f());
        this.AddMember("multipleSelection", (IMemberDescriptor) new Bridge.TYPE_a13ed638311d4fecbe84f4f4bdebb71c.FLDV_546fc3284bdb4208a38d64f012b91a67());
        this.AddMember("requiresAnswer", (IMemberDescriptor) new Bridge.TYPE_a13ed638311d4fecbe84f4f4bdebb71c.FLDV_4450633e03374aa2811a3be9e2608c65());
        this.AddMember("answers", (IMemberDescriptor) new Bridge.TYPE_a13ed638311d4fecbe84f4f4bdebb71c.FLDV_355e066e19f14f3abaea0d2774319f23());
      }

      private sealed class MTHD_1bab98da1ad94e4c85805656d7cdd83d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1bab98da1ad94e4c85805656d7cdd83d()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Item();
        }
      }

      private sealed class MTHD_dc505bb6daa4416b8c4eb7b22da9fc14 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dc505bb6daa4416b8c4eb7b22da9fc14()
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

      private sealed class MTHD_d21fe8db520a48ed928c295480f272c0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d21fe8db520a48ed928c295480f272c0()
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

      private sealed class MTHD_45744c4301714645b887217b0d26b03d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_45744c4301714645b887217b0d26b03d()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_ab13213d4243436a86716bd8e8d8ed24 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ab13213d4243436a86716bd8e8d8ed24()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_ea2615c6f8ad48eea44a5a3ceac7bb5c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ea2615c6f8ad48eea44a5a3ceac7bb5c()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_53689f8be0364a85994f6039a208331f : HardwiredMemberDescriptor
      {
        internal FLDV_53689f8be0364a85994f6039a208331f()
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

      private sealed class FLDV_546fc3284bdb4208a38d64f012b91a67 : HardwiredMemberDescriptor
      {
        internal FLDV_546fc3284bdb4208a38d64f012b91a67()
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

      private sealed class FLDV_4450633e03374aa2811a3be9e2608c65 : HardwiredMemberDescriptor
      {
        internal FLDV_4450633e03374aa2811a3be9e2608c65()
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

      private sealed class FLDV_355e066e19f14f3abaea0d2774319f23 : HardwiredMemberDescriptor
      {
        internal FLDV_355e066e19f14f3abaea0d2774319f23()
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

    private sealed class TYPE_8e65862ba35948b28dffc9d6cad328c5 : HardwiredUserDataDescriptor
    {
      internal TYPE_8e65862ba35948b28dffc9d6cad328c5()
        : base(typeof (MyPoll.Answer))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8e65862ba35948b28dffc9d6cad328c5.MTHD_f20646f4e88d4a3081805d23834bcb3d()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8e65862ba35948b28dffc9d6cad328c5.MTHD_530b417520b04a169b8bf2016190cde0()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8e65862ba35948b28dffc9d6cad328c5.MTHD_bd3f9f2bfc3e42c8b9373b1746c1d5ab()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8e65862ba35948b28dffc9d6cad328c5.MTHD_3af0d4ef01b9409fada90163cc5fd087()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8e65862ba35948b28dffc9d6cad328c5.MTHD_c9e15372e29148e9aaf7d51266acf6f5()
        }));
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_8e65862ba35948b28dffc9d6cad328c5.FLDV_a7c274d09dee47b990ec68e3186a1776());
        this.AddMember("allowUserInput", (IMemberDescriptor) new Bridge.TYPE_8e65862ba35948b28dffc9d6cad328c5.FLDV_e45c2319edbb4ea8933fff6e61458d97());
        this.AddMember("checkable", (IMemberDescriptor) new Bridge.TYPE_8e65862ba35948b28dffc9d6cad328c5.FLDV_3e9697cd30cf4809aae53ff9f3b29477());
        this.AddMember("userInput", (IMemberDescriptor) new Bridge.TYPE_8e65862ba35948b28dffc9d6cad328c5.FLDV_32dc0ff1c14d4979b03fc5c2075f12fb());
        this.AddMember("isChecked", (IMemberDescriptor) new Bridge.TYPE_8e65862ba35948b28dffc9d6cad328c5.FLDV_3f280005505f40cab66e7d5be8c44fa5());
      }

      private sealed class MTHD_f20646f4e88d4a3081805d23834bcb3d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f20646f4e88d4a3081805d23834bcb3d()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Answer();
        }
      }

      private sealed class MTHD_530b417520b04a169b8bf2016190cde0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_530b417520b04a169b8bf2016190cde0()
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

      private sealed class MTHD_bd3f9f2bfc3e42c8b9373b1746c1d5ab : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bd3f9f2bfc3e42c8b9373b1746c1d5ab()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_3af0d4ef01b9409fada90163cc5fd087 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3af0d4ef01b9409fada90163cc5fd087()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_c9e15372e29148e9aaf7d51266acf6f5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c9e15372e29148e9aaf7d51266acf6f5()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_a7c274d09dee47b990ec68e3186a1776 : HardwiredMemberDescriptor
      {
        internal FLDV_a7c274d09dee47b990ec68e3186a1776()
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

      private sealed class FLDV_e45c2319edbb4ea8933fff6e61458d97 : HardwiredMemberDescriptor
      {
        internal FLDV_e45c2319edbb4ea8933fff6e61458d97()
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

      private sealed class FLDV_3e9697cd30cf4809aae53ff9f3b29477 : HardwiredMemberDescriptor
      {
        internal FLDV_3e9697cd30cf4809aae53ff9f3b29477()
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

      private sealed class FLDV_32dc0ff1c14d4979b03fc5c2075f12fb : HardwiredMemberDescriptor
      {
        internal FLDV_32dc0ff1c14d4979b03fc5c2075f12fb()
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

      private sealed class FLDV_3f280005505f40cab66e7d5be8c44fa5 : HardwiredMemberDescriptor
      {
        internal FLDV_3f280005505f40cab66e7d5be8c44fa5()
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

    private sealed class TYPE_bc494dbd60854f36ba970509b389e7be : HardwiredUserDataDescriptor
    {
      internal TYPE_bc494dbd60854f36ba970509b389e7be()
        : base(typeof (MyPoll))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bc494dbd60854f36ba970509b389e7be.MTHD_380367d64f6e4420a416ae0b8df48e52()
        }));
        this.AddMember("GetQuestionsAsString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetQuestionsAsString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bc494dbd60854f36ba970509b389e7be.MTHD_65b67934c3444b83ae33653a500b669a()
        }));
        this.AddMember("SanitizeResponses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("SanitizeResponses", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bc494dbd60854f36ba970509b389e7be.MTHD_0e24bfc2f6de478f83219dd43e33e656()
        }));
        this.AddMember("addItem", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addItem", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bc494dbd60854f36ba970509b389e7be.MTHD_34a29d33dd8d4c4aaa6f1bbbc2c98296()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bc494dbd60854f36ba970509b389e7be.MTHD_0086ee3b0b364e51bb21599037670f99()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bc494dbd60854f36ba970509b389e7be.MTHD_2423bbf792ad4658bc1bce2543d3a789()
        }));
        this.AddMember("fromString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fromString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bc494dbd60854f36ba970509b389e7be.MTHD_926d5b5ce3aa4256b3fb8d1bdc1c4a8a()
        }));
        this.AddMember("sendToServer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("sendToServer", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bc494dbd60854f36ba970509b389e7be.MTHD_ffb22f969b614388abed833164cd04ff()
        }));
        this.AddMember("closePoll", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("closePoll", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bc494dbd60854f36ba970509b389e7be.MTHD_25abaefc832f44c0af49281ebcbdf666()
        }));
        this.AddMember("test", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("test", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bc494dbd60854f36ba970509b389e7be.MTHD_42224b68e05347a3b4893bfcbe2c77f0()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bc494dbd60854f36ba970509b389e7be.MTHD_b47db8615802418fb4fa193ff3f4f35a()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bc494dbd60854f36ba970509b389e7be.MTHD_70c4fa598f20454db9c28331d6fb9d10()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bc494dbd60854f36ba970509b389e7be.MTHD_7e1832c27f15468d84dd67ab4ac7c75d()
        }));
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_bc494dbd60854f36ba970509b389e7be.FLDV_6d401291f9424ecc900be9ab2a64725e());
        this.AddMember("id", (IMemberDescriptor) new Bridge.TYPE_bc494dbd60854f36ba970509b389e7be.FLDV_c9dfee73c8d645b69c894bebfc28651a());
        this.AddMember("items", (IMemberDescriptor) new Bridge.TYPE_bc494dbd60854f36ba970509b389e7be.FLDV_a93b4160b42948a181c1dbf50e9192e4());
        this.AddMember("isPublic", (IMemberDescriptor) new Bridge.TYPE_bc494dbd60854f36ba970509b389e7be.FLDV_c5c4e6bc7d624792adbbbf01ef52039d());
        this.AddMember("MsgRetrieve", (IMemberDescriptor) new Bridge.TYPE_bc494dbd60854f36ba970509b389e7be.FLDV_1ccf8a188e1a4b31bcfa7d0d01d2b879());
        this.AddMember("MsgSubmit", (IMemberDescriptor) new Bridge.TYPE_bc494dbd60854f36ba970509b389e7be.FLDV_6826469b9aa24fa4a741758dbb9fd8a2());
        this.AddMember("MsgCreate", (IMemberDescriptor) new Bridge.TYPE_bc494dbd60854f36ba970509b389e7be.FLDV_28157b5fcebe408cb6a94c323910e0d5());
        this.AddMember("MsgResults", (IMemberDescriptor) new Bridge.TYPE_bc494dbd60854f36ba970509b389e7be.FLDV_a5ff93adc7414379805b5ea15bcb0973());
        this.AddMember("Item", (IMemberDescriptor) new Bridge.TYPE_bc494dbd60854f36ba970509b389e7be.DVAL_145915e3d1aa4a029e4c65bce76591da());
        this.AddMember("Answer", (IMemberDescriptor) new Bridge.TYPE_bc494dbd60854f36ba970509b389e7be.DVAL_808cdcde7477455391704ea2b95ab219());
      }

      private sealed class MTHD_380367d64f6e4420a416ae0b8df48e52 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_380367d64f6e4420a416ae0b8df48e52()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll();
        }
      }

      private sealed class MTHD_65b67934c3444b83ae33653a500b669a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_65b67934c3444b83ae33653a500b669a()
        {
          this.Initialize("GetQuestionsAsString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).GetQuestionsAsString();
        }
      }

      private sealed class MTHD_0e24bfc2f6de478f83219dd43e33e656 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0e24bfc2f6de478f83219dd43e33e656()
        {
          this.Initialize("SanitizeResponses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).SanitizeResponses();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_34a29d33dd8d4c4aaa6f1bbbc2c98296 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_34a29d33dd8d4c4aaa6f1bbbc2c98296()
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

      private sealed class MTHD_0086ee3b0b364e51bb21599037670f99 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0086ee3b0b364e51bb21599037670f99()
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

      private sealed class MTHD_2423bbf792ad4658bc1bce2543d3a789 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2423bbf792ad4658bc1bce2543d3a789()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).ToString();
        }
      }

      private sealed class MTHD_926d5b5ce3aa4256b3fb8d1bdc1c4a8a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_926d5b5ce3aa4256b3fb8d1bdc1c4a8a()
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

      private sealed class MTHD_ffb22f969b614388abed833164cd04ff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ffb22f969b614388abed833164cd04ff()
        {
          this.Initialize("sendToServer", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).sendToServer();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_25abaefc832f44c0af49281ebcbdf666 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_25abaefc832f44c0af49281ebcbdf666()
        {
          this.Initialize("closePoll", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          MyPoll.closePoll();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_42224b68e05347a3b4893bfcbe2c77f0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_42224b68e05347a3b4893bfcbe2c77f0()
        {
          this.Initialize("test", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).test();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_b47db8615802418fb4fa193ff3f4f35a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b47db8615802418fb4fa193ff3f4f35a()
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

      private sealed class MTHD_70c4fa598f20454db9c28331d6fb9d10 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_70c4fa598f20454db9c28331d6fb9d10()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_7e1832c27f15468d84dd67ab4ac7c75d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7e1832c27f15468d84dd67ab4ac7c75d()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_6d401291f9424ecc900be9ab2a64725e : HardwiredMemberDescriptor
      {
        internal FLDV_6d401291f9424ecc900be9ab2a64725e()
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

      private sealed class FLDV_c9dfee73c8d645b69c894bebfc28651a : HardwiredMemberDescriptor
      {
        internal FLDV_c9dfee73c8d645b69c894bebfc28651a()
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

      private sealed class FLDV_a93b4160b42948a181c1dbf50e9192e4 : HardwiredMemberDescriptor
      {
        internal FLDV_a93b4160b42948a181c1dbf50e9192e4()
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

      private sealed class FLDV_c5c4e6bc7d624792adbbbf01ef52039d : HardwiredMemberDescriptor
      {
        internal FLDV_c5c4e6bc7d624792adbbbf01ef52039d()
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

      private sealed class FLDV_1ccf8a188e1a4b31bcfa7d0d01d2b879 : HardwiredMemberDescriptor
      {
        internal FLDV_1ccf8a188e1a4b31bcfa7d0d01d2b879()
          : base(typeof (byte), "MsgRetrieve", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 1;
        }
      }

      private sealed class FLDV_6826469b9aa24fa4a741758dbb9fd8a2 : HardwiredMemberDescriptor
      {
        internal FLDV_6826469b9aa24fa4a741758dbb9fd8a2()
          : base(typeof (byte), "MsgSubmit", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 2;
        }
      }

      private sealed class FLDV_28157b5fcebe408cb6a94c323910e0d5 : HardwiredMemberDescriptor
      {
        internal FLDV_28157b5fcebe408cb6a94c323910e0d5()
          : base(typeof (byte), "MsgCreate", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 3;
        }
      }

      private sealed class FLDV_a5ff93adc7414379805b5ea15bcb0973 : HardwiredMemberDescriptor
      {
        internal FLDV_a5ff93adc7414379805b5ea15bcb0973()
          : base(typeof (byte), "MsgResults", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 4;
        }
      }

      private sealed class DVAL_145915e3d1aa4a029e4c65bce76591da : DynValueMemberDescriptor
      {
        internal DVAL_145915e3d1aa4a029e4c65bce76591da()
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

      private sealed class DVAL_808cdcde7477455391704ea2b95ab219 : DynValueMemberDescriptor
      {
        internal DVAL_808cdcde7477455391704ea2b95ab219()
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

    private sealed class TYPE_304ef9aaeeb04ae19c4893dc48996cc4 : HardwiredUserDataDescriptor
    {
      internal TYPE_304ef9aaeeb04ae19c4893dc48996cc4()
        : base(typeof (LuaColor))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_304ef9aaeeb04ae19c4893dc48996cc4.MTHD_9e4cbc37e26b405d8e12188265488619()
        }));
        this.AddMember("toHex", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("toHex", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_304ef9aaeeb04ae19c4893dc48996cc4.MTHD_11cacd964a2241e2b5455a7f7437e2bd()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_304ef9aaeeb04ae19c4893dc48996cc4.MTHD_96ecb283347e47609e891a410934cef1(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_304ef9aaeeb04ae19c4893dc48996cc4.MTHD_157927d85b134a05bc75c9058192be56()
        }));
        this.AddMember("From", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("From", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_304ef9aaeeb04ae19c4893dc48996cc4.MTHD_d1ef28aa4681407eb964f00d4647d446(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_304ef9aaeeb04ae19c4893dc48996cc4.MTHD_153f894bdd6d488fb0609ef46196d052()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_304ef9aaeeb04ae19c4893dc48996cc4.MTHD_548d2e54cf1c44b0b085973be2b291f7()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_304ef9aaeeb04ae19c4893dc48996cc4.MTHD_becc7c2c77e04ef5b6641a3616dd5c30()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_304ef9aaeeb04ae19c4893dc48996cc4.MTHD_47e2ca125fd846ac91198b4ce99428d6()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_304ef9aaeeb04ae19c4893dc48996cc4.MTHD_d04261916fb04d07a1bdf75426b67302()
        }));
        this.AddMember("r", (IMemberDescriptor) new Bridge.TYPE_304ef9aaeeb04ae19c4893dc48996cc4.FLDV_ba1313a16da64e888f1be4d17ce59d0d());
        this.AddMember("g", (IMemberDescriptor) new Bridge.TYPE_304ef9aaeeb04ae19c4893dc48996cc4.FLDV_ecf186795ad94d3ab49c87bacd4f5615());
        this.AddMember("b", (IMemberDescriptor) new Bridge.TYPE_304ef9aaeeb04ae19c4893dc48996cc4.FLDV_14c6d7f6e321490e93d1841e6702cbbc());
        this.AddMember("a", (IMemberDescriptor) new Bridge.TYPE_304ef9aaeeb04ae19c4893dc48996cc4.FLDV_3e26ae305ea2493f94c7e8494b254bb7());
        this.AddMember("white", (IMemberDescriptor) new Bridge.TYPE_304ef9aaeeb04ae19c4893dc48996cc4.FLDV_fedfa36519e94321beec50485b00d32b());
      }

      private sealed class MTHD_9e4cbc37e26b405d8e12188265488619 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9e4cbc37e26b405d8e12188265488619()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new LuaColor();
        }
      }

      private sealed class MTHD_11cacd964a2241e2b5455a7f7437e2bd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_11cacd964a2241e2b5455a7f7437e2bd()
        {
          this.Initialize("toHex", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((LuaColor) obj).toHex();
        }
      }

      private sealed class MTHD_96ecb283347e47609e891a410934cef1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_96ecb283347e47609e891a410934cef1()
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

      private sealed class MTHD_157927d85b134a05bc75c9058192be56 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_157927d85b134a05bc75c9058192be56()
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

      private sealed class MTHD_d1ef28aa4681407eb964f00d4647d446 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d1ef28aa4681407eb964f00d4647d446()
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

      private sealed class MTHD_153f894bdd6d488fb0609ef46196d052 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_153f894bdd6d488fb0609ef46196d052()
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

      private sealed class MTHD_548d2e54cf1c44b0b085973be2b291f7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_548d2e54cf1c44b0b085973be2b291f7()
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

      private sealed class MTHD_becc7c2c77e04ef5b6641a3616dd5c30 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_becc7c2c77e04ef5b6641a3616dd5c30()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_47e2ca125fd846ac91198b4ce99428d6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_47e2ca125fd846ac91198b4ce99428d6()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_d04261916fb04d07a1bdf75426b67302 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d04261916fb04d07a1bdf75426b67302()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_ba1313a16da64e888f1be4d17ce59d0d : HardwiredMemberDescriptor
      {
        internal FLDV_ba1313a16da64e888f1be4d17ce59d0d()
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

      private sealed class FLDV_ecf186795ad94d3ab49c87bacd4f5615 : HardwiredMemberDescriptor
      {
        internal FLDV_ecf186795ad94d3ab49c87bacd4f5615()
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

      private sealed class FLDV_14c6d7f6e321490e93d1841e6702cbbc : HardwiredMemberDescriptor
      {
        internal FLDV_14c6d7f6e321490e93d1841e6702cbbc()
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

      private sealed class FLDV_3e26ae305ea2493f94c7e8494b254bb7 : HardwiredMemberDescriptor
      {
        internal FLDV_3e26ae305ea2493f94c7e8494b254bb7()
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

      private sealed class FLDV_fedfa36519e94321beec50485b00d32b : HardwiredMemberDescriptor
      {
        internal FLDV_fedfa36519e94321beec50485b00d32b()
          : base(typeof (LuaColor), "white", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) LuaColor.white;
        }
      }
    }

    private sealed class TYPE_787cdbfbaab04778b19baa42d837f9d7 : HardwiredUserDataDescriptor
    {
      internal TYPE_787cdbfbaab04778b19baa42d837f9d7()
        : base(typeof (TalkOptions))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_787cdbfbaab04778b19baa42d837f9d7.MTHD_fef181fbf2ed45d291818740994403ca()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_787cdbfbaab04778b19baa42d837f9d7.MTHD_ede4b2b43057497a8217312232bafda3()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_787cdbfbaab04778b19baa42d837f9d7.MTHD_bf464f96ec4c4edaa314740b1ea98373()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_787cdbfbaab04778b19baa42d837f9d7.MTHD_7000aaa3db7a45e1bc72432db961998d()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_787cdbfbaab04778b19baa42d837f9d7.MTHD_2e9961374ffe417d9f49487a936493ea()
        }));
      }

      private sealed class MTHD_fef181fbf2ed45d291818740994403ca : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fef181fbf2ed45d291818740994403ca()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new TalkOptions();
        }
      }

      private sealed class MTHD_ede4b2b43057497a8217312232bafda3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ede4b2b43057497a8217312232bafda3()
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

      private sealed class MTHD_bf464f96ec4c4edaa314740b1ea98373 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bf464f96ec4c4edaa314740b1ea98373()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_7000aaa3db7a45e1bc72432db961998d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7000aaa3db7a45e1bc72432db961998d()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_2e9961374ffe417d9f49487a936493ea : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2e9961374ffe417d9f49487a936493ea()
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
