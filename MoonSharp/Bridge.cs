
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
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_b65e6f0c706243d497663152c8912148());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_822d4fff440347d49059eae4fd29374d());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_93162ae8d88a4cc2914793cbc35ba186());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_352a0edd36e546ef8c673f5255eea609());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_d0bfa83f58fd48c8a10aeab139a51d90());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_9cca207999fe47af8cad135a8f2ff18a());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_d92a6931c569413c98b448a0bf44630b());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_9ffe1ad970734ecbb7c260fabe857333());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_5053ebedc67844e0982f4378ac4fa5a4());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_b8643655a9c64f3394a17191ea9db170());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_de560b42ec4c4310a3886281485c0761());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_c6301f7d9d544de284a31336bdd90d56());
    }

    private sealed class TYPE_bcd042bd15e1459bb5e402a7ce5ac8df : HardwiredUserDataDescriptor
    {
      internal TYPE_bcd042bd15e1459bb5e402a7ce5ac8df()
        : base(typeof (ContainerGame))
      {
        this.AddMember("getUser", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getUser", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_776c8b48675649448c26f4b5a0bc2f05()
        }));
        this.AddMember("getPlayers", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayers", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_4543d414a5184160aed96ce87de8c50d()
        }));
        this.AddMember("getPlayerCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayerCount", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_45658f0624004d9ab132a67c7908463e()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_6bff3a4fcfbe4108bdd51a5c238f112e()
        }));
        this.AddMember("findCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_bf51038afc9d4083b966552b4e2f4399()
        }));
        this.AddMember("findEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findEffectors", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_8b6559ba0ae246b5b2501891b20d476c()
        }));
        this.AddMember("LineCast", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCast", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_6872eb413de94fd48557496fbf1642ab()
        }));
        this.AddMember("LineCastOnlyCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_fc339d0169fd4bddb50fb960e27a1e9d()
        }));
        this.AddMember("LineCastOnlyTerrain", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyTerrain", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_53a15a2b83c645949567ec952b6e9b9c()
        }));
        this.AddMember("ShowInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ShowInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_c47eba4c072041b58f437cb85bb68d9b()
        }));
        this.AddMember("hideInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("hideInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_0b3c8b1e2d5e47b898a48f7407fb6bef()
        }));
        this.AddMember("Talk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Talk", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_90772cc2195d4e8e83bba74ff5082c3e()
        }));
        this.AddMember("get_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_db521bac29a54916b8a486e27ef469b3()
        }));
        this.AddMember("set_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_40fa9a0d2bc6448c9cb84234013e1536()
        }));
        this.AddMember("get_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_ca227f816f7549fba39b1f0fb5608c80()
        }));
        this.AddMember("set_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_d85327aab1bb4ef2b101d97991887c5e()
        }));
        this.AddMember("get_totalTimeElapsed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_totalTimeElapsed", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_63ea0cdfd3404b59bc98f97f9aa3071a()
        }));
        this.AddMember("get_turnTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnTime", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_bf0e7f0545e3477f89f8d011ca1c6a6a()
        }));
        this.AddMember("get_frame", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frame", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_a6f733ea57dd4e84add45ef9a6c0daac()
        }));
        this.AddMember("random", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("random", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_f38deb65d9594bbc86800068d7140971()
        }));
        this.AddMember("get_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_55fc5f3e33574240bee3fc9267cbfeac()
        }));
        this.AddMember("set_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_180998fc5efc44a08761ea582aba39d9()
        }));
        this.AddMember("get_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_0b15a97074d1468abf5fe6d43bbfa40d()
        }));
        this.AddMember("set_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_fe09a9755cdd4665aa0c996b417ec9a1()
        }));
        this.AddMember("get_allowMinionMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMinionMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_e10faeee70494048b0f146047de4a107()
        }));
        this.AddMember("set_allowMinionMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMinionMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_61ce3b68bcae4f649963933a29a24d24()
        }));
        this.AddMember("get_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_0af3c320c9d8418d89cca80f6e9e8212()
        }));
        this.AddMember("set_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_3079b7ba1ad343c290420b5894597b33()
        }));
        this.AddMember("get_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_dc761436ff9c4a0899c83e6cf1c31773()
        }));
        this.AddMember("set_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_ff902dc7bdfb46bcb1dbf62b92d66e57()
        }));
        this.AddMember("get_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_4a304da73e354399b5352d05de8339d9()
        }));
        this.AddMember("set_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_0f42f5713c2041eca4ca98cbe559c3c3()
        }));
        this.AddMember("get_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_e02246dfcbdc4edc92e23d5d38fb694b()
        }));
        this.AddMember("set_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_291dc8bf82584970b5f11b04a7e558e7()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_fa8200a43855492b86d867040f8c2520()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_f19f08cfa9374dfcafa5265d74e31d11()
        }));
        this.AddMember("get_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_3e7f0b5ca835416e9bf135ef0c86826c()
        }));
        this.AddMember("set_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_3fa5b7e2c0e1425c8367a1724de6cb7c()
        }));
        this.AddMember("get_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_ee6a35b5842c456ba160712b7e42739f()
        }));
        this.AddMember("set_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_7d29c787613c4651a514d49221d5a6bd()
        }));
        this.AddMember("get_waiting", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waiting", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_aa2fae5479ea4f008302ea5b847a433c()
        }));
        this.AddMember("get_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_41cb2c5db09f488e96bd92b35f7f98d2()
        }));
        this.AddMember("set_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_ba16a36fb30f4d8b904189a9200c84c8()
        }));
        this.AddMember("get_busy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_busy", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_ef624bdc366d4c78999f85e6ce722f16()
        }));
        this.AddMember("get_ongoing", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_ongoing", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_71812b6b13aa44228cff27c451a90991()
        }));
        this.AddMember("get_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_608663cb35a04b4ca2782c8398cf9cc0()
        }));
        this.AddMember("set_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_182c7b9f855a45bc9095ff2b07c73f2c()
        }));
        this.AddMember("get_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_4b0087ccdbc3440bbc14be40778962a3()
        }));
        this.AddMember("set_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_71d792a56ec64b3fbe1798ddeaae952f()
        }));
        this.AddMember("get_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_e20feb9a47ae450bbd673032d8ee1887()
        }));
        this.AddMember("set_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_6b2b0837b16f4e49be0a23016d99cfac()
        }));
        this.AddMember("get_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_4b0b28b6322e4e24958639681ace61b6()
        }));
        this.AddMember("set_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_995f9e53087a4625b324c338cf3ab2de()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_128b3c86316941509ab1ea2dfa87b7d5()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_808329d1fc88424e987cab0789eb9f36()
        }));
        this.AddMember("get_mousePosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mousePosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_79122f981c8c41c3bc858e04f823d80d()
        }));
        this.AddMember("get_mouseOverUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mouseOverUI", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_d89778d5de044108a03951b43a75a501()
        }));
        this.AddMember("worldToCanvas", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("worldToCanvas", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_ad938ecd67794861b203ed9779f7b6ae()
        }));
        this.AddMember("canvasToWorld", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("canvasToWorld", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_6f7f8e6b9a614ad196751be849a20b3f()
        }));
        this.AddMember("get_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_6b938f5ae81c438d81cecf2c7063ceb8()
        }));
        this.AddMember("set_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_4eafe8677c6f4de4aeb9af98e9e05235()
        }));
        this.AddMember("get_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_663ef36df3664cd69f0f0f1ebc2b12b2()
        }));
        this.AddMember("set_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_ade10e91585b417d83eaf0ea42a946e3()
        }));
        this.AddMember("getMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_2c24544aefda4773ba65ebdc478074eb()
        }));
        this.AddMember("setMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_ae6675b65ede4b8f9199225135c7e2de()
        }));
        this.AddMember("Dispose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Dispose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_c622f1de8d914670ad60425556f95d26()
        }));
        this.AddMember("drawImage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawImage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_212461d8a89940209f978925fa11095c()
        }));
        this.AddMember("drawRectangle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawRectangle", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_662f3bc32c8e43d78b485d0bb34a4608()
        }));
        this.AddMember("drawEllipseOutline", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipseOutline", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_974f600fb21c4e4384684ac18d207379()
        }));
        this.AddMember("drawEllipse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipse", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_69153eee214d4f0a8c79afbdd4f39efa()
        }));
        this.AddMember("blit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_6d3aca71a32d49e18f5f0258745f7a1b()
        }));
        this.AddMember("blitRotate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blitRotate", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_cfe914b279ac48c29f459760d3c0115e()
        }));
        this.AddMember("applyDraw", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("applyDraw", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_3332a598b2224ca2bb7a5b85c67d7495()
        }));
        this.AddMember("get_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_4ba71c70b5f84b1e903ea20c26ce218a()
        }));
        this.AddMember("set_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_3ae56c8411d54a13bc5e4e5288d2e2d4()
        }));
        this.AddMember("get_isUsingTouchControls", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isUsingTouchControls", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_5f9f4739c7714efebd68e08d0ea81c7f()
        }));
        this.AddMember("clientRefreshSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clientRefreshSpells", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_84a4edd45d404153946f015502b4580e()
        }));
        this.AddMember("startCoroutine", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("startCoroutine", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_10ef2c72a9314431a44164564d238f8a()
        }));
        this.AddMember("devCommand", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("devCommand", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_ef75557262a44296b10a57f090745232()
        }));
        this.AddMember("win", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("win", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_02870b39a1554ebe9b42398ad8014086()
        }));
        this.AddMember("lose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("lose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_4d512877d5be41cb9353284b0321c162()
        }));
        this.AddMember("nextTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("nextTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_dc517645fdc442dda7aab8ddcb96062f()
        }));
        this.AddMember("resetMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("resetMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_14d9e15c559a4a2a858f9e98fff577b8()
        }));
        this.AddMember("clearMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_02efbdb6d156451dabcc7cb8dd238444()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_f440726f00fd44d782225011f8fb7d1d()
        }));
        this.AddMember("getSpellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellEnum", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_75230279997644f4bac3ba948db7794f()
        }));
        this.AddMember("getSpellName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_cf53759d8d714239b034b82657033fe8()
        }));
        this.AddMember("getMapID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapID", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_13c29976af894c3d8e782734cd0ff9fc()
        }));
        this.AddMember("getMapRealName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapRealName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_781b47414a7a4a9e8d31acaf9a1efa80()
        }));
        this.AddMember("getMapShortName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapShortName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_4995a63bf6f244769e72621bfa30f9ea()
        }));
        this.AddMember("getArmageddonName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getArmageddonName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_68387838ecfe46799e8dd8728db4e5e5()
        }));
        this.AddMember("panCamera", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("panCamera", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_d8352a98b2114bfb9a7f6dc31a7360ef()
        }));
        this.AddMember("cameraFollow", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("cameraFollow", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_4212d6b250724e52bc0d79533057c420()
        }));
        this.AddMember("getInputString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getInputString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_9696fa83d27e4dbc94e409864aff8cb2()
        }));
        this.AddMember("get_screenWidth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenWidth", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_ed59be26c85440899b4a12ae56ace7db()
        }));
        this.AddMember("get_screenHeight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenHeight", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_15ff1cce8390474b8a769d173ac524ab()
        }));
        this.AddMember("createCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createCreature", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_1c5ce880d99e47a2bf8e5d2bcdff5970()
        }));
        this.AddMember("clearIndicators", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearIndicators", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_874d5123ca714d45977a90433d953090()
        }));
        this.AddMember("createIndicator", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createIndicator", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_70af352de0ba47c282969583e00ce383(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_df0e658726d34ed7ae4a2793d6aecef6()
        }));
        this.AddMember("getKeyBinds", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getKeyBinds", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_5afe478acf11493a81265346e1f361bf()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_99bc2f48c2e841739c68a536f5c7ce3f()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_bd306097d2a44d58ad0dac2b70b25372()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_52e0f5daa04445408669a7a7ff623c65()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.MTHD_0d8e2784c3bf42b3bc0acb9bde1b116e()
        }));
        this.AddMember("turn", (IMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.PROP_5ddad129e0924a6e9fe91288355d779c());
        this.AddMember("timeLimit", (IMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.PROP_2e11e4f71e914079aa4d92c523526080());
        this.AddMember("totalTimeElapsed", (IMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.PROP_7e96f61fd8e845b6b3a09444c543212e());
        this.AddMember("turnTime", (IMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.PROP_2b3fcb5817ce44bd9e7a14c6213a67df());
        this.AddMember("frame", (IMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.PROP_53fa9ae6d4834b3696fc15f0989792f3());
        this.AddMember("winOnDeath", (IMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.PROP_520528f250dc4cd8a875dbcea55564e1());
        this.AddMember("allowMovement", (IMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.PROP_9481b9f06cd945de8548f0d9e4a9a57f());
        this.AddMember("allowMinionMovement", (IMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.PROP_6eff71a39d934070a25442ac5f9b0372());
        this.AddMember("allowInput", (IMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.PROP_b7f500f6eb0141b792262d8a433170cc());
        this.AddMember("allowCallbacks", (IMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.PROP_7b03bcda80ee4e6480bbecb528085713());
        this.AddMember("allowSkipTurn", (IMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.PROP_9547b12d978b4a8a80db63f1a6954de6());
        this.AddMember("terrainDestruction", (IMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.PROP_b37a7a36f85f444490548d74bead3533());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.PROP_7d392a3000e14e378b7a5d89b5090e24());
        this.AddMember("armageddon", (IMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.PROP_de0e2f44ea2b41ef8152cc8e2787e0b4());
        this.AddMember("armageddonTurn", (IMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.PROP_a94e73c9e2b243f29fddc2204676bf54());
        this.AddMember("waiting", (IMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.PROP_4234a8f6eeea46b889cc389b93af390d());
        this.AddMember("paused", (IMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.PROP_7553eb78406e40928da382bfc2ba1175());
        this.AddMember("busy", (IMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.PROP_4a2e2e5893e04c2ba9807a9c2823189b());
        this.AddMember("ongoing", (IMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.PROP_e0da23e958ea4da2b561fe723e533223());
        this.AddMember("gravity", (IMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.PROP_a054c0f6d4b9470ab3542c0f907464fb());
        this.AddMember("wind", (IMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.PROP_c7a4839ea52c4b07acd7d0c6363e837c());
        this.AddMember("windDir", (IMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.PROP_f46213e3cd944be3820526342b7b69bb());
        this.AddMember("windPower", (IMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.PROP_058f7789a15f45f6b33e8a1da2ad4191());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.PROP_0c5601d97bad4b05988464df883eb990());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.PROP_1dc41232906e48959f2a78082655a68a());
        this.AddMember("mousePosition", (IMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.PROP_14efaec0b889419080c5480f06b634a8());
        this.AddMember("mouseOverUI", (IMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.PROP_c9195617a905429e8e0bf8e1cfc42b00());
        this.AddMember("cameraPosition", (IMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.PROP_db69f2167b6a40b7b9a97c44fd564fc3());
        this.AddMember("cameraZoom", (IMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.PROP_ae03d791b87a412297f53c8ca406d3f9());
        this.AddMember("allowBounce", (IMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.PROP_caeacb294170489ab720ff7bfb8274a7());
        this.AddMember("isUsingTouchControls", (IMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.PROP_a14deb5bdf5949d5adc2df44a651d233());
        this.AddMember("screenWidth", (IMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.PROP_e442d4ea01f84bce9f782609445baa3f());
        this.AddMember("screenHeight", (IMemberDescriptor) new Bridge.TYPE_bcd042bd15e1459bb5e402a7ce5ac8df.PROP_59df5f6318cb43e594c727ade5ed2908());
      }

      private sealed class MTHD_776c8b48675649448c26f4b5a0bc2f05 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_776c8b48675649448c26f4b5a0bc2f05()
        {
          this.Initialize("getUser", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getUser();
        }
      }

      private sealed class MTHD_4543d414a5184160aed96ce87de8c50d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4543d414a5184160aed96ce87de8c50d()
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

      private sealed class MTHD_45658f0624004d9ab132a67c7908463e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_45658f0624004d9ab132a67c7908463e()
        {
          this.Initialize("getPlayerCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getPlayerCount();
        }
      }

      private sealed class MTHD_6bff3a4fcfbe4108bdd51a5c238f112e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6bff3a4fcfbe4108bdd51a5c238f112e()
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

      private sealed class MTHD_bf51038afc9d4083b966552b4e2f4399 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bf51038afc9d4083b966552b4e2f4399()
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

      private sealed class MTHD_8b6559ba0ae246b5b2501891b20d476c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8b6559ba0ae246b5b2501891b20d476c()
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

      private sealed class MTHD_6872eb413de94fd48557496fbf1642ab : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6872eb413de94fd48557496fbf1642ab()
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

      private sealed class MTHD_fc339d0169fd4bddb50fb960e27a1e9d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fc339d0169fd4bddb50fb960e27a1e9d()
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

      private sealed class MTHD_53a15a2b83c645949567ec952b6e9b9c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_53a15a2b83c645949567ec952b6e9b9c()
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

      private sealed class MTHD_c47eba4c072041b58f437cb85bb68d9b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c47eba4c072041b58f437cb85bb68d9b()
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

      private sealed class MTHD_0b3c8b1e2d5e47b898a48f7407fb6bef : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0b3c8b1e2d5e47b898a48f7407fb6bef()
        {
          this.Initialize("hideInfo", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).hideInfo();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_90772cc2195d4e8e83bba74ff5082c3e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_90772cc2195d4e8e83bba74ff5082c3e()
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

      private sealed class MTHD_db521bac29a54916b8a486e27ef469b3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_db521bac29a54916b8a486e27ef469b3()
        {
          this.Initialize("get_turn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turn;
        }
      }

      private sealed class MTHD_40fa9a0d2bc6448c9cb84234013e1536 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_40fa9a0d2bc6448c9cb84234013e1536()
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

      private sealed class MTHD_ca227f816f7549fba39b1f0fb5608c80 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ca227f816f7549fba39b1f0fb5608c80()
        {
          this.Initialize("get_timeLimit", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).timeLimit;
        }
      }

      private sealed class MTHD_d85327aab1bb4ef2b101d97991887c5e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d85327aab1bb4ef2b101d97991887c5e()
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

      private sealed class MTHD_63ea0cdfd3404b59bc98f97f9aa3071a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_63ea0cdfd3404b59bc98f97f9aa3071a()
        {
          this.Initialize("get_totalTimeElapsed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class MTHD_bf0e7f0545e3477f89f8d011ca1c6a6a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bf0e7f0545e3477f89f8d011ca1c6a6a()
        {
          this.Initialize("get_turnTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class MTHD_a6f733ea57dd4e84add45ef9a6c0daac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a6f733ea57dd4e84add45ef9a6c0daac()
        {
          this.Initialize("get_frame", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class MTHD_f38deb65d9594bbc86800068d7140971 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f38deb65d9594bbc86800068d7140971()
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

      private sealed class MTHD_55fc5f3e33574240bee3fc9267cbfeac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_55fc5f3e33574240bee3fc9267cbfeac()
        {
          this.Initialize("get_winOnDeath", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).winOnDeath;
        }
      }

      private sealed class MTHD_180998fc5efc44a08761ea582aba39d9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_180998fc5efc44a08761ea582aba39d9()
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

      private sealed class MTHD_0b15a97074d1468abf5fe6d43bbfa40d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0b15a97074d1468abf5fe6d43bbfa40d()
        {
          this.Initialize("get_allowMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMovement;
        }
      }

      private sealed class MTHD_fe09a9755cdd4665aa0c996b417ec9a1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fe09a9755cdd4665aa0c996b417ec9a1()
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

      private sealed class MTHD_e10faeee70494048b0f146047de4a107 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e10faeee70494048b0f146047de4a107()
        {
          this.Initialize("get_allowMinionMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMinionMovement;
        }
      }

      private sealed class MTHD_61ce3b68bcae4f649963933a29a24d24 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_61ce3b68bcae4f649963933a29a24d24()
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

      private sealed class MTHD_0af3c320c9d8418d89cca80f6e9e8212 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0af3c320c9d8418d89cca80f6e9e8212()
        {
          this.Initialize("get_allowInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowInput;
        }
      }

      private sealed class MTHD_3079b7ba1ad343c290420b5894597b33 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3079b7ba1ad343c290420b5894597b33()
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

      private sealed class MTHD_dc761436ff9c4a0899c83e6cf1c31773 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dc761436ff9c4a0899c83e6cf1c31773()
        {
          this.Initialize("get_allowCallbacks", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowCallbacks;
        }
      }

      private sealed class MTHD_ff902dc7bdfb46bcb1dbf62b92d66e57 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ff902dc7bdfb46bcb1dbf62b92d66e57()
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

      private sealed class MTHD_4a304da73e354399b5352d05de8339d9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4a304da73e354399b5352d05de8339d9()
        {
          this.Initialize("get_allowSkipTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowSkipTurn;
        }
      }

      private sealed class MTHD_0f42f5713c2041eca4ca98cbe559c3c3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0f42f5713c2041eca4ca98cbe559c3c3()
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

      private sealed class MTHD_e02246dfcbdc4edc92e23d5d38fb694b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e02246dfcbdc4edc92e23d5d38fb694b()
        {
          this.Initialize("get_terrainDestruction", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).terrainDestruction;
        }
      }

      private sealed class MTHD_291dc8bf82584970b5f11b04a7e558e7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_291dc8bf82584970b5f11b04a7e558e7()
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

      private sealed class MTHD_fa8200a43855492b86d867040f8c2520 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fa8200a43855492b86d867040f8c2520()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).takeDamage;
        }
      }

      private sealed class MTHD_f19f08cfa9374dfcafa5265d74e31d11 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f19f08cfa9374dfcafa5265d74e31d11()
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

      private sealed class MTHD_3e7f0b5ca835416e9bf135ef0c86826c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3e7f0b5ca835416e9bf135ef0c86826c()
        {
          this.Initialize("get_armageddon", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddon;
        }
      }

      private sealed class MTHD_3fa5b7e2c0e1425c8367a1724de6cb7c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3fa5b7e2c0e1425c8367a1724de6cb7c()
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

      private sealed class MTHD_ee6a35b5842c456ba160712b7e42739f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ee6a35b5842c456ba160712b7e42739f()
        {
          this.Initialize("get_armageddonTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddonTurn;
        }
      }

      private sealed class MTHD_7d29c787613c4651a514d49221d5a6bd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7d29c787613c4651a514d49221d5a6bd()
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

      private sealed class MTHD_aa2fae5479ea4f008302ea5b847a433c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aa2fae5479ea4f008302ea5b847a433c()
        {
          this.Initialize("get_waiting", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class MTHD_41cb2c5db09f488e96bd92b35f7f98d2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_41cb2c5db09f488e96bd92b35f7f98d2()
        {
          this.Initialize("get_paused", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).paused;
        }
      }

      private sealed class MTHD_ba16a36fb30f4d8b904189a9200c84c8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ba16a36fb30f4d8b904189a9200c84c8()
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

      private sealed class MTHD_ef624bdc366d4c78999f85e6ce722f16 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ef624bdc366d4c78999f85e6ce722f16()
        {
          this.Initialize("get_busy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class MTHD_71812b6b13aa44228cff27c451a90991 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_71812b6b13aa44228cff27c451a90991()
        {
          this.Initialize("get_ongoing", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class MTHD_608663cb35a04b4ca2782c8398cf9cc0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_608663cb35a04b4ca2782c8398cf9cc0()
        {
          this.Initialize("get_gravity", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).gravity;
        }
      }

      private sealed class MTHD_182c7b9f855a45bc9095ff2b07c73f2c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_182c7b9f855a45bc9095ff2b07c73f2c()
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

      private sealed class MTHD_4b0087ccdbc3440bbc14be40778962a3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4b0087ccdbc3440bbc14be40778962a3()
        {
          this.Initialize("get_wind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).wind;
        }
      }

      private sealed class MTHD_71d792a56ec64b3fbe1798ddeaae952f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_71d792a56ec64b3fbe1798ddeaae952f()
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

      private sealed class MTHD_e20feb9a47ae450bbd673032d8ee1887 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e20feb9a47ae450bbd673032d8ee1887()
        {
          this.Initialize("get_windDir", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windDir;
        }
      }

      private sealed class MTHD_6b2b0837b16f4e49be0a23016d99cfac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6b2b0837b16f4e49be0a23016d99cfac()
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

      private sealed class MTHD_4b0b28b6322e4e24958639681ace61b6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4b0b28b6322e4e24958639681ace61b6()
        {
          this.Initialize("get_windPower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windPower;
        }
      }

      private sealed class MTHD_995f9e53087a4625b324c338cf3ab2de : HardwiredMethodMemberDescriptor
      {
        internal MTHD_995f9e53087a4625b324c338cf3ab2de()
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

      private sealed class MTHD_128b3c86316941509ab1ea2dfa87b7d5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_128b3c86316941509ab1ea2dfa87b7d5()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class MTHD_808329d1fc88424e987cab0789eb9f36 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_808329d1fc88424e987cab0789eb9f36()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class MTHD_79122f981c8c41c3bc858e04f823d80d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_79122f981c8c41c3bc858e04f823d80d()
        {
          this.Initialize("get_mousePosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class MTHD_d89778d5de044108a03951b43a75a501 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d89778d5de044108a03951b43a75a501()
        {
          this.Initialize("get_mouseOverUI", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class MTHD_ad938ecd67794861b203ed9779f7b6ae : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ad938ecd67794861b203ed9779f7b6ae()
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

      private sealed class MTHD_6f7f8e6b9a614ad196751be849a20b3f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6f7f8e6b9a614ad196751be849a20b3f()
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

      private sealed class MTHD_6b938f5ae81c438d81cecf2c7063ceb8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6b938f5ae81c438d81cecf2c7063ceb8()
        {
          this.Initialize("get_cameraPosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraPosition;
        }
      }

      private sealed class MTHD_4eafe8677c6f4de4aeb9af98e9e05235 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4eafe8677c6f4de4aeb9af98e9e05235()
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

      private sealed class MTHD_663ef36df3664cd69f0f0f1ebc2b12b2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_663ef36df3664cd69f0f0f1ebc2b12b2()
        {
          this.Initialize("get_cameraZoom", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraZoom;
        }
      }

      private sealed class MTHD_ade10e91585b417d83eaf0ea42a946e3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ade10e91585b417d83eaf0ea42a946e3()
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

      private sealed class MTHD_2c24544aefda4773ba65ebdc478074eb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2c24544aefda4773ba65ebdc478074eb()
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

      private sealed class MTHD_ae6675b65ede4b8f9199225135c7e2de : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ae6675b65ede4b8f9199225135c7e2de()
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

      private sealed class MTHD_c622f1de8d914670ad60425556f95d26 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c622f1de8d914670ad60425556f95d26()
        {
          this.Initialize("Dispose", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ContainerGame.Dispose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_212461d8a89940209f978925fa11095c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_212461d8a89940209f978925fa11095c()
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

      private sealed class MTHD_662f3bc32c8e43d78b485d0bb34a4608 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_662f3bc32c8e43d78b485d0bb34a4608()
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

      private sealed class MTHD_974f600fb21c4e4384684ac18d207379 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_974f600fb21c4e4384684ac18d207379()
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

      private sealed class MTHD_69153eee214d4f0a8c79afbdd4f39efa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_69153eee214d4f0a8c79afbdd4f39efa()
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

      private sealed class MTHD_6d3aca71a32d49e18f5f0258745f7a1b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6d3aca71a32d49e18f5f0258745f7a1b()
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

      private sealed class MTHD_cfe914b279ac48c29f459760d3c0115e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cfe914b279ac48c29f459760d3c0115e()
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

      private sealed class MTHD_3332a598b2224ca2bb7a5b85c67d7495 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3332a598b2224ca2bb7a5b85c67d7495()
        {
          this.Initialize("applyDraw", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).applyDraw();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_4ba71c70b5f84b1e903ea20c26ce218a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4ba71c70b5f84b1e903ea20c26ce218a()
        {
          this.Initialize("get_allowBounce", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowBounce;
        }
      }

      private sealed class MTHD_3ae56c8411d54a13bc5e4e5288d2e2d4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3ae56c8411d54a13bc5e4e5288d2e2d4()
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

      private sealed class MTHD_5f9f4739c7714efebd68e08d0ea81c7f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5f9f4739c7714efebd68e08d0ea81c7f()
        {
          this.Initialize("get_isUsingTouchControls", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class MTHD_84a4edd45d404153946f015502b4580e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_84a4edd45d404153946f015502b4580e()
        {
          this.Initialize("clientRefreshSpells", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clientRefreshSpells();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_10ef2c72a9314431a44164564d238f8a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_10ef2c72a9314431a44164564d238f8a()
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

      private sealed class MTHD_ef75557262a44296b10a57f090745232 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ef75557262a44296b10a57f090745232()
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

      private sealed class MTHD_02870b39a1554ebe9b42398ad8014086 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_02870b39a1554ebe9b42398ad8014086()
        {
          this.Initialize("win", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).win();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_4d512877d5be41cb9353284b0321c162 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4d512877d5be41cb9353284b0321c162()
        {
          this.Initialize("lose", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).lose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_dc517645fdc442dda7aab8ddcb96062f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dc517645fdc442dda7aab8ddcb96062f()
        {
          this.Initialize("nextTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).nextTurn();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_14d9e15c559a4a2a858f9e98fff577b8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_14d9e15c559a4a2a858f9e98fff577b8()
        {
          this.Initialize("resetMap", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).resetMap();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_02efbdb6d156451dabcc7cb8dd238444 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_02efbdb6d156451dabcc7cb8dd238444()
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

      private sealed class MTHD_f440726f00fd44d782225011f8fb7d1d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f440726f00fd44d782225011f8fb7d1d()
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

      private sealed class MTHD_75230279997644f4bac3ba948db7794f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_75230279997644f4bac3ba948db7794f()
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

      private sealed class MTHD_cf53759d8d714239b034b82657033fe8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cf53759d8d714239b034b82657033fe8()
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

      private sealed class MTHD_13c29976af894c3d8e782734cd0ff9fc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_13c29976af894c3d8e782734cd0ff9fc()
        {
          this.Initialize("getMapID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getMapID();
        }
      }

      private sealed class MTHD_781b47414a7a4a9e8d31acaf9a1efa80 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_781b47414a7a4a9e8d31acaf9a1efa80()
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

      private sealed class MTHD_4995a63bf6f244769e72621bfa30f9ea : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4995a63bf6f244769e72621bfa30f9ea()
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

      private sealed class MTHD_68387838ecfe46799e8dd8728db4e5e5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_68387838ecfe46799e8dd8728db4e5e5()
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

      private sealed class MTHD_d8352a98b2114bfb9a7f6dc31a7360ef : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d8352a98b2114bfb9a7f6dc31a7360ef()
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

      private sealed class MTHD_4212d6b250724e52bc0d79533057c420 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4212d6b250724e52bc0d79533057c420()
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

      private sealed class MTHD_9696fa83d27e4dbc94e409864aff8cb2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9696fa83d27e4dbc94e409864aff8cb2()
        {
          this.Initialize("getInputString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getInputString();
        }
      }

      private sealed class MTHD_ed59be26c85440899b4a12ae56ace7db : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ed59be26c85440899b4a12ae56ace7db()
        {
          this.Initialize("get_screenWidth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class MTHD_15ff1cce8390474b8a769d173ac524ab : HardwiredMethodMemberDescriptor
      {
        internal MTHD_15ff1cce8390474b8a769d173ac524ab()
        {
          this.Initialize("get_screenHeight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }

      private sealed class MTHD_1c5ce880d99e47a2bf8e5d2bcdff5970 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1c5ce880d99e47a2bf8e5d2bcdff5970()
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

      private sealed class MTHD_874d5123ca714d45977a90433d953090 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_874d5123ca714d45977a90433d953090()
        {
          this.Initialize("clearIndicators", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clearIndicators();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_70af352de0ba47c282969583e00ce383 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_70af352de0ba47c282969583e00ce383()
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

      private sealed class MTHD_df0e658726d34ed7ae4a2793d6aecef6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_df0e658726d34ed7ae4a2793d6aecef6()
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

      private sealed class MTHD_5afe478acf11493a81265346e1f361bf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5afe478acf11493a81265346e1f361bf()
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

      private sealed class MTHD_99bc2f48c2e841739c68a536f5c7ce3f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_99bc2f48c2e841739c68a536f5c7ce3f()
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

      private sealed class MTHD_bd306097d2a44d58ad0dac2b70b25372 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bd306097d2a44d58ad0dac2b70b25372()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_52e0f5daa04445408669a7a7ff623c65 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_52e0f5daa04445408669a7a7ff623c65()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_0d8e2784c3bf42b3bc0acb9bde1b116e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0d8e2784c3bf42b3bc0acb9bde1b116e()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_5ddad129e0924a6e9fe91288355d779c : HardwiredMemberDescriptor
      {
        internal PROP_5ddad129e0924a6e9fe91288355d779c()
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

      private sealed class PROP_2e11e4f71e914079aa4d92c523526080 : HardwiredMemberDescriptor
      {
        internal PROP_2e11e4f71e914079aa4d92c523526080()
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

      private sealed class PROP_7e96f61fd8e845b6b3a09444c543212e : HardwiredMemberDescriptor
      {
        internal PROP_7e96f61fd8e845b6b3a09444c543212e()
          : base(typeof (double), "totalTimeElapsed", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class PROP_2b3fcb5817ce44bd9e7a14c6213a67df : HardwiredMemberDescriptor
      {
        internal PROP_2b3fcb5817ce44bd9e7a14c6213a67df()
          : base(typeof (double), "turnTime", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class PROP_53fa9ae6d4834b3696fc15f0989792f3 : HardwiredMemberDescriptor
      {
        internal PROP_53fa9ae6d4834b3696fc15f0989792f3()
          : base(typeof (int), "frame", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class PROP_520528f250dc4cd8a875dbcea55564e1 : HardwiredMemberDescriptor
      {
        internal PROP_520528f250dc4cd8a875dbcea55564e1()
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

      private sealed class PROP_9481b9f06cd945de8548f0d9e4a9a57f : HardwiredMemberDescriptor
      {
        internal PROP_9481b9f06cd945de8548f0d9e4a9a57f()
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

      private sealed class PROP_6eff71a39d934070a25442ac5f9b0372 : HardwiredMemberDescriptor
      {
        internal PROP_6eff71a39d934070a25442ac5f9b0372()
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

      private sealed class PROP_b7f500f6eb0141b792262d8a433170cc : HardwiredMemberDescriptor
      {
        internal PROP_b7f500f6eb0141b792262d8a433170cc()
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

      private sealed class PROP_7b03bcda80ee4e6480bbecb528085713 : HardwiredMemberDescriptor
      {
        internal PROP_7b03bcda80ee4e6480bbecb528085713()
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

      private sealed class PROP_9547b12d978b4a8a80db63f1a6954de6 : HardwiredMemberDescriptor
      {
        internal PROP_9547b12d978b4a8a80db63f1a6954de6()
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

      private sealed class PROP_b37a7a36f85f444490548d74bead3533 : HardwiredMemberDescriptor
      {
        internal PROP_b37a7a36f85f444490548d74bead3533()
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

      private sealed class PROP_7d392a3000e14e378b7a5d89b5090e24 : HardwiredMemberDescriptor
      {
        internal PROP_7d392a3000e14e378b7a5d89b5090e24()
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

      private sealed class PROP_de0e2f44ea2b41ef8152cc8e2787e0b4 : HardwiredMemberDescriptor
      {
        internal PROP_de0e2f44ea2b41ef8152cc8e2787e0b4()
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

      private sealed class PROP_a94e73c9e2b243f29fddc2204676bf54 : HardwiredMemberDescriptor
      {
        internal PROP_a94e73c9e2b243f29fddc2204676bf54()
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

      private sealed class PROP_4234a8f6eeea46b889cc389b93af390d : HardwiredMemberDescriptor
      {
        internal PROP_4234a8f6eeea46b889cc389b93af390d()
          : base(typeof (bool), "waiting", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class PROP_7553eb78406e40928da382bfc2ba1175 : HardwiredMemberDescriptor
      {
        internal PROP_7553eb78406e40928da382bfc2ba1175()
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

      private sealed class PROP_4a2e2e5893e04c2ba9807a9c2823189b : HardwiredMemberDescriptor
      {
        internal PROP_4a2e2e5893e04c2ba9807a9c2823189b()
          : base(typeof (bool), "busy", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class PROP_e0da23e958ea4da2b561fe723e533223 : HardwiredMemberDescriptor
      {
        internal PROP_e0da23e958ea4da2b561fe723e533223()
          : base(typeof (bool), "ongoing", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class PROP_a054c0f6d4b9470ab3542c0f907464fb : HardwiredMemberDescriptor
      {
        internal PROP_a054c0f6d4b9470ab3542c0f907464fb()
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

      private sealed class PROP_c7a4839ea52c4b07acd7d0c6363e837c : HardwiredMemberDescriptor
      {
        internal PROP_c7a4839ea52c4b07acd7d0c6363e837c()
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

      private sealed class PROP_f46213e3cd944be3820526342b7b69bb : HardwiredMemberDescriptor
      {
        internal PROP_f46213e3cd944be3820526342b7b69bb()
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

      private sealed class PROP_058f7789a15f45f6b33e8a1da2ad4191 : HardwiredMemberDescriptor
      {
        internal PROP_058f7789a15f45f6b33e8a1da2ad4191()
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

      private sealed class PROP_0c5601d97bad4b05988464df883eb990 : HardwiredMemberDescriptor
      {
        internal PROP_0c5601d97bad4b05988464df883eb990()
          : base(typeof (int), "width", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class PROP_1dc41232906e48959f2a78082655a68a : HardwiredMemberDescriptor
      {
        internal PROP_1dc41232906e48959f2a78082655a68a()
          : base(typeof (int), "height", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class PROP_14efaec0b889419080c5480f06b634a8 : HardwiredMemberDescriptor
      {
        internal PROP_14efaec0b889419080c5480f06b634a8()
          : base(typeof (Educative.Point), "mousePosition", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class PROP_c9195617a905429e8e0bf8e1cfc42b00 : HardwiredMemberDescriptor
      {
        internal PROP_c9195617a905429e8e0bf8e1cfc42b00()
          : base(typeof (bool), "mouseOverUI", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class PROP_db69f2167b6a40b7b9a97c44fd564fc3 : HardwiredMemberDescriptor
      {
        internal PROP_db69f2167b6a40b7b9a97c44fd564fc3()
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

      private sealed class PROP_ae03d791b87a412297f53c8ca406d3f9 : HardwiredMemberDescriptor
      {
        internal PROP_ae03d791b87a412297f53c8ca406d3f9()
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

      private sealed class PROP_caeacb294170489ab720ff7bfb8274a7 : HardwiredMemberDescriptor
      {
        internal PROP_caeacb294170489ab720ff7bfb8274a7()
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

      private sealed class PROP_a14deb5bdf5949d5adc2df44a651d233 : HardwiredMemberDescriptor
      {
        internal PROP_a14deb5bdf5949d5adc2df44a651d233()
          : base(typeof (bool), "isUsingTouchControls", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class PROP_e442d4ea01f84bce9f782609445baa3f : HardwiredMemberDescriptor
      {
        internal PROP_e442d4ea01f84bce9f782609445baa3f()
          : base(typeof (double), "screenWidth", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class PROP_59df5f6318cb43e594c727ade5ed2908 : HardwiredMemberDescriptor
      {
        internal PROP_59df5f6318cb43e594c727ade5ed2908()
          : base(typeof (double), "screenHeight", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }
    }

    private sealed class TYPE_b65e6f0c706243d497663152c8912148 : HardwiredUserDataDescriptor
    {
      internal TYPE_b65e6f0c706243d497663152c8912148()
        : base(typeof (ContainerPlayer))
      {
        this.AddMember("get_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b65e6f0c706243d497663152c8912148.MTHD_9b311645d68a406aada395f773f36e98()
        }));
        this.AddMember("set_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b65e6f0c706243d497663152c8912148.MTHD_72f9e534279a44ffbb15898a201ecd9a()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b65e6f0c706243d497663152c8912148.MTHD_dd65db8557674fa99cb6e074671b9db4()
        }));
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b65e6f0c706243d497663152c8912148.MTHD_19a01a8060a142f1a863f251faa079ce()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b65e6f0c706243d497663152c8912148.MTHD_b95c7ab358de4bc08598f33b6894c38e()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b65e6f0c706243d497663152c8912148.MTHD_1b07b9b324d54de0820dcce4d634b2ad()
        }));
        this.AddMember("getCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreature", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b65e6f0c706243d497663152c8912148.MTHD_b9f63a8235f0475791b9a7e4fc99ce8c()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b65e6f0c706243d497663152c8912148.MTHD_b30ad55e6df8461ebd7319e75187f2c3()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b65e6f0c706243d497663152c8912148.MTHD_e519a84af3104e5eac1e770c499091f2()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b65e6f0c706243d497663152c8912148.MTHD_1175c8a3e81b491e823ad913174aaa89()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b65e6f0c706243d497663152c8912148.MTHD_ad6800311595413c9ceb0cf98f558b95()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b65e6f0c706243d497663152c8912148.MTHD_092e9c39f37d479f911af9d0bbaa9f04()
        }));
        this.AddMember("localTurn", (IMemberDescriptor) new Bridge.TYPE_b65e6f0c706243d497663152c8912148.PROP_7d0d8c17c40e4fadaa1a4be7a967ebc1());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_b65e6f0c706243d497663152c8912148.PROP_6ac003e48b7b40d9badd8b11df0fbbc5());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_b65e6f0c706243d497663152c8912148.PROP_1a858c92a7624e7791d404d81c5ae160());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_b65e6f0c706243d497663152c8912148.PROP_7923cef4feae4adebc9367b3d3b98a88());
      }

      private sealed class MTHD_9b311645d68a406aada395f773f36e98 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9b311645d68a406aada395f773f36e98()
        {
          this.Initialize("get_localTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).localTurn;
        }
      }

      private sealed class MTHD_72f9e534279a44ffbb15898a201ecd9a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_72f9e534279a44ffbb15898a201ecd9a()
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

      private sealed class MTHD_dd65db8557674fa99cb6e074671b9db4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dd65db8557674fa99cb6e074671b9db4()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class MTHD_19a01a8060a142f1a863f251faa079ce : HardwiredMethodMemberDescriptor
      {
        internal MTHD_19a01a8060a142f1a863f251faa079ce()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class MTHD_b95c7ab358de4bc08598f33b6894c38e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b95c7ab358de4bc08598f33b6894c38e()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }

      private sealed class MTHD_1b07b9b324d54de0820dcce4d634b2ad : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1b07b9b324d54de0820dcce4d634b2ad()
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

      private sealed class MTHD_b9f63a8235f0475791b9a7e4fc99ce8c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b9f63a8235f0475791b9a7e4fc99ce8c()
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

      private sealed class MTHD_b30ad55e6df8461ebd7319e75187f2c3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b30ad55e6df8461ebd7319e75187f2c3()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).getMinionCount();
        }
      }

      private sealed class MTHD_e519a84af3104e5eac1e770c499091f2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e519a84af3104e5eac1e770c499091f2()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).GetHashCode();
        }
      }

      private sealed class MTHD_1175c8a3e81b491e823ad913174aaa89 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1175c8a3e81b491e823ad913174aaa89()
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

      private sealed class MTHD_ad6800311595413c9ceb0cf98f558b95 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ad6800311595413c9ceb0cf98f558b95()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_092e9c39f37d479f911af9d0bbaa9f04 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_092e9c39f37d479f911af9d0bbaa9f04()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_7d0d8c17c40e4fadaa1a4be7a967ebc1 : HardwiredMemberDescriptor
      {
        internal PROP_7d0d8c17c40e4fadaa1a4be7a967ebc1()
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

      private sealed class PROP_6ac003e48b7b40d9badd8b11df0fbbc5 : HardwiredMemberDescriptor
      {
        internal PROP_6ac003e48b7b40d9badd8b11df0fbbc5()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class PROP_1a858c92a7624e7791d404d81c5ae160 : HardwiredMemberDescriptor
      {
        internal PROP_1a858c92a7624e7791d404d81c5ae160()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class PROP_7923cef4feae4adebc9367b3d3b98a88 : HardwiredMemberDescriptor
      {
        internal PROP_7923cef4feae4adebc9367b3d3b98a88()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }
    }

    private sealed class TYPE_ff0a89bdceea4c34b91be071cbc4b0b4 : HardwiredUserDataDescriptor
    {
      internal TYPE_ff0a89bdceea4c34b91be071cbc4b0b4()
        : base(typeof (ContainerCreature))
      {
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_362d5bd14d7642a2a8cb327a74fced1a()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_7b9567820d724e118fc2c9f923c12a38()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_a9aeaf6c6ad74d10b6b7bfed22bf86b5()
        }));
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_79f1ab4cb7f1427283775b5efb06bba2()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_0f4aaebd377149c2bc7acbe22a9fe757()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_e6d63d36f5984effaeae505abdedf093()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_c632f4848e3149a18dbb84566e6a6b97()
        }));
        this.AddMember("get_healthAndTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_healthAndTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_ec4d50ce37da4ee5b7a046194a6b57dc()
        }));
        this.AddMember("get_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_bf0cb26df5cc4a989c972f229f6b1ed6()
        }));
        this.AddMember("set_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_b6765f53974e44ca9b8d40bd07a8ca5f()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_c9c9a763cdb04b20a178e63e8a3f4714()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_dbbc749f34cc4130ad75110759bf64ba()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_c22086b98baa4c0e9114846c9c7d6338()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_5e07a6a75037452798523ab7df0c6220()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_c7866b12b22448dda5ed8416ff42337b()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_c77be133905845b381558cdae05927a6()
        }));
        this.AddMember("get_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_4f1bdeecdb594de2a0fb4d7d2757bfb2()
        }));
        this.AddMember("set_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_cc90dd4fc2454b329968983373edf70b()
        }));
        this.AddMember("get_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_97789cb0f6494d60843cab4850ab4049()
        }));
        this.AddMember("set_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_b40661eda43648b4b090566ebc0d400c()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_2076a717a09c48a79e5653cbda21f776()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_f9a67f1ae9fd47ecb67c9b197546bb99()
        }));
        this.AddMember("get_inTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_ca50c360dfc84b2a9846ed98d570c2d7()
        }));
        this.AddMember("get_isMoving", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMoving", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_296d85a4d00347c8a07d4751cd8140ba()
        }));
        this.AddMember("get_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_4d876a9e6e1e4360863512cb72ce4274()
        }));
        this.AddMember("set_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_2f88521ff96f40a4a446daccc499addf()
        }));
        this.AddMember("get_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_6d3fa8790581421eb3954724bc719485()
        }));
        this.AddMember("set_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_6e93bb7e4412434c80d65d37ae75b6b8()
        }));
        this.AddMember("get_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_8860ca2f8d10435fbbfadfb8739e72df()
        }));
        this.AddMember("set_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_d7978bc78dff4222b0d9cb3702f9b39d()
        }));
        this.AddMember("get_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_8a737cc4fda94a23bb53c728544f308e()
        }));
        this.AddMember("set_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_e21e9d155491447a846ac7ee8f8ea12b()
        }));
        this.AddMember("get_inWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_6fb86a6fc9314193be9ed24a1c7256f8()
        }));
        this.AddMember("get_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_0091443439534d1ba126b0c6745abfaa()
        }));
        this.AddMember("set_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_7eebcdf4d06e459ca0767e2dfc41be4f()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_6b0f8bdb3b164b4f980e97e73e911caa()
        }));
        this.AddMember("set_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_01e3d92b5c354e5e817e349284e37bec()
        }));
        this.AddMember("get_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_2a71884997e34935a34e9aadf5233b8e()
        }));
        this.AddMember("set_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_137c8874324d4becb75580a603d3f3e9()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_612fe339135c4378aea615972ae80bb5()
        }));
        this.AddMember("get_isRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_b73402b3f8c54478b5f6b09020abadb1()
        }));
        this.AddMember("get_isMounted", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMounted", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_1278af10de6c49f3bea95f0fe5cd3254()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_3820703b27304fb1a245fe2e2d9bd60e()
        }));
        this.AddMember("get_isPawn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPawn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_a91699a04b8f4302a2ecdf7c4f71e0dc()
        }));
        this.AddMember("get_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_4d256f0bd0674edab1bb7d98aa343d7b()
        }));
        this.AddMember("set_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_0cf69fb29403499888912de725539c02()
        }));
        this.AddMember("get_isMountable", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMountable", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_fe7aa4cfaea741369bb545ae04827d5b()
        }));
        this.AddMember("get_canMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_canMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_3368928bfd9141399fd501db7853b4c3()
        }));
        this.AddMember("get_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_d48aa3d962864341b755dcc70442e7fe()
        }));
        this.AddMember("set_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_6ae222988b7d4c2eac7e9447ef68f325()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_de626be45f854d43b2e2f98d4ce1aaa1()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_bdf91ea69b804985b249b1c1e46f5b05()
        }));
        this.AddMember("getRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_e110ef157f73434da98726218722d4a9()
        }));
        this.AddMember("getMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_46ae47bda22d45b0a5380925dc28cf84()
        }));
        this.AddMember("getTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_24ccdde30b0d447da97fcb5b0d9a374f()
        }));
        this.AddMember("LongJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LongJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_d6366fa59f36406688b86117263c2e88()
        }));
        this.AddMember("HighJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("HighJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_35e311508b544c7d957192ee50851fd6()
        }));
        this.AddMember("Walk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Walk", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_ba0ec48be8074f4e9dae379cb0789d54()
        }));
        this.AddMember("setDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_6f4e88a8272d477bb8e94984dda01d16()
        }));
        this.AddMember("getDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_1ce4dd16eddb44fe87dd702c984717c3()
        }));
        this.AddMember("getFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_bffcee5662734308a3ff377edbb5a09d()
        }));
        this.AddMember("getActivateableFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_f29bb2201f004a9ea9b1c960bf39f5b2()
        }));
        this.AddMember("getActivateableFamiliarBookID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarBookID", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_dbfde48e70464d6ea7305c8f3572d73b()
        }));
        this.AddMember("increaseFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("increaseFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_30dedc151efa4b719f2d2a3c05ee1347()
        }));
        this.AddMember("inside", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("inside", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_4329c84e4ba248639b3e14f2e33de10d(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_474715fbb5c641828b7c46f6f5334c72()
        }));
        this.AddMember("overlap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("overlap", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_ba0a64e38ec54f368e7e1a348600a0d8(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_d781fbc343f04a24bb5864b6c0755672()
        }));
        this.AddMember("die", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("die", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_491c84e8f82e47acb49fc87cc5f66f2d()
        }));
        this.AddMember("addSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_f9635c4d2efd4c62b2d1170ef38c3665()
        }));
        this.AddMember("removeSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("removeSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_97180342f9ab41c2bfa307aa9a07af3a(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_fb4d588accb94596ad0bd2a65eb96cf8()
        }));
        this.AddMember("getSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpells", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_ef660647544c467c86d60d26e00f602f()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_f9d406508e284f759d893a401e6add29()
        }));
        this.AddMember("getSpellCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_0f4a7eb343dd4c109aa36ec5772c9b0f()
        }));
        this.AddMember("castedCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_9f22d76cd2e040ed8f824b999311f5a4()
        }));
        this.AddMember("castedCountThisTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCountThisTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_f7f5a93f80d54e9a9f2ee1b2335e8a9d()
        }));
        this.AddMember("castedDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_5c170db329c14ccabc580f381f0660e1()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_57866c7aabbd4c1289a7ca40bc9f447e()
        }));
        this.AddMember("castSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_521baa088e9242629ca9455c7b8dfa0d()
        }));
        this.AddMember("angleToFire", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("angleToFire", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_28537cade8f947a7864bee6e35f09753()
        }));
        this.AddMember("powerToFire", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("powerToFire", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_69ee3bb7a1a34d259ac97a04749c5e20()
        }));
        this.AddMember("fireAt", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fireAt", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_faa61448cdc8430780d876d45b26984f(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_142a0977edc44d97bdd15927e69afe89()
        }));
        this.AddMember("getEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getEffectors", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_4d98af590d394ba98135c5aa9fe4f863(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_34b361db81d7497c9d320d019a6bd457()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_02e2ca4bee2f49539afa3b4669404724()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_46372fb94a7b4684aa930683bd7eb5f6()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_aed91c96b18f42bb87a0b6a1dc0048bd()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_4d4f7c1728004308845e1f44115b76d6()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_a9d7af5c6c9b4495bc10b21c7e00e79b()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.MTHD_dbb3becaf8224be0901631c863639e6b()
        }));
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.PROP_5ae5cfa8f2bd466a8c73b42f0be4e3c4());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.PROP_092fb6c258c145a5b43ece9ee9d047e5());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.PROP_fd8d663054ea4eb1a19e7c82b3b5f233());
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.PROP_4007ceda94ad47cab5c88232409a9bd8());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.PROP_25845ccf61684e06a708dd4a52cda56e());
        this.AddMember("healthAndTower", (IMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.PROP_50aecf824adb41eb92ae9678d8be2c57());
        this.AddMember("shield", (IMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.PROP_76dfd9064cb2496e9d13a921ccce266f());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.PROP_5a3d0fc9d3e14948b7dc9c18a461f63b());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.PROP_6ed3c289834c4d25a81ff0beece2f228());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.PROP_4cbede5196be472187f81e25ad21e94d());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.PROP_39e9ae2294d446c882e5f7e17e4199e5());
        this.AddMember("weight", (IMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.PROP_6d58c76658f24c639beed550d795dafa());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.PROP_13c6b159ed1b4598b6dc62af08670bbf());
        this.AddMember("inTower", (IMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.PROP_374852e6f890461b9849e451a1db2747());
        this.AddMember("isMoving", (IMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.PROP_f39f1c9a436343c9a3e98e5cb37b68d7());
        this.AddMember("stunned", (IMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.PROP_73bded6e062b440899425f80753fb876());
        this.AddMember("superStunned", (IMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.PROP_b19239cde3154343ba3122867d699f2b());
        this.AddMember("waterWalking", (IMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.PROP_d3412ea2d040419597f5e10658ff8ad9());
        this.AddMember("frostWalking", (IMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.PROP_7d19cd5329b542598f92816656f354a2());
        this.AddMember("inWater", (IMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.PROP_dc11296422b24a0ba72defc7da18562d());
        this.AddMember("diesInWater", (IMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.PROP_25f858bd9b3347419db5e30ad2f3a86f());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.PROP_a69a58aa13954d42a97bb693aa7ee47f());
        this.AddMember("race", (IMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.PROP_d612a286d03043e6a692a662f67de503());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.PROP_c59b4cc9af254758a1704ccd5b80b819());
        this.AddMember("isRider", (IMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.PROP_51fb70b989e241128f281c33d3939e57());
        this.AddMember("isMounted", (IMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.PROP_3dd689f6f43744fa9256cef5f31e94c6());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.PROP_bc348724d3c74d4d802ac6b6d8160b33());
        this.AddMember("isPawn", (IMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.PROP_df4da3278b004b2ea842691342c600ed());
        this.AddMember("isFlying", (IMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.PROP_e7e8cfeaf8954020910613237beb6c3e());
        this.AddMember("isMountable", (IMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.PROP_51f92cee819d474da13910ce01f3036d());
        this.AddMember("canMount", (IMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.PROP_f9c949f978a843f9965fc2a66238deb1());
        this.AddMember("arcaneMonster", (IMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.PROP_03fa1ee2d85b4542893a04fb6a481f0b());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_ff0a89bdceea4c34b91be071cbc4b0b4.PROP_6461e4860033409cabe38667a7a1a799());
      }

      private sealed class MTHD_362d5bd14d7642a2a8cb327a74fced1a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_362d5bd14d7642a2a8cb327a74fced1a()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class MTHD_7b9567820d724e118fc2c9f923c12a38 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7b9567820d724e118fc2c9f923c12a38()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class MTHD_a9aeaf6c6ad74d10b6b7bfed22bf86b5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a9aeaf6c6ad74d10b6b7bfed22bf86b5()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class MTHD_79f1ab4cb7f1427283775b5efb06bba2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_79f1ab4cb7f1427283775b5efb06bba2()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).health;
        }
      }

      private sealed class MTHD_0f4aaebd377149c2bc7acbe22a9fe757 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0f4aaebd377149c2bc7acbe22a9fe757()
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

      private sealed class MTHD_e6d63d36f5984effaeae505abdedf093 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e6d63d36f5984effaeae505abdedf093()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).maxHealth;
        }
      }

      private sealed class MTHD_c632f4848e3149a18dbb84566e6a6b97 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c632f4848e3149a18dbb84566e6a6b97()
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

      private sealed class MTHD_ec4d50ce37da4ee5b7a046194a6b57dc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ec4d50ce37da4ee5b7a046194a6b57dc()
        {
          this.Initialize("get_healthAndTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class MTHD_bf0cb26df5cc4a989c972f229f6b1ed6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bf0cb26df5cc4a989c972f229f6b1ed6()
        {
          this.Initialize("get_shield", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).shield;
        }
      }

      private sealed class MTHD_b6765f53974e44ca9b8d40bd07a8ca5f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b6765f53974e44ca9b8d40bd07a8ca5f()
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

      private sealed class MTHD_c9c9a763cdb04b20a178e63e8a3f4714 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c9c9a763cdb04b20a178e63e8a3f4714()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).x;
        }
      }

      private sealed class MTHD_dbbc749f34cc4130ad75110759bf64ba : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dbbc749f34cc4130ad75110759bf64ba()
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

      private sealed class MTHD_c22086b98baa4c0e9114846c9c7d6338 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c22086b98baa4c0e9114846c9c7d6338()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).y;
        }
      }

      private sealed class MTHD_5e07a6a75037452798523ab7df0c6220 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5e07a6a75037452798523ab7df0c6220()
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

      private sealed class MTHD_c7866b12b22448dda5ed8416ff42337b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c7866b12b22448dda5ed8416ff42337b()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).position;
        }
      }

      private sealed class MTHD_c77be133905845b381558cdae05927a6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c77be133905845b381558cdae05927a6()
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

      private sealed class MTHD_4f1bdeecdb594de2a0fb4d7d2757bfb2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4f1bdeecdb594de2a0fb4d7d2757bfb2()
        {
          this.Initialize("get_parent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).parent;
        }
      }

      private sealed class MTHD_cc90dd4fc2454b329968983373edf70b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cc90dd4fc2454b329968983373edf70b()
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

      private sealed class MTHD_97789cb0f6494d60843cab4850ab4049 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_97789cb0f6494d60843cab4850ab4049()
        {
          this.Initialize("get_weight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).weight;
        }
      }

      private sealed class MTHD_b40661eda43648b4b090566ebc0d400c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b40661eda43648b4b090566ebc0d400c()
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

      private sealed class MTHD_2076a717a09c48a79e5653cbda21f776 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2076a717a09c48a79e5653cbda21f776()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).radius;
        }
      }

      private sealed class MTHD_f9a67f1ae9fd47ecb67c9b197546bb99 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f9a67f1ae9fd47ecb67c9b197546bb99()
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

      private sealed class MTHD_ca50c360dfc84b2a9846ed98d570c2d7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ca50c360dfc84b2a9846ed98d570c2d7()
        {
          this.Initialize("get_inTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class MTHD_296d85a4d00347c8a07d4751cd8140ba : HardwiredMethodMemberDescriptor
      {
        internal MTHD_296d85a4d00347c8a07d4751cd8140ba()
        {
          this.Initialize("get_isMoving", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class MTHD_4d876a9e6e1e4360863512cb72ce4274 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4d876a9e6e1e4360863512cb72ce4274()
        {
          this.Initialize("get_stunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).stunned;
        }
      }

      private sealed class MTHD_2f88521ff96f40a4a446daccc499addf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2f88521ff96f40a4a446daccc499addf()
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

      private sealed class MTHD_6d3fa8790581421eb3954724bc719485 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6d3fa8790581421eb3954724bc719485()
        {
          this.Initialize("get_superStunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).superStunned;
        }
      }

      private sealed class MTHD_6e93bb7e4412434c80d65d37ae75b6b8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6e93bb7e4412434c80d65d37ae75b6b8()
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

      private sealed class MTHD_8860ca2f8d10435fbbfadfb8739e72df : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8860ca2f8d10435fbbfadfb8739e72df()
        {
          this.Initialize("get_waterWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).waterWalking;
        }
      }

      private sealed class MTHD_d7978bc78dff4222b0d9cb3702f9b39d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d7978bc78dff4222b0d9cb3702f9b39d()
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

      private sealed class MTHD_8a737cc4fda94a23bb53c728544f308e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8a737cc4fda94a23bb53c728544f308e()
        {
          this.Initialize("get_frostWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).frostWalking;
        }
      }

      private sealed class MTHD_e21e9d155491447a846ac7ee8f8ea12b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e21e9d155491447a846ac7ee8f8ea12b()
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

      private sealed class MTHD_6fb86a6fc9314193be9ed24a1c7256f8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6fb86a6fc9314193be9ed24a1c7256f8()
        {
          this.Initialize("get_inWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class MTHD_0091443439534d1ba126b0c6745abfaa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0091443439534d1ba126b0c6745abfaa()
        {
          this.Initialize("get_diesInWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).diesInWater;
        }
      }

      private sealed class MTHD_7eebcdf4d06e459ca0767e2dfc41be4f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7eebcdf4d06e459ca0767e2dfc41be4f()
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

      private sealed class MTHD_6b0f8bdb3b164b4f980e97e73e911caa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6b0f8bdb3b164b4f980e97e73e911caa()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).type;
        }
      }

      private sealed class MTHD_01e3d92b5c354e5e817e349284e37bec : HardwiredMethodMemberDescriptor
      {
        internal MTHD_01e3d92b5c354e5e817e349284e37bec()
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

      private sealed class MTHD_2a71884997e34935a34e9aadf5233b8e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2a71884997e34935a34e9aadf5233b8e()
        {
          this.Initialize("get_race", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).race;
        }
      }

      private sealed class MTHD_137c8874324d4becb75580a603d3f3e9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_137c8874324d4becb75580a603d3f3e9()
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

      private sealed class MTHD_612fe339135c4378aea615972ae80bb5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_612fe339135c4378aea615972ae80bb5()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class MTHD_b73402b3f8c54478b5f6b09020abadb1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b73402b3f8c54478b5f6b09020abadb1()
        {
          this.Initialize("get_isRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class MTHD_1278af10de6c49f3bea95f0fe5cd3254 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1278af10de6c49f3bea95f0fe5cd3254()
        {
          this.Initialize("get_isMounted", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class MTHD_3820703b27304fb1a245fe2e2d9bd60e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3820703b27304fb1a245fe2e2d9bd60e()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class MTHD_a91699a04b8f4302a2ecdf7c4f71e0dc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a91699a04b8f4302a2ecdf7c4f71e0dc()
        {
          this.Initialize("get_isPawn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class MTHD_4d256f0bd0674edab1bb7d98aa343d7b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4d256f0bd0674edab1bb7d98aa343d7b()
        {
          this.Initialize("get_isFlying", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isFlying;
        }
      }

      private sealed class MTHD_0cf69fb29403499888912de725539c02 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0cf69fb29403499888912de725539c02()
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

      private sealed class MTHD_fe7aa4cfaea741369bb545ae04827d5b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fe7aa4cfaea741369bb545ae04827d5b()
        {
          this.Initialize("get_isMountable", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class MTHD_3368928bfd9141399fd501db7853b4c3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3368928bfd9141399fd501db7853b4c3()
        {
          this.Initialize("get_canMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class MTHD_d48aa3d962864341b755dcc70442e7fe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d48aa3d962864341b755dcc70442e7fe()
        {
          this.Initialize("get_arcaneMonster", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).arcaneMonster;
        }
      }

      private sealed class MTHD_6ae222988b7d4c2eac7e9447ef68f325 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6ae222988b7d4c2eac7e9447ef68f325()
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

      private sealed class MTHD_de626be45f854d43b2e2f98d4ce1aaa1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_de626be45f854d43b2e2f98d4ce1aaa1()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).takeDamage;
        }
      }

      private sealed class MTHD_bdf91ea69b804985b249b1c1e46f5b05 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bdf91ea69b804985b249b1c1e46f5b05()
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

      private sealed class MTHD_e110ef157f73434da98726218722d4a9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e110ef157f73434da98726218722d4a9()
        {
          this.Initialize("getRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getRider();
        }
      }

      private sealed class MTHD_46ae47bda22d45b0a5380925dc28cf84 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_46ae47bda22d45b0a5380925dc28cf84()
        {
          this.Initialize("getMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMount();
        }
      }

      private sealed class MTHD_24ccdde30b0d447da97fcb5b0d9a374f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_24ccdde30b0d447da97fcb5b0d9a374f()
        {
          this.Initialize("getTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getTower();
        }
      }

      private sealed class MTHD_d6366fa59f36406688b86117263c2e88 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d6366fa59f36406688b86117263c2e88()
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

      private sealed class MTHD_35e311508b544c7d957192ee50851fd6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_35e311508b544c7d957192ee50851fd6()
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

      private sealed class MTHD_ba0ec48be8074f4e9dae379cb0789d54 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ba0ec48be8074f4e9dae379cb0789d54()
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

      private sealed class MTHD_6f4e88a8272d477bb8e94984dda01d16 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6f4e88a8272d477bb8e94984dda01d16()
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

      private sealed class MTHD_1ce4dd16eddb44fe87dd702c984717c3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1ce4dd16eddb44fe87dd702c984717c3()
        {
          this.Initialize("getDirection", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getDirection();
        }
      }

      private sealed class MTHD_bffcee5662734308a3ff377edbb5a09d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bffcee5662734308a3ff377edbb5a09d()
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

      private sealed class MTHD_f29bb2201f004a9ea9b1c960bf39f5b2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f29bb2201f004a9ea9b1c960bf39f5b2()
        {
          this.Initialize("getActivateableFamiliarLevel", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarLevel();
        }
      }

      private sealed class MTHD_dbfde48e70464d6ea7305c8f3572d73b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dbfde48e70464d6ea7305c8f3572d73b()
        {
          this.Initialize("getActivateableFamiliarBookID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarBookID();
        }
      }

      private sealed class MTHD_30dedc151efa4b719f2d2a3c05ee1347 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_30dedc151efa4b719f2d2a3c05ee1347()
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

      private sealed class MTHD_4329c84e4ba248639b3e14f2e33de10d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4329c84e4ba248639b3e14f2e33de10d()
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

      private sealed class MTHD_474715fbb5c641828b7c46f6f5334c72 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_474715fbb5c641828b7c46f6f5334c72()
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

      private sealed class MTHD_ba0a64e38ec54f368e7e1a348600a0d8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ba0a64e38ec54f368e7e1a348600a0d8()
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

      private sealed class MTHD_d781fbc343f04a24bb5864b6c0755672 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d781fbc343f04a24bb5864b6c0755672()
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

      private sealed class MTHD_491c84e8f82e47acb49fc87cc5f66f2d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_491c84e8f82e47acb49fc87cc5f66f2d()
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

      private sealed class MTHD_f9635c4d2efd4c62b2d1170ef38c3665 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f9635c4d2efd4c62b2d1170ef38c3665()
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

      private sealed class MTHD_97180342f9ab41c2bfa307aa9a07af3a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_97180342f9ab41c2bfa307aa9a07af3a()
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

      private sealed class MTHD_fb4d588accb94596ad0bd2a65eb96cf8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fb4d588accb94596ad0bd2a65eb96cf8()
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

      private sealed class MTHD_ef660647544c467c86d60d26e00f602f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ef660647544c467c86d60d26e00f602f()
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

      private sealed class MTHD_f9d406508e284f759d893a401e6add29 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f9d406508e284f759d893a401e6add29()
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

      private sealed class MTHD_0f4a7eb343dd4c109aa36ec5772c9b0f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0f4a7eb343dd4c109aa36ec5772c9b0f()
        {
          this.Initialize("getSpellCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getSpellCount();
        }
      }

      private sealed class MTHD_9f22d76cd2e040ed8f824b999311f5a4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9f22d76cd2e040ed8f824b999311f5a4()
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

      private sealed class MTHD_f7f5a93f80d54e9a9f2ee1b2335e8a9d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f7f5a93f80d54e9a9f2ee1b2335e8a9d()
        {
          this.Initialize("castedCountThisTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).castedCountThisTurn();
        }
      }

      private sealed class MTHD_5c170db329c14ccabc580f381f0660e1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5c170db329c14ccabc580f381f0660e1()
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

      private sealed class MTHD_57866c7aabbd4c1289a7ca40bc9f447e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_57866c7aabbd4c1289a7ca40bc9f447e()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMinionCount();
        }
      }

      private sealed class MTHD_521baa088e9242629ca9455c7b8dfa0d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_521baa088e9242629ca9455c7b8dfa0d()
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

      private sealed class MTHD_28537cade8f947a7864bee6e35f09753 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_28537cade8f947a7864bee6e35f09753()
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

      private sealed class MTHD_69ee3bb7a1a34d259ac97a04749c5e20 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_69ee3bb7a1a34d259ac97a04749c5e20()
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

      private sealed class MTHD_faa61448cdc8430780d876d45b26984f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_faa61448cdc8430780d876d45b26984f()
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

      private sealed class MTHD_142a0977edc44d97bdd15927e69afe89 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_142a0977edc44d97bdd15927e69afe89()
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

      private sealed class MTHD_4d98af590d394ba98135c5aa9fe4f863 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4d98af590d394ba98135c5aa9fe4f863()
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

      private sealed class MTHD_34b361db81d7497c9d320d019a6bd457 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_34b361db81d7497c9d320d019a6bd457()
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

      private sealed class MTHD_02e2ca4bee2f49539afa3b4669404724 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_02e2ca4bee2f49539afa3b4669404724()
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

      private sealed class MTHD_46372fb94a7b4684aa930683bd7eb5f6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_46372fb94a7b4684aa930683bd7eb5f6()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).GetHashCode();
        }
      }

      private sealed class MTHD_aed91c96b18f42bb87a0b6a1dc0048bd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aed91c96b18f42bb87a0b6a1dc0048bd()
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

      private sealed class MTHD_4d4f7c1728004308845e1f44115b76d6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4d4f7c1728004308845e1f44115b76d6()
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

      private sealed class MTHD_a9d7af5c6c9b4495bc10b21c7e00e79b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a9d7af5c6c9b4495bc10b21c7e00e79b()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_dbb3becaf8224be0901631c863639e6b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dbb3becaf8224be0901631c863639e6b()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_5ae5cfa8f2bd466a8c73b42f0be4e3c4 : HardwiredMemberDescriptor
      {
        internal PROP_5ae5cfa8f2bd466a8c73b42f0be4e3c4()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class PROP_092fb6c258c145a5b43ece9ee9d047e5 : HardwiredMemberDescriptor
      {
        internal PROP_092fb6c258c145a5b43ece9ee9d047e5()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class PROP_fd8d663054ea4eb1a19e7c82b3b5f233 : HardwiredMemberDescriptor
      {
        internal PROP_fd8d663054ea4eb1a19e7c82b3b5f233()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class PROP_4007ceda94ad47cab5c88232409a9bd8 : HardwiredMemberDescriptor
      {
        internal PROP_4007ceda94ad47cab5c88232409a9bd8()
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

      private sealed class PROP_25845ccf61684e06a708dd4a52cda56e : HardwiredMemberDescriptor
      {
        internal PROP_25845ccf61684e06a708dd4a52cda56e()
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

      private sealed class PROP_50aecf824adb41eb92ae9678d8be2c57 : HardwiredMemberDescriptor
      {
        internal PROP_50aecf824adb41eb92ae9678d8be2c57()
          : base(typeof (int), "healthAndTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class PROP_76dfd9064cb2496e9d13a921ccce266f : HardwiredMemberDescriptor
      {
        internal PROP_76dfd9064cb2496e9d13a921ccce266f()
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

      private sealed class PROP_5a3d0fc9d3e14948b7dc9c18a461f63b : HardwiredMemberDescriptor
      {
        internal PROP_5a3d0fc9d3e14948b7dc9c18a461f63b()
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

      private sealed class PROP_6ed3c289834c4d25a81ff0beece2f228 : HardwiredMemberDescriptor
      {
        internal PROP_6ed3c289834c4d25a81ff0beece2f228()
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

      private sealed class PROP_4cbede5196be472187f81e25ad21e94d : HardwiredMemberDescriptor
      {
        internal PROP_4cbede5196be472187f81e25ad21e94d()
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

      private sealed class PROP_39e9ae2294d446c882e5f7e17e4199e5 : HardwiredMemberDescriptor
      {
        internal PROP_39e9ae2294d446c882e5f7e17e4199e5()
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

      private sealed class PROP_6d58c76658f24c639beed550d795dafa : HardwiredMemberDescriptor
      {
        internal PROP_6d58c76658f24c639beed550d795dafa()
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

      private sealed class PROP_13c6b159ed1b4598b6dc62af08670bbf : HardwiredMemberDescriptor
      {
        internal PROP_13c6b159ed1b4598b6dc62af08670bbf()
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

      private sealed class PROP_374852e6f890461b9849e451a1db2747 : HardwiredMemberDescriptor
      {
        internal PROP_374852e6f890461b9849e451a1db2747()
          : base(typeof (bool), "inTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class PROP_f39f1c9a436343c9a3e98e5cb37b68d7 : HardwiredMemberDescriptor
      {
        internal PROP_f39f1c9a436343c9a3e98e5cb37b68d7()
          : base(typeof (bool), "isMoving", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class PROP_73bded6e062b440899425f80753fb876 : HardwiredMemberDescriptor
      {
        internal PROP_73bded6e062b440899425f80753fb876()
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

      private sealed class PROP_b19239cde3154343ba3122867d699f2b : HardwiredMemberDescriptor
      {
        internal PROP_b19239cde3154343ba3122867d699f2b()
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

      private sealed class PROP_d3412ea2d040419597f5e10658ff8ad9 : HardwiredMemberDescriptor
      {
        internal PROP_d3412ea2d040419597f5e10658ff8ad9()
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

      private sealed class PROP_7d19cd5329b542598f92816656f354a2 : HardwiredMemberDescriptor
      {
        internal PROP_7d19cd5329b542598f92816656f354a2()
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

      private sealed class PROP_dc11296422b24a0ba72defc7da18562d : HardwiredMemberDescriptor
      {
        internal PROP_dc11296422b24a0ba72defc7da18562d()
          : base(typeof (bool), "inWater", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class PROP_25f858bd9b3347419db5e30ad2f3a86f : HardwiredMemberDescriptor
      {
        internal PROP_25f858bd9b3347419db5e30ad2f3a86f()
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

      private sealed class PROP_a69a58aa13954d42a97bb693aa7ee47f : HardwiredMemberDescriptor
      {
        internal PROP_a69a58aa13954d42a97bb693aa7ee47f()
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

      private sealed class PROP_d612a286d03043e6a692a662f67de503 : HardwiredMemberDescriptor
      {
        internal PROP_d612a286d03043e6a692a662f67de503()
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

      private sealed class PROP_c59b4cc9af254758a1704ccd5b80b819 : HardwiredMemberDescriptor
      {
        internal PROP_c59b4cc9af254758a1704ccd5b80b819()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class PROP_51fb70b989e241128f281c33d3939e57 : HardwiredMemberDescriptor
      {
        internal PROP_51fb70b989e241128f281c33d3939e57()
          : base(typeof (bool), "isRider", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class PROP_3dd689f6f43744fa9256cef5f31e94c6 : HardwiredMemberDescriptor
      {
        internal PROP_3dd689f6f43744fa9256cef5f31e94c6()
          : base(typeof (bool), "isMounted", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class PROP_bc348724d3c74d4d802ac6b6d8160b33 : HardwiredMemberDescriptor
      {
        internal PROP_bc348724d3c74d4d802ac6b6d8160b33()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class PROP_df4da3278b004b2ea842691342c600ed : HardwiredMemberDescriptor
      {
        internal PROP_df4da3278b004b2ea842691342c600ed()
          : base(typeof (bool), "isPawn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class PROP_e7e8cfeaf8954020910613237beb6c3e : HardwiredMemberDescriptor
      {
        internal PROP_e7e8cfeaf8954020910613237beb6c3e()
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

      private sealed class PROP_51f92cee819d474da13910ce01f3036d : HardwiredMemberDescriptor
      {
        internal PROP_51f92cee819d474da13910ce01f3036d()
          : base(typeof (bool), "isMountable", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class PROP_f9c949f978a843f9965fc2a66238deb1 : HardwiredMemberDescriptor
      {
        internal PROP_f9c949f978a843f9965fc2a66238deb1()
          : base(typeof (bool), "canMount", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class PROP_03fa1ee2d85b4542893a04fb6a481f0b : HardwiredMemberDescriptor
      {
        internal PROP_03fa1ee2d85b4542893a04fb6a481f0b()
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

      private sealed class PROP_6461e4860033409cabe38667a7a1a799 : HardwiredMemberDescriptor
      {
        internal PROP_6461e4860033409cabe38667a7a1a799()
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

    private sealed class TYPE_822d4fff440347d49059eae4fd29374d : HardwiredUserDataDescriptor
    {
      internal TYPE_822d4fff440347d49059eae4fd29374d()
        : base(typeof (ContainerEffector))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_822d4fff440347d49059eae4fd29374d.MTHD_90a4de2115664a088e9dfee50374cc1d()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_822d4fff440347d49059eae4fd29374d.MTHD_4d4f902277cb4d9793a96409df63ab72()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_822d4fff440347d49059eae4fd29374d.MTHD_e20fed0064674be5b5beb17e88c767f4()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_822d4fff440347d49059eae4fd29374d.MTHD_29815228091d499bbe53dce1ed4cff09()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_822d4fff440347d49059eae4fd29374d.MTHD_4eef33f8b7f24e608680effe4a9b5b4d()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_822d4fff440347d49059eae4fd29374d.MTHD_00910f754d1c4e68b8ba7285798e3f30()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_822d4fff440347d49059eae4fd29374d.MTHD_b6970474021a4f56942253c2c12185bf()
        }));
        this.AddMember("get_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_822d4fff440347d49059eae4fd29374d.MTHD_be4dfd7c794c43f6a682488a336b25fd()
        }));
        this.AddMember("set_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_822d4fff440347d49059eae4fd29374d.MTHD_ab1c8c6aa87941579ee45501081c3f88()
        }));
        this.AddMember("get_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_822d4fff440347d49059eae4fd29374d.MTHD_f2ba9988597d4de9a6afcff89c494288()
        }));
        this.AddMember("set_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_822d4fff440347d49059eae4fd29374d.MTHD_4b2044c972e24498a2a5ab57762be95b()
        }));
        this.AddMember("get_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_822d4fff440347d49059eae4fd29374d.MTHD_49df75c81808437c8d07d3ef38897c3b()
        }));
        this.AddMember("set_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_822d4fff440347d49059eae4fd29374d.MTHD_b1feead622674da4b800355e38cf473f()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_822d4fff440347d49059eae4fd29374d.MTHD_4e8d9175c156441a84c3fb8eca5db959()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_822d4fff440347d49059eae4fd29374d.MTHD_bf233750ae49430195e6e2016736c82d()
        }));
        this.AddMember("turnPassed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("turnPassed", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_822d4fff440347d49059eae4fd29374d.MTHD_790a395f72e345a0933c1f0d4f3f2d11()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_822d4fff440347d49059eae4fd29374d.MTHD_4d33dc98bb6b43e3b572adbff372216f()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_822d4fff440347d49059eae4fd29374d.MTHD_1e837c07a6ab4386b205e4640dc44f6c()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_822d4fff440347d49059eae4fd29374d.MTHD_bf02bc3b20504e35b5ca65011b1b489a()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_822d4fff440347d49059eae4fd29374d.MTHD_5f479a756c3f454fad027201612c8853()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_822d4fff440347d49059eae4fd29374d.PROP_83893991a06a438f8c54497110367b51());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_822d4fff440347d49059eae4fd29374d.PROP_9b40cfcf2eb64861857d3f07e667f7b9());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_822d4fff440347d49059eae4fd29374d.PROP_ed0865e3516142318b587a6219c457b4());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_822d4fff440347d49059eae4fd29374d.PROP_e0e9a87973f44b8eaf8adeb6c550a6cf());
        this.AddMember("turnsAlive", (IMemberDescriptor) new Bridge.TYPE_822d4fff440347d49059eae4fd29374d.PROP_e99a2ae702ad450baa71fd2fd99e887a());
        this.AddMember("maxTurnsAlive", (IMemberDescriptor) new Bridge.TYPE_822d4fff440347d49059eae4fd29374d.PROP_0581242a5b4f46ab8aa4eeb9c670e8e0());
        this.AddMember("active", (IMemberDescriptor) new Bridge.TYPE_822d4fff440347d49059eae4fd29374d.PROP_60278f591b0a41d7a05d28440aebd12e());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_822d4fff440347d49059eae4fd29374d.PROP_577f95309f4448a7ae58860c9e7c155f());
      }

      private sealed class MTHD_90a4de2115664a088e9dfee50374cc1d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_90a4de2115664a088e9dfee50374cc1d()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class MTHD_4d4f902277cb4d9793a96409df63ab72 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4d4f902277cb4d9793a96409df63ab72()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).x;
        }
      }

      private sealed class MTHD_e20fed0064674be5b5beb17e88c767f4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e20fed0064674be5b5beb17e88c767f4()
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

      private sealed class MTHD_29815228091d499bbe53dce1ed4cff09 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_29815228091d499bbe53dce1ed4cff09()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).y;
        }
      }

      private sealed class MTHD_4eef33f8b7f24e608680effe4a9b5b4d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4eef33f8b7f24e608680effe4a9b5b4d()
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

      private sealed class MTHD_00910f754d1c4e68b8ba7285798e3f30 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_00910f754d1c4e68b8ba7285798e3f30()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).position;
        }
      }

      private sealed class MTHD_b6970474021a4f56942253c2c12185bf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b6970474021a4f56942253c2c12185bf()
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

      private sealed class MTHD_be4dfd7c794c43f6a682488a336b25fd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_be4dfd7c794c43f6a682488a336b25fd()
        {
          this.Initialize("get_turnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).turnsAlive;
        }
      }

      private sealed class MTHD_ab1c8c6aa87941579ee45501081c3f88 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ab1c8c6aa87941579ee45501081c3f88()
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

      private sealed class MTHD_f2ba9988597d4de9a6afcff89c494288 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f2ba9988597d4de9a6afcff89c494288()
        {
          this.Initialize("get_maxTurnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).maxTurnsAlive;
        }
      }

      private sealed class MTHD_4b2044c972e24498a2a5ab57762be95b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4b2044c972e24498a2a5ab57762be95b()
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

      private sealed class MTHD_49df75c81808437c8d07d3ef38897c3b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_49df75c81808437c8d07d3ef38897c3b()
        {
          this.Initialize("get_active", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).active;
        }
      }

      private sealed class MTHD_b1feead622674da4b800355e38cf473f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b1feead622674da4b800355e38cf473f()
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

      private sealed class MTHD_4e8d9175c156441a84c3fb8eca5db959 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4e8d9175c156441a84c3fb8eca5db959()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }

      private sealed class MTHD_bf233750ae49430195e6e2016736c82d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bf233750ae49430195e6e2016736c82d()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_790a395f72e345a0933c1f0d4f3f2d11 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_790a395f72e345a0933c1f0d4f3f2d11()
        {
          this.Initialize("turnPassed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).turnPassed();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_4d33dc98bb6b43e3b572adbff372216f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4d33dc98bb6b43e3b572adbff372216f()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).GetHashCode();
        }
      }

      private sealed class MTHD_1e837c07a6ab4386b205e4640dc44f6c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1e837c07a6ab4386b205e4640dc44f6c()
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

      private sealed class MTHD_bf02bc3b20504e35b5ca65011b1b489a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bf02bc3b20504e35b5ca65011b1b489a()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_5f479a756c3f454fad027201612c8853 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5f479a756c3f454fad027201612c8853()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_83893991a06a438f8c54497110367b51 : HardwiredMemberDescriptor
      {
        internal PROP_83893991a06a438f8c54497110367b51()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class PROP_9b40cfcf2eb64861857d3f07e667f7b9 : HardwiredMemberDescriptor
      {
        internal PROP_9b40cfcf2eb64861857d3f07e667f7b9()
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

      private sealed class PROP_ed0865e3516142318b587a6219c457b4 : HardwiredMemberDescriptor
      {
        internal PROP_ed0865e3516142318b587a6219c457b4()
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

      private sealed class PROP_e0e9a87973f44b8eaf8adeb6c550a6cf : HardwiredMemberDescriptor
      {
        internal PROP_e0e9a87973f44b8eaf8adeb6c550a6cf()
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

      private sealed class PROP_e99a2ae702ad450baa71fd2fd99e887a : HardwiredMemberDescriptor
      {
        internal PROP_e99a2ae702ad450baa71fd2fd99e887a()
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

      private sealed class PROP_0581242a5b4f46ab8aa4eeb9c670e8e0 : HardwiredMemberDescriptor
      {
        internal PROP_0581242a5b4f46ab8aa4eeb9c670e8e0()
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

      private sealed class PROP_60278f591b0a41d7a05d28440aebd12e : HardwiredMemberDescriptor
      {
        internal PROP_60278f591b0a41d7a05d28440aebd12e()
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

      private sealed class PROP_577f95309f4448a7ae58860c9e7c155f : HardwiredMemberDescriptor
      {
        internal PROP_577f95309f4448a7ae58860c9e7c155f()
          : base(typeof (EffectorType), "type", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }
    }

    private sealed class TYPE_93162ae8d88a4cc2914793cbc35ba186 : HardwiredUserDataDescriptor
    {
      internal TYPE_93162ae8d88a4cc2914793cbc35ba186()
        : base(typeof (ContainerIndicator))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_93162ae8d88a4cc2914793cbc35ba186.MTHD_15da2245d14040689bf926c31f2a8cb3()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_93162ae8d88a4cc2914793cbc35ba186.MTHD_38afa77a04ea4047937fd04563e2ddff()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_93162ae8d88a4cc2914793cbc35ba186.MTHD_a34b07490f464b3b81c44db4af09cd2f()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_93162ae8d88a4cc2914793cbc35ba186.MTHD_8edb7077504f48e4aa144955cdd40f80()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_93162ae8d88a4cc2914793cbc35ba186.MTHD_259b736d9b514a43910dfa1c19b83237()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_93162ae8d88a4cc2914793cbc35ba186.MTHD_5dbfcbc13fbb48db952db130d4b968de()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_93162ae8d88a4cc2914793cbc35ba186.MTHD_445db77aa3c8454b9ba4f4dbd68fd910()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_93162ae8d88a4cc2914793cbc35ba186.MTHD_86de7bcfd6364602aeb4502ad287ec4e()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_93162ae8d88a4cc2914793cbc35ba186.MTHD_d048fc90d45342b7b021cba083b8bb65()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_93162ae8d88a4cc2914793cbc35ba186.MTHD_642c40d4cf9649989b92e5b93be56688()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_93162ae8d88a4cc2914793cbc35ba186.MTHD_157f353bcfed4bd085cc10543cec4ba9()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_93162ae8d88a4cc2914793cbc35ba186.MTHD_974f76d5b96f4dcbb15378ce92b14f05()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_93162ae8d88a4cc2914793cbc35ba186.MTHD_7c8308a53e4a4045802b67212ad33458()
        }));
        this.AddMember("get_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color2", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_93162ae8d88a4cc2914793cbc35ba186.MTHD_0acf25fc330c407884a6413693a07d5a()
        }));
        this.AddMember("set_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color2", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_93162ae8d88a4cc2914793cbc35ba186.MTHD_01d9dbbe12e44e0f9646d18b2ce26edf()
        }));
        this.AddMember("get_kind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_kind", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_93162ae8d88a4cc2914793cbc35ba186.MTHD_33f6513924d441858b4aa58d50c02d0c()
        }));
        this.AddMember("setIcon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setIcon", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_93162ae8d88a4cc2914793cbc35ba186.MTHD_0801895309674bf5aa18acba7ca52c12()
        }));
        this.AddMember("Destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Destroy", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_93162ae8d88a4cc2914793cbc35ba186.MTHD_3abadc4867154cb0861ca70f3929384c()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_93162ae8d88a4cc2914793cbc35ba186.MTHD_c75888cb997f4702981eb48c4e8d9747()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_93162ae8d88a4cc2914793cbc35ba186.MTHD_d5b25ef8067a41aab1ed8ae6f25ad332()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_93162ae8d88a4cc2914793cbc35ba186.MTHD_dc70a13c3e4849818f20b97feecc1c7d()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_93162ae8d88a4cc2914793cbc35ba186.MTHD_a38a0f1d52f0444290f8835575e539eb()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_93162ae8d88a4cc2914793cbc35ba186.PROP_ab62d593ec984d1fa82dd5c58c3f6d7d());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_93162ae8d88a4cc2914793cbc35ba186.PROP_4aa856c949224942838ee423388dd63e());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_93162ae8d88a4cc2914793cbc35ba186.PROP_7d9d6355c0774797bfc09832f51e2988());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_93162ae8d88a4cc2914793cbc35ba186.PROP_7b6c19a8661b499fade89a9e45c1960f());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_93162ae8d88a4cc2914793cbc35ba186.PROP_f9b1558c9dac486a85ebb1e5e185de89());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_93162ae8d88a4cc2914793cbc35ba186.PROP_9f6dccdd9dac489e86817ec6bc39057d());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_93162ae8d88a4cc2914793cbc35ba186.PROP_a6b8f3c74b1445cba7d7ada8b6fa3b8a());
        this.AddMember("color2", (IMemberDescriptor) new Bridge.TYPE_93162ae8d88a4cc2914793cbc35ba186.PROP_392c6f69a9864165ac205a0dbd839c4e());
        this.AddMember("kind", (IMemberDescriptor) new Bridge.TYPE_93162ae8d88a4cc2914793cbc35ba186.PROP_09b76506817a473abbe638317d1bcab3());
      }

      private sealed class MTHD_15da2245d14040689bf926c31f2a8cb3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_15da2245d14040689bf926c31f2a8cb3()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class MTHD_38afa77a04ea4047937fd04563e2ddff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_38afa77a04ea4047937fd04563e2ddff()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).x;
        }
      }

      private sealed class MTHD_a34b07490f464b3b81c44db4af09cd2f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a34b07490f464b3b81c44db4af09cd2f()
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

      private sealed class MTHD_8edb7077504f48e4aa144955cdd40f80 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8edb7077504f48e4aa144955cdd40f80()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).y;
        }
      }

      private sealed class MTHD_259b736d9b514a43910dfa1c19b83237 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_259b736d9b514a43910dfa1c19b83237()
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

      private sealed class MTHD_5dbfcbc13fbb48db952db130d4b968de : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5dbfcbc13fbb48db952db130d4b968de()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).radius;
        }
      }

      private sealed class MTHD_445db77aa3c8454b9ba4f4dbd68fd910 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_445db77aa3c8454b9ba4f4dbd68fd910()
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

      private sealed class MTHD_86de7bcfd6364602aeb4502ad287ec4e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_86de7bcfd6364602aeb4502ad287ec4e()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).position;
        }
      }

      private sealed class MTHD_d048fc90d45342b7b021cba083b8bb65 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d048fc90d45342b7b021cba083b8bb65()
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

      private sealed class MTHD_642c40d4cf9649989b92e5b93be56688 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_642c40d4cf9649989b92e5b93be56688()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).angle;
        }
      }

      private sealed class MTHD_157f353bcfed4bd085cc10543cec4ba9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_157f353bcfed4bd085cc10543cec4ba9()
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

      private sealed class MTHD_974f76d5b96f4dcbb15378ce92b14f05 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_974f76d5b96f4dcbb15378ce92b14f05()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color;
        }
      }

      private sealed class MTHD_7c8308a53e4a4045802b67212ad33458 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7c8308a53e4a4045802b67212ad33458()
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

      private sealed class MTHD_0acf25fc330c407884a6413693a07d5a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0acf25fc330c407884a6413693a07d5a()
        {
          this.Initialize("get_color2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color2;
        }
      }

      private sealed class MTHD_01d9dbbe12e44e0f9646d18b2ce26edf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_01d9dbbe12e44e0f9646d18b2ce26edf()
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

      private sealed class MTHD_33f6513924d441858b4aa58d50c02d0c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_33f6513924d441858b4aa58d50c02d0c()
        {
          this.Initialize("get_kind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }

      private sealed class MTHD_0801895309674bf5aa18acba7ca52c12 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0801895309674bf5aa18acba7ca52c12()
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

      private sealed class MTHD_3abadc4867154cb0861ca70f3929384c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3abadc4867154cb0861ca70f3929384c()
        {
          this.Initialize("Destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerIndicator) obj).Destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_c75888cb997f4702981eb48c4e8d9747 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c75888cb997f4702981eb48c4e8d9747()
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

      private sealed class MTHD_d5b25ef8067a41aab1ed8ae6f25ad332 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d5b25ef8067a41aab1ed8ae6f25ad332()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_dc70a13c3e4849818f20b97feecc1c7d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dc70a13c3e4849818f20b97feecc1c7d()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_a38a0f1d52f0444290f8835575e539eb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a38a0f1d52f0444290f8835575e539eb()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_ab62d593ec984d1fa82dd5c58c3f6d7d : HardwiredMemberDescriptor
      {
        internal PROP_ab62d593ec984d1fa82dd5c58c3f6d7d()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class PROP_4aa856c949224942838ee423388dd63e : HardwiredMemberDescriptor
      {
        internal PROP_4aa856c949224942838ee423388dd63e()
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

      private sealed class PROP_7d9d6355c0774797bfc09832f51e2988 : HardwiredMemberDescriptor
      {
        internal PROP_7d9d6355c0774797bfc09832f51e2988()
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

      private sealed class PROP_7b6c19a8661b499fade89a9e45c1960f : HardwiredMemberDescriptor
      {
        internal PROP_7b6c19a8661b499fade89a9e45c1960f()
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

      private sealed class PROP_f9b1558c9dac486a85ebb1e5e185de89 : HardwiredMemberDescriptor
      {
        internal PROP_f9b1558c9dac486a85ebb1e5e185de89()
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

      private sealed class PROP_9f6dccdd9dac489e86817ec6bc39057d : HardwiredMemberDescriptor
      {
        internal PROP_9f6dccdd9dac489e86817ec6bc39057d()
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

      private sealed class PROP_a6b8f3c74b1445cba7d7ada8b6fa3b8a : HardwiredMemberDescriptor
      {
        internal PROP_a6b8f3c74b1445cba7d7ada8b6fa3b8a()
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

      private sealed class PROP_392c6f69a9864165ac205a0dbd839c4e : HardwiredMemberDescriptor
      {
        internal PROP_392c6f69a9864165ac205a0dbd839c4e()
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

      private sealed class PROP_09b76506817a473abbe638317d1bcab3 : HardwiredMemberDescriptor
      {
        internal PROP_09b76506817a473abbe638317d1bcab3()
          : base(typeof (IndicatorKind), "kind", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }
    }

    private sealed class TYPE_352a0edd36e546ef8c673f5255eea609 : HardwiredUserDataDescriptor
    {
      internal TYPE_352a0edd36e546ef8c673f5255eea609()
        : base(typeof (ContainerSpell))
      {
        this.AddMember("get_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_352a0edd36e546ef8c673f5255eea609.MTHD_401f89a698104f5f8c083a788e0e31c5()
        }));
        this.AddMember("set_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_352a0edd36e546ef8c673f5255eea609.MTHD_e8fa4fa314c642af98fbcf99ec09c53e()
        }));
        this.AddMember("get_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_352a0edd36e546ef8c673f5255eea609.MTHD_9cebb7018c28460c938e1c02bf571156()
        }));
        this.AddMember("set_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_352a0edd36e546ef8c673f5255eea609.MTHD_997d215a6f8b4e33b1f5914bbd6baab3()
        }));
        this.AddMember("get_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_352a0edd36e546ef8c673f5255eea609.MTHD_0b207e266d184f3b84faac7f98cfe8a4()
        }));
        this.AddMember("set_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_352a0edd36e546ef8c673f5255eea609.MTHD_5db1e44982a74eb9af5ddf9dc5e33357()
        }));
        this.AddMember("get_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_352a0edd36e546ef8c673f5255eea609.MTHD_7faf50a17be041ef8960799f4d85ad69()
        }));
        this.AddMember("set_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_352a0edd36e546ef8c673f5255eea609.MTHD_5aae864f7453450f87882685ca660d53()
        }));
        this.AddMember("get_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_352a0edd36e546ef8c673f5255eea609.MTHD_4afde0fd3f3247758358e58327f77d39()
        }));
        this.AddMember("set_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_352a0edd36e546ef8c673f5255eea609.MTHD_20c450d0420b47fb882c08de779722e0()
        }));
        this.AddMember("get_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_352a0edd36e546ef8c673f5255eea609.MTHD_a4c287bac2d04c94b59acb3028cafc09()
        }));
        this.AddMember("set_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_352a0edd36e546ef8c673f5255eea609.MTHD_c1c34d1beedc40af971dd261a290abad()
        }));
        this.AddMember("get_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_352a0edd36e546ef8c673f5255eea609.MTHD_28116866a11b4628b12b3e09a34b077a()
        }));
        this.AddMember("set_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_352a0edd36e546ef8c673f5255eea609.MTHD_06eb981004a941018163c80924417f71()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_352a0edd36e546ef8c673f5255eea609.MTHD_042c084964e34659b8023eb60d12b3ed()
        }));
        this.AddMember("get_castType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_castType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_352a0edd36e546ef8c673f5255eea609.MTHD_e7876eaa008640a88f8413bca3560596()
        }));
        this.AddMember("get_damageType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damageType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_352a0edd36e546ef8c673f5255eea609.MTHD_3c8d643f7cb047e5be40d0761501eb49()
        }));
        this.AddMember("get_book", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_book", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_352a0edd36e546ef8c673f5255eea609.MTHD_45fa88030f554012b1dec170fcf70f5a()
        }));
        this.AddMember("get_damage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damage", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_352a0edd36e546ef8c673f5255eea609.MTHD_f0fc34c3456a4e1aac47d5c03a5dc1ef()
        }));
        this.AddMember("get_explosionRadius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_explosionRadius", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_352a0edd36e546ef8c673f5255eea609.MTHD_1227947f2381465d886c103abfee6011()
        }));
        this.AddMember("get_description", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_description", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_352a0edd36e546ef8c673f5255eea609.MTHD_519d759edf654de4bace3c167b56cfaa()
        }));
        this.AddMember("get_descriptionOnly", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionOnly", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_352a0edd36e546ef8c673f5255eea609.MTHD_5cbb3753e9684ee8a5c900d998fa64ea()
        }));
        this.AddMember("get_descriptionExtra", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionExtra", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_352a0edd36e546ef8c673f5255eea609.MTHD_49595ceeaa044c1bb8504224b62d9ee7()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_352a0edd36e546ef8c673f5255eea609.MTHD_644b43bcddda4ed4816dfb840fe538b0()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_352a0edd36e546ef8c673f5255eea609.MTHD_9b53036a204942bc81bb761b1e52994b()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_352a0edd36e546ef8c673f5255eea609.MTHD_026e2a24a2bc4315969253c3ef3274c8()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_352a0edd36e546ef8c673f5255eea609.MTHD_1c5febda4d734bb4bc94d34529772f39()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_352a0edd36e546ef8c673f5255eea609.MTHD_4fa2b01e9cf34cbd88f8f76dd8798c7a()
        }));
        this.AddMember("uses", (IMemberDescriptor) new Bridge.TYPE_352a0edd36e546ef8c673f5255eea609.PROP_baf3dd92342f4be9a26af297b2e986a1());
        this.AddMember("maxUses", (IMemberDescriptor) new Bridge.TYPE_352a0edd36e546ef8c673f5255eea609.PROP_d138a98f50ac43f6b08ea38a44797fc6());
        this.AddMember("rechargeTime", (IMemberDescriptor) new Bridge.TYPE_352a0edd36e546ef8c673f5255eea609.PROP_81d5b880db6642aab2e1752b0c9e9000());
        this.AddMember("lastTurnFired", (IMemberDescriptor) new Bridge.TYPE_352a0edd36e546ef8c673f5255eea609.PROP_6769881d4f364ae4a1d104f1f219476d());
        this.AddMember("isPresent", (IMemberDescriptor) new Bridge.TYPE_352a0edd36e546ef8c673f5255eea609.PROP_5dd95a05378c4c4a8fbecbea1c7a96de());
        this.AddMember("locked", (IMemberDescriptor) new Bridge.TYPE_352a0edd36e546ef8c673f5255eea609.PROP_2ec12c66fc454a04b5eae2f4ca48ff2b());
        this.AddMember("turnsTillFirstUse", (IMemberDescriptor) new Bridge.TYPE_352a0edd36e546ef8c673f5255eea609.PROP_d8eb2db8874c460a8706fe144a8bfe35());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_352a0edd36e546ef8c673f5255eea609.PROP_7afd2dcb7df34f14b5f648f40d7baceb());
        this.AddMember("castType", (IMemberDescriptor) new Bridge.TYPE_352a0edd36e546ef8c673f5255eea609.PROP_a97a2aac82344a75b7b49263bc96259b());
        this.AddMember("damageType", (IMemberDescriptor) new Bridge.TYPE_352a0edd36e546ef8c673f5255eea609.PROP_1960e0ffac12493b8c45728535a3cb15());
        this.AddMember("book", (IMemberDescriptor) new Bridge.TYPE_352a0edd36e546ef8c673f5255eea609.PROP_ca9c8900af97421199a2d9e9b65be5f6());
        this.AddMember("damage", (IMemberDescriptor) new Bridge.TYPE_352a0edd36e546ef8c673f5255eea609.PROP_fa4be03ed1d74e0293f1ba7157f3b0d6());
        this.AddMember("explosionRadius", (IMemberDescriptor) new Bridge.TYPE_352a0edd36e546ef8c673f5255eea609.PROP_4b8cd01db5bf4403983e47c07ba7be69());
        this.AddMember("description", (IMemberDescriptor) new Bridge.TYPE_352a0edd36e546ef8c673f5255eea609.PROP_2a3f96dd2af44dd0a77341ab9431409f());
        this.AddMember("descriptionOnly", (IMemberDescriptor) new Bridge.TYPE_352a0edd36e546ef8c673f5255eea609.PROP_3b93c3c1afdc47a7be2e8877f3f82448());
        this.AddMember("descriptionExtra", (IMemberDescriptor) new Bridge.TYPE_352a0edd36e546ef8c673f5255eea609.PROP_c9dfbf9c4494429d97eac96db3376c6b());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_352a0edd36e546ef8c673f5255eea609.PROP_54bb156756864d11889442dd0a77da0c());
      }

      private sealed class MTHD_401f89a698104f5f8c083a788e0e31c5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_401f89a698104f5f8c083a788e0e31c5()
        {
          this.Initialize("get_uses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).uses;
        }
      }

      private sealed class MTHD_e8fa4fa314c642af98fbcf99ec09c53e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e8fa4fa314c642af98fbcf99ec09c53e()
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

      private sealed class MTHD_9cebb7018c28460c938e1c02bf571156 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9cebb7018c28460c938e1c02bf571156()
        {
          this.Initialize("get_maxUses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).maxUses;
        }
      }

      private sealed class MTHD_997d215a6f8b4e33b1f5914bbd6baab3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_997d215a6f8b4e33b1f5914bbd6baab3()
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

      private sealed class MTHD_0b207e266d184f3b84faac7f98cfe8a4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0b207e266d184f3b84faac7f98cfe8a4()
        {
          this.Initialize("get_rechargeTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).rechargeTime;
        }
      }

      private sealed class MTHD_5db1e44982a74eb9af5ddf9dc5e33357 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5db1e44982a74eb9af5ddf9dc5e33357()
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

      private sealed class MTHD_7faf50a17be041ef8960799f4d85ad69 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7faf50a17be041ef8960799f4d85ad69()
        {
          this.Initialize("get_lastTurnFired", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).lastTurnFired;
        }
      }

      private sealed class MTHD_5aae864f7453450f87882685ca660d53 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5aae864f7453450f87882685ca660d53()
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

      private sealed class MTHD_4afde0fd3f3247758358e58327f77d39 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4afde0fd3f3247758358e58327f77d39()
        {
          this.Initialize("get_isPresent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).isPresent;
        }
      }

      private sealed class MTHD_20c450d0420b47fb882c08de779722e0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_20c450d0420b47fb882c08de779722e0()
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

      private sealed class MTHD_a4c287bac2d04c94b59acb3028cafc09 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a4c287bac2d04c94b59acb3028cafc09()
        {
          this.Initialize("get_locked", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).locked;
        }
      }

      private sealed class MTHD_c1c34d1beedc40af971dd261a290abad : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c1c34d1beedc40af971dd261a290abad()
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

      private sealed class MTHD_28116866a11b4628b12b3e09a34b077a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_28116866a11b4628b12b3e09a34b077a()
        {
          this.Initialize("get_turnsTillFirstUse", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).turnsTillFirstUse;
        }
      }

      private sealed class MTHD_06eb981004a941018163c80924417f71 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_06eb981004a941018163c80924417f71()
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

      private sealed class MTHD_042c084964e34659b8023eb60d12b3ed : HardwiredMethodMemberDescriptor
      {
        internal MTHD_042c084964e34659b8023eb60d12b3ed()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class MTHD_e7876eaa008640a88f8413bca3560596 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e7876eaa008640a88f8413bca3560596()
        {
          this.Initialize("get_castType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class MTHD_3c8d643f7cb047e5be40d0761501eb49 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3c8d643f7cb047e5be40d0761501eb49()
        {
          this.Initialize("get_damageType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class MTHD_45fa88030f554012b1dec170fcf70f5a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_45fa88030f554012b1dec170fcf70f5a()
        {
          this.Initialize("get_book", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class MTHD_f0fc34c3456a4e1aac47d5c03a5dc1ef : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f0fc34c3456a4e1aac47d5c03a5dc1ef()
        {
          this.Initialize("get_damage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class MTHD_1227947f2381465d886c103abfee6011 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1227947f2381465d886c103abfee6011()
        {
          this.Initialize("get_explosionRadius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class MTHD_519d759edf654de4bace3c167b56cfaa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_519d759edf654de4bace3c167b56cfaa()
        {
          this.Initialize("get_description", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class MTHD_5cbb3753e9684ee8a5c900d998fa64ea : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5cbb3753e9684ee8a5c900d998fa64ea()
        {
          this.Initialize("get_descriptionOnly", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class MTHD_49595ceeaa044c1bb8504224b62d9ee7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_49595ceeaa044c1bb8504224b62d9ee7()
        {
          this.Initialize("get_descriptionExtra", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class MTHD_644b43bcddda4ed4816dfb840fe538b0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_644b43bcddda4ed4816dfb840fe538b0()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }

      private sealed class MTHD_9b53036a204942bc81bb761b1e52994b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9b53036a204942bc81bb761b1e52994b()
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

      private sealed class MTHD_026e2a24a2bc4315969253c3ef3274c8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_026e2a24a2bc4315969253c3ef3274c8()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_1c5febda4d734bb4bc94d34529772f39 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1c5febda4d734bb4bc94d34529772f39()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_4fa2b01e9cf34cbd88f8f76dd8798c7a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4fa2b01e9cf34cbd88f8f76dd8798c7a()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_baf3dd92342f4be9a26af297b2e986a1 : HardwiredMemberDescriptor
      {
        internal PROP_baf3dd92342f4be9a26af297b2e986a1()
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

      private sealed class PROP_d138a98f50ac43f6b08ea38a44797fc6 : HardwiredMemberDescriptor
      {
        internal PROP_d138a98f50ac43f6b08ea38a44797fc6()
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

      private sealed class PROP_81d5b880db6642aab2e1752b0c9e9000 : HardwiredMemberDescriptor
      {
        internal PROP_81d5b880db6642aab2e1752b0c9e9000()
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

      private sealed class PROP_6769881d4f364ae4a1d104f1f219476d : HardwiredMemberDescriptor
      {
        internal PROP_6769881d4f364ae4a1d104f1f219476d()
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

      private sealed class PROP_5dd95a05378c4c4a8fbecbea1c7a96de : HardwiredMemberDescriptor
      {
        internal PROP_5dd95a05378c4c4a8fbecbea1c7a96de()
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

      private sealed class PROP_2ec12c66fc454a04b5eae2f4ca48ff2b : HardwiredMemberDescriptor
      {
        internal PROP_2ec12c66fc454a04b5eae2f4ca48ff2b()
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

      private sealed class PROP_d8eb2db8874c460a8706fe144a8bfe35 : HardwiredMemberDescriptor
      {
        internal PROP_d8eb2db8874c460a8706fe144a8bfe35()
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

      private sealed class PROP_7afd2dcb7df34f14b5f648f40d7baceb : HardwiredMemberDescriptor
      {
        internal PROP_7afd2dcb7df34f14b5f648f40d7baceb()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class PROP_a97a2aac82344a75b7b49263bc96259b : HardwiredMemberDescriptor
      {
        internal PROP_a97a2aac82344a75b7b49263bc96259b()
          : base(typeof (CastType), "castType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class PROP_1960e0ffac12493b8c45728535a3cb15 : HardwiredMemberDescriptor
      {
        internal PROP_1960e0ffac12493b8c45728535a3cb15()
          : base(typeof (DamageType), "damageType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class PROP_ca9c8900af97421199a2d9e9b65be5f6 : HardwiredMemberDescriptor
      {
        internal PROP_ca9c8900af97421199a2d9e9b65be5f6()
          : base(typeof (BookOf), "book", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class PROP_fa4be03ed1d74e0293f1ba7157f3b0d6 : HardwiredMemberDescriptor
      {
        internal PROP_fa4be03ed1d74e0293f1ba7157f3b0d6()
          : base(typeof (int), "damage", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class PROP_4b8cd01db5bf4403983e47c07ba7be69 : HardwiredMemberDescriptor
      {
        internal PROP_4b8cd01db5bf4403983e47c07ba7be69()
          : base(typeof (int), "explosionRadius", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class PROP_2a3f96dd2af44dd0a77341ab9431409f : HardwiredMemberDescriptor
      {
        internal PROP_2a3f96dd2af44dd0a77341ab9431409f()
          : base(typeof (string), "description", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class PROP_3b93c3c1afdc47a7be2e8877f3f82448 : HardwiredMemberDescriptor
      {
        internal PROP_3b93c3c1afdc47a7be2e8877f3f82448()
          : base(typeof (string), "descriptionOnly", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class PROP_c9dfbf9c4494429d97eac96db3376c6b : HardwiredMemberDescriptor
      {
        internal PROP_c9dfbf9c4494429d97eac96db3376c6b()
          : base(typeof (string), "descriptionExtra", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class PROP_54bb156756864d11889442dd0a77da0c : HardwiredMemberDescriptor
      {
        internal PROP_54bb156756864d11889442dd0a77da0c()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }
    }

    private sealed class TYPE_d0bfa83f58fd48c8a10aeab139a51d90 : HardwiredUserDataDescriptor
    {
      internal TYPE_d0bfa83f58fd48c8a10aeab139a51d90()
        : base(typeof (ContainerTower))
      {
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d0bfa83f58fd48c8a10aeab139a51d90.MTHD_43aba0cf54114f95bf483125898462ea()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d0bfa83f58fd48c8a10aeab139a51d90.MTHD_33bd1346aef04ccbb5cedca2406be84c()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d0bfa83f58fd48c8a10aeab139a51d90.MTHD_76913641a5f64202b7499a0a3805674f()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d0bfa83f58fd48c8a10aeab139a51d90.MTHD_ffa283eea1fd4823accb8fc17c0119e0()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d0bfa83f58fd48c8a10aeab139a51d90.MTHD_1297ea6354bf4ff6a2e58f6b4f2d3647()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d0bfa83f58fd48c8a10aeab139a51d90.MTHD_620ee4c3378d486c95157235f28c89a5()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d0bfa83f58fd48c8a10aeab139a51d90.MTHD_dcabc7ad7c5a4c7191ad4617a1691a66()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d0bfa83f58fd48c8a10aeab139a51d90.MTHD_9af170540d824f1bb449a5ab301da471()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d0bfa83f58fd48c8a10aeab139a51d90.MTHD_4d6feb9a610643e7bd2feda3083667a3()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d0bfa83f58fd48c8a10aeab139a51d90.MTHD_34f1455a30e14a40942daca62e871adb()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d0bfa83f58fd48c8a10aeab139a51d90.MTHD_a964e7393f574a139823c10a08ee4f27()
        }));
        this.AddMember("getType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d0bfa83f58fd48c8a10aeab139a51d90.MTHD_d5b4d6f9ad16418f8748b0ea7971c148()
        }));
        this.AddMember("kill", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("kill", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d0bfa83f58fd48c8a10aeab139a51d90.MTHD_9124bf5c8b94406d97299972ef288f3c()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d0bfa83f58fd48c8a10aeab139a51d90.MTHD_614aa36a6bb848c3ad7bdeea1f6407cd()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d0bfa83f58fd48c8a10aeab139a51d90.MTHD_192fbe049ece4e4282eb35dc1ab30d6f()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d0bfa83f58fd48c8a10aeab139a51d90.MTHD_744b0b99d5874c7fafd9ac613710b2fd()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d0bfa83f58fd48c8a10aeab139a51d90.MTHD_2ad4ef10f8c74f2fa152b84ff08efcbe()
        }));
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_d0bfa83f58fd48c8a10aeab139a51d90.PROP_2351406077cf486e8e410e6eaf34c786());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_d0bfa83f58fd48c8a10aeab139a51d90.PROP_2d10e8c16b754ab7982bc334d888dbe1());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_d0bfa83f58fd48c8a10aeab139a51d90.PROP_ea1fec153e9540cf9697148b07f617e0());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_d0bfa83f58fd48c8a10aeab139a51d90.PROP_aeec09934f5e402d957b83bb8383ecf9());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_d0bfa83f58fd48c8a10aeab139a51d90.PROP_5ac00aa9d3f14bd3a04416ced6775d1c());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_d0bfa83f58fd48c8a10aeab139a51d90.PROP_0079d8c3051c415ab492de92812bc2f3());
      }

      private sealed class MTHD_43aba0cf54114f95bf483125898462ea : HardwiredMethodMemberDescriptor
      {
        internal MTHD_43aba0cf54114f95bf483125898462ea()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).health;
        }
      }

      private sealed class MTHD_33bd1346aef04ccbb5cedca2406be84c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_33bd1346aef04ccbb5cedca2406be84c()
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

      private sealed class MTHD_76913641a5f64202b7499a0a3805674f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_76913641a5f64202b7499a0a3805674f()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).maxHealth;
        }
      }

      private sealed class MTHD_ffa283eea1fd4823accb8fc17c0119e0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ffa283eea1fd4823accb8fc17c0119e0()
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

      private sealed class MTHD_1297ea6354bf4ff6a2e58f6b4f2d3647 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1297ea6354bf4ff6a2e58f6b4f2d3647()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).x;
        }
      }

      private sealed class MTHD_620ee4c3378d486c95157235f28c89a5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_620ee4c3378d486c95157235f28c89a5()
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

      private sealed class MTHD_dcabc7ad7c5a4c7191ad4617a1691a66 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dcabc7ad7c5a4c7191ad4617a1691a66()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).y;
        }
      }

      private sealed class MTHD_9af170540d824f1bb449a5ab301da471 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9af170540d824f1bb449a5ab301da471()
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

      private sealed class MTHD_4d6feb9a610643e7bd2feda3083667a3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4d6feb9a610643e7bd2feda3083667a3()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).position;
        }
      }

      private sealed class MTHD_34f1455a30e14a40942daca62e871adb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_34f1455a30e14a40942daca62e871adb()
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

      private sealed class MTHD_a964e7393f574a139823c10a08ee4f27 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a964e7393f574a139823c10a08ee4f27()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }

      private sealed class MTHD_d5b4d6f9ad16418f8748b0ea7971c148 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d5b4d6f9ad16418f8748b0ea7971c148()
        {
          this.Initialize("getType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).getType();
        }
      }

      private sealed class MTHD_9124bf5c8b94406d97299972ef288f3c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9124bf5c8b94406d97299972ef288f3c()
        {
          this.Initialize("kill", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerTower) obj).kill();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_614aa36a6bb848c3ad7bdeea1f6407cd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_614aa36a6bb848c3ad7bdeea1f6407cd()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).GetHashCode();
        }
      }

      private sealed class MTHD_192fbe049ece4e4282eb35dc1ab30d6f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_192fbe049ece4e4282eb35dc1ab30d6f()
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

      private sealed class MTHD_744b0b99d5874c7fafd9ac613710b2fd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_744b0b99d5874c7fafd9ac613710b2fd()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_2ad4ef10f8c74f2fa152b84ff08efcbe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2ad4ef10f8c74f2fa152b84ff08efcbe()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_2351406077cf486e8e410e6eaf34c786 : HardwiredMemberDescriptor
      {
        internal PROP_2351406077cf486e8e410e6eaf34c786()
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

      private sealed class PROP_2d10e8c16b754ab7982bc334d888dbe1 : HardwiredMemberDescriptor
      {
        internal PROP_2d10e8c16b754ab7982bc334d888dbe1()
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

      private sealed class PROP_ea1fec153e9540cf9697148b07f617e0 : HardwiredMemberDescriptor
      {
        internal PROP_ea1fec153e9540cf9697148b07f617e0()
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

      private sealed class PROP_aeec09934f5e402d957b83bb8383ecf9 : HardwiredMemberDescriptor
      {
        internal PROP_aeec09934f5e402d957b83bb8383ecf9()
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

      private sealed class PROP_5ac00aa9d3f14bd3a04416ced6775d1c : HardwiredMemberDescriptor
      {
        internal PROP_5ac00aa9d3f14bd3a04416ced6775d1c()
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

      private sealed class PROP_0079d8c3051c415ab492de92812bc2f3 : HardwiredMemberDescriptor
      {
        internal PROP_0079d8c3051c415ab492de92812bc2f3()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }
    }

    private sealed class TYPE_9cca207999fe47af8cad135a8f2ff18a : HardwiredUserDataDescriptor
    {
      internal TYPE_9cca207999fe47af8cad135a8f2ff18a()
        : base(typeof (Educative.Point))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9cca207999fe47af8cad135a8f2ff18a.MTHD_06d758972c164e60a25419ee4bc5aec9(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9cca207999fe47af8cad135a8f2ff18a.MTHD_88cf35fa7fb14de2bf70c10e36f1ae0f()
        }));
        this.AddMember("distance", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("distance", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9cca207999fe47af8cad135a8f2ff18a.MTHD_41260a9238f44e029d70b62f7283b204(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9cca207999fe47af8cad135a8f2ff18a.MTHD_722cd80c838a45179b9eed88d538176d()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9cca207999fe47af8cad135a8f2ff18a.MTHD_e54ae1a30cac46068a5749e212af40d0()
        }));
        this.AddMember("copy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("copy", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9cca207999fe47af8cad135a8f2ff18a.MTHD_0475149501904b3c9b4be27b4c66bce5()
        }));
        this.AddMember("normalized", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalized", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9cca207999fe47af8cad135a8f2ff18a.MTHD_8a2712c608bd4f3991f89ebba28f5387()
        }));
        this.AddMember("normalize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalize", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9cca207999fe47af8cad135a8f2ff18a.MTHD_4aae3ee599424d5aa56f6f6fe7b13106()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9cca207999fe47af8cad135a8f2ff18a.MTHD_9dd608f395d44f6b901cd479742ee875()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9cca207999fe47af8cad135a8f2ff18a.MTHD_97860e0017e64fa4912fe4290aa11f28()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9cca207999fe47af8cad135a8f2ff18a.MTHD_95649e94a3514d7dbc0dec9a66ead8db()
        }));
        this.AddMember("op_Subtraction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Subtraction", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9cca207999fe47af8cad135a8f2ff18a.MTHD_de4b39cdb79240248eb67beceba76c03(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9cca207999fe47af8cad135a8f2ff18a.MTHD_3d0057a7c5ea47d98fdadd23033703fa()
        }));
        this.AddMember("op_Addition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Addition", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9cca207999fe47af8cad135a8f2ff18a.MTHD_a1b75fde503d473fb50240711d9892fc(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9cca207999fe47af8cad135a8f2ff18a.MTHD_5e1546e7b08347008f359c04dc96127d()
        }));
        this.AddMember("op_Multiply", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Multiply", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9cca207999fe47af8cad135a8f2ff18a.MTHD_cb14eef7f3e7429096411fb984663c65(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9cca207999fe47af8cad135a8f2ff18a.MTHD_89ede1eb4f4a4f7ea4d8a875f77c4ab0()
        }));
        this.AddMember("op_Division", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Division", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9cca207999fe47af8cad135a8f2ff18a.MTHD_bf630e0e5ba748e08e048df4156ad47d(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9cca207999fe47af8cad135a8f2ff18a.MTHD_81c0c0b090d34ab79eec0b7194a24980()
        }));
        this.AddMember("op_Modulus", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Modulus", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9cca207999fe47af8cad135a8f2ff18a.MTHD_9964dd5963a54d978401412e38932820(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9cca207999fe47af8cad135a8f2ff18a.MTHD_6859dac9502444cd96b757ec55c8b9ea()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9cca207999fe47af8cad135a8f2ff18a.MTHD_d94e5c253b6243e886b72f85fa64b2ed()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9cca207999fe47af8cad135a8f2ff18a.MTHD_aec16ceebc2942f6aa37e704fd100140()
        }));
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_9cca207999fe47af8cad135a8f2ff18a.FLDV_e2e401d27fcb4b86b9968b87b3d45eb2());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_9cca207999fe47af8cad135a8f2ff18a.FLDV_963c36e044f247c1945536e836141456());
      }

      private sealed class MTHD_06d758972c164e60a25419ee4bc5aec9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_06d758972c164e60a25419ee4bc5aec9()
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

      private sealed class MTHD_88cf35fa7fb14de2bf70c10e36f1ae0f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_88cf35fa7fb14de2bf70c10e36f1ae0f()
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

      private sealed class MTHD_41260a9238f44e029d70b62f7283b204 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_41260a9238f44e029d70b62f7283b204()
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

      private sealed class MTHD_722cd80c838a45179b9eed88d538176d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_722cd80c838a45179b9eed88d538176d()
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

      private sealed class MTHD_e54ae1a30cac46068a5749e212af40d0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e54ae1a30cac46068a5749e212af40d0()
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

      private sealed class MTHD_0475149501904b3c9b4be27b4c66bce5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0475149501904b3c9b4be27b4c66bce5()
        {
          this.Initialize("copy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).copy();
        }
      }

      private sealed class MTHD_8a2712c608bd4f3991f89ebba28f5387 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8a2712c608bd4f3991f89ebba28f5387()
        {
          this.Initialize("normalized", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).normalized();
        }
      }

      private sealed class MTHD_4aae3ee599424d5aa56f6f6fe7b13106 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4aae3ee599424d5aa56f6f6fe7b13106()
        {
          this.Initialize("normalize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((Educative.Point) obj).normalize();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_9dd608f395d44f6b901cd479742ee875 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9dd608f395d44f6b901cd479742ee875()
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

      private sealed class MTHD_97860e0017e64fa4912fe4290aa11f28 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_97860e0017e64fa4912fe4290aa11f28()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).GetHashCode();
        }
      }

      private sealed class MTHD_95649e94a3514d7dbc0dec9a66ead8db : HardwiredMethodMemberDescriptor
      {
        internal MTHD_95649e94a3514d7dbc0dec9a66ead8db()
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

      private sealed class MTHD_de4b39cdb79240248eb67beceba76c03 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_de4b39cdb79240248eb67beceba76c03()
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

      private sealed class MTHD_3d0057a7c5ea47d98fdadd23033703fa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3d0057a7c5ea47d98fdadd23033703fa()
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

      private sealed class MTHD_a1b75fde503d473fb50240711d9892fc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a1b75fde503d473fb50240711d9892fc()
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

      private sealed class MTHD_5e1546e7b08347008f359c04dc96127d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5e1546e7b08347008f359c04dc96127d()
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

      private sealed class MTHD_cb14eef7f3e7429096411fb984663c65 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cb14eef7f3e7429096411fb984663c65()
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

      private sealed class MTHD_89ede1eb4f4a4f7ea4d8a875f77c4ab0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_89ede1eb4f4a4f7ea4d8a875f77c4ab0()
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

      private sealed class MTHD_bf630e0e5ba748e08e048df4156ad47d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bf630e0e5ba748e08e048df4156ad47d()
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

      private sealed class MTHD_81c0c0b090d34ab79eec0b7194a24980 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_81c0c0b090d34ab79eec0b7194a24980()
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

      private sealed class MTHD_9964dd5963a54d978401412e38932820 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9964dd5963a54d978401412e38932820()
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

      private sealed class MTHD_6859dac9502444cd96b757ec55c8b9ea : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6859dac9502444cd96b757ec55c8b9ea()
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

      private sealed class MTHD_d94e5c253b6243e886b72f85fa64b2ed : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d94e5c253b6243e886b72f85fa64b2ed()
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

      private sealed class MTHD_aec16ceebc2942f6aa37e704fd100140 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aec16ceebc2942f6aa37e704fd100140()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_e2e401d27fcb4b86b9968b87b3d45eb2 : HardwiredMemberDescriptor
      {
        internal FLDV_e2e401d27fcb4b86b9968b87b3d45eb2()
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

      private sealed class FLDV_963c36e044f247c1945536e836141456 : HardwiredMemberDescriptor
      {
        internal FLDV_963c36e044f247c1945536e836141456()
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

    private sealed class TYPE_d92a6931c569413c98b448a0bf44630b : HardwiredUserDataDescriptor
    {
      internal TYPE_d92a6931c569413c98b448a0bf44630b()
        : base(typeof (Summon))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d92a6931c569413c98b448a0bf44630b.MTHD_316aedf9bb644314a5b015c0cdd0d4f2()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d92a6931c569413c98b448a0bf44630b.MTHD_b0d41a33cb534e278d6da6f64c243f19()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d92a6931c569413c98b448a0bf44630b.MTHD_e5d7d81885864f36aa6aef3ce18fce09()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d92a6931c569413c98b448a0bf44630b.MTHD_afcc2dfd04f74764a881897fb80dd7ee()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d92a6931c569413c98b448a0bf44630b.MTHD_e79a555893f74947803bf7d44b77d444()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d92a6931c569413c98b448a0bf44630b.MTHD_c98c2962719549b89f3c107edf44f512()
        }));
        this.AddMember("spell", (IMemberDescriptor) new Bridge.TYPE_d92a6931c569413c98b448a0bf44630b.FLDV_8b54757164134334835dd42034111c48());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_d92a6931c569413c98b448a0bf44630b.FLDV_d8b6dabc2510462c90faeafadc72e93b());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_d92a6931c569413c98b448a0bf44630b.FLDV_030fb326224e4cea8ce0eba6f2bb1f71());
        this.AddMember("onPlayersPanel", (IMemberDescriptor) new Bridge.TYPE_d92a6931c569413c98b448a0bf44630b.FLDV_88293fbbfdb34d4393febe0e92816e6c());
        this.AddMember("useAI", (IMemberDescriptor) new Bridge.TYPE_d92a6931c569413c98b448a0bf44630b.FLDV_ab28392e15a24ec2b3d5993beccf21ab());
        this.AddMember("no_AI_still_use_turn", (IMemberDescriptor) new Bridge.TYPE_d92a6931c569413c98b448a0bf44630b.FLDV_4e84ac6b970c4a7fb6d48bc4f3ea7db7());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_d92a6931c569413c98b448a0bf44630b.FLDV_1a07e0bc1b7b43f5b478fdce0ba2932c());
        this.AddMember("playSound", (IMemberDescriptor) new Bridge.TYPE_d92a6931c569413c98b448a0bf44630b.FLDV_b94290f587854af1a6e4bf539ee5889f());
        this.AddMember("prestige", (IMemberDescriptor) new Bridge.TYPE_d92a6931c569413c98b448a0bf44630b.FLDV_757d40a63f2d4b75a4b7b92a5a10b129());
        this.AddMember("colors", (IMemberDescriptor) new Bridge.TYPE_d92a6931c569413c98b448a0bf44630b.FLDV_3bb0a307d47d44f9b0d2144357f4ee8a());
        this.AddMember("spells", (IMemberDescriptor) new Bridge.TYPE_d92a6931c569413c98b448a0bf44630b.FLDV_ec4481635ca6445b8a5fc4f276b4c22a());
        this.AddMember("outfit", (IMemberDescriptor) new Bridge.TYPE_d92a6931c569413c98b448a0bf44630b.FLDV_8382ec54eef54b5ba04535fedd19e201());
        this.AddMember("elemental", (IMemberDescriptor) new Bridge.TYPE_d92a6931c569413c98b448a0bf44630b.FLDV_bc87f986264a40ca90872dd73552ed6a());
      }

      private sealed class MTHD_316aedf9bb644314a5b015c0cdd0d4f2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_316aedf9bb644314a5b015c0cdd0d4f2()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new Summon();
        }
      }

      private sealed class MTHD_b0d41a33cb534e278d6da6f64c243f19 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b0d41a33cb534e278d6da6f64c243f19()
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

      private sealed class MTHD_e5d7d81885864f36aa6aef3ce18fce09 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e5d7d81885864f36aa6aef3ce18fce09()
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

      private sealed class MTHD_afcc2dfd04f74764a881897fb80dd7ee : HardwiredMethodMemberDescriptor
      {
        internal MTHD_afcc2dfd04f74764a881897fb80dd7ee()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_e79a555893f74947803bf7d44b77d444 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e79a555893f74947803bf7d44b77d444()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_c98c2962719549b89f3c107edf44f512 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c98c2962719549b89f3c107edf44f512()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_8b54757164134334835dd42034111c48 : HardwiredMemberDescriptor
      {
        internal FLDV_8b54757164134334835dd42034111c48()
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

      private sealed class FLDV_d8b6dabc2510462c90faeafadc72e93b : HardwiredMemberDescriptor
      {
        internal FLDV_d8b6dabc2510462c90faeafadc72e93b()
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

      private sealed class FLDV_030fb326224e4cea8ce0eba6f2bb1f71 : HardwiredMemberDescriptor
      {
        internal FLDV_030fb326224e4cea8ce0eba6f2bb1f71()
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

      private sealed class FLDV_88293fbbfdb34d4393febe0e92816e6c : HardwiredMemberDescriptor
      {
        internal FLDV_88293fbbfdb34d4393febe0e92816e6c()
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

      private sealed class FLDV_ab28392e15a24ec2b3d5993beccf21ab : HardwiredMemberDescriptor
      {
        internal FLDV_ab28392e15a24ec2b3d5993beccf21ab()
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

      private sealed class FLDV_4e84ac6b970c4a7fb6d48bc4f3ea7db7 : HardwiredMemberDescriptor
      {
        internal FLDV_4e84ac6b970c4a7fb6d48bc4f3ea7db7()
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

      private sealed class FLDV_1a07e0bc1b7b43f5b478fdce0ba2932c : HardwiredMemberDescriptor
      {
        internal FLDV_1a07e0bc1b7b43f5b478fdce0ba2932c()
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

      private sealed class FLDV_b94290f587854af1a6e4bf539ee5889f : HardwiredMemberDescriptor
      {
        internal FLDV_b94290f587854af1a6e4bf539ee5889f()
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

      private sealed class FLDV_757d40a63f2d4b75a4b7b92a5a10b129 : HardwiredMemberDescriptor
      {
        internal FLDV_757d40a63f2d4b75a4b7b92a5a10b129()
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

      private sealed class FLDV_3bb0a307d47d44f9b0d2144357f4ee8a : HardwiredMemberDescriptor
      {
        internal FLDV_3bb0a307d47d44f9b0d2144357f4ee8a()
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

      private sealed class FLDV_ec4481635ca6445b8a5fc4f276b4c22a : HardwiredMemberDescriptor
      {
        internal FLDV_ec4481635ca6445b8a5fc4f276b4c22a()
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

      private sealed class FLDV_8382ec54eef54b5ba04535fedd19e201 : HardwiredMemberDescriptor
      {
        internal FLDV_8382ec54eef54b5ba04535fedd19e201()
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

      private sealed class FLDV_bc87f986264a40ca90872dd73552ed6a : HardwiredMemberDescriptor
      {
        internal FLDV_bc87f986264a40ca90872dd73552ed6a()
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

    private sealed class TYPE_00fd262a43bd45828974a722afb05655 : HardwiredUserDataDescriptor
    {
      internal TYPE_00fd262a43bd45828974a722afb05655()
        : base(typeof (UIElement))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_306a061966d44dc2bc2f447e36e5d291()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_9b8cbfa8400d426c9febc103fe1525f5()
        }));
        this.AddMember("get_visible", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_visible", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_9b0fcf87327347dd8115da1ba034dbb7()
        }));
        this.AddMember("set_visible", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_visible", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_7a692f1c0646410aa869d2e5765afee5()
        }));
        this.AddMember("get_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_cb16810a8a524f7fafcf9eb84ac68b43()
        }));
        this.AddMember("set_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_507d5828c00d44f9ade901b934b5db47()
        }));
        this.AddMember("get_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_a7a3cd56126a44ad9fc413af07b35f07()
        }));
        this.AddMember("set_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_d23233ff35d94622a6401fed1cbdedc6()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_c5399e4ccb2049b88c2e3923fc5e80ba()
        }));
        this.AddMember("set_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_091127d343bb460b958975b065eab63e()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_3776804b75694b608986d2c3915fb64e()
        }));
        this.AddMember("set_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_bdb8c71d645342c68c068766b81b5ad2()
        }));
        this.AddMember("get_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_7765bdfbd7044015a41e1277fa9fa164()
        }));
        this.AddMember("set_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_0af1486ab21e405d902cfdc08fb3c450()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_b6a264e655d44102a74e6d04ca91044c()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_afe7d9bdd22e4d179e279316cbece88b()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_72e60f72615446038e5af7a5bf548605()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_244b1420f6be43bda45d87c83f262d04()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_dc99e26cab6544dcba7f93e299920ae9()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_09e49e2af5a949e69395d7dbd722fa6d()
        }));
        this.AddMember("get_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_4ac613c7ce214c06ba3fa419179e70d3()
        }));
        this.AddMember("set_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_4a574d618fc84147b90e625c0f7b8082()
        }));
        this.AddMember("get_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_d1499e3d51904edc902c3f6923dd03f6()
        }));
        this.AddMember("set_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_6acf058383454d228ffedc27a361a89d()
        }));
        this.AddMember("get_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_b413e6a1577e4eb4b5eb549bcae22b4e()
        }));
        this.AddMember("set_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_1404f1b92f464aad9668b61455aa5c1b()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_a1b9558dbe834a35a2c614b27550a64f()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_a905575bff18477fab1be6d29fcdd65f()
        }));
        this.AddMember("get_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_fbcef830d94d4bbc84883ae4533c3431()
        }));
        this.AddMember("set_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_b1e8f95127614868affaf9b35e3f815b()
        }));
        this.AddMember("get_onClick2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_6d0c357528e94d668345b14003b588b7()
        }));
        this.AddMember("set_onClick2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_f7f78e932485460abdc25eb61b51eb53()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_fd31f7322d284a4bb441ecddc7921a87()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_7996c1de6229482faf0a9d35587167b5()
        }));
        this.AddMember("get_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_4b91c13ff9714f829ecca8d816f82db8()
        }));
        this.AddMember("set_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_72a527d626674961acb7002afdbdeea5()
        }));
        this.AddMember("get_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_44a03b67f94249a69ff6fad7b63b0470()
        }));
        this.AddMember("set_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_8659d3c863904287aae36d81c67b8f32()
        }));
        this.AddMember("get_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_40dbaf1fe0ba4363adb1a0412625681f()
        }));
        this.AddMember("set_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_90760445fa074a74a1f17c30d0102848()
        }));
        this.AddMember("get_textColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_f4bbd8d1e3004dce83f42a9910473973()
        }));
        this.AddMember("set_textColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_8af88bb701844ef28f3597ff828ccc88()
        }));
        this.AddMember("get_highlightColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_highlightColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_737da04ea2fa40dcae839d1e3989012d()
        }));
        this.AddMember("set_highlightColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_highlightColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_bcf3fd0a076545799a10e65e234aba6a()
        }));
        this.AddMember("get_highlightColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_highlightColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_b9ee258cb13e443c91105eda208dde62()
        }));
        this.AddMember("set_highlightColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_highlightColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_abe62c03015140c59ecf6c0c475307e7()
        }));
        this.AddMember("get_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_bf75f1ffc7c34608a33fdd1fda7aa907()
        }));
        this.AddMember("set_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_0da07d698cd64256967a8bce6bed0898()
        }));
        this.AddMember("get_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_84920568b5054ec988d73cad0f3e24ff()
        }));
        this.AddMember("set_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_57a5755b5d4345a18c30acadc0942867()
        }));
        this.AddMember("activateInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("activateInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_3226047bdcb14fe48d8fdcfaa2178d24()
        }));
        this.AddMember("createUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createUI", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_c66f8d141cb3479885426063d6ae32da()
        }));
        this.AddMember("createInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_105fe8ea5430486c9dc73d690b29eac5()
        }));
        this.AddMember("duplicate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("duplicate", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_aa5486fb092c4c4793418d83b53f95f6()
        }));
        this.AddMember("destroyHierarchy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroyHierarchy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_bcdab94f0f044e789e060388736eb551()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_0ac34c00926940f08aab4b634d8ffa8a()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_f3c56ed09cbf4b4dba2d73e08d9ac3bc()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_de5ed6e6b21443908441a50c524fa231()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_89d6aa5675364efab0ca3817d2567b81()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.MTHD_d2e22820b7594fe68bc80694aaaa7ac9()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.PROP_1bfd4530868c4390bb5a57fd3faafba2());
        this.AddMember("visible", (IMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.PROP_b1e9281dadd84226b0549514f9c15dc7());
        this.AddMember("graphic", (IMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.PROP_231386a0a0ca4b0bb4f90f55aa736f00());
        this.AddMember("anchor", (IMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.PROP_339574a51455415299c68bd1aa31d7aa());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.PROP_bbf6a7d42e864874a840a1265c99f7b2());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.PROP_2c9ef8ec2c4a4804b1fc1b8d3657518d());
        this.AddMember("size", (IMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.PROP_94db860459ba4ea7b30f743d87347d07());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.PROP_01bb694bd4a04d9d8f9e0c3202a8515d());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.PROP_a651629b234c4ebeb520f225a40934e9());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.PROP_5b3f083e1c8345b599dbca6605222f0c());
        this.AddMember("pivot_x", (IMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.PROP_e423ecb3d55c45e4bc1af9b2f5272998());
        this.AddMember("pivot_y", (IMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.PROP_331b37df254c4d329b4892f7836f00f7());
        this.AddMember("pivot", (IMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.PROP_03900ce487f54dd28ec8da5c84770e0a());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.PROP_d2470f8439d24ee99ffb1572bb0e7cc5());
        this.AddMember("onClick", (IMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.PROP_a0266fa47ec844949184bbbebef743f5());
        this.AddMember("onClick2", (IMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.PROP_1fb1797b3bbc42c6aeaf7e7f6d9ee104());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.PROP_3dd4b70e745c411c9058fac97db587c1());
        this.AddMember("color2", (IMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.PROP_649f71bb576c42cfbeaface75d90dec6());
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.PROP_38a0cf2490b544dcb00027d8ef500609());
        this.AddMember("textColor", (IMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.PROP_701b636a365f469d8bccefeb669f737d());
        this.AddMember("textColor2", (IMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.PROP_2805dd08052c4ddf8dda3b3f834534d9());
        this.AddMember("highlightColor", (IMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.PROP_35bdb609e94646cfb6617c9e5680cf87());
        this.AddMember("highlightColor2", (IMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.PROP_4f86f682f4434965a0453450fe04459d());
        this.AddMember("textStyle", (IMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.PROP_83f1aff975074d74bcdd53935094046a());
        this.AddMember("textSize", (IMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.PROP_533d60c193734dfe9e15223725749d4c());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.FLDV_aa57125ec5ba4664b47d41fe94d43401());
        this.AddMember("clickID", (IMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.FLDV_8636b8d5f7f24fc29f5778aaab64f140());
        this.AddMember("clickDestroy", (IMemberDescriptor) new Bridge.TYPE_00fd262a43bd45828974a722afb05655.FLDV_b0b2d946513e4f519cd35647553faf5b());
      }

      private sealed class MTHD_306a061966d44dc2bc2f447e36e5d291 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_306a061966d44dc2bc2f447e36e5d291()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new UIElement();
        }
      }

      private sealed class MTHD_9b8cbfa8400d426c9febc103fe1525f5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9b8cbfa8400d426c9febc103fe1525f5()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class MTHD_9b0fcf87327347dd8115da1ba034dbb7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9b0fcf87327347dd8115da1ba034dbb7()
        {
          this.Initialize("get_visible", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).visible;
        }
      }

      private sealed class MTHD_7a692f1c0646410aa869d2e5765afee5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7a692f1c0646410aa869d2e5765afee5()
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

      private sealed class MTHD_cb16810a8a524f7fafcf9eb84ac68b43 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cb16810a8a524f7fafcf9eb84ac68b43()
        {
          this.Initialize("get_graphic", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return ((UIElement) obj).graphic;
        }
      }

      private sealed class MTHD_507d5828c00d44f9ade901b934b5db47 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_507d5828c00d44f9ade901b934b5db47()
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

      private sealed class MTHD_a7a3cd56126a44ad9fc413af07b35f07 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a7a3cd56126a44ad9fc413af07b35f07()
        {
          this.Initialize("get_anchor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).anchor;
        }
      }

      private sealed class MTHD_d23233ff35d94622a6401fed1cbdedc6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d23233ff35d94622a6401fed1cbdedc6()
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

      private sealed class MTHD_c5399e4ccb2049b88c2e3923fc5e80ba : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c5399e4ccb2049b88c2e3923fc5e80ba()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).width;
        }
      }

      private sealed class MTHD_091127d343bb460b958975b065eab63e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_091127d343bb460b958975b065eab63e()
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

      private sealed class MTHD_3776804b75694b608986d2c3915fb64e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3776804b75694b608986d2c3915fb64e()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).height;
        }
      }

      private sealed class MTHD_bdb8c71d645342c68c068766b81b5ad2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bdb8c71d645342c68c068766b81b5ad2()
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

      private sealed class MTHD_7765bdfbd7044015a41e1277fa9fa164 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7765bdfbd7044015a41e1277fa9fa164()
        {
          this.Initialize("get_size", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).size;
        }
      }

      private sealed class MTHD_0af1486ab21e405d902cfdc08fb3c450 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0af1486ab21e405d902cfdc08fb3c450()
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

      private sealed class MTHD_b6a264e655d44102a74e6d04ca91044c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b6a264e655d44102a74e6d04ca91044c()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).x;
        }
      }

      private sealed class MTHD_afe7d9bdd22e4d179e279316cbece88b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_afe7d9bdd22e4d179e279316cbece88b()
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

      private sealed class MTHD_72e60f72615446038e5af7a5bf548605 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_72e60f72615446038e5af7a5bf548605()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).y;
        }
      }

      private sealed class MTHD_244b1420f6be43bda45d87c83f262d04 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_244b1420f6be43bda45d87c83f262d04()
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

      private sealed class MTHD_dc99e26cab6544dcba7f93e299920ae9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dc99e26cab6544dcba7f93e299920ae9()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).position;
        }
      }

      private sealed class MTHD_09e49e2af5a949e69395d7dbd722fa6d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_09e49e2af5a949e69395d7dbd722fa6d()
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

      private sealed class MTHD_4ac613c7ce214c06ba3fa419179e70d3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4ac613c7ce214c06ba3fa419179e70d3()
        {
          this.Initialize("get_pivot_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_x;
        }
      }

      private sealed class MTHD_4a574d618fc84147b90e625c0f7b8082 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4a574d618fc84147b90e625c0f7b8082()
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

      private sealed class MTHD_d1499e3d51904edc902c3f6923dd03f6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d1499e3d51904edc902c3f6923dd03f6()
        {
          this.Initialize("get_pivot_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_y;
        }
      }

      private sealed class MTHD_6acf058383454d228ffedc27a361a89d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6acf058383454d228ffedc27a361a89d()
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

      private sealed class MTHD_b413e6a1577e4eb4b5eb549bcae22b4e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b413e6a1577e4eb4b5eb549bcae22b4e()
        {
          this.Initialize("get_pivot", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot;
        }
      }

      private sealed class MTHD_1404f1b92f464aad9668b61455aa5c1b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1404f1b92f464aad9668b61455aa5c1b()
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

      private sealed class MTHD_a1b9558dbe834a35a2c614b27550a64f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a1b9558dbe834a35a2c614b27550a64f()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).angle;
        }
      }

      private sealed class MTHD_a905575bff18477fab1be6d29fcdd65f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a905575bff18477fab1be6d29fcdd65f()
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

      private sealed class MTHD_fbcef830d94d4bbc84883ae4533c3431 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fbcef830d94d4bbc84883ae4533c3431()
        {
          this.Initialize("get_onClick", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick;
        }
      }

      private sealed class MTHD_b1e8f95127614868affaf9b35e3f815b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b1e8f95127614868affaf9b35e3f815b()
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

      private sealed class MTHD_6d0c357528e94d668345b14003b588b7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6d0c357528e94d668345b14003b588b7()
        {
          this.Initialize("get_onClick2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick2;
        }
      }

      private sealed class MTHD_f7f78e932485460abdc25eb61b51eb53 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f7f78e932485460abdc25eb61b51eb53()
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

      private sealed class MTHD_fd31f7322d284a4bb441ecddc7921a87 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fd31f7322d284a4bb441ecddc7921a87()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color;
        }
      }

      private sealed class MTHD_7996c1de6229482faf0a9d35587167b5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7996c1de6229482faf0a9d35587167b5()
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

      private sealed class MTHD_4b91c13ff9714f829ecca8d816f82db8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4b91c13ff9714f829ecca8d816f82db8()
        {
          this.Initialize("get_color2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color2;
        }
      }

      private sealed class MTHD_72a527d626674961acb7002afdbdeea5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_72a527d626674961acb7002afdbdeea5()
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

      private sealed class MTHD_44a03b67f94249a69ff6fad7b63b0470 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_44a03b67f94249a69ff6fad7b63b0470()
        {
          this.Initialize("get_text", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).text;
        }
      }

      private sealed class MTHD_8659d3c863904287aae36d81c67b8f32 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8659d3c863904287aae36d81c67b8f32()
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

      private sealed class MTHD_40dbaf1fe0ba4363adb1a0412625681f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_40dbaf1fe0ba4363adb1a0412625681f()
        {
          this.Initialize("get_textColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor;
        }
      }

      private sealed class MTHD_90760445fa074a74a1f17c30d0102848 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_90760445fa074a74a1f17c30d0102848()
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

      private sealed class MTHD_f4bbd8d1e3004dce83f42a9910473973 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f4bbd8d1e3004dce83f42a9910473973()
        {
          this.Initialize("get_textColor2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor2;
        }
      }

      private sealed class MTHD_8af88bb701844ef28f3597ff828ccc88 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8af88bb701844ef28f3597ff828ccc88()
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

      private sealed class MTHD_737da04ea2fa40dcae839d1e3989012d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_737da04ea2fa40dcae839d1e3989012d()
        {
          this.Initialize("get_highlightColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).highlightColor;
        }
      }

      private sealed class MTHD_bcf3fd0a076545799a10e65e234aba6a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bcf3fd0a076545799a10e65e234aba6a()
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

      private sealed class MTHD_b9ee258cb13e443c91105eda208dde62 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b9ee258cb13e443c91105eda208dde62()
        {
          this.Initialize("get_highlightColor2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).highlightColor2;
        }
      }

      private sealed class MTHD_abe62c03015140c59ecf6c0c475307e7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_abe62c03015140c59ecf6c0c475307e7()
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

      private sealed class MTHD_bf75f1ffc7c34608a33fdd1fda7aa907 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bf75f1ffc7c34608a33fdd1fda7aa907()
        {
          this.Initialize("get_textStyle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textStyle;
        }
      }

      private sealed class MTHD_0da07d698cd64256967a8bce6bed0898 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0da07d698cd64256967a8bce6bed0898()
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

      private sealed class MTHD_84920568b5054ec988d73cad0f3e24ff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_84920568b5054ec988d73cad0f3e24ff()
        {
          this.Initialize("get_textSize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textSize;
        }
      }

      private sealed class MTHD_57a5755b5d4345a18c30acadc0942867 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_57a5755b5d4345a18c30acadc0942867()
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

      private sealed class MTHD_3226047bdcb14fe48d8fdcfaa2178d24 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3226047bdcb14fe48d8fdcfaa2178d24()
        {
          this.Initialize("activateInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).activateInput();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_c66f8d141cb3479885426063d6ae32da : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c66f8d141cb3479885426063d6ae32da()
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

      private sealed class MTHD_105fe8ea5430486c9dc73d690b29eac5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_105fe8ea5430486c9dc73d690b29eac5()
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

      private sealed class MTHD_aa5486fb092c4c4793418d83b53f95f6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aa5486fb092c4c4793418d83b53f95f6()
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

      private sealed class MTHD_bcdab94f0f044e789e060388736eb551 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bcdab94f0f044e789e060388736eb551()
        {
          this.Initialize("destroyHierarchy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroyHierarchy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_0ac34c00926940f08aab4b634d8ffa8a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0ac34c00926940f08aab4b634d8ffa8a()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_f3c56ed09cbf4b4dba2d73e08d9ac3bc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f3c56ed09cbf4b4dba2d73e08d9ac3bc()
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

      private sealed class MTHD_de5ed6e6b21443908441a50c524fa231 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_de5ed6e6b21443908441a50c524fa231()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_89d6aa5675364efab0ca3817d2567b81 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_89d6aa5675364efab0ca3817d2567b81()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_d2e22820b7594fe68bc80694aaaa7ac9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d2e22820b7594fe68bc80694aaaa7ac9()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_1bfd4530868c4390bb5a57fd3faafba2 : HardwiredMemberDescriptor
      {
        internal PROP_1bfd4530868c4390bb5a57fd3faafba2()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class PROP_b1e9281dadd84226b0549514f9c15dc7 : HardwiredMemberDescriptor
      {
        internal PROP_b1e9281dadd84226b0549514f9c15dc7()
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

      private sealed class PROP_231386a0a0ca4b0bb4f90f55aa736f00 : HardwiredMemberDescriptor
      {
        internal PROP_231386a0a0ca4b0bb4f90f55aa736f00()
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

      private sealed class PROP_339574a51455415299c68bd1aa31d7aa : HardwiredMemberDescriptor
      {
        internal PROP_339574a51455415299c68bd1aa31d7aa()
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

      private sealed class PROP_bbf6a7d42e864874a840a1265c99f7b2 : HardwiredMemberDescriptor
      {
        internal PROP_bbf6a7d42e864874a840a1265c99f7b2()
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

      private sealed class PROP_2c9ef8ec2c4a4804b1fc1b8d3657518d : HardwiredMemberDescriptor
      {
        internal PROP_2c9ef8ec2c4a4804b1fc1b8d3657518d()
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

      private sealed class PROP_94db860459ba4ea7b30f743d87347d07 : HardwiredMemberDescriptor
      {
        internal PROP_94db860459ba4ea7b30f743d87347d07()
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

      private sealed class PROP_01bb694bd4a04d9d8f9e0c3202a8515d : HardwiredMemberDescriptor
      {
        internal PROP_01bb694bd4a04d9d8f9e0c3202a8515d()
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

      private sealed class PROP_a651629b234c4ebeb520f225a40934e9 : HardwiredMemberDescriptor
      {
        internal PROP_a651629b234c4ebeb520f225a40934e9()
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

      private sealed class PROP_5b3f083e1c8345b599dbca6605222f0c : HardwiredMemberDescriptor
      {
        internal PROP_5b3f083e1c8345b599dbca6605222f0c()
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

      private sealed class PROP_e423ecb3d55c45e4bc1af9b2f5272998 : HardwiredMemberDescriptor
      {
        internal PROP_e423ecb3d55c45e4bc1af9b2f5272998()
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

      private sealed class PROP_331b37df254c4d329b4892f7836f00f7 : HardwiredMemberDescriptor
      {
        internal PROP_331b37df254c4d329b4892f7836f00f7()
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

      private sealed class PROP_03900ce487f54dd28ec8da5c84770e0a : HardwiredMemberDescriptor
      {
        internal PROP_03900ce487f54dd28ec8da5c84770e0a()
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

      private sealed class PROP_d2470f8439d24ee99ffb1572bb0e7cc5 : HardwiredMemberDescriptor
      {
        internal PROP_d2470f8439d24ee99ffb1572bb0e7cc5()
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

      private sealed class PROP_a0266fa47ec844949184bbbebef743f5 : HardwiredMemberDescriptor
      {
        internal PROP_a0266fa47ec844949184bbbebef743f5()
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

      private sealed class PROP_1fb1797b3bbc42c6aeaf7e7f6d9ee104 : HardwiredMemberDescriptor
      {
        internal PROP_1fb1797b3bbc42c6aeaf7e7f6d9ee104()
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

      private sealed class PROP_3dd4b70e745c411c9058fac97db587c1 : HardwiredMemberDescriptor
      {
        internal PROP_3dd4b70e745c411c9058fac97db587c1()
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

      private sealed class PROP_649f71bb576c42cfbeaface75d90dec6 : HardwiredMemberDescriptor
      {
        internal PROP_649f71bb576c42cfbeaface75d90dec6()
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

      private sealed class PROP_38a0cf2490b544dcb00027d8ef500609 : HardwiredMemberDescriptor
      {
        internal PROP_38a0cf2490b544dcb00027d8ef500609()
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

      private sealed class PROP_701b636a365f469d8bccefeb669f737d : HardwiredMemberDescriptor
      {
        internal PROP_701b636a365f469d8bccefeb669f737d()
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

      private sealed class PROP_2805dd08052c4ddf8dda3b3f834534d9 : HardwiredMemberDescriptor
      {
        internal PROP_2805dd08052c4ddf8dda3b3f834534d9()
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

      private sealed class PROP_35bdb609e94646cfb6617c9e5680cf87 : HardwiredMemberDescriptor
      {
        internal PROP_35bdb609e94646cfb6617c9e5680cf87()
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

      private sealed class PROP_4f86f682f4434965a0453450fe04459d : HardwiredMemberDescriptor
      {
        internal PROP_4f86f682f4434965a0453450fe04459d()
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

      private sealed class PROP_83f1aff975074d74bcdd53935094046a : HardwiredMemberDescriptor
      {
        internal PROP_83f1aff975074d74bcdd53935094046a()
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

      private sealed class PROP_533d60c193734dfe9e15223725749d4c : HardwiredMemberDescriptor
      {
        internal PROP_533d60c193734dfe9e15223725749d4c()
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

      private sealed class FLDV_aa57125ec5ba4664b47d41fe94d43401 : HardwiredMemberDescriptor
      {
        internal FLDV_aa57125ec5ba4664b47d41fe94d43401()
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

      private sealed class FLDV_8636b8d5f7f24fc29f5778aaab64f140 : HardwiredMemberDescriptor
      {
        internal FLDV_8636b8d5f7f24fc29f5778aaab64f140()
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

      private sealed class FLDV_b0b2d946513e4f519cd35647553faf5b : HardwiredMemberDescriptor
      {
        internal FLDV_b0b2d946513e4f519cd35647553faf5b()
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

    private sealed class TYPE_9ffe1ad970734ecbb7c260fabe857333 : HardwiredUserDataDescriptor
    {
      internal TYPE_9ffe1ad970734ecbb7c260fabe857333()
        : base(typeof (MyPoll.Item))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9ffe1ad970734ecbb7c260fabe857333.MTHD_4ac755f4122b4125911fe167c70ffe90()
        }));
        this.AddMember("addAnswer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addAnswer", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9ffe1ad970734ecbb7c260fabe857333.MTHD_9f84df849b2b4113b78c9c6618adde66()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9ffe1ad970734ecbb7c260fabe857333.MTHD_bf589c5d81f44d358cc4eab946d61af9()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9ffe1ad970734ecbb7c260fabe857333.MTHD_fc878b7ed45a4e98a953d2313a8e88a1()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9ffe1ad970734ecbb7c260fabe857333.MTHD_1e07ab6705274d8eb2bb48ef4f535adf()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9ffe1ad970734ecbb7c260fabe857333.MTHD_bf2e987bd746460cad521cfaa686006f()
        }));
        this.AddMember("question", (IMemberDescriptor) new Bridge.TYPE_9ffe1ad970734ecbb7c260fabe857333.FLDV_5c34f4b24ced439bb95e84a574a2bee4());
        this.AddMember("multipleSelection", (IMemberDescriptor) new Bridge.TYPE_9ffe1ad970734ecbb7c260fabe857333.FLDV_49e16d30abed43999a709c3c8e3f7992());
        this.AddMember("requiresAnswer", (IMemberDescriptor) new Bridge.TYPE_9ffe1ad970734ecbb7c260fabe857333.FLDV_2a579860d6824dd9a518a71d7ef1d2ae());
        this.AddMember("answers", (IMemberDescriptor) new Bridge.TYPE_9ffe1ad970734ecbb7c260fabe857333.FLDV_840d9a475d72460cb9eb1a40a465ed50());
      }

      private sealed class MTHD_4ac755f4122b4125911fe167c70ffe90 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4ac755f4122b4125911fe167c70ffe90()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Item();
        }
      }

      private sealed class MTHD_9f84df849b2b4113b78c9c6618adde66 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9f84df849b2b4113b78c9c6618adde66()
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

      private sealed class MTHD_bf589c5d81f44d358cc4eab946d61af9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bf589c5d81f44d358cc4eab946d61af9()
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

      private sealed class MTHD_fc878b7ed45a4e98a953d2313a8e88a1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fc878b7ed45a4e98a953d2313a8e88a1()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_1e07ab6705274d8eb2bb48ef4f535adf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1e07ab6705274d8eb2bb48ef4f535adf()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_bf2e987bd746460cad521cfaa686006f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bf2e987bd746460cad521cfaa686006f()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_5c34f4b24ced439bb95e84a574a2bee4 : HardwiredMemberDescriptor
      {
        internal FLDV_5c34f4b24ced439bb95e84a574a2bee4()
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

      private sealed class FLDV_49e16d30abed43999a709c3c8e3f7992 : HardwiredMemberDescriptor
      {
        internal FLDV_49e16d30abed43999a709c3c8e3f7992()
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

      private sealed class FLDV_2a579860d6824dd9a518a71d7ef1d2ae : HardwiredMemberDescriptor
      {
        internal FLDV_2a579860d6824dd9a518a71d7ef1d2ae()
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

      private sealed class FLDV_840d9a475d72460cb9eb1a40a465ed50 : HardwiredMemberDescriptor
      {
        internal FLDV_840d9a475d72460cb9eb1a40a465ed50()
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

    private sealed class TYPE_5053ebedc67844e0982f4378ac4fa5a4 : HardwiredUserDataDescriptor
    {
      internal TYPE_5053ebedc67844e0982f4378ac4fa5a4()
        : base(typeof (MyPoll.Answer))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5053ebedc67844e0982f4378ac4fa5a4.MTHD_e97ff68537f345aa9b65665068d98131()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5053ebedc67844e0982f4378ac4fa5a4.MTHD_dcdd71ea9d29426aa957097fc1fc3f8f()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5053ebedc67844e0982f4378ac4fa5a4.MTHD_f6a7d1615d1a47d09b6f49bce85274ac()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5053ebedc67844e0982f4378ac4fa5a4.MTHD_4f2011bd8a234339b9705e87da29071b()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5053ebedc67844e0982f4378ac4fa5a4.MTHD_fd81540376e24056aaa9db7ac3b433df()
        }));
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_5053ebedc67844e0982f4378ac4fa5a4.FLDV_dd487205f44c4420ab6df815c31f9edf());
        this.AddMember("allowUserInput", (IMemberDescriptor) new Bridge.TYPE_5053ebedc67844e0982f4378ac4fa5a4.FLDV_56c6f7b4bdd54119957c427ac129febf());
        this.AddMember("checkable", (IMemberDescriptor) new Bridge.TYPE_5053ebedc67844e0982f4378ac4fa5a4.FLDV_e15928a6d7824fa4935f7334a68fd859());
        this.AddMember("userInput", (IMemberDescriptor) new Bridge.TYPE_5053ebedc67844e0982f4378ac4fa5a4.FLDV_67797f6b24874ddd84ac8ade91180d56());
        this.AddMember("isChecked", (IMemberDescriptor) new Bridge.TYPE_5053ebedc67844e0982f4378ac4fa5a4.FLDV_eeea91d0b7414fcb89b922f237976724());
      }

      private sealed class MTHD_e97ff68537f345aa9b65665068d98131 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e97ff68537f345aa9b65665068d98131()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Answer();
        }
      }

      private sealed class MTHD_dcdd71ea9d29426aa957097fc1fc3f8f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dcdd71ea9d29426aa957097fc1fc3f8f()
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

      private sealed class MTHD_f6a7d1615d1a47d09b6f49bce85274ac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f6a7d1615d1a47d09b6f49bce85274ac()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_4f2011bd8a234339b9705e87da29071b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4f2011bd8a234339b9705e87da29071b()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_fd81540376e24056aaa9db7ac3b433df : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fd81540376e24056aaa9db7ac3b433df()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_dd487205f44c4420ab6df815c31f9edf : HardwiredMemberDescriptor
      {
        internal FLDV_dd487205f44c4420ab6df815c31f9edf()
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

      private sealed class FLDV_56c6f7b4bdd54119957c427ac129febf : HardwiredMemberDescriptor
      {
        internal FLDV_56c6f7b4bdd54119957c427ac129febf()
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

      private sealed class FLDV_e15928a6d7824fa4935f7334a68fd859 : HardwiredMemberDescriptor
      {
        internal FLDV_e15928a6d7824fa4935f7334a68fd859()
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

      private sealed class FLDV_67797f6b24874ddd84ac8ade91180d56 : HardwiredMemberDescriptor
      {
        internal FLDV_67797f6b24874ddd84ac8ade91180d56()
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

      private sealed class FLDV_eeea91d0b7414fcb89b922f237976724 : HardwiredMemberDescriptor
      {
        internal FLDV_eeea91d0b7414fcb89b922f237976724()
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

    private sealed class TYPE_b8643655a9c64f3394a17191ea9db170 : HardwiredUserDataDescriptor
    {
      internal TYPE_b8643655a9c64f3394a17191ea9db170()
        : base(typeof (MyPoll))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b8643655a9c64f3394a17191ea9db170.MTHD_51f2bf0c10b244caa9294085f9656d69()
        }));
        this.AddMember("GetQuestionsAsString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetQuestionsAsString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b8643655a9c64f3394a17191ea9db170.MTHD_a377f8a386c54b66bd89735ef582c005()
        }));
        this.AddMember("SanitizeResponses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("SanitizeResponses", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b8643655a9c64f3394a17191ea9db170.MTHD_01b9e2a9857649d19e3d879bbad94932()
        }));
        this.AddMember("addItem", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addItem", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b8643655a9c64f3394a17191ea9db170.MTHD_370aa7c9238c47458b1828209019ed13()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b8643655a9c64f3394a17191ea9db170.MTHD_a281104a7ef44d978d938fe8d0460950()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b8643655a9c64f3394a17191ea9db170.MTHD_00b5735b3fdf487594ddb9dfedbe8158()
        }));
        this.AddMember("fromString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fromString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b8643655a9c64f3394a17191ea9db170.MTHD_4ba899f1a1dc4f5aa1582b1b4e8e26c7()
        }));
        this.AddMember("sendToServer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("sendToServer", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b8643655a9c64f3394a17191ea9db170.MTHD_08c6877e011b49798c183c9a8509def1()
        }));
        this.AddMember("closePoll", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("closePoll", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b8643655a9c64f3394a17191ea9db170.MTHD_999dd697e8114c609d5879066fe4f660()
        }));
        this.AddMember("test", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("test", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b8643655a9c64f3394a17191ea9db170.MTHD_f1247bbc1a1e44cab70a50fe7e4e0509()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b8643655a9c64f3394a17191ea9db170.MTHD_ad635be50a544013877711dc8fc4e16e()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b8643655a9c64f3394a17191ea9db170.MTHD_5af965dffc4c4b60b8db1bb4254d1f5c()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b8643655a9c64f3394a17191ea9db170.MTHD_89c415c6337a45f19513797d139e84f1()
        }));
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_b8643655a9c64f3394a17191ea9db170.FLDV_93618f37b444422395d6a28eb9e22311());
        this.AddMember("id", (IMemberDescriptor) new Bridge.TYPE_b8643655a9c64f3394a17191ea9db170.FLDV_f46b8e8612d04818af688b7c8b489aac());
        this.AddMember("items", (IMemberDescriptor) new Bridge.TYPE_b8643655a9c64f3394a17191ea9db170.FLDV_de86dc4fa81c4484827a69d53ee12540());
        this.AddMember("isPublic", (IMemberDescriptor) new Bridge.TYPE_b8643655a9c64f3394a17191ea9db170.FLDV_ea2471bc90ac4e4e8b382275d8d91fbd());
        this.AddMember("MsgRetrieve", (IMemberDescriptor) new Bridge.TYPE_b8643655a9c64f3394a17191ea9db170.FLDV_8da67b74790e45cc9d3259ed6301e839());
        this.AddMember("MsgSubmit", (IMemberDescriptor) new Bridge.TYPE_b8643655a9c64f3394a17191ea9db170.FLDV_12eb223bdfa04edfbb2d02a3295b9ba6());
        this.AddMember("MsgCreate", (IMemberDescriptor) new Bridge.TYPE_b8643655a9c64f3394a17191ea9db170.FLDV_c8a8ed89bbf3465aaddf05db1a7a45b1());
        this.AddMember("MsgResults", (IMemberDescriptor) new Bridge.TYPE_b8643655a9c64f3394a17191ea9db170.FLDV_f2026587e0534b0eb8a9df06451a2624());
        this.AddMember("Item", (IMemberDescriptor) new Bridge.TYPE_b8643655a9c64f3394a17191ea9db170.DVAL_3f20a90fc55a4903ac4bcc707343be09());
        this.AddMember("Answer", (IMemberDescriptor) new Bridge.TYPE_b8643655a9c64f3394a17191ea9db170.DVAL_5bff7a686812418cb59a85463b3a8b8b());
      }

      private sealed class MTHD_51f2bf0c10b244caa9294085f9656d69 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_51f2bf0c10b244caa9294085f9656d69()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll();
        }
      }

      private sealed class MTHD_a377f8a386c54b66bd89735ef582c005 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a377f8a386c54b66bd89735ef582c005()
        {
          this.Initialize("GetQuestionsAsString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).GetQuestionsAsString();
        }
      }

      private sealed class MTHD_01b9e2a9857649d19e3d879bbad94932 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_01b9e2a9857649d19e3d879bbad94932()
        {
          this.Initialize("SanitizeResponses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).SanitizeResponses();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_370aa7c9238c47458b1828209019ed13 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_370aa7c9238c47458b1828209019ed13()
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

      private sealed class MTHD_a281104a7ef44d978d938fe8d0460950 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a281104a7ef44d978d938fe8d0460950()
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

      private sealed class MTHD_00b5735b3fdf487594ddb9dfedbe8158 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_00b5735b3fdf487594ddb9dfedbe8158()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).ToString();
        }
      }

      private sealed class MTHD_4ba899f1a1dc4f5aa1582b1b4e8e26c7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4ba899f1a1dc4f5aa1582b1b4e8e26c7()
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

      private sealed class MTHD_08c6877e011b49798c183c9a8509def1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_08c6877e011b49798c183c9a8509def1()
        {
          this.Initialize("sendToServer", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).sendToServer();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_999dd697e8114c609d5879066fe4f660 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_999dd697e8114c609d5879066fe4f660()
        {
          this.Initialize("closePoll", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          MyPoll.closePoll();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_f1247bbc1a1e44cab70a50fe7e4e0509 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f1247bbc1a1e44cab70a50fe7e4e0509()
        {
          this.Initialize("test", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).test();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_ad635be50a544013877711dc8fc4e16e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ad635be50a544013877711dc8fc4e16e()
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

      private sealed class MTHD_5af965dffc4c4b60b8db1bb4254d1f5c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5af965dffc4c4b60b8db1bb4254d1f5c()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_89c415c6337a45f19513797d139e84f1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_89c415c6337a45f19513797d139e84f1()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_93618f37b444422395d6a28eb9e22311 : HardwiredMemberDescriptor
      {
        internal FLDV_93618f37b444422395d6a28eb9e22311()
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

      private sealed class FLDV_f46b8e8612d04818af688b7c8b489aac : HardwiredMemberDescriptor
      {
        internal FLDV_f46b8e8612d04818af688b7c8b489aac()
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

      private sealed class FLDV_de86dc4fa81c4484827a69d53ee12540 : HardwiredMemberDescriptor
      {
        internal FLDV_de86dc4fa81c4484827a69d53ee12540()
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

      private sealed class FLDV_ea2471bc90ac4e4e8b382275d8d91fbd : HardwiredMemberDescriptor
      {
        internal FLDV_ea2471bc90ac4e4e8b382275d8d91fbd()
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

      private sealed class FLDV_8da67b74790e45cc9d3259ed6301e839 : HardwiredMemberDescriptor
      {
        internal FLDV_8da67b74790e45cc9d3259ed6301e839()
          : base(typeof (byte), "MsgRetrieve", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 1;
        }
      }

      private sealed class FLDV_12eb223bdfa04edfbb2d02a3295b9ba6 : HardwiredMemberDescriptor
      {
        internal FLDV_12eb223bdfa04edfbb2d02a3295b9ba6()
          : base(typeof (byte), "MsgSubmit", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 2;
        }
      }

      private sealed class FLDV_c8a8ed89bbf3465aaddf05db1a7a45b1 : HardwiredMemberDescriptor
      {
        internal FLDV_c8a8ed89bbf3465aaddf05db1a7a45b1()
          : base(typeof (byte), "MsgCreate", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 3;
        }
      }

      private sealed class FLDV_f2026587e0534b0eb8a9df06451a2624 : HardwiredMemberDescriptor
      {
        internal FLDV_f2026587e0534b0eb8a9df06451a2624()
          : base(typeof (byte), "MsgResults", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 4;
        }
      }

      private sealed class DVAL_3f20a90fc55a4903ac4bcc707343be09 : DynValueMemberDescriptor
      {
        internal DVAL_3f20a90fc55a4903ac4bcc707343be09()
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

      private sealed class DVAL_5bff7a686812418cb59a85463b3a8b8b : DynValueMemberDescriptor
      {
        internal DVAL_5bff7a686812418cb59a85463b3a8b8b()
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

    private sealed class TYPE_de560b42ec4c4310a3886281485c0761 : HardwiredUserDataDescriptor
    {
      internal TYPE_de560b42ec4c4310a3886281485c0761()
        : base(typeof (LuaColor))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_de560b42ec4c4310a3886281485c0761.MTHD_8fefd00fedda49ef98cd5549982cb8f0()
        }));
        this.AddMember("toHex", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("toHex", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_de560b42ec4c4310a3886281485c0761.MTHD_d575e66ddb5c4af294215227feb4da1c()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_de560b42ec4c4310a3886281485c0761.MTHD_f59395d12cdd410eb03f4c97ab79536a(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_de560b42ec4c4310a3886281485c0761.MTHD_e3f453b58127490aaefb22dacae07729()
        }));
        this.AddMember("From", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("From", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_de560b42ec4c4310a3886281485c0761.MTHD_1e7f584369a0441a8dc0e8a4e3fdcf16(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_de560b42ec4c4310a3886281485c0761.MTHD_8294ee26e14141d8b55888d7edbbf279()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_de560b42ec4c4310a3886281485c0761.MTHD_6e1722e90b9e4a828da9bccaadf4034a()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_de560b42ec4c4310a3886281485c0761.MTHD_a9288d588bec4c41995795f265e42def()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_de560b42ec4c4310a3886281485c0761.MTHD_d3d73d371b9d4f1ca784d7fad7b82cd2()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_de560b42ec4c4310a3886281485c0761.MTHD_902d28a5dfd24e0bbfcadf2505f0ac11()
        }));
        this.AddMember("r", (IMemberDescriptor) new Bridge.TYPE_de560b42ec4c4310a3886281485c0761.FLDV_d5ec9a6168ea4a93acd013c0b415d875());
        this.AddMember("g", (IMemberDescriptor) new Bridge.TYPE_de560b42ec4c4310a3886281485c0761.FLDV_73c5091ab3aa43d999c3426bea3fe08c());
        this.AddMember("b", (IMemberDescriptor) new Bridge.TYPE_de560b42ec4c4310a3886281485c0761.FLDV_584151c1e1e04dd2a74076472ace0200());
        this.AddMember("a", (IMemberDescriptor) new Bridge.TYPE_de560b42ec4c4310a3886281485c0761.FLDV_97679993b2cc40b4af367c09f6682aff());
        this.AddMember("white", (IMemberDescriptor) new Bridge.TYPE_de560b42ec4c4310a3886281485c0761.FLDV_15e246b6019d48e9bbd233266ad153d8());
      }

      private sealed class MTHD_8fefd00fedda49ef98cd5549982cb8f0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8fefd00fedda49ef98cd5549982cb8f0()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new LuaColor();
        }
      }

      private sealed class MTHD_d575e66ddb5c4af294215227feb4da1c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d575e66ddb5c4af294215227feb4da1c()
        {
          this.Initialize("toHex", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((LuaColor) obj).toHex();
        }
      }

      private sealed class MTHD_f59395d12cdd410eb03f4c97ab79536a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f59395d12cdd410eb03f4c97ab79536a()
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

      private sealed class MTHD_e3f453b58127490aaefb22dacae07729 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e3f453b58127490aaefb22dacae07729()
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

      private sealed class MTHD_1e7f584369a0441a8dc0e8a4e3fdcf16 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1e7f584369a0441a8dc0e8a4e3fdcf16()
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

      private sealed class MTHD_8294ee26e14141d8b55888d7edbbf279 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8294ee26e14141d8b55888d7edbbf279()
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

      private sealed class MTHD_6e1722e90b9e4a828da9bccaadf4034a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6e1722e90b9e4a828da9bccaadf4034a()
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

      private sealed class MTHD_a9288d588bec4c41995795f265e42def : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a9288d588bec4c41995795f265e42def()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_d3d73d371b9d4f1ca784d7fad7b82cd2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d3d73d371b9d4f1ca784d7fad7b82cd2()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_902d28a5dfd24e0bbfcadf2505f0ac11 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_902d28a5dfd24e0bbfcadf2505f0ac11()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_d5ec9a6168ea4a93acd013c0b415d875 : HardwiredMemberDescriptor
      {
        internal FLDV_d5ec9a6168ea4a93acd013c0b415d875()
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

      private sealed class FLDV_73c5091ab3aa43d999c3426bea3fe08c : HardwiredMemberDescriptor
      {
        internal FLDV_73c5091ab3aa43d999c3426bea3fe08c()
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

      private sealed class FLDV_584151c1e1e04dd2a74076472ace0200 : HardwiredMemberDescriptor
      {
        internal FLDV_584151c1e1e04dd2a74076472ace0200()
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

      private sealed class FLDV_97679993b2cc40b4af367c09f6682aff : HardwiredMemberDescriptor
      {
        internal FLDV_97679993b2cc40b4af367c09f6682aff()
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

      private sealed class FLDV_15e246b6019d48e9bbd233266ad153d8 : HardwiredMemberDescriptor
      {
        internal FLDV_15e246b6019d48e9bbd233266ad153d8()
          : base(typeof (LuaColor), "white", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) LuaColor.white;
        }
      }
    }

    private sealed class TYPE_c6301f7d9d544de284a31336bdd90d56 : HardwiredUserDataDescriptor
    {
      internal TYPE_c6301f7d9d544de284a31336bdd90d56()
        : base(typeof (TalkOptions))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c6301f7d9d544de284a31336bdd90d56.MTHD_565de6758d3f4f6f91dc6c11fee49529()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c6301f7d9d544de284a31336bdd90d56.MTHD_648b14595dd54357b82e7761d69feaac()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c6301f7d9d544de284a31336bdd90d56.MTHD_6da238b82c4447c0a751a4af0828a72a()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c6301f7d9d544de284a31336bdd90d56.MTHD_9321236f23ff45b59e87587516f930ab()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c6301f7d9d544de284a31336bdd90d56.MTHD_662a947cf4b04855b8a4a6c6da2eb514()
        }));
      }

      private sealed class MTHD_565de6758d3f4f6f91dc6c11fee49529 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_565de6758d3f4f6f91dc6c11fee49529()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new TalkOptions();
        }
      }

      private sealed class MTHD_648b14595dd54357b82e7761d69feaac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_648b14595dd54357b82e7761d69feaac()
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

      private sealed class MTHD_6da238b82c4447c0a751a4af0828a72a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6da238b82c4447c0a751a4af0828a72a()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_9321236f23ff45b59e87587516f930ab : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9321236f23ff45b59e87587516f930ab()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_662a947cf4b04855b8a4a6c6da2eb514 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_662a947cf4b04855b8a4a6c6da2eb514()
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
