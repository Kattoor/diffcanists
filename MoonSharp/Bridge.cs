
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
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_a186232bac854b86a433503df4ff73ea());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_cf43a204e20041809c6e7d79b34fd08b());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_c9da66a41b9d417c9edad978d8331c68());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_c4239e7ded4f4d59b2e495047a1d506c());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_06427f3d3a4a4e97850ef2efd61b00f9());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_9895a7e27519452db7053d978fd602c1());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_1498ee2782fc4da1bbead9fdf846dc5b());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_05764d9421764dc6984ab8f27fc81933());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_dfac35578a7f43daa5f82e095b757e81());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_2abb75c395434c51b2322b250ee76115());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_e1a0a8db181845459db07c281337d748());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_1fda633c4075459fa0b69ffa3fe90954());
    }

    private sealed class TYPE_e28a1a6e046441ebb7024875dbfd8670 : HardwiredUserDataDescriptor
    {
      internal TYPE_e28a1a6e046441ebb7024875dbfd8670()
        : base(typeof (ContainerGame))
      {
        this.AddMember("getUser", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getUser", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_ebec18f6dbdc4b8abde3957df1fd16e3()
        }));
        this.AddMember("getPlayers", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayers", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_8b16261eb4114b1781a01583eedf1e1c()
        }));
        this.AddMember("getPlayerCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayerCount", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_5bb5dae4df8b45aabd498279d39dbbca()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_4e14cb90423b45bb96857aef46b9efe8()
        }));
        this.AddMember("findCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_9a06232842674f16bc708aa892af899b()
        }));
        this.AddMember("findEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findEffectors", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_6a3e9f0af1334416a3a8e40a9cb5c5a0()
        }));
        this.AddMember("LineCast", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCast", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_6676dee30e7e4a3092b5b39263162e85()
        }));
        this.AddMember("LineCastOnlyCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_c8f63acd58f7439dbde0fad0dad57016()
        }));
        this.AddMember("LineCastOnlyTerrain", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyTerrain", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_38b815e78e644139b868f32050da0149()
        }));
        this.AddMember("ShowInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ShowInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_6b600d9ecd8a4f908a0f72c27d109f45()
        }));
        this.AddMember("hideInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("hideInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_6a3c46ff23f04eaf824f9956fb9f7f8d()
        }));
        this.AddMember("Talk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Talk", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_ab905d8b4bbf4eeb8f87475bd7b63c0b()
        }));
        this.AddMember("get_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_74b36dae45054d75ad261da96e070cbb()
        }));
        this.AddMember("set_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_fad4d9b1b5684ac1aa9d46b095a551a5()
        }));
        this.AddMember("get_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_f198f01c0a404260829f43277448acea()
        }));
        this.AddMember("set_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_d3e3ca43d418483db7688dd0716a91ed()
        }));
        this.AddMember("get_totalTimeElapsed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_totalTimeElapsed", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_a983eedbe54d452898d404b72afc67f2()
        }));
        this.AddMember("get_turnTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnTime", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_804441966aec4b42bf1c3b08982816bb()
        }));
        this.AddMember("get_frame", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frame", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_2013f6f0f2a4438f9be3bbad3c22dc0a()
        }));
        this.AddMember("random", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("random", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_547912044cd64e63bd8dfa5c51579506()
        }));
        this.AddMember("get_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_9a786d9e35cd44f89892f3a4cdc18e03()
        }));
        this.AddMember("set_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_2845de8f8b834dccbc1a5f9168d0e41c()
        }));
        this.AddMember("get_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_4a490f592c064aa78e23761e86b8edee()
        }));
        this.AddMember("set_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_ea6bb5ae9a1d468c84d547dcabdcbe6b()
        }));
        this.AddMember("get_allowMinionMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMinionMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_7a78e331246c4a84b936c0809c02f865()
        }));
        this.AddMember("set_allowMinionMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMinionMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_b603d2cca8014a2bb32a9bcf20ab5296()
        }));
        this.AddMember("get_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_4ae7efd1a8ee4abfb33297bbb2c000ee()
        }));
        this.AddMember("set_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_c39ccb5fd7894683a78dc5679c29c779()
        }));
        this.AddMember("get_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_9384f5d5c1934be4b75b41d34a7729a8()
        }));
        this.AddMember("set_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_e2aa2c1beee04a25b4af1212daeb4469()
        }));
        this.AddMember("get_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_3be76dc281c54602a9fd87bd60fec755()
        }));
        this.AddMember("set_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_4b4264cad54e46978697c821cfa83b22()
        }));
        this.AddMember("get_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_9e255146d8aa4ae7aca5600ed645adc5()
        }));
        this.AddMember("set_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_53f6e8907b50454981a067452e5f450f()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_ca1919b4906046be9733c1c50d278c35()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_598e45e7946b4125b7d2982e3608b7f7()
        }));
        this.AddMember("get_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_33cfebc59abd405690e923615fd49c20()
        }));
        this.AddMember("set_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_b99871aa462c4aeaa16c442f3dc3eddc()
        }));
        this.AddMember("get_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_581821684c3d494c9f18d1c88575924d()
        }));
        this.AddMember("set_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_0925574a0df940558a96cd9dbb249951()
        }));
        this.AddMember("get_waiting", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waiting", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_0227f6db10964833a24738d6d89a368e()
        }));
        this.AddMember("get_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_c6e3532c4a924f8fbbcab6dc4bad4832()
        }));
        this.AddMember("set_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_1b29fd463c2c42e7a79a9555cdaeb61a()
        }));
        this.AddMember("get_busy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_busy", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_c247df3cad7e4cf1b4fbb0b685a84cb8()
        }));
        this.AddMember("get_ongoing", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_ongoing", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_2286928922ee4cf6b50f5bac6ff9d435()
        }));
        this.AddMember("get_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_efe1b2e698b545939b1b914d087aaddc()
        }));
        this.AddMember("set_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_f9cac42239504184a9f1273bb673b779()
        }));
        this.AddMember("get_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_d0b239137d054540a9b15dab45480629()
        }));
        this.AddMember("set_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_005dbe2dd78d41f795db8ba32dab691f()
        }));
        this.AddMember("get_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_08e92556ed6a467a9473560ba2bcd248()
        }));
        this.AddMember("set_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_49a1b914817149e2b3f57ee20ba1dd3f()
        }));
        this.AddMember("get_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_731d8387bdd5430c962bd4fc18dcd751()
        }));
        this.AddMember("set_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_fa6535b6e5a14e7db1deac71e74b1ba2()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_753741206d0c4ff09881c515717f7440()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_d72de34b07b049038333358bc86aa148()
        }));
        this.AddMember("get_mousePosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mousePosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_cbe51d930e06459aaf4702ab4400c497()
        }));
        this.AddMember("get_mouseOverUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mouseOverUI", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_a5038d90cea447aab1b22047b9ad2991()
        }));
        this.AddMember("worldToCanvas", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("worldToCanvas", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_cae47e93eb154ce187e4ab0743a7e524()
        }));
        this.AddMember("canvasToWorld", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("canvasToWorld", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_e212f5b3d7d54c35ba45d7a452a6e39b()
        }));
        this.AddMember("get_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_46c9c9ffc86449fdb43902b2f684b193()
        }));
        this.AddMember("set_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_8dfad19e529b4eb29ee17fceed04e9ea()
        }));
        this.AddMember("get_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_2c12d873444d4de5b0be062aef58f9d1()
        }));
        this.AddMember("set_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_abf31a1210ef42a7a08efc4a87f53ef6()
        }));
        this.AddMember("getMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_9f2a74ab992c419199a000299a6d02f5()
        }));
        this.AddMember("setMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_5e3f88fad30a439ba2529f80dd8b60eb()
        }));
        this.AddMember("Dispose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Dispose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_7443343021d34844b2fa8d61c38114f5()
        }));
        this.AddMember("drawImage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawImage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_5a3d7ad72c124424be27f61edd94aa18()
        }));
        this.AddMember("drawRectangle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawRectangle", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_35be6c178db94f008798ff8242d2a9ac()
        }));
        this.AddMember("drawEllipseOutline", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipseOutline", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_a9402ff1481342169dc8fdb3fa101826()
        }));
        this.AddMember("drawEllipse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipse", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_f028f69990854ded805b6c1ea756efcf()
        }));
        this.AddMember("blit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_750a2aefd5724d998bd26fa9e78ca1ea()
        }));
        this.AddMember("blitRotate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blitRotate", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_1353869d72874a0192f669101e190550()
        }));
        this.AddMember("applyDraw", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("applyDraw", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_010fe4e2751f438cb9ad5dbceb06e3e5()
        }));
        this.AddMember("get_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_fd092e87aa2b487cbaee1df36b7dbcd7()
        }));
        this.AddMember("set_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_bcdf7ffb9f7f408198ea15231bdd7beb()
        }));
        this.AddMember("get_isUsingTouchControls", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isUsingTouchControls", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_6819bb93324b4c13aff8e48aa3dfdab3()
        }));
        this.AddMember("clientRefreshSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clientRefreshSpells", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_9a13924565c547cc866c7126cd20de2c()
        }));
        this.AddMember("startCoroutine", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("startCoroutine", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_3e668afb4e214a958777edda8c35a340()
        }));
        this.AddMember("devCommand", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("devCommand", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_4ab10b4829d94717b9c905f3745d0cec()
        }));
        this.AddMember("win", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("win", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_49224660829949f6b4fa954e681af808()
        }));
        this.AddMember("lose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("lose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_b04b97f5af974a2e9a73efb04e3cdc11()
        }));
        this.AddMember("nextTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("nextTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_8ca80ce897f9428ba9f29473a8063aca()
        }));
        this.AddMember("resetMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("resetMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_1ad38e339ddc4cf6badd24bf486258d6()
        }));
        this.AddMember("clearMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_a42b14d9ee574ebbb8beeadf7e90f5ff()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_9fd70e51623e4b5e9011a6cb99397987()
        }));
        this.AddMember("getSpellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellEnum", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_3bb58934781949d180d62cd6112ccb3e()
        }));
        this.AddMember("getSpellName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_dbceafb4532c4a13878c4a163e1eb12e()
        }));
        this.AddMember("getMapID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapID", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_a5c764f217fb407c86b8862c273e5d1c()
        }));
        this.AddMember("getMapRealName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapRealName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_ac1897c7fede45f081bf568a24fe3128()
        }));
        this.AddMember("getMapShortName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapShortName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_154bdc239adb466baedb8e402952a66e()
        }));
        this.AddMember("getArmageddonName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getArmageddonName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_a554cc61f33942b1af28d93ad346fec4()
        }));
        this.AddMember("panCamera", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("panCamera", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_35e2bd32e8f44328b9bdb2ecb331594d()
        }));
        this.AddMember("cameraFollow", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("cameraFollow", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_ce08adfa5caa47e3adedbe0a8963d1ef()
        }));
        this.AddMember("getInputString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getInputString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_bd4e592c8d44491ab1c83655886bd1f5()
        }));
        this.AddMember("get_screenWidth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenWidth", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_7426354e6c0d451cb96625db12d4dff2()
        }));
        this.AddMember("get_screenHeight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenHeight", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_557976d4aab14a549a51c353bc7755ed()
        }));
        this.AddMember("createCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createCreature", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_db70b93a40c94a17b0e2cf879e4e622c()
        }));
        this.AddMember("clearIndicators", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearIndicators", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_e27bb3f1c943484796495c92a83fa4c7()
        }));
        this.AddMember("createIndicator", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createIndicator", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_578b1a8fbf8a471c8ba762f6993627f5(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_5e3f2aacefd349758b0c0b9db42b5602()
        }));
        this.AddMember("getKeyBinds", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getKeyBinds", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_b531571e456c4e8fad0b1948fd42f4c9()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_49e1b769b5b245e2a977dde9b0c3fdfe()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_b47639fa73e3445fb12b89e51aabfed3()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_e6898f0cbb4c43908d72e9bc87aa981a()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.MTHD_db8c18f06a5a463aaf3f97ce99ccd6a2()
        }));
        this.AddMember("turn", (IMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.PROP_c0888de292974ee5b2d4c023ed4520ed());
        this.AddMember("timeLimit", (IMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.PROP_bf621c5402b84b149843c350464b011e());
        this.AddMember("totalTimeElapsed", (IMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.PROP_fefc217c961d4a72918e70e9e1e2eb2d());
        this.AddMember("turnTime", (IMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.PROP_93790358ab3e4a9f930a8a09fc26769e());
        this.AddMember("frame", (IMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.PROP_84529daa57c144f096df7f0892a55977());
        this.AddMember("winOnDeath", (IMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.PROP_43e23b091fe543f19a95ddc170868d53());
        this.AddMember("allowMovement", (IMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.PROP_a39f706b07a24a689d130fbb1fa7c028());
        this.AddMember("allowMinionMovement", (IMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.PROP_01f0adb9e91f482b8bdb02d2d232aa4b());
        this.AddMember("allowInput", (IMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.PROP_2b6bd48dd26d4706a443a35580d02377());
        this.AddMember("allowCallbacks", (IMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.PROP_99e7e4dedabc4fdcaed8265888eadabb());
        this.AddMember("allowSkipTurn", (IMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.PROP_49cf851c879949c48e2c80afcf961c68());
        this.AddMember("terrainDestruction", (IMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.PROP_58af16e4e3bd4289806f1df16c215ae6());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.PROP_a69119181a6a47758f8f0d1dea6f2d09());
        this.AddMember("armageddon", (IMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.PROP_0f36876a8e104ef2a9b758542d8d5475());
        this.AddMember("armageddonTurn", (IMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.PROP_2722172de8574f769a23d3de51a22381());
        this.AddMember("waiting", (IMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.PROP_eccc561af69340848061db94bb042ec8());
        this.AddMember("paused", (IMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.PROP_87b943820976444e8c221ab2b379d1a4());
        this.AddMember("busy", (IMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.PROP_6ec31f2ebb764d1a8c973fe55565ce56());
        this.AddMember("ongoing", (IMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.PROP_9dcdb6eb979c48f2a9999e18a370e41b());
        this.AddMember("gravity", (IMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.PROP_8ed20b40bd844b56b7306e1c7f2b9e20());
        this.AddMember("wind", (IMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.PROP_3b8dc2bd58c34b84ae6dd96dc304a8c8());
        this.AddMember("windDir", (IMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.PROP_7ed0ac0dfd054626b6e7093c57e5252f());
        this.AddMember("windPower", (IMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.PROP_8eb3d6bbbbbf4470bbcaaa14fe6ce01e());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.PROP_8caa8db4887148f2aff32eb1709c7f87());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.PROP_11bd5ab742014a5bbbf93ca459a3023a());
        this.AddMember("mousePosition", (IMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.PROP_010fcdfbd3aa43d3bb6e21f0d2109e7b());
        this.AddMember("mouseOverUI", (IMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.PROP_56878f5e46844eef8ecfe543b106c0a8());
        this.AddMember("cameraPosition", (IMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.PROP_da369d8eb68b479aaf165c0033296b5c());
        this.AddMember("cameraZoom", (IMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.PROP_75dafa1711da4fba88e2c6d3464b6d2a());
        this.AddMember("allowBounce", (IMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.PROP_c55d93074c9f4bbfbb52ebce694de4e9());
        this.AddMember("isUsingTouchControls", (IMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.PROP_1c248ed0e4da493b876ddef0e43b32db());
        this.AddMember("screenWidth", (IMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.PROP_d0de542d9a4041e2a42381ee016d7aff());
        this.AddMember("screenHeight", (IMemberDescriptor) new Bridge.TYPE_e28a1a6e046441ebb7024875dbfd8670.PROP_95a7cfd41bd9485d8b36e2d5b91691af());
      }

      private sealed class MTHD_ebec18f6dbdc4b8abde3957df1fd16e3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ebec18f6dbdc4b8abde3957df1fd16e3()
        {
          this.Initialize("getUser", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getUser();
        }
      }

      private sealed class MTHD_8b16261eb4114b1781a01583eedf1e1c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8b16261eb4114b1781a01583eedf1e1c()
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

      private sealed class MTHD_5bb5dae4df8b45aabd498279d39dbbca : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5bb5dae4df8b45aabd498279d39dbbca()
        {
          this.Initialize("getPlayerCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getPlayerCount();
        }
      }

      private sealed class MTHD_4e14cb90423b45bb96857aef46b9efe8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4e14cb90423b45bb96857aef46b9efe8()
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

      private sealed class MTHD_9a06232842674f16bc708aa892af899b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9a06232842674f16bc708aa892af899b()
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

      private sealed class MTHD_6a3e9f0af1334416a3a8e40a9cb5c5a0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6a3e9f0af1334416a3a8e40a9cb5c5a0()
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

      private sealed class MTHD_6676dee30e7e4a3092b5b39263162e85 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6676dee30e7e4a3092b5b39263162e85()
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

      private sealed class MTHD_c8f63acd58f7439dbde0fad0dad57016 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c8f63acd58f7439dbde0fad0dad57016()
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

      private sealed class MTHD_38b815e78e644139b868f32050da0149 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_38b815e78e644139b868f32050da0149()
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

      private sealed class MTHD_6b600d9ecd8a4f908a0f72c27d109f45 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6b600d9ecd8a4f908a0f72c27d109f45()
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

      private sealed class MTHD_6a3c46ff23f04eaf824f9956fb9f7f8d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6a3c46ff23f04eaf824f9956fb9f7f8d()
        {
          this.Initialize("hideInfo", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).hideInfo();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_ab905d8b4bbf4eeb8f87475bd7b63c0b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ab905d8b4bbf4eeb8f87475bd7b63c0b()
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

      private sealed class MTHD_74b36dae45054d75ad261da96e070cbb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_74b36dae45054d75ad261da96e070cbb()
        {
          this.Initialize("get_turn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turn;
        }
      }

      private sealed class MTHD_fad4d9b1b5684ac1aa9d46b095a551a5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fad4d9b1b5684ac1aa9d46b095a551a5()
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

      private sealed class MTHD_f198f01c0a404260829f43277448acea : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f198f01c0a404260829f43277448acea()
        {
          this.Initialize("get_timeLimit", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).timeLimit;
        }
      }

      private sealed class MTHD_d3e3ca43d418483db7688dd0716a91ed : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d3e3ca43d418483db7688dd0716a91ed()
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

      private sealed class MTHD_a983eedbe54d452898d404b72afc67f2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a983eedbe54d452898d404b72afc67f2()
        {
          this.Initialize("get_totalTimeElapsed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class MTHD_804441966aec4b42bf1c3b08982816bb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_804441966aec4b42bf1c3b08982816bb()
        {
          this.Initialize("get_turnTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class MTHD_2013f6f0f2a4438f9be3bbad3c22dc0a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2013f6f0f2a4438f9be3bbad3c22dc0a()
        {
          this.Initialize("get_frame", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class MTHD_547912044cd64e63bd8dfa5c51579506 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_547912044cd64e63bd8dfa5c51579506()
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

      private sealed class MTHD_9a786d9e35cd44f89892f3a4cdc18e03 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9a786d9e35cd44f89892f3a4cdc18e03()
        {
          this.Initialize("get_winOnDeath", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).winOnDeath;
        }
      }

      private sealed class MTHD_2845de8f8b834dccbc1a5f9168d0e41c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2845de8f8b834dccbc1a5f9168d0e41c()
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

      private sealed class MTHD_4a490f592c064aa78e23761e86b8edee : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4a490f592c064aa78e23761e86b8edee()
        {
          this.Initialize("get_allowMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMovement;
        }
      }

      private sealed class MTHD_ea6bb5ae9a1d468c84d547dcabdcbe6b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ea6bb5ae9a1d468c84d547dcabdcbe6b()
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

      private sealed class MTHD_7a78e331246c4a84b936c0809c02f865 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7a78e331246c4a84b936c0809c02f865()
        {
          this.Initialize("get_allowMinionMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMinionMovement;
        }
      }

      private sealed class MTHD_b603d2cca8014a2bb32a9bcf20ab5296 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b603d2cca8014a2bb32a9bcf20ab5296()
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

      private sealed class MTHD_4ae7efd1a8ee4abfb33297bbb2c000ee : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4ae7efd1a8ee4abfb33297bbb2c000ee()
        {
          this.Initialize("get_allowInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowInput;
        }
      }

      private sealed class MTHD_c39ccb5fd7894683a78dc5679c29c779 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c39ccb5fd7894683a78dc5679c29c779()
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

      private sealed class MTHD_9384f5d5c1934be4b75b41d34a7729a8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9384f5d5c1934be4b75b41d34a7729a8()
        {
          this.Initialize("get_allowCallbacks", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowCallbacks;
        }
      }

      private sealed class MTHD_e2aa2c1beee04a25b4af1212daeb4469 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e2aa2c1beee04a25b4af1212daeb4469()
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

      private sealed class MTHD_3be76dc281c54602a9fd87bd60fec755 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3be76dc281c54602a9fd87bd60fec755()
        {
          this.Initialize("get_allowSkipTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowSkipTurn;
        }
      }

      private sealed class MTHD_4b4264cad54e46978697c821cfa83b22 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4b4264cad54e46978697c821cfa83b22()
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

      private sealed class MTHD_9e255146d8aa4ae7aca5600ed645adc5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9e255146d8aa4ae7aca5600ed645adc5()
        {
          this.Initialize("get_terrainDestruction", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).terrainDestruction;
        }
      }

      private sealed class MTHD_53f6e8907b50454981a067452e5f450f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_53f6e8907b50454981a067452e5f450f()
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

      private sealed class MTHD_ca1919b4906046be9733c1c50d278c35 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ca1919b4906046be9733c1c50d278c35()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).takeDamage;
        }
      }

      private sealed class MTHD_598e45e7946b4125b7d2982e3608b7f7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_598e45e7946b4125b7d2982e3608b7f7()
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

      private sealed class MTHD_33cfebc59abd405690e923615fd49c20 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_33cfebc59abd405690e923615fd49c20()
        {
          this.Initialize("get_armageddon", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddon;
        }
      }

      private sealed class MTHD_b99871aa462c4aeaa16c442f3dc3eddc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b99871aa462c4aeaa16c442f3dc3eddc()
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

      private sealed class MTHD_581821684c3d494c9f18d1c88575924d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_581821684c3d494c9f18d1c88575924d()
        {
          this.Initialize("get_armageddonTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddonTurn;
        }
      }

      private sealed class MTHD_0925574a0df940558a96cd9dbb249951 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0925574a0df940558a96cd9dbb249951()
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

      private sealed class MTHD_0227f6db10964833a24738d6d89a368e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0227f6db10964833a24738d6d89a368e()
        {
          this.Initialize("get_waiting", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class MTHD_c6e3532c4a924f8fbbcab6dc4bad4832 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c6e3532c4a924f8fbbcab6dc4bad4832()
        {
          this.Initialize("get_paused", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).paused;
        }
      }

      private sealed class MTHD_1b29fd463c2c42e7a79a9555cdaeb61a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1b29fd463c2c42e7a79a9555cdaeb61a()
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

      private sealed class MTHD_c247df3cad7e4cf1b4fbb0b685a84cb8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c247df3cad7e4cf1b4fbb0b685a84cb8()
        {
          this.Initialize("get_busy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class MTHD_2286928922ee4cf6b50f5bac6ff9d435 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2286928922ee4cf6b50f5bac6ff9d435()
        {
          this.Initialize("get_ongoing", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class MTHD_efe1b2e698b545939b1b914d087aaddc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_efe1b2e698b545939b1b914d087aaddc()
        {
          this.Initialize("get_gravity", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).gravity;
        }
      }

      private sealed class MTHD_f9cac42239504184a9f1273bb673b779 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f9cac42239504184a9f1273bb673b779()
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

      private sealed class MTHD_d0b239137d054540a9b15dab45480629 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d0b239137d054540a9b15dab45480629()
        {
          this.Initialize("get_wind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).wind;
        }
      }

      private sealed class MTHD_005dbe2dd78d41f795db8ba32dab691f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_005dbe2dd78d41f795db8ba32dab691f()
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

      private sealed class MTHD_08e92556ed6a467a9473560ba2bcd248 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_08e92556ed6a467a9473560ba2bcd248()
        {
          this.Initialize("get_windDir", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windDir;
        }
      }

      private sealed class MTHD_49a1b914817149e2b3f57ee20ba1dd3f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_49a1b914817149e2b3f57ee20ba1dd3f()
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

      private sealed class MTHD_731d8387bdd5430c962bd4fc18dcd751 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_731d8387bdd5430c962bd4fc18dcd751()
        {
          this.Initialize("get_windPower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windPower;
        }
      }

      private sealed class MTHD_fa6535b6e5a14e7db1deac71e74b1ba2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fa6535b6e5a14e7db1deac71e74b1ba2()
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

      private sealed class MTHD_753741206d0c4ff09881c515717f7440 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_753741206d0c4ff09881c515717f7440()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class MTHD_d72de34b07b049038333358bc86aa148 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d72de34b07b049038333358bc86aa148()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class MTHD_cbe51d930e06459aaf4702ab4400c497 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cbe51d930e06459aaf4702ab4400c497()
        {
          this.Initialize("get_mousePosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class MTHD_a5038d90cea447aab1b22047b9ad2991 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a5038d90cea447aab1b22047b9ad2991()
        {
          this.Initialize("get_mouseOverUI", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class MTHD_cae47e93eb154ce187e4ab0743a7e524 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cae47e93eb154ce187e4ab0743a7e524()
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

      private sealed class MTHD_e212f5b3d7d54c35ba45d7a452a6e39b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e212f5b3d7d54c35ba45d7a452a6e39b()
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

      private sealed class MTHD_46c9c9ffc86449fdb43902b2f684b193 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_46c9c9ffc86449fdb43902b2f684b193()
        {
          this.Initialize("get_cameraPosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraPosition;
        }
      }

      private sealed class MTHD_8dfad19e529b4eb29ee17fceed04e9ea : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8dfad19e529b4eb29ee17fceed04e9ea()
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

      private sealed class MTHD_2c12d873444d4de5b0be062aef58f9d1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2c12d873444d4de5b0be062aef58f9d1()
        {
          this.Initialize("get_cameraZoom", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraZoom;
        }
      }

      private sealed class MTHD_abf31a1210ef42a7a08efc4a87f53ef6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_abf31a1210ef42a7a08efc4a87f53ef6()
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

      private sealed class MTHD_9f2a74ab992c419199a000299a6d02f5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9f2a74ab992c419199a000299a6d02f5()
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

      private sealed class MTHD_5e3f88fad30a439ba2529f80dd8b60eb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5e3f88fad30a439ba2529f80dd8b60eb()
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

      private sealed class MTHD_7443343021d34844b2fa8d61c38114f5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7443343021d34844b2fa8d61c38114f5()
        {
          this.Initialize("Dispose", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ContainerGame.Dispose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_5a3d7ad72c124424be27f61edd94aa18 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5a3d7ad72c124424be27f61edd94aa18()
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

      private sealed class MTHD_35be6c178db94f008798ff8242d2a9ac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_35be6c178db94f008798ff8242d2a9ac()
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

      private sealed class MTHD_a9402ff1481342169dc8fdb3fa101826 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a9402ff1481342169dc8fdb3fa101826()
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

      private sealed class MTHD_f028f69990854ded805b6c1ea756efcf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f028f69990854ded805b6c1ea756efcf()
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

      private sealed class MTHD_750a2aefd5724d998bd26fa9e78ca1ea : HardwiredMethodMemberDescriptor
      {
        internal MTHD_750a2aefd5724d998bd26fa9e78ca1ea()
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

      private sealed class MTHD_1353869d72874a0192f669101e190550 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1353869d72874a0192f669101e190550()
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

      private sealed class MTHD_010fe4e2751f438cb9ad5dbceb06e3e5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_010fe4e2751f438cb9ad5dbceb06e3e5()
        {
          this.Initialize("applyDraw", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).applyDraw();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_fd092e87aa2b487cbaee1df36b7dbcd7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fd092e87aa2b487cbaee1df36b7dbcd7()
        {
          this.Initialize("get_allowBounce", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowBounce;
        }
      }

      private sealed class MTHD_bcdf7ffb9f7f408198ea15231bdd7beb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bcdf7ffb9f7f408198ea15231bdd7beb()
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

      private sealed class MTHD_6819bb93324b4c13aff8e48aa3dfdab3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6819bb93324b4c13aff8e48aa3dfdab3()
        {
          this.Initialize("get_isUsingTouchControls", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class MTHD_9a13924565c547cc866c7126cd20de2c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9a13924565c547cc866c7126cd20de2c()
        {
          this.Initialize("clientRefreshSpells", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clientRefreshSpells();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_3e668afb4e214a958777edda8c35a340 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3e668afb4e214a958777edda8c35a340()
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

      private sealed class MTHD_4ab10b4829d94717b9c905f3745d0cec : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4ab10b4829d94717b9c905f3745d0cec()
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

      private sealed class MTHD_49224660829949f6b4fa954e681af808 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_49224660829949f6b4fa954e681af808()
        {
          this.Initialize("win", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).win();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_b04b97f5af974a2e9a73efb04e3cdc11 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b04b97f5af974a2e9a73efb04e3cdc11()
        {
          this.Initialize("lose", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).lose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_8ca80ce897f9428ba9f29473a8063aca : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8ca80ce897f9428ba9f29473a8063aca()
        {
          this.Initialize("nextTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).nextTurn();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_1ad38e339ddc4cf6badd24bf486258d6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1ad38e339ddc4cf6badd24bf486258d6()
        {
          this.Initialize("resetMap", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).resetMap();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_a42b14d9ee574ebbb8beeadf7e90f5ff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a42b14d9ee574ebbb8beeadf7e90f5ff()
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

      private sealed class MTHD_9fd70e51623e4b5e9011a6cb99397987 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9fd70e51623e4b5e9011a6cb99397987()
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

      private sealed class MTHD_3bb58934781949d180d62cd6112ccb3e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3bb58934781949d180d62cd6112ccb3e()
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

      private sealed class MTHD_dbceafb4532c4a13878c4a163e1eb12e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dbceafb4532c4a13878c4a163e1eb12e()
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

      private sealed class MTHD_a5c764f217fb407c86b8862c273e5d1c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a5c764f217fb407c86b8862c273e5d1c()
        {
          this.Initialize("getMapID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getMapID();
        }
      }

      private sealed class MTHD_ac1897c7fede45f081bf568a24fe3128 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ac1897c7fede45f081bf568a24fe3128()
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

      private sealed class MTHD_154bdc239adb466baedb8e402952a66e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_154bdc239adb466baedb8e402952a66e()
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

      private sealed class MTHD_a554cc61f33942b1af28d93ad346fec4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a554cc61f33942b1af28d93ad346fec4()
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

      private sealed class MTHD_35e2bd32e8f44328b9bdb2ecb331594d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_35e2bd32e8f44328b9bdb2ecb331594d()
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

      private sealed class MTHD_ce08adfa5caa47e3adedbe0a8963d1ef : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ce08adfa5caa47e3adedbe0a8963d1ef()
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

      private sealed class MTHD_bd4e592c8d44491ab1c83655886bd1f5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bd4e592c8d44491ab1c83655886bd1f5()
        {
          this.Initialize("getInputString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getInputString();
        }
      }

      private sealed class MTHD_7426354e6c0d451cb96625db12d4dff2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7426354e6c0d451cb96625db12d4dff2()
        {
          this.Initialize("get_screenWidth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class MTHD_557976d4aab14a549a51c353bc7755ed : HardwiredMethodMemberDescriptor
      {
        internal MTHD_557976d4aab14a549a51c353bc7755ed()
        {
          this.Initialize("get_screenHeight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }

      private sealed class MTHD_db70b93a40c94a17b0e2cf879e4e622c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_db70b93a40c94a17b0e2cf879e4e622c()
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

      private sealed class MTHD_e27bb3f1c943484796495c92a83fa4c7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e27bb3f1c943484796495c92a83fa4c7()
        {
          this.Initialize("clearIndicators", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clearIndicators();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_578b1a8fbf8a471c8ba762f6993627f5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_578b1a8fbf8a471c8ba762f6993627f5()
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

      private sealed class MTHD_5e3f2aacefd349758b0c0b9db42b5602 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5e3f2aacefd349758b0c0b9db42b5602()
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

      private sealed class MTHD_b531571e456c4e8fad0b1948fd42f4c9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b531571e456c4e8fad0b1948fd42f4c9()
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

      private sealed class MTHD_49e1b769b5b245e2a977dde9b0c3fdfe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_49e1b769b5b245e2a977dde9b0c3fdfe()
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

      private sealed class MTHD_b47639fa73e3445fb12b89e51aabfed3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b47639fa73e3445fb12b89e51aabfed3()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_e6898f0cbb4c43908d72e9bc87aa981a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e6898f0cbb4c43908d72e9bc87aa981a()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_db8c18f06a5a463aaf3f97ce99ccd6a2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_db8c18f06a5a463aaf3f97ce99ccd6a2()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_c0888de292974ee5b2d4c023ed4520ed : HardwiredMemberDescriptor
      {
        internal PROP_c0888de292974ee5b2d4c023ed4520ed()
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

      private sealed class PROP_bf621c5402b84b149843c350464b011e : HardwiredMemberDescriptor
      {
        internal PROP_bf621c5402b84b149843c350464b011e()
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

      private sealed class PROP_fefc217c961d4a72918e70e9e1e2eb2d : HardwiredMemberDescriptor
      {
        internal PROP_fefc217c961d4a72918e70e9e1e2eb2d()
          : base(typeof (double), "totalTimeElapsed", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class PROP_93790358ab3e4a9f930a8a09fc26769e : HardwiredMemberDescriptor
      {
        internal PROP_93790358ab3e4a9f930a8a09fc26769e()
          : base(typeof (double), "turnTime", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class PROP_84529daa57c144f096df7f0892a55977 : HardwiredMemberDescriptor
      {
        internal PROP_84529daa57c144f096df7f0892a55977()
          : base(typeof (int), "frame", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class PROP_43e23b091fe543f19a95ddc170868d53 : HardwiredMemberDescriptor
      {
        internal PROP_43e23b091fe543f19a95ddc170868d53()
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

      private sealed class PROP_a39f706b07a24a689d130fbb1fa7c028 : HardwiredMemberDescriptor
      {
        internal PROP_a39f706b07a24a689d130fbb1fa7c028()
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

      private sealed class PROP_01f0adb9e91f482b8bdb02d2d232aa4b : HardwiredMemberDescriptor
      {
        internal PROP_01f0adb9e91f482b8bdb02d2d232aa4b()
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

      private sealed class PROP_2b6bd48dd26d4706a443a35580d02377 : HardwiredMemberDescriptor
      {
        internal PROP_2b6bd48dd26d4706a443a35580d02377()
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

      private sealed class PROP_99e7e4dedabc4fdcaed8265888eadabb : HardwiredMemberDescriptor
      {
        internal PROP_99e7e4dedabc4fdcaed8265888eadabb()
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

      private sealed class PROP_49cf851c879949c48e2c80afcf961c68 : HardwiredMemberDescriptor
      {
        internal PROP_49cf851c879949c48e2c80afcf961c68()
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

      private sealed class PROP_58af16e4e3bd4289806f1df16c215ae6 : HardwiredMemberDescriptor
      {
        internal PROP_58af16e4e3bd4289806f1df16c215ae6()
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

      private sealed class PROP_a69119181a6a47758f8f0d1dea6f2d09 : HardwiredMemberDescriptor
      {
        internal PROP_a69119181a6a47758f8f0d1dea6f2d09()
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

      private sealed class PROP_0f36876a8e104ef2a9b758542d8d5475 : HardwiredMemberDescriptor
      {
        internal PROP_0f36876a8e104ef2a9b758542d8d5475()
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

      private sealed class PROP_2722172de8574f769a23d3de51a22381 : HardwiredMemberDescriptor
      {
        internal PROP_2722172de8574f769a23d3de51a22381()
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

      private sealed class PROP_eccc561af69340848061db94bb042ec8 : HardwiredMemberDescriptor
      {
        internal PROP_eccc561af69340848061db94bb042ec8()
          : base(typeof (bool), "waiting", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class PROP_87b943820976444e8c221ab2b379d1a4 : HardwiredMemberDescriptor
      {
        internal PROP_87b943820976444e8c221ab2b379d1a4()
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

      private sealed class PROP_6ec31f2ebb764d1a8c973fe55565ce56 : HardwiredMemberDescriptor
      {
        internal PROP_6ec31f2ebb764d1a8c973fe55565ce56()
          : base(typeof (bool), "busy", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class PROP_9dcdb6eb979c48f2a9999e18a370e41b : HardwiredMemberDescriptor
      {
        internal PROP_9dcdb6eb979c48f2a9999e18a370e41b()
          : base(typeof (bool), "ongoing", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class PROP_8ed20b40bd844b56b7306e1c7f2b9e20 : HardwiredMemberDescriptor
      {
        internal PROP_8ed20b40bd844b56b7306e1c7f2b9e20()
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

      private sealed class PROP_3b8dc2bd58c34b84ae6dd96dc304a8c8 : HardwiredMemberDescriptor
      {
        internal PROP_3b8dc2bd58c34b84ae6dd96dc304a8c8()
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

      private sealed class PROP_7ed0ac0dfd054626b6e7093c57e5252f : HardwiredMemberDescriptor
      {
        internal PROP_7ed0ac0dfd054626b6e7093c57e5252f()
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

      private sealed class PROP_8eb3d6bbbbbf4470bbcaaa14fe6ce01e : HardwiredMemberDescriptor
      {
        internal PROP_8eb3d6bbbbbf4470bbcaaa14fe6ce01e()
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

      private sealed class PROP_8caa8db4887148f2aff32eb1709c7f87 : HardwiredMemberDescriptor
      {
        internal PROP_8caa8db4887148f2aff32eb1709c7f87()
          : base(typeof (int), "width", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class PROP_11bd5ab742014a5bbbf93ca459a3023a : HardwiredMemberDescriptor
      {
        internal PROP_11bd5ab742014a5bbbf93ca459a3023a()
          : base(typeof (int), "height", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class PROP_010fcdfbd3aa43d3bb6e21f0d2109e7b : HardwiredMemberDescriptor
      {
        internal PROP_010fcdfbd3aa43d3bb6e21f0d2109e7b()
          : base(typeof (Educative.Point), "mousePosition", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class PROP_56878f5e46844eef8ecfe543b106c0a8 : HardwiredMemberDescriptor
      {
        internal PROP_56878f5e46844eef8ecfe543b106c0a8()
          : base(typeof (bool), "mouseOverUI", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class PROP_da369d8eb68b479aaf165c0033296b5c : HardwiredMemberDescriptor
      {
        internal PROP_da369d8eb68b479aaf165c0033296b5c()
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

      private sealed class PROP_75dafa1711da4fba88e2c6d3464b6d2a : HardwiredMemberDescriptor
      {
        internal PROP_75dafa1711da4fba88e2c6d3464b6d2a()
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

      private sealed class PROP_c55d93074c9f4bbfbb52ebce694de4e9 : HardwiredMemberDescriptor
      {
        internal PROP_c55d93074c9f4bbfbb52ebce694de4e9()
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

      private sealed class PROP_1c248ed0e4da493b876ddef0e43b32db : HardwiredMemberDescriptor
      {
        internal PROP_1c248ed0e4da493b876ddef0e43b32db()
          : base(typeof (bool), "isUsingTouchControls", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class PROP_d0de542d9a4041e2a42381ee016d7aff : HardwiredMemberDescriptor
      {
        internal PROP_d0de542d9a4041e2a42381ee016d7aff()
          : base(typeof (double), "screenWidth", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class PROP_95a7cfd41bd9485d8b36e2d5b91691af : HardwiredMemberDescriptor
      {
        internal PROP_95a7cfd41bd9485d8b36e2d5b91691af()
          : base(typeof (double), "screenHeight", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }
    }

    private sealed class TYPE_a186232bac854b86a433503df4ff73ea : HardwiredUserDataDescriptor
    {
      internal TYPE_a186232bac854b86a433503df4ff73ea()
        : base(typeof (ContainerPlayer))
      {
        this.AddMember("get_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a186232bac854b86a433503df4ff73ea.MTHD_518f292ace92487a961fb648cdb0adad()
        }));
        this.AddMember("set_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a186232bac854b86a433503df4ff73ea.MTHD_124a9a0a2e3144348cae0d5d714a9cd5()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a186232bac854b86a433503df4ff73ea.MTHD_07aa0b67b0f040f19048e22241409944()
        }));
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a186232bac854b86a433503df4ff73ea.MTHD_d1f5e0058f6e4923973d9c01f7fe886e()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a186232bac854b86a433503df4ff73ea.MTHD_ece2bfe09c4f4ba1afb54de94fc7f61b()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a186232bac854b86a433503df4ff73ea.MTHD_c6b5e38ad10a4d4889a22e305a4177f2()
        }));
        this.AddMember("getCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreature", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a186232bac854b86a433503df4ff73ea.MTHD_a60c1ada7fec4134bce312bd4fcb1210()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a186232bac854b86a433503df4ff73ea.MTHD_5c9ac1c8ec4049f5a62b1fc502356f66()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a186232bac854b86a433503df4ff73ea.MTHD_4cd8ad5671da45f8a953aef79431e178()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a186232bac854b86a433503df4ff73ea.MTHD_2f253385a3fc4f8f93c0c81957094b7d()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a186232bac854b86a433503df4ff73ea.MTHD_83e0e4dc14af4c2a92bdbf1505be7b3d()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a186232bac854b86a433503df4ff73ea.MTHD_9c7138ae805a4a27b0737aed2d9d6c44()
        }));
        this.AddMember("localTurn", (IMemberDescriptor) new Bridge.TYPE_a186232bac854b86a433503df4ff73ea.PROP_6558ed5bd3414947999f2eec5230a9ab());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_a186232bac854b86a433503df4ff73ea.PROP_0e4b4ec59564433ea459aa34282d5bf2());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_a186232bac854b86a433503df4ff73ea.PROP_94b11a8f8a2f4140892df8cf8630b380());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_a186232bac854b86a433503df4ff73ea.PROP_4e2787db518342a392cee6f93b521411());
      }

      private sealed class MTHD_518f292ace92487a961fb648cdb0adad : HardwiredMethodMemberDescriptor
      {
        internal MTHD_518f292ace92487a961fb648cdb0adad()
        {
          this.Initialize("get_localTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).localTurn;
        }
      }

      private sealed class MTHD_124a9a0a2e3144348cae0d5d714a9cd5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_124a9a0a2e3144348cae0d5d714a9cd5()
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

      private sealed class MTHD_07aa0b67b0f040f19048e22241409944 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_07aa0b67b0f040f19048e22241409944()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class MTHD_d1f5e0058f6e4923973d9c01f7fe886e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d1f5e0058f6e4923973d9c01f7fe886e()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class MTHD_ece2bfe09c4f4ba1afb54de94fc7f61b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ece2bfe09c4f4ba1afb54de94fc7f61b()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }

      private sealed class MTHD_c6b5e38ad10a4d4889a22e305a4177f2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c6b5e38ad10a4d4889a22e305a4177f2()
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

      private sealed class MTHD_a60c1ada7fec4134bce312bd4fcb1210 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a60c1ada7fec4134bce312bd4fcb1210()
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

      private sealed class MTHD_5c9ac1c8ec4049f5a62b1fc502356f66 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5c9ac1c8ec4049f5a62b1fc502356f66()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).getMinionCount();
        }
      }

      private sealed class MTHD_4cd8ad5671da45f8a953aef79431e178 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4cd8ad5671da45f8a953aef79431e178()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).GetHashCode();
        }
      }

      private sealed class MTHD_2f253385a3fc4f8f93c0c81957094b7d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2f253385a3fc4f8f93c0c81957094b7d()
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

      private sealed class MTHD_83e0e4dc14af4c2a92bdbf1505be7b3d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_83e0e4dc14af4c2a92bdbf1505be7b3d()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_9c7138ae805a4a27b0737aed2d9d6c44 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9c7138ae805a4a27b0737aed2d9d6c44()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_6558ed5bd3414947999f2eec5230a9ab : HardwiredMemberDescriptor
      {
        internal PROP_6558ed5bd3414947999f2eec5230a9ab()
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

      private sealed class PROP_0e4b4ec59564433ea459aa34282d5bf2 : HardwiredMemberDescriptor
      {
        internal PROP_0e4b4ec59564433ea459aa34282d5bf2()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class PROP_94b11a8f8a2f4140892df8cf8630b380 : HardwiredMemberDescriptor
      {
        internal PROP_94b11a8f8a2f4140892df8cf8630b380()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class PROP_4e2787db518342a392cee6f93b521411 : HardwiredMemberDescriptor
      {
        internal PROP_4e2787db518342a392cee6f93b521411()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }
    }

    private sealed class TYPE_6b70efd3cb544a4a9b1105c22c044d96 : HardwiredUserDataDescriptor
    {
      internal TYPE_6b70efd3cb544a4a9b1105c22c044d96()
        : base(typeof (ContainerCreature))
      {
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_cb5964ce67e94726ac0d5cca160d9234()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_624de26206ec49239f1c4b7cb72a126a()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_4c13eefcd75e4fada1c27648abab4a95()
        }));
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_073e735b83a249a3a9f489e01f5c9f1f()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_d930a6b9a7a348a0a24b93f2e2e02c9f()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_135b46dc8b7b43c994fb8b6d59116fe0()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_85e5e428f4084ba9aed562774c4dc4e2()
        }));
        this.AddMember("get_healthAndTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_healthAndTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_053c530ab36d4cf991ac539e8af8a555()
        }));
        this.AddMember("get_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_7753906d3c6c4239b4ed072fa562356d()
        }));
        this.AddMember("set_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_60642b454ae54ee2bce6f77c664d1135()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_8345c1c8fff14e329fa4a730a0d49862()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_608c0b23a5744e33a6b5633a7ab65763()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_6332cad91ddf4d2dbcdc24333f78ee8d()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_daa72ad1ac7043c282230dbdc98087a8()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_0edcd258823a4c549d755abaf606cbaf()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_959a433c210c49ec8eebc2fced597b28()
        }));
        this.AddMember("get_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_e43a28c530d9404093d747fee99d9f92()
        }));
        this.AddMember("set_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_de31641f81cd4e4b8033d6ecc4af7499()
        }));
        this.AddMember("get_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_8eef20e18ef44e5bb95dbea63c1fbcb5()
        }));
        this.AddMember("set_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_186070530ebd446986713614057a34b0()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_6b10f8f2965342c2bf92ecf39d5ee0d7()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_8889a2884242413588c34ca00ac6cb4f()
        }));
        this.AddMember("get_inTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_5919abc8132846c88a77b6d9c94ce314()
        }));
        this.AddMember("get_isMoving", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMoving", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_1dfce702e08d49369d0f510269046bbf()
        }));
        this.AddMember("get_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_81f8d60f2c5a47db816b1ec9c8e06220()
        }));
        this.AddMember("set_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_c33c92d235e442f2a06eff01c6c78725()
        }));
        this.AddMember("get_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_d63724825b4c49a1b98cc2fab228410f()
        }));
        this.AddMember("set_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_b512327a3f994fe48d2020db8c12c3ad()
        }));
        this.AddMember("get_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_4a719db128484a7680c62429ccc68464()
        }));
        this.AddMember("set_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_59c20bcad36c4f45b5d062205c0da812()
        }));
        this.AddMember("get_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_84ad8c8f9d93497a9ead34c30d6785ed()
        }));
        this.AddMember("set_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_b5d2164001af402a9ef13bdfac8df89c()
        }));
        this.AddMember("get_inWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_1c6fe0f4af6d44fa9473727a0b27deb1()
        }));
        this.AddMember("get_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_689facf21d9f45558b28be2e6667118a()
        }));
        this.AddMember("set_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_2c8d5adbec214de9a6fc1ceffecc5913()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_8494e9bd65b5478baa813bb8a1eb897b()
        }));
        this.AddMember("set_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_5a2a8037ab1e4a81bdf3dc6e620856aa()
        }));
        this.AddMember("get_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_6d44b518479b4f54946bcf040a596d02()
        }));
        this.AddMember("set_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_3a9c003b6bb94e68ba5c491f8d6295f9()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_2d97041706d74d29a4908f403bfa340d()
        }));
        this.AddMember("get_isRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_ed748572df2d44899b0b54fdbbfcc0f6()
        }));
        this.AddMember("get_isMounted", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMounted", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_7f6660ef5c8641b4a963b54c272b5eed()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_2772ebae369044eea7b3bb99a37e190c()
        }));
        this.AddMember("get_isPawn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPawn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_771d79b9398842c796a575cbcfca7bb7()
        }));
        this.AddMember("get_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_6e9391cd54bd4d408216f5ee5f50535f()
        }));
        this.AddMember("set_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_3f21e34e3e2045c782257d799abc4043()
        }));
        this.AddMember("get_isMountable", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMountable", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_42af83e93bdb42849aa48240461a73b2()
        }));
        this.AddMember("get_canMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_canMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_72158264c5f942e2a0f2911925ea61d4()
        }));
        this.AddMember("get_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_2380ca158c4847a5abad4b6177041020()
        }));
        this.AddMember("set_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_d162daa4d0dc4412a9e74134cabc91bf()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_36eb12e6711742e38b548d5517323c07()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_cf0163dfc8964899a44fd4ed2492bb60()
        }));
        this.AddMember("getRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_dcd8d672ae844b669c669ae8c76329f0()
        }));
        this.AddMember("getMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_63c6190efe264c78b5800557e23de5fa()
        }));
        this.AddMember("getTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_da488183a1294cf3b7325485d1c3a4bc()
        }));
        this.AddMember("LongJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LongJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_418230748f5a424089aee88c35a92671()
        }));
        this.AddMember("HighJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("HighJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_68f34f47afe84492a26587d3fb34350d()
        }));
        this.AddMember("Walk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Walk", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_baa16d26544b437c9f947c4c09885534()
        }));
        this.AddMember("setDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_8a72ae56fa744030803971302e74996a()
        }));
        this.AddMember("getDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_3f00890063af4045b9a7612b9e5da8e3()
        }));
        this.AddMember("getFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_d7f4facadcc5489a8294bfd2d9e1404d()
        }));
        this.AddMember("getActivateableFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_b6a3aa42f21e49d4b524aeb1034cee3a()
        }));
        this.AddMember("getActivateableFamiliarBookID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarBookID", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_205b2f0563354611b5fdf86cc035fa52()
        }));
        this.AddMember("increaseFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("increaseFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_4cf787ca18e94cb29e7c2b19aa195a1a()
        }));
        this.AddMember("inside", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("inside", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_56ea1140a3a54ef0940ce906ce431723(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_f710cff27acf4211a29800c7e9ab8c6b()
        }));
        this.AddMember("overlap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("overlap", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_afdd5a4e896c4d56a85936a348fb5bb2(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_6dc91fe8f262455594dc486e6b9a262b()
        }));
        this.AddMember("die", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("die", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_3c8c0034f0d64af3b8831e5288c743cf()
        }));
        this.AddMember("addSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_bdc8a5a2b571432ebd2ac9e216ada989()
        }));
        this.AddMember("removeSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("removeSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_99b0bb26dd8a48c9abaf69e472e5b40e(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_f2997185342b41a198beafd81bd52933()
        }));
        this.AddMember("getSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpells", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_5fe723f422c14f30a4d09f2f8a8096f0()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_2c7f04703d274819ad59f61b30b76863()
        }));
        this.AddMember("getSpellCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_6d96700abf1d40ca9eb325b8f59b651c()
        }));
        this.AddMember("castedCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_88b74e715a0d4a70bf96ebe43a96221e()
        }));
        this.AddMember("castedCountThisTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCountThisTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_784a82497bf5450cbf29ad952d0c8121()
        }));
        this.AddMember("castedDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_f62deaecf3cc4fb7b7ab435ded6e4a0f()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_e5d2c3c5746b4943a1ffe57f1d8f5846()
        }));
        this.AddMember("castSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_0819e550be544dffa444087248f71a75()
        }));
        this.AddMember("angleToFire", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("angleToFire", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_99a59db3339447f5a539fe3423b8f359()
        }));
        this.AddMember("powerToFire", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("powerToFire", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_e741d3db0a184c6ab0a33f5a842b84c5()
        }));
        this.AddMember("fireAt", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fireAt", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_cb707ce2a8a243b28714e0e553d6dd11(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_074c8406ca7445c5a925c7ce1ecbc89a()
        }));
        this.AddMember("getEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getEffectors", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_f74c65abd3c44d39900031d753bc4500(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_1834891387bc485e9cbfde9c82442e06()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_557f6a6df10c47469fc09c4b662746f8()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_2177371bc3be46a8b5475398d2c0c5fb()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_7ba4af39ab41461da744aa2455486d0c()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_0471ead9fe3549649dcbf74dcfa45b1e()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_76dfc41f9c09463bbaa9d713e081e322()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.MTHD_a9d4990bd3ae45d290727a41fb001e81()
        }));
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.PROP_c5b5ecf1fea5443e9151db2c41f305c9());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.PROP_7d4f1fe4abe94a408dc9f549f0ee8401());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.PROP_5dae01abd7bc4def91107404c9200f45());
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.PROP_b707beae17f14c03aa7e1600c0451176());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.PROP_9b3eb1511cb84ebc811a9445501e2655());
        this.AddMember("healthAndTower", (IMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.PROP_3632fee88b614c64ab4ca2620ac91d25());
        this.AddMember("shield", (IMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.PROP_6a7c07bd574545c3bfbe74c22f4dca2e());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.PROP_68bbba16416d400789e239acee2577ed());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.PROP_c01d1b2e83f04406beb65563f0c4b60a());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.PROP_bb7fcecf084644bfb5037701ff2d722d());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.PROP_1941f31e18144e8796c19077b5f634d2());
        this.AddMember("weight", (IMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.PROP_dd5247b362274b6ab7b9205d4f07212a());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.PROP_e320819d89ca4624ab3c526544bb2183());
        this.AddMember("inTower", (IMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.PROP_6ad2a7ec41484a74975087286504337f());
        this.AddMember("isMoving", (IMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.PROP_e5be078c4940413095fb44c0b59c80a0());
        this.AddMember("stunned", (IMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.PROP_22ca0d7ff1004225bc1b3848524d3158());
        this.AddMember("superStunned", (IMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.PROP_21f416055f1e48a9811076a1f967f993());
        this.AddMember("waterWalking", (IMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.PROP_b9d65caaa47445d999539bc6dc4fcdf3());
        this.AddMember("frostWalking", (IMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.PROP_6ce048231bd4415990f7ce7940f9f642());
        this.AddMember("inWater", (IMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.PROP_6f6a65c017b44cbba40b165753004891());
        this.AddMember("diesInWater", (IMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.PROP_79ea4903ea5a487bbfde20b3498ef255());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.PROP_ebc46f34775a414cb4aafdf089d7a3fa());
        this.AddMember("race", (IMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.PROP_1401965c07124a3289fbfc6f1a7053df());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.PROP_c5fc4fc4c4ba42638b2b3f4769b472cb());
        this.AddMember("isRider", (IMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.PROP_df236c33b8be4bd6b582f154d5d309e9());
        this.AddMember("isMounted", (IMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.PROP_8bc41e1252b94ab4973ab7755b3b98fd());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.PROP_62ef6dc0300549cc984892d001070fba());
        this.AddMember("isPawn", (IMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.PROP_d2660eb05cb74cb18ee4c34c109ffb8b());
        this.AddMember("isFlying", (IMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.PROP_2f34f79958114c06a08e6fd2b855b791());
        this.AddMember("isMountable", (IMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.PROP_2b54986b0ba847aca7787bf4e3dbe940());
        this.AddMember("canMount", (IMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.PROP_fb19ed868b2643d8808053d89f5aa4d1());
        this.AddMember("arcaneMonster", (IMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.PROP_4d5b54ae5b494e78b68c5c1dbe9d0d47());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_6b70efd3cb544a4a9b1105c22c044d96.PROP_47b99877eb7b4914a5cf369b99d8b0ef());
      }

      private sealed class MTHD_cb5964ce67e94726ac0d5cca160d9234 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cb5964ce67e94726ac0d5cca160d9234()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class MTHD_624de26206ec49239f1c4b7cb72a126a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_624de26206ec49239f1c4b7cb72a126a()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class MTHD_4c13eefcd75e4fada1c27648abab4a95 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4c13eefcd75e4fada1c27648abab4a95()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class MTHD_073e735b83a249a3a9f489e01f5c9f1f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_073e735b83a249a3a9f489e01f5c9f1f()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).health;
        }
      }

      private sealed class MTHD_d930a6b9a7a348a0a24b93f2e2e02c9f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d930a6b9a7a348a0a24b93f2e2e02c9f()
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

      private sealed class MTHD_135b46dc8b7b43c994fb8b6d59116fe0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_135b46dc8b7b43c994fb8b6d59116fe0()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).maxHealth;
        }
      }

      private sealed class MTHD_85e5e428f4084ba9aed562774c4dc4e2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_85e5e428f4084ba9aed562774c4dc4e2()
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

      private sealed class MTHD_053c530ab36d4cf991ac539e8af8a555 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_053c530ab36d4cf991ac539e8af8a555()
        {
          this.Initialize("get_healthAndTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class MTHD_7753906d3c6c4239b4ed072fa562356d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7753906d3c6c4239b4ed072fa562356d()
        {
          this.Initialize("get_shield", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).shield;
        }
      }

      private sealed class MTHD_60642b454ae54ee2bce6f77c664d1135 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_60642b454ae54ee2bce6f77c664d1135()
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

      private sealed class MTHD_8345c1c8fff14e329fa4a730a0d49862 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8345c1c8fff14e329fa4a730a0d49862()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).x;
        }
      }

      private sealed class MTHD_608c0b23a5744e33a6b5633a7ab65763 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_608c0b23a5744e33a6b5633a7ab65763()
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

      private sealed class MTHD_6332cad91ddf4d2dbcdc24333f78ee8d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6332cad91ddf4d2dbcdc24333f78ee8d()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).y;
        }
      }

      private sealed class MTHD_daa72ad1ac7043c282230dbdc98087a8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_daa72ad1ac7043c282230dbdc98087a8()
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

      private sealed class MTHD_0edcd258823a4c549d755abaf606cbaf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0edcd258823a4c549d755abaf606cbaf()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).position;
        }
      }

      private sealed class MTHD_959a433c210c49ec8eebc2fced597b28 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_959a433c210c49ec8eebc2fced597b28()
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

      private sealed class MTHD_e43a28c530d9404093d747fee99d9f92 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e43a28c530d9404093d747fee99d9f92()
        {
          this.Initialize("get_parent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).parent;
        }
      }

      private sealed class MTHD_de31641f81cd4e4b8033d6ecc4af7499 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_de31641f81cd4e4b8033d6ecc4af7499()
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

      private sealed class MTHD_8eef20e18ef44e5bb95dbea63c1fbcb5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8eef20e18ef44e5bb95dbea63c1fbcb5()
        {
          this.Initialize("get_weight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).weight;
        }
      }

      private sealed class MTHD_186070530ebd446986713614057a34b0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_186070530ebd446986713614057a34b0()
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

      private sealed class MTHD_6b10f8f2965342c2bf92ecf39d5ee0d7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6b10f8f2965342c2bf92ecf39d5ee0d7()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).radius;
        }
      }

      private sealed class MTHD_8889a2884242413588c34ca00ac6cb4f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8889a2884242413588c34ca00ac6cb4f()
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

      private sealed class MTHD_5919abc8132846c88a77b6d9c94ce314 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5919abc8132846c88a77b6d9c94ce314()
        {
          this.Initialize("get_inTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class MTHD_1dfce702e08d49369d0f510269046bbf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1dfce702e08d49369d0f510269046bbf()
        {
          this.Initialize("get_isMoving", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class MTHD_81f8d60f2c5a47db816b1ec9c8e06220 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_81f8d60f2c5a47db816b1ec9c8e06220()
        {
          this.Initialize("get_stunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).stunned;
        }
      }

      private sealed class MTHD_c33c92d235e442f2a06eff01c6c78725 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c33c92d235e442f2a06eff01c6c78725()
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

      private sealed class MTHD_d63724825b4c49a1b98cc2fab228410f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d63724825b4c49a1b98cc2fab228410f()
        {
          this.Initialize("get_superStunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).superStunned;
        }
      }

      private sealed class MTHD_b512327a3f994fe48d2020db8c12c3ad : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b512327a3f994fe48d2020db8c12c3ad()
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

      private sealed class MTHD_4a719db128484a7680c62429ccc68464 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4a719db128484a7680c62429ccc68464()
        {
          this.Initialize("get_waterWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).waterWalking;
        }
      }

      private sealed class MTHD_59c20bcad36c4f45b5d062205c0da812 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_59c20bcad36c4f45b5d062205c0da812()
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

      private sealed class MTHD_84ad8c8f9d93497a9ead34c30d6785ed : HardwiredMethodMemberDescriptor
      {
        internal MTHD_84ad8c8f9d93497a9ead34c30d6785ed()
        {
          this.Initialize("get_frostWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).frostWalking;
        }
      }

      private sealed class MTHD_b5d2164001af402a9ef13bdfac8df89c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b5d2164001af402a9ef13bdfac8df89c()
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

      private sealed class MTHD_1c6fe0f4af6d44fa9473727a0b27deb1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1c6fe0f4af6d44fa9473727a0b27deb1()
        {
          this.Initialize("get_inWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class MTHD_689facf21d9f45558b28be2e6667118a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_689facf21d9f45558b28be2e6667118a()
        {
          this.Initialize("get_diesInWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).diesInWater;
        }
      }

      private sealed class MTHD_2c8d5adbec214de9a6fc1ceffecc5913 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2c8d5adbec214de9a6fc1ceffecc5913()
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

      private sealed class MTHD_8494e9bd65b5478baa813bb8a1eb897b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8494e9bd65b5478baa813bb8a1eb897b()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).type;
        }
      }

      private sealed class MTHD_5a2a8037ab1e4a81bdf3dc6e620856aa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5a2a8037ab1e4a81bdf3dc6e620856aa()
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

      private sealed class MTHD_6d44b518479b4f54946bcf040a596d02 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6d44b518479b4f54946bcf040a596d02()
        {
          this.Initialize("get_race", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).race;
        }
      }

      private sealed class MTHD_3a9c003b6bb94e68ba5c491f8d6295f9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3a9c003b6bb94e68ba5c491f8d6295f9()
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

      private sealed class MTHD_2d97041706d74d29a4908f403bfa340d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2d97041706d74d29a4908f403bfa340d()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class MTHD_ed748572df2d44899b0b54fdbbfcc0f6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ed748572df2d44899b0b54fdbbfcc0f6()
        {
          this.Initialize("get_isRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class MTHD_7f6660ef5c8641b4a963b54c272b5eed : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7f6660ef5c8641b4a963b54c272b5eed()
        {
          this.Initialize("get_isMounted", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class MTHD_2772ebae369044eea7b3bb99a37e190c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2772ebae369044eea7b3bb99a37e190c()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class MTHD_771d79b9398842c796a575cbcfca7bb7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_771d79b9398842c796a575cbcfca7bb7()
        {
          this.Initialize("get_isPawn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class MTHD_6e9391cd54bd4d408216f5ee5f50535f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6e9391cd54bd4d408216f5ee5f50535f()
        {
          this.Initialize("get_isFlying", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isFlying;
        }
      }

      private sealed class MTHD_3f21e34e3e2045c782257d799abc4043 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3f21e34e3e2045c782257d799abc4043()
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

      private sealed class MTHD_42af83e93bdb42849aa48240461a73b2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_42af83e93bdb42849aa48240461a73b2()
        {
          this.Initialize("get_isMountable", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class MTHD_72158264c5f942e2a0f2911925ea61d4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_72158264c5f942e2a0f2911925ea61d4()
        {
          this.Initialize("get_canMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class MTHD_2380ca158c4847a5abad4b6177041020 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2380ca158c4847a5abad4b6177041020()
        {
          this.Initialize("get_arcaneMonster", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).arcaneMonster;
        }
      }

      private sealed class MTHD_d162daa4d0dc4412a9e74134cabc91bf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d162daa4d0dc4412a9e74134cabc91bf()
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

      private sealed class MTHD_36eb12e6711742e38b548d5517323c07 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_36eb12e6711742e38b548d5517323c07()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).takeDamage;
        }
      }

      private sealed class MTHD_cf0163dfc8964899a44fd4ed2492bb60 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cf0163dfc8964899a44fd4ed2492bb60()
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

      private sealed class MTHD_dcd8d672ae844b669c669ae8c76329f0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dcd8d672ae844b669c669ae8c76329f0()
        {
          this.Initialize("getRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getRider();
        }
      }

      private sealed class MTHD_63c6190efe264c78b5800557e23de5fa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_63c6190efe264c78b5800557e23de5fa()
        {
          this.Initialize("getMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMount();
        }
      }

      private sealed class MTHD_da488183a1294cf3b7325485d1c3a4bc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_da488183a1294cf3b7325485d1c3a4bc()
        {
          this.Initialize("getTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getTower();
        }
      }

      private sealed class MTHD_418230748f5a424089aee88c35a92671 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_418230748f5a424089aee88c35a92671()
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

      private sealed class MTHD_68f34f47afe84492a26587d3fb34350d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_68f34f47afe84492a26587d3fb34350d()
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

      private sealed class MTHD_baa16d26544b437c9f947c4c09885534 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_baa16d26544b437c9f947c4c09885534()
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

      private sealed class MTHD_8a72ae56fa744030803971302e74996a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8a72ae56fa744030803971302e74996a()
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

      private sealed class MTHD_3f00890063af4045b9a7612b9e5da8e3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3f00890063af4045b9a7612b9e5da8e3()
        {
          this.Initialize("getDirection", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getDirection();
        }
      }

      private sealed class MTHD_d7f4facadcc5489a8294bfd2d9e1404d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d7f4facadcc5489a8294bfd2d9e1404d()
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

      private sealed class MTHD_b6a3aa42f21e49d4b524aeb1034cee3a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b6a3aa42f21e49d4b524aeb1034cee3a()
        {
          this.Initialize("getActivateableFamiliarLevel", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarLevel();
        }
      }

      private sealed class MTHD_205b2f0563354611b5fdf86cc035fa52 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_205b2f0563354611b5fdf86cc035fa52()
        {
          this.Initialize("getActivateableFamiliarBookID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarBookID();
        }
      }

      private sealed class MTHD_4cf787ca18e94cb29e7c2b19aa195a1a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4cf787ca18e94cb29e7c2b19aa195a1a()
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

      private sealed class MTHD_56ea1140a3a54ef0940ce906ce431723 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_56ea1140a3a54ef0940ce906ce431723()
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

      private sealed class MTHD_f710cff27acf4211a29800c7e9ab8c6b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f710cff27acf4211a29800c7e9ab8c6b()
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

      private sealed class MTHD_afdd5a4e896c4d56a85936a348fb5bb2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_afdd5a4e896c4d56a85936a348fb5bb2()
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

      private sealed class MTHD_6dc91fe8f262455594dc486e6b9a262b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6dc91fe8f262455594dc486e6b9a262b()
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

      private sealed class MTHD_3c8c0034f0d64af3b8831e5288c743cf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3c8c0034f0d64af3b8831e5288c743cf()
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

      private sealed class MTHD_bdc8a5a2b571432ebd2ac9e216ada989 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bdc8a5a2b571432ebd2ac9e216ada989()
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

      private sealed class MTHD_99b0bb26dd8a48c9abaf69e472e5b40e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_99b0bb26dd8a48c9abaf69e472e5b40e()
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

      private sealed class MTHD_f2997185342b41a198beafd81bd52933 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f2997185342b41a198beafd81bd52933()
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

      private sealed class MTHD_5fe723f422c14f30a4d09f2f8a8096f0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5fe723f422c14f30a4d09f2f8a8096f0()
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

      private sealed class MTHD_2c7f04703d274819ad59f61b30b76863 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2c7f04703d274819ad59f61b30b76863()
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

      private sealed class MTHD_6d96700abf1d40ca9eb325b8f59b651c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6d96700abf1d40ca9eb325b8f59b651c()
        {
          this.Initialize("getSpellCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getSpellCount();
        }
      }

      private sealed class MTHD_88b74e715a0d4a70bf96ebe43a96221e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_88b74e715a0d4a70bf96ebe43a96221e()
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

      private sealed class MTHD_784a82497bf5450cbf29ad952d0c8121 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_784a82497bf5450cbf29ad952d0c8121()
        {
          this.Initialize("castedCountThisTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).castedCountThisTurn();
        }
      }

      private sealed class MTHD_f62deaecf3cc4fb7b7ab435ded6e4a0f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f62deaecf3cc4fb7b7ab435ded6e4a0f()
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

      private sealed class MTHD_e5d2c3c5746b4943a1ffe57f1d8f5846 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e5d2c3c5746b4943a1ffe57f1d8f5846()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMinionCount();
        }
      }

      private sealed class MTHD_0819e550be544dffa444087248f71a75 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0819e550be544dffa444087248f71a75()
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

      private sealed class MTHD_99a59db3339447f5a539fe3423b8f359 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_99a59db3339447f5a539fe3423b8f359()
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

      private sealed class MTHD_e741d3db0a184c6ab0a33f5a842b84c5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e741d3db0a184c6ab0a33f5a842b84c5()
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

      private sealed class MTHD_cb707ce2a8a243b28714e0e553d6dd11 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cb707ce2a8a243b28714e0e553d6dd11()
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

      private sealed class MTHD_074c8406ca7445c5a925c7ce1ecbc89a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_074c8406ca7445c5a925c7ce1ecbc89a()
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

      private sealed class MTHD_f74c65abd3c44d39900031d753bc4500 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f74c65abd3c44d39900031d753bc4500()
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

      private sealed class MTHD_1834891387bc485e9cbfde9c82442e06 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1834891387bc485e9cbfde9c82442e06()
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

      private sealed class MTHD_557f6a6df10c47469fc09c4b662746f8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_557f6a6df10c47469fc09c4b662746f8()
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

      private sealed class MTHD_2177371bc3be46a8b5475398d2c0c5fb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2177371bc3be46a8b5475398d2c0c5fb()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).GetHashCode();
        }
      }

      private sealed class MTHD_7ba4af39ab41461da744aa2455486d0c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7ba4af39ab41461da744aa2455486d0c()
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

      private sealed class MTHD_0471ead9fe3549649dcbf74dcfa45b1e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0471ead9fe3549649dcbf74dcfa45b1e()
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

      private sealed class MTHD_76dfc41f9c09463bbaa9d713e081e322 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_76dfc41f9c09463bbaa9d713e081e322()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_a9d4990bd3ae45d290727a41fb001e81 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a9d4990bd3ae45d290727a41fb001e81()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_c5b5ecf1fea5443e9151db2c41f305c9 : HardwiredMemberDescriptor
      {
        internal PROP_c5b5ecf1fea5443e9151db2c41f305c9()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class PROP_7d4f1fe4abe94a408dc9f549f0ee8401 : HardwiredMemberDescriptor
      {
        internal PROP_7d4f1fe4abe94a408dc9f549f0ee8401()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class PROP_5dae01abd7bc4def91107404c9200f45 : HardwiredMemberDescriptor
      {
        internal PROP_5dae01abd7bc4def91107404c9200f45()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class PROP_b707beae17f14c03aa7e1600c0451176 : HardwiredMemberDescriptor
      {
        internal PROP_b707beae17f14c03aa7e1600c0451176()
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

      private sealed class PROP_9b3eb1511cb84ebc811a9445501e2655 : HardwiredMemberDescriptor
      {
        internal PROP_9b3eb1511cb84ebc811a9445501e2655()
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

      private sealed class PROP_3632fee88b614c64ab4ca2620ac91d25 : HardwiredMemberDescriptor
      {
        internal PROP_3632fee88b614c64ab4ca2620ac91d25()
          : base(typeof (int), "healthAndTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class PROP_6a7c07bd574545c3bfbe74c22f4dca2e : HardwiredMemberDescriptor
      {
        internal PROP_6a7c07bd574545c3bfbe74c22f4dca2e()
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

      private sealed class PROP_68bbba16416d400789e239acee2577ed : HardwiredMemberDescriptor
      {
        internal PROP_68bbba16416d400789e239acee2577ed()
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

      private sealed class PROP_c01d1b2e83f04406beb65563f0c4b60a : HardwiredMemberDescriptor
      {
        internal PROP_c01d1b2e83f04406beb65563f0c4b60a()
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

      private sealed class PROP_bb7fcecf084644bfb5037701ff2d722d : HardwiredMemberDescriptor
      {
        internal PROP_bb7fcecf084644bfb5037701ff2d722d()
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

      private sealed class PROP_1941f31e18144e8796c19077b5f634d2 : HardwiredMemberDescriptor
      {
        internal PROP_1941f31e18144e8796c19077b5f634d2()
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

      private sealed class PROP_dd5247b362274b6ab7b9205d4f07212a : HardwiredMemberDescriptor
      {
        internal PROP_dd5247b362274b6ab7b9205d4f07212a()
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

      private sealed class PROP_e320819d89ca4624ab3c526544bb2183 : HardwiredMemberDescriptor
      {
        internal PROP_e320819d89ca4624ab3c526544bb2183()
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

      private sealed class PROP_6ad2a7ec41484a74975087286504337f : HardwiredMemberDescriptor
      {
        internal PROP_6ad2a7ec41484a74975087286504337f()
          : base(typeof (bool), "inTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class PROP_e5be078c4940413095fb44c0b59c80a0 : HardwiredMemberDescriptor
      {
        internal PROP_e5be078c4940413095fb44c0b59c80a0()
          : base(typeof (bool), "isMoving", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class PROP_22ca0d7ff1004225bc1b3848524d3158 : HardwiredMemberDescriptor
      {
        internal PROP_22ca0d7ff1004225bc1b3848524d3158()
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

      private sealed class PROP_21f416055f1e48a9811076a1f967f993 : HardwiredMemberDescriptor
      {
        internal PROP_21f416055f1e48a9811076a1f967f993()
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

      private sealed class PROP_b9d65caaa47445d999539bc6dc4fcdf3 : HardwiredMemberDescriptor
      {
        internal PROP_b9d65caaa47445d999539bc6dc4fcdf3()
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

      private sealed class PROP_6ce048231bd4415990f7ce7940f9f642 : HardwiredMemberDescriptor
      {
        internal PROP_6ce048231bd4415990f7ce7940f9f642()
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

      private sealed class PROP_6f6a65c017b44cbba40b165753004891 : HardwiredMemberDescriptor
      {
        internal PROP_6f6a65c017b44cbba40b165753004891()
          : base(typeof (bool), "inWater", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class PROP_79ea4903ea5a487bbfde20b3498ef255 : HardwiredMemberDescriptor
      {
        internal PROP_79ea4903ea5a487bbfde20b3498ef255()
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

      private sealed class PROP_ebc46f34775a414cb4aafdf089d7a3fa : HardwiredMemberDescriptor
      {
        internal PROP_ebc46f34775a414cb4aafdf089d7a3fa()
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

      private sealed class PROP_1401965c07124a3289fbfc6f1a7053df : HardwiredMemberDescriptor
      {
        internal PROP_1401965c07124a3289fbfc6f1a7053df()
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

      private sealed class PROP_c5fc4fc4c4ba42638b2b3f4769b472cb : HardwiredMemberDescriptor
      {
        internal PROP_c5fc4fc4c4ba42638b2b3f4769b472cb()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class PROP_df236c33b8be4bd6b582f154d5d309e9 : HardwiredMemberDescriptor
      {
        internal PROP_df236c33b8be4bd6b582f154d5d309e9()
          : base(typeof (bool), "isRider", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class PROP_8bc41e1252b94ab4973ab7755b3b98fd : HardwiredMemberDescriptor
      {
        internal PROP_8bc41e1252b94ab4973ab7755b3b98fd()
          : base(typeof (bool), "isMounted", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class PROP_62ef6dc0300549cc984892d001070fba : HardwiredMemberDescriptor
      {
        internal PROP_62ef6dc0300549cc984892d001070fba()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class PROP_d2660eb05cb74cb18ee4c34c109ffb8b : HardwiredMemberDescriptor
      {
        internal PROP_d2660eb05cb74cb18ee4c34c109ffb8b()
          : base(typeof (bool), "isPawn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class PROP_2f34f79958114c06a08e6fd2b855b791 : HardwiredMemberDescriptor
      {
        internal PROP_2f34f79958114c06a08e6fd2b855b791()
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

      private sealed class PROP_2b54986b0ba847aca7787bf4e3dbe940 : HardwiredMemberDescriptor
      {
        internal PROP_2b54986b0ba847aca7787bf4e3dbe940()
          : base(typeof (bool), "isMountable", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class PROP_fb19ed868b2643d8808053d89f5aa4d1 : HardwiredMemberDescriptor
      {
        internal PROP_fb19ed868b2643d8808053d89f5aa4d1()
          : base(typeof (bool), "canMount", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class PROP_4d5b54ae5b494e78b68c5c1dbe9d0d47 : HardwiredMemberDescriptor
      {
        internal PROP_4d5b54ae5b494e78b68c5c1dbe9d0d47()
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

      private sealed class PROP_47b99877eb7b4914a5cf369b99d8b0ef : HardwiredMemberDescriptor
      {
        internal PROP_47b99877eb7b4914a5cf369b99d8b0ef()
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

    private sealed class TYPE_cf43a204e20041809c6e7d79b34fd08b : HardwiredUserDataDescriptor
    {
      internal TYPE_cf43a204e20041809c6e7d79b34fd08b()
        : base(typeof (ContainerEffector))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cf43a204e20041809c6e7d79b34fd08b.MTHD_81a97d2dfd06420ca9522a86929051b2()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cf43a204e20041809c6e7d79b34fd08b.MTHD_bb78f2da6f7e4ac9ba411a22bef2e852()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cf43a204e20041809c6e7d79b34fd08b.MTHD_fa3efa5ad61c43a693d56bdb3b754e99()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cf43a204e20041809c6e7d79b34fd08b.MTHD_735f7c7c49b749908c825c2e317e4259()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cf43a204e20041809c6e7d79b34fd08b.MTHD_d570696503eb434992634f00b8cf22c3()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cf43a204e20041809c6e7d79b34fd08b.MTHD_e903dc413ba44276bd5b770e89a480ca()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cf43a204e20041809c6e7d79b34fd08b.MTHD_0ec71b5ddb5940eaa75e9f9d4e37cab6()
        }));
        this.AddMember("get_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cf43a204e20041809c6e7d79b34fd08b.MTHD_9211b13ff6f24139a280bada4ba9fbff()
        }));
        this.AddMember("set_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cf43a204e20041809c6e7d79b34fd08b.MTHD_2e1d9c8c27ad4c9b97e27a129833b128()
        }));
        this.AddMember("get_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cf43a204e20041809c6e7d79b34fd08b.MTHD_0fda9aa16b424dd5b88eca9df8a821cc()
        }));
        this.AddMember("set_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cf43a204e20041809c6e7d79b34fd08b.MTHD_029ae13b3900428abfb04920ad7b41ed()
        }));
        this.AddMember("get_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cf43a204e20041809c6e7d79b34fd08b.MTHD_cca5432f8c9f4f279916f09fb09ecd29()
        }));
        this.AddMember("set_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cf43a204e20041809c6e7d79b34fd08b.MTHD_1728b7165652412e8dbc3039b1d588db()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cf43a204e20041809c6e7d79b34fd08b.MTHD_49175015ea424cba984742e66c0577d0()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cf43a204e20041809c6e7d79b34fd08b.MTHD_75982ace55a14aeabf5b2f70635051f9()
        }));
        this.AddMember("turnPassed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("turnPassed", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cf43a204e20041809c6e7d79b34fd08b.MTHD_3d1911b01b2245bf90873c81c4ef3f1b()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cf43a204e20041809c6e7d79b34fd08b.MTHD_9a7365b3985b4428836775423a8195ed()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cf43a204e20041809c6e7d79b34fd08b.MTHD_64c416b580a84a87a9ef61aac0aec6d9()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cf43a204e20041809c6e7d79b34fd08b.MTHD_8d7cad44454b4caaa0156654f0d160b5()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cf43a204e20041809c6e7d79b34fd08b.MTHD_771b39a8cf2840338ab38536891fd5ef()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_cf43a204e20041809c6e7d79b34fd08b.PROP_d443103d51e040dcba07721c489ab894());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_cf43a204e20041809c6e7d79b34fd08b.PROP_e07ef72d7163465689551f26501968df());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_cf43a204e20041809c6e7d79b34fd08b.PROP_f409943e034340799f8be2078198bc75());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_cf43a204e20041809c6e7d79b34fd08b.PROP_9e9accf29433489b9ba7139ce8dfcb2e());
        this.AddMember("turnsAlive", (IMemberDescriptor) new Bridge.TYPE_cf43a204e20041809c6e7d79b34fd08b.PROP_cc74cd672932413893122cf4fa51ccc7());
        this.AddMember("maxTurnsAlive", (IMemberDescriptor) new Bridge.TYPE_cf43a204e20041809c6e7d79b34fd08b.PROP_d1478434973d408d9ffb709547d1163f());
        this.AddMember("active", (IMemberDescriptor) new Bridge.TYPE_cf43a204e20041809c6e7d79b34fd08b.PROP_ea191bbe9a1544aba078305d846e5e70());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_cf43a204e20041809c6e7d79b34fd08b.PROP_b8d2ba766f1542b7b69eb1ac07abc143());
      }

      private sealed class MTHD_81a97d2dfd06420ca9522a86929051b2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_81a97d2dfd06420ca9522a86929051b2()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class MTHD_bb78f2da6f7e4ac9ba411a22bef2e852 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bb78f2da6f7e4ac9ba411a22bef2e852()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).x;
        }
      }

      private sealed class MTHD_fa3efa5ad61c43a693d56bdb3b754e99 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fa3efa5ad61c43a693d56bdb3b754e99()
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

      private sealed class MTHD_735f7c7c49b749908c825c2e317e4259 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_735f7c7c49b749908c825c2e317e4259()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).y;
        }
      }

      private sealed class MTHD_d570696503eb434992634f00b8cf22c3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d570696503eb434992634f00b8cf22c3()
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

      private sealed class MTHD_e903dc413ba44276bd5b770e89a480ca : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e903dc413ba44276bd5b770e89a480ca()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).position;
        }
      }

      private sealed class MTHD_0ec71b5ddb5940eaa75e9f9d4e37cab6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0ec71b5ddb5940eaa75e9f9d4e37cab6()
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

      private sealed class MTHD_9211b13ff6f24139a280bada4ba9fbff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9211b13ff6f24139a280bada4ba9fbff()
        {
          this.Initialize("get_turnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).turnsAlive;
        }
      }

      private sealed class MTHD_2e1d9c8c27ad4c9b97e27a129833b128 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2e1d9c8c27ad4c9b97e27a129833b128()
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

      private sealed class MTHD_0fda9aa16b424dd5b88eca9df8a821cc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0fda9aa16b424dd5b88eca9df8a821cc()
        {
          this.Initialize("get_maxTurnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).maxTurnsAlive;
        }
      }

      private sealed class MTHD_029ae13b3900428abfb04920ad7b41ed : HardwiredMethodMemberDescriptor
      {
        internal MTHD_029ae13b3900428abfb04920ad7b41ed()
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

      private sealed class MTHD_cca5432f8c9f4f279916f09fb09ecd29 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cca5432f8c9f4f279916f09fb09ecd29()
        {
          this.Initialize("get_active", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).active;
        }
      }

      private sealed class MTHD_1728b7165652412e8dbc3039b1d588db : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1728b7165652412e8dbc3039b1d588db()
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

      private sealed class MTHD_49175015ea424cba984742e66c0577d0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_49175015ea424cba984742e66c0577d0()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }

      private sealed class MTHD_75982ace55a14aeabf5b2f70635051f9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_75982ace55a14aeabf5b2f70635051f9()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_3d1911b01b2245bf90873c81c4ef3f1b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3d1911b01b2245bf90873c81c4ef3f1b()
        {
          this.Initialize("turnPassed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).turnPassed();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_9a7365b3985b4428836775423a8195ed : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9a7365b3985b4428836775423a8195ed()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).GetHashCode();
        }
      }

      private sealed class MTHD_64c416b580a84a87a9ef61aac0aec6d9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_64c416b580a84a87a9ef61aac0aec6d9()
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

      private sealed class MTHD_8d7cad44454b4caaa0156654f0d160b5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8d7cad44454b4caaa0156654f0d160b5()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_771b39a8cf2840338ab38536891fd5ef : HardwiredMethodMemberDescriptor
      {
        internal MTHD_771b39a8cf2840338ab38536891fd5ef()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_d443103d51e040dcba07721c489ab894 : HardwiredMemberDescriptor
      {
        internal PROP_d443103d51e040dcba07721c489ab894()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class PROP_e07ef72d7163465689551f26501968df : HardwiredMemberDescriptor
      {
        internal PROP_e07ef72d7163465689551f26501968df()
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

      private sealed class PROP_f409943e034340799f8be2078198bc75 : HardwiredMemberDescriptor
      {
        internal PROP_f409943e034340799f8be2078198bc75()
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

      private sealed class PROP_9e9accf29433489b9ba7139ce8dfcb2e : HardwiredMemberDescriptor
      {
        internal PROP_9e9accf29433489b9ba7139ce8dfcb2e()
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

      private sealed class PROP_cc74cd672932413893122cf4fa51ccc7 : HardwiredMemberDescriptor
      {
        internal PROP_cc74cd672932413893122cf4fa51ccc7()
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

      private sealed class PROP_d1478434973d408d9ffb709547d1163f : HardwiredMemberDescriptor
      {
        internal PROP_d1478434973d408d9ffb709547d1163f()
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

      private sealed class PROP_ea191bbe9a1544aba078305d846e5e70 : HardwiredMemberDescriptor
      {
        internal PROP_ea191bbe9a1544aba078305d846e5e70()
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

      private sealed class PROP_b8d2ba766f1542b7b69eb1ac07abc143 : HardwiredMemberDescriptor
      {
        internal PROP_b8d2ba766f1542b7b69eb1ac07abc143()
          : base(typeof (EffectorType), "type", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }
    }

    private sealed class TYPE_c9da66a41b9d417c9edad978d8331c68 : HardwiredUserDataDescriptor
    {
      internal TYPE_c9da66a41b9d417c9edad978d8331c68()
        : base(typeof (ContainerIndicator))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9da66a41b9d417c9edad978d8331c68.MTHD_91b80c7ac0c043ca8e9359caebf1c4ff()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9da66a41b9d417c9edad978d8331c68.MTHD_f8a0f6fe7cea4a63966ac963111bac73()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9da66a41b9d417c9edad978d8331c68.MTHD_60f1b7c3d01f47f18530c9cc4220569a()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9da66a41b9d417c9edad978d8331c68.MTHD_f4428ddeb7e6452c8a41e0f018c60a6b()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9da66a41b9d417c9edad978d8331c68.MTHD_22705b31e16847ab8da835aaa537be94()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9da66a41b9d417c9edad978d8331c68.MTHD_07082e3f314a4801a5a212ce7c4e15ba()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9da66a41b9d417c9edad978d8331c68.MTHD_b2ade643490941efb83cca513485c29e()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9da66a41b9d417c9edad978d8331c68.MTHD_319c1695a3c444d1b62a99db40bb1895()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9da66a41b9d417c9edad978d8331c68.MTHD_2b11fae23e5b4e288bc61393410b1bd6()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9da66a41b9d417c9edad978d8331c68.MTHD_e0d52db782594782abcab09cd078d416()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9da66a41b9d417c9edad978d8331c68.MTHD_3c7a6dfcbc98471c8fd7cd48f3f2ee5c()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9da66a41b9d417c9edad978d8331c68.MTHD_153fa9fce3ce4e419e3b2f0f7cb49fdd()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9da66a41b9d417c9edad978d8331c68.MTHD_f3d7d9a4b23f43d49c772bd7483d5819()
        }));
        this.AddMember("get_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color2", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9da66a41b9d417c9edad978d8331c68.MTHD_22b0155a5d064d319af2327c0afae17f()
        }));
        this.AddMember("set_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color2", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9da66a41b9d417c9edad978d8331c68.MTHD_be0f1b93838a4eb4bbb89d1deb565ee7()
        }));
        this.AddMember("get_kind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_kind", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9da66a41b9d417c9edad978d8331c68.MTHD_a986f7133db2482d90d0689d7434fde2()
        }));
        this.AddMember("setIcon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setIcon", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9da66a41b9d417c9edad978d8331c68.MTHD_76fa745d72f84ee786f06276956d5190()
        }));
        this.AddMember("Destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Destroy", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9da66a41b9d417c9edad978d8331c68.MTHD_6372b615e59f4ad4aaa781b6726d9e25()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9da66a41b9d417c9edad978d8331c68.MTHD_38668f60de7746cf8de8ee7ea72f14ea()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9da66a41b9d417c9edad978d8331c68.MTHD_dbea375d1a0747ff8d58954e13f0aff7()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9da66a41b9d417c9edad978d8331c68.MTHD_016a7be6c9a948c7b7a1f82d0ac5e161()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9da66a41b9d417c9edad978d8331c68.MTHD_7ea075049bc24d409d96798d28dc5343()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_c9da66a41b9d417c9edad978d8331c68.PROP_b04df063dd1e4326a78de293fde68b95());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_c9da66a41b9d417c9edad978d8331c68.PROP_7b5f5053f6384d439028f76f2002e5cf());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_c9da66a41b9d417c9edad978d8331c68.PROP_6290257231884a439e9909b829cdc04a());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_c9da66a41b9d417c9edad978d8331c68.PROP_f31b81c39ed9463ea50f09dccd7811e1());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_c9da66a41b9d417c9edad978d8331c68.PROP_0ed4775e2ae24526939448cf8cd8c57a());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_c9da66a41b9d417c9edad978d8331c68.PROP_ee530cae187a41eaa3999526b80f0c2d());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_c9da66a41b9d417c9edad978d8331c68.PROP_2bd6b36d9b4a4ece8301637a29d36f03());
        this.AddMember("color2", (IMemberDescriptor) new Bridge.TYPE_c9da66a41b9d417c9edad978d8331c68.PROP_50be2ea93db44822a4928aeeaf37e0c3());
        this.AddMember("kind", (IMemberDescriptor) new Bridge.TYPE_c9da66a41b9d417c9edad978d8331c68.PROP_8ff79ad026384ddfb6b0e5647c18cc7d());
      }

      private sealed class MTHD_91b80c7ac0c043ca8e9359caebf1c4ff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_91b80c7ac0c043ca8e9359caebf1c4ff()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class MTHD_f8a0f6fe7cea4a63966ac963111bac73 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f8a0f6fe7cea4a63966ac963111bac73()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).x;
        }
      }

      private sealed class MTHD_60f1b7c3d01f47f18530c9cc4220569a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_60f1b7c3d01f47f18530c9cc4220569a()
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

      private sealed class MTHD_f4428ddeb7e6452c8a41e0f018c60a6b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f4428ddeb7e6452c8a41e0f018c60a6b()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).y;
        }
      }

      private sealed class MTHD_22705b31e16847ab8da835aaa537be94 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_22705b31e16847ab8da835aaa537be94()
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

      private sealed class MTHD_07082e3f314a4801a5a212ce7c4e15ba : HardwiredMethodMemberDescriptor
      {
        internal MTHD_07082e3f314a4801a5a212ce7c4e15ba()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).radius;
        }
      }

      private sealed class MTHD_b2ade643490941efb83cca513485c29e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b2ade643490941efb83cca513485c29e()
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

      private sealed class MTHD_319c1695a3c444d1b62a99db40bb1895 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_319c1695a3c444d1b62a99db40bb1895()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).position;
        }
      }

      private sealed class MTHD_2b11fae23e5b4e288bc61393410b1bd6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2b11fae23e5b4e288bc61393410b1bd6()
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

      private sealed class MTHD_e0d52db782594782abcab09cd078d416 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e0d52db782594782abcab09cd078d416()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).angle;
        }
      }

      private sealed class MTHD_3c7a6dfcbc98471c8fd7cd48f3f2ee5c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3c7a6dfcbc98471c8fd7cd48f3f2ee5c()
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

      private sealed class MTHD_153fa9fce3ce4e419e3b2f0f7cb49fdd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_153fa9fce3ce4e419e3b2f0f7cb49fdd()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color;
        }
      }

      private sealed class MTHD_f3d7d9a4b23f43d49c772bd7483d5819 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f3d7d9a4b23f43d49c772bd7483d5819()
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

      private sealed class MTHD_22b0155a5d064d319af2327c0afae17f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_22b0155a5d064d319af2327c0afae17f()
        {
          this.Initialize("get_color2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color2;
        }
      }

      private sealed class MTHD_be0f1b93838a4eb4bbb89d1deb565ee7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_be0f1b93838a4eb4bbb89d1deb565ee7()
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

      private sealed class MTHD_a986f7133db2482d90d0689d7434fde2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a986f7133db2482d90d0689d7434fde2()
        {
          this.Initialize("get_kind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }

      private sealed class MTHD_76fa745d72f84ee786f06276956d5190 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_76fa745d72f84ee786f06276956d5190()
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

      private sealed class MTHD_6372b615e59f4ad4aaa781b6726d9e25 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6372b615e59f4ad4aaa781b6726d9e25()
        {
          this.Initialize("Destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerIndicator) obj).Destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_38668f60de7746cf8de8ee7ea72f14ea : HardwiredMethodMemberDescriptor
      {
        internal MTHD_38668f60de7746cf8de8ee7ea72f14ea()
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

      private sealed class MTHD_dbea375d1a0747ff8d58954e13f0aff7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dbea375d1a0747ff8d58954e13f0aff7()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_016a7be6c9a948c7b7a1f82d0ac5e161 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_016a7be6c9a948c7b7a1f82d0ac5e161()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_7ea075049bc24d409d96798d28dc5343 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7ea075049bc24d409d96798d28dc5343()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_b04df063dd1e4326a78de293fde68b95 : HardwiredMemberDescriptor
      {
        internal PROP_b04df063dd1e4326a78de293fde68b95()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class PROP_7b5f5053f6384d439028f76f2002e5cf : HardwiredMemberDescriptor
      {
        internal PROP_7b5f5053f6384d439028f76f2002e5cf()
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

      private sealed class PROP_6290257231884a439e9909b829cdc04a : HardwiredMemberDescriptor
      {
        internal PROP_6290257231884a439e9909b829cdc04a()
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

      private sealed class PROP_f31b81c39ed9463ea50f09dccd7811e1 : HardwiredMemberDescriptor
      {
        internal PROP_f31b81c39ed9463ea50f09dccd7811e1()
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

      private sealed class PROP_0ed4775e2ae24526939448cf8cd8c57a : HardwiredMemberDescriptor
      {
        internal PROP_0ed4775e2ae24526939448cf8cd8c57a()
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

      private sealed class PROP_ee530cae187a41eaa3999526b80f0c2d : HardwiredMemberDescriptor
      {
        internal PROP_ee530cae187a41eaa3999526b80f0c2d()
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

      private sealed class PROP_2bd6b36d9b4a4ece8301637a29d36f03 : HardwiredMemberDescriptor
      {
        internal PROP_2bd6b36d9b4a4ece8301637a29d36f03()
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

      private sealed class PROP_50be2ea93db44822a4928aeeaf37e0c3 : HardwiredMemberDescriptor
      {
        internal PROP_50be2ea93db44822a4928aeeaf37e0c3()
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

      private sealed class PROP_8ff79ad026384ddfb6b0e5647c18cc7d : HardwiredMemberDescriptor
      {
        internal PROP_8ff79ad026384ddfb6b0e5647c18cc7d()
          : base(typeof (IndicatorKind), "kind", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }
    }

    private sealed class TYPE_c4239e7ded4f4d59b2e495047a1d506c : HardwiredUserDataDescriptor
    {
      internal TYPE_c4239e7ded4f4d59b2e495047a1d506c()
        : base(typeof (ContainerSpell))
      {
        this.AddMember("get_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c4239e7ded4f4d59b2e495047a1d506c.MTHD_b51ac0d608c44652bee99c12334495fa()
        }));
        this.AddMember("set_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c4239e7ded4f4d59b2e495047a1d506c.MTHD_55e97c9c7d2e4dab872316aaf0e1cc80()
        }));
        this.AddMember("get_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c4239e7ded4f4d59b2e495047a1d506c.MTHD_1974ee10886f49fdb3367a0ffc6dc3c4()
        }));
        this.AddMember("set_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c4239e7ded4f4d59b2e495047a1d506c.MTHD_80cd7e746c7c46d6bbb5b2685b00ef00()
        }));
        this.AddMember("get_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c4239e7ded4f4d59b2e495047a1d506c.MTHD_5480d5e6786340a8803222d4e12645f4()
        }));
        this.AddMember("set_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c4239e7ded4f4d59b2e495047a1d506c.MTHD_228f8743aa53433da09056175f9c972a()
        }));
        this.AddMember("get_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c4239e7ded4f4d59b2e495047a1d506c.MTHD_363194d966b446e18c4d5edce0d5feff()
        }));
        this.AddMember("set_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c4239e7ded4f4d59b2e495047a1d506c.MTHD_b9b975b5894e4e8b85d5592ce444599c()
        }));
        this.AddMember("get_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c4239e7ded4f4d59b2e495047a1d506c.MTHD_15d4cef2a2fb44278b829d23a731ba9b()
        }));
        this.AddMember("set_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c4239e7ded4f4d59b2e495047a1d506c.MTHD_1f1d42772a1c4f2e8d3cf69711456b83()
        }));
        this.AddMember("get_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c4239e7ded4f4d59b2e495047a1d506c.MTHD_0b1b989924a542aeb411d6e1310af46a()
        }));
        this.AddMember("set_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c4239e7ded4f4d59b2e495047a1d506c.MTHD_9695f1081c504b52986aa5d746f0484b()
        }));
        this.AddMember("get_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c4239e7ded4f4d59b2e495047a1d506c.MTHD_97565cdb419a44f7a8c88af416e26f6a()
        }));
        this.AddMember("set_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c4239e7ded4f4d59b2e495047a1d506c.MTHD_6212e5f26a3b4ff188e776143212ca9b()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c4239e7ded4f4d59b2e495047a1d506c.MTHD_122efdbdf53343a1a0b822b5169e2f3a()
        }));
        this.AddMember("get_castType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_castType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c4239e7ded4f4d59b2e495047a1d506c.MTHD_0ea9ce8ae99c4ac6ac9e137b6e0124f0()
        }));
        this.AddMember("get_damageType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damageType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c4239e7ded4f4d59b2e495047a1d506c.MTHD_26dc2bfe9e2246f5a11eb5ff3af082b9()
        }));
        this.AddMember("get_book", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_book", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c4239e7ded4f4d59b2e495047a1d506c.MTHD_6202814c878c49b69544bb2775c1aafd()
        }));
        this.AddMember("get_damage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damage", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c4239e7ded4f4d59b2e495047a1d506c.MTHD_c207df51414840228ba043247d3e2c23()
        }));
        this.AddMember("get_explosionRadius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_explosionRadius", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c4239e7ded4f4d59b2e495047a1d506c.MTHD_fbcc2f1ba7964f668d9ea316232b10c5()
        }));
        this.AddMember("get_description", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_description", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c4239e7ded4f4d59b2e495047a1d506c.MTHD_a6988c824679422c8c3c7ce2f57bb20b()
        }));
        this.AddMember("get_descriptionOnly", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionOnly", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c4239e7ded4f4d59b2e495047a1d506c.MTHD_f0cfb60445f8461ba1cd3bfbf66ddcec()
        }));
        this.AddMember("get_descriptionExtra", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionExtra", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c4239e7ded4f4d59b2e495047a1d506c.MTHD_2845b0348eea44f29f62a7144e532e64()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c4239e7ded4f4d59b2e495047a1d506c.MTHD_643e00a3e5db48ba9edf2c187e7f455e()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c4239e7ded4f4d59b2e495047a1d506c.MTHD_86a66e076c87471faed615db1caf83f9()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c4239e7ded4f4d59b2e495047a1d506c.MTHD_385f8b644813491f8e6d020cd4bef27e()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c4239e7ded4f4d59b2e495047a1d506c.MTHD_042bb0bcf1ce4b999314d77855055562()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c4239e7ded4f4d59b2e495047a1d506c.MTHD_b0dafc675c4a47a39586a6c8f2fc01bc()
        }));
        this.AddMember("uses", (IMemberDescriptor) new Bridge.TYPE_c4239e7ded4f4d59b2e495047a1d506c.PROP_8eeb61250ac843ceb134e4b853ccf149());
        this.AddMember("maxUses", (IMemberDescriptor) new Bridge.TYPE_c4239e7ded4f4d59b2e495047a1d506c.PROP_f693545a931a45249ccaf62ca6060789());
        this.AddMember("rechargeTime", (IMemberDescriptor) new Bridge.TYPE_c4239e7ded4f4d59b2e495047a1d506c.PROP_dbdd637ce7864c9291d2d3be5131309d());
        this.AddMember("lastTurnFired", (IMemberDescriptor) new Bridge.TYPE_c4239e7ded4f4d59b2e495047a1d506c.PROP_053d3209937f4ef2a16459caadc52e11());
        this.AddMember("isPresent", (IMemberDescriptor) new Bridge.TYPE_c4239e7ded4f4d59b2e495047a1d506c.PROP_e5f6029c442a4bbeb38a55de1ffbfd81());
        this.AddMember("locked", (IMemberDescriptor) new Bridge.TYPE_c4239e7ded4f4d59b2e495047a1d506c.PROP_b24aa6e757d048b681e5c8c05be728c0());
        this.AddMember("turnsTillFirstUse", (IMemberDescriptor) new Bridge.TYPE_c4239e7ded4f4d59b2e495047a1d506c.PROP_98fb5511c16c4c24aa4d82c1cb697f22());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_c4239e7ded4f4d59b2e495047a1d506c.PROP_9372bc2940b4402097b98f395c2b2ca1());
        this.AddMember("castType", (IMemberDescriptor) new Bridge.TYPE_c4239e7ded4f4d59b2e495047a1d506c.PROP_ef79fb2caf7f46948429d03bdd20d836());
        this.AddMember("damageType", (IMemberDescriptor) new Bridge.TYPE_c4239e7ded4f4d59b2e495047a1d506c.PROP_e4592f2d734e417e82bb9685651af1d6());
        this.AddMember("book", (IMemberDescriptor) new Bridge.TYPE_c4239e7ded4f4d59b2e495047a1d506c.PROP_df111b46994f42aa8f7cd3977a332593());
        this.AddMember("damage", (IMemberDescriptor) new Bridge.TYPE_c4239e7ded4f4d59b2e495047a1d506c.PROP_ffa3c22dd96449ba9c77f7893dc61271());
        this.AddMember("explosionRadius", (IMemberDescriptor) new Bridge.TYPE_c4239e7ded4f4d59b2e495047a1d506c.PROP_f2711c04221a432aaa055f616eaea6fe());
        this.AddMember("description", (IMemberDescriptor) new Bridge.TYPE_c4239e7ded4f4d59b2e495047a1d506c.PROP_bdfcf167fa6e49ab9f77a5a2b08f0606());
        this.AddMember("descriptionOnly", (IMemberDescriptor) new Bridge.TYPE_c4239e7ded4f4d59b2e495047a1d506c.PROP_04ae10130744469f846a6b65527f3203());
        this.AddMember("descriptionExtra", (IMemberDescriptor) new Bridge.TYPE_c4239e7ded4f4d59b2e495047a1d506c.PROP_87b23d22aad64feab425e72dd509f641());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_c4239e7ded4f4d59b2e495047a1d506c.PROP_a3c40102fd104027b7886aa83a45a2ef());
      }

      private sealed class MTHD_b51ac0d608c44652bee99c12334495fa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b51ac0d608c44652bee99c12334495fa()
        {
          this.Initialize("get_uses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).uses;
        }
      }

      private sealed class MTHD_55e97c9c7d2e4dab872316aaf0e1cc80 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_55e97c9c7d2e4dab872316aaf0e1cc80()
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

      private sealed class MTHD_1974ee10886f49fdb3367a0ffc6dc3c4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1974ee10886f49fdb3367a0ffc6dc3c4()
        {
          this.Initialize("get_maxUses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).maxUses;
        }
      }

      private sealed class MTHD_80cd7e746c7c46d6bbb5b2685b00ef00 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_80cd7e746c7c46d6bbb5b2685b00ef00()
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

      private sealed class MTHD_5480d5e6786340a8803222d4e12645f4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5480d5e6786340a8803222d4e12645f4()
        {
          this.Initialize("get_rechargeTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).rechargeTime;
        }
      }

      private sealed class MTHD_228f8743aa53433da09056175f9c972a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_228f8743aa53433da09056175f9c972a()
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

      private sealed class MTHD_363194d966b446e18c4d5edce0d5feff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_363194d966b446e18c4d5edce0d5feff()
        {
          this.Initialize("get_lastTurnFired", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).lastTurnFired;
        }
      }

      private sealed class MTHD_b9b975b5894e4e8b85d5592ce444599c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b9b975b5894e4e8b85d5592ce444599c()
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

      private sealed class MTHD_15d4cef2a2fb44278b829d23a731ba9b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_15d4cef2a2fb44278b829d23a731ba9b()
        {
          this.Initialize("get_isPresent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).isPresent;
        }
      }

      private sealed class MTHD_1f1d42772a1c4f2e8d3cf69711456b83 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1f1d42772a1c4f2e8d3cf69711456b83()
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

      private sealed class MTHD_0b1b989924a542aeb411d6e1310af46a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0b1b989924a542aeb411d6e1310af46a()
        {
          this.Initialize("get_locked", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).locked;
        }
      }

      private sealed class MTHD_9695f1081c504b52986aa5d746f0484b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9695f1081c504b52986aa5d746f0484b()
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

      private sealed class MTHD_97565cdb419a44f7a8c88af416e26f6a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_97565cdb419a44f7a8c88af416e26f6a()
        {
          this.Initialize("get_turnsTillFirstUse", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).turnsTillFirstUse;
        }
      }

      private sealed class MTHD_6212e5f26a3b4ff188e776143212ca9b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6212e5f26a3b4ff188e776143212ca9b()
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

      private sealed class MTHD_122efdbdf53343a1a0b822b5169e2f3a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_122efdbdf53343a1a0b822b5169e2f3a()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class MTHD_0ea9ce8ae99c4ac6ac9e137b6e0124f0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0ea9ce8ae99c4ac6ac9e137b6e0124f0()
        {
          this.Initialize("get_castType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class MTHD_26dc2bfe9e2246f5a11eb5ff3af082b9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_26dc2bfe9e2246f5a11eb5ff3af082b9()
        {
          this.Initialize("get_damageType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class MTHD_6202814c878c49b69544bb2775c1aafd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6202814c878c49b69544bb2775c1aafd()
        {
          this.Initialize("get_book", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class MTHD_c207df51414840228ba043247d3e2c23 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c207df51414840228ba043247d3e2c23()
        {
          this.Initialize("get_damage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class MTHD_fbcc2f1ba7964f668d9ea316232b10c5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fbcc2f1ba7964f668d9ea316232b10c5()
        {
          this.Initialize("get_explosionRadius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class MTHD_a6988c824679422c8c3c7ce2f57bb20b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a6988c824679422c8c3c7ce2f57bb20b()
        {
          this.Initialize("get_description", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class MTHD_f0cfb60445f8461ba1cd3bfbf66ddcec : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f0cfb60445f8461ba1cd3bfbf66ddcec()
        {
          this.Initialize("get_descriptionOnly", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class MTHD_2845b0348eea44f29f62a7144e532e64 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2845b0348eea44f29f62a7144e532e64()
        {
          this.Initialize("get_descriptionExtra", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class MTHD_643e00a3e5db48ba9edf2c187e7f455e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_643e00a3e5db48ba9edf2c187e7f455e()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }

      private sealed class MTHD_86a66e076c87471faed615db1caf83f9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_86a66e076c87471faed615db1caf83f9()
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

      private sealed class MTHD_385f8b644813491f8e6d020cd4bef27e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_385f8b644813491f8e6d020cd4bef27e()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_042bb0bcf1ce4b999314d77855055562 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_042bb0bcf1ce4b999314d77855055562()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_b0dafc675c4a47a39586a6c8f2fc01bc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b0dafc675c4a47a39586a6c8f2fc01bc()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_8eeb61250ac843ceb134e4b853ccf149 : HardwiredMemberDescriptor
      {
        internal PROP_8eeb61250ac843ceb134e4b853ccf149()
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

      private sealed class PROP_f693545a931a45249ccaf62ca6060789 : HardwiredMemberDescriptor
      {
        internal PROP_f693545a931a45249ccaf62ca6060789()
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

      private sealed class PROP_dbdd637ce7864c9291d2d3be5131309d : HardwiredMemberDescriptor
      {
        internal PROP_dbdd637ce7864c9291d2d3be5131309d()
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

      private sealed class PROP_053d3209937f4ef2a16459caadc52e11 : HardwiredMemberDescriptor
      {
        internal PROP_053d3209937f4ef2a16459caadc52e11()
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

      private sealed class PROP_e5f6029c442a4bbeb38a55de1ffbfd81 : HardwiredMemberDescriptor
      {
        internal PROP_e5f6029c442a4bbeb38a55de1ffbfd81()
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

      private sealed class PROP_b24aa6e757d048b681e5c8c05be728c0 : HardwiredMemberDescriptor
      {
        internal PROP_b24aa6e757d048b681e5c8c05be728c0()
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

      private sealed class PROP_98fb5511c16c4c24aa4d82c1cb697f22 : HardwiredMemberDescriptor
      {
        internal PROP_98fb5511c16c4c24aa4d82c1cb697f22()
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

      private sealed class PROP_9372bc2940b4402097b98f395c2b2ca1 : HardwiredMemberDescriptor
      {
        internal PROP_9372bc2940b4402097b98f395c2b2ca1()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class PROP_ef79fb2caf7f46948429d03bdd20d836 : HardwiredMemberDescriptor
      {
        internal PROP_ef79fb2caf7f46948429d03bdd20d836()
          : base(typeof (CastType), "castType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class PROP_e4592f2d734e417e82bb9685651af1d6 : HardwiredMemberDescriptor
      {
        internal PROP_e4592f2d734e417e82bb9685651af1d6()
          : base(typeof (DamageType), "damageType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class PROP_df111b46994f42aa8f7cd3977a332593 : HardwiredMemberDescriptor
      {
        internal PROP_df111b46994f42aa8f7cd3977a332593()
          : base(typeof (BookOf), "book", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class PROP_ffa3c22dd96449ba9c77f7893dc61271 : HardwiredMemberDescriptor
      {
        internal PROP_ffa3c22dd96449ba9c77f7893dc61271()
          : base(typeof (int), "damage", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class PROP_f2711c04221a432aaa055f616eaea6fe : HardwiredMemberDescriptor
      {
        internal PROP_f2711c04221a432aaa055f616eaea6fe()
          : base(typeof (int), "explosionRadius", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class PROP_bdfcf167fa6e49ab9f77a5a2b08f0606 : HardwiredMemberDescriptor
      {
        internal PROP_bdfcf167fa6e49ab9f77a5a2b08f0606()
          : base(typeof (string), "description", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class PROP_04ae10130744469f846a6b65527f3203 : HardwiredMemberDescriptor
      {
        internal PROP_04ae10130744469f846a6b65527f3203()
          : base(typeof (string), "descriptionOnly", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class PROP_87b23d22aad64feab425e72dd509f641 : HardwiredMemberDescriptor
      {
        internal PROP_87b23d22aad64feab425e72dd509f641()
          : base(typeof (string), "descriptionExtra", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class PROP_a3c40102fd104027b7886aa83a45a2ef : HardwiredMemberDescriptor
      {
        internal PROP_a3c40102fd104027b7886aa83a45a2ef()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }
    }

    private sealed class TYPE_06427f3d3a4a4e97850ef2efd61b00f9 : HardwiredUserDataDescriptor
    {
      internal TYPE_06427f3d3a4a4e97850ef2efd61b00f9()
        : base(typeof (ContainerTower))
      {
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06427f3d3a4a4e97850ef2efd61b00f9.MTHD_7dcdf660878c4f2e8a9cd5596b432f7f()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06427f3d3a4a4e97850ef2efd61b00f9.MTHD_65bd86d95a3542be824b788f00d3f9fe()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06427f3d3a4a4e97850ef2efd61b00f9.MTHD_3eac3bb829604cc1b20d4c5100414822()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06427f3d3a4a4e97850ef2efd61b00f9.MTHD_24a824e8d2144c8c9bcb14654c1ba64b()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06427f3d3a4a4e97850ef2efd61b00f9.MTHD_5fa76672cce04bf3a33815c1b4316ae2()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06427f3d3a4a4e97850ef2efd61b00f9.MTHD_00582fbdc88c4648b9df504ef5d899e2()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06427f3d3a4a4e97850ef2efd61b00f9.MTHD_64f4f72817b84e229253b5eda98dfb5c()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06427f3d3a4a4e97850ef2efd61b00f9.MTHD_af7eb127a4054bea802c8f4b4e1264b0()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06427f3d3a4a4e97850ef2efd61b00f9.MTHD_878e9f446ea24fee879256db51d614e3()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06427f3d3a4a4e97850ef2efd61b00f9.MTHD_5d73e37c656048828b98be5247dab2a6()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06427f3d3a4a4e97850ef2efd61b00f9.MTHD_0ea57bde1e8341f792a5bffa1491e032()
        }));
        this.AddMember("getType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06427f3d3a4a4e97850ef2efd61b00f9.MTHD_b7dcd9c1793447138db5cc548d0f01f2()
        }));
        this.AddMember("kill", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("kill", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06427f3d3a4a4e97850ef2efd61b00f9.MTHD_d4acba93e5ef47a7b089c6b57af0f92d()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06427f3d3a4a4e97850ef2efd61b00f9.MTHD_0321f585b0504ea1a9636706945a020b()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06427f3d3a4a4e97850ef2efd61b00f9.MTHD_220ee2781ff543fb8f3cd40bbf9fd83d()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06427f3d3a4a4e97850ef2efd61b00f9.MTHD_f8f7a911768645658f2e71ce1f4e41b2()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06427f3d3a4a4e97850ef2efd61b00f9.MTHD_93dd54165176415bb55f0902aae4c5e7()
        }));
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_06427f3d3a4a4e97850ef2efd61b00f9.PROP_0350f3986a6b4891803ab8a450252893());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_06427f3d3a4a4e97850ef2efd61b00f9.PROP_43e0363c483945c7afde03eedf633f4d());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_06427f3d3a4a4e97850ef2efd61b00f9.PROP_4cb28c6117584c7fb38e64685ea78ad6());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_06427f3d3a4a4e97850ef2efd61b00f9.PROP_b5b24fe9de034268b721452fa5fd5f42());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_06427f3d3a4a4e97850ef2efd61b00f9.PROP_e6819c09c95f4c4492b566118bbcd01c());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_06427f3d3a4a4e97850ef2efd61b00f9.PROP_90d35cc5be664f36a0b5738a5429e951());
      }

      private sealed class MTHD_7dcdf660878c4f2e8a9cd5596b432f7f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7dcdf660878c4f2e8a9cd5596b432f7f()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).health;
        }
      }

      private sealed class MTHD_65bd86d95a3542be824b788f00d3f9fe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_65bd86d95a3542be824b788f00d3f9fe()
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

      private sealed class MTHD_3eac3bb829604cc1b20d4c5100414822 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3eac3bb829604cc1b20d4c5100414822()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).maxHealth;
        }
      }

      private sealed class MTHD_24a824e8d2144c8c9bcb14654c1ba64b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_24a824e8d2144c8c9bcb14654c1ba64b()
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

      private sealed class MTHD_5fa76672cce04bf3a33815c1b4316ae2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5fa76672cce04bf3a33815c1b4316ae2()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).x;
        }
      }

      private sealed class MTHD_00582fbdc88c4648b9df504ef5d899e2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_00582fbdc88c4648b9df504ef5d899e2()
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

      private sealed class MTHD_64f4f72817b84e229253b5eda98dfb5c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_64f4f72817b84e229253b5eda98dfb5c()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).y;
        }
      }

      private sealed class MTHD_af7eb127a4054bea802c8f4b4e1264b0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_af7eb127a4054bea802c8f4b4e1264b0()
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

      private sealed class MTHD_878e9f446ea24fee879256db51d614e3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_878e9f446ea24fee879256db51d614e3()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).position;
        }
      }

      private sealed class MTHD_5d73e37c656048828b98be5247dab2a6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5d73e37c656048828b98be5247dab2a6()
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

      private sealed class MTHD_0ea57bde1e8341f792a5bffa1491e032 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0ea57bde1e8341f792a5bffa1491e032()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }

      private sealed class MTHD_b7dcd9c1793447138db5cc548d0f01f2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b7dcd9c1793447138db5cc548d0f01f2()
        {
          this.Initialize("getType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).getType();
        }
      }

      private sealed class MTHD_d4acba93e5ef47a7b089c6b57af0f92d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d4acba93e5ef47a7b089c6b57af0f92d()
        {
          this.Initialize("kill", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerTower) obj).kill();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_0321f585b0504ea1a9636706945a020b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0321f585b0504ea1a9636706945a020b()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).GetHashCode();
        }
      }

      private sealed class MTHD_220ee2781ff543fb8f3cd40bbf9fd83d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_220ee2781ff543fb8f3cd40bbf9fd83d()
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

      private sealed class MTHD_f8f7a911768645658f2e71ce1f4e41b2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f8f7a911768645658f2e71ce1f4e41b2()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_93dd54165176415bb55f0902aae4c5e7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_93dd54165176415bb55f0902aae4c5e7()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_0350f3986a6b4891803ab8a450252893 : HardwiredMemberDescriptor
      {
        internal PROP_0350f3986a6b4891803ab8a450252893()
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

      private sealed class PROP_43e0363c483945c7afde03eedf633f4d : HardwiredMemberDescriptor
      {
        internal PROP_43e0363c483945c7afde03eedf633f4d()
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

      private sealed class PROP_4cb28c6117584c7fb38e64685ea78ad6 : HardwiredMemberDescriptor
      {
        internal PROP_4cb28c6117584c7fb38e64685ea78ad6()
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

      private sealed class PROP_b5b24fe9de034268b721452fa5fd5f42 : HardwiredMemberDescriptor
      {
        internal PROP_b5b24fe9de034268b721452fa5fd5f42()
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

      private sealed class PROP_e6819c09c95f4c4492b566118bbcd01c : HardwiredMemberDescriptor
      {
        internal PROP_e6819c09c95f4c4492b566118bbcd01c()
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

      private sealed class PROP_90d35cc5be664f36a0b5738a5429e951 : HardwiredMemberDescriptor
      {
        internal PROP_90d35cc5be664f36a0b5738a5429e951()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }
    }

    private sealed class TYPE_9895a7e27519452db7053d978fd602c1 : HardwiredUserDataDescriptor
    {
      internal TYPE_9895a7e27519452db7053d978fd602c1()
        : base(typeof (Educative.Point))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9895a7e27519452db7053d978fd602c1.MTHD_e786d77f92dd459bb5f366cbbfc94646(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9895a7e27519452db7053d978fd602c1.MTHD_b1f92d8286094a678ab926efdd7a8eb7()
        }));
        this.AddMember("distance", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("distance", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9895a7e27519452db7053d978fd602c1.MTHD_c0a5a6c4cc024ef089df34e0daf87c9a(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9895a7e27519452db7053d978fd602c1.MTHD_f28ebb1210cd4a85ac20358302a9054c()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9895a7e27519452db7053d978fd602c1.MTHD_668debbfe121402bb87cdb0e3196585c()
        }));
        this.AddMember("copy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("copy", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9895a7e27519452db7053d978fd602c1.MTHD_bd436676bb27404b9f759e000f2ee745()
        }));
        this.AddMember("normalized", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalized", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9895a7e27519452db7053d978fd602c1.MTHD_8d85db11f90b4e6190d6e533c5535e8f()
        }));
        this.AddMember("normalize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalize", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9895a7e27519452db7053d978fd602c1.MTHD_b6fc982c5de44a82beeeb54db06e173b()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9895a7e27519452db7053d978fd602c1.MTHD_5a6ed673d4994aef9c1b77ecdf230378()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9895a7e27519452db7053d978fd602c1.MTHD_60b646e49054467d9aafd4c20123242b()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9895a7e27519452db7053d978fd602c1.MTHD_fa58b31f330a4ef1b383466e8ba29392()
        }));
        this.AddMember("op_Subtraction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Subtraction", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9895a7e27519452db7053d978fd602c1.MTHD_1fc57189f2cf44f9989c3061e54d9182(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9895a7e27519452db7053d978fd602c1.MTHD_8c0f85e9b0a4415cb669a1930fb64ed7()
        }));
        this.AddMember("op_Addition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Addition", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9895a7e27519452db7053d978fd602c1.MTHD_16f297ef3c024090b61830188f6a919d(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9895a7e27519452db7053d978fd602c1.MTHD_3bc4626439304b1fb091dc63c7a1b2ff()
        }));
        this.AddMember("op_Multiply", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Multiply", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9895a7e27519452db7053d978fd602c1.MTHD_8f56789e5a2a4abebc2ac76c1fa3f0c3(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9895a7e27519452db7053d978fd602c1.MTHD_fb059f0d675b4a7c90bf588b532aa43d()
        }));
        this.AddMember("op_Division", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Division", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9895a7e27519452db7053d978fd602c1.MTHD_fb374d15ea4e4f9a9b6912ff35c64329(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9895a7e27519452db7053d978fd602c1.MTHD_dd8d19e608ab49e38ff18650aa5c46f7()
        }));
        this.AddMember("op_Modulus", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Modulus", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9895a7e27519452db7053d978fd602c1.MTHD_e489ae3d8a82433cb5db4975227cc10e(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9895a7e27519452db7053d978fd602c1.MTHD_df6d7b1a988247cb9ea202e123174829()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9895a7e27519452db7053d978fd602c1.MTHD_b5887b8938024ae5af0f6a429676f664()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9895a7e27519452db7053d978fd602c1.MTHD_c7bef79c5da545eb8e1355b24448cdf0()
        }));
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_9895a7e27519452db7053d978fd602c1.FLDV_57ee5f2118fa43268ff75bd793597869());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_9895a7e27519452db7053d978fd602c1.FLDV_66b8234245e64d0f9c188f90dca2e89b());
      }

      private sealed class MTHD_e786d77f92dd459bb5f366cbbfc94646 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e786d77f92dd459bb5f366cbbfc94646()
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

      private sealed class MTHD_b1f92d8286094a678ab926efdd7a8eb7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b1f92d8286094a678ab926efdd7a8eb7()
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

      private sealed class MTHD_c0a5a6c4cc024ef089df34e0daf87c9a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c0a5a6c4cc024ef089df34e0daf87c9a()
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

      private sealed class MTHD_f28ebb1210cd4a85ac20358302a9054c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f28ebb1210cd4a85ac20358302a9054c()
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

      private sealed class MTHD_668debbfe121402bb87cdb0e3196585c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_668debbfe121402bb87cdb0e3196585c()
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

      private sealed class MTHD_bd436676bb27404b9f759e000f2ee745 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bd436676bb27404b9f759e000f2ee745()
        {
          this.Initialize("copy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).copy();
        }
      }

      private sealed class MTHD_8d85db11f90b4e6190d6e533c5535e8f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8d85db11f90b4e6190d6e533c5535e8f()
        {
          this.Initialize("normalized", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).normalized();
        }
      }

      private sealed class MTHD_b6fc982c5de44a82beeeb54db06e173b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b6fc982c5de44a82beeeb54db06e173b()
        {
          this.Initialize("normalize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((Educative.Point) obj).normalize();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_5a6ed673d4994aef9c1b77ecdf230378 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5a6ed673d4994aef9c1b77ecdf230378()
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

      private sealed class MTHD_60b646e49054467d9aafd4c20123242b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_60b646e49054467d9aafd4c20123242b()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).GetHashCode();
        }
      }

      private sealed class MTHD_fa58b31f330a4ef1b383466e8ba29392 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fa58b31f330a4ef1b383466e8ba29392()
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

      private sealed class MTHD_1fc57189f2cf44f9989c3061e54d9182 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1fc57189f2cf44f9989c3061e54d9182()
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

      private sealed class MTHD_8c0f85e9b0a4415cb669a1930fb64ed7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8c0f85e9b0a4415cb669a1930fb64ed7()
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

      private sealed class MTHD_16f297ef3c024090b61830188f6a919d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_16f297ef3c024090b61830188f6a919d()
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

      private sealed class MTHD_3bc4626439304b1fb091dc63c7a1b2ff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3bc4626439304b1fb091dc63c7a1b2ff()
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

      private sealed class MTHD_8f56789e5a2a4abebc2ac76c1fa3f0c3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8f56789e5a2a4abebc2ac76c1fa3f0c3()
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

      private sealed class MTHD_fb059f0d675b4a7c90bf588b532aa43d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fb059f0d675b4a7c90bf588b532aa43d()
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

      private sealed class MTHD_fb374d15ea4e4f9a9b6912ff35c64329 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fb374d15ea4e4f9a9b6912ff35c64329()
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

      private sealed class MTHD_dd8d19e608ab49e38ff18650aa5c46f7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dd8d19e608ab49e38ff18650aa5c46f7()
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

      private sealed class MTHD_e489ae3d8a82433cb5db4975227cc10e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e489ae3d8a82433cb5db4975227cc10e()
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

      private sealed class MTHD_df6d7b1a988247cb9ea202e123174829 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_df6d7b1a988247cb9ea202e123174829()
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

      private sealed class MTHD_b5887b8938024ae5af0f6a429676f664 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b5887b8938024ae5af0f6a429676f664()
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

      private sealed class MTHD_c7bef79c5da545eb8e1355b24448cdf0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c7bef79c5da545eb8e1355b24448cdf0()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_57ee5f2118fa43268ff75bd793597869 : HardwiredMemberDescriptor
      {
        internal FLDV_57ee5f2118fa43268ff75bd793597869()
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

      private sealed class FLDV_66b8234245e64d0f9c188f90dca2e89b : HardwiredMemberDescriptor
      {
        internal FLDV_66b8234245e64d0f9c188f90dca2e89b()
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

    private sealed class TYPE_1498ee2782fc4da1bbead9fdf846dc5b : HardwiredUserDataDescriptor
    {
      internal TYPE_1498ee2782fc4da1bbead9fdf846dc5b()
        : base(typeof (Summon))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1498ee2782fc4da1bbead9fdf846dc5b.MTHD_05d6271ff94f4f67b5c9e29771d03e9c()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1498ee2782fc4da1bbead9fdf846dc5b.MTHD_86e26c946a894a22b2720be0b63e6c48()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1498ee2782fc4da1bbead9fdf846dc5b.MTHD_745ace09d2df4e19a2688aad0727cc3b()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1498ee2782fc4da1bbead9fdf846dc5b.MTHD_a5b91426867f47a88c4f1bb561ac6e31()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1498ee2782fc4da1bbead9fdf846dc5b.MTHD_e8d107d5bfc447f9882e0455ba432723()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1498ee2782fc4da1bbead9fdf846dc5b.MTHD_85883e8efe704d40b146353f2f5e3dd7()
        }));
        this.AddMember("spell", (IMemberDescriptor) new Bridge.TYPE_1498ee2782fc4da1bbead9fdf846dc5b.FLDV_a66a1f81b5cd4224a0b071ae963bb6ea());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_1498ee2782fc4da1bbead9fdf846dc5b.FLDV_a9e974985d8146a6a44f8f33385f276b());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_1498ee2782fc4da1bbead9fdf846dc5b.FLDV_f7495c604df6451b82461c02b6c2cee3());
        this.AddMember("onPlayersPanel", (IMemberDescriptor) new Bridge.TYPE_1498ee2782fc4da1bbead9fdf846dc5b.FLDV_5ff07b4a4f9c4e02a812526c7a9fdd69());
        this.AddMember("useAI", (IMemberDescriptor) new Bridge.TYPE_1498ee2782fc4da1bbead9fdf846dc5b.FLDV_5504570bb0b9403fad3825136ae8ed84());
        this.AddMember("no_AI_still_use_turn", (IMemberDescriptor) new Bridge.TYPE_1498ee2782fc4da1bbead9fdf846dc5b.FLDV_5ad792e8d1d94ab7b5f5f1f6e71edca6());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_1498ee2782fc4da1bbead9fdf846dc5b.FLDV_e35eec65aae041df97b58f5550c815e3());
        this.AddMember("playSound", (IMemberDescriptor) new Bridge.TYPE_1498ee2782fc4da1bbead9fdf846dc5b.FLDV_d9755e47580e47b797a13ada40c30d62());
        this.AddMember("prestige", (IMemberDescriptor) new Bridge.TYPE_1498ee2782fc4da1bbead9fdf846dc5b.FLDV_0764b0dbb4a74b278eb5ca6906d1794c());
        this.AddMember("colors", (IMemberDescriptor) new Bridge.TYPE_1498ee2782fc4da1bbead9fdf846dc5b.FLDV_357e20fe5df9424b8925232c4e51a074());
        this.AddMember("spells", (IMemberDescriptor) new Bridge.TYPE_1498ee2782fc4da1bbead9fdf846dc5b.FLDV_86fcb3f9165747c4845cce39e5a795d3());
        this.AddMember("outfit", (IMemberDescriptor) new Bridge.TYPE_1498ee2782fc4da1bbead9fdf846dc5b.FLDV_3c5e942b69e149268bb75b993c0d8962());
        this.AddMember("elemental", (IMemberDescriptor) new Bridge.TYPE_1498ee2782fc4da1bbead9fdf846dc5b.FLDV_2c65522e7602417fa4c33d46ec3f9d0f());
      }

      private sealed class MTHD_05d6271ff94f4f67b5c9e29771d03e9c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_05d6271ff94f4f67b5c9e29771d03e9c()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new Summon();
        }
      }

      private sealed class MTHD_86e26c946a894a22b2720be0b63e6c48 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_86e26c946a894a22b2720be0b63e6c48()
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

      private sealed class MTHD_745ace09d2df4e19a2688aad0727cc3b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_745ace09d2df4e19a2688aad0727cc3b()
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

      private sealed class MTHD_a5b91426867f47a88c4f1bb561ac6e31 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a5b91426867f47a88c4f1bb561ac6e31()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_e8d107d5bfc447f9882e0455ba432723 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e8d107d5bfc447f9882e0455ba432723()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_85883e8efe704d40b146353f2f5e3dd7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_85883e8efe704d40b146353f2f5e3dd7()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_a66a1f81b5cd4224a0b071ae963bb6ea : HardwiredMemberDescriptor
      {
        internal FLDV_a66a1f81b5cd4224a0b071ae963bb6ea()
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

      private sealed class FLDV_a9e974985d8146a6a44f8f33385f276b : HardwiredMemberDescriptor
      {
        internal FLDV_a9e974985d8146a6a44f8f33385f276b()
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

      private sealed class FLDV_f7495c604df6451b82461c02b6c2cee3 : HardwiredMemberDescriptor
      {
        internal FLDV_f7495c604df6451b82461c02b6c2cee3()
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

      private sealed class FLDV_5ff07b4a4f9c4e02a812526c7a9fdd69 : HardwiredMemberDescriptor
      {
        internal FLDV_5ff07b4a4f9c4e02a812526c7a9fdd69()
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

      private sealed class FLDV_5504570bb0b9403fad3825136ae8ed84 : HardwiredMemberDescriptor
      {
        internal FLDV_5504570bb0b9403fad3825136ae8ed84()
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

      private sealed class FLDV_5ad792e8d1d94ab7b5f5f1f6e71edca6 : HardwiredMemberDescriptor
      {
        internal FLDV_5ad792e8d1d94ab7b5f5f1f6e71edca6()
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

      private sealed class FLDV_e35eec65aae041df97b58f5550c815e3 : HardwiredMemberDescriptor
      {
        internal FLDV_e35eec65aae041df97b58f5550c815e3()
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

      private sealed class FLDV_d9755e47580e47b797a13ada40c30d62 : HardwiredMemberDescriptor
      {
        internal FLDV_d9755e47580e47b797a13ada40c30d62()
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

      private sealed class FLDV_0764b0dbb4a74b278eb5ca6906d1794c : HardwiredMemberDescriptor
      {
        internal FLDV_0764b0dbb4a74b278eb5ca6906d1794c()
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

      private sealed class FLDV_357e20fe5df9424b8925232c4e51a074 : HardwiredMemberDescriptor
      {
        internal FLDV_357e20fe5df9424b8925232c4e51a074()
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

      private sealed class FLDV_86fcb3f9165747c4845cce39e5a795d3 : HardwiredMemberDescriptor
      {
        internal FLDV_86fcb3f9165747c4845cce39e5a795d3()
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

      private sealed class FLDV_3c5e942b69e149268bb75b993c0d8962 : HardwiredMemberDescriptor
      {
        internal FLDV_3c5e942b69e149268bb75b993c0d8962()
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

      private sealed class FLDV_2c65522e7602417fa4c33d46ec3f9d0f : HardwiredMemberDescriptor
      {
        internal FLDV_2c65522e7602417fa4c33d46ec3f9d0f()
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

    private sealed class TYPE_46bef42312854b90a77ae5e870cfd275 : HardwiredUserDataDescriptor
    {
      internal TYPE_46bef42312854b90a77ae5e870cfd275()
        : base(typeof (UIElement))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_00facfd577a64a0ba8752bd0d3647568()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_3080c2e8f19542c1adc658ca96e6d315()
        }));
        this.AddMember("get_visible", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_visible", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_5ac571b960674be8ad6f2d17c884592d()
        }));
        this.AddMember("set_visible", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_visible", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_fd7f7f41be8a4b6299776c39fba8ed43()
        }));
        this.AddMember("get_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_3b8bccc663744e7d94c007c247576221()
        }));
        this.AddMember("set_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_07d57942092641f19c7e7d2392dd11ac()
        }));
        this.AddMember("get_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_373ff56a2c424f99a5ae9256ba633c3c()
        }));
        this.AddMember("set_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_afefe5bd2f0048608d82c8096d7a9bf8()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_14a5c2e001dd4004948a1160cd426e00()
        }));
        this.AddMember("set_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_cdcc9fbd9b1f4716a3c38b07580eea44()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_5a1dbbdcbc0d41bba87965f10c8ef941()
        }));
        this.AddMember("set_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_0cff02ee1aee4969af90f74cbac6b7d9()
        }));
        this.AddMember("get_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_21e057878bc54eb897a025f16e07df40()
        }));
        this.AddMember("set_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_72fb64e4b27e4df8ba115941fbc5aeab()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_c97b606ae16642c5bbe3aea0d99e252c()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_ea51b10edd8a437aa7377f99f7876d04()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_d7e0323c1e5947f69896257c18385799()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_20d45530dab741ccb9d05371f81a16da()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_28c3ee4e01834d1f987ceb89ddf873cd()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_89cd67f09cef4ca8851505d8027bea80()
        }));
        this.AddMember("get_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_3178ce9268924075847b153d68216ce7()
        }));
        this.AddMember("set_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_39a3500cb16d4a13b7e22d50fb0d1364()
        }));
        this.AddMember("get_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_078162c80fde40669f2885180733829e()
        }));
        this.AddMember("set_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_ff51e72304844e68b68e5236e665c355()
        }));
        this.AddMember("get_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_9ec1877fd5b345e497513d2a20cc2af6()
        }));
        this.AddMember("set_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_c1623fddaa904d248edc786345698764()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_fb9b765c72be479b846b233bdd7bb7a2()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_fd5d4e772c7b47229604ecebf7d824ea()
        }));
        this.AddMember("get_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_2df9dbc28f8c44cbaecfc6e655f0d1f2()
        }));
        this.AddMember("set_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_6ad068197b4d47f1b9ceca43afa99e9b()
        }));
        this.AddMember("get_onClick2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_d6a5cbe92a0b4f38bfa7b96ff85ad568()
        }));
        this.AddMember("set_onClick2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_36e035e8430d4d2dab6f7ea4f08e0efb()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_e99f1b1b291e474eab52923746286d53()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_ed947ffdea354264ba75def202a1d6d1()
        }));
        this.AddMember("get_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_785254c314264fd3aadb8d41c74b8723()
        }));
        this.AddMember("set_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_14136165c22f42238e716a7d76bbe620()
        }));
        this.AddMember("get_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_2ea265f69fc4470cb839b406891cddbd()
        }));
        this.AddMember("set_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_694436f69aed4f6db6fdd08e078c9f7d()
        }));
        this.AddMember("get_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_7373f76ea6f74c6c9d7eb73180b3f5ed()
        }));
        this.AddMember("set_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_937e98c51a5a45fb876cc4e8dede0486()
        }));
        this.AddMember("get_textColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_d3a02afff90e44e786db28bced09fec4()
        }));
        this.AddMember("set_textColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_0c7cd9448caf47aaab7dd1cd9044f491()
        }));
        this.AddMember("get_highlightColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_highlightColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_ca4dff40a7ba4c1eb7e80d30ae041dc8()
        }));
        this.AddMember("set_highlightColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_highlightColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_37e5eb986cdb435fbf1861b2d075673c()
        }));
        this.AddMember("get_highlightColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_highlightColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_e28f96ae06d343a88a88cce166cef182()
        }));
        this.AddMember("set_highlightColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_highlightColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_ad19e0ee39224182b823ff1eee55086e()
        }));
        this.AddMember("get_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_5813c3064b114c6a81484f1ac1c019d3()
        }));
        this.AddMember("set_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_49221e44027545a2a7e07c3409d69d6f()
        }));
        this.AddMember("get_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_13c405587d854b478de531981af6ca07()
        }));
        this.AddMember("set_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_37e5c23b85f44a87b6f5a1079a12d5c0()
        }));
        this.AddMember("activateInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("activateInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_e6ac9a29854048f1b269326a56e3c2aa()
        }));
        this.AddMember("createUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createUI", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_11c17b863fe743ef91ab911f9def8092()
        }));
        this.AddMember("createInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_189e0fbc078b4bcaaf087a6b84f53a32()
        }));
        this.AddMember("duplicate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("duplicate", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_27715fa06ec94aacbe7604b852935087()
        }));
        this.AddMember("destroyHierarchy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroyHierarchy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_2e84d1ea09454c8eaec9806e307d4b73()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_a9cd4ed77d6c4284a1c4fa25f11576fd()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_d6ce916991c64bcea1b1f58cb4dc99d8()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_36cb3322c70841339a203ff7fc9408de()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_dd111f169fc141e5a46028617c30f908()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.MTHD_621739dc89394f0881ee1598e0a02032()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.PROP_539b2e1367c04ebf9f5b6c319b061b28());
        this.AddMember("visible", (IMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.PROP_b469dd08ca7b4c16b705c23dc09549d9());
        this.AddMember("graphic", (IMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.PROP_7e7081bdafb44e91b1cb3242da6920cd());
        this.AddMember("anchor", (IMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.PROP_b2dea481077c4b928603a9248c400b54());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.PROP_c3b86497ca6d4a1086f31cb184882b93());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.PROP_df95a2234395437baac5abb5c95ef6c3());
        this.AddMember("size", (IMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.PROP_9f85938472144a74843b93ddc0e8a166());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.PROP_4422138355c84ad2b214fcccab8944e8());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.PROP_ba9a4880296d43d18e460c036b48d0f9());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.PROP_d74c2539e1f04f91845aeb7ef6b9480b());
        this.AddMember("pivot_x", (IMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.PROP_87bcb2f3bbcb4db5a1d26e060a24c54d());
        this.AddMember("pivot_y", (IMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.PROP_f5b2029b090c44e7b3e491bf1c293993());
        this.AddMember("pivot", (IMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.PROP_e176028953b649bda23cf76f5e8420c2());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.PROP_15c6c22b9f7d4d869765c21af97bbbab());
        this.AddMember("onClick", (IMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.PROP_0e67b51c4e8c4ef49ba2cd550ca6ba87());
        this.AddMember("onClick2", (IMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.PROP_f1487363ec7b48a1992ee8957c3146f7());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.PROP_3d01b71b11274ee282676d6f5f89ae36());
        this.AddMember("color2", (IMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.PROP_0361f82a12814852bf19f753f3d7278f());
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.PROP_2ab1dc1ea5664a5e8c52a642723b725d());
        this.AddMember("textColor", (IMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.PROP_c6d983b2da5a48588dd71218f3f679d0());
        this.AddMember("textColor2", (IMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.PROP_34358a6b00074c46b2962649fc07e137());
        this.AddMember("highlightColor", (IMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.PROP_4736c0e2d2f349e5b9d76b45b272a79c());
        this.AddMember("highlightColor2", (IMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.PROP_a8c979b9634040e58cc76537b81171dd());
        this.AddMember("textStyle", (IMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.PROP_8a84512a91a5478293727c4cfafc831c());
        this.AddMember("textSize", (IMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.PROP_6e9177de2d8e4b10955bec64a1374720());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.FLDV_d897634b6db24bdbb96163a6fbaea19e());
        this.AddMember("clickID", (IMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.FLDV_fe3a4f61d3a044f4ae91ec95a1ba43a1());
        this.AddMember("clickDestroy", (IMemberDescriptor) new Bridge.TYPE_46bef42312854b90a77ae5e870cfd275.FLDV_c1358b8dbfa740aca6717cde4922e172());
      }

      private sealed class MTHD_00facfd577a64a0ba8752bd0d3647568 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_00facfd577a64a0ba8752bd0d3647568()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new UIElement();
        }
      }

      private sealed class MTHD_3080c2e8f19542c1adc658ca96e6d315 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3080c2e8f19542c1adc658ca96e6d315()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class MTHD_5ac571b960674be8ad6f2d17c884592d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5ac571b960674be8ad6f2d17c884592d()
        {
          this.Initialize("get_visible", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).visible;
        }
      }

      private sealed class MTHD_fd7f7f41be8a4b6299776c39fba8ed43 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fd7f7f41be8a4b6299776c39fba8ed43()
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

      private sealed class MTHD_3b8bccc663744e7d94c007c247576221 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3b8bccc663744e7d94c007c247576221()
        {
          this.Initialize("get_graphic", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return ((UIElement) obj).graphic;
        }
      }

      private sealed class MTHD_07d57942092641f19c7e7d2392dd11ac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_07d57942092641f19c7e7d2392dd11ac()
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

      private sealed class MTHD_373ff56a2c424f99a5ae9256ba633c3c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_373ff56a2c424f99a5ae9256ba633c3c()
        {
          this.Initialize("get_anchor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).anchor;
        }
      }

      private sealed class MTHD_afefe5bd2f0048608d82c8096d7a9bf8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_afefe5bd2f0048608d82c8096d7a9bf8()
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

      private sealed class MTHD_14a5c2e001dd4004948a1160cd426e00 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_14a5c2e001dd4004948a1160cd426e00()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).width;
        }
      }

      private sealed class MTHD_cdcc9fbd9b1f4716a3c38b07580eea44 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cdcc9fbd9b1f4716a3c38b07580eea44()
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

      private sealed class MTHD_5a1dbbdcbc0d41bba87965f10c8ef941 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5a1dbbdcbc0d41bba87965f10c8ef941()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).height;
        }
      }

      private sealed class MTHD_0cff02ee1aee4969af90f74cbac6b7d9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0cff02ee1aee4969af90f74cbac6b7d9()
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

      private sealed class MTHD_21e057878bc54eb897a025f16e07df40 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_21e057878bc54eb897a025f16e07df40()
        {
          this.Initialize("get_size", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).size;
        }
      }

      private sealed class MTHD_72fb64e4b27e4df8ba115941fbc5aeab : HardwiredMethodMemberDescriptor
      {
        internal MTHD_72fb64e4b27e4df8ba115941fbc5aeab()
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

      private sealed class MTHD_c97b606ae16642c5bbe3aea0d99e252c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c97b606ae16642c5bbe3aea0d99e252c()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).x;
        }
      }

      private sealed class MTHD_ea51b10edd8a437aa7377f99f7876d04 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ea51b10edd8a437aa7377f99f7876d04()
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

      private sealed class MTHD_d7e0323c1e5947f69896257c18385799 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d7e0323c1e5947f69896257c18385799()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).y;
        }
      }

      private sealed class MTHD_20d45530dab741ccb9d05371f81a16da : HardwiredMethodMemberDescriptor
      {
        internal MTHD_20d45530dab741ccb9d05371f81a16da()
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

      private sealed class MTHD_28c3ee4e01834d1f987ceb89ddf873cd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_28c3ee4e01834d1f987ceb89ddf873cd()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).position;
        }
      }

      private sealed class MTHD_89cd67f09cef4ca8851505d8027bea80 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_89cd67f09cef4ca8851505d8027bea80()
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

      private sealed class MTHD_3178ce9268924075847b153d68216ce7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3178ce9268924075847b153d68216ce7()
        {
          this.Initialize("get_pivot_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_x;
        }
      }

      private sealed class MTHD_39a3500cb16d4a13b7e22d50fb0d1364 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_39a3500cb16d4a13b7e22d50fb0d1364()
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

      private sealed class MTHD_078162c80fde40669f2885180733829e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_078162c80fde40669f2885180733829e()
        {
          this.Initialize("get_pivot_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_y;
        }
      }

      private sealed class MTHD_ff51e72304844e68b68e5236e665c355 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ff51e72304844e68b68e5236e665c355()
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

      private sealed class MTHD_9ec1877fd5b345e497513d2a20cc2af6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9ec1877fd5b345e497513d2a20cc2af6()
        {
          this.Initialize("get_pivot", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot;
        }
      }

      private sealed class MTHD_c1623fddaa904d248edc786345698764 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c1623fddaa904d248edc786345698764()
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

      private sealed class MTHD_fb9b765c72be479b846b233bdd7bb7a2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fb9b765c72be479b846b233bdd7bb7a2()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).angle;
        }
      }

      private sealed class MTHD_fd5d4e772c7b47229604ecebf7d824ea : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fd5d4e772c7b47229604ecebf7d824ea()
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

      private sealed class MTHD_2df9dbc28f8c44cbaecfc6e655f0d1f2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2df9dbc28f8c44cbaecfc6e655f0d1f2()
        {
          this.Initialize("get_onClick", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick;
        }
      }

      private sealed class MTHD_6ad068197b4d47f1b9ceca43afa99e9b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6ad068197b4d47f1b9ceca43afa99e9b()
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

      private sealed class MTHD_d6a5cbe92a0b4f38bfa7b96ff85ad568 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d6a5cbe92a0b4f38bfa7b96ff85ad568()
        {
          this.Initialize("get_onClick2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick2;
        }
      }

      private sealed class MTHD_36e035e8430d4d2dab6f7ea4f08e0efb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_36e035e8430d4d2dab6f7ea4f08e0efb()
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

      private sealed class MTHD_e99f1b1b291e474eab52923746286d53 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e99f1b1b291e474eab52923746286d53()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color;
        }
      }

      private sealed class MTHD_ed947ffdea354264ba75def202a1d6d1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ed947ffdea354264ba75def202a1d6d1()
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

      private sealed class MTHD_785254c314264fd3aadb8d41c74b8723 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_785254c314264fd3aadb8d41c74b8723()
        {
          this.Initialize("get_color2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color2;
        }
      }

      private sealed class MTHD_14136165c22f42238e716a7d76bbe620 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_14136165c22f42238e716a7d76bbe620()
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

      private sealed class MTHD_2ea265f69fc4470cb839b406891cddbd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2ea265f69fc4470cb839b406891cddbd()
        {
          this.Initialize("get_text", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).text;
        }
      }

      private sealed class MTHD_694436f69aed4f6db6fdd08e078c9f7d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_694436f69aed4f6db6fdd08e078c9f7d()
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

      private sealed class MTHD_7373f76ea6f74c6c9d7eb73180b3f5ed : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7373f76ea6f74c6c9d7eb73180b3f5ed()
        {
          this.Initialize("get_textColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor;
        }
      }

      private sealed class MTHD_937e98c51a5a45fb876cc4e8dede0486 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_937e98c51a5a45fb876cc4e8dede0486()
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

      private sealed class MTHD_d3a02afff90e44e786db28bced09fec4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d3a02afff90e44e786db28bced09fec4()
        {
          this.Initialize("get_textColor2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor2;
        }
      }

      private sealed class MTHD_0c7cd9448caf47aaab7dd1cd9044f491 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0c7cd9448caf47aaab7dd1cd9044f491()
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

      private sealed class MTHD_ca4dff40a7ba4c1eb7e80d30ae041dc8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ca4dff40a7ba4c1eb7e80d30ae041dc8()
        {
          this.Initialize("get_highlightColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).highlightColor;
        }
      }

      private sealed class MTHD_37e5eb986cdb435fbf1861b2d075673c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_37e5eb986cdb435fbf1861b2d075673c()
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

      private sealed class MTHD_e28f96ae06d343a88a88cce166cef182 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e28f96ae06d343a88a88cce166cef182()
        {
          this.Initialize("get_highlightColor2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).highlightColor2;
        }
      }

      private sealed class MTHD_ad19e0ee39224182b823ff1eee55086e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ad19e0ee39224182b823ff1eee55086e()
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

      private sealed class MTHD_5813c3064b114c6a81484f1ac1c019d3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5813c3064b114c6a81484f1ac1c019d3()
        {
          this.Initialize("get_textStyle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textStyle;
        }
      }

      private sealed class MTHD_49221e44027545a2a7e07c3409d69d6f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_49221e44027545a2a7e07c3409d69d6f()
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

      private sealed class MTHD_13c405587d854b478de531981af6ca07 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_13c405587d854b478de531981af6ca07()
        {
          this.Initialize("get_textSize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textSize;
        }
      }

      private sealed class MTHD_37e5c23b85f44a87b6f5a1079a12d5c0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_37e5c23b85f44a87b6f5a1079a12d5c0()
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

      private sealed class MTHD_e6ac9a29854048f1b269326a56e3c2aa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e6ac9a29854048f1b269326a56e3c2aa()
        {
          this.Initialize("activateInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).activateInput();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_11c17b863fe743ef91ab911f9def8092 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_11c17b863fe743ef91ab911f9def8092()
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

      private sealed class MTHD_189e0fbc078b4bcaaf087a6b84f53a32 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_189e0fbc078b4bcaaf087a6b84f53a32()
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

      private sealed class MTHD_27715fa06ec94aacbe7604b852935087 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_27715fa06ec94aacbe7604b852935087()
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

      private sealed class MTHD_2e84d1ea09454c8eaec9806e307d4b73 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2e84d1ea09454c8eaec9806e307d4b73()
        {
          this.Initialize("destroyHierarchy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroyHierarchy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_a9cd4ed77d6c4284a1c4fa25f11576fd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a9cd4ed77d6c4284a1c4fa25f11576fd()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_d6ce916991c64bcea1b1f58cb4dc99d8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d6ce916991c64bcea1b1f58cb4dc99d8()
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

      private sealed class MTHD_36cb3322c70841339a203ff7fc9408de : HardwiredMethodMemberDescriptor
      {
        internal MTHD_36cb3322c70841339a203ff7fc9408de()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_dd111f169fc141e5a46028617c30f908 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dd111f169fc141e5a46028617c30f908()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_621739dc89394f0881ee1598e0a02032 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_621739dc89394f0881ee1598e0a02032()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_539b2e1367c04ebf9f5b6c319b061b28 : HardwiredMemberDescriptor
      {
        internal PROP_539b2e1367c04ebf9f5b6c319b061b28()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class PROP_b469dd08ca7b4c16b705c23dc09549d9 : HardwiredMemberDescriptor
      {
        internal PROP_b469dd08ca7b4c16b705c23dc09549d9()
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

      private sealed class PROP_7e7081bdafb44e91b1cb3242da6920cd : HardwiredMemberDescriptor
      {
        internal PROP_7e7081bdafb44e91b1cb3242da6920cd()
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

      private sealed class PROP_b2dea481077c4b928603a9248c400b54 : HardwiredMemberDescriptor
      {
        internal PROP_b2dea481077c4b928603a9248c400b54()
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

      private sealed class PROP_c3b86497ca6d4a1086f31cb184882b93 : HardwiredMemberDescriptor
      {
        internal PROP_c3b86497ca6d4a1086f31cb184882b93()
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

      private sealed class PROP_df95a2234395437baac5abb5c95ef6c3 : HardwiredMemberDescriptor
      {
        internal PROP_df95a2234395437baac5abb5c95ef6c3()
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

      private sealed class PROP_9f85938472144a74843b93ddc0e8a166 : HardwiredMemberDescriptor
      {
        internal PROP_9f85938472144a74843b93ddc0e8a166()
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

      private sealed class PROP_4422138355c84ad2b214fcccab8944e8 : HardwiredMemberDescriptor
      {
        internal PROP_4422138355c84ad2b214fcccab8944e8()
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

      private sealed class PROP_ba9a4880296d43d18e460c036b48d0f9 : HardwiredMemberDescriptor
      {
        internal PROP_ba9a4880296d43d18e460c036b48d0f9()
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

      private sealed class PROP_d74c2539e1f04f91845aeb7ef6b9480b : HardwiredMemberDescriptor
      {
        internal PROP_d74c2539e1f04f91845aeb7ef6b9480b()
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

      private sealed class PROP_87bcb2f3bbcb4db5a1d26e060a24c54d : HardwiredMemberDescriptor
      {
        internal PROP_87bcb2f3bbcb4db5a1d26e060a24c54d()
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

      private sealed class PROP_f5b2029b090c44e7b3e491bf1c293993 : HardwiredMemberDescriptor
      {
        internal PROP_f5b2029b090c44e7b3e491bf1c293993()
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

      private sealed class PROP_e176028953b649bda23cf76f5e8420c2 : HardwiredMemberDescriptor
      {
        internal PROP_e176028953b649bda23cf76f5e8420c2()
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

      private sealed class PROP_15c6c22b9f7d4d869765c21af97bbbab : HardwiredMemberDescriptor
      {
        internal PROP_15c6c22b9f7d4d869765c21af97bbbab()
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

      private sealed class PROP_0e67b51c4e8c4ef49ba2cd550ca6ba87 : HardwiredMemberDescriptor
      {
        internal PROP_0e67b51c4e8c4ef49ba2cd550ca6ba87()
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

      private sealed class PROP_f1487363ec7b48a1992ee8957c3146f7 : HardwiredMemberDescriptor
      {
        internal PROP_f1487363ec7b48a1992ee8957c3146f7()
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

      private sealed class PROP_3d01b71b11274ee282676d6f5f89ae36 : HardwiredMemberDescriptor
      {
        internal PROP_3d01b71b11274ee282676d6f5f89ae36()
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

      private sealed class PROP_0361f82a12814852bf19f753f3d7278f : HardwiredMemberDescriptor
      {
        internal PROP_0361f82a12814852bf19f753f3d7278f()
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

      private sealed class PROP_2ab1dc1ea5664a5e8c52a642723b725d : HardwiredMemberDescriptor
      {
        internal PROP_2ab1dc1ea5664a5e8c52a642723b725d()
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

      private sealed class PROP_c6d983b2da5a48588dd71218f3f679d0 : HardwiredMemberDescriptor
      {
        internal PROP_c6d983b2da5a48588dd71218f3f679d0()
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

      private sealed class PROP_34358a6b00074c46b2962649fc07e137 : HardwiredMemberDescriptor
      {
        internal PROP_34358a6b00074c46b2962649fc07e137()
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

      private sealed class PROP_4736c0e2d2f349e5b9d76b45b272a79c : HardwiredMemberDescriptor
      {
        internal PROP_4736c0e2d2f349e5b9d76b45b272a79c()
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

      private sealed class PROP_a8c979b9634040e58cc76537b81171dd : HardwiredMemberDescriptor
      {
        internal PROP_a8c979b9634040e58cc76537b81171dd()
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

      private sealed class PROP_8a84512a91a5478293727c4cfafc831c : HardwiredMemberDescriptor
      {
        internal PROP_8a84512a91a5478293727c4cfafc831c()
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

      private sealed class PROP_6e9177de2d8e4b10955bec64a1374720 : HardwiredMemberDescriptor
      {
        internal PROP_6e9177de2d8e4b10955bec64a1374720()
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

      private sealed class FLDV_d897634b6db24bdbb96163a6fbaea19e : HardwiredMemberDescriptor
      {
        internal FLDV_d897634b6db24bdbb96163a6fbaea19e()
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

      private sealed class FLDV_fe3a4f61d3a044f4ae91ec95a1ba43a1 : HardwiredMemberDescriptor
      {
        internal FLDV_fe3a4f61d3a044f4ae91ec95a1ba43a1()
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

      private sealed class FLDV_c1358b8dbfa740aca6717cde4922e172 : HardwiredMemberDescriptor
      {
        internal FLDV_c1358b8dbfa740aca6717cde4922e172()
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

    private sealed class TYPE_05764d9421764dc6984ab8f27fc81933 : HardwiredUserDataDescriptor
    {
      internal TYPE_05764d9421764dc6984ab8f27fc81933()
        : base(typeof (MyPoll.Item))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_05764d9421764dc6984ab8f27fc81933.MTHD_be35e5117adb490887c4fca46ccbaad9()
        }));
        this.AddMember("addAnswer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addAnswer", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_05764d9421764dc6984ab8f27fc81933.MTHD_527280b268284431b3d00048db67cd54()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_05764d9421764dc6984ab8f27fc81933.MTHD_8ce914371755402db9822c01f9e8c753()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_05764d9421764dc6984ab8f27fc81933.MTHD_2b6de029b58a4ddd9716142e418ea93e()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_05764d9421764dc6984ab8f27fc81933.MTHD_b272a3d999d04147840a881850c21c23()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_05764d9421764dc6984ab8f27fc81933.MTHD_8065123bcbad4403a63af7c997b031de()
        }));
        this.AddMember("question", (IMemberDescriptor) new Bridge.TYPE_05764d9421764dc6984ab8f27fc81933.FLDV_35353babfa5a427f82932e74aed18b1c());
        this.AddMember("multipleSelection", (IMemberDescriptor) new Bridge.TYPE_05764d9421764dc6984ab8f27fc81933.FLDV_245672ba1d0e442ab6804951cffd14c2());
        this.AddMember("requiresAnswer", (IMemberDescriptor) new Bridge.TYPE_05764d9421764dc6984ab8f27fc81933.FLDV_9e0b6a74bbe043f8af0b49cb5d952e9b());
        this.AddMember("answers", (IMemberDescriptor) new Bridge.TYPE_05764d9421764dc6984ab8f27fc81933.FLDV_48f3e80a0865421db3d197818188d3e1());
      }

      private sealed class MTHD_be35e5117adb490887c4fca46ccbaad9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_be35e5117adb490887c4fca46ccbaad9()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Item();
        }
      }

      private sealed class MTHD_527280b268284431b3d00048db67cd54 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_527280b268284431b3d00048db67cd54()
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

      private sealed class MTHD_8ce914371755402db9822c01f9e8c753 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8ce914371755402db9822c01f9e8c753()
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

      private sealed class MTHD_2b6de029b58a4ddd9716142e418ea93e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2b6de029b58a4ddd9716142e418ea93e()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_b272a3d999d04147840a881850c21c23 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b272a3d999d04147840a881850c21c23()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_8065123bcbad4403a63af7c997b031de : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8065123bcbad4403a63af7c997b031de()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_35353babfa5a427f82932e74aed18b1c : HardwiredMemberDescriptor
      {
        internal FLDV_35353babfa5a427f82932e74aed18b1c()
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

      private sealed class FLDV_245672ba1d0e442ab6804951cffd14c2 : HardwiredMemberDescriptor
      {
        internal FLDV_245672ba1d0e442ab6804951cffd14c2()
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

      private sealed class FLDV_9e0b6a74bbe043f8af0b49cb5d952e9b : HardwiredMemberDescriptor
      {
        internal FLDV_9e0b6a74bbe043f8af0b49cb5d952e9b()
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

      private sealed class FLDV_48f3e80a0865421db3d197818188d3e1 : HardwiredMemberDescriptor
      {
        internal FLDV_48f3e80a0865421db3d197818188d3e1()
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

    private sealed class TYPE_dfac35578a7f43daa5f82e095b757e81 : HardwiredUserDataDescriptor
    {
      internal TYPE_dfac35578a7f43daa5f82e095b757e81()
        : base(typeof (MyPoll.Answer))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dfac35578a7f43daa5f82e095b757e81.MTHD_3ec8b58a17fe4c09a01c2310ad421ec2()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dfac35578a7f43daa5f82e095b757e81.MTHD_03c3b4e6bf48438aaf81e414ccb49426()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dfac35578a7f43daa5f82e095b757e81.MTHD_834534afbf2b4f79843fe345f50defbf()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dfac35578a7f43daa5f82e095b757e81.MTHD_7490d080386d4037b0f9b9f8212dc17f()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dfac35578a7f43daa5f82e095b757e81.MTHD_e41b895f26ec4189b8cdad1ed079f608()
        }));
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_dfac35578a7f43daa5f82e095b757e81.FLDV_def50127a1394784a57f1ccb4eed096b());
        this.AddMember("allowUserInput", (IMemberDescriptor) new Bridge.TYPE_dfac35578a7f43daa5f82e095b757e81.FLDV_a789e78e0afc411a9946cf21f3be53e1());
        this.AddMember("checkable", (IMemberDescriptor) new Bridge.TYPE_dfac35578a7f43daa5f82e095b757e81.FLDV_47de9924c41d41b5ace084c264347f10());
        this.AddMember("userInput", (IMemberDescriptor) new Bridge.TYPE_dfac35578a7f43daa5f82e095b757e81.FLDV_1a927dd61568401b91f3b95e57fa1441());
        this.AddMember("isChecked", (IMemberDescriptor) new Bridge.TYPE_dfac35578a7f43daa5f82e095b757e81.FLDV_3e1c9dbbd8724940baa00b8ae4d0d059());
      }

      private sealed class MTHD_3ec8b58a17fe4c09a01c2310ad421ec2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3ec8b58a17fe4c09a01c2310ad421ec2()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Answer();
        }
      }

      private sealed class MTHD_03c3b4e6bf48438aaf81e414ccb49426 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_03c3b4e6bf48438aaf81e414ccb49426()
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

      private sealed class MTHD_834534afbf2b4f79843fe345f50defbf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_834534afbf2b4f79843fe345f50defbf()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_7490d080386d4037b0f9b9f8212dc17f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7490d080386d4037b0f9b9f8212dc17f()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_e41b895f26ec4189b8cdad1ed079f608 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e41b895f26ec4189b8cdad1ed079f608()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_def50127a1394784a57f1ccb4eed096b : HardwiredMemberDescriptor
      {
        internal FLDV_def50127a1394784a57f1ccb4eed096b()
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

      private sealed class FLDV_a789e78e0afc411a9946cf21f3be53e1 : HardwiredMemberDescriptor
      {
        internal FLDV_a789e78e0afc411a9946cf21f3be53e1()
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

      private sealed class FLDV_47de9924c41d41b5ace084c264347f10 : HardwiredMemberDescriptor
      {
        internal FLDV_47de9924c41d41b5ace084c264347f10()
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

      private sealed class FLDV_1a927dd61568401b91f3b95e57fa1441 : HardwiredMemberDescriptor
      {
        internal FLDV_1a927dd61568401b91f3b95e57fa1441()
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

      private sealed class FLDV_3e1c9dbbd8724940baa00b8ae4d0d059 : HardwiredMemberDescriptor
      {
        internal FLDV_3e1c9dbbd8724940baa00b8ae4d0d059()
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

    private sealed class TYPE_2abb75c395434c51b2322b250ee76115 : HardwiredUserDataDescriptor
    {
      internal TYPE_2abb75c395434c51b2322b250ee76115()
        : base(typeof (MyPoll))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2abb75c395434c51b2322b250ee76115.MTHD_5e2960549b78423d9d9dfc24af0352e8()
        }));
        this.AddMember("GetQuestionsAsString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetQuestionsAsString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2abb75c395434c51b2322b250ee76115.MTHD_c1f35d25386e4f4997f50ed2a67a0093()
        }));
        this.AddMember("SanitizeResponses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("SanitizeResponses", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2abb75c395434c51b2322b250ee76115.MTHD_17ff45ddff6c4a679c66704e2e102bcf()
        }));
        this.AddMember("addItem", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addItem", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2abb75c395434c51b2322b250ee76115.MTHD_d1bbdb7f9be54f6c9c2bd0613a47f1ed()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2abb75c395434c51b2322b250ee76115.MTHD_3470411ad28b421092ad7b8fa0ab8a1e()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2abb75c395434c51b2322b250ee76115.MTHD_76b5e514c28747209c4ce1a3d72b5727()
        }));
        this.AddMember("fromString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fromString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2abb75c395434c51b2322b250ee76115.MTHD_47cc37f453554f80b4cc823cf4ed0a85()
        }));
        this.AddMember("sendToServer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("sendToServer", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2abb75c395434c51b2322b250ee76115.MTHD_7a2db4e1e5564341b49f62a2de499ab8()
        }));
        this.AddMember("closePoll", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("closePoll", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2abb75c395434c51b2322b250ee76115.MTHD_1d225c8f87da438d9f6c76124f1c585b()
        }));
        this.AddMember("test", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("test", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2abb75c395434c51b2322b250ee76115.MTHD_8ba3614b8dc740ef902e0361cb0c7cfe()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2abb75c395434c51b2322b250ee76115.MTHD_b4f0956c6acc459cb8ac2aafa70768bd()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2abb75c395434c51b2322b250ee76115.MTHD_3eab82ee9b32489a9d48054241da71e3()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2abb75c395434c51b2322b250ee76115.MTHD_b7fd0ae289484b90a5aea3f88c6fbcb5()
        }));
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_2abb75c395434c51b2322b250ee76115.FLDV_ab98b6f7ee0f410d95e73156f0d8ddfb());
        this.AddMember("id", (IMemberDescriptor) new Bridge.TYPE_2abb75c395434c51b2322b250ee76115.FLDV_9fabf17cb24c4016b5b7602ebd399cc7());
        this.AddMember("items", (IMemberDescriptor) new Bridge.TYPE_2abb75c395434c51b2322b250ee76115.FLDV_0680f4101aaa4d9fa5527612a1c0f19a());
        this.AddMember("isPublic", (IMemberDescriptor) new Bridge.TYPE_2abb75c395434c51b2322b250ee76115.FLDV_ac98ca4ae2dd45408ca9eb5494503791());
        this.AddMember("MsgRetrieve", (IMemberDescriptor) new Bridge.TYPE_2abb75c395434c51b2322b250ee76115.FLDV_a9a7f28e3c5e47f6bbf54f06777c785f());
        this.AddMember("MsgSubmit", (IMemberDescriptor) new Bridge.TYPE_2abb75c395434c51b2322b250ee76115.FLDV_bb18060e0c5a4f98b51d198637284b81());
        this.AddMember("MsgCreate", (IMemberDescriptor) new Bridge.TYPE_2abb75c395434c51b2322b250ee76115.FLDV_c7d3fe15845e40f39fbb243788e7fe4c());
        this.AddMember("MsgResults", (IMemberDescriptor) new Bridge.TYPE_2abb75c395434c51b2322b250ee76115.FLDV_fc7d7676ed71401bbe947d950c890d42());
        this.AddMember("Item", (IMemberDescriptor) new Bridge.TYPE_2abb75c395434c51b2322b250ee76115.DVAL_67c6a340278c49b28f05450d75f02474());
        this.AddMember("Answer", (IMemberDescriptor) new Bridge.TYPE_2abb75c395434c51b2322b250ee76115.DVAL_c9ef5cde050b48fdbd78f9e3fb187872());
      }

      private sealed class MTHD_5e2960549b78423d9d9dfc24af0352e8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5e2960549b78423d9d9dfc24af0352e8()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll();
        }
      }

      private sealed class MTHD_c1f35d25386e4f4997f50ed2a67a0093 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c1f35d25386e4f4997f50ed2a67a0093()
        {
          this.Initialize("GetQuestionsAsString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).GetQuestionsAsString();
        }
      }

      private sealed class MTHD_17ff45ddff6c4a679c66704e2e102bcf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_17ff45ddff6c4a679c66704e2e102bcf()
        {
          this.Initialize("SanitizeResponses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).SanitizeResponses();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_d1bbdb7f9be54f6c9c2bd0613a47f1ed : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d1bbdb7f9be54f6c9c2bd0613a47f1ed()
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

      private sealed class MTHD_3470411ad28b421092ad7b8fa0ab8a1e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3470411ad28b421092ad7b8fa0ab8a1e()
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

      private sealed class MTHD_76b5e514c28747209c4ce1a3d72b5727 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_76b5e514c28747209c4ce1a3d72b5727()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).ToString();
        }
      }

      private sealed class MTHD_47cc37f453554f80b4cc823cf4ed0a85 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_47cc37f453554f80b4cc823cf4ed0a85()
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

      private sealed class MTHD_7a2db4e1e5564341b49f62a2de499ab8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7a2db4e1e5564341b49f62a2de499ab8()
        {
          this.Initialize("sendToServer", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).sendToServer();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_1d225c8f87da438d9f6c76124f1c585b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1d225c8f87da438d9f6c76124f1c585b()
        {
          this.Initialize("closePoll", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          MyPoll.closePoll();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_8ba3614b8dc740ef902e0361cb0c7cfe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8ba3614b8dc740ef902e0361cb0c7cfe()
        {
          this.Initialize("test", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).test();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_b4f0956c6acc459cb8ac2aafa70768bd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b4f0956c6acc459cb8ac2aafa70768bd()
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

      private sealed class MTHD_3eab82ee9b32489a9d48054241da71e3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3eab82ee9b32489a9d48054241da71e3()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_b7fd0ae289484b90a5aea3f88c6fbcb5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b7fd0ae289484b90a5aea3f88c6fbcb5()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_ab98b6f7ee0f410d95e73156f0d8ddfb : HardwiredMemberDescriptor
      {
        internal FLDV_ab98b6f7ee0f410d95e73156f0d8ddfb()
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

      private sealed class FLDV_9fabf17cb24c4016b5b7602ebd399cc7 : HardwiredMemberDescriptor
      {
        internal FLDV_9fabf17cb24c4016b5b7602ebd399cc7()
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

      private sealed class FLDV_0680f4101aaa4d9fa5527612a1c0f19a : HardwiredMemberDescriptor
      {
        internal FLDV_0680f4101aaa4d9fa5527612a1c0f19a()
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

      private sealed class FLDV_ac98ca4ae2dd45408ca9eb5494503791 : HardwiredMemberDescriptor
      {
        internal FLDV_ac98ca4ae2dd45408ca9eb5494503791()
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

      private sealed class FLDV_a9a7f28e3c5e47f6bbf54f06777c785f : HardwiredMemberDescriptor
      {
        internal FLDV_a9a7f28e3c5e47f6bbf54f06777c785f()
          : base(typeof (byte), "MsgRetrieve", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 1;
        }
      }

      private sealed class FLDV_bb18060e0c5a4f98b51d198637284b81 : HardwiredMemberDescriptor
      {
        internal FLDV_bb18060e0c5a4f98b51d198637284b81()
          : base(typeof (byte), "MsgSubmit", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 2;
        }
      }

      private sealed class FLDV_c7d3fe15845e40f39fbb243788e7fe4c : HardwiredMemberDescriptor
      {
        internal FLDV_c7d3fe15845e40f39fbb243788e7fe4c()
          : base(typeof (byte), "MsgCreate", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 3;
        }
      }

      private sealed class FLDV_fc7d7676ed71401bbe947d950c890d42 : HardwiredMemberDescriptor
      {
        internal FLDV_fc7d7676ed71401bbe947d950c890d42()
          : base(typeof (byte), "MsgResults", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 4;
        }
      }

      private sealed class DVAL_67c6a340278c49b28f05450d75f02474 : DynValueMemberDescriptor
      {
        internal DVAL_67c6a340278c49b28f05450d75f02474()
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

      private sealed class DVAL_c9ef5cde050b48fdbd78f9e3fb187872 : DynValueMemberDescriptor
      {
        internal DVAL_c9ef5cde050b48fdbd78f9e3fb187872()
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

    private sealed class TYPE_e1a0a8db181845459db07c281337d748 : HardwiredUserDataDescriptor
    {
      internal TYPE_e1a0a8db181845459db07c281337d748()
        : base(typeof (LuaColor))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e1a0a8db181845459db07c281337d748.MTHD_23d5ee5efdb14d69acdc3a2f7ad77de9()
        }));
        this.AddMember("toHex", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("toHex", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e1a0a8db181845459db07c281337d748.MTHD_3af60ea7e36f4939a8653484a0329c66()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e1a0a8db181845459db07c281337d748.MTHD_10c205ee894e408685f0840a6eadeb1e(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e1a0a8db181845459db07c281337d748.MTHD_ab134ea5521c46919b6aa98e27fa31bc()
        }));
        this.AddMember("From", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("From", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e1a0a8db181845459db07c281337d748.MTHD_6d0176aa1d6d472bb86f89ee91b9e4ce(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e1a0a8db181845459db07c281337d748.MTHD_c6c0821d4ffc4ac3821461b42419fcf0()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e1a0a8db181845459db07c281337d748.MTHD_d3aa9e71e7a84eaeb5801ac7219db1dd()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e1a0a8db181845459db07c281337d748.MTHD_33da87b0a9624637b1b2c347977db6ac()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e1a0a8db181845459db07c281337d748.MTHD_3a7431f2b9814dc39463e17620a7f7db()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e1a0a8db181845459db07c281337d748.MTHD_0aefc7c030ed48afa0d1e231c0d3cac9()
        }));
        this.AddMember("r", (IMemberDescriptor) new Bridge.TYPE_e1a0a8db181845459db07c281337d748.FLDV_620caf6ca01349dab1a688dd436763a9());
        this.AddMember("g", (IMemberDescriptor) new Bridge.TYPE_e1a0a8db181845459db07c281337d748.FLDV_607d39773e0847fbab843e4ae07c0818());
        this.AddMember("b", (IMemberDescriptor) new Bridge.TYPE_e1a0a8db181845459db07c281337d748.FLDV_86019ed7ecb94b5e84a3a8d5e4d29213());
        this.AddMember("a", (IMemberDescriptor) new Bridge.TYPE_e1a0a8db181845459db07c281337d748.FLDV_9f69f0c89e664142b590d53d9ea71ba6());
        this.AddMember("white", (IMemberDescriptor) new Bridge.TYPE_e1a0a8db181845459db07c281337d748.FLDV_3a19d1b43ff648f28899c297ae53093f());
      }

      private sealed class MTHD_23d5ee5efdb14d69acdc3a2f7ad77de9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_23d5ee5efdb14d69acdc3a2f7ad77de9()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new LuaColor();
        }
      }

      private sealed class MTHD_3af60ea7e36f4939a8653484a0329c66 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3af60ea7e36f4939a8653484a0329c66()
        {
          this.Initialize("toHex", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((LuaColor) obj).toHex();
        }
      }

      private sealed class MTHD_10c205ee894e408685f0840a6eadeb1e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_10c205ee894e408685f0840a6eadeb1e()
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

      private sealed class MTHD_ab134ea5521c46919b6aa98e27fa31bc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ab134ea5521c46919b6aa98e27fa31bc()
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

      private sealed class MTHD_6d0176aa1d6d472bb86f89ee91b9e4ce : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6d0176aa1d6d472bb86f89ee91b9e4ce()
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

      private sealed class MTHD_c6c0821d4ffc4ac3821461b42419fcf0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c6c0821d4ffc4ac3821461b42419fcf0()
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

      private sealed class MTHD_d3aa9e71e7a84eaeb5801ac7219db1dd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d3aa9e71e7a84eaeb5801ac7219db1dd()
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

      private sealed class MTHD_33da87b0a9624637b1b2c347977db6ac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_33da87b0a9624637b1b2c347977db6ac()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_3a7431f2b9814dc39463e17620a7f7db : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3a7431f2b9814dc39463e17620a7f7db()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_0aefc7c030ed48afa0d1e231c0d3cac9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0aefc7c030ed48afa0d1e231c0d3cac9()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_620caf6ca01349dab1a688dd436763a9 : HardwiredMemberDescriptor
      {
        internal FLDV_620caf6ca01349dab1a688dd436763a9()
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

      private sealed class FLDV_607d39773e0847fbab843e4ae07c0818 : HardwiredMemberDescriptor
      {
        internal FLDV_607d39773e0847fbab843e4ae07c0818()
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

      private sealed class FLDV_86019ed7ecb94b5e84a3a8d5e4d29213 : HardwiredMemberDescriptor
      {
        internal FLDV_86019ed7ecb94b5e84a3a8d5e4d29213()
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

      private sealed class FLDV_9f69f0c89e664142b590d53d9ea71ba6 : HardwiredMemberDescriptor
      {
        internal FLDV_9f69f0c89e664142b590d53d9ea71ba6()
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

      private sealed class FLDV_3a19d1b43ff648f28899c297ae53093f : HardwiredMemberDescriptor
      {
        internal FLDV_3a19d1b43ff648f28899c297ae53093f()
          : base(typeof (LuaColor), "white", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) LuaColor.white;
        }
      }
    }

    private sealed class TYPE_1fda633c4075459fa0b69ffa3fe90954 : HardwiredUserDataDescriptor
    {
      internal TYPE_1fda633c4075459fa0b69ffa3fe90954()
        : base(typeof (TalkOptions))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1fda633c4075459fa0b69ffa3fe90954.MTHD_d631831ca3474c9b88b1c267c5e6b873()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1fda633c4075459fa0b69ffa3fe90954.MTHD_ba20d9e1b37342e484d21a47ca334d6f()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1fda633c4075459fa0b69ffa3fe90954.MTHD_7ac92c43fb9340e8b328959a8199e451()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1fda633c4075459fa0b69ffa3fe90954.MTHD_8959a4620e1e486eb9e7217c7913da7d()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1fda633c4075459fa0b69ffa3fe90954.MTHD_f57510ef8a3749a7b059eeafe6cc0110()
        }));
      }

      private sealed class MTHD_d631831ca3474c9b88b1c267c5e6b873 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d631831ca3474c9b88b1c267c5e6b873()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new TalkOptions();
        }
      }

      private sealed class MTHD_ba20d9e1b37342e484d21a47ca334d6f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ba20d9e1b37342e484d21a47ca334d6f()
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

      private sealed class MTHD_7ac92c43fb9340e8b328959a8199e451 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7ac92c43fb9340e8b328959a8199e451()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_8959a4620e1e486eb9e7217c7913da7d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8959a4620e1e486eb9e7217c7913da7d()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_f57510ef8a3749a7b059eeafe6cc0110 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f57510ef8a3749a7b059eeafe6cc0110()
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
