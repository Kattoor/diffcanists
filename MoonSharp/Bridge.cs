
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
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_b70aa26c9a5249e8b480785dc1d21328());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_20ad0b35551f4060b236f0778bf3e9ab());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_3e21a9815bf845ceaf9c39933e2e1a03());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_6222a24e56af4b63b781a3dac3e989c6());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_f86ff89059a94cc2806d035a87eafd0d());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_ee5529fea45e46a89798cc4a8ca67fec());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_a4dd87315da540f19ca08b1413bc4f6c());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_1fb6c02699bd46af89b6fb4c62c8d3a4());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_addf20d8a1e645f38a82f913508a1eb9());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_c0b5a7388ec241d1b765077cf439c332());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_de6e718d56d849d59ef4ac096280bc0a());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_3b2e353d187240c9acc975cefd38bcf9());
    }

    private sealed class TYPE_dc234b17ff6d442b9131c96212a1462a : HardwiredUserDataDescriptor
    {
      internal TYPE_dc234b17ff6d442b9131c96212a1462a()
        : base(typeof (ContainerGame))
      {
        this.AddMember("getUser", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getUser", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_bcd84042a9fa44358597831255f4b9d0()
        }));
        this.AddMember("getPlayers", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayers", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_0d1d196b822c4107878872c2fe73ee8c()
        }));
        this.AddMember("getPlayerCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayerCount", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_58c97416019242ccb0be9a1c91e2b408()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_2e84f4bbcba248008c7c9f6be2947f42()
        }));
        this.AddMember("findCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_089cb5c1869d4a0386d011b5a049c911()
        }));
        this.AddMember("findEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findEffectors", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_6e0f70b719214a9e975f49bc79ebd757()
        }));
        this.AddMember("LineCast", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCast", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_efaed1fad7254d83bb1625e19857ead8()
        }));
        this.AddMember("LineCastOnlyCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_50bbe4d2f14e4d80a33eda048662ae5d()
        }));
        this.AddMember("LineCastOnlyTerrain", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyTerrain", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_0222117444fe4f09a25bdebf2c1957fd()
        }));
        this.AddMember("ShowInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ShowInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_06516bd0eeb94b86b2a0d4e3b1ff01fb()
        }));
        this.AddMember("hideInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("hideInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_9d2dea57738848faaeb98fd7994998cd()
        }));
        this.AddMember("Talk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Talk", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_8a768343e76943f4a52c272a309e181b()
        }));
        this.AddMember("get_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_51ae6c524fec48bd8465bfa594299c5d()
        }));
        this.AddMember("set_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_670c9abad1c84a159bc51521abe3834a()
        }));
        this.AddMember("get_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_6b5db72a7a024800ab4d61fc3b065da9()
        }));
        this.AddMember("set_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_2d7d018c8b664c8884e012a99dd0c379()
        }));
        this.AddMember("get_totalTimeElapsed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_totalTimeElapsed", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_af808d24ee9d47da8906d3610165135f()
        }));
        this.AddMember("get_turnTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnTime", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_22a0def2d12c4da7aa3f66d9b380a1cd()
        }));
        this.AddMember("get_frame", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frame", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_d9cb92f3bce44cf5b767e4c9926f5fc4()
        }));
        this.AddMember("random", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("random", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_f4a90a08f80b4e6b8bc5f60f0ee4d665()
        }));
        this.AddMember("get_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_9e4e57eae5ae49edab878c28bf2b4168()
        }));
        this.AddMember("set_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_90327fee671e4dac88ff4c08cae7517c()
        }));
        this.AddMember("get_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_2df1de0785f24f7683f3dfc5c8a017a9()
        }));
        this.AddMember("set_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_bb344856beca46d4a3424d29fffef3c9()
        }));
        this.AddMember("get_allowMinionMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMinionMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_91083f32521c4a548c5c07f1776bf46b()
        }));
        this.AddMember("set_allowMinionMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMinionMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_7a699dadcc5344a1a778bd522dbc1b8a()
        }));
        this.AddMember("get_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_554745b0845e44d9b212fa09c602fab6()
        }));
        this.AddMember("set_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_64790275fa2c4b13a224f0f164a06c66()
        }));
        this.AddMember("get_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_d6479a38ed22464eb392e258a6ba34cb()
        }));
        this.AddMember("set_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_56342ee3b3a346ffb923bb294a8b2ce9()
        }));
        this.AddMember("get_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_5afe6856d6b8427cb87ab5539c92e997()
        }));
        this.AddMember("set_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_62984e48b884417e988a1920bb286552()
        }));
        this.AddMember("get_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_001350c43ef341389da9594d8bfff099()
        }));
        this.AddMember("set_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_8eb56ecd405b42459264c8450621ffe5()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_0f12c9804d464318b7ef7999f672dd11()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_e7720c1b8cb843bbbc26037786ddd216()
        }));
        this.AddMember("get_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_53790ff92dde4dc49ded3f5d369bfde3()
        }));
        this.AddMember("set_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_f0b49e04b8f8451fbdeb0e378100debc()
        }));
        this.AddMember("get_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_189d6494a2884524abd4eea477da7ebd()
        }));
        this.AddMember("set_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_8bff4ea251ad46fda70f0809ee727157()
        }));
        this.AddMember("get_waiting", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waiting", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_317009fcd78b42b7aebb835e030c1318()
        }));
        this.AddMember("get_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_42d74f9fe606461ab630014eece1ee57()
        }));
        this.AddMember("set_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_0d3f453000a846d2902894721aad1161()
        }));
        this.AddMember("get_busy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_busy", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_7d6419a443804b1390fc40229cb013cc()
        }));
        this.AddMember("get_ongoing", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_ongoing", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_9ce1ed46868e4a65a19e50565d50654c()
        }));
        this.AddMember("get_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_d38f7f88aa8343f58d72251c683c4a2f()
        }));
        this.AddMember("set_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_ec5e175421794238ab2f5f1f6cabea59()
        }));
        this.AddMember("get_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_23f17963aa2d405fb26c9b5b182005c2()
        }));
        this.AddMember("set_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_8a2120c3cc86441d9f652602d722d9fa()
        }));
        this.AddMember("get_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_26418c441dde4045aa2f845e4e8dc663()
        }));
        this.AddMember("set_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_4f973cf778e54f1f9860332e87b11bdd()
        }));
        this.AddMember("get_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_117a2ed37af24867b143cebc59f8994d()
        }));
        this.AddMember("set_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_6666d77ab39b40af91a21a63fc697f3f()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_b94175065fbe434fb6ab63f04a9eb034()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_da872ffef3a94039ba1e4640111955e2()
        }));
        this.AddMember("get_mousePosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mousePosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_ad4fc987d70a41dd94fda675956e10dd()
        }));
        this.AddMember("get_mouseOverUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mouseOverUI", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_0d1c716d1da141209594cc631a9da3b2()
        }));
        this.AddMember("worldToCanvas", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("worldToCanvas", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_ea21ec8d08ce4b72ab8711dc5eb3cb8d()
        }));
        this.AddMember("canvasToWorld", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("canvasToWorld", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_45c1f2d6f6be405ab6f169cbffc3ae77()
        }));
        this.AddMember("get_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_52a4f8a594624f76aa1e5197799c8695()
        }));
        this.AddMember("set_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_5e7c1c2a88d3477581906751d9f163e6()
        }));
        this.AddMember("get_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_619a3ce24b924167a12487d17251bbd1()
        }));
        this.AddMember("set_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_bfdacac5ea46492c90f36b4a5cfaa4f1()
        }));
        this.AddMember("getMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_29c1b45175734447800f11ae15a9c9ce()
        }));
        this.AddMember("setMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_74f414a42e7b43fd8ea3874190d997b4()
        }));
        this.AddMember("Dispose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Dispose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_af543cffaf2d4586ae3b33cde7d21b3f()
        }));
        this.AddMember("drawImage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawImage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_76108ee35a2d44cfbb40b7e3ffd65ca0()
        }));
        this.AddMember("drawRectangle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawRectangle", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_29be795c6e8845b284d5122c62a8f7ac()
        }));
        this.AddMember("drawEllipseOutline", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipseOutline", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_8791a0bbb2234c6c9e41b76b9d5ae43b()
        }));
        this.AddMember("drawEllipse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipse", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_9a8b9d6ecc234306b619871beaf1fc4f()
        }));
        this.AddMember("blit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_cde7078c496f47469e57b62845b14507()
        }));
        this.AddMember("blitRotate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blitRotate", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_96963f69056e4600b7839cd24d453e31()
        }));
        this.AddMember("applyDraw", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("applyDraw", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_60944f3eaddc4ab8925ef41fb130c4c9()
        }));
        this.AddMember("get_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_11b82943888140e7966e7c787d4500a9()
        }));
        this.AddMember("set_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_c68f87fe81fe48d484644229962ee684()
        }));
        this.AddMember("get_isUsingTouchControls", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isUsingTouchControls", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_61bd38c8c6e94d928e5e6b729e244ff2()
        }));
        this.AddMember("clientRefreshSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clientRefreshSpells", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_328f1b71fd99452393b291c74ef8fd50()
        }));
        this.AddMember("startCoroutine", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("startCoroutine", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_a379f39b3ccd4e64adcc789b027d869d()
        }));
        this.AddMember("devCommand", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("devCommand", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_f4addcc85e154f4ab23c4a4d710eeb90()
        }));
        this.AddMember("win", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("win", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_36f9d5ec030a4420a565d5a39149bd47()
        }));
        this.AddMember("lose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("lose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_f2547ef33bf84e0a804b4293df1b18d4()
        }));
        this.AddMember("nextTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("nextTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_cfa061daef8c484da49354ddf66bd110()
        }));
        this.AddMember("resetMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("resetMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_8c133a651fec4c4c964002d689593201()
        }));
        this.AddMember("clearMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_4d2cb1805fd54ca78430fd3255ed5886()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_34cfa7ac28444a15b104508f4fff8a59()
        }));
        this.AddMember("getSpellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellEnum", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_27fabbe05dfe4246aa882f71c211af8f()
        }));
        this.AddMember("getSpellName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_cbd5b06f915d42339889481beeb0393a()
        }));
        this.AddMember("getMapID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapID", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_30adc296a2c24612a5307c5488643e80()
        }));
        this.AddMember("getMapRealName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapRealName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_0575c7c2361e4ae0813b6cf5030d015e()
        }));
        this.AddMember("getMapShortName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapShortName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_4410d86024d2427caa5d8d06dd77e4bc()
        }));
        this.AddMember("getArmageddonName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getArmageddonName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_aac8bcadde8c4eb09b8b36bf54177b36()
        }));
        this.AddMember("panCamera", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("panCamera", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_aa0baf3947c84330954c6d3c7c0921e8()
        }));
        this.AddMember("cameraFollow", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("cameraFollow", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_23b9846ffbcb4c63a0f1b5b3050df4f0()
        }));
        this.AddMember("getInputString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getInputString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_5080b8b47a0e417aa270b4282cd17714()
        }));
        this.AddMember("get_screenWidth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenWidth", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_a8dc65f1bfff469abafaa06ffbbf611f()
        }));
        this.AddMember("get_screenHeight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenHeight", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_d0fe7dc729ab44bc857ff6f81848a60a()
        }));
        this.AddMember("createCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createCreature", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_6896ee1cada347b1a27b1365b3128a96()
        }));
        this.AddMember("clearIndicators", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearIndicators", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_5e6883944da441ddb0a07bbe87e7ff8f()
        }));
        this.AddMember("createIndicator", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createIndicator", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_9e1859daa72a4a91bc9eaa581f6f4fbc(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_a186adb6321643d39c1e4bfdd4216517()
        }));
        this.AddMember("getKeyBinds", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getKeyBinds", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_6e85614c54eb404d9bc0604bdf5673b0()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_7b75a18ff67143cf9fda969813601211()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_b174228aaf9c4240ab8c9051ba3cce0e()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_fb38b7a8113e4bf2bbb74b7ba0ef4239()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.MTHD_dc602a06d6954fbc90beeab10570f5dd()
        }));
        this.AddMember("turn", (IMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.PROP_f0f71ecca3c44a07b0aaed0ab31feaa1());
        this.AddMember("timeLimit", (IMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.PROP_d131d9028b0e443bbb6c07766a0fdbca());
        this.AddMember("totalTimeElapsed", (IMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.PROP_8e411b475c1f4af39f9c13a609b43f19());
        this.AddMember("turnTime", (IMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.PROP_89a230a1d8174d43b2c5668b2c56e27b());
        this.AddMember("frame", (IMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.PROP_e0dd8472877449c4b316f826aa1b680d());
        this.AddMember("winOnDeath", (IMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.PROP_4f3dc325099848b9ac2f33998aa3f893());
        this.AddMember("allowMovement", (IMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.PROP_24ce4e78860b43239cdebd782a63494a());
        this.AddMember("allowMinionMovement", (IMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.PROP_63a442d97db04b0896807c45e6ff9feb());
        this.AddMember("allowInput", (IMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.PROP_b24688d450e54ef8b419bdec478f1349());
        this.AddMember("allowCallbacks", (IMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.PROP_cceeee28dda24481b386cdfcdb86bc07());
        this.AddMember("allowSkipTurn", (IMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.PROP_05dab2df1de74249948db06dbaa976b8());
        this.AddMember("terrainDestruction", (IMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.PROP_73429656270d4105940bed63d36ce078());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.PROP_752b9dfa4bbc445c86a56d8e65913ccf());
        this.AddMember("armageddon", (IMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.PROP_9852b2e9596b40b9abf86323ce98984a());
        this.AddMember("armageddonTurn", (IMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.PROP_c92affc99be745d89a94f6333c1078f6());
        this.AddMember("waiting", (IMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.PROP_a5c0d52e6de44a08976f4b385d37902e());
        this.AddMember("paused", (IMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.PROP_f6f33188000449b987fc8d405589ae18());
        this.AddMember("busy", (IMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.PROP_88a028a32fc24139b1807ce2012500d1());
        this.AddMember("ongoing", (IMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.PROP_8558bac2e8da4f88815ef272181209b9());
        this.AddMember("gravity", (IMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.PROP_d0a2853c82494db5b4de70dae30ab8d2());
        this.AddMember("wind", (IMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.PROP_c308bd9c29504348a535811a1876ef79());
        this.AddMember("windDir", (IMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.PROP_c34219430798424ba36acad9124feba6());
        this.AddMember("windPower", (IMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.PROP_e3c5baf8ce344732a434119e2bfd59f7());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.PROP_068223d6626447ad99e769dcc0eabf0d());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.PROP_5808c754703541c7b8262d8e549c9553());
        this.AddMember("mousePosition", (IMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.PROP_12241a5228ab4a6fb07b0e8575474aaf());
        this.AddMember("mouseOverUI", (IMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.PROP_fbe84cd348854cfb8283126cb797cbac());
        this.AddMember("cameraPosition", (IMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.PROP_5db12a31a889407a868c9751180550d5());
        this.AddMember("cameraZoom", (IMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.PROP_1ab5d44dc0194a78bcf572ff5bd46142());
        this.AddMember("allowBounce", (IMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.PROP_78d1190fc1ed4e9686348cee0004cc92());
        this.AddMember("isUsingTouchControls", (IMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.PROP_b3024012724049f38b813e85cb84c56e());
        this.AddMember("screenWidth", (IMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.PROP_3f398c3b33cf4b3a948e409a4cef0e5a());
        this.AddMember("screenHeight", (IMemberDescriptor) new Bridge.TYPE_dc234b17ff6d442b9131c96212a1462a.PROP_7c5ece392d4c46bd987d775a7f838384());
      }

      private sealed class MTHD_bcd84042a9fa44358597831255f4b9d0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bcd84042a9fa44358597831255f4b9d0()
        {
          this.Initialize("getUser", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getUser();
        }
      }

      private sealed class MTHD_0d1d196b822c4107878872c2fe73ee8c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0d1d196b822c4107878872c2fe73ee8c()
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

      private sealed class MTHD_58c97416019242ccb0be9a1c91e2b408 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_58c97416019242ccb0be9a1c91e2b408()
        {
          this.Initialize("getPlayerCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getPlayerCount();
        }
      }

      private sealed class MTHD_2e84f4bbcba248008c7c9f6be2947f42 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2e84f4bbcba248008c7c9f6be2947f42()
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

      private sealed class MTHD_089cb5c1869d4a0386d011b5a049c911 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_089cb5c1869d4a0386d011b5a049c911()
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

      private sealed class MTHD_6e0f70b719214a9e975f49bc79ebd757 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6e0f70b719214a9e975f49bc79ebd757()
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

      private sealed class MTHD_efaed1fad7254d83bb1625e19857ead8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_efaed1fad7254d83bb1625e19857ead8()
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

      private sealed class MTHD_50bbe4d2f14e4d80a33eda048662ae5d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_50bbe4d2f14e4d80a33eda048662ae5d()
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

      private sealed class MTHD_0222117444fe4f09a25bdebf2c1957fd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0222117444fe4f09a25bdebf2c1957fd()
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

      private sealed class MTHD_06516bd0eeb94b86b2a0d4e3b1ff01fb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_06516bd0eeb94b86b2a0d4e3b1ff01fb()
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

      private sealed class MTHD_9d2dea57738848faaeb98fd7994998cd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9d2dea57738848faaeb98fd7994998cd()
        {
          this.Initialize("hideInfo", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).hideInfo();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_8a768343e76943f4a52c272a309e181b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8a768343e76943f4a52c272a309e181b()
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

      private sealed class MTHD_51ae6c524fec48bd8465bfa594299c5d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_51ae6c524fec48bd8465bfa594299c5d()
        {
          this.Initialize("get_turn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turn;
        }
      }

      private sealed class MTHD_670c9abad1c84a159bc51521abe3834a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_670c9abad1c84a159bc51521abe3834a()
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

      private sealed class MTHD_6b5db72a7a024800ab4d61fc3b065da9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6b5db72a7a024800ab4d61fc3b065da9()
        {
          this.Initialize("get_timeLimit", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).timeLimit;
        }
      }

      private sealed class MTHD_2d7d018c8b664c8884e012a99dd0c379 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2d7d018c8b664c8884e012a99dd0c379()
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

      private sealed class MTHD_af808d24ee9d47da8906d3610165135f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_af808d24ee9d47da8906d3610165135f()
        {
          this.Initialize("get_totalTimeElapsed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class MTHD_22a0def2d12c4da7aa3f66d9b380a1cd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_22a0def2d12c4da7aa3f66d9b380a1cd()
        {
          this.Initialize("get_turnTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class MTHD_d9cb92f3bce44cf5b767e4c9926f5fc4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d9cb92f3bce44cf5b767e4c9926f5fc4()
        {
          this.Initialize("get_frame", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class MTHD_f4a90a08f80b4e6b8bc5f60f0ee4d665 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f4a90a08f80b4e6b8bc5f60f0ee4d665()
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

      private sealed class MTHD_9e4e57eae5ae49edab878c28bf2b4168 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9e4e57eae5ae49edab878c28bf2b4168()
        {
          this.Initialize("get_winOnDeath", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).winOnDeath;
        }
      }

      private sealed class MTHD_90327fee671e4dac88ff4c08cae7517c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_90327fee671e4dac88ff4c08cae7517c()
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

      private sealed class MTHD_2df1de0785f24f7683f3dfc5c8a017a9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2df1de0785f24f7683f3dfc5c8a017a9()
        {
          this.Initialize("get_allowMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMovement;
        }
      }

      private sealed class MTHD_bb344856beca46d4a3424d29fffef3c9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bb344856beca46d4a3424d29fffef3c9()
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

      private sealed class MTHD_91083f32521c4a548c5c07f1776bf46b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_91083f32521c4a548c5c07f1776bf46b()
        {
          this.Initialize("get_allowMinionMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMinionMovement;
        }
      }

      private sealed class MTHD_7a699dadcc5344a1a778bd522dbc1b8a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7a699dadcc5344a1a778bd522dbc1b8a()
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

      private sealed class MTHD_554745b0845e44d9b212fa09c602fab6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_554745b0845e44d9b212fa09c602fab6()
        {
          this.Initialize("get_allowInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowInput;
        }
      }

      private sealed class MTHD_64790275fa2c4b13a224f0f164a06c66 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_64790275fa2c4b13a224f0f164a06c66()
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

      private sealed class MTHD_d6479a38ed22464eb392e258a6ba34cb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d6479a38ed22464eb392e258a6ba34cb()
        {
          this.Initialize("get_allowCallbacks", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowCallbacks;
        }
      }

      private sealed class MTHD_56342ee3b3a346ffb923bb294a8b2ce9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_56342ee3b3a346ffb923bb294a8b2ce9()
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

      private sealed class MTHD_5afe6856d6b8427cb87ab5539c92e997 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5afe6856d6b8427cb87ab5539c92e997()
        {
          this.Initialize("get_allowSkipTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowSkipTurn;
        }
      }

      private sealed class MTHD_62984e48b884417e988a1920bb286552 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_62984e48b884417e988a1920bb286552()
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

      private sealed class MTHD_001350c43ef341389da9594d8bfff099 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_001350c43ef341389da9594d8bfff099()
        {
          this.Initialize("get_terrainDestruction", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).terrainDestruction;
        }
      }

      private sealed class MTHD_8eb56ecd405b42459264c8450621ffe5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8eb56ecd405b42459264c8450621ffe5()
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

      private sealed class MTHD_0f12c9804d464318b7ef7999f672dd11 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0f12c9804d464318b7ef7999f672dd11()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).takeDamage;
        }
      }

      private sealed class MTHD_e7720c1b8cb843bbbc26037786ddd216 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e7720c1b8cb843bbbc26037786ddd216()
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

      private sealed class MTHD_53790ff92dde4dc49ded3f5d369bfde3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_53790ff92dde4dc49ded3f5d369bfde3()
        {
          this.Initialize("get_armageddon", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddon;
        }
      }

      private sealed class MTHD_f0b49e04b8f8451fbdeb0e378100debc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f0b49e04b8f8451fbdeb0e378100debc()
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

      private sealed class MTHD_189d6494a2884524abd4eea477da7ebd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_189d6494a2884524abd4eea477da7ebd()
        {
          this.Initialize("get_armageddonTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddonTurn;
        }
      }

      private sealed class MTHD_8bff4ea251ad46fda70f0809ee727157 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8bff4ea251ad46fda70f0809ee727157()
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

      private sealed class MTHD_317009fcd78b42b7aebb835e030c1318 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_317009fcd78b42b7aebb835e030c1318()
        {
          this.Initialize("get_waiting", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class MTHD_42d74f9fe606461ab630014eece1ee57 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_42d74f9fe606461ab630014eece1ee57()
        {
          this.Initialize("get_paused", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).paused;
        }
      }

      private sealed class MTHD_0d3f453000a846d2902894721aad1161 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0d3f453000a846d2902894721aad1161()
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

      private sealed class MTHD_7d6419a443804b1390fc40229cb013cc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7d6419a443804b1390fc40229cb013cc()
        {
          this.Initialize("get_busy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class MTHD_9ce1ed46868e4a65a19e50565d50654c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9ce1ed46868e4a65a19e50565d50654c()
        {
          this.Initialize("get_ongoing", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class MTHD_d38f7f88aa8343f58d72251c683c4a2f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d38f7f88aa8343f58d72251c683c4a2f()
        {
          this.Initialize("get_gravity", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).gravity;
        }
      }

      private sealed class MTHD_ec5e175421794238ab2f5f1f6cabea59 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ec5e175421794238ab2f5f1f6cabea59()
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

      private sealed class MTHD_23f17963aa2d405fb26c9b5b182005c2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_23f17963aa2d405fb26c9b5b182005c2()
        {
          this.Initialize("get_wind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).wind;
        }
      }

      private sealed class MTHD_8a2120c3cc86441d9f652602d722d9fa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8a2120c3cc86441d9f652602d722d9fa()
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

      private sealed class MTHD_26418c441dde4045aa2f845e4e8dc663 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_26418c441dde4045aa2f845e4e8dc663()
        {
          this.Initialize("get_windDir", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windDir;
        }
      }

      private sealed class MTHD_4f973cf778e54f1f9860332e87b11bdd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4f973cf778e54f1f9860332e87b11bdd()
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

      private sealed class MTHD_117a2ed37af24867b143cebc59f8994d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_117a2ed37af24867b143cebc59f8994d()
        {
          this.Initialize("get_windPower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windPower;
        }
      }

      private sealed class MTHD_6666d77ab39b40af91a21a63fc697f3f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6666d77ab39b40af91a21a63fc697f3f()
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

      private sealed class MTHD_b94175065fbe434fb6ab63f04a9eb034 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b94175065fbe434fb6ab63f04a9eb034()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class MTHD_da872ffef3a94039ba1e4640111955e2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_da872ffef3a94039ba1e4640111955e2()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class MTHD_ad4fc987d70a41dd94fda675956e10dd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ad4fc987d70a41dd94fda675956e10dd()
        {
          this.Initialize("get_mousePosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class MTHD_0d1c716d1da141209594cc631a9da3b2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0d1c716d1da141209594cc631a9da3b2()
        {
          this.Initialize("get_mouseOverUI", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class MTHD_ea21ec8d08ce4b72ab8711dc5eb3cb8d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ea21ec8d08ce4b72ab8711dc5eb3cb8d()
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

      private sealed class MTHD_45c1f2d6f6be405ab6f169cbffc3ae77 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_45c1f2d6f6be405ab6f169cbffc3ae77()
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

      private sealed class MTHD_52a4f8a594624f76aa1e5197799c8695 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_52a4f8a594624f76aa1e5197799c8695()
        {
          this.Initialize("get_cameraPosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraPosition;
        }
      }

      private sealed class MTHD_5e7c1c2a88d3477581906751d9f163e6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5e7c1c2a88d3477581906751d9f163e6()
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

      private sealed class MTHD_619a3ce24b924167a12487d17251bbd1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_619a3ce24b924167a12487d17251bbd1()
        {
          this.Initialize("get_cameraZoom", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraZoom;
        }
      }

      private sealed class MTHD_bfdacac5ea46492c90f36b4a5cfaa4f1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bfdacac5ea46492c90f36b4a5cfaa4f1()
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

      private sealed class MTHD_29c1b45175734447800f11ae15a9c9ce : HardwiredMethodMemberDescriptor
      {
        internal MTHD_29c1b45175734447800f11ae15a9c9ce()
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

      private sealed class MTHD_74f414a42e7b43fd8ea3874190d997b4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_74f414a42e7b43fd8ea3874190d997b4()
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

      private sealed class MTHD_af543cffaf2d4586ae3b33cde7d21b3f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_af543cffaf2d4586ae3b33cde7d21b3f()
        {
          this.Initialize("Dispose", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ContainerGame.Dispose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_76108ee35a2d44cfbb40b7e3ffd65ca0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_76108ee35a2d44cfbb40b7e3ffd65ca0()
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

      private sealed class MTHD_29be795c6e8845b284d5122c62a8f7ac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_29be795c6e8845b284d5122c62a8f7ac()
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

      private sealed class MTHD_8791a0bbb2234c6c9e41b76b9d5ae43b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8791a0bbb2234c6c9e41b76b9d5ae43b()
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

      private sealed class MTHD_9a8b9d6ecc234306b619871beaf1fc4f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9a8b9d6ecc234306b619871beaf1fc4f()
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

      private sealed class MTHD_cde7078c496f47469e57b62845b14507 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cde7078c496f47469e57b62845b14507()
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

      private sealed class MTHD_96963f69056e4600b7839cd24d453e31 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_96963f69056e4600b7839cd24d453e31()
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

      private sealed class MTHD_60944f3eaddc4ab8925ef41fb130c4c9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_60944f3eaddc4ab8925ef41fb130c4c9()
        {
          this.Initialize("applyDraw", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).applyDraw();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_11b82943888140e7966e7c787d4500a9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_11b82943888140e7966e7c787d4500a9()
        {
          this.Initialize("get_allowBounce", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowBounce;
        }
      }

      private sealed class MTHD_c68f87fe81fe48d484644229962ee684 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c68f87fe81fe48d484644229962ee684()
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

      private sealed class MTHD_61bd38c8c6e94d928e5e6b729e244ff2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_61bd38c8c6e94d928e5e6b729e244ff2()
        {
          this.Initialize("get_isUsingTouchControls", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class MTHD_328f1b71fd99452393b291c74ef8fd50 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_328f1b71fd99452393b291c74ef8fd50()
        {
          this.Initialize("clientRefreshSpells", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clientRefreshSpells();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_a379f39b3ccd4e64adcc789b027d869d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a379f39b3ccd4e64adcc789b027d869d()
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

      private sealed class MTHD_f4addcc85e154f4ab23c4a4d710eeb90 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f4addcc85e154f4ab23c4a4d710eeb90()
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

      private sealed class MTHD_36f9d5ec030a4420a565d5a39149bd47 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_36f9d5ec030a4420a565d5a39149bd47()
        {
          this.Initialize("win", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).win();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_f2547ef33bf84e0a804b4293df1b18d4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f2547ef33bf84e0a804b4293df1b18d4()
        {
          this.Initialize("lose", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).lose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_cfa061daef8c484da49354ddf66bd110 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cfa061daef8c484da49354ddf66bd110()
        {
          this.Initialize("nextTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).nextTurn();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_8c133a651fec4c4c964002d689593201 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8c133a651fec4c4c964002d689593201()
        {
          this.Initialize("resetMap", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).resetMap();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_4d2cb1805fd54ca78430fd3255ed5886 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4d2cb1805fd54ca78430fd3255ed5886()
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

      private sealed class MTHD_34cfa7ac28444a15b104508f4fff8a59 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_34cfa7ac28444a15b104508f4fff8a59()
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

      private sealed class MTHD_27fabbe05dfe4246aa882f71c211af8f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_27fabbe05dfe4246aa882f71c211af8f()
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

      private sealed class MTHD_cbd5b06f915d42339889481beeb0393a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cbd5b06f915d42339889481beeb0393a()
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

      private sealed class MTHD_30adc296a2c24612a5307c5488643e80 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_30adc296a2c24612a5307c5488643e80()
        {
          this.Initialize("getMapID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getMapID();
        }
      }

      private sealed class MTHD_0575c7c2361e4ae0813b6cf5030d015e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0575c7c2361e4ae0813b6cf5030d015e()
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

      private sealed class MTHD_4410d86024d2427caa5d8d06dd77e4bc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4410d86024d2427caa5d8d06dd77e4bc()
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

      private sealed class MTHD_aac8bcadde8c4eb09b8b36bf54177b36 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aac8bcadde8c4eb09b8b36bf54177b36()
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

      private sealed class MTHD_aa0baf3947c84330954c6d3c7c0921e8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aa0baf3947c84330954c6d3c7c0921e8()
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

      private sealed class MTHD_23b9846ffbcb4c63a0f1b5b3050df4f0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_23b9846ffbcb4c63a0f1b5b3050df4f0()
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

      private sealed class MTHD_5080b8b47a0e417aa270b4282cd17714 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5080b8b47a0e417aa270b4282cd17714()
        {
          this.Initialize("getInputString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getInputString();
        }
      }

      private sealed class MTHD_a8dc65f1bfff469abafaa06ffbbf611f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a8dc65f1bfff469abafaa06ffbbf611f()
        {
          this.Initialize("get_screenWidth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class MTHD_d0fe7dc729ab44bc857ff6f81848a60a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d0fe7dc729ab44bc857ff6f81848a60a()
        {
          this.Initialize("get_screenHeight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }

      private sealed class MTHD_6896ee1cada347b1a27b1365b3128a96 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6896ee1cada347b1a27b1365b3128a96()
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

      private sealed class MTHD_5e6883944da441ddb0a07bbe87e7ff8f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5e6883944da441ddb0a07bbe87e7ff8f()
        {
          this.Initialize("clearIndicators", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clearIndicators();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_9e1859daa72a4a91bc9eaa581f6f4fbc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9e1859daa72a4a91bc9eaa581f6f4fbc()
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

      private sealed class MTHD_a186adb6321643d39c1e4bfdd4216517 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a186adb6321643d39c1e4bfdd4216517()
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

      private sealed class MTHD_6e85614c54eb404d9bc0604bdf5673b0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6e85614c54eb404d9bc0604bdf5673b0()
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

      private sealed class MTHD_7b75a18ff67143cf9fda969813601211 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7b75a18ff67143cf9fda969813601211()
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

      private sealed class MTHD_b174228aaf9c4240ab8c9051ba3cce0e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b174228aaf9c4240ab8c9051ba3cce0e()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_fb38b7a8113e4bf2bbb74b7ba0ef4239 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fb38b7a8113e4bf2bbb74b7ba0ef4239()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_dc602a06d6954fbc90beeab10570f5dd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dc602a06d6954fbc90beeab10570f5dd()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_f0f71ecca3c44a07b0aaed0ab31feaa1 : HardwiredMemberDescriptor
      {
        internal PROP_f0f71ecca3c44a07b0aaed0ab31feaa1()
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

      private sealed class PROP_d131d9028b0e443bbb6c07766a0fdbca : HardwiredMemberDescriptor
      {
        internal PROP_d131d9028b0e443bbb6c07766a0fdbca()
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

      private sealed class PROP_8e411b475c1f4af39f9c13a609b43f19 : HardwiredMemberDescriptor
      {
        internal PROP_8e411b475c1f4af39f9c13a609b43f19()
          : base(typeof (double), "totalTimeElapsed", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class PROP_89a230a1d8174d43b2c5668b2c56e27b : HardwiredMemberDescriptor
      {
        internal PROP_89a230a1d8174d43b2c5668b2c56e27b()
          : base(typeof (double), "turnTime", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class PROP_e0dd8472877449c4b316f826aa1b680d : HardwiredMemberDescriptor
      {
        internal PROP_e0dd8472877449c4b316f826aa1b680d()
          : base(typeof (int), "frame", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class PROP_4f3dc325099848b9ac2f33998aa3f893 : HardwiredMemberDescriptor
      {
        internal PROP_4f3dc325099848b9ac2f33998aa3f893()
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

      private sealed class PROP_24ce4e78860b43239cdebd782a63494a : HardwiredMemberDescriptor
      {
        internal PROP_24ce4e78860b43239cdebd782a63494a()
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

      private sealed class PROP_63a442d97db04b0896807c45e6ff9feb : HardwiredMemberDescriptor
      {
        internal PROP_63a442d97db04b0896807c45e6ff9feb()
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

      private sealed class PROP_b24688d450e54ef8b419bdec478f1349 : HardwiredMemberDescriptor
      {
        internal PROP_b24688d450e54ef8b419bdec478f1349()
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

      private sealed class PROP_cceeee28dda24481b386cdfcdb86bc07 : HardwiredMemberDescriptor
      {
        internal PROP_cceeee28dda24481b386cdfcdb86bc07()
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

      private sealed class PROP_05dab2df1de74249948db06dbaa976b8 : HardwiredMemberDescriptor
      {
        internal PROP_05dab2df1de74249948db06dbaa976b8()
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

      private sealed class PROP_73429656270d4105940bed63d36ce078 : HardwiredMemberDescriptor
      {
        internal PROP_73429656270d4105940bed63d36ce078()
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

      private sealed class PROP_752b9dfa4bbc445c86a56d8e65913ccf : HardwiredMemberDescriptor
      {
        internal PROP_752b9dfa4bbc445c86a56d8e65913ccf()
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

      private sealed class PROP_9852b2e9596b40b9abf86323ce98984a : HardwiredMemberDescriptor
      {
        internal PROP_9852b2e9596b40b9abf86323ce98984a()
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

      private sealed class PROP_c92affc99be745d89a94f6333c1078f6 : HardwiredMemberDescriptor
      {
        internal PROP_c92affc99be745d89a94f6333c1078f6()
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

      private sealed class PROP_a5c0d52e6de44a08976f4b385d37902e : HardwiredMemberDescriptor
      {
        internal PROP_a5c0d52e6de44a08976f4b385d37902e()
          : base(typeof (bool), "waiting", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class PROP_f6f33188000449b987fc8d405589ae18 : HardwiredMemberDescriptor
      {
        internal PROP_f6f33188000449b987fc8d405589ae18()
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

      private sealed class PROP_88a028a32fc24139b1807ce2012500d1 : HardwiredMemberDescriptor
      {
        internal PROP_88a028a32fc24139b1807ce2012500d1()
          : base(typeof (bool), "busy", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class PROP_8558bac2e8da4f88815ef272181209b9 : HardwiredMemberDescriptor
      {
        internal PROP_8558bac2e8da4f88815ef272181209b9()
          : base(typeof (bool), "ongoing", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class PROP_d0a2853c82494db5b4de70dae30ab8d2 : HardwiredMemberDescriptor
      {
        internal PROP_d0a2853c82494db5b4de70dae30ab8d2()
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

      private sealed class PROP_c308bd9c29504348a535811a1876ef79 : HardwiredMemberDescriptor
      {
        internal PROP_c308bd9c29504348a535811a1876ef79()
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

      private sealed class PROP_c34219430798424ba36acad9124feba6 : HardwiredMemberDescriptor
      {
        internal PROP_c34219430798424ba36acad9124feba6()
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

      private sealed class PROP_e3c5baf8ce344732a434119e2bfd59f7 : HardwiredMemberDescriptor
      {
        internal PROP_e3c5baf8ce344732a434119e2bfd59f7()
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

      private sealed class PROP_068223d6626447ad99e769dcc0eabf0d : HardwiredMemberDescriptor
      {
        internal PROP_068223d6626447ad99e769dcc0eabf0d()
          : base(typeof (int), "width", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class PROP_5808c754703541c7b8262d8e549c9553 : HardwiredMemberDescriptor
      {
        internal PROP_5808c754703541c7b8262d8e549c9553()
          : base(typeof (int), "height", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class PROP_12241a5228ab4a6fb07b0e8575474aaf : HardwiredMemberDescriptor
      {
        internal PROP_12241a5228ab4a6fb07b0e8575474aaf()
          : base(typeof (Educative.Point), "mousePosition", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class PROP_fbe84cd348854cfb8283126cb797cbac : HardwiredMemberDescriptor
      {
        internal PROP_fbe84cd348854cfb8283126cb797cbac()
          : base(typeof (bool), "mouseOverUI", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class PROP_5db12a31a889407a868c9751180550d5 : HardwiredMemberDescriptor
      {
        internal PROP_5db12a31a889407a868c9751180550d5()
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

      private sealed class PROP_1ab5d44dc0194a78bcf572ff5bd46142 : HardwiredMemberDescriptor
      {
        internal PROP_1ab5d44dc0194a78bcf572ff5bd46142()
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

      private sealed class PROP_78d1190fc1ed4e9686348cee0004cc92 : HardwiredMemberDescriptor
      {
        internal PROP_78d1190fc1ed4e9686348cee0004cc92()
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

      private sealed class PROP_b3024012724049f38b813e85cb84c56e : HardwiredMemberDescriptor
      {
        internal PROP_b3024012724049f38b813e85cb84c56e()
          : base(typeof (bool), "isUsingTouchControls", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class PROP_3f398c3b33cf4b3a948e409a4cef0e5a : HardwiredMemberDescriptor
      {
        internal PROP_3f398c3b33cf4b3a948e409a4cef0e5a()
          : base(typeof (double), "screenWidth", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class PROP_7c5ece392d4c46bd987d775a7f838384 : HardwiredMemberDescriptor
      {
        internal PROP_7c5ece392d4c46bd987d775a7f838384()
          : base(typeof (double), "screenHeight", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }
    }

    private sealed class TYPE_b70aa26c9a5249e8b480785dc1d21328 : HardwiredUserDataDescriptor
    {
      internal TYPE_b70aa26c9a5249e8b480785dc1d21328()
        : base(typeof (ContainerPlayer))
      {
        this.AddMember("get_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b70aa26c9a5249e8b480785dc1d21328.MTHD_bd21db26aaf54eeb91352d5c97827935()
        }));
        this.AddMember("set_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b70aa26c9a5249e8b480785dc1d21328.MTHD_ab4562ee3a61435390cfaeec0b8feada()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b70aa26c9a5249e8b480785dc1d21328.MTHD_7ffc173e695e4e5b97be05104ec55937()
        }));
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b70aa26c9a5249e8b480785dc1d21328.MTHD_182c894d37a447f8bf1704f0dd996e65()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b70aa26c9a5249e8b480785dc1d21328.MTHD_15f7b704915e420aad4032092fdfb096()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b70aa26c9a5249e8b480785dc1d21328.MTHD_dabf000287b4493e96960a169c426f08()
        }));
        this.AddMember("getCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreature", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b70aa26c9a5249e8b480785dc1d21328.MTHD_848a6932b3ee4625aae5ffd02f90c7fc()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b70aa26c9a5249e8b480785dc1d21328.MTHD_050279fbb0e847b68372073b1c56d619()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b70aa26c9a5249e8b480785dc1d21328.MTHD_3b7f4bc38a82423f9135ff3afcee7928()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b70aa26c9a5249e8b480785dc1d21328.MTHD_2c4d8937ddda4c6fb151273166b40783()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b70aa26c9a5249e8b480785dc1d21328.MTHD_bf92c8bf8b674d889db76a7a23844e35()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b70aa26c9a5249e8b480785dc1d21328.MTHD_5b0d5ddb719f441e94990cbf35ce5a7e()
        }));
        this.AddMember("localTurn", (IMemberDescriptor) new Bridge.TYPE_b70aa26c9a5249e8b480785dc1d21328.PROP_c1c4369b4888443d8784ebff6f20c298());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_b70aa26c9a5249e8b480785dc1d21328.PROP_f4c5343250784d2a9f51d9b276ad6031());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_b70aa26c9a5249e8b480785dc1d21328.PROP_4119cc073ea5487787bcb2cc190a9a94());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_b70aa26c9a5249e8b480785dc1d21328.PROP_4c2abd50e5094edcad7c557c9f5de13e());
      }

      private sealed class MTHD_bd21db26aaf54eeb91352d5c97827935 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bd21db26aaf54eeb91352d5c97827935()
        {
          this.Initialize("get_localTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).localTurn;
        }
      }

      private sealed class MTHD_ab4562ee3a61435390cfaeec0b8feada : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ab4562ee3a61435390cfaeec0b8feada()
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

      private sealed class MTHD_7ffc173e695e4e5b97be05104ec55937 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7ffc173e695e4e5b97be05104ec55937()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class MTHD_182c894d37a447f8bf1704f0dd996e65 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_182c894d37a447f8bf1704f0dd996e65()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class MTHD_15f7b704915e420aad4032092fdfb096 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_15f7b704915e420aad4032092fdfb096()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }

      private sealed class MTHD_dabf000287b4493e96960a169c426f08 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dabf000287b4493e96960a169c426f08()
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

      private sealed class MTHD_848a6932b3ee4625aae5ffd02f90c7fc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_848a6932b3ee4625aae5ffd02f90c7fc()
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

      private sealed class MTHD_050279fbb0e847b68372073b1c56d619 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_050279fbb0e847b68372073b1c56d619()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).getMinionCount();
        }
      }

      private sealed class MTHD_3b7f4bc38a82423f9135ff3afcee7928 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3b7f4bc38a82423f9135ff3afcee7928()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).GetHashCode();
        }
      }

      private sealed class MTHD_2c4d8937ddda4c6fb151273166b40783 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2c4d8937ddda4c6fb151273166b40783()
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

      private sealed class MTHD_bf92c8bf8b674d889db76a7a23844e35 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bf92c8bf8b674d889db76a7a23844e35()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_5b0d5ddb719f441e94990cbf35ce5a7e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5b0d5ddb719f441e94990cbf35ce5a7e()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_c1c4369b4888443d8784ebff6f20c298 : HardwiredMemberDescriptor
      {
        internal PROP_c1c4369b4888443d8784ebff6f20c298()
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

      private sealed class PROP_f4c5343250784d2a9f51d9b276ad6031 : HardwiredMemberDescriptor
      {
        internal PROP_f4c5343250784d2a9f51d9b276ad6031()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class PROP_4119cc073ea5487787bcb2cc190a9a94 : HardwiredMemberDescriptor
      {
        internal PROP_4119cc073ea5487787bcb2cc190a9a94()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class PROP_4c2abd50e5094edcad7c557c9f5de13e : HardwiredMemberDescriptor
      {
        internal PROP_4c2abd50e5094edcad7c557c9f5de13e()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }
    }

    private sealed class TYPE_403821ab3dd34920bb92c9172c2a9402 : HardwiredUserDataDescriptor
    {
      internal TYPE_403821ab3dd34920bb92c9172c2a9402()
        : base(typeof (ContainerCreature))
      {
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_42cdc816e4354db28f9df0f168cb4c2e()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_4dbdcf1ca6a64dadba2c2ea1540b70d1()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_691fbdc307c14077b4570575c9dfc921()
        }));
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_1231aa0350cd42ba9b4d1b29f8fce7be()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_4d9b86002757424c87f83ef89ef185f6()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_80c83cd96ea14a648e2f0c6a82800a5f()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_bacec6b128754e78b76901b8b2444ef6()
        }));
        this.AddMember("get_healthAndTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_healthAndTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_b7ad4e3208cf46e09cd9d0375f3041e7()
        }));
        this.AddMember("get_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_a3162e90b2f9451c8d1033983a6b4c42()
        }));
        this.AddMember("set_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_bf3c9af6154a4a6cb73814cb5a68905c()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_2a1808bd3a0a481da4a78aa1df03fadf()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_0336574e72a046149bf595776c6dbf29()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_7f4523b92ba7421daabaff551b2371c4()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_16dd0c97fea94139ae26ee3822b1a781()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_e92ea0437be1487d94f8413f7204919e()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_d9b89eb08a1a40f6af123432f42f7287()
        }));
        this.AddMember("get_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_4cfb4cee4e1848fbb7457f3d19e94a28()
        }));
        this.AddMember("set_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_11810f3fd2e24c3aa286e8ec095b1883()
        }));
        this.AddMember("get_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_516e740be27840d0ba13c4ebb27ba74c()
        }));
        this.AddMember("set_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_6edf667f25734402b2460f2abd521c74()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_43772526a5094d3caae17861a7470a45()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_50abfe4f981643b0b88843028bee6c4e()
        }));
        this.AddMember("get_inTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_1fb06db78aac4cc99fc575a09bb272c4()
        }));
        this.AddMember("get_isMoving", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMoving", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_4d6ee4149d4d4812b68385d1caf666a6()
        }));
        this.AddMember("get_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_1ed79d5d72554237aeb17cf84b7ff10d()
        }));
        this.AddMember("set_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_faebec06b9b341759dcd7cd327e450d3()
        }));
        this.AddMember("get_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_f07614be898b4752a7f8e5570891f5a5()
        }));
        this.AddMember("set_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_570e08ec2c9445be84d8fe17af51f32e()
        }));
        this.AddMember("get_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_3f15f501c2fb41a8a28e1ae0f25b04f0()
        }));
        this.AddMember("set_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_713be17ea4624069a717c48c1aee6129()
        }));
        this.AddMember("get_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_77b92c8df4fc43d2b71204fc4afdd344()
        }));
        this.AddMember("set_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_ec86a82ab9c74d07a70daaee8e8861c6()
        }));
        this.AddMember("get_inWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_8f9e89d1e2674cde9b48a5824a6e726c()
        }));
        this.AddMember("get_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_d560e3e22f1e4e3ba881c56a0a794ac3()
        }));
        this.AddMember("set_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_ee86e9a6c0484fd2847e2dbecfc80bd5()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_0a963ee29a4247fab7b0513c4509a093()
        }));
        this.AddMember("set_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_bb78cbd06a2b4dd2a67be459b8b5f321()
        }));
        this.AddMember("get_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_a01b9128e4954fee9621b51f342dcb02()
        }));
        this.AddMember("set_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_464479658d5f40a1a7670c9d95057d78()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_e568bd90887f44a880684812ca0996d5()
        }));
        this.AddMember("get_isRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_56d1d43e52604d35936ec0124f46d647()
        }));
        this.AddMember("get_isMounted", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMounted", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_3705577d6cb8485d9ae8080fcc3a4811()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_b63aedfe81f149299eb976e3d3dff339()
        }));
        this.AddMember("get_isPawn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPawn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_3a1c31af119e45efbb3bccb1cb3d1053()
        }));
        this.AddMember("get_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_1568dde90dfd40e78e6b8d2ed54f27f6()
        }));
        this.AddMember("set_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_27b252a841934e9caa5b160c853781a4()
        }));
        this.AddMember("get_isMountable", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMountable", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_140b7c0677bb40e9baaefd08403a5b3d()
        }));
        this.AddMember("get_canMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_canMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_579f2c41232249d88f9c6a92bbc8febb()
        }));
        this.AddMember("get_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_309042a946c4494cb02b4b4348c297ca()
        }));
        this.AddMember("set_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_e7edc34e9bc24b4c87dfbc94df60f28c()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_f682631d905048c8b9ccb77a6339409f()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_e0463dcf2dcf49c3ba4ff966718913ba()
        }));
        this.AddMember("getRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_9ad81f2f6fdf447fb043661c1f2e1fd7()
        }));
        this.AddMember("getMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_989812ec254949639aec150d9e8d081e()
        }));
        this.AddMember("getTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_18b64c36b9e643b6bc8d2043b532bf21()
        }));
        this.AddMember("LongJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LongJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_7c0073edb9a94d4fa4ccb6dd5c1240f2()
        }));
        this.AddMember("HighJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("HighJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_90e4e04420494d0aa6dd560a3ae96eac()
        }));
        this.AddMember("Walk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Walk", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_d9fb5437d5a9453c8553e55178c9150f()
        }));
        this.AddMember("setDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_4c8fd05c8e1c4d53a951237e6999f8a2()
        }));
        this.AddMember("getDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_a6f1ab97992e42eb99c213a20a5d59a3()
        }));
        this.AddMember("getFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_e9077ccf4a514fd5a67baa42b03d3366()
        }));
        this.AddMember("getActivateableFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_031f1424ee934e928ff79c23f63a2bef()
        }));
        this.AddMember("getActivateableFamiliarBookID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarBookID", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_80c173affc7247b5b1adeedabf86d2fc()
        }));
        this.AddMember("increaseFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("increaseFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_58369b2141eb45fc965ec68061a4e1f1()
        }));
        this.AddMember("inside", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("inside", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_accc88dea66b47b3bb4536a010ee81f8(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_b2812d5e7fb84bdeaa31b2862931ee0b()
        }));
        this.AddMember("overlap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("overlap", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_29420b2155414614985ecd87ccc63f44(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_781418458c3f4977a31e10482f2016cc()
        }));
        this.AddMember("die", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("die", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_aa33753dcf8d4a8d94a1b2d14765ba77()
        }));
        this.AddMember("addSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_ea2030c067cf461b856fbf13954e0681()
        }));
        this.AddMember("removeSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("removeSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_eea1bedf745847a1a2016b3ff954a333(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_13c145fb53b4462e87310a966e824638()
        }));
        this.AddMember("getSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpells", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_9bf508879b14495483b81232d929c752()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_d766e323f33942f8abeab7b701b38a7b()
        }));
        this.AddMember("getSpellCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_05f3ac3565dc4ce19e2891374b31556b()
        }));
        this.AddMember("castedCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_a7a344043e294701a3f27949b6482c43()
        }));
        this.AddMember("castedCountThisTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCountThisTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_41555587714240caba518df7a6ba4794()
        }));
        this.AddMember("castedDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_b3139684166a441791cc0b947577776f()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_5cd998e60df74b03a26beb4a0292e537()
        }));
        this.AddMember("castSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_d61299493c114e688bb4d1ef5f67a305()
        }));
        this.AddMember("angleToFire", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("angleToFire", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_9e575a599ace40a6ae7868313497f77b()
        }));
        this.AddMember("powerToFire", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("powerToFire", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_1db23496881141fe91977d7f4a372ee2()
        }));
        this.AddMember("fireAt", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fireAt", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_a27ba396f8004f41881fb02269ddd0b0(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_7ed1818daaa54956bd8ca786e6412c3e()
        }));
        this.AddMember("getEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getEffectors", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_3c21747a4be14312a6d29bcb25a0d5f3(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_9a3e4e49d28b4d78a295b193fc8cee3e()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_b8a79879ae5c4c6facf5bc3b3f2c66f4()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_27820ebc719441698adb80334b41d6ea()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_ff7bc8f77ddc44aca0c78e9367824dcf()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_558f866c55704d29bb3741d6ca536896()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_46ed5839c6604f3c881cc90824c96ba5()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.MTHD_cad7a0d2155f4a5caa588b69fccd3dba()
        }));
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.PROP_b972a8b111a44ecd8a71bcec0d121bc5());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.PROP_0a4739ec3f854d718fd46398bad4d786());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.PROP_95308bb0896f472caf829de7902af222());
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.PROP_14093d03a1e143fcae93b84df16ded2d());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.PROP_61097e117f3b4b2e808b560f5e2f8d45());
        this.AddMember("healthAndTower", (IMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.PROP_c08f014d0eea44dfa70107d91faed845());
        this.AddMember("shield", (IMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.PROP_f3f98c41e31447488a6be8a451d7c6ef());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.PROP_43174ca388624500a8482ca3e5fdb2e1());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.PROP_e679f7daa26042d5b56dbd4017e15354());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.PROP_9685c996be834715abdcb1b7a8a13c31());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.PROP_bc619030ae834ae2bc044973ecb5d34a());
        this.AddMember("weight", (IMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.PROP_c5e0e0090e84472abc173662de7632ee());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.PROP_2eb37d5984f14d6db50d9809565a2c68());
        this.AddMember("inTower", (IMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.PROP_84ec5d2212ae433f98ea308a62eb5fe9());
        this.AddMember("isMoving", (IMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.PROP_e7dbcfb4626444c6bf992efccc908c4c());
        this.AddMember("stunned", (IMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.PROP_c741bf53871841d9a4bc73af35c976ef());
        this.AddMember("superStunned", (IMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.PROP_00b024af3f9e4a50ad3a0c1e7e8f3856());
        this.AddMember("waterWalking", (IMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.PROP_bcc4c3a060b74891abfd42d4388667df());
        this.AddMember("frostWalking", (IMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.PROP_9e811ade587d42dcab73ea8a9661db9f());
        this.AddMember("inWater", (IMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.PROP_ca3865291edb49668c848cc85fc06d6f());
        this.AddMember("diesInWater", (IMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.PROP_e6b8fbf2582f4f2d98028ce7117a0ff0());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.PROP_2e128a9e4e634745b38932dbc214e887());
        this.AddMember("race", (IMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.PROP_63bba646d9d84fb3bf6676d922fbe08c());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.PROP_6bb2004ceaba4050b2fdc6d09e79882f());
        this.AddMember("isRider", (IMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.PROP_9bff6766dfa94cf4b009c69382321eae());
        this.AddMember("isMounted", (IMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.PROP_0ca03a6544c544e7b0233552d28b0b09());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.PROP_97727ccc8c4144ceba2a67b32a342ae1());
        this.AddMember("isPawn", (IMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.PROP_15a32d6fec184714be0e0f2963dad8f6());
        this.AddMember("isFlying", (IMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.PROP_45ebb90b07df423a92cd357d09948b84());
        this.AddMember("isMountable", (IMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.PROP_c77a3e6afc0741129c52f07bfdf9397d());
        this.AddMember("canMount", (IMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.PROP_ebd68a50005a496395dbfcfd430395b5());
        this.AddMember("arcaneMonster", (IMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.PROP_7e119e29ba8a467e83158b71e7648b9f());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_403821ab3dd34920bb92c9172c2a9402.PROP_07eb0497b512474498c176236f896e26());
      }

      private sealed class MTHD_42cdc816e4354db28f9df0f168cb4c2e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_42cdc816e4354db28f9df0f168cb4c2e()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class MTHD_4dbdcf1ca6a64dadba2c2ea1540b70d1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4dbdcf1ca6a64dadba2c2ea1540b70d1()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class MTHD_691fbdc307c14077b4570575c9dfc921 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_691fbdc307c14077b4570575c9dfc921()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class MTHD_1231aa0350cd42ba9b4d1b29f8fce7be : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1231aa0350cd42ba9b4d1b29f8fce7be()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).health;
        }
      }

      private sealed class MTHD_4d9b86002757424c87f83ef89ef185f6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4d9b86002757424c87f83ef89ef185f6()
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

      private sealed class MTHD_80c83cd96ea14a648e2f0c6a82800a5f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_80c83cd96ea14a648e2f0c6a82800a5f()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).maxHealth;
        }
      }

      private sealed class MTHD_bacec6b128754e78b76901b8b2444ef6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bacec6b128754e78b76901b8b2444ef6()
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

      private sealed class MTHD_b7ad4e3208cf46e09cd9d0375f3041e7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b7ad4e3208cf46e09cd9d0375f3041e7()
        {
          this.Initialize("get_healthAndTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class MTHD_a3162e90b2f9451c8d1033983a6b4c42 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a3162e90b2f9451c8d1033983a6b4c42()
        {
          this.Initialize("get_shield", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).shield;
        }
      }

      private sealed class MTHD_bf3c9af6154a4a6cb73814cb5a68905c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bf3c9af6154a4a6cb73814cb5a68905c()
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

      private sealed class MTHD_2a1808bd3a0a481da4a78aa1df03fadf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2a1808bd3a0a481da4a78aa1df03fadf()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).x;
        }
      }

      private sealed class MTHD_0336574e72a046149bf595776c6dbf29 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0336574e72a046149bf595776c6dbf29()
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

      private sealed class MTHD_7f4523b92ba7421daabaff551b2371c4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7f4523b92ba7421daabaff551b2371c4()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).y;
        }
      }

      private sealed class MTHD_16dd0c97fea94139ae26ee3822b1a781 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_16dd0c97fea94139ae26ee3822b1a781()
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

      private sealed class MTHD_e92ea0437be1487d94f8413f7204919e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e92ea0437be1487d94f8413f7204919e()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).position;
        }
      }

      private sealed class MTHD_d9b89eb08a1a40f6af123432f42f7287 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d9b89eb08a1a40f6af123432f42f7287()
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

      private sealed class MTHD_4cfb4cee4e1848fbb7457f3d19e94a28 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4cfb4cee4e1848fbb7457f3d19e94a28()
        {
          this.Initialize("get_parent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).parent;
        }
      }

      private sealed class MTHD_11810f3fd2e24c3aa286e8ec095b1883 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_11810f3fd2e24c3aa286e8ec095b1883()
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

      private sealed class MTHD_516e740be27840d0ba13c4ebb27ba74c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_516e740be27840d0ba13c4ebb27ba74c()
        {
          this.Initialize("get_weight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).weight;
        }
      }

      private sealed class MTHD_6edf667f25734402b2460f2abd521c74 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6edf667f25734402b2460f2abd521c74()
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

      private sealed class MTHD_43772526a5094d3caae17861a7470a45 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_43772526a5094d3caae17861a7470a45()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).radius;
        }
      }

      private sealed class MTHD_50abfe4f981643b0b88843028bee6c4e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_50abfe4f981643b0b88843028bee6c4e()
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

      private sealed class MTHD_1fb06db78aac4cc99fc575a09bb272c4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1fb06db78aac4cc99fc575a09bb272c4()
        {
          this.Initialize("get_inTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class MTHD_4d6ee4149d4d4812b68385d1caf666a6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4d6ee4149d4d4812b68385d1caf666a6()
        {
          this.Initialize("get_isMoving", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class MTHD_1ed79d5d72554237aeb17cf84b7ff10d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1ed79d5d72554237aeb17cf84b7ff10d()
        {
          this.Initialize("get_stunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).stunned;
        }
      }

      private sealed class MTHD_faebec06b9b341759dcd7cd327e450d3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_faebec06b9b341759dcd7cd327e450d3()
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

      private sealed class MTHD_f07614be898b4752a7f8e5570891f5a5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f07614be898b4752a7f8e5570891f5a5()
        {
          this.Initialize("get_superStunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).superStunned;
        }
      }

      private sealed class MTHD_570e08ec2c9445be84d8fe17af51f32e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_570e08ec2c9445be84d8fe17af51f32e()
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

      private sealed class MTHD_3f15f501c2fb41a8a28e1ae0f25b04f0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3f15f501c2fb41a8a28e1ae0f25b04f0()
        {
          this.Initialize("get_waterWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).waterWalking;
        }
      }

      private sealed class MTHD_713be17ea4624069a717c48c1aee6129 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_713be17ea4624069a717c48c1aee6129()
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

      private sealed class MTHD_77b92c8df4fc43d2b71204fc4afdd344 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_77b92c8df4fc43d2b71204fc4afdd344()
        {
          this.Initialize("get_frostWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).frostWalking;
        }
      }

      private sealed class MTHD_ec86a82ab9c74d07a70daaee8e8861c6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ec86a82ab9c74d07a70daaee8e8861c6()
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

      private sealed class MTHD_8f9e89d1e2674cde9b48a5824a6e726c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8f9e89d1e2674cde9b48a5824a6e726c()
        {
          this.Initialize("get_inWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class MTHD_d560e3e22f1e4e3ba881c56a0a794ac3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d560e3e22f1e4e3ba881c56a0a794ac3()
        {
          this.Initialize("get_diesInWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).diesInWater;
        }
      }

      private sealed class MTHD_ee86e9a6c0484fd2847e2dbecfc80bd5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ee86e9a6c0484fd2847e2dbecfc80bd5()
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

      private sealed class MTHD_0a963ee29a4247fab7b0513c4509a093 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0a963ee29a4247fab7b0513c4509a093()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).type;
        }
      }

      private sealed class MTHD_bb78cbd06a2b4dd2a67be459b8b5f321 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bb78cbd06a2b4dd2a67be459b8b5f321()
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

      private sealed class MTHD_a01b9128e4954fee9621b51f342dcb02 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a01b9128e4954fee9621b51f342dcb02()
        {
          this.Initialize("get_race", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).race;
        }
      }

      private sealed class MTHD_464479658d5f40a1a7670c9d95057d78 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_464479658d5f40a1a7670c9d95057d78()
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

      private sealed class MTHD_e568bd90887f44a880684812ca0996d5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e568bd90887f44a880684812ca0996d5()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class MTHD_56d1d43e52604d35936ec0124f46d647 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_56d1d43e52604d35936ec0124f46d647()
        {
          this.Initialize("get_isRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class MTHD_3705577d6cb8485d9ae8080fcc3a4811 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3705577d6cb8485d9ae8080fcc3a4811()
        {
          this.Initialize("get_isMounted", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class MTHD_b63aedfe81f149299eb976e3d3dff339 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b63aedfe81f149299eb976e3d3dff339()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class MTHD_3a1c31af119e45efbb3bccb1cb3d1053 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3a1c31af119e45efbb3bccb1cb3d1053()
        {
          this.Initialize("get_isPawn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class MTHD_1568dde90dfd40e78e6b8d2ed54f27f6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1568dde90dfd40e78e6b8d2ed54f27f6()
        {
          this.Initialize("get_isFlying", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isFlying;
        }
      }

      private sealed class MTHD_27b252a841934e9caa5b160c853781a4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_27b252a841934e9caa5b160c853781a4()
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

      private sealed class MTHD_140b7c0677bb40e9baaefd08403a5b3d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_140b7c0677bb40e9baaefd08403a5b3d()
        {
          this.Initialize("get_isMountable", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class MTHD_579f2c41232249d88f9c6a92bbc8febb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_579f2c41232249d88f9c6a92bbc8febb()
        {
          this.Initialize("get_canMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class MTHD_309042a946c4494cb02b4b4348c297ca : HardwiredMethodMemberDescriptor
      {
        internal MTHD_309042a946c4494cb02b4b4348c297ca()
        {
          this.Initialize("get_arcaneMonster", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).arcaneMonster;
        }
      }

      private sealed class MTHD_e7edc34e9bc24b4c87dfbc94df60f28c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e7edc34e9bc24b4c87dfbc94df60f28c()
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

      private sealed class MTHD_f682631d905048c8b9ccb77a6339409f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f682631d905048c8b9ccb77a6339409f()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).takeDamage;
        }
      }

      private sealed class MTHD_e0463dcf2dcf49c3ba4ff966718913ba : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e0463dcf2dcf49c3ba4ff966718913ba()
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

      private sealed class MTHD_9ad81f2f6fdf447fb043661c1f2e1fd7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9ad81f2f6fdf447fb043661c1f2e1fd7()
        {
          this.Initialize("getRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getRider();
        }
      }

      private sealed class MTHD_989812ec254949639aec150d9e8d081e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_989812ec254949639aec150d9e8d081e()
        {
          this.Initialize("getMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMount();
        }
      }

      private sealed class MTHD_18b64c36b9e643b6bc8d2043b532bf21 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_18b64c36b9e643b6bc8d2043b532bf21()
        {
          this.Initialize("getTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getTower();
        }
      }

      private sealed class MTHD_7c0073edb9a94d4fa4ccb6dd5c1240f2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7c0073edb9a94d4fa4ccb6dd5c1240f2()
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

      private sealed class MTHD_90e4e04420494d0aa6dd560a3ae96eac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_90e4e04420494d0aa6dd560a3ae96eac()
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

      private sealed class MTHD_d9fb5437d5a9453c8553e55178c9150f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d9fb5437d5a9453c8553e55178c9150f()
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

      private sealed class MTHD_4c8fd05c8e1c4d53a951237e6999f8a2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4c8fd05c8e1c4d53a951237e6999f8a2()
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

      private sealed class MTHD_a6f1ab97992e42eb99c213a20a5d59a3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a6f1ab97992e42eb99c213a20a5d59a3()
        {
          this.Initialize("getDirection", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getDirection();
        }
      }

      private sealed class MTHD_e9077ccf4a514fd5a67baa42b03d3366 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e9077ccf4a514fd5a67baa42b03d3366()
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

      private sealed class MTHD_031f1424ee934e928ff79c23f63a2bef : HardwiredMethodMemberDescriptor
      {
        internal MTHD_031f1424ee934e928ff79c23f63a2bef()
        {
          this.Initialize("getActivateableFamiliarLevel", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarLevel();
        }
      }

      private sealed class MTHD_80c173affc7247b5b1adeedabf86d2fc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_80c173affc7247b5b1adeedabf86d2fc()
        {
          this.Initialize("getActivateableFamiliarBookID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarBookID();
        }
      }

      private sealed class MTHD_58369b2141eb45fc965ec68061a4e1f1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_58369b2141eb45fc965ec68061a4e1f1()
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

      private sealed class MTHD_accc88dea66b47b3bb4536a010ee81f8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_accc88dea66b47b3bb4536a010ee81f8()
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

      private sealed class MTHD_b2812d5e7fb84bdeaa31b2862931ee0b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b2812d5e7fb84bdeaa31b2862931ee0b()
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

      private sealed class MTHD_29420b2155414614985ecd87ccc63f44 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_29420b2155414614985ecd87ccc63f44()
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

      private sealed class MTHD_781418458c3f4977a31e10482f2016cc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_781418458c3f4977a31e10482f2016cc()
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

      private sealed class MTHD_aa33753dcf8d4a8d94a1b2d14765ba77 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aa33753dcf8d4a8d94a1b2d14765ba77()
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

      private sealed class MTHD_ea2030c067cf461b856fbf13954e0681 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ea2030c067cf461b856fbf13954e0681()
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

      private sealed class MTHD_eea1bedf745847a1a2016b3ff954a333 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eea1bedf745847a1a2016b3ff954a333()
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

      private sealed class MTHD_13c145fb53b4462e87310a966e824638 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_13c145fb53b4462e87310a966e824638()
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

      private sealed class MTHD_9bf508879b14495483b81232d929c752 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9bf508879b14495483b81232d929c752()
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

      private sealed class MTHD_d766e323f33942f8abeab7b701b38a7b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d766e323f33942f8abeab7b701b38a7b()
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

      private sealed class MTHD_05f3ac3565dc4ce19e2891374b31556b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_05f3ac3565dc4ce19e2891374b31556b()
        {
          this.Initialize("getSpellCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getSpellCount();
        }
      }

      private sealed class MTHD_a7a344043e294701a3f27949b6482c43 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a7a344043e294701a3f27949b6482c43()
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

      private sealed class MTHD_41555587714240caba518df7a6ba4794 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_41555587714240caba518df7a6ba4794()
        {
          this.Initialize("castedCountThisTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).castedCountThisTurn();
        }
      }

      private sealed class MTHD_b3139684166a441791cc0b947577776f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b3139684166a441791cc0b947577776f()
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

      private sealed class MTHD_5cd998e60df74b03a26beb4a0292e537 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5cd998e60df74b03a26beb4a0292e537()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMinionCount();
        }
      }

      private sealed class MTHD_d61299493c114e688bb4d1ef5f67a305 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d61299493c114e688bb4d1ef5f67a305()
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

      private sealed class MTHD_9e575a599ace40a6ae7868313497f77b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9e575a599ace40a6ae7868313497f77b()
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

      private sealed class MTHD_1db23496881141fe91977d7f4a372ee2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1db23496881141fe91977d7f4a372ee2()
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

      private sealed class MTHD_a27ba396f8004f41881fb02269ddd0b0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a27ba396f8004f41881fb02269ddd0b0()
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

      private sealed class MTHD_7ed1818daaa54956bd8ca786e6412c3e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7ed1818daaa54956bd8ca786e6412c3e()
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

      private sealed class MTHD_3c21747a4be14312a6d29bcb25a0d5f3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3c21747a4be14312a6d29bcb25a0d5f3()
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

      private sealed class MTHD_9a3e4e49d28b4d78a295b193fc8cee3e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9a3e4e49d28b4d78a295b193fc8cee3e()
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

      private sealed class MTHD_b8a79879ae5c4c6facf5bc3b3f2c66f4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b8a79879ae5c4c6facf5bc3b3f2c66f4()
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

      private sealed class MTHD_27820ebc719441698adb80334b41d6ea : HardwiredMethodMemberDescriptor
      {
        internal MTHD_27820ebc719441698adb80334b41d6ea()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).GetHashCode();
        }
      }

      private sealed class MTHD_ff7bc8f77ddc44aca0c78e9367824dcf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ff7bc8f77ddc44aca0c78e9367824dcf()
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

      private sealed class MTHD_558f866c55704d29bb3741d6ca536896 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_558f866c55704d29bb3741d6ca536896()
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

      private sealed class MTHD_46ed5839c6604f3c881cc90824c96ba5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_46ed5839c6604f3c881cc90824c96ba5()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_cad7a0d2155f4a5caa588b69fccd3dba : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cad7a0d2155f4a5caa588b69fccd3dba()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_b972a8b111a44ecd8a71bcec0d121bc5 : HardwiredMemberDescriptor
      {
        internal PROP_b972a8b111a44ecd8a71bcec0d121bc5()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class PROP_0a4739ec3f854d718fd46398bad4d786 : HardwiredMemberDescriptor
      {
        internal PROP_0a4739ec3f854d718fd46398bad4d786()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class PROP_95308bb0896f472caf829de7902af222 : HardwiredMemberDescriptor
      {
        internal PROP_95308bb0896f472caf829de7902af222()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class PROP_14093d03a1e143fcae93b84df16ded2d : HardwiredMemberDescriptor
      {
        internal PROP_14093d03a1e143fcae93b84df16ded2d()
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

      private sealed class PROP_61097e117f3b4b2e808b560f5e2f8d45 : HardwiredMemberDescriptor
      {
        internal PROP_61097e117f3b4b2e808b560f5e2f8d45()
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

      private sealed class PROP_c08f014d0eea44dfa70107d91faed845 : HardwiredMemberDescriptor
      {
        internal PROP_c08f014d0eea44dfa70107d91faed845()
          : base(typeof (int), "healthAndTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class PROP_f3f98c41e31447488a6be8a451d7c6ef : HardwiredMemberDescriptor
      {
        internal PROP_f3f98c41e31447488a6be8a451d7c6ef()
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

      private sealed class PROP_43174ca388624500a8482ca3e5fdb2e1 : HardwiredMemberDescriptor
      {
        internal PROP_43174ca388624500a8482ca3e5fdb2e1()
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

      private sealed class PROP_e679f7daa26042d5b56dbd4017e15354 : HardwiredMemberDescriptor
      {
        internal PROP_e679f7daa26042d5b56dbd4017e15354()
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

      private sealed class PROP_9685c996be834715abdcb1b7a8a13c31 : HardwiredMemberDescriptor
      {
        internal PROP_9685c996be834715abdcb1b7a8a13c31()
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

      private sealed class PROP_bc619030ae834ae2bc044973ecb5d34a : HardwiredMemberDescriptor
      {
        internal PROP_bc619030ae834ae2bc044973ecb5d34a()
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

      private sealed class PROP_c5e0e0090e84472abc173662de7632ee : HardwiredMemberDescriptor
      {
        internal PROP_c5e0e0090e84472abc173662de7632ee()
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

      private sealed class PROP_2eb37d5984f14d6db50d9809565a2c68 : HardwiredMemberDescriptor
      {
        internal PROP_2eb37d5984f14d6db50d9809565a2c68()
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

      private sealed class PROP_84ec5d2212ae433f98ea308a62eb5fe9 : HardwiredMemberDescriptor
      {
        internal PROP_84ec5d2212ae433f98ea308a62eb5fe9()
          : base(typeof (bool), "inTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class PROP_e7dbcfb4626444c6bf992efccc908c4c : HardwiredMemberDescriptor
      {
        internal PROP_e7dbcfb4626444c6bf992efccc908c4c()
          : base(typeof (bool), "isMoving", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class PROP_c741bf53871841d9a4bc73af35c976ef : HardwiredMemberDescriptor
      {
        internal PROP_c741bf53871841d9a4bc73af35c976ef()
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

      private sealed class PROP_00b024af3f9e4a50ad3a0c1e7e8f3856 : HardwiredMemberDescriptor
      {
        internal PROP_00b024af3f9e4a50ad3a0c1e7e8f3856()
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

      private sealed class PROP_bcc4c3a060b74891abfd42d4388667df : HardwiredMemberDescriptor
      {
        internal PROP_bcc4c3a060b74891abfd42d4388667df()
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

      private sealed class PROP_9e811ade587d42dcab73ea8a9661db9f : HardwiredMemberDescriptor
      {
        internal PROP_9e811ade587d42dcab73ea8a9661db9f()
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

      private sealed class PROP_ca3865291edb49668c848cc85fc06d6f : HardwiredMemberDescriptor
      {
        internal PROP_ca3865291edb49668c848cc85fc06d6f()
          : base(typeof (bool), "inWater", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class PROP_e6b8fbf2582f4f2d98028ce7117a0ff0 : HardwiredMemberDescriptor
      {
        internal PROP_e6b8fbf2582f4f2d98028ce7117a0ff0()
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

      private sealed class PROP_2e128a9e4e634745b38932dbc214e887 : HardwiredMemberDescriptor
      {
        internal PROP_2e128a9e4e634745b38932dbc214e887()
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

      private sealed class PROP_63bba646d9d84fb3bf6676d922fbe08c : HardwiredMemberDescriptor
      {
        internal PROP_63bba646d9d84fb3bf6676d922fbe08c()
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

      private sealed class PROP_6bb2004ceaba4050b2fdc6d09e79882f : HardwiredMemberDescriptor
      {
        internal PROP_6bb2004ceaba4050b2fdc6d09e79882f()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class PROP_9bff6766dfa94cf4b009c69382321eae : HardwiredMemberDescriptor
      {
        internal PROP_9bff6766dfa94cf4b009c69382321eae()
          : base(typeof (bool), "isRider", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class PROP_0ca03a6544c544e7b0233552d28b0b09 : HardwiredMemberDescriptor
      {
        internal PROP_0ca03a6544c544e7b0233552d28b0b09()
          : base(typeof (bool), "isMounted", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class PROP_97727ccc8c4144ceba2a67b32a342ae1 : HardwiredMemberDescriptor
      {
        internal PROP_97727ccc8c4144ceba2a67b32a342ae1()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class PROP_15a32d6fec184714be0e0f2963dad8f6 : HardwiredMemberDescriptor
      {
        internal PROP_15a32d6fec184714be0e0f2963dad8f6()
          : base(typeof (bool), "isPawn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class PROP_45ebb90b07df423a92cd357d09948b84 : HardwiredMemberDescriptor
      {
        internal PROP_45ebb90b07df423a92cd357d09948b84()
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

      private sealed class PROP_c77a3e6afc0741129c52f07bfdf9397d : HardwiredMemberDescriptor
      {
        internal PROP_c77a3e6afc0741129c52f07bfdf9397d()
          : base(typeof (bool), "isMountable", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class PROP_ebd68a50005a496395dbfcfd430395b5 : HardwiredMemberDescriptor
      {
        internal PROP_ebd68a50005a496395dbfcfd430395b5()
          : base(typeof (bool), "canMount", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class PROP_7e119e29ba8a467e83158b71e7648b9f : HardwiredMemberDescriptor
      {
        internal PROP_7e119e29ba8a467e83158b71e7648b9f()
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

      private sealed class PROP_07eb0497b512474498c176236f896e26 : HardwiredMemberDescriptor
      {
        internal PROP_07eb0497b512474498c176236f896e26()
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

    private sealed class TYPE_20ad0b35551f4060b236f0778bf3e9ab : HardwiredUserDataDescriptor
    {
      internal TYPE_20ad0b35551f4060b236f0778bf3e9ab()
        : base(typeof (ContainerEffector))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_20ad0b35551f4060b236f0778bf3e9ab.MTHD_8b77638b7b1344f3b956199cac71eb58()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_20ad0b35551f4060b236f0778bf3e9ab.MTHD_b7f2359d182b45848ca7fa41c0a4912f()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_20ad0b35551f4060b236f0778bf3e9ab.MTHD_262c7b4bcc164ee8bbfecead319b1b4b()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_20ad0b35551f4060b236f0778bf3e9ab.MTHD_653877109bae4f6a948737f8f864985e()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_20ad0b35551f4060b236f0778bf3e9ab.MTHD_44812ba3c5d541a78187bd3c599780c9()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_20ad0b35551f4060b236f0778bf3e9ab.MTHD_736c419e410445eebddae52c5e1edc4f()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_20ad0b35551f4060b236f0778bf3e9ab.MTHD_08730c0502e446f8b963f6fb67f98ec8()
        }));
        this.AddMember("get_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_20ad0b35551f4060b236f0778bf3e9ab.MTHD_80af30913fac45d0a9fa600e30804af7()
        }));
        this.AddMember("set_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_20ad0b35551f4060b236f0778bf3e9ab.MTHD_a1e2c2af5daf40f2a292b98f24142669()
        }));
        this.AddMember("get_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_20ad0b35551f4060b236f0778bf3e9ab.MTHD_f03992eee9a843968cee398bbc9db4b9()
        }));
        this.AddMember("set_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_20ad0b35551f4060b236f0778bf3e9ab.MTHD_54145f655767484c890bd7ac9541a731()
        }));
        this.AddMember("get_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_20ad0b35551f4060b236f0778bf3e9ab.MTHD_bdc026e218af481fb9a39585a7267f42()
        }));
        this.AddMember("set_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_20ad0b35551f4060b236f0778bf3e9ab.MTHD_85e4fb5c89344deeb2e0a3cd6dba1df6()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_20ad0b35551f4060b236f0778bf3e9ab.MTHD_6a2fb668f7f6499f9f286623aec43c7c()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_20ad0b35551f4060b236f0778bf3e9ab.MTHD_b93e6eabffd648059687c6da959b8afd()
        }));
        this.AddMember("turnPassed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("turnPassed", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_20ad0b35551f4060b236f0778bf3e9ab.MTHD_4c0594992e6d4ebe98fb9dd1ca095b6e()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_20ad0b35551f4060b236f0778bf3e9ab.MTHD_5167eca7c983457a91c9d977cdc92476()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_20ad0b35551f4060b236f0778bf3e9ab.MTHD_95eb423be91a4f83aa7c44e3ec1e1f93()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_20ad0b35551f4060b236f0778bf3e9ab.MTHD_9ab0bfcabfad412699f8827f55abb0d9()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_20ad0b35551f4060b236f0778bf3e9ab.MTHD_0ad88f099e664cd692e90f680b985e39()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_20ad0b35551f4060b236f0778bf3e9ab.PROP_a24b33bb2c654abbb646b3fc89f002f9());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_20ad0b35551f4060b236f0778bf3e9ab.PROP_e31b4e7f47a84dc88db66945ef437066());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_20ad0b35551f4060b236f0778bf3e9ab.PROP_c5b4fbc3fe79435381e9de9a2cd519fa());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_20ad0b35551f4060b236f0778bf3e9ab.PROP_c7ba51c83c9342cf89d3f48fb3f5272c());
        this.AddMember("turnsAlive", (IMemberDescriptor) new Bridge.TYPE_20ad0b35551f4060b236f0778bf3e9ab.PROP_d7c0db5e79a04b87ab6b55dfaef03259());
        this.AddMember("maxTurnsAlive", (IMemberDescriptor) new Bridge.TYPE_20ad0b35551f4060b236f0778bf3e9ab.PROP_568f4bdbfa204893acaabed15767fe7d());
        this.AddMember("active", (IMemberDescriptor) new Bridge.TYPE_20ad0b35551f4060b236f0778bf3e9ab.PROP_5b469d6d0800421abb2c230c145827ec());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_20ad0b35551f4060b236f0778bf3e9ab.PROP_8c5fce16af234c68bf4c15d60613ff44());
      }

      private sealed class MTHD_8b77638b7b1344f3b956199cac71eb58 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8b77638b7b1344f3b956199cac71eb58()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class MTHD_b7f2359d182b45848ca7fa41c0a4912f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b7f2359d182b45848ca7fa41c0a4912f()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).x;
        }
      }

      private sealed class MTHD_262c7b4bcc164ee8bbfecead319b1b4b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_262c7b4bcc164ee8bbfecead319b1b4b()
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

      private sealed class MTHD_653877109bae4f6a948737f8f864985e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_653877109bae4f6a948737f8f864985e()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).y;
        }
      }

      private sealed class MTHD_44812ba3c5d541a78187bd3c599780c9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_44812ba3c5d541a78187bd3c599780c9()
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

      private sealed class MTHD_736c419e410445eebddae52c5e1edc4f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_736c419e410445eebddae52c5e1edc4f()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).position;
        }
      }

      private sealed class MTHD_08730c0502e446f8b963f6fb67f98ec8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_08730c0502e446f8b963f6fb67f98ec8()
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

      private sealed class MTHD_80af30913fac45d0a9fa600e30804af7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_80af30913fac45d0a9fa600e30804af7()
        {
          this.Initialize("get_turnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).turnsAlive;
        }
      }

      private sealed class MTHD_a1e2c2af5daf40f2a292b98f24142669 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a1e2c2af5daf40f2a292b98f24142669()
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

      private sealed class MTHD_f03992eee9a843968cee398bbc9db4b9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f03992eee9a843968cee398bbc9db4b9()
        {
          this.Initialize("get_maxTurnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).maxTurnsAlive;
        }
      }

      private sealed class MTHD_54145f655767484c890bd7ac9541a731 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_54145f655767484c890bd7ac9541a731()
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

      private sealed class MTHD_bdc026e218af481fb9a39585a7267f42 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bdc026e218af481fb9a39585a7267f42()
        {
          this.Initialize("get_active", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).active;
        }
      }

      private sealed class MTHD_85e4fb5c89344deeb2e0a3cd6dba1df6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_85e4fb5c89344deeb2e0a3cd6dba1df6()
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

      private sealed class MTHD_6a2fb668f7f6499f9f286623aec43c7c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6a2fb668f7f6499f9f286623aec43c7c()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }

      private sealed class MTHD_b93e6eabffd648059687c6da959b8afd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b93e6eabffd648059687c6da959b8afd()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_4c0594992e6d4ebe98fb9dd1ca095b6e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4c0594992e6d4ebe98fb9dd1ca095b6e()
        {
          this.Initialize("turnPassed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).turnPassed();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_5167eca7c983457a91c9d977cdc92476 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5167eca7c983457a91c9d977cdc92476()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).GetHashCode();
        }
      }

      private sealed class MTHD_95eb423be91a4f83aa7c44e3ec1e1f93 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_95eb423be91a4f83aa7c44e3ec1e1f93()
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

      private sealed class MTHD_9ab0bfcabfad412699f8827f55abb0d9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9ab0bfcabfad412699f8827f55abb0d9()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_0ad88f099e664cd692e90f680b985e39 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0ad88f099e664cd692e90f680b985e39()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_a24b33bb2c654abbb646b3fc89f002f9 : HardwiredMemberDescriptor
      {
        internal PROP_a24b33bb2c654abbb646b3fc89f002f9()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class PROP_e31b4e7f47a84dc88db66945ef437066 : HardwiredMemberDescriptor
      {
        internal PROP_e31b4e7f47a84dc88db66945ef437066()
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

      private sealed class PROP_c5b4fbc3fe79435381e9de9a2cd519fa : HardwiredMemberDescriptor
      {
        internal PROP_c5b4fbc3fe79435381e9de9a2cd519fa()
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

      private sealed class PROP_c7ba51c83c9342cf89d3f48fb3f5272c : HardwiredMemberDescriptor
      {
        internal PROP_c7ba51c83c9342cf89d3f48fb3f5272c()
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

      private sealed class PROP_d7c0db5e79a04b87ab6b55dfaef03259 : HardwiredMemberDescriptor
      {
        internal PROP_d7c0db5e79a04b87ab6b55dfaef03259()
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

      private sealed class PROP_568f4bdbfa204893acaabed15767fe7d : HardwiredMemberDescriptor
      {
        internal PROP_568f4bdbfa204893acaabed15767fe7d()
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

      private sealed class PROP_5b469d6d0800421abb2c230c145827ec : HardwiredMemberDescriptor
      {
        internal PROP_5b469d6d0800421abb2c230c145827ec()
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

      private sealed class PROP_8c5fce16af234c68bf4c15d60613ff44 : HardwiredMemberDescriptor
      {
        internal PROP_8c5fce16af234c68bf4c15d60613ff44()
          : base(typeof (EffectorType), "type", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }
    }

    private sealed class TYPE_3e21a9815bf845ceaf9c39933e2e1a03 : HardwiredUserDataDescriptor
    {
      internal TYPE_3e21a9815bf845ceaf9c39933e2e1a03()
        : base(typeof (ContainerIndicator))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3e21a9815bf845ceaf9c39933e2e1a03.MTHD_7ca18c474800411abe9329c1c856ce8f()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3e21a9815bf845ceaf9c39933e2e1a03.MTHD_06dc3d1874244cef8d6c6e82329fb4ca()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3e21a9815bf845ceaf9c39933e2e1a03.MTHD_e4ac29df228e44b7964c8d0178ab7a45()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3e21a9815bf845ceaf9c39933e2e1a03.MTHD_538a49e493654f129ad9c6d2e5c46c65()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3e21a9815bf845ceaf9c39933e2e1a03.MTHD_6b8ee2035be84286ac157b32485b6743()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3e21a9815bf845ceaf9c39933e2e1a03.MTHD_f84c749751f541b9b465a50bda78f96a()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3e21a9815bf845ceaf9c39933e2e1a03.MTHD_9ce82fbac7a44117ab83750d87be6f11()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3e21a9815bf845ceaf9c39933e2e1a03.MTHD_0359b00d6a5848dc8da40ebde1777953()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3e21a9815bf845ceaf9c39933e2e1a03.MTHD_699eafd62ff74509beac86894345c6d2()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3e21a9815bf845ceaf9c39933e2e1a03.MTHD_2968a908fa154ff0a1ef9c07825b1aaf()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3e21a9815bf845ceaf9c39933e2e1a03.MTHD_f30b907932354e488e9a058b9a1253c6()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3e21a9815bf845ceaf9c39933e2e1a03.MTHD_49c2d91e612f4172b957610a95d76acf()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3e21a9815bf845ceaf9c39933e2e1a03.MTHD_c43a8cc5f8aa4219bde795ad9436e8d0()
        }));
        this.AddMember("get_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color2", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3e21a9815bf845ceaf9c39933e2e1a03.MTHD_c994b69349694586a37560c4d3ad3ff2()
        }));
        this.AddMember("set_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color2", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3e21a9815bf845ceaf9c39933e2e1a03.MTHD_c653ae5c128045018f9a98d49ff37e49()
        }));
        this.AddMember("get_kind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_kind", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3e21a9815bf845ceaf9c39933e2e1a03.MTHD_3e84efa09939454f9e3a70e430bdaaa3()
        }));
        this.AddMember("setIcon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setIcon", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3e21a9815bf845ceaf9c39933e2e1a03.MTHD_719fd504929a46889d3cc434ba039c82()
        }));
        this.AddMember("Destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Destroy", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3e21a9815bf845ceaf9c39933e2e1a03.MTHD_49cb120e1bdd46c0a9832a049e869d75()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3e21a9815bf845ceaf9c39933e2e1a03.MTHD_209a81fdfd554c5bb77bdc91ae43819b()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3e21a9815bf845ceaf9c39933e2e1a03.MTHD_247ed8f082d14c28a57d83719070c712()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3e21a9815bf845ceaf9c39933e2e1a03.MTHD_ffc69e86bb1b41efb01d2efc7d460ca4()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3e21a9815bf845ceaf9c39933e2e1a03.MTHD_2876f7f3ce0e4d81820fc31335e6b6d9()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_3e21a9815bf845ceaf9c39933e2e1a03.PROP_a1371572018a4982ae1ae448322b0f84());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_3e21a9815bf845ceaf9c39933e2e1a03.PROP_6929c983377a42b28ffc2a864d7204e5());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_3e21a9815bf845ceaf9c39933e2e1a03.PROP_2e008da05bdd47dcbca0c4bdd0f06b90());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_3e21a9815bf845ceaf9c39933e2e1a03.PROP_78796da7eb724d48993ca025344c1704());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_3e21a9815bf845ceaf9c39933e2e1a03.PROP_6b6ef88ccc514f9eba365e28915a2c33());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_3e21a9815bf845ceaf9c39933e2e1a03.PROP_6ba825f4d3bd405391cd5844829ba717());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_3e21a9815bf845ceaf9c39933e2e1a03.PROP_1b873476535b4d2481a02d2e042350e5());
        this.AddMember("color2", (IMemberDescriptor) new Bridge.TYPE_3e21a9815bf845ceaf9c39933e2e1a03.PROP_4d7901767f754a2dbcf7f02810c82c68());
        this.AddMember("kind", (IMemberDescriptor) new Bridge.TYPE_3e21a9815bf845ceaf9c39933e2e1a03.PROP_5a7b56315bc846b3aced30b59deecde5());
      }

      private sealed class MTHD_7ca18c474800411abe9329c1c856ce8f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7ca18c474800411abe9329c1c856ce8f()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class MTHD_06dc3d1874244cef8d6c6e82329fb4ca : HardwiredMethodMemberDescriptor
      {
        internal MTHD_06dc3d1874244cef8d6c6e82329fb4ca()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).x;
        }
      }

      private sealed class MTHD_e4ac29df228e44b7964c8d0178ab7a45 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e4ac29df228e44b7964c8d0178ab7a45()
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

      private sealed class MTHD_538a49e493654f129ad9c6d2e5c46c65 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_538a49e493654f129ad9c6d2e5c46c65()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).y;
        }
      }

      private sealed class MTHD_6b8ee2035be84286ac157b32485b6743 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6b8ee2035be84286ac157b32485b6743()
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

      private sealed class MTHD_f84c749751f541b9b465a50bda78f96a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f84c749751f541b9b465a50bda78f96a()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).radius;
        }
      }

      private sealed class MTHD_9ce82fbac7a44117ab83750d87be6f11 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9ce82fbac7a44117ab83750d87be6f11()
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

      private sealed class MTHD_0359b00d6a5848dc8da40ebde1777953 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0359b00d6a5848dc8da40ebde1777953()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).position;
        }
      }

      private sealed class MTHD_699eafd62ff74509beac86894345c6d2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_699eafd62ff74509beac86894345c6d2()
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

      private sealed class MTHD_2968a908fa154ff0a1ef9c07825b1aaf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2968a908fa154ff0a1ef9c07825b1aaf()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).angle;
        }
      }

      private sealed class MTHD_f30b907932354e488e9a058b9a1253c6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f30b907932354e488e9a058b9a1253c6()
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

      private sealed class MTHD_49c2d91e612f4172b957610a95d76acf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_49c2d91e612f4172b957610a95d76acf()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color;
        }
      }

      private sealed class MTHD_c43a8cc5f8aa4219bde795ad9436e8d0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c43a8cc5f8aa4219bde795ad9436e8d0()
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

      private sealed class MTHD_c994b69349694586a37560c4d3ad3ff2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c994b69349694586a37560c4d3ad3ff2()
        {
          this.Initialize("get_color2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color2;
        }
      }

      private sealed class MTHD_c653ae5c128045018f9a98d49ff37e49 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c653ae5c128045018f9a98d49ff37e49()
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

      private sealed class MTHD_3e84efa09939454f9e3a70e430bdaaa3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3e84efa09939454f9e3a70e430bdaaa3()
        {
          this.Initialize("get_kind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }

      private sealed class MTHD_719fd504929a46889d3cc434ba039c82 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_719fd504929a46889d3cc434ba039c82()
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

      private sealed class MTHD_49cb120e1bdd46c0a9832a049e869d75 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_49cb120e1bdd46c0a9832a049e869d75()
        {
          this.Initialize("Destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerIndicator) obj).Destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_209a81fdfd554c5bb77bdc91ae43819b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_209a81fdfd554c5bb77bdc91ae43819b()
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

      private sealed class MTHD_247ed8f082d14c28a57d83719070c712 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_247ed8f082d14c28a57d83719070c712()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_ffc69e86bb1b41efb01d2efc7d460ca4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ffc69e86bb1b41efb01d2efc7d460ca4()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_2876f7f3ce0e4d81820fc31335e6b6d9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2876f7f3ce0e4d81820fc31335e6b6d9()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_a1371572018a4982ae1ae448322b0f84 : HardwiredMemberDescriptor
      {
        internal PROP_a1371572018a4982ae1ae448322b0f84()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class PROP_6929c983377a42b28ffc2a864d7204e5 : HardwiredMemberDescriptor
      {
        internal PROP_6929c983377a42b28ffc2a864d7204e5()
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

      private sealed class PROP_2e008da05bdd47dcbca0c4bdd0f06b90 : HardwiredMemberDescriptor
      {
        internal PROP_2e008da05bdd47dcbca0c4bdd0f06b90()
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

      private sealed class PROP_78796da7eb724d48993ca025344c1704 : HardwiredMemberDescriptor
      {
        internal PROP_78796da7eb724d48993ca025344c1704()
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

      private sealed class PROP_6b6ef88ccc514f9eba365e28915a2c33 : HardwiredMemberDescriptor
      {
        internal PROP_6b6ef88ccc514f9eba365e28915a2c33()
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

      private sealed class PROP_6ba825f4d3bd405391cd5844829ba717 : HardwiredMemberDescriptor
      {
        internal PROP_6ba825f4d3bd405391cd5844829ba717()
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

      private sealed class PROP_1b873476535b4d2481a02d2e042350e5 : HardwiredMemberDescriptor
      {
        internal PROP_1b873476535b4d2481a02d2e042350e5()
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

      private sealed class PROP_4d7901767f754a2dbcf7f02810c82c68 : HardwiredMemberDescriptor
      {
        internal PROP_4d7901767f754a2dbcf7f02810c82c68()
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

      private sealed class PROP_5a7b56315bc846b3aced30b59deecde5 : HardwiredMemberDescriptor
      {
        internal PROP_5a7b56315bc846b3aced30b59deecde5()
          : base(typeof (IndicatorKind), "kind", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }
    }

    private sealed class TYPE_6222a24e56af4b63b781a3dac3e989c6 : HardwiredUserDataDescriptor
    {
      internal TYPE_6222a24e56af4b63b781a3dac3e989c6()
        : base(typeof (ContainerSpell))
      {
        this.AddMember("get_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6222a24e56af4b63b781a3dac3e989c6.MTHD_6b1f4feb58174993940744461e7b77ee()
        }));
        this.AddMember("set_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6222a24e56af4b63b781a3dac3e989c6.MTHD_b3799af8298d43d99f13b89b5f2c66bf()
        }));
        this.AddMember("get_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6222a24e56af4b63b781a3dac3e989c6.MTHD_6f1ad4d341f84edbbb520845a53c9e59()
        }));
        this.AddMember("set_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6222a24e56af4b63b781a3dac3e989c6.MTHD_f53e3051ef8045cc9bab8b8420fe8855()
        }));
        this.AddMember("get_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6222a24e56af4b63b781a3dac3e989c6.MTHD_e024706c1efa4c9e8c4f9a2ba66eded2()
        }));
        this.AddMember("set_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6222a24e56af4b63b781a3dac3e989c6.MTHD_9490e99cdb034fefae5572d248852761()
        }));
        this.AddMember("get_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6222a24e56af4b63b781a3dac3e989c6.MTHD_3dd0a8a87d444d52873e6ddd2d09d5ae()
        }));
        this.AddMember("set_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6222a24e56af4b63b781a3dac3e989c6.MTHD_7ecc2e3fbe184df2b18b9548fd99eb10()
        }));
        this.AddMember("get_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6222a24e56af4b63b781a3dac3e989c6.MTHD_7bc0ad4d7af54ac5b168a4c7500f247b()
        }));
        this.AddMember("set_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6222a24e56af4b63b781a3dac3e989c6.MTHD_1bcfceab8d4344b88ddc32575ba1e650()
        }));
        this.AddMember("get_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6222a24e56af4b63b781a3dac3e989c6.MTHD_dd7f905dc2354b79b3772d9474d82cd2()
        }));
        this.AddMember("set_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6222a24e56af4b63b781a3dac3e989c6.MTHD_a4ac8fad70f34be8b0b918dc2598b498()
        }));
        this.AddMember("get_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6222a24e56af4b63b781a3dac3e989c6.MTHD_90af0f3bc722437f979a1e7489b95869()
        }));
        this.AddMember("set_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6222a24e56af4b63b781a3dac3e989c6.MTHD_465a0c055ac8421a89d81c0f8da8ccfb()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6222a24e56af4b63b781a3dac3e989c6.MTHD_b64158308e5e4238a81b3e113b3f0263()
        }));
        this.AddMember("get_castType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_castType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6222a24e56af4b63b781a3dac3e989c6.MTHD_e6cb80651f434e98910551f75521a72b()
        }));
        this.AddMember("get_damageType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damageType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6222a24e56af4b63b781a3dac3e989c6.MTHD_ee90f0687bdb4b7486e1a79a6d76a4d0()
        }));
        this.AddMember("get_book", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_book", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6222a24e56af4b63b781a3dac3e989c6.MTHD_4b15300e4b0247fb9a6b40b6ede37b67()
        }));
        this.AddMember("get_damage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damage", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6222a24e56af4b63b781a3dac3e989c6.MTHD_ac533eae2d014aa382f56e38dff10f82()
        }));
        this.AddMember("get_explosionRadius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_explosionRadius", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6222a24e56af4b63b781a3dac3e989c6.MTHD_6ac049f6ebf44b11abdccbed1d99496c()
        }));
        this.AddMember("get_description", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_description", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6222a24e56af4b63b781a3dac3e989c6.MTHD_16f60eea3ddc4f569d201327a77dd035()
        }));
        this.AddMember("get_descriptionOnly", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionOnly", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6222a24e56af4b63b781a3dac3e989c6.MTHD_0788d8723a104cf998a94a7f4d4ff958()
        }));
        this.AddMember("get_descriptionExtra", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionExtra", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6222a24e56af4b63b781a3dac3e989c6.MTHD_8f8c606352104f3cbe41c7bbf4e504e3()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6222a24e56af4b63b781a3dac3e989c6.MTHD_c83cb7ecf99c4fa0b23729dc75841546()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6222a24e56af4b63b781a3dac3e989c6.MTHD_fc3e586349e94514a129da2c2cb450f6()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6222a24e56af4b63b781a3dac3e989c6.MTHD_2657863369674aadb62f497842e74105()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6222a24e56af4b63b781a3dac3e989c6.MTHD_152ae4436fff42f6bba6ef259240da50()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6222a24e56af4b63b781a3dac3e989c6.MTHD_5a16d50c5337499091c49cac3adba841()
        }));
        this.AddMember("uses", (IMemberDescriptor) new Bridge.TYPE_6222a24e56af4b63b781a3dac3e989c6.PROP_a706ab8516b744dba8cd3586e713cfcb());
        this.AddMember("maxUses", (IMemberDescriptor) new Bridge.TYPE_6222a24e56af4b63b781a3dac3e989c6.PROP_6f6da0dcf97c42949e2b878992e21c97());
        this.AddMember("rechargeTime", (IMemberDescriptor) new Bridge.TYPE_6222a24e56af4b63b781a3dac3e989c6.PROP_a9e5b87e7051423f8ff954a520363292());
        this.AddMember("lastTurnFired", (IMemberDescriptor) new Bridge.TYPE_6222a24e56af4b63b781a3dac3e989c6.PROP_2956adce01c141f49f5fd02793bf5063());
        this.AddMember("isPresent", (IMemberDescriptor) new Bridge.TYPE_6222a24e56af4b63b781a3dac3e989c6.PROP_456d66ee700e48d99629ae7b9fc767c5());
        this.AddMember("locked", (IMemberDescriptor) new Bridge.TYPE_6222a24e56af4b63b781a3dac3e989c6.PROP_97baf26986f64f148ffe0feb0ce72967());
        this.AddMember("turnsTillFirstUse", (IMemberDescriptor) new Bridge.TYPE_6222a24e56af4b63b781a3dac3e989c6.PROP_eef2d62f3bdc4ed99e05f53b208bec7a());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_6222a24e56af4b63b781a3dac3e989c6.PROP_a6a02969e4834ebcae9a1a6b630ec6ba());
        this.AddMember("castType", (IMemberDescriptor) new Bridge.TYPE_6222a24e56af4b63b781a3dac3e989c6.PROP_41dadfe6240a47ad86877acc1ea30955());
        this.AddMember("damageType", (IMemberDescriptor) new Bridge.TYPE_6222a24e56af4b63b781a3dac3e989c6.PROP_222e57a75fc54a48aa59bcf5ec21b9ed());
        this.AddMember("book", (IMemberDescriptor) new Bridge.TYPE_6222a24e56af4b63b781a3dac3e989c6.PROP_82563a0f7ea54775b60a50e677f74813());
        this.AddMember("damage", (IMemberDescriptor) new Bridge.TYPE_6222a24e56af4b63b781a3dac3e989c6.PROP_68d347d274554feba22b1f02aae4ef0a());
        this.AddMember("explosionRadius", (IMemberDescriptor) new Bridge.TYPE_6222a24e56af4b63b781a3dac3e989c6.PROP_06f6dfe5db4541bc9d3e0ab56805603f());
        this.AddMember("description", (IMemberDescriptor) new Bridge.TYPE_6222a24e56af4b63b781a3dac3e989c6.PROP_7c9db1b1b3954b508f9fa0b851eb3b28());
        this.AddMember("descriptionOnly", (IMemberDescriptor) new Bridge.TYPE_6222a24e56af4b63b781a3dac3e989c6.PROP_7482faa907fe450c88c6f0bcb92368fb());
        this.AddMember("descriptionExtra", (IMemberDescriptor) new Bridge.TYPE_6222a24e56af4b63b781a3dac3e989c6.PROP_1b6df0a2c3ab46a9b4c23b52402f2870());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_6222a24e56af4b63b781a3dac3e989c6.PROP_10bdec459e794bd5bb8d2270b4c0a448());
      }

      private sealed class MTHD_6b1f4feb58174993940744461e7b77ee : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6b1f4feb58174993940744461e7b77ee()
        {
          this.Initialize("get_uses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).uses;
        }
      }

      private sealed class MTHD_b3799af8298d43d99f13b89b5f2c66bf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b3799af8298d43d99f13b89b5f2c66bf()
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

      private sealed class MTHD_6f1ad4d341f84edbbb520845a53c9e59 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6f1ad4d341f84edbbb520845a53c9e59()
        {
          this.Initialize("get_maxUses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).maxUses;
        }
      }

      private sealed class MTHD_f53e3051ef8045cc9bab8b8420fe8855 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f53e3051ef8045cc9bab8b8420fe8855()
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

      private sealed class MTHD_e024706c1efa4c9e8c4f9a2ba66eded2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e024706c1efa4c9e8c4f9a2ba66eded2()
        {
          this.Initialize("get_rechargeTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).rechargeTime;
        }
      }

      private sealed class MTHD_9490e99cdb034fefae5572d248852761 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9490e99cdb034fefae5572d248852761()
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

      private sealed class MTHD_3dd0a8a87d444d52873e6ddd2d09d5ae : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3dd0a8a87d444d52873e6ddd2d09d5ae()
        {
          this.Initialize("get_lastTurnFired", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).lastTurnFired;
        }
      }

      private sealed class MTHD_7ecc2e3fbe184df2b18b9548fd99eb10 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7ecc2e3fbe184df2b18b9548fd99eb10()
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

      private sealed class MTHD_7bc0ad4d7af54ac5b168a4c7500f247b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7bc0ad4d7af54ac5b168a4c7500f247b()
        {
          this.Initialize("get_isPresent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).isPresent;
        }
      }

      private sealed class MTHD_1bcfceab8d4344b88ddc32575ba1e650 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1bcfceab8d4344b88ddc32575ba1e650()
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

      private sealed class MTHD_dd7f905dc2354b79b3772d9474d82cd2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dd7f905dc2354b79b3772d9474d82cd2()
        {
          this.Initialize("get_locked", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).locked;
        }
      }

      private sealed class MTHD_a4ac8fad70f34be8b0b918dc2598b498 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a4ac8fad70f34be8b0b918dc2598b498()
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

      private sealed class MTHD_90af0f3bc722437f979a1e7489b95869 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_90af0f3bc722437f979a1e7489b95869()
        {
          this.Initialize("get_turnsTillFirstUse", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).turnsTillFirstUse;
        }
      }

      private sealed class MTHD_465a0c055ac8421a89d81c0f8da8ccfb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_465a0c055ac8421a89d81c0f8da8ccfb()
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

      private sealed class MTHD_b64158308e5e4238a81b3e113b3f0263 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b64158308e5e4238a81b3e113b3f0263()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class MTHD_e6cb80651f434e98910551f75521a72b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e6cb80651f434e98910551f75521a72b()
        {
          this.Initialize("get_castType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class MTHD_ee90f0687bdb4b7486e1a79a6d76a4d0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ee90f0687bdb4b7486e1a79a6d76a4d0()
        {
          this.Initialize("get_damageType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class MTHD_4b15300e4b0247fb9a6b40b6ede37b67 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4b15300e4b0247fb9a6b40b6ede37b67()
        {
          this.Initialize("get_book", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class MTHD_ac533eae2d014aa382f56e38dff10f82 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ac533eae2d014aa382f56e38dff10f82()
        {
          this.Initialize("get_damage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class MTHD_6ac049f6ebf44b11abdccbed1d99496c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6ac049f6ebf44b11abdccbed1d99496c()
        {
          this.Initialize("get_explosionRadius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class MTHD_16f60eea3ddc4f569d201327a77dd035 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_16f60eea3ddc4f569d201327a77dd035()
        {
          this.Initialize("get_description", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class MTHD_0788d8723a104cf998a94a7f4d4ff958 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0788d8723a104cf998a94a7f4d4ff958()
        {
          this.Initialize("get_descriptionOnly", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class MTHD_8f8c606352104f3cbe41c7bbf4e504e3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8f8c606352104f3cbe41c7bbf4e504e3()
        {
          this.Initialize("get_descriptionExtra", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class MTHD_c83cb7ecf99c4fa0b23729dc75841546 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c83cb7ecf99c4fa0b23729dc75841546()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }

      private sealed class MTHD_fc3e586349e94514a129da2c2cb450f6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fc3e586349e94514a129da2c2cb450f6()
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

      private sealed class MTHD_2657863369674aadb62f497842e74105 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2657863369674aadb62f497842e74105()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_152ae4436fff42f6bba6ef259240da50 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_152ae4436fff42f6bba6ef259240da50()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_5a16d50c5337499091c49cac3adba841 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5a16d50c5337499091c49cac3adba841()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_a706ab8516b744dba8cd3586e713cfcb : HardwiredMemberDescriptor
      {
        internal PROP_a706ab8516b744dba8cd3586e713cfcb()
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

      private sealed class PROP_6f6da0dcf97c42949e2b878992e21c97 : HardwiredMemberDescriptor
      {
        internal PROP_6f6da0dcf97c42949e2b878992e21c97()
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

      private sealed class PROP_a9e5b87e7051423f8ff954a520363292 : HardwiredMemberDescriptor
      {
        internal PROP_a9e5b87e7051423f8ff954a520363292()
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

      private sealed class PROP_2956adce01c141f49f5fd02793bf5063 : HardwiredMemberDescriptor
      {
        internal PROP_2956adce01c141f49f5fd02793bf5063()
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

      private sealed class PROP_456d66ee700e48d99629ae7b9fc767c5 : HardwiredMemberDescriptor
      {
        internal PROP_456d66ee700e48d99629ae7b9fc767c5()
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

      private sealed class PROP_97baf26986f64f148ffe0feb0ce72967 : HardwiredMemberDescriptor
      {
        internal PROP_97baf26986f64f148ffe0feb0ce72967()
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

      private sealed class PROP_eef2d62f3bdc4ed99e05f53b208bec7a : HardwiredMemberDescriptor
      {
        internal PROP_eef2d62f3bdc4ed99e05f53b208bec7a()
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

      private sealed class PROP_a6a02969e4834ebcae9a1a6b630ec6ba : HardwiredMemberDescriptor
      {
        internal PROP_a6a02969e4834ebcae9a1a6b630ec6ba()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class PROP_41dadfe6240a47ad86877acc1ea30955 : HardwiredMemberDescriptor
      {
        internal PROP_41dadfe6240a47ad86877acc1ea30955()
          : base(typeof (CastType), "castType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class PROP_222e57a75fc54a48aa59bcf5ec21b9ed : HardwiredMemberDescriptor
      {
        internal PROP_222e57a75fc54a48aa59bcf5ec21b9ed()
          : base(typeof (DamageType), "damageType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class PROP_82563a0f7ea54775b60a50e677f74813 : HardwiredMemberDescriptor
      {
        internal PROP_82563a0f7ea54775b60a50e677f74813()
          : base(typeof (BookOf), "book", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class PROP_68d347d274554feba22b1f02aae4ef0a : HardwiredMemberDescriptor
      {
        internal PROP_68d347d274554feba22b1f02aae4ef0a()
          : base(typeof (int), "damage", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class PROP_06f6dfe5db4541bc9d3e0ab56805603f : HardwiredMemberDescriptor
      {
        internal PROP_06f6dfe5db4541bc9d3e0ab56805603f()
          : base(typeof (int), "explosionRadius", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class PROP_7c9db1b1b3954b508f9fa0b851eb3b28 : HardwiredMemberDescriptor
      {
        internal PROP_7c9db1b1b3954b508f9fa0b851eb3b28()
          : base(typeof (string), "description", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class PROP_7482faa907fe450c88c6f0bcb92368fb : HardwiredMemberDescriptor
      {
        internal PROP_7482faa907fe450c88c6f0bcb92368fb()
          : base(typeof (string), "descriptionOnly", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class PROP_1b6df0a2c3ab46a9b4c23b52402f2870 : HardwiredMemberDescriptor
      {
        internal PROP_1b6df0a2c3ab46a9b4c23b52402f2870()
          : base(typeof (string), "descriptionExtra", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class PROP_10bdec459e794bd5bb8d2270b4c0a448 : HardwiredMemberDescriptor
      {
        internal PROP_10bdec459e794bd5bb8d2270b4c0a448()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }
    }

    private sealed class TYPE_f86ff89059a94cc2806d035a87eafd0d : HardwiredUserDataDescriptor
    {
      internal TYPE_f86ff89059a94cc2806d035a87eafd0d()
        : base(typeof (ContainerTower))
      {
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f86ff89059a94cc2806d035a87eafd0d.MTHD_3ae1ed5505504654b92665c44957ae3c()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f86ff89059a94cc2806d035a87eafd0d.MTHD_fe16b8c493874ce9883833d1f924191a()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f86ff89059a94cc2806d035a87eafd0d.MTHD_ea856971e69c4e70b809e642a68d303b()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f86ff89059a94cc2806d035a87eafd0d.MTHD_985e4e5aedc84a789ad011a89c6d4c0b()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f86ff89059a94cc2806d035a87eafd0d.MTHD_50242c41f3db4bbe920db954940c12d1()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f86ff89059a94cc2806d035a87eafd0d.MTHD_e34b4878d7d743989c8c56b8d1d8d48f()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f86ff89059a94cc2806d035a87eafd0d.MTHD_11ee45c92c3642b7b94bd4fae36def4a()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f86ff89059a94cc2806d035a87eafd0d.MTHD_801de89dd183403bae45831973b307ea()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f86ff89059a94cc2806d035a87eafd0d.MTHD_abb7f1f819384c8d971408de642ead3b()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f86ff89059a94cc2806d035a87eafd0d.MTHD_24dabec5b5af4388a50304aac799e04c()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f86ff89059a94cc2806d035a87eafd0d.MTHD_9c38c17357df4ea6b62462aac47fda93()
        }));
        this.AddMember("getType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f86ff89059a94cc2806d035a87eafd0d.MTHD_301cf50f484f40d2bc0b776e8b3fd3e1()
        }));
        this.AddMember("kill", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("kill", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f86ff89059a94cc2806d035a87eafd0d.MTHD_2dae5da65a6d4f2191a004263a3d9c45()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f86ff89059a94cc2806d035a87eafd0d.MTHD_852eddc56a5246d4b151cd0f8c1fefcf()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f86ff89059a94cc2806d035a87eafd0d.MTHD_295c2a857eac42289c575f18490030d2()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f86ff89059a94cc2806d035a87eafd0d.MTHD_8b482cebb54f46a3a1e9f39e0367995a()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f86ff89059a94cc2806d035a87eafd0d.MTHD_f5a5779395e141939959cec025fceaa2()
        }));
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_f86ff89059a94cc2806d035a87eafd0d.PROP_bd90c5075a40465486f7a98cc8c2e58d());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_f86ff89059a94cc2806d035a87eafd0d.PROP_55cf0ea0a34348a29d12468673e41108());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_f86ff89059a94cc2806d035a87eafd0d.PROP_f2b959348f424f0c9072d8de995ae020());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_f86ff89059a94cc2806d035a87eafd0d.PROP_d40208ca71804f05931fbe3953b90493());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_f86ff89059a94cc2806d035a87eafd0d.PROP_e057290466c142e085ddae22026889df());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_f86ff89059a94cc2806d035a87eafd0d.PROP_36df54d57f7243b28749c854266af541());
      }

      private sealed class MTHD_3ae1ed5505504654b92665c44957ae3c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3ae1ed5505504654b92665c44957ae3c()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).health;
        }
      }

      private sealed class MTHD_fe16b8c493874ce9883833d1f924191a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fe16b8c493874ce9883833d1f924191a()
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

      private sealed class MTHD_ea856971e69c4e70b809e642a68d303b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ea856971e69c4e70b809e642a68d303b()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).maxHealth;
        }
      }

      private sealed class MTHD_985e4e5aedc84a789ad011a89c6d4c0b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_985e4e5aedc84a789ad011a89c6d4c0b()
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

      private sealed class MTHD_50242c41f3db4bbe920db954940c12d1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_50242c41f3db4bbe920db954940c12d1()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).x;
        }
      }

      private sealed class MTHD_e34b4878d7d743989c8c56b8d1d8d48f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e34b4878d7d743989c8c56b8d1d8d48f()
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

      private sealed class MTHD_11ee45c92c3642b7b94bd4fae36def4a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_11ee45c92c3642b7b94bd4fae36def4a()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).y;
        }
      }

      private sealed class MTHD_801de89dd183403bae45831973b307ea : HardwiredMethodMemberDescriptor
      {
        internal MTHD_801de89dd183403bae45831973b307ea()
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

      private sealed class MTHD_abb7f1f819384c8d971408de642ead3b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_abb7f1f819384c8d971408de642ead3b()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).position;
        }
      }

      private sealed class MTHD_24dabec5b5af4388a50304aac799e04c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_24dabec5b5af4388a50304aac799e04c()
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

      private sealed class MTHD_9c38c17357df4ea6b62462aac47fda93 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9c38c17357df4ea6b62462aac47fda93()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }

      private sealed class MTHD_301cf50f484f40d2bc0b776e8b3fd3e1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_301cf50f484f40d2bc0b776e8b3fd3e1()
        {
          this.Initialize("getType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).getType();
        }
      }

      private sealed class MTHD_2dae5da65a6d4f2191a004263a3d9c45 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2dae5da65a6d4f2191a004263a3d9c45()
        {
          this.Initialize("kill", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerTower) obj).kill();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_852eddc56a5246d4b151cd0f8c1fefcf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_852eddc56a5246d4b151cd0f8c1fefcf()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).GetHashCode();
        }
      }

      private sealed class MTHD_295c2a857eac42289c575f18490030d2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_295c2a857eac42289c575f18490030d2()
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

      private sealed class MTHD_8b482cebb54f46a3a1e9f39e0367995a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8b482cebb54f46a3a1e9f39e0367995a()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_f5a5779395e141939959cec025fceaa2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f5a5779395e141939959cec025fceaa2()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_bd90c5075a40465486f7a98cc8c2e58d : HardwiredMemberDescriptor
      {
        internal PROP_bd90c5075a40465486f7a98cc8c2e58d()
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

      private sealed class PROP_55cf0ea0a34348a29d12468673e41108 : HardwiredMemberDescriptor
      {
        internal PROP_55cf0ea0a34348a29d12468673e41108()
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

      private sealed class PROP_f2b959348f424f0c9072d8de995ae020 : HardwiredMemberDescriptor
      {
        internal PROP_f2b959348f424f0c9072d8de995ae020()
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

      private sealed class PROP_d40208ca71804f05931fbe3953b90493 : HardwiredMemberDescriptor
      {
        internal PROP_d40208ca71804f05931fbe3953b90493()
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

      private sealed class PROP_e057290466c142e085ddae22026889df : HardwiredMemberDescriptor
      {
        internal PROP_e057290466c142e085ddae22026889df()
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

      private sealed class PROP_36df54d57f7243b28749c854266af541 : HardwiredMemberDescriptor
      {
        internal PROP_36df54d57f7243b28749c854266af541()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }
    }

    private sealed class TYPE_ee5529fea45e46a89798cc4a8ca67fec : HardwiredUserDataDescriptor
    {
      internal TYPE_ee5529fea45e46a89798cc4a8ca67fec()
        : base(typeof (Educative.Point))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee5529fea45e46a89798cc4a8ca67fec.MTHD_4680dd42fe03463e8d8dd1f3cd169df6(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee5529fea45e46a89798cc4a8ca67fec.MTHD_a76682331f1d4d5b8aae1d5c4f3df235()
        }));
        this.AddMember("distance", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("distance", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee5529fea45e46a89798cc4a8ca67fec.MTHD_7d1b55b32f0d4b32ad31aa168ab02526(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee5529fea45e46a89798cc4a8ca67fec.MTHD_694e4b47ee814522ba55a60682903ca6()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee5529fea45e46a89798cc4a8ca67fec.MTHD_9efff98e3c854d9181286dbd47c6acb9()
        }));
        this.AddMember("copy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("copy", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee5529fea45e46a89798cc4a8ca67fec.MTHD_66a06e9f0d304f30bc39a82c621ddea3()
        }));
        this.AddMember("normalized", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalized", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee5529fea45e46a89798cc4a8ca67fec.MTHD_a73c28c4649542e4919fc37c104bedfe()
        }));
        this.AddMember("normalize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalize", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee5529fea45e46a89798cc4a8ca67fec.MTHD_c771a9e2420540cfbf2d6e11d1133900()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee5529fea45e46a89798cc4a8ca67fec.MTHD_f40aa0633ccf4572880f74656532b92d()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee5529fea45e46a89798cc4a8ca67fec.MTHD_a253987f8b3f409ead35aeec801c3ab7()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee5529fea45e46a89798cc4a8ca67fec.MTHD_dfc9cbb8cf464e16818abfe68d717184()
        }));
        this.AddMember("op_Subtraction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Subtraction", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee5529fea45e46a89798cc4a8ca67fec.MTHD_de6727c2b0464fe38ff2a91a9215dda0(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee5529fea45e46a89798cc4a8ca67fec.MTHD_b533e52668464efbad14752f2683f539()
        }));
        this.AddMember("op_Addition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Addition", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee5529fea45e46a89798cc4a8ca67fec.MTHD_01573e2721fc479aa0ed3cbd6c8e6a86(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee5529fea45e46a89798cc4a8ca67fec.MTHD_30b16664203b49e2ae0b931af5ef90e9()
        }));
        this.AddMember("op_Multiply", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Multiply", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee5529fea45e46a89798cc4a8ca67fec.MTHD_e7252abe53f84fe7ac423c4aafb76d17(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee5529fea45e46a89798cc4a8ca67fec.MTHD_13093d7a200341e687f7fe8caa08352d()
        }));
        this.AddMember("op_Division", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Division", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee5529fea45e46a89798cc4a8ca67fec.MTHD_12ce1b0174bf4489a1ce75d61385be63(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee5529fea45e46a89798cc4a8ca67fec.MTHD_94bd8b50eb954e46bbe4836fc3adbeb6()
        }));
        this.AddMember("op_Modulus", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Modulus", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee5529fea45e46a89798cc4a8ca67fec.MTHD_6dda5f4f13134b2b8db8e8d63e03ae92(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee5529fea45e46a89798cc4a8ca67fec.MTHD_4b12ad3e3bbf46ad82f2a2305536fcb6()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee5529fea45e46a89798cc4a8ca67fec.MTHD_b9d17149f82549e1a0ded5e15c6bcda2()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee5529fea45e46a89798cc4a8ca67fec.MTHD_13f752e6e131492f99aebe77f284abb7()
        }));
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_ee5529fea45e46a89798cc4a8ca67fec.FLDV_f34abd56750e4156b1cf7efa6f8ba743());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_ee5529fea45e46a89798cc4a8ca67fec.FLDV_2e6d5cd583374afaafa003b6e51ea02a());
      }

      private sealed class MTHD_4680dd42fe03463e8d8dd1f3cd169df6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4680dd42fe03463e8d8dd1f3cd169df6()
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

      private sealed class MTHD_a76682331f1d4d5b8aae1d5c4f3df235 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a76682331f1d4d5b8aae1d5c4f3df235()
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

      private sealed class MTHD_7d1b55b32f0d4b32ad31aa168ab02526 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7d1b55b32f0d4b32ad31aa168ab02526()
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

      private sealed class MTHD_694e4b47ee814522ba55a60682903ca6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_694e4b47ee814522ba55a60682903ca6()
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

      private sealed class MTHD_9efff98e3c854d9181286dbd47c6acb9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9efff98e3c854d9181286dbd47c6acb9()
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

      private sealed class MTHD_66a06e9f0d304f30bc39a82c621ddea3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_66a06e9f0d304f30bc39a82c621ddea3()
        {
          this.Initialize("copy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).copy();
        }
      }

      private sealed class MTHD_a73c28c4649542e4919fc37c104bedfe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a73c28c4649542e4919fc37c104bedfe()
        {
          this.Initialize("normalized", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).normalized();
        }
      }

      private sealed class MTHD_c771a9e2420540cfbf2d6e11d1133900 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c771a9e2420540cfbf2d6e11d1133900()
        {
          this.Initialize("normalize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((Educative.Point) obj).normalize();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_f40aa0633ccf4572880f74656532b92d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f40aa0633ccf4572880f74656532b92d()
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

      private sealed class MTHD_a253987f8b3f409ead35aeec801c3ab7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a253987f8b3f409ead35aeec801c3ab7()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).GetHashCode();
        }
      }

      private sealed class MTHD_dfc9cbb8cf464e16818abfe68d717184 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dfc9cbb8cf464e16818abfe68d717184()
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

      private sealed class MTHD_de6727c2b0464fe38ff2a91a9215dda0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_de6727c2b0464fe38ff2a91a9215dda0()
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

      private sealed class MTHD_b533e52668464efbad14752f2683f539 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b533e52668464efbad14752f2683f539()
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

      private sealed class MTHD_01573e2721fc479aa0ed3cbd6c8e6a86 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_01573e2721fc479aa0ed3cbd6c8e6a86()
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

      private sealed class MTHD_30b16664203b49e2ae0b931af5ef90e9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_30b16664203b49e2ae0b931af5ef90e9()
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

      private sealed class MTHD_e7252abe53f84fe7ac423c4aafb76d17 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e7252abe53f84fe7ac423c4aafb76d17()
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

      private sealed class MTHD_13093d7a200341e687f7fe8caa08352d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_13093d7a200341e687f7fe8caa08352d()
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

      private sealed class MTHD_12ce1b0174bf4489a1ce75d61385be63 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_12ce1b0174bf4489a1ce75d61385be63()
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

      private sealed class MTHD_94bd8b50eb954e46bbe4836fc3adbeb6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_94bd8b50eb954e46bbe4836fc3adbeb6()
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

      private sealed class MTHD_6dda5f4f13134b2b8db8e8d63e03ae92 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6dda5f4f13134b2b8db8e8d63e03ae92()
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

      private sealed class MTHD_4b12ad3e3bbf46ad82f2a2305536fcb6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4b12ad3e3bbf46ad82f2a2305536fcb6()
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

      private sealed class MTHD_b9d17149f82549e1a0ded5e15c6bcda2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b9d17149f82549e1a0ded5e15c6bcda2()
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

      private sealed class MTHD_13f752e6e131492f99aebe77f284abb7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_13f752e6e131492f99aebe77f284abb7()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_f34abd56750e4156b1cf7efa6f8ba743 : HardwiredMemberDescriptor
      {
        internal FLDV_f34abd56750e4156b1cf7efa6f8ba743()
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

      private sealed class FLDV_2e6d5cd583374afaafa003b6e51ea02a : HardwiredMemberDescriptor
      {
        internal FLDV_2e6d5cd583374afaafa003b6e51ea02a()
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

    private sealed class TYPE_a4dd87315da540f19ca08b1413bc4f6c : HardwiredUserDataDescriptor
    {
      internal TYPE_a4dd87315da540f19ca08b1413bc4f6c()
        : base(typeof (Summon))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a4dd87315da540f19ca08b1413bc4f6c.MTHD_7ec3472defe54763b71c5ec1be1ab94b()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a4dd87315da540f19ca08b1413bc4f6c.MTHD_caaa19ad621e491dad9c4f0bdf0404a9()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a4dd87315da540f19ca08b1413bc4f6c.MTHD_5a45e6a4cc0e4493ba7cd40acee27226()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a4dd87315da540f19ca08b1413bc4f6c.MTHD_dc90b09bea7a4fab90bef7d320ab7a3e()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a4dd87315da540f19ca08b1413bc4f6c.MTHD_effbe4a37f074c208178d2282ed610c9()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a4dd87315da540f19ca08b1413bc4f6c.MTHD_b25b24a2c8af4dd79aaba8e2dad2e121()
        }));
        this.AddMember("spell", (IMemberDescriptor) new Bridge.TYPE_a4dd87315da540f19ca08b1413bc4f6c.FLDV_c1ff12ae3fb846a9b43e82c388ca76ad());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_a4dd87315da540f19ca08b1413bc4f6c.FLDV_c3ec84cdfcf3454ba80e18055765ead3());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_a4dd87315da540f19ca08b1413bc4f6c.FLDV_d1ae2db72785400f9fbc285b7f15e9cf());
        this.AddMember("onPlayersPanel", (IMemberDescriptor) new Bridge.TYPE_a4dd87315da540f19ca08b1413bc4f6c.FLDV_05292afa50fc4eefb5b6634739d8b739());
        this.AddMember("useAI", (IMemberDescriptor) new Bridge.TYPE_a4dd87315da540f19ca08b1413bc4f6c.FLDV_1fcf3da9e802425ea11ed4dc8d12d295());
        this.AddMember("no_AI_still_use_turn", (IMemberDescriptor) new Bridge.TYPE_a4dd87315da540f19ca08b1413bc4f6c.FLDV_5daeb431225d4e92beef461a966ddc36());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_a4dd87315da540f19ca08b1413bc4f6c.FLDV_426307ee8c4f4b65b4a9507cf6b1d9a2());
        this.AddMember("playSound", (IMemberDescriptor) new Bridge.TYPE_a4dd87315da540f19ca08b1413bc4f6c.FLDV_0d9664054be0479c87336f4ebfc2810b());
        this.AddMember("prestige", (IMemberDescriptor) new Bridge.TYPE_a4dd87315da540f19ca08b1413bc4f6c.FLDV_3d2d683f99b64b77aba945b343a53ae9());
        this.AddMember("colors", (IMemberDescriptor) new Bridge.TYPE_a4dd87315da540f19ca08b1413bc4f6c.FLDV_01f9794438d54e37a515bb0864490185());
        this.AddMember("spells", (IMemberDescriptor) new Bridge.TYPE_a4dd87315da540f19ca08b1413bc4f6c.FLDV_3cddeed09bcc431c9c33c30382b16854());
        this.AddMember("outfit", (IMemberDescriptor) new Bridge.TYPE_a4dd87315da540f19ca08b1413bc4f6c.FLDV_f50544ff0db24e9db456a39816727206());
        this.AddMember("elemental", (IMemberDescriptor) new Bridge.TYPE_a4dd87315da540f19ca08b1413bc4f6c.FLDV_6f2921d3be6a4ade90de1954bd6af76d());
      }

      private sealed class MTHD_7ec3472defe54763b71c5ec1be1ab94b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7ec3472defe54763b71c5ec1be1ab94b()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new Summon();
        }
      }

      private sealed class MTHD_caaa19ad621e491dad9c4f0bdf0404a9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_caaa19ad621e491dad9c4f0bdf0404a9()
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

      private sealed class MTHD_5a45e6a4cc0e4493ba7cd40acee27226 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5a45e6a4cc0e4493ba7cd40acee27226()
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

      private sealed class MTHD_dc90b09bea7a4fab90bef7d320ab7a3e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dc90b09bea7a4fab90bef7d320ab7a3e()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_effbe4a37f074c208178d2282ed610c9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_effbe4a37f074c208178d2282ed610c9()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_b25b24a2c8af4dd79aaba8e2dad2e121 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b25b24a2c8af4dd79aaba8e2dad2e121()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_c1ff12ae3fb846a9b43e82c388ca76ad : HardwiredMemberDescriptor
      {
        internal FLDV_c1ff12ae3fb846a9b43e82c388ca76ad()
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

      private sealed class FLDV_c3ec84cdfcf3454ba80e18055765ead3 : HardwiredMemberDescriptor
      {
        internal FLDV_c3ec84cdfcf3454ba80e18055765ead3()
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

      private sealed class FLDV_d1ae2db72785400f9fbc285b7f15e9cf : HardwiredMemberDescriptor
      {
        internal FLDV_d1ae2db72785400f9fbc285b7f15e9cf()
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

      private sealed class FLDV_05292afa50fc4eefb5b6634739d8b739 : HardwiredMemberDescriptor
      {
        internal FLDV_05292afa50fc4eefb5b6634739d8b739()
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

      private sealed class FLDV_1fcf3da9e802425ea11ed4dc8d12d295 : HardwiredMemberDescriptor
      {
        internal FLDV_1fcf3da9e802425ea11ed4dc8d12d295()
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

      private sealed class FLDV_5daeb431225d4e92beef461a966ddc36 : HardwiredMemberDescriptor
      {
        internal FLDV_5daeb431225d4e92beef461a966ddc36()
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

      private sealed class FLDV_426307ee8c4f4b65b4a9507cf6b1d9a2 : HardwiredMemberDescriptor
      {
        internal FLDV_426307ee8c4f4b65b4a9507cf6b1d9a2()
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

      private sealed class FLDV_0d9664054be0479c87336f4ebfc2810b : HardwiredMemberDescriptor
      {
        internal FLDV_0d9664054be0479c87336f4ebfc2810b()
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

      private sealed class FLDV_3d2d683f99b64b77aba945b343a53ae9 : HardwiredMemberDescriptor
      {
        internal FLDV_3d2d683f99b64b77aba945b343a53ae9()
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

      private sealed class FLDV_01f9794438d54e37a515bb0864490185 : HardwiredMemberDescriptor
      {
        internal FLDV_01f9794438d54e37a515bb0864490185()
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

      private sealed class FLDV_3cddeed09bcc431c9c33c30382b16854 : HardwiredMemberDescriptor
      {
        internal FLDV_3cddeed09bcc431c9c33c30382b16854()
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

      private sealed class FLDV_f50544ff0db24e9db456a39816727206 : HardwiredMemberDescriptor
      {
        internal FLDV_f50544ff0db24e9db456a39816727206()
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

      private sealed class FLDV_6f2921d3be6a4ade90de1954bd6af76d : HardwiredMemberDescriptor
      {
        internal FLDV_6f2921d3be6a4ade90de1954bd6af76d()
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

    private sealed class TYPE_3ff468a2007646369f8de4db45419b0e : HardwiredUserDataDescriptor
    {
      internal TYPE_3ff468a2007646369f8de4db45419b0e()
        : base(typeof (UIElement))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_6ec9cfa4b8de4bb38d869060128a5b6a()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_1b2f19f9b97c4a06aeeffebefb628db2()
        }));
        this.AddMember("get_visible", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_visible", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_bcea8ebce7f445c9bbae0c95d10dd390()
        }));
        this.AddMember("set_visible", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_visible", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_2f12e528a7b646a0bf1547c1b04b86e4()
        }));
        this.AddMember("get_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_12963dd15a50466dae15b1a88f1df793()
        }));
        this.AddMember("set_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_dba3dd821c054c2bb23307c81df88c9e()
        }));
        this.AddMember("get_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_afdc9bcd6cf44ff0b2ef18d1ec8f416c()
        }));
        this.AddMember("set_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_49b6bc8ad8724ab8811fcbc98ce8a105()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_2cc24308531d48759a49d804ddcc66b9()
        }));
        this.AddMember("set_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_90f834c6a89949ac8382fe4f71d7fb62()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_d2eaa3063e994e68b93e4bbaba7a328e()
        }));
        this.AddMember("set_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_ac2572e6cc18400487f341a358971338()
        }));
        this.AddMember("get_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_872b0f62a1ff457ba503b5fc3c26de9d()
        }));
        this.AddMember("set_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_3998d32e16fd4aeb8dfde070f1cd115c()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_f1d2613f047e49cdab00b5be31ed86fa()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_25fff6b48718485dacf26c97e7f9e145()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_ef3c2457371c4acb8822aa560db8f493()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_5605977f8ffc4854b045c69ae9f067ea()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_739c236f8bcc4d8a8b021e0294acd869()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_9c8eea1fa78448429bb69d1bdb47f338()
        }));
        this.AddMember("get_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_17c9edf6742b4ea6b914be4b357cbae9()
        }));
        this.AddMember("set_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_bf9b2488fefa44139b4027f5cb06d089()
        }));
        this.AddMember("get_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_6a12be73c63f4e3095e6d1623b1413c2()
        }));
        this.AddMember("set_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_53951b579d3546929e579db9080d90e8()
        }));
        this.AddMember("get_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_b64411848e644e0689f476f07a0ca253()
        }));
        this.AddMember("set_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_8018db7218ce42f2992a4432cfdd17d8()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_4007cefaecd14c9a93dcd5f8bb63e614()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_5123119eb90b40fa9ddf00c56ccfdcca()
        }));
        this.AddMember("get_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_ddb8c867f214479e8e0d44a955048710()
        }));
        this.AddMember("set_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_9b16261b96074c79a8600275746938b9()
        }));
        this.AddMember("get_onClick2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_b8f5201b4851485a9a4d158ec771e0b1()
        }));
        this.AddMember("set_onClick2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_410713bcd1f3406185dc113b0fd3c58a()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_a152735f74984ec38ca2bd798ab9235e()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_e1fb7552fc3c4eac9bc513aa228b1d1d()
        }));
        this.AddMember("get_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_86f5b8d037524fffaedf3f5a8ed2b53f()
        }));
        this.AddMember("set_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_399bae88a57249cfa8540d0e81ac3077()
        }));
        this.AddMember("get_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_b8c47b0b78a24df9946d8803a24db9a8()
        }));
        this.AddMember("set_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_5c575ef44c8e4c86aeff61dcb7a6bf8e()
        }));
        this.AddMember("get_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_6892b8c8afe64400b2787f55a9bb57fe()
        }));
        this.AddMember("set_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_d8ab8d0bc78f46ea9160f9108994f48d()
        }));
        this.AddMember("get_textColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_3f8f6c99ef9f41b58c41c26edbe6df7c()
        }));
        this.AddMember("set_textColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_e80f14668c96470593bb7ff413428919()
        }));
        this.AddMember("get_highlightColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_highlightColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_dc017a92fc3a4c74b63e80eb08b7c071()
        }));
        this.AddMember("set_highlightColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_highlightColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_67d9053f1af548d197899ee90346157f()
        }));
        this.AddMember("get_highlightColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_highlightColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_321892ca60374f53866e7863c099a8df()
        }));
        this.AddMember("set_highlightColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_highlightColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_ead31155913d44029c00f37f7af1e324()
        }));
        this.AddMember("get_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_4fcddcaaec2f454697b84c047f541823()
        }));
        this.AddMember("set_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_9fd229efadb44c079d3136afb7fd408e()
        }));
        this.AddMember("get_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_321e939cfb2947ba8fb84a2e46310eee()
        }));
        this.AddMember("set_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_5f8824d2bf094b729f1b48e55d8b282a()
        }));
        this.AddMember("activateInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("activateInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_f6a6606f35564cbcb50cab7b19364396()
        }));
        this.AddMember("createUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createUI", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_494b8dde7f2948a985861cff48e79974()
        }));
        this.AddMember("createInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_e717bacd3c004df38b2194af6ce25d99()
        }));
        this.AddMember("duplicate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("duplicate", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_17396b2f36ef460fb9ee55fab1960e28()
        }));
        this.AddMember("destroyHierarchy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroyHierarchy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_19d0065bc5b64b22b55bc7303444df65()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_60789b3679484dd48dac1f36c7b37501()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_6668d913bfde49b4bf9a7dd580c5fc28()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_81f7c4ba569a43d79c77cf90e38665cd()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_57b8d347bb41489ea0ad8cb9147bfec3()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.MTHD_9eb342f219ce43d4884f24e5771fc0b0()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.PROP_a756f860d9df416aaedae80acf451e1b());
        this.AddMember("visible", (IMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.PROP_13b7b0d1e0b34453b74c395ceaed8ba0());
        this.AddMember("graphic", (IMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.PROP_63567d605c6c4bfb8b031a3757b87565());
        this.AddMember("anchor", (IMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.PROP_56c8e3a7114340d58b59eb36072a3617());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.PROP_9ffce5a2e8ac4e1683461a3806fbd014());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.PROP_46f04a7192a54193bf6dfb2f0ae90f39());
        this.AddMember("size", (IMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.PROP_1b8917b304464ccebdce27749346e160());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.PROP_bf67dd5e43534bdf9e8305f6687b5893());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.PROP_162346eddb4e4633b575e96cbbb0cbc9());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.PROP_bcff25d61a2d44acaf413fcf591b800c());
        this.AddMember("pivot_x", (IMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.PROP_cc961f9708f54578b6305734bc10b77f());
        this.AddMember("pivot_y", (IMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.PROP_4487675c270841b7ae01533a6946c891());
        this.AddMember("pivot", (IMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.PROP_75ece5a5c3f64b329a5f445e687268ef());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.PROP_46883c53325b44b4924e6e24ddd4d10e());
        this.AddMember("onClick", (IMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.PROP_1a5d30acdb93455dbc8498dcdfab5f18());
        this.AddMember("onClick2", (IMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.PROP_8cf08de0122e4b47a7dd1b42655a2b31());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.PROP_25db19e090d84cda93ea3997735fc0a7());
        this.AddMember("color2", (IMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.PROP_da1f3af3f0944bf6ba4e75f4f152a972());
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.PROP_9986c350eda84ed28a1f44c3488d61f5());
        this.AddMember("textColor", (IMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.PROP_f2028227e19c4150be3e43cab758fe1d());
        this.AddMember("textColor2", (IMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.PROP_d7b5018713bf4e41969746f8b9646bef());
        this.AddMember("highlightColor", (IMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.PROP_abae3cb82f044325933b178c1b9ab3e9());
        this.AddMember("highlightColor2", (IMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.PROP_19f28378605d4541abd1c0d27bc10246());
        this.AddMember("textStyle", (IMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.PROP_94342d6225934c54b64068d511d2e0be());
        this.AddMember("textSize", (IMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.PROP_c6f8eafd90124eadb44a5cf8b9ced1b1());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.FLDV_02db6ed6bbed4fbd92904e5a5fd62295());
        this.AddMember("clickID", (IMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.FLDV_c8367f3a6ecf478098785db49522da63());
        this.AddMember("clickDestroy", (IMemberDescriptor) new Bridge.TYPE_3ff468a2007646369f8de4db45419b0e.FLDV_fd64290be6804379bd706708460d94ce());
      }

      private sealed class MTHD_6ec9cfa4b8de4bb38d869060128a5b6a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6ec9cfa4b8de4bb38d869060128a5b6a()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new UIElement();
        }
      }

      private sealed class MTHD_1b2f19f9b97c4a06aeeffebefb628db2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1b2f19f9b97c4a06aeeffebefb628db2()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class MTHD_bcea8ebce7f445c9bbae0c95d10dd390 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bcea8ebce7f445c9bbae0c95d10dd390()
        {
          this.Initialize("get_visible", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).visible;
        }
      }

      private sealed class MTHD_2f12e528a7b646a0bf1547c1b04b86e4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2f12e528a7b646a0bf1547c1b04b86e4()
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

      private sealed class MTHD_12963dd15a50466dae15b1a88f1df793 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_12963dd15a50466dae15b1a88f1df793()
        {
          this.Initialize("get_graphic", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return ((UIElement) obj).graphic;
        }
      }

      private sealed class MTHD_dba3dd821c054c2bb23307c81df88c9e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dba3dd821c054c2bb23307c81df88c9e()
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

      private sealed class MTHD_afdc9bcd6cf44ff0b2ef18d1ec8f416c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_afdc9bcd6cf44ff0b2ef18d1ec8f416c()
        {
          this.Initialize("get_anchor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).anchor;
        }
      }

      private sealed class MTHD_49b6bc8ad8724ab8811fcbc98ce8a105 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_49b6bc8ad8724ab8811fcbc98ce8a105()
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

      private sealed class MTHD_2cc24308531d48759a49d804ddcc66b9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2cc24308531d48759a49d804ddcc66b9()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).width;
        }
      }

      private sealed class MTHD_90f834c6a89949ac8382fe4f71d7fb62 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_90f834c6a89949ac8382fe4f71d7fb62()
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

      private sealed class MTHD_d2eaa3063e994e68b93e4bbaba7a328e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d2eaa3063e994e68b93e4bbaba7a328e()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).height;
        }
      }

      private sealed class MTHD_ac2572e6cc18400487f341a358971338 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ac2572e6cc18400487f341a358971338()
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

      private sealed class MTHD_872b0f62a1ff457ba503b5fc3c26de9d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_872b0f62a1ff457ba503b5fc3c26de9d()
        {
          this.Initialize("get_size", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).size;
        }
      }

      private sealed class MTHD_3998d32e16fd4aeb8dfde070f1cd115c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3998d32e16fd4aeb8dfde070f1cd115c()
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

      private sealed class MTHD_f1d2613f047e49cdab00b5be31ed86fa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f1d2613f047e49cdab00b5be31ed86fa()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).x;
        }
      }

      private sealed class MTHD_25fff6b48718485dacf26c97e7f9e145 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_25fff6b48718485dacf26c97e7f9e145()
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

      private sealed class MTHD_ef3c2457371c4acb8822aa560db8f493 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ef3c2457371c4acb8822aa560db8f493()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).y;
        }
      }

      private sealed class MTHD_5605977f8ffc4854b045c69ae9f067ea : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5605977f8ffc4854b045c69ae9f067ea()
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

      private sealed class MTHD_739c236f8bcc4d8a8b021e0294acd869 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_739c236f8bcc4d8a8b021e0294acd869()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).position;
        }
      }

      private sealed class MTHD_9c8eea1fa78448429bb69d1bdb47f338 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9c8eea1fa78448429bb69d1bdb47f338()
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

      private sealed class MTHD_17c9edf6742b4ea6b914be4b357cbae9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_17c9edf6742b4ea6b914be4b357cbae9()
        {
          this.Initialize("get_pivot_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_x;
        }
      }

      private sealed class MTHD_bf9b2488fefa44139b4027f5cb06d089 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bf9b2488fefa44139b4027f5cb06d089()
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

      private sealed class MTHD_6a12be73c63f4e3095e6d1623b1413c2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6a12be73c63f4e3095e6d1623b1413c2()
        {
          this.Initialize("get_pivot_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_y;
        }
      }

      private sealed class MTHD_53951b579d3546929e579db9080d90e8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_53951b579d3546929e579db9080d90e8()
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

      private sealed class MTHD_b64411848e644e0689f476f07a0ca253 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b64411848e644e0689f476f07a0ca253()
        {
          this.Initialize("get_pivot", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot;
        }
      }

      private sealed class MTHD_8018db7218ce42f2992a4432cfdd17d8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8018db7218ce42f2992a4432cfdd17d8()
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

      private sealed class MTHD_4007cefaecd14c9a93dcd5f8bb63e614 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4007cefaecd14c9a93dcd5f8bb63e614()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).angle;
        }
      }

      private sealed class MTHD_5123119eb90b40fa9ddf00c56ccfdcca : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5123119eb90b40fa9ddf00c56ccfdcca()
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

      private sealed class MTHD_ddb8c867f214479e8e0d44a955048710 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ddb8c867f214479e8e0d44a955048710()
        {
          this.Initialize("get_onClick", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick;
        }
      }

      private sealed class MTHD_9b16261b96074c79a8600275746938b9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9b16261b96074c79a8600275746938b9()
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

      private sealed class MTHD_b8f5201b4851485a9a4d158ec771e0b1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b8f5201b4851485a9a4d158ec771e0b1()
        {
          this.Initialize("get_onClick2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick2;
        }
      }

      private sealed class MTHD_410713bcd1f3406185dc113b0fd3c58a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_410713bcd1f3406185dc113b0fd3c58a()
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

      private sealed class MTHD_a152735f74984ec38ca2bd798ab9235e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a152735f74984ec38ca2bd798ab9235e()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color;
        }
      }

      private sealed class MTHD_e1fb7552fc3c4eac9bc513aa228b1d1d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e1fb7552fc3c4eac9bc513aa228b1d1d()
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

      private sealed class MTHD_86f5b8d037524fffaedf3f5a8ed2b53f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_86f5b8d037524fffaedf3f5a8ed2b53f()
        {
          this.Initialize("get_color2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color2;
        }
      }

      private sealed class MTHD_399bae88a57249cfa8540d0e81ac3077 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_399bae88a57249cfa8540d0e81ac3077()
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

      private sealed class MTHD_b8c47b0b78a24df9946d8803a24db9a8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b8c47b0b78a24df9946d8803a24db9a8()
        {
          this.Initialize("get_text", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).text;
        }
      }

      private sealed class MTHD_5c575ef44c8e4c86aeff61dcb7a6bf8e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5c575ef44c8e4c86aeff61dcb7a6bf8e()
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

      private sealed class MTHD_6892b8c8afe64400b2787f55a9bb57fe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6892b8c8afe64400b2787f55a9bb57fe()
        {
          this.Initialize("get_textColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor;
        }
      }

      private sealed class MTHD_d8ab8d0bc78f46ea9160f9108994f48d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d8ab8d0bc78f46ea9160f9108994f48d()
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

      private sealed class MTHD_3f8f6c99ef9f41b58c41c26edbe6df7c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3f8f6c99ef9f41b58c41c26edbe6df7c()
        {
          this.Initialize("get_textColor2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor2;
        }
      }

      private sealed class MTHD_e80f14668c96470593bb7ff413428919 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e80f14668c96470593bb7ff413428919()
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

      private sealed class MTHD_dc017a92fc3a4c74b63e80eb08b7c071 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dc017a92fc3a4c74b63e80eb08b7c071()
        {
          this.Initialize("get_highlightColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).highlightColor;
        }
      }

      private sealed class MTHD_67d9053f1af548d197899ee90346157f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_67d9053f1af548d197899ee90346157f()
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

      private sealed class MTHD_321892ca60374f53866e7863c099a8df : HardwiredMethodMemberDescriptor
      {
        internal MTHD_321892ca60374f53866e7863c099a8df()
        {
          this.Initialize("get_highlightColor2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).highlightColor2;
        }
      }

      private sealed class MTHD_ead31155913d44029c00f37f7af1e324 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ead31155913d44029c00f37f7af1e324()
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

      private sealed class MTHD_4fcddcaaec2f454697b84c047f541823 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4fcddcaaec2f454697b84c047f541823()
        {
          this.Initialize("get_textStyle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textStyle;
        }
      }

      private sealed class MTHD_9fd229efadb44c079d3136afb7fd408e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9fd229efadb44c079d3136afb7fd408e()
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

      private sealed class MTHD_321e939cfb2947ba8fb84a2e46310eee : HardwiredMethodMemberDescriptor
      {
        internal MTHD_321e939cfb2947ba8fb84a2e46310eee()
        {
          this.Initialize("get_textSize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textSize;
        }
      }

      private sealed class MTHD_5f8824d2bf094b729f1b48e55d8b282a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5f8824d2bf094b729f1b48e55d8b282a()
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

      private sealed class MTHD_f6a6606f35564cbcb50cab7b19364396 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f6a6606f35564cbcb50cab7b19364396()
        {
          this.Initialize("activateInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).activateInput();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_494b8dde7f2948a985861cff48e79974 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_494b8dde7f2948a985861cff48e79974()
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

      private sealed class MTHD_e717bacd3c004df38b2194af6ce25d99 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e717bacd3c004df38b2194af6ce25d99()
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

      private sealed class MTHD_17396b2f36ef460fb9ee55fab1960e28 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_17396b2f36ef460fb9ee55fab1960e28()
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

      private sealed class MTHD_19d0065bc5b64b22b55bc7303444df65 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_19d0065bc5b64b22b55bc7303444df65()
        {
          this.Initialize("destroyHierarchy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroyHierarchy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_60789b3679484dd48dac1f36c7b37501 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_60789b3679484dd48dac1f36c7b37501()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_6668d913bfde49b4bf9a7dd580c5fc28 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6668d913bfde49b4bf9a7dd580c5fc28()
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

      private sealed class MTHD_81f7c4ba569a43d79c77cf90e38665cd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_81f7c4ba569a43d79c77cf90e38665cd()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_57b8d347bb41489ea0ad8cb9147bfec3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_57b8d347bb41489ea0ad8cb9147bfec3()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_9eb342f219ce43d4884f24e5771fc0b0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9eb342f219ce43d4884f24e5771fc0b0()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_a756f860d9df416aaedae80acf451e1b : HardwiredMemberDescriptor
      {
        internal PROP_a756f860d9df416aaedae80acf451e1b()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class PROP_13b7b0d1e0b34453b74c395ceaed8ba0 : HardwiredMemberDescriptor
      {
        internal PROP_13b7b0d1e0b34453b74c395ceaed8ba0()
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

      private sealed class PROP_63567d605c6c4bfb8b031a3757b87565 : HardwiredMemberDescriptor
      {
        internal PROP_63567d605c6c4bfb8b031a3757b87565()
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

      private sealed class PROP_56c8e3a7114340d58b59eb36072a3617 : HardwiredMemberDescriptor
      {
        internal PROP_56c8e3a7114340d58b59eb36072a3617()
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

      private sealed class PROP_9ffce5a2e8ac4e1683461a3806fbd014 : HardwiredMemberDescriptor
      {
        internal PROP_9ffce5a2e8ac4e1683461a3806fbd014()
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

      private sealed class PROP_46f04a7192a54193bf6dfb2f0ae90f39 : HardwiredMemberDescriptor
      {
        internal PROP_46f04a7192a54193bf6dfb2f0ae90f39()
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

      private sealed class PROP_1b8917b304464ccebdce27749346e160 : HardwiredMemberDescriptor
      {
        internal PROP_1b8917b304464ccebdce27749346e160()
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

      private sealed class PROP_bf67dd5e43534bdf9e8305f6687b5893 : HardwiredMemberDescriptor
      {
        internal PROP_bf67dd5e43534bdf9e8305f6687b5893()
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

      private sealed class PROP_162346eddb4e4633b575e96cbbb0cbc9 : HardwiredMemberDescriptor
      {
        internal PROP_162346eddb4e4633b575e96cbbb0cbc9()
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

      private sealed class PROP_bcff25d61a2d44acaf413fcf591b800c : HardwiredMemberDescriptor
      {
        internal PROP_bcff25d61a2d44acaf413fcf591b800c()
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

      private sealed class PROP_cc961f9708f54578b6305734bc10b77f : HardwiredMemberDescriptor
      {
        internal PROP_cc961f9708f54578b6305734bc10b77f()
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

      private sealed class PROP_4487675c270841b7ae01533a6946c891 : HardwiredMemberDescriptor
      {
        internal PROP_4487675c270841b7ae01533a6946c891()
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

      private sealed class PROP_75ece5a5c3f64b329a5f445e687268ef : HardwiredMemberDescriptor
      {
        internal PROP_75ece5a5c3f64b329a5f445e687268ef()
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

      private sealed class PROP_46883c53325b44b4924e6e24ddd4d10e : HardwiredMemberDescriptor
      {
        internal PROP_46883c53325b44b4924e6e24ddd4d10e()
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

      private sealed class PROP_1a5d30acdb93455dbc8498dcdfab5f18 : HardwiredMemberDescriptor
      {
        internal PROP_1a5d30acdb93455dbc8498dcdfab5f18()
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

      private sealed class PROP_8cf08de0122e4b47a7dd1b42655a2b31 : HardwiredMemberDescriptor
      {
        internal PROP_8cf08de0122e4b47a7dd1b42655a2b31()
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

      private sealed class PROP_25db19e090d84cda93ea3997735fc0a7 : HardwiredMemberDescriptor
      {
        internal PROP_25db19e090d84cda93ea3997735fc0a7()
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

      private sealed class PROP_da1f3af3f0944bf6ba4e75f4f152a972 : HardwiredMemberDescriptor
      {
        internal PROP_da1f3af3f0944bf6ba4e75f4f152a972()
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

      private sealed class PROP_9986c350eda84ed28a1f44c3488d61f5 : HardwiredMemberDescriptor
      {
        internal PROP_9986c350eda84ed28a1f44c3488d61f5()
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

      private sealed class PROP_f2028227e19c4150be3e43cab758fe1d : HardwiredMemberDescriptor
      {
        internal PROP_f2028227e19c4150be3e43cab758fe1d()
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

      private sealed class PROP_d7b5018713bf4e41969746f8b9646bef : HardwiredMemberDescriptor
      {
        internal PROP_d7b5018713bf4e41969746f8b9646bef()
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

      private sealed class PROP_abae3cb82f044325933b178c1b9ab3e9 : HardwiredMemberDescriptor
      {
        internal PROP_abae3cb82f044325933b178c1b9ab3e9()
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

      private sealed class PROP_19f28378605d4541abd1c0d27bc10246 : HardwiredMemberDescriptor
      {
        internal PROP_19f28378605d4541abd1c0d27bc10246()
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

      private sealed class PROP_94342d6225934c54b64068d511d2e0be : HardwiredMemberDescriptor
      {
        internal PROP_94342d6225934c54b64068d511d2e0be()
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

      private sealed class PROP_c6f8eafd90124eadb44a5cf8b9ced1b1 : HardwiredMemberDescriptor
      {
        internal PROP_c6f8eafd90124eadb44a5cf8b9ced1b1()
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

      private sealed class FLDV_02db6ed6bbed4fbd92904e5a5fd62295 : HardwiredMemberDescriptor
      {
        internal FLDV_02db6ed6bbed4fbd92904e5a5fd62295()
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

      private sealed class FLDV_c8367f3a6ecf478098785db49522da63 : HardwiredMemberDescriptor
      {
        internal FLDV_c8367f3a6ecf478098785db49522da63()
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

      private sealed class FLDV_fd64290be6804379bd706708460d94ce : HardwiredMemberDescriptor
      {
        internal FLDV_fd64290be6804379bd706708460d94ce()
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

    private sealed class TYPE_1fb6c02699bd46af89b6fb4c62c8d3a4 : HardwiredUserDataDescriptor
    {
      internal TYPE_1fb6c02699bd46af89b6fb4c62c8d3a4()
        : base(typeof (MyPoll.Item))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1fb6c02699bd46af89b6fb4c62c8d3a4.MTHD_033b28888e554892a8dca7ea021a98d0()
        }));
        this.AddMember("addAnswer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addAnswer", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1fb6c02699bd46af89b6fb4c62c8d3a4.MTHD_2d45e85a5dab4d1097183dcce1f93356()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1fb6c02699bd46af89b6fb4c62c8d3a4.MTHD_c7d30d3a5e6147a59528637f78a330e3()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1fb6c02699bd46af89b6fb4c62c8d3a4.MTHD_3ff29e290e80412798eb2d1c5de66c90()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1fb6c02699bd46af89b6fb4c62c8d3a4.MTHD_4bd5b8c4a61f43eea9a2f85925a1b628()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1fb6c02699bd46af89b6fb4c62c8d3a4.MTHD_6feb980fb9ac4b588a3ed0a2837d6444()
        }));
        this.AddMember("question", (IMemberDescriptor) new Bridge.TYPE_1fb6c02699bd46af89b6fb4c62c8d3a4.FLDV_e20bb5c22d2243fb9789eecb194b34a8());
        this.AddMember("multipleSelection", (IMemberDescriptor) new Bridge.TYPE_1fb6c02699bd46af89b6fb4c62c8d3a4.FLDV_10afb0d29d264ebeb3f0db1a25f81c80());
        this.AddMember("requiresAnswer", (IMemberDescriptor) new Bridge.TYPE_1fb6c02699bd46af89b6fb4c62c8d3a4.FLDV_9b0421875e9445289c347a0bc7629a1b());
        this.AddMember("answers", (IMemberDescriptor) new Bridge.TYPE_1fb6c02699bd46af89b6fb4c62c8d3a4.FLDV_dc9cea2c88804f5bba1b74d1eb57b1db());
      }

      private sealed class MTHD_033b28888e554892a8dca7ea021a98d0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_033b28888e554892a8dca7ea021a98d0()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Item();
        }
      }

      private sealed class MTHD_2d45e85a5dab4d1097183dcce1f93356 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2d45e85a5dab4d1097183dcce1f93356()
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

      private sealed class MTHD_c7d30d3a5e6147a59528637f78a330e3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c7d30d3a5e6147a59528637f78a330e3()
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

      private sealed class MTHD_3ff29e290e80412798eb2d1c5de66c90 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3ff29e290e80412798eb2d1c5de66c90()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_4bd5b8c4a61f43eea9a2f85925a1b628 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4bd5b8c4a61f43eea9a2f85925a1b628()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_6feb980fb9ac4b588a3ed0a2837d6444 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6feb980fb9ac4b588a3ed0a2837d6444()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_e20bb5c22d2243fb9789eecb194b34a8 : HardwiredMemberDescriptor
      {
        internal FLDV_e20bb5c22d2243fb9789eecb194b34a8()
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

      private sealed class FLDV_10afb0d29d264ebeb3f0db1a25f81c80 : HardwiredMemberDescriptor
      {
        internal FLDV_10afb0d29d264ebeb3f0db1a25f81c80()
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

      private sealed class FLDV_9b0421875e9445289c347a0bc7629a1b : HardwiredMemberDescriptor
      {
        internal FLDV_9b0421875e9445289c347a0bc7629a1b()
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

      private sealed class FLDV_dc9cea2c88804f5bba1b74d1eb57b1db : HardwiredMemberDescriptor
      {
        internal FLDV_dc9cea2c88804f5bba1b74d1eb57b1db()
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

    private sealed class TYPE_addf20d8a1e645f38a82f913508a1eb9 : HardwiredUserDataDescriptor
    {
      internal TYPE_addf20d8a1e645f38a82f913508a1eb9()
        : base(typeof (MyPoll.Answer))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_addf20d8a1e645f38a82f913508a1eb9.MTHD_aa746c74ecf24c04a7bd3225069eae63()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_addf20d8a1e645f38a82f913508a1eb9.MTHD_0b7c00a7241f43e1a2e49e32981ca0cf()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_addf20d8a1e645f38a82f913508a1eb9.MTHD_e24c99c500454014acc691ba561e891f()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_addf20d8a1e645f38a82f913508a1eb9.MTHD_2092d6a6219b4b1c8962f62c5f5550b3()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_addf20d8a1e645f38a82f913508a1eb9.MTHD_0c073640b0c142f4b08122204f414258()
        }));
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_addf20d8a1e645f38a82f913508a1eb9.FLDV_02de279d892e4f609ca53613dec1f4fa());
        this.AddMember("allowUserInput", (IMemberDescriptor) new Bridge.TYPE_addf20d8a1e645f38a82f913508a1eb9.FLDV_c51a69f7b2cd4c3faf7d83641b30823f());
        this.AddMember("checkable", (IMemberDescriptor) new Bridge.TYPE_addf20d8a1e645f38a82f913508a1eb9.FLDV_97e7723a9acf42f88f1ef60272b4da9c());
        this.AddMember("userInput", (IMemberDescriptor) new Bridge.TYPE_addf20d8a1e645f38a82f913508a1eb9.FLDV_b7bee5264c674779b236fac080106b0d());
        this.AddMember("isChecked", (IMemberDescriptor) new Bridge.TYPE_addf20d8a1e645f38a82f913508a1eb9.FLDV_c7b71b773ea747b8b2cd3fa4d4650e0d());
      }

      private sealed class MTHD_aa746c74ecf24c04a7bd3225069eae63 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aa746c74ecf24c04a7bd3225069eae63()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Answer();
        }
      }

      private sealed class MTHD_0b7c00a7241f43e1a2e49e32981ca0cf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0b7c00a7241f43e1a2e49e32981ca0cf()
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

      private sealed class MTHD_e24c99c500454014acc691ba561e891f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e24c99c500454014acc691ba561e891f()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_2092d6a6219b4b1c8962f62c5f5550b3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2092d6a6219b4b1c8962f62c5f5550b3()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_0c073640b0c142f4b08122204f414258 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0c073640b0c142f4b08122204f414258()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_02de279d892e4f609ca53613dec1f4fa : HardwiredMemberDescriptor
      {
        internal FLDV_02de279d892e4f609ca53613dec1f4fa()
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

      private sealed class FLDV_c51a69f7b2cd4c3faf7d83641b30823f : HardwiredMemberDescriptor
      {
        internal FLDV_c51a69f7b2cd4c3faf7d83641b30823f()
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

      private sealed class FLDV_97e7723a9acf42f88f1ef60272b4da9c : HardwiredMemberDescriptor
      {
        internal FLDV_97e7723a9acf42f88f1ef60272b4da9c()
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

      private sealed class FLDV_b7bee5264c674779b236fac080106b0d : HardwiredMemberDescriptor
      {
        internal FLDV_b7bee5264c674779b236fac080106b0d()
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

      private sealed class FLDV_c7b71b773ea747b8b2cd3fa4d4650e0d : HardwiredMemberDescriptor
      {
        internal FLDV_c7b71b773ea747b8b2cd3fa4d4650e0d()
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

    private sealed class TYPE_c0b5a7388ec241d1b765077cf439c332 : HardwiredUserDataDescriptor
    {
      internal TYPE_c0b5a7388ec241d1b765077cf439c332()
        : base(typeof (MyPoll))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c0b5a7388ec241d1b765077cf439c332.MTHD_889d5ff2576b457b9eaaa72ba45c2517()
        }));
        this.AddMember("GetQuestionsAsString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetQuestionsAsString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c0b5a7388ec241d1b765077cf439c332.MTHD_9c13f7ebc1514bfe96876fa30185ed89()
        }));
        this.AddMember("SanitizeResponses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("SanitizeResponses", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c0b5a7388ec241d1b765077cf439c332.MTHD_db2e80d8f3e947b59c57105a43c5da41()
        }));
        this.AddMember("addItem", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addItem", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c0b5a7388ec241d1b765077cf439c332.MTHD_2a2721ed7b63499fbe01c114ed522665()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c0b5a7388ec241d1b765077cf439c332.MTHD_743002c91b924929a8c4412f5c5c1548()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c0b5a7388ec241d1b765077cf439c332.MTHD_a2da68251e024cf19b12d3a6e344084c()
        }));
        this.AddMember("fromString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fromString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c0b5a7388ec241d1b765077cf439c332.MTHD_0bb75fe2358c423dbc9d775263bdc2db()
        }));
        this.AddMember("sendToServer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("sendToServer", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c0b5a7388ec241d1b765077cf439c332.MTHD_830ecdc7ce3644c2a87b6b5101599b46()
        }));
        this.AddMember("closePoll", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("closePoll", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c0b5a7388ec241d1b765077cf439c332.MTHD_d9cb9e62be8d4cb083038fdf96649a46()
        }));
        this.AddMember("test", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("test", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c0b5a7388ec241d1b765077cf439c332.MTHD_08106483998e4615b7c0961d3b5778cf()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c0b5a7388ec241d1b765077cf439c332.MTHD_09191f1582224d1d9284223e5406a6d6()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c0b5a7388ec241d1b765077cf439c332.MTHD_bff14057f0e64417a323c3a60ae78fb6()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c0b5a7388ec241d1b765077cf439c332.MTHD_28bcf25705f746f3b2771a26d43a3c7c()
        }));
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_c0b5a7388ec241d1b765077cf439c332.FLDV_77d72d6f00a74e6ca3fd0813f4a323c6());
        this.AddMember("id", (IMemberDescriptor) new Bridge.TYPE_c0b5a7388ec241d1b765077cf439c332.FLDV_3dda759de043482892962be8baa65625());
        this.AddMember("items", (IMemberDescriptor) new Bridge.TYPE_c0b5a7388ec241d1b765077cf439c332.FLDV_ebf3d790ea7841b2b5b856546c674c5c());
        this.AddMember("isPublic", (IMemberDescriptor) new Bridge.TYPE_c0b5a7388ec241d1b765077cf439c332.FLDV_507f52e49af94cb68f7f7b67f1216e06());
        this.AddMember("MsgRetrieve", (IMemberDescriptor) new Bridge.TYPE_c0b5a7388ec241d1b765077cf439c332.FLDV_d779ef0b6b2242b091d92702b35342ce());
        this.AddMember("MsgSubmit", (IMemberDescriptor) new Bridge.TYPE_c0b5a7388ec241d1b765077cf439c332.FLDV_3712676d81af4ab0a55a1dec5cee7e3e());
        this.AddMember("MsgCreate", (IMemberDescriptor) new Bridge.TYPE_c0b5a7388ec241d1b765077cf439c332.FLDV_a9b60c8b51c6429c87c899b658ef36ae());
        this.AddMember("MsgResults", (IMemberDescriptor) new Bridge.TYPE_c0b5a7388ec241d1b765077cf439c332.FLDV_74950c4f280e418c9735427a880fd770());
        this.AddMember("Item", (IMemberDescriptor) new Bridge.TYPE_c0b5a7388ec241d1b765077cf439c332.DVAL_7074b8aefa46478f9b8634e8a3120567());
        this.AddMember("Answer", (IMemberDescriptor) new Bridge.TYPE_c0b5a7388ec241d1b765077cf439c332.DVAL_6eb4ee2203974a89a4ffb5966edc85fc());
      }

      private sealed class MTHD_889d5ff2576b457b9eaaa72ba45c2517 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_889d5ff2576b457b9eaaa72ba45c2517()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll();
        }
      }

      private sealed class MTHD_9c13f7ebc1514bfe96876fa30185ed89 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9c13f7ebc1514bfe96876fa30185ed89()
        {
          this.Initialize("GetQuestionsAsString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).GetQuestionsAsString();
        }
      }

      private sealed class MTHD_db2e80d8f3e947b59c57105a43c5da41 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_db2e80d8f3e947b59c57105a43c5da41()
        {
          this.Initialize("SanitizeResponses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).SanitizeResponses();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_2a2721ed7b63499fbe01c114ed522665 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2a2721ed7b63499fbe01c114ed522665()
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

      private sealed class MTHD_743002c91b924929a8c4412f5c5c1548 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_743002c91b924929a8c4412f5c5c1548()
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

      private sealed class MTHD_a2da68251e024cf19b12d3a6e344084c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a2da68251e024cf19b12d3a6e344084c()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).ToString();
        }
      }

      private sealed class MTHD_0bb75fe2358c423dbc9d775263bdc2db : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0bb75fe2358c423dbc9d775263bdc2db()
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

      private sealed class MTHD_830ecdc7ce3644c2a87b6b5101599b46 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_830ecdc7ce3644c2a87b6b5101599b46()
        {
          this.Initialize("sendToServer", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).sendToServer();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_d9cb9e62be8d4cb083038fdf96649a46 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d9cb9e62be8d4cb083038fdf96649a46()
        {
          this.Initialize("closePoll", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          MyPoll.closePoll();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_08106483998e4615b7c0961d3b5778cf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_08106483998e4615b7c0961d3b5778cf()
        {
          this.Initialize("test", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).test();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_09191f1582224d1d9284223e5406a6d6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_09191f1582224d1d9284223e5406a6d6()
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

      private sealed class MTHD_bff14057f0e64417a323c3a60ae78fb6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bff14057f0e64417a323c3a60ae78fb6()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_28bcf25705f746f3b2771a26d43a3c7c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_28bcf25705f746f3b2771a26d43a3c7c()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_77d72d6f00a74e6ca3fd0813f4a323c6 : HardwiredMemberDescriptor
      {
        internal FLDV_77d72d6f00a74e6ca3fd0813f4a323c6()
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

      private sealed class FLDV_3dda759de043482892962be8baa65625 : HardwiredMemberDescriptor
      {
        internal FLDV_3dda759de043482892962be8baa65625()
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

      private sealed class FLDV_ebf3d790ea7841b2b5b856546c674c5c : HardwiredMemberDescriptor
      {
        internal FLDV_ebf3d790ea7841b2b5b856546c674c5c()
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

      private sealed class FLDV_507f52e49af94cb68f7f7b67f1216e06 : HardwiredMemberDescriptor
      {
        internal FLDV_507f52e49af94cb68f7f7b67f1216e06()
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

      private sealed class FLDV_d779ef0b6b2242b091d92702b35342ce : HardwiredMemberDescriptor
      {
        internal FLDV_d779ef0b6b2242b091d92702b35342ce()
          : base(typeof (byte), "MsgRetrieve", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 1;
        }
      }

      private sealed class FLDV_3712676d81af4ab0a55a1dec5cee7e3e : HardwiredMemberDescriptor
      {
        internal FLDV_3712676d81af4ab0a55a1dec5cee7e3e()
          : base(typeof (byte), "MsgSubmit", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 2;
        }
      }

      private sealed class FLDV_a9b60c8b51c6429c87c899b658ef36ae : HardwiredMemberDescriptor
      {
        internal FLDV_a9b60c8b51c6429c87c899b658ef36ae()
          : base(typeof (byte), "MsgCreate", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 3;
        }
      }

      private sealed class FLDV_74950c4f280e418c9735427a880fd770 : HardwiredMemberDescriptor
      {
        internal FLDV_74950c4f280e418c9735427a880fd770()
          : base(typeof (byte), "MsgResults", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 4;
        }
      }

      private sealed class DVAL_7074b8aefa46478f9b8634e8a3120567 : DynValueMemberDescriptor
      {
        internal DVAL_7074b8aefa46478f9b8634e8a3120567()
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

      private sealed class DVAL_6eb4ee2203974a89a4ffb5966edc85fc : DynValueMemberDescriptor
      {
        internal DVAL_6eb4ee2203974a89a4ffb5966edc85fc()
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

    private sealed class TYPE_de6e718d56d849d59ef4ac096280bc0a : HardwiredUserDataDescriptor
    {
      internal TYPE_de6e718d56d849d59ef4ac096280bc0a()
        : base(typeof (LuaColor))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_de6e718d56d849d59ef4ac096280bc0a.MTHD_068c70e603bd45a4ae89a9a09d996059()
        }));
        this.AddMember("toHex", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("toHex", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_de6e718d56d849d59ef4ac096280bc0a.MTHD_5b155fa9abe543dfa3a475d1702e17d3()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_de6e718d56d849d59ef4ac096280bc0a.MTHD_6ab0aa35968140e6ab2920a21771bd95(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_de6e718d56d849d59ef4ac096280bc0a.MTHD_ec2d8ea0700d4f559dc0d8eeb71c0ad4()
        }));
        this.AddMember("From", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("From", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_de6e718d56d849d59ef4ac096280bc0a.MTHD_75acc1a22b1b44bfbfee3fb75e8a556a(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_de6e718d56d849d59ef4ac096280bc0a.MTHD_9f89cb47a37e45a8ba58d0961aed0953()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_de6e718d56d849d59ef4ac096280bc0a.MTHD_a781ad6173334d1d8076195fb2951b8e()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_de6e718d56d849d59ef4ac096280bc0a.MTHD_8c28029ad99f4d88bdc1549239b2d05a()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_de6e718d56d849d59ef4ac096280bc0a.MTHD_05a7894ce8b540ab872979c25296c75e()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_de6e718d56d849d59ef4ac096280bc0a.MTHD_7d3b84b54c924d1cad71c4a162604774()
        }));
        this.AddMember("r", (IMemberDescriptor) new Bridge.TYPE_de6e718d56d849d59ef4ac096280bc0a.FLDV_fb132e23d1854880af64e4063f6053a0());
        this.AddMember("g", (IMemberDescriptor) new Bridge.TYPE_de6e718d56d849d59ef4ac096280bc0a.FLDV_a8f473cc62524d8ba830784df9a706d9());
        this.AddMember("b", (IMemberDescriptor) new Bridge.TYPE_de6e718d56d849d59ef4ac096280bc0a.FLDV_f9ad83a747ff4d50961d7f2a70232db6());
        this.AddMember("a", (IMemberDescriptor) new Bridge.TYPE_de6e718d56d849d59ef4ac096280bc0a.FLDV_aec795ba638546678a65506772e63ca5());
        this.AddMember("white", (IMemberDescriptor) new Bridge.TYPE_de6e718d56d849d59ef4ac096280bc0a.FLDV_1613f812ff89419d8c6fc5cedf8a534b());
      }

      private sealed class MTHD_068c70e603bd45a4ae89a9a09d996059 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_068c70e603bd45a4ae89a9a09d996059()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new LuaColor();
        }
      }

      private sealed class MTHD_5b155fa9abe543dfa3a475d1702e17d3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5b155fa9abe543dfa3a475d1702e17d3()
        {
          this.Initialize("toHex", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((LuaColor) obj).toHex();
        }
      }

      private sealed class MTHD_6ab0aa35968140e6ab2920a21771bd95 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6ab0aa35968140e6ab2920a21771bd95()
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

      private sealed class MTHD_ec2d8ea0700d4f559dc0d8eeb71c0ad4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ec2d8ea0700d4f559dc0d8eeb71c0ad4()
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

      private sealed class MTHD_75acc1a22b1b44bfbfee3fb75e8a556a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_75acc1a22b1b44bfbfee3fb75e8a556a()
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

      private sealed class MTHD_9f89cb47a37e45a8ba58d0961aed0953 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9f89cb47a37e45a8ba58d0961aed0953()
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

      private sealed class MTHD_a781ad6173334d1d8076195fb2951b8e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a781ad6173334d1d8076195fb2951b8e()
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

      private sealed class MTHD_8c28029ad99f4d88bdc1549239b2d05a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8c28029ad99f4d88bdc1549239b2d05a()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_05a7894ce8b540ab872979c25296c75e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_05a7894ce8b540ab872979c25296c75e()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_7d3b84b54c924d1cad71c4a162604774 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7d3b84b54c924d1cad71c4a162604774()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_fb132e23d1854880af64e4063f6053a0 : HardwiredMemberDescriptor
      {
        internal FLDV_fb132e23d1854880af64e4063f6053a0()
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

      private sealed class FLDV_a8f473cc62524d8ba830784df9a706d9 : HardwiredMemberDescriptor
      {
        internal FLDV_a8f473cc62524d8ba830784df9a706d9()
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

      private sealed class FLDV_f9ad83a747ff4d50961d7f2a70232db6 : HardwiredMemberDescriptor
      {
        internal FLDV_f9ad83a747ff4d50961d7f2a70232db6()
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

      private sealed class FLDV_aec795ba638546678a65506772e63ca5 : HardwiredMemberDescriptor
      {
        internal FLDV_aec795ba638546678a65506772e63ca5()
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

      private sealed class FLDV_1613f812ff89419d8c6fc5cedf8a534b : HardwiredMemberDescriptor
      {
        internal FLDV_1613f812ff89419d8c6fc5cedf8a534b()
          : base(typeof (LuaColor), "white", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) LuaColor.white;
        }
      }
    }

    private sealed class TYPE_3b2e353d187240c9acc975cefd38bcf9 : HardwiredUserDataDescriptor
    {
      internal TYPE_3b2e353d187240c9acc975cefd38bcf9()
        : base(typeof (TalkOptions))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3b2e353d187240c9acc975cefd38bcf9.MTHD_c19979634392416c93801b1865183a94()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3b2e353d187240c9acc975cefd38bcf9.MTHD_2178a3313bd84d15ab89095bfa23cb99()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3b2e353d187240c9acc975cefd38bcf9.MTHD_41d57c71ce7a4cb389c67a537121686c()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3b2e353d187240c9acc975cefd38bcf9.MTHD_274114f870f94242915c06742d8ea294()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3b2e353d187240c9acc975cefd38bcf9.MTHD_7a17b513c6ef42b1ae5a793777cb99a8()
        }));
      }

      private sealed class MTHD_c19979634392416c93801b1865183a94 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c19979634392416c93801b1865183a94()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new TalkOptions();
        }
      }

      private sealed class MTHD_2178a3313bd84d15ab89095bfa23cb99 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2178a3313bd84d15ab89095bfa23cb99()
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

      private sealed class MTHD_41d57c71ce7a4cb389c67a537121686c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_41d57c71ce7a4cb389c67a537121686c()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_274114f870f94242915c06742d8ea294 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_274114f870f94242915c06742d8ea294()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_7a17b513c6ef42b1ae5a793777cb99a8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7a17b513c6ef42b1ae5a793777cb99a8()
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
