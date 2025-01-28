
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
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_f02861a3a773466dba2302f163553d9b());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_af7d8213227c4316bbc580d77aae24b3());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_7144828b165440668f329f8b6e4cade4());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_a824fa2a52584d53af8602aa1e466df4());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_bec8410e7d094e898f08622fd13a6bc3());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_c336838a44cf42c985b3cf4cb56f0883());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_b767b971714b4f1b9947612e40681a6e());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_2f03151ef2bb45d4a7eee688bc4a8158());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_369a5f136f05447887db257d476cf0be());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_38a48c32d6de49cab91487eb12df019a());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_6461a4288d1a4ff8b39cc68b978df6f8());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_92ffb8f50fa54db7bb1885c07c7b92c2());
    }

    private sealed class TYPE_44eecac7fd024a3381120a37c0db2a60 : HardwiredUserDataDescriptor
    {
      internal TYPE_44eecac7fd024a3381120a37c0db2a60()
        : base(typeof (ContainerGame))
      {
        this.AddMember("getUser", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getUser", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_d26165d10b424f75a079b479a67050d0()
        }));
        this.AddMember("getPlayers", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayers", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_0313ce2edc35480e9706765c67cf094d()
        }));
        this.AddMember("getPlayerCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayerCount", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_810c5aa760984095a1501165594411a2()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_58dd7bad6519482c8e2ee87592c1c457()
        }));
        this.AddMember("findCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_4decfef3cd574681b544b6d743b53236()
        }));
        this.AddMember("findEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findEffectors", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_32fe470986f64bdab9712b6237cc8237()
        }));
        this.AddMember("LineCast", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCast", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_a6e007fbf5444dbc9d76687e855c6172()
        }));
        this.AddMember("LineCastOnlyCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_240c6407ff504ba6984be892a7b647a3()
        }));
        this.AddMember("LineCastOnlyTerrain", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyTerrain", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_2797a5e762ab4cbba001f06444a06b2b()
        }));
        this.AddMember("ShowInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ShowInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_4345b9fdb245475c9fe7e9749f992be8()
        }));
        this.AddMember("hideInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("hideInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_991827fcce61415182b88f44314d504d()
        }));
        this.AddMember("Talk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Talk", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_07260af34f55499cbde158432592bedb()
        }));
        this.AddMember("get_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_996d738934d74b39aea4fd5e044ed12d()
        }));
        this.AddMember("set_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_19dcbd233ee540438921808b290a2fac()
        }));
        this.AddMember("get_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_3fd1ac8579dd4edd95f4f5a5522b94d2()
        }));
        this.AddMember("set_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_0b9c9a9645134f75873a0d003b01f186()
        }));
        this.AddMember("get_totalTimeElapsed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_totalTimeElapsed", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_8d09755a68144fcc88c153f7d03e0a67()
        }));
        this.AddMember("get_turnTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnTime", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_49e10b1d358f403b957659630f2805fe()
        }));
        this.AddMember("get_frame", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frame", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_6a9817ed4e23445c8bccfa23d2e521c9()
        }));
        this.AddMember("random", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("random", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_cc9480b7350347a6ba487e0d7f8dd811()
        }));
        this.AddMember("get_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_c3f3dec5f5034059b4a6691cefa91a56()
        }));
        this.AddMember("set_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_fbbcd6f91c0c48899d31d2f3cadf1faa()
        }));
        this.AddMember("get_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_553e3699c41b4d398879c5884ddc5f93()
        }));
        this.AddMember("set_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_a435ca946c5643cbac4de767b9c36440()
        }));
        this.AddMember("get_allowMinionMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMinionMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_aa05344119fc4b629bbd21022203c96f()
        }));
        this.AddMember("set_allowMinionMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMinionMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_d690d6e5fb9146e4a2b4a8408177141c()
        }));
        this.AddMember("get_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_9ad9ca9bfa8a4fa89a16ce5c540f76ba()
        }));
        this.AddMember("set_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_8c4724c4b52b4c958cef7bdfaa5fca1a()
        }));
        this.AddMember("get_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_107f8b8ebd9c4fca92005ee033ef97e8()
        }));
        this.AddMember("set_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_3700c69de0ad4e10b32a8df6d192a553()
        }));
        this.AddMember("get_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_71e97cca1be74a698335862f4c0650b3()
        }));
        this.AddMember("set_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_50164e6a562442b89c463b49ac30a7e2()
        }));
        this.AddMember("get_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_ffceba2cfdce47a5985dd7e139985c26()
        }));
        this.AddMember("set_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_cbc35922ae594ad293f3cc81d8b0925a()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_2cb3481f9be9416bac22b4050b215527()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_cf5f5b2fe82c426cb61df0b671df9ad5()
        }));
        this.AddMember("get_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_6bcff77cbbbf44da8c8265c828bc9d6c()
        }));
        this.AddMember("set_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_49aae5b204614b8ab4f48805ebaef223()
        }));
        this.AddMember("get_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_f16b1ab296d146edb11a53ace62e3ead()
        }));
        this.AddMember("set_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_779821b0e02e41d4a46cee73d7eafc9f()
        }));
        this.AddMember("get_waiting", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waiting", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_b97c2c35ca5d4e329d9e42a6b882e534()
        }));
        this.AddMember("get_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_4271816381b44127a4f15fc51004d5db()
        }));
        this.AddMember("set_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_e2ba8a11e5724cb391231ae9c15abf79()
        }));
        this.AddMember("get_busy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_busy", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_74fed80b7195488abb97caf753220433()
        }));
        this.AddMember("get_ongoing", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_ongoing", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_79508019c6a54ab5a61ed70ef66661c8()
        }));
        this.AddMember("get_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_d53d666157cc4dc1ab93f678d9dbada6()
        }));
        this.AddMember("set_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_283903c8b9114e93bf8f276616cb7665()
        }));
        this.AddMember("get_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_b3d7cbf1aabf462290a1e3f1f8deb573()
        }));
        this.AddMember("set_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_e9a85d1a08d94ad39d4213cbed1a0ef4()
        }));
        this.AddMember("get_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_3882c1215bd547f2a80ba77d3ef78b47()
        }));
        this.AddMember("set_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_1dc0c98eea27437789207304990bea6f()
        }));
        this.AddMember("get_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_328fbe77386e4a7f910615384381e54d()
        }));
        this.AddMember("set_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_2d93b43d04974789a18cb437569a73e6()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_2c499b9f556d477ca52c1277f20db420()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_b3be8e2dc5ec4ba58587580a395c6ee4()
        }));
        this.AddMember("get_mousePosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mousePosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_eb7df843d9b842b3a3e8ac6c1b7ae6bc()
        }));
        this.AddMember("get_mouseOverUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mouseOverUI", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_893ca5c231ee492895edb779bf3a1dd2()
        }));
        this.AddMember("worldToCanvas", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("worldToCanvas", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_7d7dc3df6368470090875a43731f33cb()
        }));
        this.AddMember("canvasToWorld", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("canvasToWorld", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_727d2e4626b34c178593b908ec6786da()
        }));
        this.AddMember("get_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_b34c1f013e7e4d518ecc7cb234efcf89()
        }));
        this.AddMember("set_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_24ba52902d714ab3a2304bc40ab4ae22()
        }));
        this.AddMember("get_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_2a0c722f01a64672908e32ecc33e41aa()
        }));
        this.AddMember("set_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_161c7108aca44767b960b3fb9ad6710b()
        }));
        this.AddMember("getMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_fbd2fddb75ea4626bdd5e4ca638c3f69()
        }));
        this.AddMember("setMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_085e508e169e4fb6b4f4f79cd5ccb77a()
        }));
        this.AddMember("Dispose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Dispose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_f7c4cf0ddb084b0da90b9ffbcf1c34a5()
        }));
        this.AddMember("drawImage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawImage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_8a4d40c3bade4b599d5f4f770ec9d852()
        }));
        this.AddMember("drawRectangle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawRectangle", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_6393fc4dff4c43e086f1aa7f541d83dd()
        }));
        this.AddMember("drawEllipseOutline", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipseOutline", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_5f253ce32b744dcbb7cbd86d8b13ba28()
        }));
        this.AddMember("drawEllipse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipse", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_80cca1929fd244128025f0d6f8c5c67b()
        }));
        this.AddMember("blit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_d67475a60f494e27a94c72fed65d2e59()
        }));
        this.AddMember("blitRotate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blitRotate", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_102eabc3a531423fb286b7c08d287e0e()
        }));
        this.AddMember("applyDraw", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("applyDraw", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_e6921273e0f14d0d977756385febfbbc()
        }));
        this.AddMember("get_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_e0e0606ee44b4ee4bb4f0cbf629570d6()
        }));
        this.AddMember("set_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_9af0d67ba62a4afdb01afda7c29e2285()
        }));
        this.AddMember("get_isUsingTouchControls", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isUsingTouchControls", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_cd9e8c5afbb34c238d1a3053e2c83016()
        }));
        this.AddMember("clientRefreshSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clientRefreshSpells", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_b577dd9c370e4380a5c42d7605db759e()
        }));
        this.AddMember("startCoroutine", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("startCoroutine", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_fffdf8d34e674f778a823d842a2bf8f0()
        }));
        this.AddMember("devCommand", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("devCommand", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_18abc9160ec743ea99bb532c635051bf()
        }));
        this.AddMember("win", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("win", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_16c3635aa10545d2a3e9e13f6905f91c()
        }));
        this.AddMember("lose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("lose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_d31e9ab2fc2c4866813e3f9b8e06d9d7()
        }));
        this.AddMember("nextTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("nextTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_afada59751d24396b98a45034062dac2()
        }));
        this.AddMember("resetMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("resetMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_0f9131c6a76f4e8c865f881cd0fb3d12()
        }));
        this.AddMember("clearMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_681f71b17b2c4e81ad9472c7e24ad9d0()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_296ab0bcb51447a0b2ecfda37cb126d4()
        }));
        this.AddMember("getSpellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellEnum", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_4410fcc6aa564c8494bb05372c5b1d9b()
        }));
        this.AddMember("getSpellName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_4e60510c32414489b9c16f93c2dee8ab()
        }));
        this.AddMember("getMapID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapID", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_468c21dce1c24d9e83c2224ce0788516()
        }));
        this.AddMember("getMapRealName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapRealName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_739185104eee48179a27c023101ad292()
        }));
        this.AddMember("getMapShortName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapShortName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_6b8d1cf880464807914cb2114c542bef()
        }));
        this.AddMember("getArmageddonName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getArmageddonName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_69f6c0c435d347e887911b9b35409d85()
        }));
        this.AddMember("panCamera", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("panCamera", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_85137326696a41f0bfdd4f0983576a8f()
        }));
        this.AddMember("cameraFollow", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("cameraFollow", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_058db2fc0b9c4947a6fb6b2445df386b()
        }));
        this.AddMember("getInputString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getInputString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_779dc8c809824e98a3c2876d761a81f7()
        }));
        this.AddMember("get_screenWidth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenWidth", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_1d51b2e245384ef99af16d774bfc7847()
        }));
        this.AddMember("get_screenHeight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenHeight", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_27e83cfc02464e9599d00b63d2eb5bfc()
        }));
        this.AddMember("createCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createCreature", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_8a7588cae1c24a408291a6c4cf14d963()
        }));
        this.AddMember("clearIndicators", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearIndicators", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_d2887d921bf7401e8393e8ec387c11dc()
        }));
        this.AddMember("createIndicator", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createIndicator", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_e52e20934b634116ae939ffd7b99817f(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_13b1c761eb4443958e1dd8c3463a18e0()
        }));
        this.AddMember("getKeyBinds", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getKeyBinds", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_1b7569fb91374bb798c31e7a2a496414()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_79ad9aeeca464c79a8eb2a2041974801()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_56cd36bbf6614faea5f3a2b0aafe05a4()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_f7aa9e63b37647dfb5abd7b1b1fdef1a()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.MTHD_245a2801baf5413c937c313b78d54779()
        }));
        this.AddMember("turn", (IMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.PROP_66739a3a5e594c89bdec3c7e878e90a8());
        this.AddMember("timeLimit", (IMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.PROP_c747a4088b9d4d5b91d04672d3662483());
        this.AddMember("totalTimeElapsed", (IMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.PROP_eda597d0f72242a6b0e9118d29382659());
        this.AddMember("turnTime", (IMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.PROP_1cd8d0c7f8ae4f5f9f398766e01cec68());
        this.AddMember("frame", (IMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.PROP_c7525ccb91d54ff7b367b762e2fd2c43());
        this.AddMember("winOnDeath", (IMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.PROP_8dc959ea4177457c8e8b71051499c050());
        this.AddMember("allowMovement", (IMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.PROP_748a382a491a48bb9c6aa5141b47ab9e());
        this.AddMember("allowMinionMovement", (IMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.PROP_4f2abd62615c43d5a17880bdbcd9589a());
        this.AddMember("allowInput", (IMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.PROP_e5bf2e1e1c234c3986bf77463db032e3());
        this.AddMember("allowCallbacks", (IMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.PROP_3c3d026d1f1544d2886ba4e5a9dac6b4());
        this.AddMember("allowSkipTurn", (IMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.PROP_2f443b9e7efd4ad2b3bd28801e30b50d());
        this.AddMember("terrainDestruction", (IMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.PROP_7b4d380cf17c4314b0d519bd5c60fe46());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.PROP_a2bea0a3d7e0416a8d0c0c4516fd9067());
        this.AddMember("armageddon", (IMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.PROP_fa63d0f8cc94427281e5cd61b0f6202c());
        this.AddMember("armageddonTurn", (IMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.PROP_f8d7929a7b2d49968e29df0d5ca88557());
        this.AddMember("waiting", (IMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.PROP_eed7331f9eb149759982d5679794856d());
        this.AddMember("paused", (IMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.PROP_8133bdbc52b744078c184fece6cf34e7());
        this.AddMember("busy", (IMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.PROP_214a361c5fdb4272a1c7e81648d0f18e());
        this.AddMember("ongoing", (IMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.PROP_ebaa22092b294893879259d55f9f7ca7());
        this.AddMember("gravity", (IMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.PROP_2426e09dcb5045b3a8f1471d2c099f02());
        this.AddMember("wind", (IMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.PROP_3184fbf55d924e049fbfd847e7c96494());
        this.AddMember("windDir", (IMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.PROP_b62f74776ffd467aaa926003feff6b8a());
        this.AddMember("windPower", (IMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.PROP_a9e53609f57540e3861a0ae7caa29535());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.PROP_9b0ca29e29fc4001b769327d15c14ddc());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.PROP_51a8a42dbaf8491ca2cf7cc5cabad5e8());
        this.AddMember("mousePosition", (IMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.PROP_05687f1211d0441fbb2ea319ba1263f3());
        this.AddMember("mouseOverUI", (IMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.PROP_fd6a4a99a639468fa10f01fb5fd80fd2());
        this.AddMember("cameraPosition", (IMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.PROP_66e10c3e0a9941bcb6fae6b8ad989cba());
        this.AddMember("cameraZoom", (IMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.PROP_e45d1213c5da4a71ae53a0bfd05d971b());
        this.AddMember("allowBounce", (IMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.PROP_88f47d0f3a3447bf9bda5fb86bbe56bc());
        this.AddMember("isUsingTouchControls", (IMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.PROP_405af4a9c8854aa18790aa0f1d9e1555());
        this.AddMember("screenWidth", (IMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.PROP_f4fe44b83dcf46848df6a34e3c9c38e0());
        this.AddMember("screenHeight", (IMemberDescriptor) new Bridge.TYPE_44eecac7fd024a3381120a37c0db2a60.PROP_061398b81e7749b1805fff5411eccda1());
      }

      private sealed class MTHD_d26165d10b424f75a079b479a67050d0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d26165d10b424f75a079b479a67050d0()
        {
          this.Initialize("getUser", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getUser();
        }
      }

      private sealed class MTHD_0313ce2edc35480e9706765c67cf094d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0313ce2edc35480e9706765c67cf094d()
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

      private sealed class MTHD_810c5aa760984095a1501165594411a2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_810c5aa760984095a1501165594411a2()
        {
          this.Initialize("getPlayerCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getPlayerCount();
        }
      }

      private sealed class MTHD_58dd7bad6519482c8e2ee87592c1c457 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_58dd7bad6519482c8e2ee87592c1c457()
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

      private sealed class MTHD_4decfef3cd574681b544b6d743b53236 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4decfef3cd574681b544b6d743b53236()
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

      private sealed class MTHD_32fe470986f64bdab9712b6237cc8237 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_32fe470986f64bdab9712b6237cc8237()
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

      private sealed class MTHD_a6e007fbf5444dbc9d76687e855c6172 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a6e007fbf5444dbc9d76687e855c6172()
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

      private sealed class MTHD_240c6407ff504ba6984be892a7b647a3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_240c6407ff504ba6984be892a7b647a3()
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

      private sealed class MTHD_2797a5e762ab4cbba001f06444a06b2b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2797a5e762ab4cbba001f06444a06b2b()
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

      private sealed class MTHD_4345b9fdb245475c9fe7e9749f992be8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4345b9fdb245475c9fe7e9749f992be8()
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

      private sealed class MTHD_991827fcce61415182b88f44314d504d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_991827fcce61415182b88f44314d504d()
        {
          this.Initialize("hideInfo", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).hideInfo();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_07260af34f55499cbde158432592bedb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_07260af34f55499cbde158432592bedb()
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

      private sealed class MTHD_996d738934d74b39aea4fd5e044ed12d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_996d738934d74b39aea4fd5e044ed12d()
        {
          this.Initialize("get_turn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turn;
        }
      }

      private sealed class MTHD_19dcbd233ee540438921808b290a2fac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_19dcbd233ee540438921808b290a2fac()
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

      private sealed class MTHD_3fd1ac8579dd4edd95f4f5a5522b94d2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3fd1ac8579dd4edd95f4f5a5522b94d2()
        {
          this.Initialize("get_timeLimit", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).timeLimit;
        }
      }

      private sealed class MTHD_0b9c9a9645134f75873a0d003b01f186 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0b9c9a9645134f75873a0d003b01f186()
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

      private sealed class MTHD_8d09755a68144fcc88c153f7d03e0a67 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8d09755a68144fcc88c153f7d03e0a67()
        {
          this.Initialize("get_totalTimeElapsed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class MTHD_49e10b1d358f403b957659630f2805fe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_49e10b1d358f403b957659630f2805fe()
        {
          this.Initialize("get_turnTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class MTHD_6a9817ed4e23445c8bccfa23d2e521c9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6a9817ed4e23445c8bccfa23d2e521c9()
        {
          this.Initialize("get_frame", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class MTHD_cc9480b7350347a6ba487e0d7f8dd811 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cc9480b7350347a6ba487e0d7f8dd811()
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

      private sealed class MTHD_c3f3dec5f5034059b4a6691cefa91a56 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c3f3dec5f5034059b4a6691cefa91a56()
        {
          this.Initialize("get_winOnDeath", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).winOnDeath;
        }
      }

      private sealed class MTHD_fbbcd6f91c0c48899d31d2f3cadf1faa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fbbcd6f91c0c48899d31d2f3cadf1faa()
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

      private sealed class MTHD_553e3699c41b4d398879c5884ddc5f93 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_553e3699c41b4d398879c5884ddc5f93()
        {
          this.Initialize("get_allowMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMovement;
        }
      }

      private sealed class MTHD_a435ca946c5643cbac4de767b9c36440 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a435ca946c5643cbac4de767b9c36440()
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

      private sealed class MTHD_aa05344119fc4b629bbd21022203c96f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aa05344119fc4b629bbd21022203c96f()
        {
          this.Initialize("get_allowMinionMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMinionMovement;
        }
      }

      private sealed class MTHD_d690d6e5fb9146e4a2b4a8408177141c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d690d6e5fb9146e4a2b4a8408177141c()
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

      private sealed class MTHD_9ad9ca9bfa8a4fa89a16ce5c540f76ba : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9ad9ca9bfa8a4fa89a16ce5c540f76ba()
        {
          this.Initialize("get_allowInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowInput;
        }
      }

      private sealed class MTHD_8c4724c4b52b4c958cef7bdfaa5fca1a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8c4724c4b52b4c958cef7bdfaa5fca1a()
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

      private sealed class MTHD_107f8b8ebd9c4fca92005ee033ef97e8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_107f8b8ebd9c4fca92005ee033ef97e8()
        {
          this.Initialize("get_allowCallbacks", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowCallbacks;
        }
      }

      private sealed class MTHD_3700c69de0ad4e10b32a8df6d192a553 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3700c69de0ad4e10b32a8df6d192a553()
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

      private sealed class MTHD_71e97cca1be74a698335862f4c0650b3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_71e97cca1be74a698335862f4c0650b3()
        {
          this.Initialize("get_allowSkipTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowSkipTurn;
        }
      }

      private sealed class MTHD_50164e6a562442b89c463b49ac30a7e2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_50164e6a562442b89c463b49ac30a7e2()
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

      private sealed class MTHD_ffceba2cfdce47a5985dd7e139985c26 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ffceba2cfdce47a5985dd7e139985c26()
        {
          this.Initialize("get_terrainDestruction", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).terrainDestruction;
        }
      }

      private sealed class MTHD_cbc35922ae594ad293f3cc81d8b0925a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cbc35922ae594ad293f3cc81d8b0925a()
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

      private sealed class MTHD_2cb3481f9be9416bac22b4050b215527 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2cb3481f9be9416bac22b4050b215527()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).takeDamage;
        }
      }

      private sealed class MTHD_cf5f5b2fe82c426cb61df0b671df9ad5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cf5f5b2fe82c426cb61df0b671df9ad5()
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

      private sealed class MTHD_6bcff77cbbbf44da8c8265c828bc9d6c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6bcff77cbbbf44da8c8265c828bc9d6c()
        {
          this.Initialize("get_armageddon", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddon;
        }
      }

      private sealed class MTHD_49aae5b204614b8ab4f48805ebaef223 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_49aae5b204614b8ab4f48805ebaef223()
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

      private sealed class MTHD_f16b1ab296d146edb11a53ace62e3ead : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f16b1ab296d146edb11a53ace62e3ead()
        {
          this.Initialize("get_armageddonTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddonTurn;
        }
      }

      private sealed class MTHD_779821b0e02e41d4a46cee73d7eafc9f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_779821b0e02e41d4a46cee73d7eafc9f()
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

      private sealed class MTHD_b97c2c35ca5d4e329d9e42a6b882e534 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b97c2c35ca5d4e329d9e42a6b882e534()
        {
          this.Initialize("get_waiting", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class MTHD_4271816381b44127a4f15fc51004d5db : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4271816381b44127a4f15fc51004d5db()
        {
          this.Initialize("get_paused", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).paused;
        }
      }

      private sealed class MTHD_e2ba8a11e5724cb391231ae9c15abf79 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e2ba8a11e5724cb391231ae9c15abf79()
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

      private sealed class MTHD_74fed80b7195488abb97caf753220433 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_74fed80b7195488abb97caf753220433()
        {
          this.Initialize("get_busy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class MTHD_79508019c6a54ab5a61ed70ef66661c8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_79508019c6a54ab5a61ed70ef66661c8()
        {
          this.Initialize("get_ongoing", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class MTHD_d53d666157cc4dc1ab93f678d9dbada6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d53d666157cc4dc1ab93f678d9dbada6()
        {
          this.Initialize("get_gravity", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).gravity;
        }
      }

      private sealed class MTHD_283903c8b9114e93bf8f276616cb7665 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_283903c8b9114e93bf8f276616cb7665()
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

      private sealed class MTHD_b3d7cbf1aabf462290a1e3f1f8deb573 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b3d7cbf1aabf462290a1e3f1f8deb573()
        {
          this.Initialize("get_wind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).wind;
        }
      }

      private sealed class MTHD_e9a85d1a08d94ad39d4213cbed1a0ef4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e9a85d1a08d94ad39d4213cbed1a0ef4()
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

      private sealed class MTHD_3882c1215bd547f2a80ba77d3ef78b47 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3882c1215bd547f2a80ba77d3ef78b47()
        {
          this.Initialize("get_windDir", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windDir;
        }
      }

      private sealed class MTHD_1dc0c98eea27437789207304990bea6f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1dc0c98eea27437789207304990bea6f()
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

      private sealed class MTHD_328fbe77386e4a7f910615384381e54d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_328fbe77386e4a7f910615384381e54d()
        {
          this.Initialize("get_windPower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windPower;
        }
      }

      private sealed class MTHD_2d93b43d04974789a18cb437569a73e6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2d93b43d04974789a18cb437569a73e6()
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

      private sealed class MTHD_2c499b9f556d477ca52c1277f20db420 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2c499b9f556d477ca52c1277f20db420()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class MTHD_b3be8e2dc5ec4ba58587580a395c6ee4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b3be8e2dc5ec4ba58587580a395c6ee4()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class MTHD_eb7df843d9b842b3a3e8ac6c1b7ae6bc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eb7df843d9b842b3a3e8ac6c1b7ae6bc()
        {
          this.Initialize("get_mousePosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class MTHD_893ca5c231ee492895edb779bf3a1dd2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_893ca5c231ee492895edb779bf3a1dd2()
        {
          this.Initialize("get_mouseOverUI", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class MTHD_7d7dc3df6368470090875a43731f33cb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7d7dc3df6368470090875a43731f33cb()
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

      private sealed class MTHD_727d2e4626b34c178593b908ec6786da : HardwiredMethodMemberDescriptor
      {
        internal MTHD_727d2e4626b34c178593b908ec6786da()
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

      private sealed class MTHD_b34c1f013e7e4d518ecc7cb234efcf89 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b34c1f013e7e4d518ecc7cb234efcf89()
        {
          this.Initialize("get_cameraPosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraPosition;
        }
      }

      private sealed class MTHD_24ba52902d714ab3a2304bc40ab4ae22 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_24ba52902d714ab3a2304bc40ab4ae22()
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

      private sealed class MTHD_2a0c722f01a64672908e32ecc33e41aa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2a0c722f01a64672908e32ecc33e41aa()
        {
          this.Initialize("get_cameraZoom", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraZoom;
        }
      }

      private sealed class MTHD_161c7108aca44767b960b3fb9ad6710b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_161c7108aca44767b960b3fb9ad6710b()
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

      private sealed class MTHD_fbd2fddb75ea4626bdd5e4ca638c3f69 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fbd2fddb75ea4626bdd5e4ca638c3f69()
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

      private sealed class MTHD_085e508e169e4fb6b4f4f79cd5ccb77a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_085e508e169e4fb6b4f4f79cd5ccb77a()
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

      private sealed class MTHD_f7c4cf0ddb084b0da90b9ffbcf1c34a5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f7c4cf0ddb084b0da90b9ffbcf1c34a5()
        {
          this.Initialize("Dispose", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ContainerGame.Dispose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_8a4d40c3bade4b599d5f4f770ec9d852 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8a4d40c3bade4b599d5f4f770ec9d852()
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

      private sealed class MTHD_6393fc4dff4c43e086f1aa7f541d83dd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6393fc4dff4c43e086f1aa7f541d83dd()
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

      private sealed class MTHD_5f253ce32b744dcbb7cbd86d8b13ba28 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5f253ce32b744dcbb7cbd86d8b13ba28()
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

      private sealed class MTHD_80cca1929fd244128025f0d6f8c5c67b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_80cca1929fd244128025f0d6f8c5c67b()
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

      private sealed class MTHD_d67475a60f494e27a94c72fed65d2e59 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d67475a60f494e27a94c72fed65d2e59()
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

      private sealed class MTHD_102eabc3a531423fb286b7c08d287e0e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_102eabc3a531423fb286b7c08d287e0e()
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

      private sealed class MTHD_e6921273e0f14d0d977756385febfbbc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e6921273e0f14d0d977756385febfbbc()
        {
          this.Initialize("applyDraw", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).applyDraw();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_e0e0606ee44b4ee4bb4f0cbf629570d6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e0e0606ee44b4ee4bb4f0cbf629570d6()
        {
          this.Initialize("get_allowBounce", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowBounce;
        }
      }

      private sealed class MTHD_9af0d67ba62a4afdb01afda7c29e2285 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9af0d67ba62a4afdb01afda7c29e2285()
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

      private sealed class MTHD_cd9e8c5afbb34c238d1a3053e2c83016 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cd9e8c5afbb34c238d1a3053e2c83016()
        {
          this.Initialize("get_isUsingTouchControls", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class MTHD_b577dd9c370e4380a5c42d7605db759e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b577dd9c370e4380a5c42d7605db759e()
        {
          this.Initialize("clientRefreshSpells", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clientRefreshSpells();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_fffdf8d34e674f778a823d842a2bf8f0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fffdf8d34e674f778a823d842a2bf8f0()
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

      private sealed class MTHD_18abc9160ec743ea99bb532c635051bf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_18abc9160ec743ea99bb532c635051bf()
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

      private sealed class MTHD_16c3635aa10545d2a3e9e13f6905f91c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_16c3635aa10545d2a3e9e13f6905f91c()
        {
          this.Initialize("win", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).win();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_d31e9ab2fc2c4866813e3f9b8e06d9d7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d31e9ab2fc2c4866813e3f9b8e06d9d7()
        {
          this.Initialize("lose", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).lose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_afada59751d24396b98a45034062dac2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_afada59751d24396b98a45034062dac2()
        {
          this.Initialize("nextTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).nextTurn();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_0f9131c6a76f4e8c865f881cd0fb3d12 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0f9131c6a76f4e8c865f881cd0fb3d12()
        {
          this.Initialize("resetMap", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).resetMap();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_681f71b17b2c4e81ad9472c7e24ad9d0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_681f71b17b2c4e81ad9472c7e24ad9d0()
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

      private sealed class MTHD_296ab0bcb51447a0b2ecfda37cb126d4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_296ab0bcb51447a0b2ecfda37cb126d4()
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

      private sealed class MTHD_4410fcc6aa564c8494bb05372c5b1d9b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4410fcc6aa564c8494bb05372c5b1d9b()
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

      private sealed class MTHD_4e60510c32414489b9c16f93c2dee8ab : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4e60510c32414489b9c16f93c2dee8ab()
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

      private sealed class MTHD_468c21dce1c24d9e83c2224ce0788516 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_468c21dce1c24d9e83c2224ce0788516()
        {
          this.Initialize("getMapID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getMapID();
        }
      }

      private sealed class MTHD_739185104eee48179a27c023101ad292 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_739185104eee48179a27c023101ad292()
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

      private sealed class MTHD_6b8d1cf880464807914cb2114c542bef : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6b8d1cf880464807914cb2114c542bef()
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

      private sealed class MTHD_69f6c0c435d347e887911b9b35409d85 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_69f6c0c435d347e887911b9b35409d85()
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

      private sealed class MTHD_85137326696a41f0bfdd4f0983576a8f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_85137326696a41f0bfdd4f0983576a8f()
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

      private sealed class MTHD_058db2fc0b9c4947a6fb6b2445df386b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_058db2fc0b9c4947a6fb6b2445df386b()
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

      private sealed class MTHD_779dc8c809824e98a3c2876d761a81f7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_779dc8c809824e98a3c2876d761a81f7()
        {
          this.Initialize("getInputString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getInputString();
        }
      }

      private sealed class MTHD_1d51b2e245384ef99af16d774bfc7847 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1d51b2e245384ef99af16d774bfc7847()
        {
          this.Initialize("get_screenWidth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class MTHD_27e83cfc02464e9599d00b63d2eb5bfc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_27e83cfc02464e9599d00b63d2eb5bfc()
        {
          this.Initialize("get_screenHeight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }

      private sealed class MTHD_8a7588cae1c24a408291a6c4cf14d963 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8a7588cae1c24a408291a6c4cf14d963()
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

      private sealed class MTHD_d2887d921bf7401e8393e8ec387c11dc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d2887d921bf7401e8393e8ec387c11dc()
        {
          this.Initialize("clearIndicators", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clearIndicators();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_e52e20934b634116ae939ffd7b99817f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e52e20934b634116ae939ffd7b99817f()
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

      private sealed class MTHD_13b1c761eb4443958e1dd8c3463a18e0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_13b1c761eb4443958e1dd8c3463a18e0()
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

      private sealed class MTHD_1b7569fb91374bb798c31e7a2a496414 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1b7569fb91374bb798c31e7a2a496414()
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

      private sealed class MTHD_79ad9aeeca464c79a8eb2a2041974801 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_79ad9aeeca464c79a8eb2a2041974801()
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

      private sealed class MTHD_56cd36bbf6614faea5f3a2b0aafe05a4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_56cd36bbf6614faea5f3a2b0aafe05a4()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_f7aa9e63b37647dfb5abd7b1b1fdef1a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f7aa9e63b37647dfb5abd7b1b1fdef1a()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_245a2801baf5413c937c313b78d54779 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_245a2801baf5413c937c313b78d54779()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_66739a3a5e594c89bdec3c7e878e90a8 : HardwiredMemberDescriptor
      {
        internal PROP_66739a3a5e594c89bdec3c7e878e90a8()
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

      private sealed class PROP_c747a4088b9d4d5b91d04672d3662483 : HardwiredMemberDescriptor
      {
        internal PROP_c747a4088b9d4d5b91d04672d3662483()
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

      private sealed class PROP_eda597d0f72242a6b0e9118d29382659 : HardwiredMemberDescriptor
      {
        internal PROP_eda597d0f72242a6b0e9118d29382659()
          : base(typeof (double), "totalTimeElapsed", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class PROP_1cd8d0c7f8ae4f5f9f398766e01cec68 : HardwiredMemberDescriptor
      {
        internal PROP_1cd8d0c7f8ae4f5f9f398766e01cec68()
          : base(typeof (double), "turnTime", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class PROP_c7525ccb91d54ff7b367b762e2fd2c43 : HardwiredMemberDescriptor
      {
        internal PROP_c7525ccb91d54ff7b367b762e2fd2c43()
          : base(typeof (int), "frame", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class PROP_8dc959ea4177457c8e8b71051499c050 : HardwiredMemberDescriptor
      {
        internal PROP_8dc959ea4177457c8e8b71051499c050()
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

      private sealed class PROP_748a382a491a48bb9c6aa5141b47ab9e : HardwiredMemberDescriptor
      {
        internal PROP_748a382a491a48bb9c6aa5141b47ab9e()
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

      private sealed class PROP_4f2abd62615c43d5a17880bdbcd9589a : HardwiredMemberDescriptor
      {
        internal PROP_4f2abd62615c43d5a17880bdbcd9589a()
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

      private sealed class PROP_e5bf2e1e1c234c3986bf77463db032e3 : HardwiredMemberDescriptor
      {
        internal PROP_e5bf2e1e1c234c3986bf77463db032e3()
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

      private sealed class PROP_3c3d026d1f1544d2886ba4e5a9dac6b4 : HardwiredMemberDescriptor
      {
        internal PROP_3c3d026d1f1544d2886ba4e5a9dac6b4()
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

      private sealed class PROP_2f443b9e7efd4ad2b3bd28801e30b50d : HardwiredMemberDescriptor
      {
        internal PROP_2f443b9e7efd4ad2b3bd28801e30b50d()
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

      private sealed class PROP_7b4d380cf17c4314b0d519bd5c60fe46 : HardwiredMemberDescriptor
      {
        internal PROP_7b4d380cf17c4314b0d519bd5c60fe46()
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

      private sealed class PROP_a2bea0a3d7e0416a8d0c0c4516fd9067 : HardwiredMemberDescriptor
      {
        internal PROP_a2bea0a3d7e0416a8d0c0c4516fd9067()
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

      private sealed class PROP_fa63d0f8cc94427281e5cd61b0f6202c : HardwiredMemberDescriptor
      {
        internal PROP_fa63d0f8cc94427281e5cd61b0f6202c()
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

      private sealed class PROP_f8d7929a7b2d49968e29df0d5ca88557 : HardwiredMemberDescriptor
      {
        internal PROP_f8d7929a7b2d49968e29df0d5ca88557()
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

      private sealed class PROP_eed7331f9eb149759982d5679794856d : HardwiredMemberDescriptor
      {
        internal PROP_eed7331f9eb149759982d5679794856d()
          : base(typeof (bool), "waiting", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class PROP_8133bdbc52b744078c184fece6cf34e7 : HardwiredMemberDescriptor
      {
        internal PROP_8133bdbc52b744078c184fece6cf34e7()
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

      private sealed class PROP_214a361c5fdb4272a1c7e81648d0f18e : HardwiredMemberDescriptor
      {
        internal PROP_214a361c5fdb4272a1c7e81648d0f18e()
          : base(typeof (bool), "busy", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class PROP_ebaa22092b294893879259d55f9f7ca7 : HardwiredMemberDescriptor
      {
        internal PROP_ebaa22092b294893879259d55f9f7ca7()
          : base(typeof (bool), "ongoing", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class PROP_2426e09dcb5045b3a8f1471d2c099f02 : HardwiredMemberDescriptor
      {
        internal PROP_2426e09dcb5045b3a8f1471d2c099f02()
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

      private sealed class PROP_3184fbf55d924e049fbfd847e7c96494 : HardwiredMemberDescriptor
      {
        internal PROP_3184fbf55d924e049fbfd847e7c96494()
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

      private sealed class PROP_b62f74776ffd467aaa926003feff6b8a : HardwiredMemberDescriptor
      {
        internal PROP_b62f74776ffd467aaa926003feff6b8a()
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

      private sealed class PROP_a9e53609f57540e3861a0ae7caa29535 : HardwiredMemberDescriptor
      {
        internal PROP_a9e53609f57540e3861a0ae7caa29535()
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

      private sealed class PROP_9b0ca29e29fc4001b769327d15c14ddc : HardwiredMemberDescriptor
      {
        internal PROP_9b0ca29e29fc4001b769327d15c14ddc()
          : base(typeof (int), "width", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class PROP_51a8a42dbaf8491ca2cf7cc5cabad5e8 : HardwiredMemberDescriptor
      {
        internal PROP_51a8a42dbaf8491ca2cf7cc5cabad5e8()
          : base(typeof (int), "height", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class PROP_05687f1211d0441fbb2ea319ba1263f3 : HardwiredMemberDescriptor
      {
        internal PROP_05687f1211d0441fbb2ea319ba1263f3()
          : base(typeof (Educative.Point), "mousePosition", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class PROP_fd6a4a99a639468fa10f01fb5fd80fd2 : HardwiredMemberDescriptor
      {
        internal PROP_fd6a4a99a639468fa10f01fb5fd80fd2()
          : base(typeof (bool), "mouseOverUI", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class PROP_66e10c3e0a9941bcb6fae6b8ad989cba : HardwiredMemberDescriptor
      {
        internal PROP_66e10c3e0a9941bcb6fae6b8ad989cba()
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

      private sealed class PROP_e45d1213c5da4a71ae53a0bfd05d971b : HardwiredMemberDescriptor
      {
        internal PROP_e45d1213c5da4a71ae53a0bfd05d971b()
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

      private sealed class PROP_88f47d0f3a3447bf9bda5fb86bbe56bc : HardwiredMemberDescriptor
      {
        internal PROP_88f47d0f3a3447bf9bda5fb86bbe56bc()
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

      private sealed class PROP_405af4a9c8854aa18790aa0f1d9e1555 : HardwiredMemberDescriptor
      {
        internal PROP_405af4a9c8854aa18790aa0f1d9e1555()
          : base(typeof (bool), "isUsingTouchControls", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class PROP_f4fe44b83dcf46848df6a34e3c9c38e0 : HardwiredMemberDescriptor
      {
        internal PROP_f4fe44b83dcf46848df6a34e3c9c38e0()
          : base(typeof (double), "screenWidth", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class PROP_061398b81e7749b1805fff5411eccda1 : HardwiredMemberDescriptor
      {
        internal PROP_061398b81e7749b1805fff5411eccda1()
          : base(typeof (double), "screenHeight", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }
    }

    private sealed class TYPE_f02861a3a773466dba2302f163553d9b : HardwiredUserDataDescriptor
    {
      internal TYPE_f02861a3a773466dba2302f163553d9b()
        : base(typeof (ContainerPlayer))
      {
        this.AddMember("get_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f02861a3a773466dba2302f163553d9b.MTHD_1d172637adf84d50a170982e6c82e83b()
        }));
        this.AddMember("set_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f02861a3a773466dba2302f163553d9b.MTHD_2e39ec0fc99b4f26944829ab9d9140b3()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f02861a3a773466dba2302f163553d9b.MTHD_6efe561663cb496bb3e3a307f5e76662()
        }));
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f02861a3a773466dba2302f163553d9b.MTHD_aa75e9f9aab7443881844a59125b20ab()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f02861a3a773466dba2302f163553d9b.MTHD_ab38e13fa941457fb81024905054f460()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f02861a3a773466dba2302f163553d9b.MTHD_75612d619a924f829321a3702d852bea()
        }));
        this.AddMember("getCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreature", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f02861a3a773466dba2302f163553d9b.MTHD_ff1298900cce4260b443d427832c879a()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f02861a3a773466dba2302f163553d9b.MTHD_30ef4e7a8e034425a08c5a5c27dad68d()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f02861a3a773466dba2302f163553d9b.MTHD_95eee8b29dd344e183752b1dd1f6a266()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f02861a3a773466dba2302f163553d9b.MTHD_1443bb0a497546adb8c658436a6ea587()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f02861a3a773466dba2302f163553d9b.MTHD_cfb0a9bb9edc4775a2f71141e7cb6711()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f02861a3a773466dba2302f163553d9b.MTHD_650f0ab8f3204c3fa08d4136b786bfeb()
        }));
        this.AddMember("localTurn", (IMemberDescriptor) new Bridge.TYPE_f02861a3a773466dba2302f163553d9b.PROP_5a6abd6a541142e49d2d9e481826f95a());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_f02861a3a773466dba2302f163553d9b.PROP_ad9da6caddfe4c0aa38c21a62f90337e());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_f02861a3a773466dba2302f163553d9b.PROP_172d60cadc2544caabda1de1d4779fc4());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_f02861a3a773466dba2302f163553d9b.PROP_1f71d985570c43a49ef4e6f774ac7b3f());
      }

      private sealed class MTHD_1d172637adf84d50a170982e6c82e83b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1d172637adf84d50a170982e6c82e83b()
        {
          this.Initialize("get_localTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).localTurn;
        }
      }

      private sealed class MTHD_2e39ec0fc99b4f26944829ab9d9140b3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2e39ec0fc99b4f26944829ab9d9140b3()
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

      private sealed class MTHD_6efe561663cb496bb3e3a307f5e76662 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6efe561663cb496bb3e3a307f5e76662()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class MTHD_aa75e9f9aab7443881844a59125b20ab : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aa75e9f9aab7443881844a59125b20ab()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class MTHD_ab38e13fa941457fb81024905054f460 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ab38e13fa941457fb81024905054f460()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }

      private sealed class MTHD_75612d619a924f829321a3702d852bea : HardwiredMethodMemberDescriptor
      {
        internal MTHD_75612d619a924f829321a3702d852bea()
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

      private sealed class MTHD_ff1298900cce4260b443d427832c879a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ff1298900cce4260b443d427832c879a()
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

      private sealed class MTHD_30ef4e7a8e034425a08c5a5c27dad68d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_30ef4e7a8e034425a08c5a5c27dad68d()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).getMinionCount();
        }
      }

      private sealed class MTHD_95eee8b29dd344e183752b1dd1f6a266 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_95eee8b29dd344e183752b1dd1f6a266()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).GetHashCode();
        }
      }

      private sealed class MTHD_1443bb0a497546adb8c658436a6ea587 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1443bb0a497546adb8c658436a6ea587()
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

      private sealed class MTHD_cfb0a9bb9edc4775a2f71141e7cb6711 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cfb0a9bb9edc4775a2f71141e7cb6711()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_650f0ab8f3204c3fa08d4136b786bfeb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_650f0ab8f3204c3fa08d4136b786bfeb()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_5a6abd6a541142e49d2d9e481826f95a : HardwiredMemberDescriptor
      {
        internal PROP_5a6abd6a541142e49d2d9e481826f95a()
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

      private sealed class PROP_ad9da6caddfe4c0aa38c21a62f90337e : HardwiredMemberDescriptor
      {
        internal PROP_ad9da6caddfe4c0aa38c21a62f90337e()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class PROP_172d60cadc2544caabda1de1d4779fc4 : HardwiredMemberDescriptor
      {
        internal PROP_172d60cadc2544caabda1de1d4779fc4()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class PROP_1f71d985570c43a49ef4e6f774ac7b3f : HardwiredMemberDescriptor
      {
        internal PROP_1f71d985570c43a49ef4e6f774ac7b3f()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }
    }

    private sealed class TYPE_7e719f5f09db4540b0a548cbe5fdf295 : HardwiredUserDataDescriptor
    {
      internal TYPE_7e719f5f09db4540b0a548cbe5fdf295()
        : base(typeof (ContainerCreature))
      {
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_08a34c9891db4a49a267f59a045e3afe()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_2373faf794ba43b38393ff7d78f13144()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_a5d8c3a14cce427f8c9e98b35b2a0211()
        }));
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_4d82b8392fd142b2a91dc960fa4bbcb4()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_60d45f29c8d4461db6d0924813f5d84d()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_422f2a7e6e274a198a7c80d1b6023d74()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_d14049a2da424d7b9bb764419d23862e()
        }));
        this.AddMember("get_healthAndTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_healthAndTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_3d661d673a084d1cb5e8a5bc4b3a7e52()
        }));
        this.AddMember("get_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_9a0af40958194124abb01597c8758156()
        }));
        this.AddMember("set_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_f3b128e5a510415d950537667c87d0f7()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_6a46cfb524ca482cb39675691b0f422d()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_86e6fddda94840ed8ccdb61fec2ed23a()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_417d862d0b4142cba9df33e9052ba597()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_643b327b7d914092b9f4b2c1cea7b22d()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_8e2135b207c54ac69b8b0b11b84a2ed5()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_5160af27705342b7bd45264bc2123ac9()
        }));
        this.AddMember("get_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_1af936273a5e436ab2089811a06b0482()
        }));
        this.AddMember("set_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_617ba921fce44ff7be7d473753e864fd()
        }));
        this.AddMember("get_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_c5a6490827b347b8a215acf06014ba49()
        }));
        this.AddMember("set_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_624c43b3a9e7484e956553abb9537aae()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_97a085fe55b842d6b82cbf7ee2ee43c5()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_3809433f1f9c4bd1bcfa86f828363150()
        }));
        this.AddMember("get_inTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_897180be40d24d2580b6826dfb7c3683()
        }));
        this.AddMember("get_isMoving", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMoving", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_e520ded25bc54e31be9d677f4c657270()
        }));
        this.AddMember("get_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_35138b1ec962471092c340b901769a11()
        }));
        this.AddMember("set_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_f51bf24487a24b58bb4eacd5dd835140()
        }));
        this.AddMember("get_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_0c69a5ec6fb14ee0aa44dc4f26676074()
        }));
        this.AddMember("set_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_23a07dbb26524c36beefd416250ed2f5()
        }));
        this.AddMember("get_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_f308c0fd1442456aa9ccb7df6e75cb7a()
        }));
        this.AddMember("set_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_c231ba00c60b442b9320955d9c57daa8()
        }));
        this.AddMember("get_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_f007a08468cb422da05ec9838b6e4d7d()
        }));
        this.AddMember("set_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_7ad6d3603e994045a09ef27703c5aa62()
        }));
        this.AddMember("get_inWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_059b1f3398cc4e83a1f0e87f4e6f1355()
        }));
        this.AddMember("get_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_68b8c7331ccd4f81b9251b50914f0ed7()
        }));
        this.AddMember("set_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_6d2c3d1a43be4ac3a39e8b9b09fc85a2()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_9bb8b3bf070a4bc181ac8ecda90765f9()
        }));
        this.AddMember("set_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_7131fd972b414a4c9092bc839215ca14()
        }));
        this.AddMember("get_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_23c2421cb7a944559bc3530d58c45b53()
        }));
        this.AddMember("set_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_9c11255a33c94c3c9e5c8df6c8412244()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_9b80f4da61bd46cf93b2494a6d2f17db()
        }));
        this.AddMember("get_isRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_76eeafb062f8456dac0cd772ada00350()
        }));
        this.AddMember("get_isMounted", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMounted", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_7c199203e61c4388b23e80c29322c6cc()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_397bb7911fc145b295ffe740858a0e27()
        }));
        this.AddMember("get_isPawn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPawn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_e5e884037a4d43eaa7a0d7857769eea8()
        }));
        this.AddMember("get_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_662d223ec5b944acbbfa69a2fa2cd2a8()
        }));
        this.AddMember("set_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_bcd3286ff2524c1982d6c141288ccd36()
        }));
        this.AddMember("get_isMountable", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMountable", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_4a6d9243eb6740858a2353faa8d9b14d()
        }));
        this.AddMember("get_canMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_canMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_64402a095b864a299e07174c5fb76b52()
        }));
        this.AddMember("get_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_65c273ded9c54f0580ce98f9a2302f6f()
        }));
        this.AddMember("set_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_465107cc8a9b4ee2ab46eb327541e880()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_d8b5cdb8b4d346ae8127e18e5bde8bc7()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_08bffc86ddee4f48a9ef735a90bcc194()
        }));
        this.AddMember("getRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_c5a35d463faa405582771674aa99aa53()
        }));
        this.AddMember("getMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_645d93327da34ef78c22a13904550e01()
        }));
        this.AddMember("getTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_37d20caeeb2047dba1de4a8bea8fcd3a()
        }));
        this.AddMember("LongJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LongJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_2e7fa38633cf434095c52c59c16a2b19()
        }));
        this.AddMember("HighJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("HighJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_408585593c52472fbd685da7fb7ed118()
        }));
        this.AddMember("Walk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Walk", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_d960f0b771f649d18c3e507a13ae3164()
        }));
        this.AddMember("setDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_f03962bb1dd84f85a9acddcd55752d23()
        }));
        this.AddMember("getDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_0bbb2042a75040f798dec4ef5c51882b()
        }));
        this.AddMember("getFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_3f6d9d04a53c47078cf58bd440f305b8()
        }));
        this.AddMember("getActivateableFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_2a10bae045294de19763f6f8b082e755()
        }));
        this.AddMember("getActivateableFamiliarBookID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarBookID", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_ba42c5accb714368824a20c7782fce88()
        }));
        this.AddMember("increaseFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("increaseFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_e7ac2ce299124d0ebf7cfea7b436bea1()
        }));
        this.AddMember("inside", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("inside", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_aadf909c74a947aa8cb18ecb57a6b4eb(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_fb20fa1a0c8f419aac77b3c70bb95f41()
        }));
        this.AddMember("overlap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("overlap", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_927fb56ba6a946309a0c7d27568000ef(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_d784433e7b204b73ba32633025c3f6a6()
        }));
        this.AddMember("die", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("die", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_7fe85530da4447e28d7af50dce42676d()
        }));
        this.AddMember("addSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_9e949e163d3c47a98916cfc4e3b46b50()
        }));
        this.AddMember("removeSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("removeSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_048ce9c7b5f64d519300c4c421a829aa(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_ebea0a660f9e4ccf9da0c3abe934f8cd()
        }));
        this.AddMember("getSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpells", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_20e25efb07ee46acb35aad7be2d5610d()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_6190e33b57db41448f5a048908582a76()
        }));
        this.AddMember("getSpellCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_63937857af0c48389a0da46236248cee()
        }));
        this.AddMember("castedCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_e35029db0389476c98f3791d2fb030a6()
        }));
        this.AddMember("castedCountThisTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCountThisTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_664088c52d4d4eccbf39d884c3561f05()
        }));
        this.AddMember("castedDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_cd6970f864934afbb33ee6c0123bf13d()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_2d5a3ab275424b0a871eb55384efd839()
        }));
        this.AddMember("castSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_0e3cc06ba5f347c98069acf42956e580()
        }));
        this.AddMember("angleToFire", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("angleToFire", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_fe5b48fd3ddc4f9daa865bfc5dbd839d()
        }));
        this.AddMember("powerToFire", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("powerToFire", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_f0f39e67b3ac45fcbdddb2bc1974db91()
        }));
        this.AddMember("fireAt", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fireAt", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_2ead6d0457a843cd98e3fe334dbd3915(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_a73252517a224cc69d47cd9e2f028a76()
        }));
        this.AddMember("getEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getEffectors", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_15d232f96f024c058b05ecd6157db583(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_ca8e82e2141a4711b02fc40e058461a6()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_f310ab46a78f4da4a40f52836f7e23b3()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_c85ea01b9bc24009bfb29d3c1e06a207()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_348dd86d0299444aaddc3c303291f70b()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_f8443a0d56a44d46b97150fb91158127()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_f5ac7aaf60214578abd90a1efc4da6a3()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.MTHD_65c0ee3f5bc84c6296b6b1c6d5d0d285()
        }));
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.PROP_940693df55de4642b8a555f5749ed395());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.PROP_a4e2bee207774081b669738e9bc0d311());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.PROP_b72288b5d687436282aff89e0bc07694());
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.PROP_6dd5ebb57c204f1c990ddcff23d30989());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.PROP_a1b659b9cd6443ab8cd8edf75e7bcaf0());
        this.AddMember("healthAndTower", (IMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.PROP_ac3b721b5b0b41349fb6097c644ad3ca());
        this.AddMember("shield", (IMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.PROP_f41f6977ddc24b3689f3638c2fb281f1());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.PROP_b9bd5ddb044f439088564a66855b2db6());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.PROP_d0e9b99b0ac34ee3bc171b407cb3eb9e());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.PROP_26e148954c0b42718944ae717aadb546());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.PROP_12f3949c0a734cf880e2e730885467dc());
        this.AddMember("weight", (IMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.PROP_22f12f1544d440ca8af97122445ff19b());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.PROP_7a5915794dd644f5b4b5ce10bdc6eea4());
        this.AddMember("inTower", (IMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.PROP_7011e1e9bfb843788900e84ddeb4a458());
        this.AddMember("isMoving", (IMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.PROP_a3db789894784911a5e76415cbe25c6b());
        this.AddMember("stunned", (IMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.PROP_dbef6abe4b8b4eeebb4308df7e2a27e2());
        this.AddMember("superStunned", (IMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.PROP_8a104fd8c84b4566a95457efaf7c8271());
        this.AddMember("waterWalking", (IMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.PROP_5cb400eb941946818be0a328d2a0d0f8());
        this.AddMember("frostWalking", (IMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.PROP_5bc5e57017a043e18c8a2937cad64d06());
        this.AddMember("inWater", (IMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.PROP_8e63cb3bee9d47d584cd2bbaff6fc056());
        this.AddMember("diesInWater", (IMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.PROP_aad951d9bf954abab50a213bfe3b1bc8());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.PROP_b52cea63358044fba0ba34d0eb024336());
        this.AddMember("race", (IMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.PROP_654537d74193417e80223168581cb581());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.PROP_d379ac4c892a49318d456b261c80b47a());
        this.AddMember("isRider", (IMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.PROP_a8624b18fafa4090a05c5147966e0423());
        this.AddMember("isMounted", (IMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.PROP_9ead6ca91bcb436b9711e6fc803e1f2d());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.PROP_0a80893f9bd14e0c9da2d258b1bbca9e());
        this.AddMember("isPawn", (IMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.PROP_85847c38f654425886dabbd82b748c10());
        this.AddMember("isFlying", (IMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.PROP_045d3514bbba4de2a94059ec29d78270());
        this.AddMember("isMountable", (IMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.PROP_202c1f77cc7d4061845b0e73881291b5());
        this.AddMember("canMount", (IMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.PROP_847fc8ee75a94df2a6f3f727fa14c31a());
        this.AddMember("arcaneMonster", (IMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.PROP_749e353c901c4f74bf00f74971ff28b6());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_7e719f5f09db4540b0a548cbe5fdf295.PROP_8bb54319f7d9415b81528bf694616253());
      }

      private sealed class MTHD_08a34c9891db4a49a267f59a045e3afe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_08a34c9891db4a49a267f59a045e3afe()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class MTHD_2373faf794ba43b38393ff7d78f13144 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2373faf794ba43b38393ff7d78f13144()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class MTHD_a5d8c3a14cce427f8c9e98b35b2a0211 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a5d8c3a14cce427f8c9e98b35b2a0211()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class MTHD_4d82b8392fd142b2a91dc960fa4bbcb4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4d82b8392fd142b2a91dc960fa4bbcb4()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).health;
        }
      }

      private sealed class MTHD_60d45f29c8d4461db6d0924813f5d84d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_60d45f29c8d4461db6d0924813f5d84d()
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

      private sealed class MTHD_422f2a7e6e274a198a7c80d1b6023d74 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_422f2a7e6e274a198a7c80d1b6023d74()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).maxHealth;
        }
      }

      private sealed class MTHD_d14049a2da424d7b9bb764419d23862e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d14049a2da424d7b9bb764419d23862e()
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

      private sealed class MTHD_3d661d673a084d1cb5e8a5bc4b3a7e52 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3d661d673a084d1cb5e8a5bc4b3a7e52()
        {
          this.Initialize("get_healthAndTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class MTHD_9a0af40958194124abb01597c8758156 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9a0af40958194124abb01597c8758156()
        {
          this.Initialize("get_shield", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).shield;
        }
      }

      private sealed class MTHD_f3b128e5a510415d950537667c87d0f7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f3b128e5a510415d950537667c87d0f7()
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

      private sealed class MTHD_6a46cfb524ca482cb39675691b0f422d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6a46cfb524ca482cb39675691b0f422d()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).x;
        }
      }

      private sealed class MTHD_86e6fddda94840ed8ccdb61fec2ed23a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_86e6fddda94840ed8ccdb61fec2ed23a()
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

      private sealed class MTHD_417d862d0b4142cba9df33e9052ba597 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_417d862d0b4142cba9df33e9052ba597()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).y;
        }
      }

      private sealed class MTHD_643b327b7d914092b9f4b2c1cea7b22d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_643b327b7d914092b9f4b2c1cea7b22d()
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

      private sealed class MTHD_8e2135b207c54ac69b8b0b11b84a2ed5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8e2135b207c54ac69b8b0b11b84a2ed5()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).position;
        }
      }

      private sealed class MTHD_5160af27705342b7bd45264bc2123ac9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5160af27705342b7bd45264bc2123ac9()
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

      private sealed class MTHD_1af936273a5e436ab2089811a06b0482 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1af936273a5e436ab2089811a06b0482()
        {
          this.Initialize("get_parent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).parent;
        }
      }

      private sealed class MTHD_617ba921fce44ff7be7d473753e864fd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_617ba921fce44ff7be7d473753e864fd()
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

      private sealed class MTHD_c5a6490827b347b8a215acf06014ba49 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c5a6490827b347b8a215acf06014ba49()
        {
          this.Initialize("get_weight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).weight;
        }
      }

      private sealed class MTHD_624c43b3a9e7484e956553abb9537aae : HardwiredMethodMemberDescriptor
      {
        internal MTHD_624c43b3a9e7484e956553abb9537aae()
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

      private sealed class MTHD_97a085fe55b842d6b82cbf7ee2ee43c5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_97a085fe55b842d6b82cbf7ee2ee43c5()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).radius;
        }
      }

      private sealed class MTHD_3809433f1f9c4bd1bcfa86f828363150 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3809433f1f9c4bd1bcfa86f828363150()
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

      private sealed class MTHD_897180be40d24d2580b6826dfb7c3683 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_897180be40d24d2580b6826dfb7c3683()
        {
          this.Initialize("get_inTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class MTHD_e520ded25bc54e31be9d677f4c657270 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e520ded25bc54e31be9d677f4c657270()
        {
          this.Initialize("get_isMoving", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class MTHD_35138b1ec962471092c340b901769a11 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_35138b1ec962471092c340b901769a11()
        {
          this.Initialize("get_stunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).stunned;
        }
      }

      private sealed class MTHD_f51bf24487a24b58bb4eacd5dd835140 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f51bf24487a24b58bb4eacd5dd835140()
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

      private sealed class MTHD_0c69a5ec6fb14ee0aa44dc4f26676074 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0c69a5ec6fb14ee0aa44dc4f26676074()
        {
          this.Initialize("get_superStunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).superStunned;
        }
      }

      private sealed class MTHD_23a07dbb26524c36beefd416250ed2f5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_23a07dbb26524c36beefd416250ed2f5()
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

      private sealed class MTHD_f308c0fd1442456aa9ccb7df6e75cb7a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f308c0fd1442456aa9ccb7df6e75cb7a()
        {
          this.Initialize("get_waterWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).waterWalking;
        }
      }

      private sealed class MTHD_c231ba00c60b442b9320955d9c57daa8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c231ba00c60b442b9320955d9c57daa8()
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

      private sealed class MTHD_f007a08468cb422da05ec9838b6e4d7d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f007a08468cb422da05ec9838b6e4d7d()
        {
          this.Initialize("get_frostWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).frostWalking;
        }
      }

      private sealed class MTHD_7ad6d3603e994045a09ef27703c5aa62 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7ad6d3603e994045a09ef27703c5aa62()
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

      private sealed class MTHD_059b1f3398cc4e83a1f0e87f4e6f1355 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_059b1f3398cc4e83a1f0e87f4e6f1355()
        {
          this.Initialize("get_inWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class MTHD_68b8c7331ccd4f81b9251b50914f0ed7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_68b8c7331ccd4f81b9251b50914f0ed7()
        {
          this.Initialize("get_diesInWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).diesInWater;
        }
      }

      private sealed class MTHD_6d2c3d1a43be4ac3a39e8b9b09fc85a2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6d2c3d1a43be4ac3a39e8b9b09fc85a2()
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

      private sealed class MTHD_9bb8b3bf070a4bc181ac8ecda90765f9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9bb8b3bf070a4bc181ac8ecda90765f9()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).type;
        }
      }

      private sealed class MTHD_7131fd972b414a4c9092bc839215ca14 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7131fd972b414a4c9092bc839215ca14()
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

      private sealed class MTHD_23c2421cb7a944559bc3530d58c45b53 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_23c2421cb7a944559bc3530d58c45b53()
        {
          this.Initialize("get_race", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).race;
        }
      }

      private sealed class MTHD_9c11255a33c94c3c9e5c8df6c8412244 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9c11255a33c94c3c9e5c8df6c8412244()
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

      private sealed class MTHD_9b80f4da61bd46cf93b2494a6d2f17db : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9b80f4da61bd46cf93b2494a6d2f17db()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class MTHD_76eeafb062f8456dac0cd772ada00350 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_76eeafb062f8456dac0cd772ada00350()
        {
          this.Initialize("get_isRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class MTHD_7c199203e61c4388b23e80c29322c6cc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7c199203e61c4388b23e80c29322c6cc()
        {
          this.Initialize("get_isMounted", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class MTHD_397bb7911fc145b295ffe740858a0e27 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_397bb7911fc145b295ffe740858a0e27()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class MTHD_e5e884037a4d43eaa7a0d7857769eea8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e5e884037a4d43eaa7a0d7857769eea8()
        {
          this.Initialize("get_isPawn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class MTHD_662d223ec5b944acbbfa69a2fa2cd2a8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_662d223ec5b944acbbfa69a2fa2cd2a8()
        {
          this.Initialize("get_isFlying", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isFlying;
        }
      }

      private sealed class MTHD_bcd3286ff2524c1982d6c141288ccd36 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bcd3286ff2524c1982d6c141288ccd36()
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

      private sealed class MTHD_4a6d9243eb6740858a2353faa8d9b14d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4a6d9243eb6740858a2353faa8d9b14d()
        {
          this.Initialize("get_isMountable", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class MTHD_64402a095b864a299e07174c5fb76b52 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_64402a095b864a299e07174c5fb76b52()
        {
          this.Initialize("get_canMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class MTHD_65c273ded9c54f0580ce98f9a2302f6f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_65c273ded9c54f0580ce98f9a2302f6f()
        {
          this.Initialize("get_arcaneMonster", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).arcaneMonster;
        }
      }

      private sealed class MTHD_465107cc8a9b4ee2ab46eb327541e880 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_465107cc8a9b4ee2ab46eb327541e880()
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

      private sealed class MTHD_d8b5cdb8b4d346ae8127e18e5bde8bc7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d8b5cdb8b4d346ae8127e18e5bde8bc7()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).takeDamage;
        }
      }

      private sealed class MTHD_08bffc86ddee4f48a9ef735a90bcc194 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_08bffc86ddee4f48a9ef735a90bcc194()
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

      private sealed class MTHD_c5a35d463faa405582771674aa99aa53 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c5a35d463faa405582771674aa99aa53()
        {
          this.Initialize("getRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getRider();
        }
      }

      private sealed class MTHD_645d93327da34ef78c22a13904550e01 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_645d93327da34ef78c22a13904550e01()
        {
          this.Initialize("getMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMount();
        }
      }

      private sealed class MTHD_37d20caeeb2047dba1de4a8bea8fcd3a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_37d20caeeb2047dba1de4a8bea8fcd3a()
        {
          this.Initialize("getTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getTower();
        }
      }

      private sealed class MTHD_2e7fa38633cf434095c52c59c16a2b19 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2e7fa38633cf434095c52c59c16a2b19()
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

      private sealed class MTHD_408585593c52472fbd685da7fb7ed118 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_408585593c52472fbd685da7fb7ed118()
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

      private sealed class MTHD_d960f0b771f649d18c3e507a13ae3164 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d960f0b771f649d18c3e507a13ae3164()
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

      private sealed class MTHD_f03962bb1dd84f85a9acddcd55752d23 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f03962bb1dd84f85a9acddcd55752d23()
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

      private sealed class MTHD_0bbb2042a75040f798dec4ef5c51882b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0bbb2042a75040f798dec4ef5c51882b()
        {
          this.Initialize("getDirection", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getDirection();
        }
      }

      private sealed class MTHD_3f6d9d04a53c47078cf58bd440f305b8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3f6d9d04a53c47078cf58bd440f305b8()
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

      private sealed class MTHD_2a10bae045294de19763f6f8b082e755 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2a10bae045294de19763f6f8b082e755()
        {
          this.Initialize("getActivateableFamiliarLevel", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarLevel();
        }
      }

      private sealed class MTHD_ba42c5accb714368824a20c7782fce88 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ba42c5accb714368824a20c7782fce88()
        {
          this.Initialize("getActivateableFamiliarBookID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarBookID();
        }
      }

      private sealed class MTHD_e7ac2ce299124d0ebf7cfea7b436bea1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e7ac2ce299124d0ebf7cfea7b436bea1()
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

      private sealed class MTHD_aadf909c74a947aa8cb18ecb57a6b4eb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aadf909c74a947aa8cb18ecb57a6b4eb()
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

      private sealed class MTHD_fb20fa1a0c8f419aac77b3c70bb95f41 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fb20fa1a0c8f419aac77b3c70bb95f41()
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

      private sealed class MTHD_927fb56ba6a946309a0c7d27568000ef : HardwiredMethodMemberDescriptor
      {
        internal MTHD_927fb56ba6a946309a0c7d27568000ef()
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

      private sealed class MTHD_d784433e7b204b73ba32633025c3f6a6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d784433e7b204b73ba32633025c3f6a6()
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

      private sealed class MTHD_7fe85530da4447e28d7af50dce42676d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7fe85530da4447e28d7af50dce42676d()
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

      private sealed class MTHD_9e949e163d3c47a98916cfc4e3b46b50 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9e949e163d3c47a98916cfc4e3b46b50()
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

      private sealed class MTHD_048ce9c7b5f64d519300c4c421a829aa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_048ce9c7b5f64d519300c4c421a829aa()
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

      private sealed class MTHD_ebea0a660f9e4ccf9da0c3abe934f8cd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ebea0a660f9e4ccf9da0c3abe934f8cd()
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

      private sealed class MTHD_20e25efb07ee46acb35aad7be2d5610d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_20e25efb07ee46acb35aad7be2d5610d()
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

      private sealed class MTHD_6190e33b57db41448f5a048908582a76 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6190e33b57db41448f5a048908582a76()
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

      private sealed class MTHD_63937857af0c48389a0da46236248cee : HardwiredMethodMemberDescriptor
      {
        internal MTHD_63937857af0c48389a0da46236248cee()
        {
          this.Initialize("getSpellCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getSpellCount();
        }
      }

      private sealed class MTHD_e35029db0389476c98f3791d2fb030a6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e35029db0389476c98f3791d2fb030a6()
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

      private sealed class MTHD_664088c52d4d4eccbf39d884c3561f05 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_664088c52d4d4eccbf39d884c3561f05()
        {
          this.Initialize("castedCountThisTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).castedCountThisTurn();
        }
      }

      private sealed class MTHD_cd6970f864934afbb33ee6c0123bf13d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cd6970f864934afbb33ee6c0123bf13d()
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

      private sealed class MTHD_2d5a3ab275424b0a871eb55384efd839 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2d5a3ab275424b0a871eb55384efd839()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMinionCount();
        }
      }

      private sealed class MTHD_0e3cc06ba5f347c98069acf42956e580 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0e3cc06ba5f347c98069acf42956e580()
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

      private sealed class MTHD_fe5b48fd3ddc4f9daa865bfc5dbd839d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fe5b48fd3ddc4f9daa865bfc5dbd839d()
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

      private sealed class MTHD_f0f39e67b3ac45fcbdddb2bc1974db91 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f0f39e67b3ac45fcbdddb2bc1974db91()
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

      private sealed class MTHD_2ead6d0457a843cd98e3fe334dbd3915 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2ead6d0457a843cd98e3fe334dbd3915()
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

      private sealed class MTHD_a73252517a224cc69d47cd9e2f028a76 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a73252517a224cc69d47cd9e2f028a76()
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

      private sealed class MTHD_15d232f96f024c058b05ecd6157db583 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_15d232f96f024c058b05ecd6157db583()
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

      private sealed class MTHD_ca8e82e2141a4711b02fc40e058461a6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ca8e82e2141a4711b02fc40e058461a6()
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

      private sealed class MTHD_f310ab46a78f4da4a40f52836f7e23b3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f310ab46a78f4da4a40f52836f7e23b3()
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

      private sealed class MTHD_c85ea01b9bc24009bfb29d3c1e06a207 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c85ea01b9bc24009bfb29d3c1e06a207()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).GetHashCode();
        }
      }

      private sealed class MTHD_348dd86d0299444aaddc3c303291f70b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_348dd86d0299444aaddc3c303291f70b()
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

      private sealed class MTHD_f8443a0d56a44d46b97150fb91158127 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f8443a0d56a44d46b97150fb91158127()
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

      private sealed class MTHD_f5ac7aaf60214578abd90a1efc4da6a3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f5ac7aaf60214578abd90a1efc4da6a3()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_65c0ee3f5bc84c6296b6b1c6d5d0d285 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_65c0ee3f5bc84c6296b6b1c6d5d0d285()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_940693df55de4642b8a555f5749ed395 : HardwiredMemberDescriptor
      {
        internal PROP_940693df55de4642b8a555f5749ed395()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class PROP_a4e2bee207774081b669738e9bc0d311 : HardwiredMemberDescriptor
      {
        internal PROP_a4e2bee207774081b669738e9bc0d311()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class PROP_b72288b5d687436282aff89e0bc07694 : HardwiredMemberDescriptor
      {
        internal PROP_b72288b5d687436282aff89e0bc07694()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class PROP_6dd5ebb57c204f1c990ddcff23d30989 : HardwiredMemberDescriptor
      {
        internal PROP_6dd5ebb57c204f1c990ddcff23d30989()
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

      private sealed class PROP_a1b659b9cd6443ab8cd8edf75e7bcaf0 : HardwiredMemberDescriptor
      {
        internal PROP_a1b659b9cd6443ab8cd8edf75e7bcaf0()
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

      private sealed class PROP_ac3b721b5b0b41349fb6097c644ad3ca : HardwiredMemberDescriptor
      {
        internal PROP_ac3b721b5b0b41349fb6097c644ad3ca()
          : base(typeof (int), "healthAndTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class PROP_f41f6977ddc24b3689f3638c2fb281f1 : HardwiredMemberDescriptor
      {
        internal PROP_f41f6977ddc24b3689f3638c2fb281f1()
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

      private sealed class PROP_b9bd5ddb044f439088564a66855b2db6 : HardwiredMemberDescriptor
      {
        internal PROP_b9bd5ddb044f439088564a66855b2db6()
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

      private sealed class PROP_d0e9b99b0ac34ee3bc171b407cb3eb9e : HardwiredMemberDescriptor
      {
        internal PROP_d0e9b99b0ac34ee3bc171b407cb3eb9e()
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

      private sealed class PROP_26e148954c0b42718944ae717aadb546 : HardwiredMemberDescriptor
      {
        internal PROP_26e148954c0b42718944ae717aadb546()
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

      private sealed class PROP_12f3949c0a734cf880e2e730885467dc : HardwiredMemberDescriptor
      {
        internal PROP_12f3949c0a734cf880e2e730885467dc()
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

      private sealed class PROP_22f12f1544d440ca8af97122445ff19b : HardwiredMemberDescriptor
      {
        internal PROP_22f12f1544d440ca8af97122445ff19b()
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

      private sealed class PROP_7a5915794dd644f5b4b5ce10bdc6eea4 : HardwiredMemberDescriptor
      {
        internal PROP_7a5915794dd644f5b4b5ce10bdc6eea4()
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

      private sealed class PROP_7011e1e9bfb843788900e84ddeb4a458 : HardwiredMemberDescriptor
      {
        internal PROP_7011e1e9bfb843788900e84ddeb4a458()
          : base(typeof (bool), "inTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class PROP_a3db789894784911a5e76415cbe25c6b : HardwiredMemberDescriptor
      {
        internal PROP_a3db789894784911a5e76415cbe25c6b()
          : base(typeof (bool), "isMoving", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class PROP_dbef6abe4b8b4eeebb4308df7e2a27e2 : HardwiredMemberDescriptor
      {
        internal PROP_dbef6abe4b8b4eeebb4308df7e2a27e2()
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

      private sealed class PROP_8a104fd8c84b4566a95457efaf7c8271 : HardwiredMemberDescriptor
      {
        internal PROP_8a104fd8c84b4566a95457efaf7c8271()
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

      private sealed class PROP_5cb400eb941946818be0a328d2a0d0f8 : HardwiredMemberDescriptor
      {
        internal PROP_5cb400eb941946818be0a328d2a0d0f8()
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

      private sealed class PROP_5bc5e57017a043e18c8a2937cad64d06 : HardwiredMemberDescriptor
      {
        internal PROP_5bc5e57017a043e18c8a2937cad64d06()
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

      private sealed class PROP_8e63cb3bee9d47d584cd2bbaff6fc056 : HardwiredMemberDescriptor
      {
        internal PROP_8e63cb3bee9d47d584cd2bbaff6fc056()
          : base(typeof (bool), "inWater", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class PROP_aad951d9bf954abab50a213bfe3b1bc8 : HardwiredMemberDescriptor
      {
        internal PROP_aad951d9bf954abab50a213bfe3b1bc8()
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

      private sealed class PROP_b52cea63358044fba0ba34d0eb024336 : HardwiredMemberDescriptor
      {
        internal PROP_b52cea63358044fba0ba34d0eb024336()
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

      private sealed class PROP_654537d74193417e80223168581cb581 : HardwiredMemberDescriptor
      {
        internal PROP_654537d74193417e80223168581cb581()
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

      private sealed class PROP_d379ac4c892a49318d456b261c80b47a : HardwiredMemberDescriptor
      {
        internal PROP_d379ac4c892a49318d456b261c80b47a()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class PROP_a8624b18fafa4090a05c5147966e0423 : HardwiredMemberDescriptor
      {
        internal PROP_a8624b18fafa4090a05c5147966e0423()
          : base(typeof (bool), "isRider", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class PROP_9ead6ca91bcb436b9711e6fc803e1f2d : HardwiredMemberDescriptor
      {
        internal PROP_9ead6ca91bcb436b9711e6fc803e1f2d()
          : base(typeof (bool), "isMounted", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class PROP_0a80893f9bd14e0c9da2d258b1bbca9e : HardwiredMemberDescriptor
      {
        internal PROP_0a80893f9bd14e0c9da2d258b1bbca9e()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class PROP_85847c38f654425886dabbd82b748c10 : HardwiredMemberDescriptor
      {
        internal PROP_85847c38f654425886dabbd82b748c10()
          : base(typeof (bool), "isPawn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class PROP_045d3514bbba4de2a94059ec29d78270 : HardwiredMemberDescriptor
      {
        internal PROP_045d3514bbba4de2a94059ec29d78270()
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

      private sealed class PROP_202c1f77cc7d4061845b0e73881291b5 : HardwiredMemberDescriptor
      {
        internal PROP_202c1f77cc7d4061845b0e73881291b5()
          : base(typeof (bool), "isMountable", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class PROP_847fc8ee75a94df2a6f3f727fa14c31a : HardwiredMemberDescriptor
      {
        internal PROP_847fc8ee75a94df2a6f3f727fa14c31a()
          : base(typeof (bool), "canMount", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class PROP_749e353c901c4f74bf00f74971ff28b6 : HardwiredMemberDescriptor
      {
        internal PROP_749e353c901c4f74bf00f74971ff28b6()
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

      private sealed class PROP_8bb54319f7d9415b81528bf694616253 : HardwiredMemberDescriptor
      {
        internal PROP_8bb54319f7d9415b81528bf694616253()
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

    private sealed class TYPE_af7d8213227c4316bbc580d77aae24b3 : HardwiredUserDataDescriptor
    {
      internal TYPE_af7d8213227c4316bbc580d77aae24b3()
        : base(typeof (ContainerEffector))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_af7d8213227c4316bbc580d77aae24b3.MTHD_bc3f063ed25b41f491031e21633ac065()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_af7d8213227c4316bbc580d77aae24b3.MTHD_b47345267af6466591d7ea8f331b268a()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_af7d8213227c4316bbc580d77aae24b3.MTHD_a69a450d05554afe880d6af5c5fbdbbd()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_af7d8213227c4316bbc580d77aae24b3.MTHD_33590592f8734d89a3b2ff16fa060abe()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_af7d8213227c4316bbc580d77aae24b3.MTHD_684900dc7b204547a7500a737397cf2a()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_af7d8213227c4316bbc580d77aae24b3.MTHD_9381ec944adb4e7a84a8cae7fff222a0()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_af7d8213227c4316bbc580d77aae24b3.MTHD_932280383c04414e842dae4200b114e2()
        }));
        this.AddMember("get_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_af7d8213227c4316bbc580d77aae24b3.MTHD_f23541ab287c412e9f4e7da80fe5479b()
        }));
        this.AddMember("set_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_af7d8213227c4316bbc580d77aae24b3.MTHD_d4b4990f0bab467a8143338ef52a1457()
        }));
        this.AddMember("get_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_af7d8213227c4316bbc580d77aae24b3.MTHD_24cd02ea52f14484b1918b7f5bedf674()
        }));
        this.AddMember("set_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_af7d8213227c4316bbc580d77aae24b3.MTHD_6c3c4652e80145929e194f7149829d28()
        }));
        this.AddMember("get_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_af7d8213227c4316bbc580d77aae24b3.MTHD_0f7f5f3d4a5548a283930b1d4d351d94()
        }));
        this.AddMember("set_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_af7d8213227c4316bbc580d77aae24b3.MTHD_727e4e463192467ea8f33b9ac2700c6f()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_af7d8213227c4316bbc580d77aae24b3.MTHD_0efd5bc9e0ee42c384c73e892f53eb57()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_af7d8213227c4316bbc580d77aae24b3.MTHD_7c344c55a2c948a486204e8551327c47()
        }));
        this.AddMember("turnPassed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("turnPassed", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_af7d8213227c4316bbc580d77aae24b3.MTHD_c497eda8569f4f80b2fb05249f0c5c9a()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_af7d8213227c4316bbc580d77aae24b3.MTHD_eda4a1941a5f44d99d896ba3d9638070()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_af7d8213227c4316bbc580d77aae24b3.MTHD_544bd40115a0461db4d4b661925e943e()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_af7d8213227c4316bbc580d77aae24b3.MTHD_1ce30533eada4432a0198a00c43b5be3()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_af7d8213227c4316bbc580d77aae24b3.MTHD_62d43519319d4a5dbf39b744840def59()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_af7d8213227c4316bbc580d77aae24b3.PROP_2dbd1b12150f4d198b63fbb367cd45bf());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_af7d8213227c4316bbc580d77aae24b3.PROP_81ca68ae202b4e1197fefb0f48d0c9e7());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_af7d8213227c4316bbc580d77aae24b3.PROP_252184683ccd47e89e4f74ce97fab8ca());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_af7d8213227c4316bbc580d77aae24b3.PROP_57f412d4718049b9983e608aae7f0b4d());
        this.AddMember("turnsAlive", (IMemberDescriptor) new Bridge.TYPE_af7d8213227c4316bbc580d77aae24b3.PROP_03f34052eddc47429ba42c323f9a8690());
        this.AddMember("maxTurnsAlive", (IMemberDescriptor) new Bridge.TYPE_af7d8213227c4316bbc580d77aae24b3.PROP_16925427cf724e2aa576e7e3fe46cdb0());
        this.AddMember("active", (IMemberDescriptor) new Bridge.TYPE_af7d8213227c4316bbc580d77aae24b3.PROP_0b990d32f25b4a2da26baa3e6498127d());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_af7d8213227c4316bbc580d77aae24b3.PROP_ee8127d2861b4f2cb076657e8c298924());
      }

      private sealed class MTHD_bc3f063ed25b41f491031e21633ac065 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bc3f063ed25b41f491031e21633ac065()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class MTHD_b47345267af6466591d7ea8f331b268a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b47345267af6466591d7ea8f331b268a()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).x;
        }
      }

      private sealed class MTHD_a69a450d05554afe880d6af5c5fbdbbd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a69a450d05554afe880d6af5c5fbdbbd()
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

      private sealed class MTHD_33590592f8734d89a3b2ff16fa060abe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_33590592f8734d89a3b2ff16fa060abe()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).y;
        }
      }

      private sealed class MTHD_684900dc7b204547a7500a737397cf2a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_684900dc7b204547a7500a737397cf2a()
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

      private sealed class MTHD_9381ec944adb4e7a84a8cae7fff222a0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9381ec944adb4e7a84a8cae7fff222a0()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).position;
        }
      }

      private sealed class MTHD_932280383c04414e842dae4200b114e2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_932280383c04414e842dae4200b114e2()
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

      private sealed class MTHD_f23541ab287c412e9f4e7da80fe5479b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f23541ab287c412e9f4e7da80fe5479b()
        {
          this.Initialize("get_turnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).turnsAlive;
        }
      }

      private sealed class MTHD_d4b4990f0bab467a8143338ef52a1457 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d4b4990f0bab467a8143338ef52a1457()
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

      private sealed class MTHD_24cd02ea52f14484b1918b7f5bedf674 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_24cd02ea52f14484b1918b7f5bedf674()
        {
          this.Initialize("get_maxTurnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).maxTurnsAlive;
        }
      }

      private sealed class MTHD_6c3c4652e80145929e194f7149829d28 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6c3c4652e80145929e194f7149829d28()
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

      private sealed class MTHD_0f7f5f3d4a5548a283930b1d4d351d94 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0f7f5f3d4a5548a283930b1d4d351d94()
        {
          this.Initialize("get_active", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).active;
        }
      }

      private sealed class MTHD_727e4e463192467ea8f33b9ac2700c6f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_727e4e463192467ea8f33b9ac2700c6f()
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

      private sealed class MTHD_0efd5bc9e0ee42c384c73e892f53eb57 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0efd5bc9e0ee42c384c73e892f53eb57()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }

      private sealed class MTHD_7c344c55a2c948a486204e8551327c47 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7c344c55a2c948a486204e8551327c47()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_c497eda8569f4f80b2fb05249f0c5c9a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c497eda8569f4f80b2fb05249f0c5c9a()
        {
          this.Initialize("turnPassed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).turnPassed();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_eda4a1941a5f44d99d896ba3d9638070 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eda4a1941a5f44d99d896ba3d9638070()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).GetHashCode();
        }
      }

      private sealed class MTHD_544bd40115a0461db4d4b661925e943e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_544bd40115a0461db4d4b661925e943e()
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

      private sealed class MTHD_1ce30533eada4432a0198a00c43b5be3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1ce30533eada4432a0198a00c43b5be3()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_62d43519319d4a5dbf39b744840def59 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_62d43519319d4a5dbf39b744840def59()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_2dbd1b12150f4d198b63fbb367cd45bf : HardwiredMemberDescriptor
      {
        internal PROP_2dbd1b12150f4d198b63fbb367cd45bf()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class PROP_81ca68ae202b4e1197fefb0f48d0c9e7 : HardwiredMemberDescriptor
      {
        internal PROP_81ca68ae202b4e1197fefb0f48d0c9e7()
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

      private sealed class PROP_252184683ccd47e89e4f74ce97fab8ca : HardwiredMemberDescriptor
      {
        internal PROP_252184683ccd47e89e4f74ce97fab8ca()
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

      private sealed class PROP_57f412d4718049b9983e608aae7f0b4d : HardwiredMemberDescriptor
      {
        internal PROP_57f412d4718049b9983e608aae7f0b4d()
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

      private sealed class PROP_03f34052eddc47429ba42c323f9a8690 : HardwiredMemberDescriptor
      {
        internal PROP_03f34052eddc47429ba42c323f9a8690()
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

      private sealed class PROP_16925427cf724e2aa576e7e3fe46cdb0 : HardwiredMemberDescriptor
      {
        internal PROP_16925427cf724e2aa576e7e3fe46cdb0()
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

      private sealed class PROP_0b990d32f25b4a2da26baa3e6498127d : HardwiredMemberDescriptor
      {
        internal PROP_0b990d32f25b4a2da26baa3e6498127d()
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

      private sealed class PROP_ee8127d2861b4f2cb076657e8c298924 : HardwiredMemberDescriptor
      {
        internal PROP_ee8127d2861b4f2cb076657e8c298924()
          : base(typeof (EffectorType), "type", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }
    }

    private sealed class TYPE_7144828b165440668f329f8b6e4cade4 : HardwiredUserDataDescriptor
    {
      internal TYPE_7144828b165440668f329f8b6e4cade4()
        : base(typeof (ContainerIndicator))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7144828b165440668f329f8b6e4cade4.MTHD_b65e8435cec541478b0cbb63f60979ec()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7144828b165440668f329f8b6e4cade4.MTHD_7432e25dcbd9440cad051e91c063e3cf()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7144828b165440668f329f8b6e4cade4.MTHD_58f45c2ce9184ce9be029d83dab55310()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7144828b165440668f329f8b6e4cade4.MTHD_06a7ff64aad2410e8eedeb891d6602bc()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7144828b165440668f329f8b6e4cade4.MTHD_bfb65df6f523411485ff5afd79825ed1()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7144828b165440668f329f8b6e4cade4.MTHD_2efdb239ea1f48aabb81fa69075f732a()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7144828b165440668f329f8b6e4cade4.MTHD_62ca276a47dd42d8b34135ac2b4f28f2()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7144828b165440668f329f8b6e4cade4.MTHD_ac242fbe2a6245dcad6952cbc3f111de()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7144828b165440668f329f8b6e4cade4.MTHD_6bfdac18a990462295a6294092019b81()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7144828b165440668f329f8b6e4cade4.MTHD_64e96844be2e4718b1d647fd040a1379()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7144828b165440668f329f8b6e4cade4.MTHD_85a85a3b5d60448e85aeffb8ff768d2f()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7144828b165440668f329f8b6e4cade4.MTHD_7841c3ea410d44e3a85009ab72e30613()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7144828b165440668f329f8b6e4cade4.MTHD_4b9848f6439b4ed190f76705e8aec5cf()
        }));
        this.AddMember("get_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color2", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7144828b165440668f329f8b6e4cade4.MTHD_6a72a48dee6a48b686500ad044cbd0cd()
        }));
        this.AddMember("set_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color2", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7144828b165440668f329f8b6e4cade4.MTHD_85a4232924704b7c9d3a88b2c245357f()
        }));
        this.AddMember("get_kind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_kind", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7144828b165440668f329f8b6e4cade4.MTHD_325f81f796e44b69b7a4287bf6f4b86d()
        }));
        this.AddMember("setIcon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setIcon", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7144828b165440668f329f8b6e4cade4.MTHD_e5904b50d3eb4513b7fd3e8a481b6d36()
        }));
        this.AddMember("Destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Destroy", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7144828b165440668f329f8b6e4cade4.MTHD_b830df580e2444c18a07c33b7d450684()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7144828b165440668f329f8b6e4cade4.MTHD_1662cae9374e4366abbc040356d0d2f9()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7144828b165440668f329f8b6e4cade4.MTHD_95184f803cd74b5db3c19e628a2bde64()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7144828b165440668f329f8b6e4cade4.MTHD_58dcf29a472243b4a9e405962bce2dd0()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7144828b165440668f329f8b6e4cade4.MTHD_6a1d6761a22b40ca9c6e2c7aa8dc160d()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_7144828b165440668f329f8b6e4cade4.PROP_e0774449293e4b42a0ebee7a197c124d());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_7144828b165440668f329f8b6e4cade4.PROP_e35aa25d805544a28d54756908a1e272());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_7144828b165440668f329f8b6e4cade4.PROP_c80509a72b4946c8869d2f8a34afedee());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_7144828b165440668f329f8b6e4cade4.PROP_ab9212b713424fa393f3effe14144fd8());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_7144828b165440668f329f8b6e4cade4.PROP_d91c6fcbdfe04e3884300210c667ff36());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_7144828b165440668f329f8b6e4cade4.PROP_5da27dce6936402fab8966b41e3e7316());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_7144828b165440668f329f8b6e4cade4.PROP_4946ac08cefc4bdf9983c4991293ad74());
        this.AddMember("color2", (IMemberDescriptor) new Bridge.TYPE_7144828b165440668f329f8b6e4cade4.PROP_541bcade9715411d95b3767f0a0c1f6d());
        this.AddMember("kind", (IMemberDescriptor) new Bridge.TYPE_7144828b165440668f329f8b6e4cade4.PROP_cff6134f8b684e4cacfa5024c782dc8b());
      }

      private sealed class MTHD_b65e8435cec541478b0cbb63f60979ec : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b65e8435cec541478b0cbb63f60979ec()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class MTHD_7432e25dcbd9440cad051e91c063e3cf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7432e25dcbd9440cad051e91c063e3cf()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).x;
        }
      }

      private sealed class MTHD_58f45c2ce9184ce9be029d83dab55310 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_58f45c2ce9184ce9be029d83dab55310()
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

      private sealed class MTHD_06a7ff64aad2410e8eedeb891d6602bc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_06a7ff64aad2410e8eedeb891d6602bc()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).y;
        }
      }

      private sealed class MTHD_bfb65df6f523411485ff5afd79825ed1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bfb65df6f523411485ff5afd79825ed1()
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

      private sealed class MTHD_2efdb239ea1f48aabb81fa69075f732a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2efdb239ea1f48aabb81fa69075f732a()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).radius;
        }
      }

      private sealed class MTHD_62ca276a47dd42d8b34135ac2b4f28f2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_62ca276a47dd42d8b34135ac2b4f28f2()
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

      private sealed class MTHD_ac242fbe2a6245dcad6952cbc3f111de : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ac242fbe2a6245dcad6952cbc3f111de()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).position;
        }
      }

      private sealed class MTHD_6bfdac18a990462295a6294092019b81 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6bfdac18a990462295a6294092019b81()
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

      private sealed class MTHD_64e96844be2e4718b1d647fd040a1379 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_64e96844be2e4718b1d647fd040a1379()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).angle;
        }
      }

      private sealed class MTHD_85a85a3b5d60448e85aeffb8ff768d2f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_85a85a3b5d60448e85aeffb8ff768d2f()
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

      private sealed class MTHD_7841c3ea410d44e3a85009ab72e30613 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7841c3ea410d44e3a85009ab72e30613()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color;
        }
      }

      private sealed class MTHD_4b9848f6439b4ed190f76705e8aec5cf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4b9848f6439b4ed190f76705e8aec5cf()
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

      private sealed class MTHD_6a72a48dee6a48b686500ad044cbd0cd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6a72a48dee6a48b686500ad044cbd0cd()
        {
          this.Initialize("get_color2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color2;
        }
      }

      private sealed class MTHD_85a4232924704b7c9d3a88b2c245357f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_85a4232924704b7c9d3a88b2c245357f()
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

      private sealed class MTHD_325f81f796e44b69b7a4287bf6f4b86d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_325f81f796e44b69b7a4287bf6f4b86d()
        {
          this.Initialize("get_kind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }

      private sealed class MTHD_e5904b50d3eb4513b7fd3e8a481b6d36 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e5904b50d3eb4513b7fd3e8a481b6d36()
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

      private sealed class MTHD_b830df580e2444c18a07c33b7d450684 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b830df580e2444c18a07c33b7d450684()
        {
          this.Initialize("Destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerIndicator) obj).Destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_1662cae9374e4366abbc040356d0d2f9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1662cae9374e4366abbc040356d0d2f9()
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

      private sealed class MTHD_95184f803cd74b5db3c19e628a2bde64 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_95184f803cd74b5db3c19e628a2bde64()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_58dcf29a472243b4a9e405962bce2dd0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_58dcf29a472243b4a9e405962bce2dd0()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_6a1d6761a22b40ca9c6e2c7aa8dc160d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6a1d6761a22b40ca9c6e2c7aa8dc160d()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_e0774449293e4b42a0ebee7a197c124d : HardwiredMemberDescriptor
      {
        internal PROP_e0774449293e4b42a0ebee7a197c124d()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class PROP_e35aa25d805544a28d54756908a1e272 : HardwiredMemberDescriptor
      {
        internal PROP_e35aa25d805544a28d54756908a1e272()
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

      private sealed class PROP_c80509a72b4946c8869d2f8a34afedee : HardwiredMemberDescriptor
      {
        internal PROP_c80509a72b4946c8869d2f8a34afedee()
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

      private sealed class PROP_ab9212b713424fa393f3effe14144fd8 : HardwiredMemberDescriptor
      {
        internal PROP_ab9212b713424fa393f3effe14144fd8()
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

      private sealed class PROP_d91c6fcbdfe04e3884300210c667ff36 : HardwiredMemberDescriptor
      {
        internal PROP_d91c6fcbdfe04e3884300210c667ff36()
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

      private sealed class PROP_5da27dce6936402fab8966b41e3e7316 : HardwiredMemberDescriptor
      {
        internal PROP_5da27dce6936402fab8966b41e3e7316()
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

      private sealed class PROP_4946ac08cefc4bdf9983c4991293ad74 : HardwiredMemberDescriptor
      {
        internal PROP_4946ac08cefc4bdf9983c4991293ad74()
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

      private sealed class PROP_541bcade9715411d95b3767f0a0c1f6d : HardwiredMemberDescriptor
      {
        internal PROP_541bcade9715411d95b3767f0a0c1f6d()
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

      private sealed class PROP_cff6134f8b684e4cacfa5024c782dc8b : HardwiredMemberDescriptor
      {
        internal PROP_cff6134f8b684e4cacfa5024c782dc8b()
          : base(typeof (IndicatorKind), "kind", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }
    }

    private sealed class TYPE_a824fa2a52584d53af8602aa1e466df4 : HardwiredUserDataDescriptor
    {
      internal TYPE_a824fa2a52584d53af8602aa1e466df4()
        : base(typeof (ContainerSpell))
      {
        this.AddMember("get_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a824fa2a52584d53af8602aa1e466df4.MTHD_42bb7028c96241ecb5242c0fe1609b18()
        }));
        this.AddMember("set_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a824fa2a52584d53af8602aa1e466df4.MTHD_348b70932a3144efb067234717eb82c9()
        }));
        this.AddMember("get_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a824fa2a52584d53af8602aa1e466df4.MTHD_bfc1f57eb6f7432594eae85f23637dae()
        }));
        this.AddMember("set_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a824fa2a52584d53af8602aa1e466df4.MTHD_9d7173c543854a2896956f1e65c13cb0()
        }));
        this.AddMember("get_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a824fa2a52584d53af8602aa1e466df4.MTHD_e3938a90e10246cb98f9ac816e4939c1()
        }));
        this.AddMember("set_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a824fa2a52584d53af8602aa1e466df4.MTHD_8e8283b1485943bc93e342fd953620bd()
        }));
        this.AddMember("get_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a824fa2a52584d53af8602aa1e466df4.MTHD_16ba28d5817148b4a5543d1ea70bd4d0()
        }));
        this.AddMember("set_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a824fa2a52584d53af8602aa1e466df4.MTHD_39b537ec2aa94a7099e7dc6a8c33ec50()
        }));
        this.AddMember("get_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a824fa2a52584d53af8602aa1e466df4.MTHD_427f0884c38d4f1a998752f467ad0839()
        }));
        this.AddMember("set_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a824fa2a52584d53af8602aa1e466df4.MTHD_f4422cc8f12547ceb7446c30940d31cc()
        }));
        this.AddMember("get_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a824fa2a52584d53af8602aa1e466df4.MTHD_6b99eaf571ac4bb6968ed5198da9208d()
        }));
        this.AddMember("set_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a824fa2a52584d53af8602aa1e466df4.MTHD_a6a14755a1b84293983ef29ad4cca2f3()
        }));
        this.AddMember("get_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a824fa2a52584d53af8602aa1e466df4.MTHD_454b8435c41a45609e3ec48738133d7e()
        }));
        this.AddMember("set_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a824fa2a52584d53af8602aa1e466df4.MTHD_06f1f57227b546d69db7dea3d0d0b5c1()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a824fa2a52584d53af8602aa1e466df4.MTHD_800cf11aacfe463f90a6e53965f8bc52()
        }));
        this.AddMember("get_castType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_castType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a824fa2a52584d53af8602aa1e466df4.MTHD_ac140ff5d0874e20a93081cc1347a99e()
        }));
        this.AddMember("get_damageType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damageType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a824fa2a52584d53af8602aa1e466df4.MTHD_50c52b0ba4a141338102e6fc6e205153()
        }));
        this.AddMember("get_book", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_book", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a824fa2a52584d53af8602aa1e466df4.MTHD_488ccdbb7cc24f658e33fd2dd1d13d2d()
        }));
        this.AddMember("get_damage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damage", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a824fa2a52584d53af8602aa1e466df4.MTHD_9ee068beff9349c1bbe0dd19c1032176()
        }));
        this.AddMember("get_explosionRadius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_explosionRadius", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a824fa2a52584d53af8602aa1e466df4.MTHD_0dd050f74fc544c5bcac7dd385d369f5()
        }));
        this.AddMember("get_description", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_description", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a824fa2a52584d53af8602aa1e466df4.MTHD_3a11f6efe6bd4402861430b5bbd861a8()
        }));
        this.AddMember("get_descriptionOnly", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionOnly", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a824fa2a52584d53af8602aa1e466df4.MTHD_52a7c32deb28400fa5caadd9d0f8f4c0()
        }));
        this.AddMember("get_descriptionExtra", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionExtra", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a824fa2a52584d53af8602aa1e466df4.MTHD_74989fed7f3e4c52910022988be0c3d7()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a824fa2a52584d53af8602aa1e466df4.MTHD_6c1dd402fc074b74b2f2c4ad9b157afb()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a824fa2a52584d53af8602aa1e466df4.MTHD_84881b714daa4f32aa8207953a1a2a62()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a824fa2a52584d53af8602aa1e466df4.MTHD_cba8a99e823442e3906f53dd650d2900()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a824fa2a52584d53af8602aa1e466df4.MTHD_071bd5dd5d554aa98f8cda0f5da2cef9()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a824fa2a52584d53af8602aa1e466df4.MTHD_d63776b773d24998a24995346f60e00a()
        }));
        this.AddMember("uses", (IMemberDescriptor) new Bridge.TYPE_a824fa2a52584d53af8602aa1e466df4.PROP_4166585a7eea455cae00c8d5f127065f());
        this.AddMember("maxUses", (IMemberDescriptor) new Bridge.TYPE_a824fa2a52584d53af8602aa1e466df4.PROP_12501325648f4278ad4626e6334d2914());
        this.AddMember("rechargeTime", (IMemberDescriptor) new Bridge.TYPE_a824fa2a52584d53af8602aa1e466df4.PROP_d2781889398d4c5c84940a700c0f9777());
        this.AddMember("lastTurnFired", (IMemberDescriptor) new Bridge.TYPE_a824fa2a52584d53af8602aa1e466df4.PROP_68a9613b088a4515a717bd5c11f747c8());
        this.AddMember("isPresent", (IMemberDescriptor) new Bridge.TYPE_a824fa2a52584d53af8602aa1e466df4.PROP_6585eed318274be5adaae182895d35d1());
        this.AddMember("locked", (IMemberDescriptor) new Bridge.TYPE_a824fa2a52584d53af8602aa1e466df4.PROP_abe5ebca840d41c7920b5e6b3c582125());
        this.AddMember("turnsTillFirstUse", (IMemberDescriptor) new Bridge.TYPE_a824fa2a52584d53af8602aa1e466df4.PROP_624aeb00281a40df9a5c1654df3d984e());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_a824fa2a52584d53af8602aa1e466df4.PROP_3d91bfe199354f45be98769373e40c4d());
        this.AddMember("castType", (IMemberDescriptor) new Bridge.TYPE_a824fa2a52584d53af8602aa1e466df4.PROP_cc4df9027b67495fb56c2f4dcabfeade());
        this.AddMember("damageType", (IMemberDescriptor) new Bridge.TYPE_a824fa2a52584d53af8602aa1e466df4.PROP_505059a8b83340069f7b636b1d560643());
        this.AddMember("book", (IMemberDescriptor) new Bridge.TYPE_a824fa2a52584d53af8602aa1e466df4.PROP_d9cb385bd765428fac303eb2ff966d32());
        this.AddMember("damage", (IMemberDescriptor) new Bridge.TYPE_a824fa2a52584d53af8602aa1e466df4.PROP_300f85b5d50645f3854421672c82e284());
        this.AddMember("explosionRadius", (IMemberDescriptor) new Bridge.TYPE_a824fa2a52584d53af8602aa1e466df4.PROP_1f6c0bdd540a435a942f6ce3f2dfa9c3());
        this.AddMember("description", (IMemberDescriptor) new Bridge.TYPE_a824fa2a52584d53af8602aa1e466df4.PROP_c16c5f1ecd1d4fa09e2f32691de22179());
        this.AddMember("descriptionOnly", (IMemberDescriptor) new Bridge.TYPE_a824fa2a52584d53af8602aa1e466df4.PROP_8980b44510d64320a91930b55a90dd87());
        this.AddMember("descriptionExtra", (IMemberDescriptor) new Bridge.TYPE_a824fa2a52584d53af8602aa1e466df4.PROP_514367d8069d40e284d4051f82359fba());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_a824fa2a52584d53af8602aa1e466df4.PROP_c374224a62b24733ab602c77f43606ff());
      }

      private sealed class MTHD_42bb7028c96241ecb5242c0fe1609b18 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_42bb7028c96241ecb5242c0fe1609b18()
        {
          this.Initialize("get_uses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).uses;
        }
      }

      private sealed class MTHD_348b70932a3144efb067234717eb82c9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_348b70932a3144efb067234717eb82c9()
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

      private sealed class MTHD_bfc1f57eb6f7432594eae85f23637dae : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bfc1f57eb6f7432594eae85f23637dae()
        {
          this.Initialize("get_maxUses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).maxUses;
        }
      }

      private sealed class MTHD_9d7173c543854a2896956f1e65c13cb0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9d7173c543854a2896956f1e65c13cb0()
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

      private sealed class MTHD_e3938a90e10246cb98f9ac816e4939c1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e3938a90e10246cb98f9ac816e4939c1()
        {
          this.Initialize("get_rechargeTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).rechargeTime;
        }
      }

      private sealed class MTHD_8e8283b1485943bc93e342fd953620bd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8e8283b1485943bc93e342fd953620bd()
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

      private sealed class MTHD_16ba28d5817148b4a5543d1ea70bd4d0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_16ba28d5817148b4a5543d1ea70bd4d0()
        {
          this.Initialize("get_lastTurnFired", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).lastTurnFired;
        }
      }

      private sealed class MTHD_39b537ec2aa94a7099e7dc6a8c33ec50 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_39b537ec2aa94a7099e7dc6a8c33ec50()
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

      private sealed class MTHD_427f0884c38d4f1a998752f467ad0839 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_427f0884c38d4f1a998752f467ad0839()
        {
          this.Initialize("get_isPresent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).isPresent;
        }
      }

      private sealed class MTHD_f4422cc8f12547ceb7446c30940d31cc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f4422cc8f12547ceb7446c30940d31cc()
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

      private sealed class MTHD_6b99eaf571ac4bb6968ed5198da9208d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6b99eaf571ac4bb6968ed5198da9208d()
        {
          this.Initialize("get_locked", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).locked;
        }
      }

      private sealed class MTHD_a6a14755a1b84293983ef29ad4cca2f3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a6a14755a1b84293983ef29ad4cca2f3()
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

      private sealed class MTHD_454b8435c41a45609e3ec48738133d7e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_454b8435c41a45609e3ec48738133d7e()
        {
          this.Initialize("get_turnsTillFirstUse", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).turnsTillFirstUse;
        }
      }

      private sealed class MTHD_06f1f57227b546d69db7dea3d0d0b5c1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_06f1f57227b546d69db7dea3d0d0b5c1()
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

      private sealed class MTHD_800cf11aacfe463f90a6e53965f8bc52 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_800cf11aacfe463f90a6e53965f8bc52()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class MTHD_ac140ff5d0874e20a93081cc1347a99e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ac140ff5d0874e20a93081cc1347a99e()
        {
          this.Initialize("get_castType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class MTHD_50c52b0ba4a141338102e6fc6e205153 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_50c52b0ba4a141338102e6fc6e205153()
        {
          this.Initialize("get_damageType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class MTHD_488ccdbb7cc24f658e33fd2dd1d13d2d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_488ccdbb7cc24f658e33fd2dd1d13d2d()
        {
          this.Initialize("get_book", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class MTHD_9ee068beff9349c1bbe0dd19c1032176 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9ee068beff9349c1bbe0dd19c1032176()
        {
          this.Initialize("get_damage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class MTHD_0dd050f74fc544c5bcac7dd385d369f5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0dd050f74fc544c5bcac7dd385d369f5()
        {
          this.Initialize("get_explosionRadius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class MTHD_3a11f6efe6bd4402861430b5bbd861a8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3a11f6efe6bd4402861430b5bbd861a8()
        {
          this.Initialize("get_description", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class MTHD_52a7c32deb28400fa5caadd9d0f8f4c0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_52a7c32deb28400fa5caadd9d0f8f4c0()
        {
          this.Initialize("get_descriptionOnly", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class MTHD_74989fed7f3e4c52910022988be0c3d7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_74989fed7f3e4c52910022988be0c3d7()
        {
          this.Initialize("get_descriptionExtra", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class MTHD_6c1dd402fc074b74b2f2c4ad9b157afb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6c1dd402fc074b74b2f2c4ad9b157afb()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }

      private sealed class MTHD_84881b714daa4f32aa8207953a1a2a62 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_84881b714daa4f32aa8207953a1a2a62()
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

      private sealed class MTHD_cba8a99e823442e3906f53dd650d2900 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cba8a99e823442e3906f53dd650d2900()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_071bd5dd5d554aa98f8cda0f5da2cef9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_071bd5dd5d554aa98f8cda0f5da2cef9()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_d63776b773d24998a24995346f60e00a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d63776b773d24998a24995346f60e00a()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_4166585a7eea455cae00c8d5f127065f : HardwiredMemberDescriptor
      {
        internal PROP_4166585a7eea455cae00c8d5f127065f()
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

      private sealed class PROP_12501325648f4278ad4626e6334d2914 : HardwiredMemberDescriptor
      {
        internal PROP_12501325648f4278ad4626e6334d2914()
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

      private sealed class PROP_d2781889398d4c5c84940a700c0f9777 : HardwiredMemberDescriptor
      {
        internal PROP_d2781889398d4c5c84940a700c0f9777()
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

      private sealed class PROP_68a9613b088a4515a717bd5c11f747c8 : HardwiredMemberDescriptor
      {
        internal PROP_68a9613b088a4515a717bd5c11f747c8()
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

      private sealed class PROP_6585eed318274be5adaae182895d35d1 : HardwiredMemberDescriptor
      {
        internal PROP_6585eed318274be5adaae182895d35d1()
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

      private sealed class PROP_abe5ebca840d41c7920b5e6b3c582125 : HardwiredMemberDescriptor
      {
        internal PROP_abe5ebca840d41c7920b5e6b3c582125()
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

      private sealed class PROP_624aeb00281a40df9a5c1654df3d984e : HardwiredMemberDescriptor
      {
        internal PROP_624aeb00281a40df9a5c1654df3d984e()
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

      private sealed class PROP_3d91bfe199354f45be98769373e40c4d : HardwiredMemberDescriptor
      {
        internal PROP_3d91bfe199354f45be98769373e40c4d()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class PROP_cc4df9027b67495fb56c2f4dcabfeade : HardwiredMemberDescriptor
      {
        internal PROP_cc4df9027b67495fb56c2f4dcabfeade()
          : base(typeof (CastType), "castType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class PROP_505059a8b83340069f7b636b1d560643 : HardwiredMemberDescriptor
      {
        internal PROP_505059a8b83340069f7b636b1d560643()
          : base(typeof (DamageType), "damageType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class PROP_d9cb385bd765428fac303eb2ff966d32 : HardwiredMemberDescriptor
      {
        internal PROP_d9cb385bd765428fac303eb2ff966d32()
          : base(typeof (BookOf), "book", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class PROP_300f85b5d50645f3854421672c82e284 : HardwiredMemberDescriptor
      {
        internal PROP_300f85b5d50645f3854421672c82e284()
          : base(typeof (int), "damage", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class PROP_1f6c0bdd540a435a942f6ce3f2dfa9c3 : HardwiredMemberDescriptor
      {
        internal PROP_1f6c0bdd540a435a942f6ce3f2dfa9c3()
          : base(typeof (int), "explosionRadius", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class PROP_c16c5f1ecd1d4fa09e2f32691de22179 : HardwiredMemberDescriptor
      {
        internal PROP_c16c5f1ecd1d4fa09e2f32691de22179()
          : base(typeof (string), "description", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class PROP_8980b44510d64320a91930b55a90dd87 : HardwiredMemberDescriptor
      {
        internal PROP_8980b44510d64320a91930b55a90dd87()
          : base(typeof (string), "descriptionOnly", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class PROP_514367d8069d40e284d4051f82359fba : HardwiredMemberDescriptor
      {
        internal PROP_514367d8069d40e284d4051f82359fba()
          : base(typeof (string), "descriptionExtra", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class PROP_c374224a62b24733ab602c77f43606ff : HardwiredMemberDescriptor
      {
        internal PROP_c374224a62b24733ab602c77f43606ff()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }
    }

    private sealed class TYPE_bec8410e7d094e898f08622fd13a6bc3 : HardwiredUserDataDescriptor
    {
      internal TYPE_bec8410e7d094e898f08622fd13a6bc3()
        : base(typeof (ContainerTower))
      {
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bec8410e7d094e898f08622fd13a6bc3.MTHD_07599d0db75c4d399e8e28aa512abb0d()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bec8410e7d094e898f08622fd13a6bc3.MTHD_34cf6cfc906e4b03ac038b14fd742992()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bec8410e7d094e898f08622fd13a6bc3.MTHD_254a2da4d53c4903927f46206b89b60f()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bec8410e7d094e898f08622fd13a6bc3.MTHD_4fcd4c88606541c1baa164f7d25be6a3()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bec8410e7d094e898f08622fd13a6bc3.MTHD_a11d6233baad4d88a6f8b86fb369152c()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bec8410e7d094e898f08622fd13a6bc3.MTHD_5ead3c067909482bac0fd745e24b7aed()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bec8410e7d094e898f08622fd13a6bc3.MTHD_007d654b80f543f1aa22599d9e5505f5()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bec8410e7d094e898f08622fd13a6bc3.MTHD_0859858255dc4f5582853eddfd8c383e()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bec8410e7d094e898f08622fd13a6bc3.MTHD_6ab352f3a16f499bb020930fc263d8cf()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bec8410e7d094e898f08622fd13a6bc3.MTHD_cfff37785ed944a4b1b879007be12300()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bec8410e7d094e898f08622fd13a6bc3.MTHD_f70e9a11fb45459fbe926e8d0a59b14a()
        }));
        this.AddMember("getType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bec8410e7d094e898f08622fd13a6bc3.MTHD_99f70cfde7cc4a2ba780536099c9249e()
        }));
        this.AddMember("kill", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("kill", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bec8410e7d094e898f08622fd13a6bc3.MTHD_cafb4723e88b4d6e9f5ebab254d41b98()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bec8410e7d094e898f08622fd13a6bc3.MTHD_032ab0f473564162820669356d767be8()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bec8410e7d094e898f08622fd13a6bc3.MTHD_1f67d726e421442fa9f3efab44481e2a()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bec8410e7d094e898f08622fd13a6bc3.MTHD_f6560ce828ac468abf98059f25238a08()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bec8410e7d094e898f08622fd13a6bc3.MTHD_80a8c8ec1ddf4dc9ac8dfe5c27f6015f()
        }));
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_bec8410e7d094e898f08622fd13a6bc3.PROP_7bbd1263f7ee40b3b0b5da99126e0e55());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_bec8410e7d094e898f08622fd13a6bc3.PROP_be61708b90ae4ad3bfdb32cd61c1f540());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_bec8410e7d094e898f08622fd13a6bc3.PROP_1cce2e88f6334766b0d711dd1d1adcd1());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_bec8410e7d094e898f08622fd13a6bc3.PROP_e8adb5da8bec464886c3a0ad84977679());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_bec8410e7d094e898f08622fd13a6bc3.PROP_8269b7f1dbe44a8d9382cf4325adfc86());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_bec8410e7d094e898f08622fd13a6bc3.PROP_cc831af08184451f87bd8162eeb20fb3());
      }

      private sealed class MTHD_07599d0db75c4d399e8e28aa512abb0d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_07599d0db75c4d399e8e28aa512abb0d()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).health;
        }
      }

      private sealed class MTHD_34cf6cfc906e4b03ac038b14fd742992 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_34cf6cfc906e4b03ac038b14fd742992()
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

      private sealed class MTHD_254a2da4d53c4903927f46206b89b60f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_254a2da4d53c4903927f46206b89b60f()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).maxHealth;
        }
      }

      private sealed class MTHD_4fcd4c88606541c1baa164f7d25be6a3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4fcd4c88606541c1baa164f7d25be6a3()
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

      private sealed class MTHD_a11d6233baad4d88a6f8b86fb369152c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a11d6233baad4d88a6f8b86fb369152c()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).x;
        }
      }

      private sealed class MTHD_5ead3c067909482bac0fd745e24b7aed : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5ead3c067909482bac0fd745e24b7aed()
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

      private sealed class MTHD_007d654b80f543f1aa22599d9e5505f5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_007d654b80f543f1aa22599d9e5505f5()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).y;
        }
      }

      private sealed class MTHD_0859858255dc4f5582853eddfd8c383e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0859858255dc4f5582853eddfd8c383e()
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

      private sealed class MTHD_6ab352f3a16f499bb020930fc263d8cf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6ab352f3a16f499bb020930fc263d8cf()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).position;
        }
      }

      private sealed class MTHD_cfff37785ed944a4b1b879007be12300 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cfff37785ed944a4b1b879007be12300()
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

      private sealed class MTHD_f70e9a11fb45459fbe926e8d0a59b14a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f70e9a11fb45459fbe926e8d0a59b14a()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }

      private sealed class MTHD_99f70cfde7cc4a2ba780536099c9249e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_99f70cfde7cc4a2ba780536099c9249e()
        {
          this.Initialize("getType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).getType();
        }
      }

      private sealed class MTHD_cafb4723e88b4d6e9f5ebab254d41b98 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cafb4723e88b4d6e9f5ebab254d41b98()
        {
          this.Initialize("kill", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerTower) obj).kill();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_032ab0f473564162820669356d767be8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_032ab0f473564162820669356d767be8()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).GetHashCode();
        }
      }

      private sealed class MTHD_1f67d726e421442fa9f3efab44481e2a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1f67d726e421442fa9f3efab44481e2a()
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

      private sealed class MTHD_f6560ce828ac468abf98059f25238a08 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f6560ce828ac468abf98059f25238a08()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_80a8c8ec1ddf4dc9ac8dfe5c27f6015f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_80a8c8ec1ddf4dc9ac8dfe5c27f6015f()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_7bbd1263f7ee40b3b0b5da99126e0e55 : HardwiredMemberDescriptor
      {
        internal PROP_7bbd1263f7ee40b3b0b5da99126e0e55()
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

      private sealed class PROP_be61708b90ae4ad3bfdb32cd61c1f540 : HardwiredMemberDescriptor
      {
        internal PROP_be61708b90ae4ad3bfdb32cd61c1f540()
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

      private sealed class PROP_1cce2e88f6334766b0d711dd1d1adcd1 : HardwiredMemberDescriptor
      {
        internal PROP_1cce2e88f6334766b0d711dd1d1adcd1()
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

      private sealed class PROP_e8adb5da8bec464886c3a0ad84977679 : HardwiredMemberDescriptor
      {
        internal PROP_e8adb5da8bec464886c3a0ad84977679()
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

      private sealed class PROP_8269b7f1dbe44a8d9382cf4325adfc86 : HardwiredMemberDescriptor
      {
        internal PROP_8269b7f1dbe44a8d9382cf4325adfc86()
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

      private sealed class PROP_cc831af08184451f87bd8162eeb20fb3 : HardwiredMemberDescriptor
      {
        internal PROP_cc831af08184451f87bd8162eeb20fb3()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }
    }

    private sealed class TYPE_c336838a44cf42c985b3cf4cb56f0883 : HardwiredUserDataDescriptor
    {
      internal TYPE_c336838a44cf42c985b3cf4cb56f0883()
        : base(typeof (Educative.Point))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c336838a44cf42c985b3cf4cb56f0883.MTHD_e4c206a94ce240ddbd77d8b1e78217a4(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c336838a44cf42c985b3cf4cb56f0883.MTHD_d6f9485913174e65834d3709e9b43db6()
        }));
        this.AddMember("distance", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("distance", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c336838a44cf42c985b3cf4cb56f0883.MTHD_c1e9de99ceda4f2aaa6c016bf0718573(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c336838a44cf42c985b3cf4cb56f0883.MTHD_986bafe6162a4ac183fe489a43a02439()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c336838a44cf42c985b3cf4cb56f0883.MTHD_837b611432394ff3a18b594d74cd072c()
        }));
        this.AddMember("copy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("copy", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c336838a44cf42c985b3cf4cb56f0883.MTHD_3f25b72a66f745629946f468bc7262e1()
        }));
        this.AddMember("normalized", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalized", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c336838a44cf42c985b3cf4cb56f0883.MTHD_63cc5fcf5add45f9836bc5311bfaf029()
        }));
        this.AddMember("normalize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalize", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c336838a44cf42c985b3cf4cb56f0883.MTHD_46779a3b014b4e49ba8631c3ade17ba2()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c336838a44cf42c985b3cf4cb56f0883.MTHD_ef4a5030f3aa43198d41a00da0967b5b()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c336838a44cf42c985b3cf4cb56f0883.MTHD_ad0c179b407142e28e54e0a7e710be52()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c336838a44cf42c985b3cf4cb56f0883.MTHD_89888b80fb5942a1b652a9c68cd086f0()
        }));
        this.AddMember("op_Subtraction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Subtraction", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c336838a44cf42c985b3cf4cb56f0883.MTHD_6e8f0d104958472ba40bc6713956fac1(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c336838a44cf42c985b3cf4cb56f0883.MTHD_2375fd792a7b424bb079b2b392e3eeaf()
        }));
        this.AddMember("op_Addition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Addition", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c336838a44cf42c985b3cf4cb56f0883.MTHD_de08cab48ee949d68947bfe727ce4ec9(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c336838a44cf42c985b3cf4cb56f0883.MTHD_93c559b478534aaa9e48ce224877ae6f()
        }));
        this.AddMember("op_Multiply", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Multiply", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c336838a44cf42c985b3cf4cb56f0883.MTHD_93dd592eb6454cadb761addcecb530c7(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c336838a44cf42c985b3cf4cb56f0883.MTHD_8a59bbfe654849d5b808c248186f1164()
        }));
        this.AddMember("op_Division", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Division", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c336838a44cf42c985b3cf4cb56f0883.MTHD_58a3561dd3204fedb1da8da834867efe(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c336838a44cf42c985b3cf4cb56f0883.MTHD_461a3061ef754d9fab4fcf7d4c63b145()
        }));
        this.AddMember("op_Modulus", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Modulus", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c336838a44cf42c985b3cf4cb56f0883.MTHD_5e4438a7327a416d911eddef63019d51(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c336838a44cf42c985b3cf4cb56f0883.MTHD_de5022981d5b48ad82111ce5bdf89ad6()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c336838a44cf42c985b3cf4cb56f0883.MTHD_abb3d6ac8c4c49a1942c93283499975f()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c336838a44cf42c985b3cf4cb56f0883.MTHD_1af678b332bf48898fd093a836ecd7ec()
        }));
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_c336838a44cf42c985b3cf4cb56f0883.FLDV_e0943be342104712ab8d04ebd6b0d8c4());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_c336838a44cf42c985b3cf4cb56f0883.FLDV_2b91408526e449ac91f27001c1accf0c());
      }

      private sealed class MTHD_e4c206a94ce240ddbd77d8b1e78217a4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e4c206a94ce240ddbd77d8b1e78217a4()
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

      private sealed class MTHD_d6f9485913174e65834d3709e9b43db6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d6f9485913174e65834d3709e9b43db6()
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

      private sealed class MTHD_c1e9de99ceda4f2aaa6c016bf0718573 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c1e9de99ceda4f2aaa6c016bf0718573()
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

      private sealed class MTHD_986bafe6162a4ac183fe489a43a02439 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_986bafe6162a4ac183fe489a43a02439()
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

      private sealed class MTHD_837b611432394ff3a18b594d74cd072c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_837b611432394ff3a18b594d74cd072c()
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

      private sealed class MTHD_3f25b72a66f745629946f468bc7262e1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3f25b72a66f745629946f468bc7262e1()
        {
          this.Initialize("copy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).copy();
        }
      }

      private sealed class MTHD_63cc5fcf5add45f9836bc5311bfaf029 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_63cc5fcf5add45f9836bc5311bfaf029()
        {
          this.Initialize("normalized", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).normalized();
        }
      }

      private sealed class MTHD_46779a3b014b4e49ba8631c3ade17ba2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_46779a3b014b4e49ba8631c3ade17ba2()
        {
          this.Initialize("normalize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((Educative.Point) obj).normalize();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_ef4a5030f3aa43198d41a00da0967b5b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ef4a5030f3aa43198d41a00da0967b5b()
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

      private sealed class MTHD_ad0c179b407142e28e54e0a7e710be52 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ad0c179b407142e28e54e0a7e710be52()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).GetHashCode();
        }
      }

      private sealed class MTHD_89888b80fb5942a1b652a9c68cd086f0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_89888b80fb5942a1b652a9c68cd086f0()
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

      private sealed class MTHD_6e8f0d104958472ba40bc6713956fac1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6e8f0d104958472ba40bc6713956fac1()
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

      private sealed class MTHD_2375fd792a7b424bb079b2b392e3eeaf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2375fd792a7b424bb079b2b392e3eeaf()
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

      private sealed class MTHD_de08cab48ee949d68947bfe727ce4ec9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_de08cab48ee949d68947bfe727ce4ec9()
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

      private sealed class MTHD_93c559b478534aaa9e48ce224877ae6f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_93c559b478534aaa9e48ce224877ae6f()
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

      private sealed class MTHD_93dd592eb6454cadb761addcecb530c7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_93dd592eb6454cadb761addcecb530c7()
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

      private sealed class MTHD_8a59bbfe654849d5b808c248186f1164 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8a59bbfe654849d5b808c248186f1164()
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

      private sealed class MTHD_58a3561dd3204fedb1da8da834867efe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_58a3561dd3204fedb1da8da834867efe()
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

      private sealed class MTHD_461a3061ef754d9fab4fcf7d4c63b145 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_461a3061ef754d9fab4fcf7d4c63b145()
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

      private sealed class MTHD_5e4438a7327a416d911eddef63019d51 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5e4438a7327a416d911eddef63019d51()
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

      private sealed class MTHD_de5022981d5b48ad82111ce5bdf89ad6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_de5022981d5b48ad82111ce5bdf89ad6()
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

      private sealed class MTHD_abb3d6ac8c4c49a1942c93283499975f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_abb3d6ac8c4c49a1942c93283499975f()
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

      private sealed class MTHD_1af678b332bf48898fd093a836ecd7ec : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1af678b332bf48898fd093a836ecd7ec()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_e0943be342104712ab8d04ebd6b0d8c4 : HardwiredMemberDescriptor
      {
        internal FLDV_e0943be342104712ab8d04ebd6b0d8c4()
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

      private sealed class FLDV_2b91408526e449ac91f27001c1accf0c : HardwiredMemberDescriptor
      {
        internal FLDV_2b91408526e449ac91f27001c1accf0c()
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

    private sealed class TYPE_b767b971714b4f1b9947612e40681a6e : HardwiredUserDataDescriptor
    {
      internal TYPE_b767b971714b4f1b9947612e40681a6e()
        : base(typeof (Summon))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b767b971714b4f1b9947612e40681a6e.MTHD_7eab52a694e3420e923f09ce883b4dc0()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b767b971714b4f1b9947612e40681a6e.MTHD_d5e4860edc6e4d1ebd8f89057f927749()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b767b971714b4f1b9947612e40681a6e.MTHD_648768768a984b2d9d6d8433128daa6a()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b767b971714b4f1b9947612e40681a6e.MTHD_20d1141773cb4bfbbe3d99a540de5694()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b767b971714b4f1b9947612e40681a6e.MTHD_52d6e3040e664eb094c5f08de6712340()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b767b971714b4f1b9947612e40681a6e.MTHD_4d51c7ae4f744cf8b0b5e9f6df4c8141()
        }));
        this.AddMember("spell", (IMemberDescriptor) new Bridge.TYPE_b767b971714b4f1b9947612e40681a6e.FLDV_98c3a92b7b1b4faea0b2214756c83a88());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_b767b971714b4f1b9947612e40681a6e.FLDV_8c9f6869a8b740ac8027119c07b06b56());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_b767b971714b4f1b9947612e40681a6e.FLDV_4f0ef3656d1b4aa2b2c7af522bc9a83c());
        this.AddMember("onPlayersPanel", (IMemberDescriptor) new Bridge.TYPE_b767b971714b4f1b9947612e40681a6e.FLDV_d0c49ded05ba47b791716ca86c1c9ca4());
        this.AddMember("useAI", (IMemberDescriptor) new Bridge.TYPE_b767b971714b4f1b9947612e40681a6e.FLDV_ea26edef554e4de78e642dc3be348a41());
        this.AddMember("no_AI_still_use_turn", (IMemberDescriptor) new Bridge.TYPE_b767b971714b4f1b9947612e40681a6e.FLDV_e5a6ef400d35448a95a8eae469baca91());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_b767b971714b4f1b9947612e40681a6e.FLDV_0abd512ddd4d4066ae8e95eb0b259694());
        this.AddMember("playSound", (IMemberDescriptor) new Bridge.TYPE_b767b971714b4f1b9947612e40681a6e.FLDV_c85895acda2c4bf69651f056d48adf73());
        this.AddMember("prestige", (IMemberDescriptor) new Bridge.TYPE_b767b971714b4f1b9947612e40681a6e.FLDV_70a9abf1ebaa45fc8020e51a045c13e2());
        this.AddMember("colors", (IMemberDescriptor) new Bridge.TYPE_b767b971714b4f1b9947612e40681a6e.FLDV_f94d8b3655dd4af8a945d167a44092b5());
        this.AddMember("spells", (IMemberDescriptor) new Bridge.TYPE_b767b971714b4f1b9947612e40681a6e.FLDV_0a16c9c5c9f84321a878cab46126242e());
        this.AddMember("outfit", (IMemberDescriptor) new Bridge.TYPE_b767b971714b4f1b9947612e40681a6e.FLDV_f004c8ad505d4120b363d79418a2e434());
        this.AddMember("elemental", (IMemberDescriptor) new Bridge.TYPE_b767b971714b4f1b9947612e40681a6e.FLDV_bef3839726cf4c2f8ae5b1120dd6c925());
      }

      private sealed class MTHD_7eab52a694e3420e923f09ce883b4dc0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7eab52a694e3420e923f09ce883b4dc0()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new Summon();
        }
      }

      private sealed class MTHD_d5e4860edc6e4d1ebd8f89057f927749 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d5e4860edc6e4d1ebd8f89057f927749()
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

      private sealed class MTHD_648768768a984b2d9d6d8433128daa6a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_648768768a984b2d9d6d8433128daa6a()
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

      private sealed class MTHD_20d1141773cb4bfbbe3d99a540de5694 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_20d1141773cb4bfbbe3d99a540de5694()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_52d6e3040e664eb094c5f08de6712340 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_52d6e3040e664eb094c5f08de6712340()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_4d51c7ae4f744cf8b0b5e9f6df4c8141 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4d51c7ae4f744cf8b0b5e9f6df4c8141()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_98c3a92b7b1b4faea0b2214756c83a88 : HardwiredMemberDescriptor
      {
        internal FLDV_98c3a92b7b1b4faea0b2214756c83a88()
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

      private sealed class FLDV_8c9f6869a8b740ac8027119c07b06b56 : HardwiredMemberDescriptor
      {
        internal FLDV_8c9f6869a8b740ac8027119c07b06b56()
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

      private sealed class FLDV_4f0ef3656d1b4aa2b2c7af522bc9a83c : HardwiredMemberDescriptor
      {
        internal FLDV_4f0ef3656d1b4aa2b2c7af522bc9a83c()
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

      private sealed class FLDV_d0c49ded05ba47b791716ca86c1c9ca4 : HardwiredMemberDescriptor
      {
        internal FLDV_d0c49ded05ba47b791716ca86c1c9ca4()
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

      private sealed class FLDV_ea26edef554e4de78e642dc3be348a41 : HardwiredMemberDescriptor
      {
        internal FLDV_ea26edef554e4de78e642dc3be348a41()
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

      private sealed class FLDV_e5a6ef400d35448a95a8eae469baca91 : HardwiredMemberDescriptor
      {
        internal FLDV_e5a6ef400d35448a95a8eae469baca91()
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

      private sealed class FLDV_0abd512ddd4d4066ae8e95eb0b259694 : HardwiredMemberDescriptor
      {
        internal FLDV_0abd512ddd4d4066ae8e95eb0b259694()
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

      private sealed class FLDV_c85895acda2c4bf69651f056d48adf73 : HardwiredMemberDescriptor
      {
        internal FLDV_c85895acda2c4bf69651f056d48adf73()
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

      private sealed class FLDV_70a9abf1ebaa45fc8020e51a045c13e2 : HardwiredMemberDescriptor
      {
        internal FLDV_70a9abf1ebaa45fc8020e51a045c13e2()
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

      private sealed class FLDV_f94d8b3655dd4af8a945d167a44092b5 : HardwiredMemberDescriptor
      {
        internal FLDV_f94d8b3655dd4af8a945d167a44092b5()
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

      private sealed class FLDV_0a16c9c5c9f84321a878cab46126242e : HardwiredMemberDescriptor
      {
        internal FLDV_0a16c9c5c9f84321a878cab46126242e()
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

      private sealed class FLDV_f004c8ad505d4120b363d79418a2e434 : HardwiredMemberDescriptor
      {
        internal FLDV_f004c8ad505d4120b363d79418a2e434()
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

      private sealed class FLDV_bef3839726cf4c2f8ae5b1120dd6c925 : HardwiredMemberDescriptor
      {
        internal FLDV_bef3839726cf4c2f8ae5b1120dd6c925()
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

    private sealed class TYPE_08ae1aa44a624a5d96ce45e0ab58de17 : HardwiredUserDataDescriptor
    {
      internal TYPE_08ae1aa44a624a5d96ce45e0ab58de17()
        : base(typeof (UIElement))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_12c60877f41c4a8e97cfb57261ecd8a6()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_30646cfd88af4e57a44e1837c0a5b974()
        }));
        this.AddMember("get_visible", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_visible", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_084c0ad0fcf34cff948859843699db30()
        }));
        this.AddMember("set_visible", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_visible", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_344ea92cf20c41f5bac5783d1b793593()
        }));
        this.AddMember("get_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_269b0f9bb1774e23b59891260becc72d()
        }));
        this.AddMember("set_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_d2e8c04b547047a9bb82ad7cd90f3a5e()
        }));
        this.AddMember("get_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_bf2bdb6f94ad450b937b2e376e1b1a34()
        }));
        this.AddMember("set_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_c288c1e49b344060a2eb11a01413f81f()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_8067d9ef96424452be6daf4aed39bf4c()
        }));
        this.AddMember("set_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_09507588ba2d42ab8dff2e30fd5e2af5()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_bee2246d2c4d4b3eb083aea1b6a333c0()
        }));
        this.AddMember("set_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_3b8b2c604efe4205aef6214ddcd5d981()
        }));
        this.AddMember("get_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_81a1437bdb8d4af7894385e0144f96b9()
        }));
        this.AddMember("set_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_06539ca96c7d426aae4fa3276eab98eb()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_e9da84f40fc446cba25b2686a3a059b3()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_af99cd8781c7406db0d4a7fefa9ccc5e()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_ecda1b4cd2434df8a69350f19754ae0e()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_17bdb99dbda34c66a4d1fccbec22d7f5()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_beee8cc0f74d4dc9a130409562a6ca30()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_a59b55da7d0e4da4a6810b9f49c0f880()
        }));
        this.AddMember("get_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_f2ef82df1bec4283b71381b44703470e()
        }));
        this.AddMember("set_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_02b63953bce44afba00d1a7576f9bc20()
        }));
        this.AddMember("get_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_42070295bf7d48598d29ca880184ed8e()
        }));
        this.AddMember("set_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_ec3cc917e15148aa9c785c7ad09cb01d()
        }));
        this.AddMember("get_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_69e9adc789e7401686dc1c20391ce442()
        }));
        this.AddMember("set_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_24631df186814260b25d7d78e5438e32()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_1a5b43193afb496691a12089589f9508()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_5b34359b38a24275a8d6eb562ca43882()
        }));
        this.AddMember("get_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_5cf5b75709b747c8b55d76948de6cc3a()
        }));
        this.AddMember("set_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_f2912566ed124aefa1b6e01ad7bd3aac()
        }));
        this.AddMember("get_onClick2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_c5e75bd0cc0d4800b9394dc06c9c12b2()
        }));
        this.AddMember("set_onClick2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_9b49beafcf6843cc8e6d3e6883643a83()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_ba0b871721c74d01ba9c793c385a4f14()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_f0a9b4df3c894d59827258161aa3e13b()
        }));
        this.AddMember("get_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_35bd0628eeb5468a8c2dc8a1458fcad4()
        }));
        this.AddMember("set_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_5ce4fea88b3b42a9887ae7874292d106()
        }));
        this.AddMember("get_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_b7808034af7749a88f829b0f3a30ece4()
        }));
        this.AddMember("set_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_d87fa8716d0a4809b4cdcda8c78fa093()
        }));
        this.AddMember("get_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_2c4903ae8ec546e39472099841605933()
        }));
        this.AddMember("set_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_74c2ad689bb54e9c95c3615f0bdad33b()
        }));
        this.AddMember("get_textColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_db1feab0ead143768dfd31f9d962dd48()
        }));
        this.AddMember("set_textColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_15428c65b56b4427940e8764e67474ad()
        }));
        this.AddMember("get_highlightColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_highlightColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_e8cac91e11d7480399141100fa90baad()
        }));
        this.AddMember("set_highlightColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_highlightColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_01352ee0013b4b6a8fe44db66e69a47c()
        }));
        this.AddMember("get_highlightColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_highlightColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_e06b5370ff1840d9b34a412a4b16ebd5()
        }));
        this.AddMember("set_highlightColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_highlightColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_7465fc1f8a4d40088d85abe1e84b9784()
        }));
        this.AddMember("get_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_5955540050c14b0d9efd38d829257029()
        }));
        this.AddMember("set_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_26484ad7439e4f37bb33f9acb63e087b()
        }));
        this.AddMember("get_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_71301bb6565a4edda377a1a90df5dd40()
        }));
        this.AddMember("set_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_46619cac0cc5422fb247e12d737bf328()
        }));
        this.AddMember("activateInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("activateInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_50ae660cb68f453e95c1adf33507ca3d()
        }));
        this.AddMember("createUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createUI", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_140c13888a7744f88fd8655fea4fc280()
        }));
        this.AddMember("createInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_930ed2ab8a3e4b13b6aec34c162e6d1f()
        }));
        this.AddMember("duplicate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("duplicate", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_39ef7d6025184bf9931cf1c6324c15ca()
        }));
        this.AddMember("destroyHierarchy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroyHierarchy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_021bc8488bfb48f392cf5029268264c8()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_85796fe7ac9c4a708c849883fc499118()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_6e01f6a80b0d4a45af983371dca7f81a()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_2ca968f935b2478888f41277ac7d52d2()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_ff58560642184f8087fd6c1c4a003caa()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.MTHD_d421c208f32a477d80ca279ba3449089()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.PROP_a6b901e6bafa4b46b4f9eff4800b4814());
        this.AddMember("visible", (IMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.PROP_a5bf8ea73bd2473a9fce2c8151e826d2());
        this.AddMember("graphic", (IMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.PROP_779595b2670b443791807836345d3f34());
        this.AddMember("anchor", (IMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.PROP_e21cbd669fdc4a6c96bf33304cfb7232());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.PROP_406bd32e18ea49b094e3b6f9f28b6f73());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.PROP_8cbacfd2938c4569ab2cfb8eb8545578());
        this.AddMember("size", (IMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.PROP_9127466158d54bd2b43f55f373b29ed6());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.PROP_b794512997684f12ac7930d696ed8ef0());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.PROP_2de4e0a1278a4d609e2a8b81adfe691d());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.PROP_a99d1a806dbb4c46af0bc7169f167ad3());
        this.AddMember("pivot_x", (IMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.PROP_f3bb4ce8595147f68a059dc9202c1708());
        this.AddMember("pivot_y", (IMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.PROP_c017eed580d64be2898e11449b80b348());
        this.AddMember("pivot", (IMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.PROP_94b4db6635cb475e9b9accf19b0f5462());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.PROP_a5592844b4ba4c08bb63fe0990c8ce8a());
        this.AddMember("onClick", (IMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.PROP_2383a50f49504e59829a2be7bf0a837a());
        this.AddMember("onClick2", (IMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.PROP_8b4a35b483784149ae27afdec515e4bc());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.PROP_410b4c16ab7e40958fa1aa3f8cb33b25());
        this.AddMember("color2", (IMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.PROP_562d7a6c8c224d86a634630609656186());
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.PROP_3c0a9fab04294434b729d3c3def238bf());
        this.AddMember("textColor", (IMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.PROP_330a08f723eb4b87bb799ebc48b7e91d());
        this.AddMember("textColor2", (IMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.PROP_99bd8bea15bc42609e3aa565dd7b1279());
        this.AddMember("highlightColor", (IMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.PROP_664dd7d6554b406488353bff2553e0f7());
        this.AddMember("highlightColor2", (IMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.PROP_6fed7773d18347848d3e0e3bd649536f());
        this.AddMember("textStyle", (IMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.PROP_0ebb33b06a0a4c39b831d744dffda60c());
        this.AddMember("textSize", (IMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.PROP_7c900540a2d44af39d8da11cc1d9a277());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.FLDV_7ea21d4ee0af4a9989b1ab9a1ef6dd03());
        this.AddMember("clickID", (IMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.FLDV_7a2944511c7d4dba9da2a3761d628cc5());
        this.AddMember("clickDestroy", (IMemberDescriptor) new Bridge.TYPE_08ae1aa44a624a5d96ce45e0ab58de17.FLDV_fa6c02b143964d90abf0c230113f3aef());
      }

      private sealed class MTHD_12c60877f41c4a8e97cfb57261ecd8a6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_12c60877f41c4a8e97cfb57261ecd8a6()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new UIElement();
        }
      }

      private sealed class MTHD_30646cfd88af4e57a44e1837c0a5b974 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_30646cfd88af4e57a44e1837c0a5b974()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class MTHD_084c0ad0fcf34cff948859843699db30 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_084c0ad0fcf34cff948859843699db30()
        {
          this.Initialize("get_visible", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).visible;
        }
      }

      private sealed class MTHD_344ea92cf20c41f5bac5783d1b793593 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_344ea92cf20c41f5bac5783d1b793593()
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

      private sealed class MTHD_269b0f9bb1774e23b59891260becc72d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_269b0f9bb1774e23b59891260becc72d()
        {
          this.Initialize("get_graphic", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return ((UIElement) obj).graphic;
        }
      }

      private sealed class MTHD_d2e8c04b547047a9bb82ad7cd90f3a5e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d2e8c04b547047a9bb82ad7cd90f3a5e()
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

      private sealed class MTHD_bf2bdb6f94ad450b937b2e376e1b1a34 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bf2bdb6f94ad450b937b2e376e1b1a34()
        {
          this.Initialize("get_anchor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).anchor;
        }
      }

      private sealed class MTHD_c288c1e49b344060a2eb11a01413f81f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c288c1e49b344060a2eb11a01413f81f()
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

      private sealed class MTHD_8067d9ef96424452be6daf4aed39bf4c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8067d9ef96424452be6daf4aed39bf4c()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).width;
        }
      }

      private sealed class MTHD_09507588ba2d42ab8dff2e30fd5e2af5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_09507588ba2d42ab8dff2e30fd5e2af5()
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

      private sealed class MTHD_bee2246d2c4d4b3eb083aea1b6a333c0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bee2246d2c4d4b3eb083aea1b6a333c0()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).height;
        }
      }

      private sealed class MTHD_3b8b2c604efe4205aef6214ddcd5d981 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3b8b2c604efe4205aef6214ddcd5d981()
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

      private sealed class MTHD_81a1437bdb8d4af7894385e0144f96b9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_81a1437bdb8d4af7894385e0144f96b9()
        {
          this.Initialize("get_size", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).size;
        }
      }

      private sealed class MTHD_06539ca96c7d426aae4fa3276eab98eb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_06539ca96c7d426aae4fa3276eab98eb()
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

      private sealed class MTHD_e9da84f40fc446cba25b2686a3a059b3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e9da84f40fc446cba25b2686a3a059b3()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).x;
        }
      }

      private sealed class MTHD_af99cd8781c7406db0d4a7fefa9ccc5e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_af99cd8781c7406db0d4a7fefa9ccc5e()
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

      private sealed class MTHD_ecda1b4cd2434df8a69350f19754ae0e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ecda1b4cd2434df8a69350f19754ae0e()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).y;
        }
      }

      private sealed class MTHD_17bdb99dbda34c66a4d1fccbec22d7f5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_17bdb99dbda34c66a4d1fccbec22d7f5()
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

      private sealed class MTHD_beee8cc0f74d4dc9a130409562a6ca30 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_beee8cc0f74d4dc9a130409562a6ca30()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).position;
        }
      }

      private sealed class MTHD_a59b55da7d0e4da4a6810b9f49c0f880 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a59b55da7d0e4da4a6810b9f49c0f880()
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

      private sealed class MTHD_f2ef82df1bec4283b71381b44703470e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f2ef82df1bec4283b71381b44703470e()
        {
          this.Initialize("get_pivot_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_x;
        }
      }

      private sealed class MTHD_02b63953bce44afba00d1a7576f9bc20 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_02b63953bce44afba00d1a7576f9bc20()
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

      private sealed class MTHD_42070295bf7d48598d29ca880184ed8e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_42070295bf7d48598d29ca880184ed8e()
        {
          this.Initialize("get_pivot_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_y;
        }
      }

      private sealed class MTHD_ec3cc917e15148aa9c785c7ad09cb01d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ec3cc917e15148aa9c785c7ad09cb01d()
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

      private sealed class MTHD_69e9adc789e7401686dc1c20391ce442 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_69e9adc789e7401686dc1c20391ce442()
        {
          this.Initialize("get_pivot", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot;
        }
      }

      private sealed class MTHD_24631df186814260b25d7d78e5438e32 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_24631df186814260b25d7d78e5438e32()
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

      private sealed class MTHD_1a5b43193afb496691a12089589f9508 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1a5b43193afb496691a12089589f9508()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).angle;
        }
      }

      private sealed class MTHD_5b34359b38a24275a8d6eb562ca43882 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5b34359b38a24275a8d6eb562ca43882()
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

      private sealed class MTHD_5cf5b75709b747c8b55d76948de6cc3a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5cf5b75709b747c8b55d76948de6cc3a()
        {
          this.Initialize("get_onClick", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick;
        }
      }

      private sealed class MTHD_f2912566ed124aefa1b6e01ad7bd3aac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f2912566ed124aefa1b6e01ad7bd3aac()
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

      private sealed class MTHD_c5e75bd0cc0d4800b9394dc06c9c12b2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c5e75bd0cc0d4800b9394dc06c9c12b2()
        {
          this.Initialize("get_onClick2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick2;
        }
      }

      private sealed class MTHD_9b49beafcf6843cc8e6d3e6883643a83 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9b49beafcf6843cc8e6d3e6883643a83()
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

      private sealed class MTHD_ba0b871721c74d01ba9c793c385a4f14 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ba0b871721c74d01ba9c793c385a4f14()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color;
        }
      }

      private sealed class MTHD_f0a9b4df3c894d59827258161aa3e13b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f0a9b4df3c894d59827258161aa3e13b()
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

      private sealed class MTHD_35bd0628eeb5468a8c2dc8a1458fcad4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_35bd0628eeb5468a8c2dc8a1458fcad4()
        {
          this.Initialize("get_color2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color2;
        }
      }

      private sealed class MTHD_5ce4fea88b3b42a9887ae7874292d106 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5ce4fea88b3b42a9887ae7874292d106()
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

      private sealed class MTHD_b7808034af7749a88f829b0f3a30ece4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b7808034af7749a88f829b0f3a30ece4()
        {
          this.Initialize("get_text", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).text;
        }
      }

      private sealed class MTHD_d87fa8716d0a4809b4cdcda8c78fa093 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d87fa8716d0a4809b4cdcda8c78fa093()
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

      private sealed class MTHD_2c4903ae8ec546e39472099841605933 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2c4903ae8ec546e39472099841605933()
        {
          this.Initialize("get_textColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor;
        }
      }

      private sealed class MTHD_74c2ad689bb54e9c95c3615f0bdad33b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_74c2ad689bb54e9c95c3615f0bdad33b()
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

      private sealed class MTHD_db1feab0ead143768dfd31f9d962dd48 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_db1feab0ead143768dfd31f9d962dd48()
        {
          this.Initialize("get_textColor2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor2;
        }
      }

      private sealed class MTHD_15428c65b56b4427940e8764e67474ad : HardwiredMethodMemberDescriptor
      {
        internal MTHD_15428c65b56b4427940e8764e67474ad()
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

      private sealed class MTHD_e8cac91e11d7480399141100fa90baad : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e8cac91e11d7480399141100fa90baad()
        {
          this.Initialize("get_highlightColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).highlightColor;
        }
      }

      private sealed class MTHD_01352ee0013b4b6a8fe44db66e69a47c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_01352ee0013b4b6a8fe44db66e69a47c()
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

      private sealed class MTHD_e06b5370ff1840d9b34a412a4b16ebd5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e06b5370ff1840d9b34a412a4b16ebd5()
        {
          this.Initialize("get_highlightColor2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).highlightColor2;
        }
      }

      private sealed class MTHD_7465fc1f8a4d40088d85abe1e84b9784 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7465fc1f8a4d40088d85abe1e84b9784()
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

      private sealed class MTHD_5955540050c14b0d9efd38d829257029 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5955540050c14b0d9efd38d829257029()
        {
          this.Initialize("get_textStyle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textStyle;
        }
      }

      private sealed class MTHD_26484ad7439e4f37bb33f9acb63e087b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_26484ad7439e4f37bb33f9acb63e087b()
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

      private sealed class MTHD_71301bb6565a4edda377a1a90df5dd40 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_71301bb6565a4edda377a1a90df5dd40()
        {
          this.Initialize("get_textSize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textSize;
        }
      }

      private sealed class MTHD_46619cac0cc5422fb247e12d737bf328 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_46619cac0cc5422fb247e12d737bf328()
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

      private sealed class MTHD_50ae660cb68f453e95c1adf33507ca3d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_50ae660cb68f453e95c1adf33507ca3d()
        {
          this.Initialize("activateInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).activateInput();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_140c13888a7744f88fd8655fea4fc280 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_140c13888a7744f88fd8655fea4fc280()
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

      private sealed class MTHD_930ed2ab8a3e4b13b6aec34c162e6d1f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_930ed2ab8a3e4b13b6aec34c162e6d1f()
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

      private sealed class MTHD_39ef7d6025184bf9931cf1c6324c15ca : HardwiredMethodMemberDescriptor
      {
        internal MTHD_39ef7d6025184bf9931cf1c6324c15ca()
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

      private sealed class MTHD_021bc8488bfb48f392cf5029268264c8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_021bc8488bfb48f392cf5029268264c8()
        {
          this.Initialize("destroyHierarchy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroyHierarchy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_85796fe7ac9c4a708c849883fc499118 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_85796fe7ac9c4a708c849883fc499118()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_6e01f6a80b0d4a45af983371dca7f81a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6e01f6a80b0d4a45af983371dca7f81a()
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

      private sealed class MTHD_2ca968f935b2478888f41277ac7d52d2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2ca968f935b2478888f41277ac7d52d2()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_ff58560642184f8087fd6c1c4a003caa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ff58560642184f8087fd6c1c4a003caa()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_d421c208f32a477d80ca279ba3449089 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d421c208f32a477d80ca279ba3449089()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_a6b901e6bafa4b46b4f9eff4800b4814 : HardwiredMemberDescriptor
      {
        internal PROP_a6b901e6bafa4b46b4f9eff4800b4814()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class PROP_a5bf8ea73bd2473a9fce2c8151e826d2 : HardwiredMemberDescriptor
      {
        internal PROP_a5bf8ea73bd2473a9fce2c8151e826d2()
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

      private sealed class PROP_779595b2670b443791807836345d3f34 : HardwiredMemberDescriptor
      {
        internal PROP_779595b2670b443791807836345d3f34()
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

      private sealed class PROP_e21cbd669fdc4a6c96bf33304cfb7232 : HardwiredMemberDescriptor
      {
        internal PROP_e21cbd669fdc4a6c96bf33304cfb7232()
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

      private sealed class PROP_406bd32e18ea49b094e3b6f9f28b6f73 : HardwiredMemberDescriptor
      {
        internal PROP_406bd32e18ea49b094e3b6f9f28b6f73()
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

      private sealed class PROP_8cbacfd2938c4569ab2cfb8eb8545578 : HardwiredMemberDescriptor
      {
        internal PROP_8cbacfd2938c4569ab2cfb8eb8545578()
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

      private sealed class PROP_9127466158d54bd2b43f55f373b29ed6 : HardwiredMemberDescriptor
      {
        internal PROP_9127466158d54bd2b43f55f373b29ed6()
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

      private sealed class PROP_b794512997684f12ac7930d696ed8ef0 : HardwiredMemberDescriptor
      {
        internal PROP_b794512997684f12ac7930d696ed8ef0()
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

      private sealed class PROP_2de4e0a1278a4d609e2a8b81adfe691d : HardwiredMemberDescriptor
      {
        internal PROP_2de4e0a1278a4d609e2a8b81adfe691d()
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

      private sealed class PROP_a99d1a806dbb4c46af0bc7169f167ad3 : HardwiredMemberDescriptor
      {
        internal PROP_a99d1a806dbb4c46af0bc7169f167ad3()
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

      private sealed class PROP_f3bb4ce8595147f68a059dc9202c1708 : HardwiredMemberDescriptor
      {
        internal PROP_f3bb4ce8595147f68a059dc9202c1708()
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

      private sealed class PROP_c017eed580d64be2898e11449b80b348 : HardwiredMemberDescriptor
      {
        internal PROP_c017eed580d64be2898e11449b80b348()
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

      private sealed class PROP_94b4db6635cb475e9b9accf19b0f5462 : HardwiredMemberDescriptor
      {
        internal PROP_94b4db6635cb475e9b9accf19b0f5462()
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

      private sealed class PROP_a5592844b4ba4c08bb63fe0990c8ce8a : HardwiredMemberDescriptor
      {
        internal PROP_a5592844b4ba4c08bb63fe0990c8ce8a()
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

      private sealed class PROP_2383a50f49504e59829a2be7bf0a837a : HardwiredMemberDescriptor
      {
        internal PROP_2383a50f49504e59829a2be7bf0a837a()
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

      private sealed class PROP_8b4a35b483784149ae27afdec515e4bc : HardwiredMemberDescriptor
      {
        internal PROP_8b4a35b483784149ae27afdec515e4bc()
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

      private sealed class PROP_410b4c16ab7e40958fa1aa3f8cb33b25 : HardwiredMemberDescriptor
      {
        internal PROP_410b4c16ab7e40958fa1aa3f8cb33b25()
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

      private sealed class PROP_562d7a6c8c224d86a634630609656186 : HardwiredMemberDescriptor
      {
        internal PROP_562d7a6c8c224d86a634630609656186()
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

      private sealed class PROP_3c0a9fab04294434b729d3c3def238bf : HardwiredMemberDescriptor
      {
        internal PROP_3c0a9fab04294434b729d3c3def238bf()
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

      private sealed class PROP_330a08f723eb4b87bb799ebc48b7e91d : HardwiredMemberDescriptor
      {
        internal PROP_330a08f723eb4b87bb799ebc48b7e91d()
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

      private sealed class PROP_99bd8bea15bc42609e3aa565dd7b1279 : HardwiredMemberDescriptor
      {
        internal PROP_99bd8bea15bc42609e3aa565dd7b1279()
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

      private sealed class PROP_664dd7d6554b406488353bff2553e0f7 : HardwiredMemberDescriptor
      {
        internal PROP_664dd7d6554b406488353bff2553e0f7()
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

      private sealed class PROP_6fed7773d18347848d3e0e3bd649536f : HardwiredMemberDescriptor
      {
        internal PROP_6fed7773d18347848d3e0e3bd649536f()
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

      private sealed class PROP_0ebb33b06a0a4c39b831d744dffda60c : HardwiredMemberDescriptor
      {
        internal PROP_0ebb33b06a0a4c39b831d744dffda60c()
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

      private sealed class PROP_7c900540a2d44af39d8da11cc1d9a277 : HardwiredMemberDescriptor
      {
        internal PROP_7c900540a2d44af39d8da11cc1d9a277()
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

      private sealed class FLDV_7ea21d4ee0af4a9989b1ab9a1ef6dd03 : HardwiredMemberDescriptor
      {
        internal FLDV_7ea21d4ee0af4a9989b1ab9a1ef6dd03()
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

      private sealed class FLDV_7a2944511c7d4dba9da2a3761d628cc5 : HardwiredMemberDescriptor
      {
        internal FLDV_7a2944511c7d4dba9da2a3761d628cc5()
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

      private sealed class FLDV_fa6c02b143964d90abf0c230113f3aef : HardwiredMemberDescriptor
      {
        internal FLDV_fa6c02b143964d90abf0c230113f3aef()
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

    private sealed class TYPE_2f03151ef2bb45d4a7eee688bc4a8158 : HardwiredUserDataDescriptor
    {
      internal TYPE_2f03151ef2bb45d4a7eee688bc4a8158()
        : base(typeof (MyPoll.Item))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2f03151ef2bb45d4a7eee688bc4a8158.MTHD_2bcd7a525373490dbb09b689fe394b1a()
        }));
        this.AddMember("addAnswer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addAnswer", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2f03151ef2bb45d4a7eee688bc4a8158.MTHD_ca5beb0d44c94b17be7bf28ec0ed24ff()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2f03151ef2bb45d4a7eee688bc4a8158.MTHD_3021c71beab347be9a89b39076c4507f()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2f03151ef2bb45d4a7eee688bc4a8158.MTHD_4b445b49c9fb4a3083ef20b74fe730e1()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2f03151ef2bb45d4a7eee688bc4a8158.MTHD_50c6ca42fda645a5bdb10822ced645b6()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2f03151ef2bb45d4a7eee688bc4a8158.MTHD_404b7121fff54d129e8f9b458dcdc4f5()
        }));
        this.AddMember("question", (IMemberDescriptor) new Bridge.TYPE_2f03151ef2bb45d4a7eee688bc4a8158.FLDV_28c435c5654d41f2857db4f2145f9f7f());
        this.AddMember("multipleSelection", (IMemberDescriptor) new Bridge.TYPE_2f03151ef2bb45d4a7eee688bc4a8158.FLDV_0489873c81a947809d8049a40c517f16());
        this.AddMember("requiresAnswer", (IMemberDescriptor) new Bridge.TYPE_2f03151ef2bb45d4a7eee688bc4a8158.FLDV_23e7258636a641c38503cc3916f0c95a());
        this.AddMember("answers", (IMemberDescriptor) new Bridge.TYPE_2f03151ef2bb45d4a7eee688bc4a8158.FLDV_ef2bf6eedbed47c2b7ab6f2d95946b03());
      }

      private sealed class MTHD_2bcd7a525373490dbb09b689fe394b1a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2bcd7a525373490dbb09b689fe394b1a()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Item();
        }
      }

      private sealed class MTHD_ca5beb0d44c94b17be7bf28ec0ed24ff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ca5beb0d44c94b17be7bf28ec0ed24ff()
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

      private sealed class MTHD_3021c71beab347be9a89b39076c4507f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3021c71beab347be9a89b39076c4507f()
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

      private sealed class MTHD_4b445b49c9fb4a3083ef20b74fe730e1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4b445b49c9fb4a3083ef20b74fe730e1()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_50c6ca42fda645a5bdb10822ced645b6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_50c6ca42fda645a5bdb10822ced645b6()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_404b7121fff54d129e8f9b458dcdc4f5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_404b7121fff54d129e8f9b458dcdc4f5()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_28c435c5654d41f2857db4f2145f9f7f : HardwiredMemberDescriptor
      {
        internal FLDV_28c435c5654d41f2857db4f2145f9f7f()
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

      private sealed class FLDV_0489873c81a947809d8049a40c517f16 : HardwiredMemberDescriptor
      {
        internal FLDV_0489873c81a947809d8049a40c517f16()
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

      private sealed class FLDV_23e7258636a641c38503cc3916f0c95a : HardwiredMemberDescriptor
      {
        internal FLDV_23e7258636a641c38503cc3916f0c95a()
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

      private sealed class FLDV_ef2bf6eedbed47c2b7ab6f2d95946b03 : HardwiredMemberDescriptor
      {
        internal FLDV_ef2bf6eedbed47c2b7ab6f2d95946b03()
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

    private sealed class TYPE_369a5f136f05447887db257d476cf0be : HardwiredUserDataDescriptor
    {
      internal TYPE_369a5f136f05447887db257d476cf0be()
        : base(typeof (MyPoll.Answer))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_369a5f136f05447887db257d476cf0be.MTHD_4731c290fceb44428e8b3750ad094c17()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_369a5f136f05447887db257d476cf0be.MTHD_747eb2d20bad41cbaab9e040680047a7()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_369a5f136f05447887db257d476cf0be.MTHD_613676cd52fc4900ac91edb55841e254()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_369a5f136f05447887db257d476cf0be.MTHD_1ba64ee31c8c401695fa6b42bc51b598()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_369a5f136f05447887db257d476cf0be.MTHD_06e6dceb30fe4212956e1ff39c78faf5()
        }));
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_369a5f136f05447887db257d476cf0be.FLDV_0bc5c042edbf49168d2a86beb3398f8b());
        this.AddMember("allowUserInput", (IMemberDescriptor) new Bridge.TYPE_369a5f136f05447887db257d476cf0be.FLDV_c764b39745074a6783fb0de4ea8f57b5());
        this.AddMember("checkable", (IMemberDescriptor) new Bridge.TYPE_369a5f136f05447887db257d476cf0be.FLDV_675acc26bd204da2a3b6fd72f0ab3871());
        this.AddMember("userInput", (IMemberDescriptor) new Bridge.TYPE_369a5f136f05447887db257d476cf0be.FLDV_354df6103ff04abaa8e176e91b15292f());
        this.AddMember("isChecked", (IMemberDescriptor) new Bridge.TYPE_369a5f136f05447887db257d476cf0be.FLDV_028aa065f1d94fe8bfa8e6f6ec0ac9d9());
      }

      private sealed class MTHD_4731c290fceb44428e8b3750ad094c17 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4731c290fceb44428e8b3750ad094c17()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Answer();
        }
      }

      private sealed class MTHD_747eb2d20bad41cbaab9e040680047a7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_747eb2d20bad41cbaab9e040680047a7()
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

      private sealed class MTHD_613676cd52fc4900ac91edb55841e254 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_613676cd52fc4900ac91edb55841e254()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_1ba64ee31c8c401695fa6b42bc51b598 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1ba64ee31c8c401695fa6b42bc51b598()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_06e6dceb30fe4212956e1ff39c78faf5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_06e6dceb30fe4212956e1ff39c78faf5()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_0bc5c042edbf49168d2a86beb3398f8b : HardwiredMemberDescriptor
      {
        internal FLDV_0bc5c042edbf49168d2a86beb3398f8b()
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

      private sealed class FLDV_c764b39745074a6783fb0de4ea8f57b5 : HardwiredMemberDescriptor
      {
        internal FLDV_c764b39745074a6783fb0de4ea8f57b5()
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

      private sealed class FLDV_675acc26bd204da2a3b6fd72f0ab3871 : HardwiredMemberDescriptor
      {
        internal FLDV_675acc26bd204da2a3b6fd72f0ab3871()
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

      private sealed class FLDV_354df6103ff04abaa8e176e91b15292f : HardwiredMemberDescriptor
      {
        internal FLDV_354df6103ff04abaa8e176e91b15292f()
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

      private sealed class FLDV_028aa065f1d94fe8bfa8e6f6ec0ac9d9 : HardwiredMemberDescriptor
      {
        internal FLDV_028aa065f1d94fe8bfa8e6f6ec0ac9d9()
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

    private sealed class TYPE_38a48c32d6de49cab91487eb12df019a : HardwiredUserDataDescriptor
    {
      internal TYPE_38a48c32d6de49cab91487eb12df019a()
        : base(typeof (MyPoll))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_38a48c32d6de49cab91487eb12df019a.MTHD_60ba3952fe2e4722b2af86d118de641e()
        }));
        this.AddMember("GetQuestionsAsString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetQuestionsAsString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_38a48c32d6de49cab91487eb12df019a.MTHD_3712812b8e3645f48f7d32cbd03bb75f()
        }));
        this.AddMember("SanitizeResponses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("SanitizeResponses", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_38a48c32d6de49cab91487eb12df019a.MTHD_802c9aa857834ccd89fc072caecea185()
        }));
        this.AddMember("addItem", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addItem", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_38a48c32d6de49cab91487eb12df019a.MTHD_197be84405ae4457b6890d4d794867f1()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_38a48c32d6de49cab91487eb12df019a.MTHD_62ef5d59b62a45f1a3ca4b9307d0673b()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_38a48c32d6de49cab91487eb12df019a.MTHD_339a2a81a74e431484b752c8e9824be0()
        }));
        this.AddMember("fromString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fromString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_38a48c32d6de49cab91487eb12df019a.MTHD_0df83870ce324f48ac82e75a74c02791()
        }));
        this.AddMember("sendToServer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("sendToServer", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_38a48c32d6de49cab91487eb12df019a.MTHD_79e95a6775724f5793dc2bd0b2ed8cb5()
        }));
        this.AddMember("closePoll", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("closePoll", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_38a48c32d6de49cab91487eb12df019a.MTHD_89c07ad98fcb4779bba0081c04e2fef4()
        }));
        this.AddMember("test", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("test", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_38a48c32d6de49cab91487eb12df019a.MTHD_5f55d2d5c51947569b281e4e309a281f()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_38a48c32d6de49cab91487eb12df019a.MTHD_70174729d6444af28b084d43951c8ce4()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_38a48c32d6de49cab91487eb12df019a.MTHD_4803d0f264f3480aa95a103f8cb796d2()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_38a48c32d6de49cab91487eb12df019a.MTHD_10d250d49cd547d684008f0946b54be5()
        }));
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_38a48c32d6de49cab91487eb12df019a.FLDV_af1d2c8f752e45e4b7b642277b21fe14());
        this.AddMember("id", (IMemberDescriptor) new Bridge.TYPE_38a48c32d6de49cab91487eb12df019a.FLDV_bdcd3e117e794e908b56c237a1962c5f());
        this.AddMember("items", (IMemberDescriptor) new Bridge.TYPE_38a48c32d6de49cab91487eb12df019a.FLDV_4f4f8ed4d6bf4ccca0c3d1fd2d2e839f());
        this.AddMember("isPublic", (IMemberDescriptor) new Bridge.TYPE_38a48c32d6de49cab91487eb12df019a.FLDV_ea00cd6876984a5ca43ec7b762189d31());
        this.AddMember("MsgRetrieve", (IMemberDescriptor) new Bridge.TYPE_38a48c32d6de49cab91487eb12df019a.FLDV_bf0159b14e844a52ab5db68ad5990b72());
        this.AddMember("MsgSubmit", (IMemberDescriptor) new Bridge.TYPE_38a48c32d6de49cab91487eb12df019a.FLDV_a5ac1237c8a14b98926cf41b2421ef9a());
        this.AddMember("MsgCreate", (IMemberDescriptor) new Bridge.TYPE_38a48c32d6de49cab91487eb12df019a.FLDV_df4bccd1362942f3a0e45958ec21864b());
        this.AddMember("MsgResults", (IMemberDescriptor) new Bridge.TYPE_38a48c32d6de49cab91487eb12df019a.FLDV_961c41f0a6974dd0a3f8b2a7b82304eb());
        this.AddMember("Item", (IMemberDescriptor) new Bridge.TYPE_38a48c32d6de49cab91487eb12df019a.DVAL_5a2cc2603abf4489adec4d26ffcb53e0());
        this.AddMember("Answer", (IMemberDescriptor) new Bridge.TYPE_38a48c32d6de49cab91487eb12df019a.DVAL_6b110fc2e924418b80de493d79ca594d());
      }

      private sealed class MTHD_60ba3952fe2e4722b2af86d118de641e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_60ba3952fe2e4722b2af86d118de641e()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll();
        }
      }

      private sealed class MTHD_3712812b8e3645f48f7d32cbd03bb75f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3712812b8e3645f48f7d32cbd03bb75f()
        {
          this.Initialize("GetQuestionsAsString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).GetQuestionsAsString();
        }
      }

      private sealed class MTHD_802c9aa857834ccd89fc072caecea185 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_802c9aa857834ccd89fc072caecea185()
        {
          this.Initialize("SanitizeResponses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).SanitizeResponses();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_197be84405ae4457b6890d4d794867f1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_197be84405ae4457b6890d4d794867f1()
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

      private sealed class MTHD_62ef5d59b62a45f1a3ca4b9307d0673b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_62ef5d59b62a45f1a3ca4b9307d0673b()
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

      private sealed class MTHD_339a2a81a74e431484b752c8e9824be0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_339a2a81a74e431484b752c8e9824be0()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).ToString();
        }
      }

      private sealed class MTHD_0df83870ce324f48ac82e75a74c02791 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0df83870ce324f48ac82e75a74c02791()
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

      private sealed class MTHD_79e95a6775724f5793dc2bd0b2ed8cb5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_79e95a6775724f5793dc2bd0b2ed8cb5()
        {
          this.Initialize("sendToServer", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).sendToServer();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_89c07ad98fcb4779bba0081c04e2fef4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_89c07ad98fcb4779bba0081c04e2fef4()
        {
          this.Initialize("closePoll", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          MyPoll.closePoll();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_5f55d2d5c51947569b281e4e309a281f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5f55d2d5c51947569b281e4e309a281f()
        {
          this.Initialize("test", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).test();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_70174729d6444af28b084d43951c8ce4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_70174729d6444af28b084d43951c8ce4()
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

      private sealed class MTHD_4803d0f264f3480aa95a103f8cb796d2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4803d0f264f3480aa95a103f8cb796d2()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_10d250d49cd547d684008f0946b54be5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_10d250d49cd547d684008f0946b54be5()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_af1d2c8f752e45e4b7b642277b21fe14 : HardwiredMemberDescriptor
      {
        internal FLDV_af1d2c8f752e45e4b7b642277b21fe14()
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

      private sealed class FLDV_bdcd3e117e794e908b56c237a1962c5f : HardwiredMemberDescriptor
      {
        internal FLDV_bdcd3e117e794e908b56c237a1962c5f()
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

      private sealed class FLDV_4f4f8ed4d6bf4ccca0c3d1fd2d2e839f : HardwiredMemberDescriptor
      {
        internal FLDV_4f4f8ed4d6bf4ccca0c3d1fd2d2e839f()
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

      private sealed class FLDV_ea00cd6876984a5ca43ec7b762189d31 : HardwiredMemberDescriptor
      {
        internal FLDV_ea00cd6876984a5ca43ec7b762189d31()
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

      private sealed class FLDV_bf0159b14e844a52ab5db68ad5990b72 : HardwiredMemberDescriptor
      {
        internal FLDV_bf0159b14e844a52ab5db68ad5990b72()
          : base(typeof (byte), "MsgRetrieve", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 1;
        }
      }

      private sealed class FLDV_a5ac1237c8a14b98926cf41b2421ef9a : HardwiredMemberDescriptor
      {
        internal FLDV_a5ac1237c8a14b98926cf41b2421ef9a()
          : base(typeof (byte), "MsgSubmit", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 2;
        }
      }

      private sealed class FLDV_df4bccd1362942f3a0e45958ec21864b : HardwiredMemberDescriptor
      {
        internal FLDV_df4bccd1362942f3a0e45958ec21864b()
          : base(typeof (byte), "MsgCreate", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 3;
        }
      }

      private sealed class FLDV_961c41f0a6974dd0a3f8b2a7b82304eb : HardwiredMemberDescriptor
      {
        internal FLDV_961c41f0a6974dd0a3f8b2a7b82304eb()
          : base(typeof (byte), "MsgResults", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 4;
        }
      }

      private sealed class DVAL_5a2cc2603abf4489adec4d26ffcb53e0 : DynValueMemberDescriptor
      {
        internal DVAL_5a2cc2603abf4489adec4d26ffcb53e0()
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

      private sealed class DVAL_6b110fc2e924418b80de493d79ca594d : DynValueMemberDescriptor
      {
        internal DVAL_6b110fc2e924418b80de493d79ca594d()
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

    private sealed class TYPE_6461a4288d1a4ff8b39cc68b978df6f8 : HardwiredUserDataDescriptor
    {
      internal TYPE_6461a4288d1a4ff8b39cc68b978df6f8()
        : base(typeof (LuaColor))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6461a4288d1a4ff8b39cc68b978df6f8.MTHD_ab8b13a5b8964fc8b42db54e72668f67()
        }));
        this.AddMember("toHex", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("toHex", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6461a4288d1a4ff8b39cc68b978df6f8.MTHD_df6619aec44843c2a4b7cfc95401442f()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6461a4288d1a4ff8b39cc68b978df6f8.MTHD_422ed017d0a74f38b8e696980f4866dc(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6461a4288d1a4ff8b39cc68b978df6f8.MTHD_9be236b1a2574d8cbc8947cafdeafcb0()
        }));
        this.AddMember("From", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("From", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6461a4288d1a4ff8b39cc68b978df6f8.MTHD_c1b8fa7611294bbfb778ed033c854635(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6461a4288d1a4ff8b39cc68b978df6f8.MTHD_3e610196decb40b585bdb042d067110d()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6461a4288d1a4ff8b39cc68b978df6f8.MTHD_fdc63697cb68489c911a73ba145d3633()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6461a4288d1a4ff8b39cc68b978df6f8.MTHD_925aea77f27e45c6a64e78cade0dc5fc()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6461a4288d1a4ff8b39cc68b978df6f8.MTHD_5b027c959c1b4118b90dc96e27d5fa20()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6461a4288d1a4ff8b39cc68b978df6f8.MTHD_234ce9b48a054d98a308e21657ad7b49()
        }));
        this.AddMember("r", (IMemberDescriptor) new Bridge.TYPE_6461a4288d1a4ff8b39cc68b978df6f8.FLDV_6e3beb4c7096480db9f5b6d2dc9eabc2());
        this.AddMember("g", (IMemberDescriptor) new Bridge.TYPE_6461a4288d1a4ff8b39cc68b978df6f8.FLDV_01e9e923d9dc4915b18b29f63a394b2e());
        this.AddMember("b", (IMemberDescriptor) new Bridge.TYPE_6461a4288d1a4ff8b39cc68b978df6f8.FLDV_4f27951a26b64ca780c2bbe170c7a91e());
        this.AddMember("a", (IMemberDescriptor) new Bridge.TYPE_6461a4288d1a4ff8b39cc68b978df6f8.FLDV_d77a1d418a3f4c2d8f8be3d47ff54864());
        this.AddMember("white", (IMemberDescriptor) new Bridge.TYPE_6461a4288d1a4ff8b39cc68b978df6f8.FLDV_e244731347264f098ccfe408ba48fd3d());
      }

      private sealed class MTHD_ab8b13a5b8964fc8b42db54e72668f67 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ab8b13a5b8964fc8b42db54e72668f67()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new LuaColor();
        }
      }

      private sealed class MTHD_df6619aec44843c2a4b7cfc95401442f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_df6619aec44843c2a4b7cfc95401442f()
        {
          this.Initialize("toHex", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((LuaColor) obj).toHex();
        }
      }

      private sealed class MTHD_422ed017d0a74f38b8e696980f4866dc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_422ed017d0a74f38b8e696980f4866dc()
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

      private sealed class MTHD_9be236b1a2574d8cbc8947cafdeafcb0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9be236b1a2574d8cbc8947cafdeafcb0()
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

      private sealed class MTHD_c1b8fa7611294bbfb778ed033c854635 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c1b8fa7611294bbfb778ed033c854635()
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

      private sealed class MTHD_3e610196decb40b585bdb042d067110d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3e610196decb40b585bdb042d067110d()
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

      private sealed class MTHD_fdc63697cb68489c911a73ba145d3633 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fdc63697cb68489c911a73ba145d3633()
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

      private sealed class MTHD_925aea77f27e45c6a64e78cade0dc5fc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_925aea77f27e45c6a64e78cade0dc5fc()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_5b027c959c1b4118b90dc96e27d5fa20 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5b027c959c1b4118b90dc96e27d5fa20()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_234ce9b48a054d98a308e21657ad7b49 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_234ce9b48a054d98a308e21657ad7b49()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_6e3beb4c7096480db9f5b6d2dc9eabc2 : HardwiredMemberDescriptor
      {
        internal FLDV_6e3beb4c7096480db9f5b6d2dc9eabc2()
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

      private sealed class FLDV_01e9e923d9dc4915b18b29f63a394b2e : HardwiredMemberDescriptor
      {
        internal FLDV_01e9e923d9dc4915b18b29f63a394b2e()
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

      private sealed class FLDV_4f27951a26b64ca780c2bbe170c7a91e : HardwiredMemberDescriptor
      {
        internal FLDV_4f27951a26b64ca780c2bbe170c7a91e()
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

      private sealed class FLDV_d77a1d418a3f4c2d8f8be3d47ff54864 : HardwiredMemberDescriptor
      {
        internal FLDV_d77a1d418a3f4c2d8f8be3d47ff54864()
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

      private sealed class FLDV_e244731347264f098ccfe408ba48fd3d : HardwiredMemberDescriptor
      {
        internal FLDV_e244731347264f098ccfe408ba48fd3d()
          : base(typeof (LuaColor), "white", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) LuaColor.white;
        }
      }
    }

    private sealed class TYPE_92ffb8f50fa54db7bb1885c07c7b92c2 : HardwiredUserDataDescriptor
    {
      internal TYPE_92ffb8f50fa54db7bb1885c07c7b92c2()
        : base(typeof (TalkOptions))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_92ffb8f50fa54db7bb1885c07c7b92c2.MTHD_e521cbc7e9ac48808794346f8e01f1a6()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_92ffb8f50fa54db7bb1885c07c7b92c2.MTHD_650257e0598a4ad887db2651d2a2360e()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_92ffb8f50fa54db7bb1885c07c7b92c2.MTHD_ca812a783c8a4c47947b8f80b5893a5d()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_92ffb8f50fa54db7bb1885c07c7b92c2.MTHD_7c4049338c914070b2d732b89531269c()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_92ffb8f50fa54db7bb1885c07c7b92c2.MTHD_6fa0bc68385e4f8dab83870564f79dcc()
        }));
      }

      private sealed class MTHD_e521cbc7e9ac48808794346f8e01f1a6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e521cbc7e9ac48808794346f8e01f1a6()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new TalkOptions();
        }
      }

      private sealed class MTHD_650257e0598a4ad887db2651d2a2360e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_650257e0598a4ad887db2651d2a2360e()
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

      private sealed class MTHD_ca812a783c8a4c47947b8f80b5893a5d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ca812a783c8a4c47947b8f80b5893a5d()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_7c4049338c914070b2d732b89531269c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7c4049338c914070b2d732b89531269c()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_6fa0bc68385e4f8dab83870564f79dcc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6fa0bc68385e4f8dab83870564f79dcc()
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
