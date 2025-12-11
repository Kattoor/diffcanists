
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
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_3fadb670da064ef58036e9a5f23b9b13());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_77ad4911c6394031bfb361a119d0d378());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_3735edbd689c425d8b67b14b28c26ad9());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_4642a60d7b544bb4bc7838968e30a632());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_6c8367819323494cae0f919b727ab62a());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_9172052d3c884097bd786517b4efd577());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_f21b318e026945008dc7b94ca497dcf7());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_a2a6983aa4c4430ea21f2895da5f0c8d());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_1a16ed1ca86b4e9cbfadc19af1733415());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_0def1c4b6d6c474590cae7ce0c6b09e3());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_95914849b5aa4edaa7fe64de41e6f6b1());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_618224c4e7a54910995fc48f16312449());
    }

    private sealed class TYPE_84e0d0dde40d492a811d77207ed74243 : HardwiredUserDataDescriptor
    {
      internal TYPE_84e0d0dde40d492a811d77207ed74243()
        : base(typeof (ContainerGame))
      {
        this.AddMember("getUser", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getUser", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_4e08cd46ab1842cd9f7e62cce05aa5b5()
        }));
        this.AddMember("getPlayers", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayers", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_2b94b6ac2643435cbc0062e78647cbf3()
        }));
        this.AddMember("getPlayerCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayerCount", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_a2b3b4f17af84200904a646b24f1123f()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_ea4ac218864d4c13adff08e769d397bf()
        }));
        this.AddMember("findCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_5afe0d437ef74af7a4936d2e8d4df238()
        }));
        this.AddMember("findEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findEffectors", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_91fe530b50e246bbb05e2f14cd21cfe3()
        }));
        this.AddMember("LineCast", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCast", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_2448ddaf458b45fea3f3ef5181b4bd4a()
        }));
        this.AddMember("LineCastOnlyCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_37d6f2440d544fa28b055a08e9e76819()
        }));
        this.AddMember("LineCastOnlyTerrain", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyTerrain", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_614b154b568a4d69af0f05e2f41e605e()
        }));
        this.AddMember("ShowInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ShowInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_b14ec8f69dd74d2f9268cfa2db13ae7d()
        }));
        this.AddMember("hideInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("hideInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_da79e893c5024983b2f1322288254c0b()
        }));
        this.AddMember("Talk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Talk", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_04719247b7a646209e124c50ea0c3c9c()
        }));
        this.AddMember("get_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_1fcc307134df4acf8cda850e59a95001()
        }));
        this.AddMember("set_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_2b67e4b239a54aed8e23caa7c9dcaed6()
        }));
        this.AddMember("get_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_1dd396c0c78c4d558be4b56042dc060c()
        }));
        this.AddMember("set_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_9cabc0cd03d64385b529b08d1f391fd2()
        }));
        this.AddMember("get_totalTimeElapsed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_totalTimeElapsed", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_469b84ef735f43e2ac475bbd0535cbf6()
        }));
        this.AddMember("get_turnTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnTime", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_92239f3576df451b812664f5d5af6227()
        }));
        this.AddMember("get_frame", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frame", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_ab47f58cf8794391a650403d97b85798()
        }));
        this.AddMember("random", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("random", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_7e22be292cbe44f5a1599cb26dac8112()
        }));
        this.AddMember("get_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_33f33c69e4394ddf800fa5f47e986a74()
        }));
        this.AddMember("set_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_c6beb0ddda714e89890120f5855a60fb()
        }));
        this.AddMember("get_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_1e5a1b68176b4e4682b7fcab848cbaf2()
        }));
        this.AddMember("set_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_93f8b966fb2d4d088c07b2ba7c1914a1()
        }));
        this.AddMember("get_allowMinionMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMinionMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_f633ddadde7a4fb5b275d4136ee7d58b()
        }));
        this.AddMember("set_allowMinionMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMinionMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_572ca7502db54a338bc7f0731338d46d()
        }));
        this.AddMember("get_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_b348d7dad840452c87e210307df4a188()
        }));
        this.AddMember("set_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_e05ff4476a854b17932beff93805d289()
        }));
        this.AddMember("get_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_2acf003e50fd48e69bb8504c5a2ee7d3()
        }));
        this.AddMember("set_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_76dc3d289961493faba147e607478eaa()
        }));
        this.AddMember("get_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_5a9f30cd6c664f6fb62204d0631a7f1e()
        }));
        this.AddMember("set_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_63fc7b21a2c7482a8a45773010e29f61()
        }));
        this.AddMember("get_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_564f19fbb2184c9b8d38b2942aafb20e()
        }));
        this.AddMember("set_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_23877a2abade4edd880d739edf42921f()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_85df6cf68e8e40d399c2d07038441e5a()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_b3eb32178d1645e399d03bf7750e0e3d()
        }));
        this.AddMember("get_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_958527a99d3947f2b532ef08bf9138c7()
        }));
        this.AddMember("set_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_7460359d69174bfcbd28ab614021ad74()
        }));
        this.AddMember("get_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_770a05cbce244e78ac12655f4bf098dc()
        }));
        this.AddMember("set_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_6db8c7cb34f64b12a3fddb19f95e6970()
        }));
        this.AddMember("get_waiting", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waiting", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_d271affc50504b6fa2868b95b3e060db()
        }));
        this.AddMember("get_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_9d0eefa190114c35869f2aad682612f1()
        }));
        this.AddMember("set_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_bffef336f2ac459db25316673b942964()
        }));
        this.AddMember("get_busy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_busy", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_7ee246d2b7454dbcae81407878469c40()
        }));
        this.AddMember("get_ongoing", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_ongoing", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_edd7f27cc6ee446eadc38bcef3b75441()
        }));
        this.AddMember("get_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_306a5ebd542f492687c4e5cf01860a5f()
        }));
        this.AddMember("set_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_25234495d46c4d2983f478d9734e7295()
        }));
        this.AddMember("get_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_392eb329c00b47b18a1ac2b836616a04()
        }));
        this.AddMember("set_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_b24e7a495ba1452a8557f46a83217311()
        }));
        this.AddMember("get_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_8355430805c0485cba89ce5e826bad4e()
        }));
        this.AddMember("set_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_373dadef8e5048f0b9ba5f4a1bf9865f()
        }));
        this.AddMember("get_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_7672811731654e399bea0553bc8e4af5()
        }));
        this.AddMember("set_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_f4eba77fc6d74e66822a607742b953fb()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_89d8f61563124446b132f20cc4619bd2()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_8d057cda041f4566af39dfc5f2f017a3()
        }));
        this.AddMember("get_mousePosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mousePosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_50ac57e24ec947cc97b955255e9eeb72()
        }));
        this.AddMember("get_mouseOverUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mouseOverUI", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_06cdb73d07e9454d9e4b0e99c19ef88b()
        }));
        this.AddMember("worldToCanvas", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("worldToCanvas", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_06884788f89d4596a5aec3ddcd3fabde()
        }));
        this.AddMember("canvasToWorld", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("canvasToWorld", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_8bf62109e55f46868afb54b90348031f()
        }));
        this.AddMember("get_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_af5ee9b389cb429fbf62155945193eaf()
        }));
        this.AddMember("set_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_38822e95e273465d840e1e07b88182ad()
        }));
        this.AddMember("get_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_ea78c0cf03b7452ca47c99fb617de0c1()
        }));
        this.AddMember("set_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_7feb724ebc474c31982c9d1391f598cc()
        }));
        this.AddMember("getMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_a999764929d24cff8d1c829970f4280b()
        }));
        this.AddMember("setMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_b8ed248d939540d095695090464bd104()
        }));
        this.AddMember("Dispose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Dispose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_f3751ab4bf404a4bbc9d2f6c6f48420a()
        }));
        this.AddMember("drawImage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawImage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_0c26d16fe695490abff02cf77d3d91ed()
        }));
        this.AddMember("drawRectangle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawRectangle", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_6155edfd056a41c3836901783cc85915()
        }));
        this.AddMember("drawEllipseOutline", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipseOutline", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_80b6cdd65109401c80abb33e013725c8()
        }));
        this.AddMember("drawEllipse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipse", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_1dfff1ca85f24cf2a55a539430c64b44()
        }));
        this.AddMember("blit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_7a93966a6e4d40b7a32f5d300d32635e()
        }));
        this.AddMember("blitRotate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blitRotate", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_b9c98233970e4280b981f27ca0f86e6a()
        }));
        this.AddMember("applyDraw", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("applyDraw", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_4abcc6026f5a417ebb5aeb048ca6f7d3()
        }));
        this.AddMember("get_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_27e2ae6e41ac4e4ebd0666128fb6ef14()
        }));
        this.AddMember("set_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_9cf97f37f4184a4086482e53a96afe2a()
        }));
        this.AddMember("get_isUsingTouchControls", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isUsingTouchControls", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_66ade50bae674d2d811eb17130df4b66()
        }));
        this.AddMember("clientRefreshSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clientRefreshSpells", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_57f3df2736884639b18f41a8a8f44973()
        }));
        this.AddMember("startCoroutine", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("startCoroutine", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_cd2d25459f574476a91bc08561fd766c()
        }));
        this.AddMember("devCommand", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("devCommand", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_b85c84428fc34316b7c47cadf0944529()
        }));
        this.AddMember("win", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("win", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_422aab0cec0b4ac3a22fa0d4f5606143()
        }));
        this.AddMember("lose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("lose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_98a70dccfd9f414d8b292909915b0f4c()
        }));
        this.AddMember("nextTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("nextTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_8d2edf46b9494545ae6561accd2ad7e4()
        }));
        this.AddMember("resetMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("resetMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_bc22200034a54775b9d6bb77c445b85f()
        }));
        this.AddMember("clearMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_0d8a544868144bd3ab5a7973e40eabdc()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_9e4bc53cddf54f018fbd3e762e7def5b()
        }));
        this.AddMember("getSpellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellEnum", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_525d612e9bb84298b64012bc8160063e()
        }));
        this.AddMember("getSpellName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_b4a791eadd534e47aa882bd31b5ab5a5()
        }));
        this.AddMember("getMapID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapID", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_8c7858bf466b4ad59ebcd90d9fc7e45f()
        }));
        this.AddMember("getMapRealName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapRealName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_b6b921d8231f40d6a7cc692249219d4b()
        }));
        this.AddMember("getMapShortName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapShortName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_64353c6559f14fb9addd5467cb88c488()
        }));
        this.AddMember("getArmageddonName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getArmageddonName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_d5947b6eab424c7197f871720eeaeb59()
        }));
        this.AddMember("panCamera", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("panCamera", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_2d837450d30245daa5850cb72f9f4abe()
        }));
        this.AddMember("cameraFollow", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("cameraFollow", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_4323073adc0f470b8870ee65f7e24fd6()
        }));
        this.AddMember("getInputString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getInputString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_527b57b162994b93be0b046738bd2f9f()
        }));
        this.AddMember("get_screenWidth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenWidth", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_b1f65e4217cb4c9fa4ef18fb476acff8()
        }));
        this.AddMember("get_screenHeight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenHeight", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_4d0ce82d3db1422793078065a8772cd6()
        }));
        this.AddMember("createCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createCreature", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_1d36ec7c7b964bfe923d02a80bbe4a8a()
        }));
        this.AddMember("clearIndicators", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearIndicators", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_518b9529477e47faa683123e1f8e0632()
        }));
        this.AddMember("createIndicator", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createIndicator", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_fbdafdf0c2b340d3a3437bc89dd17ead(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_61884a20fe2142eab123024e63e58036()
        }));
        this.AddMember("getKeyBinds", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getKeyBinds", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_8e55606e13a844b4bc2d50adda14ad9e()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_705344dfc0d54125ba07bc27dabc622d()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_e5c283e5ba4a43f98426bd3c54ca8faa()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_e0a3e55b5cdf45548e0020aa63a7c773()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.MTHD_e9509bcdbdfc4a3f84a338730768aa76()
        }));
        this.AddMember("turn", (IMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.PROP_38ec9298b6784d6fb7a18a73dca40a1d());
        this.AddMember("timeLimit", (IMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.PROP_0a2942716cf3440ba93b42a113569bce());
        this.AddMember("totalTimeElapsed", (IMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.PROP_139480da97244493a30c35baeb991134());
        this.AddMember("turnTime", (IMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.PROP_ffb52947e4bf4a8fb40008d5b4334994());
        this.AddMember("frame", (IMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.PROP_1eccee4b2e524b1da7db92c58ac19b2d());
        this.AddMember("winOnDeath", (IMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.PROP_4d4e2cc08e4e4ef5ad76eea4d02d0314());
        this.AddMember("allowMovement", (IMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.PROP_57bb3566e0e44eddafc21b6add38431e());
        this.AddMember("allowMinionMovement", (IMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.PROP_8a451d596eac4e4c93f5154f7437c316());
        this.AddMember("allowInput", (IMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.PROP_87d37f2d2377414bac455f3880995913());
        this.AddMember("allowCallbacks", (IMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.PROP_a3f6644e4f784ddcaf55c346a414b32f());
        this.AddMember("allowSkipTurn", (IMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.PROP_8d333aa76cda4699a11b95067e612faf());
        this.AddMember("terrainDestruction", (IMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.PROP_71b1011dcee949cf8cfc7ba3f626ba70());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.PROP_44d46f2fef6348b29451e748f63239ce());
        this.AddMember("armageddon", (IMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.PROP_f58e6789830146f98f5b7006cea31eef());
        this.AddMember("armageddonTurn", (IMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.PROP_06b729976964410d86c20b5d4dd23fb6());
        this.AddMember("waiting", (IMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.PROP_5b2c75b5467740f385c65d2c3244b4e6());
        this.AddMember("paused", (IMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.PROP_b7fe60c2f7d04976aeb8fb1d9487e92b());
        this.AddMember("busy", (IMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.PROP_a7527d93a00f4effa4da11fc1cccc1ef());
        this.AddMember("ongoing", (IMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.PROP_f54a499d9f9b4082877994d76f5338c5());
        this.AddMember("gravity", (IMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.PROP_ee88893eb3a44e87b9d57ecba022861a());
        this.AddMember("wind", (IMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.PROP_03bc8a0f46144b52981b2e40f3e00a62());
        this.AddMember("windDir", (IMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.PROP_b59afaf5972240918f0b22fb532aca63());
        this.AddMember("windPower", (IMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.PROP_1f71c5c3322d44fe95c40963a10ce3e0());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.PROP_c78a04f93e9f499a8fcb1db8f4f5fbbf());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.PROP_b381e0a7b6ee414ea3431ce117421a87());
        this.AddMember("mousePosition", (IMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.PROP_d25c5b05191748a99a0ccae5a05a7e8a());
        this.AddMember("mouseOverUI", (IMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.PROP_681fa740b9a8438e9a62e77e4da6374a());
        this.AddMember("cameraPosition", (IMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.PROP_80de89d50d4e4296880673039d7d6477());
        this.AddMember("cameraZoom", (IMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.PROP_d6098ba9e0cb4ff988aad3bede650f3a());
        this.AddMember("allowBounce", (IMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.PROP_ac7b6581182a41a99e0b8d26b0b27c5e());
        this.AddMember("isUsingTouchControls", (IMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.PROP_5165882cab2547d3b99ad51de12810c3());
        this.AddMember("screenWidth", (IMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.PROP_98b18a683aca4acc8fefac5565c5e00f());
        this.AddMember("screenHeight", (IMemberDescriptor) new Bridge.TYPE_84e0d0dde40d492a811d77207ed74243.PROP_e17f554b700d41028f85f9f1f0758592());
      }

      private sealed class MTHD_4e08cd46ab1842cd9f7e62cce05aa5b5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4e08cd46ab1842cd9f7e62cce05aa5b5()
        {
          this.Initialize("getUser", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getUser();
        }
      }

      private sealed class MTHD_2b94b6ac2643435cbc0062e78647cbf3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2b94b6ac2643435cbc0062e78647cbf3()
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

      private sealed class MTHD_a2b3b4f17af84200904a646b24f1123f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a2b3b4f17af84200904a646b24f1123f()
        {
          this.Initialize("getPlayerCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getPlayerCount();
        }
      }

      private sealed class MTHD_ea4ac218864d4c13adff08e769d397bf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ea4ac218864d4c13adff08e769d397bf()
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

      private sealed class MTHD_5afe0d437ef74af7a4936d2e8d4df238 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5afe0d437ef74af7a4936d2e8d4df238()
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

      private sealed class MTHD_91fe530b50e246bbb05e2f14cd21cfe3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_91fe530b50e246bbb05e2f14cd21cfe3()
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

      private sealed class MTHD_2448ddaf458b45fea3f3ef5181b4bd4a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2448ddaf458b45fea3f3ef5181b4bd4a()
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

      private sealed class MTHD_37d6f2440d544fa28b055a08e9e76819 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_37d6f2440d544fa28b055a08e9e76819()
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

      private sealed class MTHD_614b154b568a4d69af0f05e2f41e605e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_614b154b568a4d69af0f05e2f41e605e()
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

      private sealed class MTHD_b14ec8f69dd74d2f9268cfa2db13ae7d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b14ec8f69dd74d2f9268cfa2db13ae7d()
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

      private sealed class MTHD_da79e893c5024983b2f1322288254c0b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_da79e893c5024983b2f1322288254c0b()
        {
          this.Initialize("hideInfo", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).hideInfo();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_04719247b7a646209e124c50ea0c3c9c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_04719247b7a646209e124c50ea0c3c9c()
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

      private sealed class MTHD_1fcc307134df4acf8cda850e59a95001 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1fcc307134df4acf8cda850e59a95001()
        {
          this.Initialize("get_turn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turn;
        }
      }

      private sealed class MTHD_2b67e4b239a54aed8e23caa7c9dcaed6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2b67e4b239a54aed8e23caa7c9dcaed6()
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

      private sealed class MTHD_1dd396c0c78c4d558be4b56042dc060c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1dd396c0c78c4d558be4b56042dc060c()
        {
          this.Initialize("get_timeLimit", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).timeLimit;
        }
      }

      private sealed class MTHD_9cabc0cd03d64385b529b08d1f391fd2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9cabc0cd03d64385b529b08d1f391fd2()
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

      private sealed class MTHD_469b84ef735f43e2ac475bbd0535cbf6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_469b84ef735f43e2ac475bbd0535cbf6()
        {
          this.Initialize("get_totalTimeElapsed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class MTHD_92239f3576df451b812664f5d5af6227 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_92239f3576df451b812664f5d5af6227()
        {
          this.Initialize("get_turnTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class MTHD_ab47f58cf8794391a650403d97b85798 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ab47f58cf8794391a650403d97b85798()
        {
          this.Initialize("get_frame", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class MTHD_7e22be292cbe44f5a1599cb26dac8112 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7e22be292cbe44f5a1599cb26dac8112()
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

      private sealed class MTHD_33f33c69e4394ddf800fa5f47e986a74 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_33f33c69e4394ddf800fa5f47e986a74()
        {
          this.Initialize("get_winOnDeath", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).winOnDeath;
        }
      }

      private sealed class MTHD_c6beb0ddda714e89890120f5855a60fb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c6beb0ddda714e89890120f5855a60fb()
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

      private sealed class MTHD_1e5a1b68176b4e4682b7fcab848cbaf2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1e5a1b68176b4e4682b7fcab848cbaf2()
        {
          this.Initialize("get_allowMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMovement;
        }
      }

      private sealed class MTHD_93f8b966fb2d4d088c07b2ba7c1914a1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_93f8b966fb2d4d088c07b2ba7c1914a1()
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

      private sealed class MTHD_f633ddadde7a4fb5b275d4136ee7d58b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f633ddadde7a4fb5b275d4136ee7d58b()
        {
          this.Initialize("get_allowMinionMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMinionMovement;
        }
      }

      private sealed class MTHD_572ca7502db54a338bc7f0731338d46d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_572ca7502db54a338bc7f0731338d46d()
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

      private sealed class MTHD_b348d7dad840452c87e210307df4a188 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b348d7dad840452c87e210307df4a188()
        {
          this.Initialize("get_allowInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowInput;
        }
      }

      private sealed class MTHD_e05ff4476a854b17932beff93805d289 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e05ff4476a854b17932beff93805d289()
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

      private sealed class MTHD_2acf003e50fd48e69bb8504c5a2ee7d3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2acf003e50fd48e69bb8504c5a2ee7d3()
        {
          this.Initialize("get_allowCallbacks", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowCallbacks;
        }
      }

      private sealed class MTHD_76dc3d289961493faba147e607478eaa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_76dc3d289961493faba147e607478eaa()
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

      private sealed class MTHD_5a9f30cd6c664f6fb62204d0631a7f1e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5a9f30cd6c664f6fb62204d0631a7f1e()
        {
          this.Initialize("get_allowSkipTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowSkipTurn;
        }
      }

      private sealed class MTHD_63fc7b21a2c7482a8a45773010e29f61 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_63fc7b21a2c7482a8a45773010e29f61()
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

      private sealed class MTHD_564f19fbb2184c9b8d38b2942aafb20e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_564f19fbb2184c9b8d38b2942aafb20e()
        {
          this.Initialize("get_terrainDestruction", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).terrainDestruction;
        }
      }

      private sealed class MTHD_23877a2abade4edd880d739edf42921f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_23877a2abade4edd880d739edf42921f()
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

      private sealed class MTHD_85df6cf68e8e40d399c2d07038441e5a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_85df6cf68e8e40d399c2d07038441e5a()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).takeDamage;
        }
      }

      private sealed class MTHD_b3eb32178d1645e399d03bf7750e0e3d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b3eb32178d1645e399d03bf7750e0e3d()
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

      private sealed class MTHD_958527a99d3947f2b532ef08bf9138c7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_958527a99d3947f2b532ef08bf9138c7()
        {
          this.Initialize("get_armageddon", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddon;
        }
      }

      private sealed class MTHD_7460359d69174bfcbd28ab614021ad74 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7460359d69174bfcbd28ab614021ad74()
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

      private sealed class MTHD_770a05cbce244e78ac12655f4bf098dc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_770a05cbce244e78ac12655f4bf098dc()
        {
          this.Initialize("get_armageddonTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddonTurn;
        }
      }

      private sealed class MTHD_6db8c7cb34f64b12a3fddb19f95e6970 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6db8c7cb34f64b12a3fddb19f95e6970()
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

      private sealed class MTHD_d271affc50504b6fa2868b95b3e060db : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d271affc50504b6fa2868b95b3e060db()
        {
          this.Initialize("get_waiting", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class MTHD_9d0eefa190114c35869f2aad682612f1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9d0eefa190114c35869f2aad682612f1()
        {
          this.Initialize("get_paused", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).paused;
        }
      }

      private sealed class MTHD_bffef336f2ac459db25316673b942964 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bffef336f2ac459db25316673b942964()
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

      private sealed class MTHD_7ee246d2b7454dbcae81407878469c40 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7ee246d2b7454dbcae81407878469c40()
        {
          this.Initialize("get_busy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class MTHD_edd7f27cc6ee446eadc38bcef3b75441 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_edd7f27cc6ee446eadc38bcef3b75441()
        {
          this.Initialize("get_ongoing", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class MTHD_306a5ebd542f492687c4e5cf01860a5f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_306a5ebd542f492687c4e5cf01860a5f()
        {
          this.Initialize("get_gravity", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).gravity;
        }
      }

      private sealed class MTHD_25234495d46c4d2983f478d9734e7295 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_25234495d46c4d2983f478d9734e7295()
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

      private sealed class MTHD_392eb329c00b47b18a1ac2b836616a04 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_392eb329c00b47b18a1ac2b836616a04()
        {
          this.Initialize("get_wind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).wind;
        }
      }

      private sealed class MTHD_b24e7a495ba1452a8557f46a83217311 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b24e7a495ba1452a8557f46a83217311()
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

      private sealed class MTHD_8355430805c0485cba89ce5e826bad4e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8355430805c0485cba89ce5e826bad4e()
        {
          this.Initialize("get_windDir", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windDir;
        }
      }

      private sealed class MTHD_373dadef8e5048f0b9ba5f4a1bf9865f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_373dadef8e5048f0b9ba5f4a1bf9865f()
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

      private sealed class MTHD_7672811731654e399bea0553bc8e4af5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7672811731654e399bea0553bc8e4af5()
        {
          this.Initialize("get_windPower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windPower;
        }
      }

      private sealed class MTHD_f4eba77fc6d74e66822a607742b953fb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f4eba77fc6d74e66822a607742b953fb()
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

      private sealed class MTHD_89d8f61563124446b132f20cc4619bd2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_89d8f61563124446b132f20cc4619bd2()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class MTHD_8d057cda041f4566af39dfc5f2f017a3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8d057cda041f4566af39dfc5f2f017a3()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class MTHD_50ac57e24ec947cc97b955255e9eeb72 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_50ac57e24ec947cc97b955255e9eeb72()
        {
          this.Initialize("get_mousePosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class MTHD_06cdb73d07e9454d9e4b0e99c19ef88b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_06cdb73d07e9454d9e4b0e99c19ef88b()
        {
          this.Initialize("get_mouseOverUI", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class MTHD_06884788f89d4596a5aec3ddcd3fabde : HardwiredMethodMemberDescriptor
      {
        internal MTHD_06884788f89d4596a5aec3ddcd3fabde()
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

      private sealed class MTHD_8bf62109e55f46868afb54b90348031f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8bf62109e55f46868afb54b90348031f()
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

      private sealed class MTHD_af5ee9b389cb429fbf62155945193eaf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_af5ee9b389cb429fbf62155945193eaf()
        {
          this.Initialize("get_cameraPosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraPosition;
        }
      }

      private sealed class MTHD_38822e95e273465d840e1e07b88182ad : HardwiredMethodMemberDescriptor
      {
        internal MTHD_38822e95e273465d840e1e07b88182ad()
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

      private sealed class MTHD_ea78c0cf03b7452ca47c99fb617de0c1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ea78c0cf03b7452ca47c99fb617de0c1()
        {
          this.Initialize("get_cameraZoom", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraZoom;
        }
      }

      private sealed class MTHD_7feb724ebc474c31982c9d1391f598cc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7feb724ebc474c31982c9d1391f598cc()
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

      private sealed class MTHD_a999764929d24cff8d1c829970f4280b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a999764929d24cff8d1c829970f4280b()
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

      private sealed class MTHD_b8ed248d939540d095695090464bd104 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b8ed248d939540d095695090464bd104()
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

      private sealed class MTHD_f3751ab4bf404a4bbc9d2f6c6f48420a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f3751ab4bf404a4bbc9d2f6c6f48420a()
        {
          this.Initialize("Dispose", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ContainerGame.Dispose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_0c26d16fe695490abff02cf77d3d91ed : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0c26d16fe695490abff02cf77d3d91ed()
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

      private sealed class MTHD_6155edfd056a41c3836901783cc85915 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6155edfd056a41c3836901783cc85915()
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

      private sealed class MTHD_80b6cdd65109401c80abb33e013725c8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_80b6cdd65109401c80abb33e013725c8()
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

      private sealed class MTHD_1dfff1ca85f24cf2a55a539430c64b44 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1dfff1ca85f24cf2a55a539430c64b44()
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

      private sealed class MTHD_7a93966a6e4d40b7a32f5d300d32635e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7a93966a6e4d40b7a32f5d300d32635e()
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

      private sealed class MTHD_b9c98233970e4280b981f27ca0f86e6a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b9c98233970e4280b981f27ca0f86e6a()
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

      private sealed class MTHD_4abcc6026f5a417ebb5aeb048ca6f7d3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4abcc6026f5a417ebb5aeb048ca6f7d3()
        {
          this.Initialize("applyDraw", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).applyDraw();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_27e2ae6e41ac4e4ebd0666128fb6ef14 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_27e2ae6e41ac4e4ebd0666128fb6ef14()
        {
          this.Initialize("get_allowBounce", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowBounce;
        }
      }

      private sealed class MTHD_9cf97f37f4184a4086482e53a96afe2a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9cf97f37f4184a4086482e53a96afe2a()
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

      private sealed class MTHD_66ade50bae674d2d811eb17130df4b66 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_66ade50bae674d2d811eb17130df4b66()
        {
          this.Initialize("get_isUsingTouchControls", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class MTHD_57f3df2736884639b18f41a8a8f44973 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_57f3df2736884639b18f41a8a8f44973()
        {
          this.Initialize("clientRefreshSpells", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clientRefreshSpells();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_cd2d25459f574476a91bc08561fd766c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cd2d25459f574476a91bc08561fd766c()
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

      private sealed class MTHD_b85c84428fc34316b7c47cadf0944529 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b85c84428fc34316b7c47cadf0944529()
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

      private sealed class MTHD_422aab0cec0b4ac3a22fa0d4f5606143 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_422aab0cec0b4ac3a22fa0d4f5606143()
        {
          this.Initialize("win", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).win();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_98a70dccfd9f414d8b292909915b0f4c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_98a70dccfd9f414d8b292909915b0f4c()
        {
          this.Initialize("lose", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).lose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_8d2edf46b9494545ae6561accd2ad7e4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8d2edf46b9494545ae6561accd2ad7e4()
        {
          this.Initialize("nextTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).nextTurn();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_bc22200034a54775b9d6bb77c445b85f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bc22200034a54775b9d6bb77c445b85f()
        {
          this.Initialize("resetMap", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).resetMap();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_0d8a544868144bd3ab5a7973e40eabdc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0d8a544868144bd3ab5a7973e40eabdc()
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

      private sealed class MTHD_9e4bc53cddf54f018fbd3e762e7def5b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9e4bc53cddf54f018fbd3e762e7def5b()
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

      private sealed class MTHD_525d612e9bb84298b64012bc8160063e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_525d612e9bb84298b64012bc8160063e()
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

      private sealed class MTHD_b4a791eadd534e47aa882bd31b5ab5a5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b4a791eadd534e47aa882bd31b5ab5a5()
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

      private sealed class MTHD_8c7858bf466b4ad59ebcd90d9fc7e45f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8c7858bf466b4ad59ebcd90d9fc7e45f()
        {
          this.Initialize("getMapID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getMapID();
        }
      }

      private sealed class MTHD_b6b921d8231f40d6a7cc692249219d4b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b6b921d8231f40d6a7cc692249219d4b()
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

      private sealed class MTHD_64353c6559f14fb9addd5467cb88c488 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_64353c6559f14fb9addd5467cb88c488()
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

      private sealed class MTHD_d5947b6eab424c7197f871720eeaeb59 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d5947b6eab424c7197f871720eeaeb59()
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

      private sealed class MTHD_2d837450d30245daa5850cb72f9f4abe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2d837450d30245daa5850cb72f9f4abe()
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

      private sealed class MTHD_4323073adc0f470b8870ee65f7e24fd6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4323073adc0f470b8870ee65f7e24fd6()
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

      private sealed class MTHD_527b57b162994b93be0b046738bd2f9f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_527b57b162994b93be0b046738bd2f9f()
        {
          this.Initialize("getInputString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getInputString();
        }
      }

      private sealed class MTHD_b1f65e4217cb4c9fa4ef18fb476acff8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b1f65e4217cb4c9fa4ef18fb476acff8()
        {
          this.Initialize("get_screenWidth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class MTHD_4d0ce82d3db1422793078065a8772cd6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4d0ce82d3db1422793078065a8772cd6()
        {
          this.Initialize("get_screenHeight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }

      private sealed class MTHD_1d36ec7c7b964bfe923d02a80bbe4a8a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1d36ec7c7b964bfe923d02a80bbe4a8a()
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

      private sealed class MTHD_518b9529477e47faa683123e1f8e0632 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_518b9529477e47faa683123e1f8e0632()
        {
          this.Initialize("clearIndicators", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clearIndicators();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_fbdafdf0c2b340d3a3437bc89dd17ead : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fbdafdf0c2b340d3a3437bc89dd17ead()
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

      private sealed class MTHD_61884a20fe2142eab123024e63e58036 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_61884a20fe2142eab123024e63e58036()
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

      private sealed class MTHD_8e55606e13a844b4bc2d50adda14ad9e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8e55606e13a844b4bc2d50adda14ad9e()
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

      private sealed class MTHD_705344dfc0d54125ba07bc27dabc622d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_705344dfc0d54125ba07bc27dabc622d()
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

      private sealed class MTHD_e5c283e5ba4a43f98426bd3c54ca8faa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e5c283e5ba4a43f98426bd3c54ca8faa()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_e0a3e55b5cdf45548e0020aa63a7c773 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e0a3e55b5cdf45548e0020aa63a7c773()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_e9509bcdbdfc4a3f84a338730768aa76 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e9509bcdbdfc4a3f84a338730768aa76()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_38ec9298b6784d6fb7a18a73dca40a1d : HardwiredMemberDescriptor
      {
        internal PROP_38ec9298b6784d6fb7a18a73dca40a1d()
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

      private sealed class PROP_0a2942716cf3440ba93b42a113569bce : HardwiredMemberDescriptor
      {
        internal PROP_0a2942716cf3440ba93b42a113569bce()
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

      private sealed class PROP_139480da97244493a30c35baeb991134 : HardwiredMemberDescriptor
      {
        internal PROP_139480da97244493a30c35baeb991134()
          : base(typeof (double), "totalTimeElapsed", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class PROP_ffb52947e4bf4a8fb40008d5b4334994 : HardwiredMemberDescriptor
      {
        internal PROP_ffb52947e4bf4a8fb40008d5b4334994()
          : base(typeof (double), "turnTime", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class PROP_1eccee4b2e524b1da7db92c58ac19b2d : HardwiredMemberDescriptor
      {
        internal PROP_1eccee4b2e524b1da7db92c58ac19b2d()
          : base(typeof (int), "frame", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class PROP_4d4e2cc08e4e4ef5ad76eea4d02d0314 : HardwiredMemberDescriptor
      {
        internal PROP_4d4e2cc08e4e4ef5ad76eea4d02d0314()
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

      private sealed class PROP_57bb3566e0e44eddafc21b6add38431e : HardwiredMemberDescriptor
      {
        internal PROP_57bb3566e0e44eddafc21b6add38431e()
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

      private sealed class PROP_8a451d596eac4e4c93f5154f7437c316 : HardwiredMemberDescriptor
      {
        internal PROP_8a451d596eac4e4c93f5154f7437c316()
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

      private sealed class PROP_87d37f2d2377414bac455f3880995913 : HardwiredMemberDescriptor
      {
        internal PROP_87d37f2d2377414bac455f3880995913()
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

      private sealed class PROP_a3f6644e4f784ddcaf55c346a414b32f : HardwiredMemberDescriptor
      {
        internal PROP_a3f6644e4f784ddcaf55c346a414b32f()
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

      private sealed class PROP_8d333aa76cda4699a11b95067e612faf : HardwiredMemberDescriptor
      {
        internal PROP_8d333aa76cda4699a11b95067e612faf()
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

      private sealed class PROP_71b1011dcee949cf8cfc7ba3f626ba70 : HardwiredMemberDescriptor
      {
        internal PROP_71b1011dcee949cf8cfc7ba3f626ba70()
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

      private sealed class PROP_44d46f2fef6348b29451e748f63239ce : HardwiredMemberDescriptor
      {
        internal PROP_44d46f2fef6348b29451e748f63239ce()
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

      private sealed class PROP_f58e6789830146f98f5b7006cea31eef : HardwiredMemberDescriptor
      {
        internal PROP_f58e6789830146f98f5b7006cea31eef()
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

      private sealed class PROP_06b729976964410d86c20b5d4dd23fb6 : HardwiredMemberDescriptor
      {
        internal PROP_06b729976964410d86c20b5d4dd23fb6()
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

      private sealed class PROP_5b2c75b5467740f385c65d2c3244b4e6 : HardwiredMemberDescriptor
      {
        internal PROP_5b2c75b5467740f385c65d2c3244b4e6()
          : base(typeof (bool), "waiting", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class PROP_b7fe60c2f7d04976aeb8fb1d9487e92b : HardwiredMemberDescriptor
      {
        internal PROP_b7fe60c2f7d04976aeb8fb1d9487e92b()
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

      private sealed class PROP_a7527d93a00f4effa4da11fc1cccc1ef : HardwiredMemberDescriptor
      {
        internal PROP_a7527d93a00f4effa4da11fc1cccc1ef()
          : base(typeof (bool), "busy", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class PROP_f54a499d9f9b4082877994d76f5338c5 : HardwiredMemberDescriptor
      {
        internal PROP_f54a499d9f9b4082877994d76f5338c5()
          : base(typeof (bool), "ongoing", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class PROP_ee88893eb3a44e87b9d57ecba022861a : HardwiredMemberDescriptor
      {
        internal PROP_ee88893eb3a44e87b9d57ecba022861a()
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

      private sealed class PROP_03bc8a0f46144b52981b2e40f3e00a62 : HardwiredMemberDescriptor
      {
        internal PROP_03bc8a0f46144b52981b2e40f3e00a62()
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

      private sealed class PROP_b59afaf5972240918f0b22fb532aca63 : HardwiredMemberDescriptor
      {
        internal PROP_b59afaf5972240918f0b22fb532aca63()
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

      private sealed class PROP_1f71c5c3322d44fe95c40963a10ce3e0 : HardwiredMemberDescriptor
      {
        internal PROP_1f71c5c3322d44fe95c40963a10ce3e0()
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

      private sealed class PROP_c78a04f93e9f499a8fcb1db8f4f5fbbf : HardwiredMemberDescriptor
      {
        internal PROP_c78a04f93e9f499a8fcb1db8f4f5fbbf()
          : base(typeof (int), "width", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class PROP_b381e0a7b6ee414ea3431ce117421a87 : HardwiredMemberDescriptor
      {
        internal PROP_b381e0a7b6ee414ea3431ce117421a87()
          : base(typeof (int), "height", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class PROP_d25c5b05191748a99a0ccae5a05a7e8a : HardwiredMemberDescriptor
      {
        internal PROP_d25c5b05191748a99a0ccae5a05a7e8a()
          : base(typeof (Educative.Point), "mousePosition", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class PROP_681fa740b9a8438e9a62e77e4da6374a : HardwiredMemberDescriptor
      {
        internal PROP_681fa740b9a8438e9a62e77e4da6374a()
          : base(typeof (bool), "mouseOverUI", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class PROP_80de89d50d4e4296880673039d7d6477 : HardwiredMemberDescriptor
      {
        internal PROP_80de89d50d4e4296880673039d7d6477()
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

      private sealed class PROP_d6098ba9e0cb4ff988aad3bede650f3a : HardwiredMemberDescriptor
      {
        internal PROP_d6098ba9e0cb4ff988aad3bede650f3a()
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

      private sealed class PROP_ac7b6581182a41a99e0b8d26b0b27c5e : HardwiredMemberDescriptor
      {
        internal PROP_ac7b6581182a41a99e0b8d26b0b27c5e()
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

      private sealed class PROP_5165882cab2547d3b99ad51de12810c3 : HardwiredMemberDescriptor
      {
        internal PROP_5165882cab2547d3b99ad51de12810c3()
          : base(typeof (bool), "isUsingTouchControls", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class PROP_98b18a683aca4acc8fefac5565c5e00f : HardwiredMemberDescriptor
      {
        internal PROP_98b18a683aca4acc8fefac5565c5e00f()
          : base(typeof (double), "screenWidth", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class PROP_e17f554b700d41028f85f9f1f0758592 : HardwiredMemberDescriptor
      {
        internal PROP_e17f554b700d41028f85f9f1f0758592()
          : base(typeof (double), "screenHeight", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }
    }

    private sealed class TYPE_3fadb670da064ef58036e9a5f23b9b13 : HardwiredUserDataDescriptor
    {
      internal TYPE_3fadb670da064ef58036e9a5f23b9b13()
        : base(typeof (ContainerPlayer))
      {
        this.AddMember("get_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3fadb670da064ef58036e9a5f23b9b13.MTHD_4c8c537ce02e4cc5937e9967cccf0150()
        }));
        this.AddMember("set_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3fadb670da064ef58036e9a5f23b9b13.MTHD_c4992f820fa7426e8a4809a7b50110a5()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3fadb670da064ef58036e9a5f23b9b13.MTHD_055370ae7af34ab0a6340a6b1c456ea6()
        }));
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3fadb670da064ef58036e9a5f23b9b13.MTHD_3f25c4293f0146d49be04f58529d39b2()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3fadb670da064ef58036e9a5f23b9b13.MTHD_6f095ca096e14b288ed3b6f9e29ede0f()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3fadb670da064ef58036e9a5f23b9b13.MTHD_453b77b5d83942b683860d649bd97597()
        }));
        this.AddMember("getCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreature", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3fadb670da064ef58036e9a5f23b9b13.MTHD_25d5fd8aa95d42ccbc1a2119a0c72ad3()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3fadb670da064ef58036e9a5f23b9b13.MTHD_2d6bd7cbb2ac458da0e004dce4c4ad82()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3fadb670da064ef58036e9a5f23b9b13.MTHD_7fb1141c72f1472988017451d02c4e68()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3fadb670da064ef58036e9a5f23b9b13.MTHD_6d7593302f594a189d031ad1316c4a68()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3fadb670da064ef58036e9a5f23b9b13.MTHD_24edbd70bb054e0492669d432d6ec14d()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3fadb670da064ef58036e9a5f23b9b13.MTHD_a6c83e47577a419b95fddb9b1d34cba0()
        }));
        this.AddMember("localTurn", (IMemberDescriptor) new Bridge.TYPE_3fadb670da064ef58036e9a5f23b9b13.PROP_e861ad02c2ca43048cf8253da17b2d16());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_3fadb670da064ef58036e9a5f23b9b13.PROP_103e8f5960964b3287da01f0c56be946());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_3fadb670da064ef58036e9a5f23b9b13.PROP_986ab7ed82514f558461b475a7e74f1d());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_3fadb670da064ef58036e9a5f23b9b13.PROP_402e24cf38dc4c77b5e6f670c9bc735c());
      }

      private sealed class MTHD_4c8c537ce02e4cc5937e9967cccf0150 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4c8c537ce02e4cc5937e9967cccf0150()
        {
          this.Initialize("get_localTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).localTurn;
        }
      }

      private sealed class MTHD_c4992f820fa7426e8a4809a7b50110a5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c4992f820fa7426e8a4809a7b50110a5()
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

      private sealed class MTHD_055370ae7af34ab0a6340a6b1c456ea6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_055370ae7af34ab0a6340a6b1c456ea6()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class MTHD_3f25c4293f0146d49be04f58529d39b2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3f25c4293f0146d49be04f58529d39b2()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class MTHD_6f095ca096e14b288ed3b6f9e29ede0f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6f095ca096e14b288ed3b6f9e29ede0f()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }

      private sealed class MTHD_453b77b5d83942b683860d649bd97597 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_453b77b5d83942b683860d649bd97597()
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

      private sealed class MTHD_25d5fd8aa95d42ccbc1a2119a0c72ad3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_25d5fd8aa95d42ccbc1a2119a0c72ad3()
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

      private sealed class MTHD_2d6bd7cbb2ac458da0e004dce4c4ad82 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2d6bd7cbb2ac458da0e004dce4c4ad82()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).getMinionCount();
        }
      }

      private sealed class MTHD_7fb1141c72f1472988017451d02c4e68 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7fb1141c72f1472988017451d02c4e68()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).GetHashCode();
        }
      }

      private sealed class MTHD_6d7593302f594a189d031ad1316c4a68 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6d7593302f594a189d031ad1316c4a68()
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

      private sealed class MTHD_24edbd70bb054e0492669d432d6ec14d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_24edbd70bb054e0492669d432d6ec14d()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_a6c83e47577a419b95fddb9b1d34cba0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a6c83e47577a419b95fddb9b1d34cba0()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_e861ad02c2ca43048cf8253da17b2d16 : HardwiredMemberDescriptor
      {
        internal PROP_e861ad02c2ca43048cf8253da17b2d16()
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

      private sealed class PROP_103e8f5960964b3287da01f0c56be946 : HardwiredMemberDescriptor
      {
        internal PROP_103e8f5960964b3287da01f0c56be946()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class PROP_986ab7ed82514f558461b475a7e74f1d : HardwiredMemberDescriptor
      {
        internal PROP_986ab7ed82514f558461b475a7e74f1d()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class PROP_402e24cf38dc4c77b5e6f670c9bc735c : HardwiredMemberDescriptor
      {
        internal PROP_402e24cf38dc4c77b5e6f670c9bc735c()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }
    }

    private sealed class TYPE_90481244fc434cba85aac675eebeb297 : HardwiredUserDataDescriptor
    {
      internal TYPE_90481244fc434cba85aac675eebeb297()
        : base(typeof (ContainerCreature))
      {
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_b8c59e6d595647f4b489a9ef98b9870d()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_5e87d72fd3e1431199925141e5e10c8b()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_92df1a6456444d6ab4b13d4e73d3a680()
        }));
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_32154d1e1c4a41b38a03c355db995bdd()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_29483670bb084ab3bcf8948d7d1be8d1()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_495766c9e490450f9f68ec673becd130()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_fd21c2844b9a4492ac72c61807f696b5()
        }));
        this.AddMember("get_healthAndTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_healthAndTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_03edba8f1c1742b281af50df691d270c()
        }));
        this.AddMember("get_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_361fb2375d9e48498926f279f1d4a27b()
        }));
        this.AddMember("set_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_416e2127bd9e44f48efe9ce42a50d595()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_845d55b6fdae40b9856be2e1d7d7d60f()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_f1bb7f3758fa418888415f86580b08a3()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_8723243072b440a1b948667265668042()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_26acccbd39104a1f9dacf5e4d3c2b6cd()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_83b9510874a64293bf8dc8ce95923b1c()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_2b34a276b55843bb8279175291dcb7f8()
        }));
        this.AddMember("get_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_591b0530df0b43d8adaad5001ff318cb()
        }));
        this.AddMember("set_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_b77fcf8e94464119a2cb86f476258cee()
        }));
        this.AddMember("get_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_96b0fb831177491f8bb499030cce6366()
        }));
        this.AddMember("set_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_979a894486774fe68fec22ccc4e779c7()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_ce735f078c08403d944c78aa97939de3()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_32a3e41b5b01455ba92a46e96d68615f()
        }));
        this.AddMember("get_inTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_be29b369a39844948a6263a50527b4b4()
        }));
        this.AddMember("get_isMoving", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMoving", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_cf4b3610e19d4cafacf33c74aa7123dd()
        }));
        this.AddMember("get_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_f734f3b4cc194d66adfeced1e75cfcd9()
        }));
        this.AddMember("set_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_3b5ab5a3b7d44b76941b8f4df8d87190()
        }));
        this.AddMember("get_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_a5778b9739dd4f09a8266b3e7cca5549()
        }));
        this.AddMember("set_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_99dda9f5ac8f4c0fab789e1605324209()
        }));
        this.AddMember("get_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_421ce806a13f4ac79d414094e0e1e317()
        }));
        this.AddMember("set_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_52dbafd9394443d598f9b2b2884f3782()
        }));
        this.AddMember("get_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_66df6c74025c497e8540cf15f6aea0ed()
        }));
        this.AddMember("set_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_8393650d72f549b4a6ddabc2dedbb936()
        }));
        this.AddMember("get_inWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_39aaaf5038c9417e934022581cb9ca13()
        }));
        this.AddMember("get_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_a2c8f3a712c9420eb2f37eb1132d2b73()
        }));
        this.AddMember("set_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_215bba9e0ef4436bb3e33529d852a796()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_58cf9497c7284d7394c01d7c89c8d0c2()
        }));
        this.AddMember("set_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_e0bbe7ee37b444eeab3f6f3bd6c216a0()
        }));
        this.AddMember("get_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_412b4d6870fc4165b8b0eb176342e28b()
        }));
        this.AddMember("set_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_6cba31b604ae4fddbe1aae943e852915()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_1c4d447cb1774954b513ba24b7ccfd94()
        }));
        this.AddMember("get_isRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_2fd243e8d87d4d4595bc002ca61da41b()
        }));
        this.AddMember("get_isMounted", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMounted", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_851a709a2c314b7c98431446124bb692()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_b0b71be096454bd2897480f02478e419()
        }));
        this.AddMember("get_isPawn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPawn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_49a64619d00a48a7a45614607347026b()
        }));
        this.AddMember("get_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_354410660ce74145ba12999189ef14ed()
        }));
        this.AddMember("set_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_0dd70be2e0144b609b48f1ed8b6ff539()
        }));
        this.AddMember("get_isMountable", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMountable", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_1756b50aa75040209b3948b4aa030285()
        }));
        this.AddMember("get_canMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_canMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_12246cda6c24464dba3e54d022b7060c()
        }));
        this.AddMember("get_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_2864a2d60dab4422bba5988f81a47fed()
        }));
        this.AddMember("set_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_c6084be7444744b689e51f50729e0744()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_965f2e8da669411d8084f99e55e00738()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_a8de29acfdac4c88ab362b3c6233c631()
        }));
        this.AddMember("getRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_be0b9c8cc9a2476eaaa4ab31889ff230()
        }));
        this.AddMember("getMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_953a52fdfa4f456394aac4ca2382faf6()
        }));
        this.AddMember("getTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_74ce62c4d57945b4b17fb22fc99874c4()
        }));
        this.AddMember("LongJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LongJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_e1618397d0ff4acdbcb383f1dd9ab0c9()
        }));
        this.AddMember("HighJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("HighJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_23a3cf2f373f4e8f8db124b6b26ed874()
        }));
        this.AddMember("Walk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Walk", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_da177f8ad171406d8df8a801c7585484()
        }));
        this.AddMember("setDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_8f0f46445f5541a99afb5da9899b4b52()
        }));
        this.AddMember("getDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_1c2768496dc34e97aae4d8e8bcb8bfbf()
        }));
        this.AddMember("getFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_34281f8e0f09472793a2099508cd89da()
        }));
        this.AddMember("getActivateableFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_169ad86070e14fd79e0ac8b1dda3ff03()
        }));
        this.AddMember("getActivateableFamiliarBookID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarBookID", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_474a745a171644f0ae9b519e91021445()
        }));
        this.AddMember("increaseFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("increaseFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_0ab1627ba9334bdb8143c59d0cbda8a3()
        }));
        this.AddMember("inside", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("inside", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_6097f6ddd62640fb8e4aa0d5a3e74a6d(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_dae733a5479c4294b169296488697d20()
        }));
        this.AddMember("overlap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("overlap", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_63d1b3b472814a8e8aa3a806be8082c1(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_95ba03b479cd41fba5bbd2a523834446()
        }));
        this.AddMember("die", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("die", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_6a48aff29e1a4ea68a57ec3de73ae36f()
        }));
        this.AddMember("addSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_52039203eee749fda64f1bb022de4b9b()
        }));
        this.AddMember("removeSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("removeSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_117dc5dd410645e6aacf29b6864370e9(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_bc587d82d37a4e55b67730a0c0cda23f()
        }));
        this.AddMember("getSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpells", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_106d57cc6a3646e0b94e2015e205ae00()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_4e1edb6c9a504d00bf7571e73b8d339f()
        }));
        this.AddMember("getSpellCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_819175bd4c3143eeb98333d96ed896f3()
        }));
        this.AddMember("castedCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_df143b3739474cb9aad98b176e6cc37d()
        }));
        this.AddMember("castedCountThisTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCountThisTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_6ad2a00276ae4641b92e48821e5275de()
        }));
        this.AddMember("castedDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_99c593809c7b41519a10429bcd9a39a8()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_6393ae389505418ba31453c1a7b41950()
        }));
        this.AddMember("castSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_f4db3cadc046482089d1e8c62fb25b4f()
        }));
        this.AddMember("angleToFire", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("angleToFire", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_0019629af62749dfb9fc5a4ce06b13ad()
        }));
        this.AddMember("powerToFire", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("powerToFire", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_7f738b5bea514f4891d7029083f8bc95()
        }));
        this.AddMember("fireAt", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fireAt", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_beb3d8a71ba74291a9d8ab1d6c869d12(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_b0cc88e1357f4fb0bbff866470588f9f()
        }));
        this.AddMember("getEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getEffectors", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_49dca7164e4048688848bdd73355fe52(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_f31aee106a4f499a9fd8b85aae88a223()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_5c8896ae693748159656fe539c286982()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_12212107f93443c3938966df8dcd10f3()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_7a13f03c7212431f80a960116cc19d62()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_a8c760174d3e4268a26bc4c9a0a8ba6e()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_bff128b0e5d244d0b7b8dffa51a1d066()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.MTHD_43c532f6cdbb4f9cb39499a599c23868()
        }));
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.PROP_31b2daf0501749c1aeabeaf23aabc46f());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.PROP_1caf38061a3c4bb5912c4d7a7e28daf3());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.PROP_d756a18627a2445ca36b0018ac2c8bf2());
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.PROP_f557fe1ddcd140b8b55d5ea81d8fa2ea());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.PROP_80e85f8b9a624a6ebadf7a9b09e19281());
        this.AddMember("healthAndTower", (IMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.PROP_b4a1040f63514be293ae71bd152c08fe());
        this.AddMember("shield", (IMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.PROP_7776d508d6bc4819b825816fcdf97e1e());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.PROP_b9f830e0c42c46f097b29b98c6e36db6());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.PROP_ad92b2819e534fc5ac48e2602844cac2());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.PROP_f9c193e3814540439ca3271a4b9f0e3d());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.PROP_e58b10074d324060962b9b720664e5d4());
        this.AddMember("weight", (IMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.PROP_4fc68c6e5d854e03a21731f8200ee8dd());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.PROP_fd9bfb1a82424608954d3cb0e153b53f());
        this.AddMember("inTower", (IMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.PROP_31ed3d8f2da44336b51457fa6dff55a1());
        this.AddMember("isMoving", (IMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.PROP_e0376727dc5d485ea373f00327792b8a());
        this.AddMember("stunned", (IMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.PROP_6dd3cadf12e54912a22116fac99cf8ed());
        this.AddMember("superStunned", (IMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.PROP_4e0961f7e8c94cbaa06111e538e8efd7());
        this.AddMember("waterWalking", (IMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.PROP_d5a320b83cbd40f5aaccd4a5502844ea());
        this.AddMember("frostWalking", (IMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.PROP_fc6c70d14e5f405c8c670b60aafd1124());
        this.AddMember("inWater", (IMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.PROP_9c5a4fc969144918883a8806ba1485d2());
        this.AddMember("diesInWater", (IMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.PROP_5e7b1fa456524fab9c03801bfa3159d3());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.PROP_f4821f9b1b5b4e03a7a75c125ac928a0());
        this.AddMember("race", (IMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.PROP_4511879b6e1c4f4bbb7ed26aad50d257());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.PROP_c3cb2469dd1d4c01a72d9718462df6cb());
        this.AddMember("isRider", (IMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.PROP_25b8ef5180b04d189a648afbf3a37719());
        this.AddMember("isMounted", (IMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.PROP_4aabf369af0e40098b1a2fe2c65feade());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.PROP_fd9ea0d5c3e94032967fad8bb71a3022());
        this.AddMember("isPawn", (IMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.PROP_7fff6b0ece1543d6809e0f354f83f46c());
        this.AddMember("isFlying", (IMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.PROP_d6ee58ec14d24096b728eef99ad72535());
        this.AddMember("isMountable", (IMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.PROP_10f73484d4e54e51b1ff8c742d86b1d1());
        this.AddMember("canMount", (IMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.PROP_7a61fb96bfa348c898eb98356c1177a5());
        this.AddMember("arcaneMonster", (IMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.PROP_5a7d7151669d4267b0ae4d930b0d86fe());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_90481244fc434cba85aac675eebeb297.PROP_afc7efacfc694ffbbf9cd7deff98bbc0());
      }

      private sealed class MTHD_b8c59e6d595647f4b489a9ef98b9870d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b8c59e6d595647f4b489a9ef98b9870d()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class MTHD_5e87d72fd3e1431199925141e5e10c8b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5e87d72fd3e1431199925141e5e10c8b()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class MTHD_92df1a6456444d6ab4b13d4e73d3a680 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_92df1a6456444d6ab4b13d4e73d3a680()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class MTHD_32154d1e1c4a41b38a03c355db995bdd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_32154d1e1c4a41b38a03c355db995bdd()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).health;
        }
      }

      private sealed class MTHD_29483670bb084ab3bcf8948d7d1be8d1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_29483670bb084ab3bcf8948d7d1be8d1()
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

      private sealed class MTHD_495766c9e490450f9f68ec673becd130 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_495766c9e490450f9f68ec673becd130()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).maxHealth;
        }
      }

      private sealed class MTHD_fd21c2844b9a4492ac72c61807f696b5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fd21c2844b9a4492ac72c61807f696b5()
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

      private sealed class MTHD_03edba8f1c1742b281af50df691d270c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_03edba8f1c1742b281af50df691d270c()
        {
          this.Initialize("get_healthAndTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class MTHD_361fb2375d9e48498926f279f1d4a27b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_361fb2375d9e48498926f279f1d4a27b()
        {
          this.Initialize("get_shield", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).shield;
        }
      }

      private sealed class MTHD_416e2127bd9e44f48efe9ce42a50d595 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_416e2127bd9e44f48efe9ce42a50d595()
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

      private sealed class MTHD_845d55b6fdae40b9856be2e1d7d7d60f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_845d55b6fdae40b9856be2e1d7d7d60f()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).x;
        }
      }

      private sealed class MTHD_f1bb7f3758fa418888415f86580b08a3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f1bb7f3758fa418888415f86580b08a3()
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

      private sealed class MTHD_8723243072b440a1b948667265668042 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8723243072b440a1b948667265668042()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).y;
        }
      }

      private sealed class MTHD_26acccbd39104a1f9dacf5e4d3c2b6cd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_26acccbd39104a1f9dacf5e4d3c2b6cd()
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

      private sealed class MTHD_83b9510874a64293bf8dc8ce95923b1c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_83b9510874a64293bf8dc8ce95923b1c()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).position;
        }
      }

      private sealed class MTHD_2b34a276b55843bb8279175291dcb7f8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2b34a276b55843bb8279175291dcb7f8()
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

      private sealed class MTHD_591b0530df0b43d8adaad5001ff318cb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_591b0530df0b43d8adaad5001ff318cb()
        {
          this.Initialize("get_parent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).parent;
        }
      }

      private sealed class MTHD_b77fcf8e94464119a2cb86f476258cee : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b77fcf8e94464119a2cb86f476258cee()
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

      private sealed class MTHD_96b0fb831177491f8bb499030cce6366 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_96b0fb831177491f8bb499030cce6366()
        {
          this.Initialize("get_weight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).weight;
        }
      }

      private sealed class MTHD_979a894486774fe68fec22ccc4e779c7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_979a894486774fe68fec22ccc4e779c7()
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

      private sealed class MTHD_ce735f078c08403d944c78aa97939de3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ce735f078c08403d944c78aa97939de3()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).radius;
        }
      }

      private sealed class MTHD_32a3e41b5b01455ba92a46e96d68615f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_32a3e41b5b01455ba92a46e96d68615f()
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

      private sealed class MTHD_be29b369a39844948a6263a50527b4b4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_be29b369a39844948a6263a50527b4b4()
        {
          this.Initialize("get_inTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class MTHD_cf4b3610e19d4cafacf33c74aa7123dd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cf4b3610e19d4cafacf33c74aa7123dd()
        {
          this.Initialize("get_isMoving", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class MTHD_f734f3b4cc194d66adfeced1e75cfcd9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f734f3b4cc194d66adfeced1e75cfcd9()
        {
          this.Initialize("get_stunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).stunned;
        }
      }

      private sealed class MTHD_3b5ab5a3b7d44b76941b8f4df8d87190 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3b5ab5a3b7d44b76941b8f4df8d87190()
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

      private sealed class MTHD_a5778b9739dd4f09a8266b3e7cca5549 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a5778b9739dd4f09a8266b3e7cca5549()
        {
          this.Initialize("get_superStunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).superStunned;
        }
      }

      private sealed class MTHD_99dda9f5ac8f4c0fab789e1605324209 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_99dda9f5ac8f4c0fab789e1605324209()
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

      private sealed class MTHD_421ce806a13f4ac79d414094e0e1e317 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_421ce806a13f4ac79d414094e0e1e317()
        {
          this.Initialize("get_waterWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).waterWalking;
        }
      }

      private sealed class MTHD_52dbafd9394443d598f9b2b2884f3782 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_52dbafd9394443d598f9b2b2884f3782()
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

      private sealed class MTHD_66df6c74025c497e8540cf15f6aea0ed : HardwiredMethodMemberDescriptor
      {
        internal MTHD_66df6c74025c497e8540cf15f6aea0ed()
        {
          this.Initialize("get_frostWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).frostWalking;
        }
      }

      private sealed class MTHD_8393650d72f549b4a6ddabc2dedbb936 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8393650d72f549b4a6ddabc2dedbb936()
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

      private sealed class MTHD_39aaaf5038c9417e934022581cb9ca13 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_39aaaf5038c9417e934022581cb9ca13()
        {
          this.Initialize("get_inWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class MTHD_a2c8f3a712c9420eb2f37eb1132d2b73 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a2c8f3a712c9420eb2f37eb1132d2b73()
        {
          this.Initialize("get_diesInWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).diesInWater;
        }
      }

      private sealed class MTHD_215bba9e0ef4436bb3e33529d852a796 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_215bba9e0ef4436bb3e33529d852a796()
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

      private sealed class MTHD_58cf9497c7284d7394c01d7c89c8d0c2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_58cf9497c7284d7394c01d7c89c8d0c2()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).type;
        }
      }

      private sealed class MTHD_e0bbe7ee37b444eeab3f6f3bd6c216a0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e0bbe7ee37b444eeab3f6f3bd6c216a0()
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

      private sealed class MTHD_412b4d6870fc4165b8b0eb176342e28b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_412b4d6870fc4165b8b0eb176342e28b()
        {
          this.Initialize("get_race", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).race;
        }
      }

      private sealed class MTHD_6cba31b604ae4fddbe1aae943e852915 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6cba31b604ae4fddbe1aae943e852915()
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

      private sealed class MTHD_1c4d447cb1774954b513ba24b7ccfd94 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1c4d447cb1774954b513ba24b7ccfd94()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class MTHD_2fd243e8d87d4d4595bc002ca61da41b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2fd243e8d87d4d4595bc002ca61da41b()
        {
          this.Initialize("get_isRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class MTHD_851a709a2c314b7c98431446124bb692 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_851a709a2c314b7c98431446124bb692()
        {
          this.Initialize("get_isMounted", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class MTHD_b0b71be096454bd2897480f02478e419 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b0b71be096454bd2897480f02478e419()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class MTHD_49a64619d00a48a7a45614607347026b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_49a64619d00a48a7a45614607347026b()
        {
          this.Initialize("get_isPawn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class MTHD_354410660ce74145ba12999189ef14ed : HardwiredMethodMemberDescriptor
      {
        internal MTHD_354410660ce74145ba12999189ef14ed()
        {
          this.Initialize("get_isFlying", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isFlying;
        }
      }

      private sealed class MTHD_0dd70be2e0144b609b48f1ed8b6ff539 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0dd70be2e0144b609b48f1ed8b6ff539()
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

      private sealed class MTHD_1756b50aa75040209b3948b4aa030285 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1756b50aa75040209b3948b4aa030285()
        {
          this.Initialize("get_isMountable", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class MTHD_12246cda6c24464dba3e54d022b7060c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_12246cda6c24464dba3e54d022b7060c()
        {
          this.Initialize("get_canMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class MTHD_2864a2d60dab4422bba5988f81a47fed : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2864a2d60dab4422bba5988f81a47fed()
        {
          this.Initialize("get_arcaneMonster", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).arcaneMonster;
        }
      }

      private sealed class MTHD_c6084be7444744b689e51f50729e0744 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c6084be7444744b689e51f50729e0744()
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

      private sealed class MTHD_965f2e8da669411d8084f99e55e00738 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_965f2e8da669411d8084f99e55e00738()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).takeDamage;
        }
      }

      private sealed class MTHD_a8de29acfdac4c88ab362b3c6233c631 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a8de29acfdac4c88ab362b3c6233c631()
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

      private sealed class MTHD_be0b9c8cc9a2476eaaa4ab31889ff230 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_be0b9c8cc9a2476eaaa4ab31889ff230()
        {
          this.Initialize("getRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getRider();
        }
      }

      private sealed class MTHD_953a52fdfa4f456394aac4ca2382faf6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_953a52fdfa4f456394aac4ca2382faf6()
        {
          this.Initialize("getMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMount();
        }
      }

      private sealed class MTHD_74ce62c4d57945b4b17fb22fc99874c4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_74ce62c4d57945b4b17fb22fc99874c4()
        {
          this.Initialize("getTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getTower();
        }
      }

      private sealed class MTHD_e1618397d0ff4acdbcb383f1dd9ab0c9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e1618397d0ff4acdbcb383f1dd9ab0c9()
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

      private sealed class MTHD_23a3cf2f373f4e8f8db124b6b26ed874 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_23a3cf2f373f4e8f8db124b6b26ed874()
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

      private sealed class MTHD_da177f8ad171406d8df8a801c7585484 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_da177f8ad171406d8df8a801c7585484()
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

      private sealed class MTHD_8f0f46445f5541a99afb5da9899b4b52 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8f0f46445f5541a99afb5da9899b4b52()
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

      private sealed class MTHD_1c2768496dc34e97aae4d8e8bcb8bfbf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1c2768496dc34e97aae4d8e8bcb8bfbf()
        {
          this.Initialize("getDirection", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getDirection();
        }
      }

      private sealed class MTHD_34281f8e0f09472793a2099508cd89da : HardwiredMethodMemberDescriptor
      {
        internal MTHD_34281f8e0f09472793a2099508cd89da()
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

      private sealed class MTHD_169ad86070e14fd79e0ac8b1dda3ff03 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_169ad86070e14fd79e0ac8b1dda3ff03()
        {
          this.Initialize("getActivateableFamiliarLevel", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarLevel();
        }
      }

      private sealed class MTHD_474a745a171644f0ae9b519e91021445 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_474a745a171644f0ae9b519e91021445()
        {
          this.Initialize("getActivateableFamiliarBookID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarBookID();
        }
      }

      private sealed class MTHD_0ab1627ba9334bdb8143c59d0cbda8a3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0ab1627ba9334bdb8143c59d0cbda8a3()
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

      private sealed class MTHD_6097f6ddd62640fb8e4aa0d5a3e74a6d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6097f6ddd62640fb8e4aa0d5a3e74a6d()
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

      private sealed class MTHD_dae733a5479c4294b169296488697d20 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dae733a5479c4294b169296488697d20()
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

      private sealed class MTHD_63d1b3b472814a8e8aa3a806be8082c1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_63d1b3b472814a8e8aa3a806be8082c1()
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

      private sealed class MTHD_95ba03b479cd41fba5bbd2a523834446 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_95ba03b479cd41fba5bbd2a523834446()
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

      private sealed class MTHD_6a48aff29e1a4ea68a57ec3de73ae36f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6a48aff29e1a4ea68a57ec3de73ae36f()
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

      private sealed class MTHD_52039203eee749fda64f1bb022de4b9b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_52039203eee749fda64f1bb022de4b9b()
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

      private sealed class MTHD_117dc5dd410645e6aacf29b6864370e9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_117dc5dd410645e6aacf29b6864370e9()
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

      private sealed class MTHD_bc587d82d37a4e55b67730a0c0cda23f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bc587d82d37a4e55b67730a0c0cda23f()
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

      private sealed class MTHD_106d57cc6a3646e0b94e2015e205ae00 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_106d57cc6a3646e0b94e2015e205ae00()
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

      private sealed class MTHD_4e1edb6c9a504d00bf7571e73b8d339f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4e1edb6c9a504d00bf7571e73b8d339f()
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

      private sealed class MTHD_819175bd4c3143eeb98333d96ed896f3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_819175bd4c3143eeb98333d96ed896f3()
        {
          this.Initialize("getSpellCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getSpellCount();
        }
      }

      private sealed class MTHD_df143b3739474cb9aad98b176e6cc37d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_df143b3739474cb9aad98b176e6cc37d()
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

      private sealed class MTHD_6ad2a00276ae4641b92e48821e5275de : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6ad2a00276ae4641b92e48821e5275de()
        {
          this.Initialize("castedCountThisTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).castedCountThisTurn();
        }
      }

      private sealed class MTHD_99c593809c7b41519a10429bcd9a39a8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_99c593809c7b41519a10429bcd9a39a8()
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

      private sealed class MTHD_6393ae389505418ba31453c1a7b41950 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6393ae389505418ba31453c1a7b41950()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMinionCount();
        }
      }

      private sealed class MTHD_f4db3cadc046482089d1e8c62fb25b4f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f4db3cadc046482089d1e8c62fb25b4f()
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

      private sealed class MTHD_0019629af62749dfb9fc5a4ce06b13ad : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0019629af62749dfb9fc5a4ce06b13ad()
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

      private sealed class MTHD_7f738b5bea514f4891d7029083f8bc95 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7f738b5bea514f4891d7029083f8bc95()
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

      private sealed class MTHD_beb3d8a71ba74291a9d8ab1d6c869d12 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_beb3d8a71ba74291a9d8ab1d6c869d12()
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

      private sealed class MTHD_b0cc88e1357f4fb0bbff866470588f9f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b0cc88e1357f4fb0bbff866470588f9f()
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

      private sealed class MTHD_49dca7164e4048688848bdd73355fe52 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_49dca7164e4048688848bdd73355fe52()
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

      private sealed class MTHD_f31aee106a4f499a9fd8b85aae88a223 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f31aee106a4f499a9fd8b85aae88a223()
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

      private sealed class MTHD_5c8896ae693748159656fe539c286982 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5c8896ae693748159656fe539c286982()
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

      private sealed class MTHD_12212107f93443c3938966df8dcd10f3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_12212107f93443c3938966df8dcd10f3()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).GetHashCode();
        }
      }

      private sealed class MTHD_7a13f03c7212431f80a960116cc19d62 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7a13f03c7212431f80a960116cc19d62()
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

      private sealed class MTHD_a8c760174d3e4268a26bc4c9a0a8ba6e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a8c760174d3e4268a26bc4c9a0a8ba6e()
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

      private sealed class MTHD_bff128b0e5d244d0b7b8dffa51a1d066 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bff128b0e5d244d0b7b8dffa51a1d066()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_43c532f6cdbb4f9cb39499a599c23868 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_43c532f6cdbb4f9cb39499a599c23868()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_31b2daf0501749c1aeabeaf23aabc46f : HardwiredMemberDescriptor
      {
        internal PROP_31b2daf0501749c1aeabeaf23aabc46f()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class PROP_1caf38061a3c4bb5912c4d7a7e28daf3 : HardwiredMemberDescriptor
      {
        internal PROP_1caf38061a3c4bb5912c4d7a7e28daf3()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class PROP_d756a18627a2445ca36b0018ac2c8bf2 : HardwiredMemberDescriptor
      {
        internal PROP_d756a18627a2445ca36b0018ac2c8bf2()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class PROP_f557fe1ddcd140b8b55d5ea81d8fa2ea : HardwiredMemberDescriptor
      {
        internal PROP_f557fe1ddcd140b8b55d5ea81d8fa2ea()
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

      private sealed class PROP_80e85f8b9a624a6ebadf7a9b09e19281 : HardwiredMemberDescriptor
      {
        internal PROP_80e85f8b9a624a6ebadf7a9b09e19281()
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

      private sealed class PROP_b4a1040f63514be293ae71bd152c08fe : HardwiredMemberDescriptor
      {
        internal PROP_b4a1040f63514be293ae71bd152c08fe()
          : base(typeof (int), "healthAndTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class PROP_7776d508d6bc4819b825816fcdf97e1e : HardwiredMemberDescriptor
      {
        internal PROP_7776d508d6bc4819b825816fcdf97e1e()
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

      private sealed class PROP_b9f830e0c42c46f097b29b98c6e36db6 : HardwiredMemberDescriptor
      {
        internal PROP_b9f830e0c42c46f097b29b98c6e36db6()
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

      private sealed class PROP_ad92b2819e534fc5ac48e2602844cac2 : HardwiredMemberDescriptor
      {
        internal PROP_ad92b2819e534fc5ac48e2602844cac2()
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

      private sealed class PROP_f9c193e3814540439ca3271a4b9f0e3d : HardwiredMemberDescriptor
      {
        internal PROP_f9c193e3814540439ca3271a4b9f0e3d()
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

      private sealed class PROP_e58b10074d324060962b9b720664e5d4 : HardwiredMemberDescriptor
      {
        internal PROP_e58b10074d324060962b9b720664e5d4()
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

      private sealed class PROP_4fc68c6e5d854e03a21731f8200ee8dd : HardwiredMemberDescriptor
      {
        internal PROP_4fc68c6e5d854e03a21731f8200ee8dd()
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

      private sealed class PROP_fd9bfb1a82424608954d3cb0e153b53f : HardwiredMemberDescriptor
      {
        internal PROP_fd9bfb1a82424608954d3cb0e153b53f()
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

      private sealed class PROP_31ed3d8f2da44336b51457fa6dff55a1 : HardwiredMemberDescriptor
      {
        internal PROP_31ed3d8f2da44336b51457fa6dff55a1()
          : base(typeof (bool), "inTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class PROP_e0376727dc5d485ea373f00327792b8a : HardwiredMemberDescriptor
      {
        internal PROP_e0376727dc5d485ea373f00327792b8a()
          : base(typeof (bool), "isMoving", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class PROP_6dd3cadf12e54912a22116fac99cf8ed : HardwiredMemberDescriptor
      {
        internal PROP_6dd3cadf12e54912a22116fac99cf8ed()
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

      private sealed class PROP_4e0961f7e8c94cbaa06111e538e8efd7 : HardwiredMemberDescriptor
      {
        internal PROP_4e0961f7e8c94cbaa06111e538e8efd7()
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

      private sealed class PROP_d5a320b83cbd40f5aaccd4a5502844ea : HardwiredMemberDescriptor
      {
        internal PROP_d5a320b83cbd40f5aaccd4a5502844ea()
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

      private sealed class PROP_fc6c70d14e5f405c8c670b60aafd1124 : HardwiredMemberDescriptor
      {
        internal PROP_fc6c70d14e5f405c8c670b60aafd1124()
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

      private sealed class PROP_9c5a4fc969144918883a8806ba1485d2 : HardwiredMemberDescriptor
      {
        internal PROP_9c5a4fc969144918883a8806ba1485d2()
          : base(typeof (bool), "inWater", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class PROP_5e7b1fa456524fab9c03801bfa3159d3 : HardwiredMemberDescriptor
      {
        internal PROP_5e7b1fa456524fab9c03801bfa3159d3()
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

      private sealed class PROP_f4821f9b1b5b4e03a7a75c125ac928a0 : HardwiredMemberDescriptor
      {
        internal PROP_f4821f9b1b5b4e03a7a75c125ac928a0()
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

      private sealed class PROP_4511879b6e1c4f4bbb7ed26aad50d257 : HardwiredMemberDescriptor
      {
        internal PROP_4511879b6e1c4f4bbb7ed26aad50d257()
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

      private sealed class PROP_c3cb2469dd1d4c01a72d9718462df6cb : HardwiredMemberDescriptor
      {
        internal PROP_c3cb2469dd1d4c01a72d9718462df6cb()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class PROP_25b8ef5180b04d189a648afbf3a37719 : HardwiredMemberDescriptor
      {
        internal PROP_25b8ef5180b04d189a648afbf3a37719()
          : base(typeof (bool), "isRider", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class PROP_4aabf369af0e40098b1a2fe2c65feade : HardwiredMemberDescriptor
      {
        internal PROP_4aabf369af0e40098b1a2fe2c65feade()
          : base(typeof (bool), "isMounted", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class PROP_fd9ea0d5c3e94032967fad8bb71a3022 : HardwiredMemberDescriptor
      {
        internal PROP_fd9ea0d5c3e94032967fad8bb71a3022()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class PROP_7fff6b0ece1543d6809e0f354f83f46c : HardwiredMemberDescriptor
      {
        internal PROP_7fff6b0ece1543d6809e0f354f83f46c()
          : base(typeof (bool), "isPawn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class PROP_d6ee58ec14d24096b728eef99ad72535 : HardwiredMemberDescriptor
      {
        internal PROP_d6ee58ec14d24096b728eef99ad72535()
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

      private sealed class PROP_10f73484d4e54e51b1ff8c742d86b1d1 : HardwiredMemberDescriptor
      {
        internal PROP_10f73484d4e54e51b1ff8c742d86b1d1()
          : base(typeof (bool), "isMountable", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class PROP_7a61fb96bfa348c898eb98356c1177a5 : HardwiredMemberDescriptor
      {
        internal PROP_7a61fb96bfa348c898eb98356c1177a5()
          : base(typeof (bool), "canMount", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class PROP_5a7d7151669d4267b0ae4d930b0d86fe : HardwiredMemberDescriptor
      {
        internal PROP_5a7d7151669d4267b0ae4d930b0d86fe()
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

      private sealed class PROP_afc7efacfc694ffbbf9cd7deff98bbc0 : HardwiredMemberDescriptor
      {
        internal PROP_afc7efacfc694ffbbf9cd7deff98bbc0()
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

    private sealed class TYPE_77ad4911c6394031bfb361a119d0d378 : HardwiredUserDataDescriptor
    {
      internal TYPE_77ad4911c6394031bfb361a119d0d378()
        : base(typeof (ContainerEffector))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_77ad4911c6394031bfb361a119d0d378.MTHD_16bfa408dd01463a8d742774f1cded4d()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_77ad4911c6394031bfb361a119d0d378.MTHD_f74c1a202538436585f1c088c423c186()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_77ad4911c6394031bfb361a119d0d378.MTHD_f5f55ccd43bf486e860d2fc4a928a467()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_77ad4911c6394031bfb361a119d0d378.MTHD_405f0819e2a14a04b1ae9dfc2c4c20fa()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_77ad4911c6394031bfb361a119d0d378.MTHD_e841ce8d32f14c4ebff953c1863cefb5()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_77ad4911c6394031bfb361a119d0d378.MTHD_992fbc3d37b14a55aa7a65b8456c1bfd()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_77ad4911c6394031bfb361a119d0d378.MTHD_6b7d7798e2b74ccea82044255ae72446()
        }));
        this.AddMember("get_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_77ad4911c6394031bfb361a119d0d378.MTHD_664b9eab9b0c4745b1487b81949a67c8()
        }));
        this.AddMember("set_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_77ad4911c6394031bfb361a119d0d378.MTHD_3e8bb5fd67864dee860f6dd8d38ff3cf()
        }));
        this.AddMember("get_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_77ad4911c6394031bfb361a119d0d378.MTHD_9eb076d2fb974c0fa1c3010b384254c2()
        }));
        this.AddMember("set_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_77ad4911c6394031bfb361a119d0d378.MTHD_a04e585b0ce74d02a636a061cdd3eba0()
        }));
        this.AddMember("get_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_77ad4911c6394031bfb361a119d0d378.MTHD_2c167650f3824eadbeab1af0f34c9e71()
        }));
        this.AddMember("set_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_77ad4911c6394031bfb361a119d0d378.MTHD_3aa07925fbed487081ac56234c0718a3()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_77ad4911c6394031bfb361a119d0d378.MTHD_f033bb47ae90489fb148d5afb1f80ef0()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_77ad4911c6394031bfb361a119d0d378.MTHD_0ff963430d5a4f3d8ae9a5138c363796()
        }));
        this.AddMember("turnPassed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("turnPassed", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_77ad4911c6394031bfb361a119d0d378.MTHD_735f76a8e3134779ba641a196cfafe9e()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_77ad4911c6394031bfb361a119d0d378.MTHD_2a4477cc4f3e446395ede7cb0f14f3cc()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_77ad4911c6394031bfb361a119d0d378.MTHD_1dec757752ff4032a5b5783322d9f69c()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_77ad4911c6394031bfb361a119d0d378.MTHD_651e51aaa5ad457eb82ae97a9a1216b7()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_77ad4911c6394031bfb361a119d0d378.MTHD_3f47ec6302ce4efeb3cf061036c1e345()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_77ad4911c6394031bfb361a119d0d378.PROP_b0dc65c07b9446a1b0b502814cdddc76());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_77ad4911c6394031bfb361a119d0d378.PROP_6c140ce689304726a2d905fd5e3bb372());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_77ad4911c6394031bfb361a119d0d378.PROP_3eac4406b0af4964a8cf39b5dabacb00());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_77ad4911c6394031bfb361a119d0d378.PROP_262360b0ac8d477ca743616b7e91e7eb());
        this.AddMember("turnsAlive", (IMemberDescriptor) new Bridge.TYPE_77ad4911c6394031bfb361a119d0d378.PROP_92b4dcd471fb4123a3012d71593a5fa6());
        this.AddMember("maxTurnsAlive", (IMemberDescriptor) new Bridge.TYPE_77ad4911c6394031bfb361a119d0d378.PROP_705c6c052656413a9d48a4cb1e50b6b5());
        this.AddMember("active", (IMemberDescriptor) new Bridge.TYPE_77ad4911c6394031bfb361a119d0d378.PROP_25749c7941a54dd2b16027085ec9fdde());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_77ad4911c6394031bfb361a119d0d378.PROP_d39a66f9d5504aa793e8a671d69ffc0f());
      }

      private sealed class MTHD_16bfa408dd01463a8d742774f1cded4d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_16bfa408dd01463a8d742774f1cded4d()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class MTHD_f74c1a202538436585f1c088c423c186 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f74c1a202538436585f1c088c423c186()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).x;
        }
      }

      private sealed class MTHD_f5f55ccd43bf486e860d2fc4a928a467 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f5f55ccd43bf486e860d2fc4a928a467()
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

      private sealed class MTHD_405f0819e2a14a04b1ae9dfc2c4c20fa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_405f0819e2a14a04b1ae9dfc2c4c20fa()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).y;
        }
      }

      private sealed class MTHD_e841ce8d32f14c4ebff953c1863cefb5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e841ce8d32f14c4ebff953c1863cefb5()
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

      private sealed class MTHD_992fbc3d37b14a55aa7a65b8456c1bfd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_992fbc3d37b14a55aa7a65b8456c1bfd()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).position;
        }
      }

      private sealed class MTHD_6b7d7798e2b74ccea82044255ae72446 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6b7d7798e2b74ccea82044255ae72446()
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

      private sealed class MTHD_664b9eab9b0c4745b1487b81949a67c8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_664b9eab9b0c4745b1487b81949a67c8()
        {
          this.Initialize("get_turnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).turnsAlive;
        }
      }

      private sealed class MTHD_3e8bb5fd67864dee860f6dd8d38ff3cf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3e8bb5fd67864dee860f6dd8d38ff3cf()
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

      private sealed class MTHD_9eb076d2fb974c0fa1c3010b384254c2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9eb076d2fb974c0fa1c3010b384254c2()
        {
          this.Initialize("get_maxTurnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).maxTurnsAlive;
        }
      }

      private sealed class MTHD_a04e585b0ce74d02a636a061cdd3eba0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a04e585b0ce74d02a636a061cdd3eba0()
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

      private sealed class MTHD_2c167650f3824eadbeab1af0f34c9e71 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2c167650f3824eadbeab1af0f34c9e71()
        {
          this.Initialize("get_active", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).active;
        }
      }

      private sealed class MTHD_3aa07925fbed487081ac56234c0718a3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3aa07925fbed487081ac56234c0718a3()
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

      private sealed class MTHD_f033bb47ae90489fb148d5afb1f80ef0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f033bb47ae90489fb148d5afb1f80ef0()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }

      private sealed class MTHD_0ff963430d5a4f3d8ae9a5138c363796 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0ff963430d5a4f3d8ae9a5138c363796()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_735f76a8e3134779ba641a196cfafe9e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_735f76a8e3134779ba641a196cfafe9e()
        {
          this.Initialize("turnPassed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).turnPassed();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_2a4477cc4f3e446395ede7cb0f14f3cc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2a4477cc4f3e446395ede7cb0f14f3cc()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).GetHashCode();
        }
      }

      private sealed class MTHD_1dec757752ff4032a5b5783322d9f69c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1dec757752ff4032a5b5783322d9f69c()
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

      private sealed class MTHD_651e51aaa5ad457eb82ae97a9a1216b7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_651e51aaa5ad457eb82ae97a9a1216b7()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_3f47ec6302ce4efeb3cf061036c1e345 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3f47ec6302ce4efeb3cf061036c1e345()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_b0dc65c07b9446a1b0b502814cdddc76 : HardwiredMemberDescriptor
      {
        internal PROP_b0dc65c07b9446a1b0b502814cdddc76()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class PROP_6c140ce689304726a2d905fd5e3bb372 : HardwiredMemberDescriptor
      {
        internal PROP_6c140ce689304726a2d905fd5e3bb372()
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

      private sealed class PROP_3eac4406b0af4964a8cf39b5dabacb00 : HardwiredMemberDescriptor
      {
        internal PROP_3eac4406b0af4964a8cf39b5dabacb00()
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

      private sealed class PROP_262360b0ac8d477ca743616b7e91e7eb : HardwiredMemberDescriptor
      {
        internal PROP_262360b0ac8d477ca743616b7e91e7eb()
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

      private sealed class PROP_92b4dcd471fb4123a3012d71593a5fa6 : HardwiredMemberDescriptor
      {
        internal PROP_92b4dcd471fb4123a3012d71593a5fa6()
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

      private sealed class PROP_705c6c052656413a9d48a4cb1e50b6b5 : HardwiredMemberDescriptor
      {
        internal PROP_705c6c052656413a9d48a4cb1e50b6b5()
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

      private sealed class PROP_25749c7941a54dd2b16027085ec9fdde : HardwiredMemberDescriptor
      {
        internal PROP_25749c7941a54dd2b16027085ec9fdde()
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

      private sealed class PROP_d39a66f9d5504aa793e8a671d69ffc0f : HardwiredMemberDescriptor
      {
        internal PROP_d39a66f9d5504aa793e8a671d69ffc0f()
          : base(typeof (EffectorType), "type", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }
    }

    private sealed class TYPE_3735edbd689c425d8b67b14b28c26ad9 : HardwiredUserDataDescriptor
    {
      internal TYPE_3735edbd689c425d8b67b14b28c26ad9()
        : base(typeof (ContainerIndicator))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3735edbd689c425d8b67b14b28c26ad9.MTHD_a42a48f74a064473a0f54b452f5c7a57()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3735edbd689c425d8b67b14b28c26ad9.MTHD_ff58afdbde7f410f9ee967f14d15a924()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3735edbd689c425d8b67b14b28c26ad9.MTHD_05dc63e779d0406b95316b9514221621()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3735edbd689c425d8b67b14b28c26ad9.MTHD_411041d2a67048469dbd31b23b9a57a3()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3735edbd689c425d8b67b14b28c26ad9.MTHD_7a20de686b284efc84fc4a7a06446f6e()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3735edbd689c425d8b67b14b28c26ad9.MTHD_8d15f8607a4449978745548238012d89()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3735edbd689c425d8b67b14b28c26ad9.MTHD_d2a8bead86f5414dbe2347f19eac9819()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3735edbd689c425d8b67b14b28c26ad9.MTHD_38e5ecf7667d4bca9a16911ec6c2af5e()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3735edbd689c425d8b67b14b28c26ad9.MTHD_218ca805a96848ab8bb0e882ee2a1ef7()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3735edbd689c425d8b67b14b28c26ad9.MTHD_af25fc8a65314815a424925f23654cab()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3735edbd689c425d8b67b14b28c26ad9.MTHD_d3f3347bc802460bae00d55cd7cef6a4()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3735edbd689c425d8b67b14b28c26ad9.MTHD_5fe5d15a261c4fc1834fc434b76a65c4()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3735edbd689c425d8b67b14b28c26ad9.MTHD_7882dd3f400742e3b4ee9cce59a5bfe7()
        }));
        this.AddMember("get_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color2", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3735edbd689c425d8b67b14b28c26ad9.MTHD_ab049eea0b8f40c4a0877ccba0a64414()
        }));
        this.AddMember("set_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color2", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3735edbd689c425d8b67b14b28c26ad9.MTHD_47ece9a35b85477293c803cc903bf754()
        }));
        this.AddMember("get_kind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_kind", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3735edbd689c425d8b67b14b28c26ad9.MTHD_27c3e2d92c4545fbb0726824efe416b4()
        }));
        this.AddMember("setIcon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setIcon", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3735edbd689c425d8b67b14b28c26ad9.MTHD_6fa9bcfe58da42faae0894597bfaae3c()
        }));
        this.AddMember("Destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Destroy", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3735edbd689c425d8b67b14b28c26ad9.MTHD_7251461882944a67b4e9ea9fccb05ffb()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3735edbd689c425d8b67b14b28c26ad9.MTHD_e2255dc8147a4015b04d05b075ac8f44()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3735edbd689c425d8b67b14b28c26ad9.MTHD_d024799cab01439f86d7b52f76925f13()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3735edbd689c425d8b67b14b28c26ad9.MTHD_bcd8ed09552441dab7b5f846f0781977()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3735edbd689c425d8b67b14b28c26ad9.MTHD_cb17808af3ce41a79af6f41552fdbdf8()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_3735edbd689c425d8b67b14b28c26ad9.PROP_edcdf1e635af4d4d9dcef039ff2925b7());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_3735edbd689c425d8b67b14b28c26ad9.PROP_179be0084912465f9d5ccf2aee4b8d0f());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_3735edbd689c425d8b67b14b28c26ad9.PROP_4bdbc01ab6eb425c8e5320d10b5cadd2());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_3735edbd689c425d8b67b14b28c26ad9.PROP_c1fa1c5d41c642c4bca709f5ba8bb82b());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_3735edbd689c425d8b67b14b28c26ad9.PROP_f6d9fc159f654e8bb204662402035c64());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_3735edbd689c425d8b67b14b28c26ad9.PROP_99002a24b668423f834df9cefb5031eb());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_3735edbd689c425d8b67b14b28c26ad9.PROP_6f2ccbf93afc48728c436e0c953937d1());
        this.AddMember("color2", (IMemberDescriptor) new Bridge.TYPE_3735edbd689c425d8b67b14b28c26ad9.PROP_b2f048dc57e044c7bd1440d5c0f0dd8c());
        this.AddMember("kind", (IMemberDescriptor) new Bridge.TYPE_3735edbd689c425d8b67b14b28c26ad9.PROP_74fd922f03b64b4e9c77160cca46c635());
      }

      private sealed class MTHD_a42a48f74a064473a0f54b452f5c7a57 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a42a48f74a064473a0f54b452f5c7a57()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class MTHD_ff58afdbde7f410f9ee967f14d15a924 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ff58afdbde7f410f9ee967f14d15a924()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).x;
        }
      }

      private sealed class MTHD_05dc63e779d0406b95316b9514221621 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_05dc63e779d0406b95316b9514221621()
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

      private sealed class MTHD_411041d2a67048469dbd31b23b9a57a3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_411041d2a67048469dbd31b23b9a57a3()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).y;
        }
      }

      private sealed class MTHD_7a20de686b284efc84fc4a7a06446f6e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7a20de686b284efc84fc4a7a06446f6e()
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

      private sealed class MTHD_8d15f8607a4449978745548238012d89 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8d15f8607a4449978745548238012d89()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).radius;
        }
      }

      private sealed class MTHD_d2a8bead86f5414dbe2347f19eac9819 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d2a8bead86f5414dbe2347f19eac9819()
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

      private sealed class MTHD_38e5ecf7667d4bca9a16911ec6c2af5e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_38e5ecf7667d4bca9a16911ec6c2af5e()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).position;
        }
      }

      private sealed class MTHD_218ca805a96848ab8bb0e882ee2a1ef7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_218ca805a96848ab8bb0e882ee2a1ef7()
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

      private sealed class MTHD_af25fc8a65314815a424925f23654cab : HardwiredMethodMemberDescriptor
      {
        internal MTHD_af25fc8a65314815a424925f23654cab()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).angle;
        }
      }

      private sealed class MTHD_d3f3347bc802460bae00d55cd7cef6a4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d3f3347bc802460bae00d55cd7cef6a4()
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

      private sealed class MTHD_5fe5d15a261c4fc1834fc434b76a65c4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5fe5d15a261c4fc1834fc434b76a65c4()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color;
        }
      }

      private sealed class MTHD_7882dd3f400742e3b4ee9cce59a5bfe7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7882dd3f400742e3b4ee9cce59a5bfe7()
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

      private sealed class MTHD_ab049eea0b8f40c4a0877ccba0a64414 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ab049eea0b8f40c4a0877ccba0a64414()
        {
          this.Initialize("get_color2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color2;
        }
      }

      private sealed class MTHD_47ece9a35b85477293c803cc903bf754 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_47ece9a35b85477293c803cc903bf754()
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

      private sealed class MTHD_27c3e2d92c4545fbb0726824efe416b4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_27c3e2d92c4545fbb0726824efe416b4()
        {
          this.Initialize("get_kind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }

      private sealed class MTHD_6fa9bcfe58da42faae0894597bfaae3c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6fa9bcfe58da42faae0894597bfaae3c()
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

      private sealed class MTHD_7251461882944a67b4e9ea9fccb05ffb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7251461882944a67b4e9ea9fccb05ffb()
        {
          this.Initialize("Destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerIndicator) obj).Destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_e2255dc8147a4015b04d05b075ac8f44 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e2255dc8147a4015b04d05b075ac8f44()
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

      private sealed class MTHD_d024799cab01439f86d7b52f76925f13 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d024799cab01439f86d7b52f76925f13()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_bcd8ed09552441dab7b5f846f0781977 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bcd8ed09552441dab7b5f846f0781977()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_cb17808af3ce41a79af6f41552fdbdf8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cb17808af3ce41a79af6f41552fdbdf8()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_edcdf1e635af4d4d9dcef039ff2925b7 : HardwiredMemberDescriptor
      {
        internal PROP_edcdf1e635af4d4d9dcef039ff2925b7()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class PROP_179be0084912465f9d5ccf2aee4b8d0f : HardwiredMemberDescriptor
      {
        internal PROP_179be0084912465f9d5ccf2aee4b8d0f()
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

      private sealed class PROP_4bdbc01ab6eb425c8e5320d10b5cadd2 : HardwiredMemberDescriptor
      {
        internal PROP_4bdbc01ab6eb425c8e5320d10b5cadd2()
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

      private sealed class PROP_c1fa1c5d41c642c4bca709f5ba8bb82b : HardwiredMemberDescriptor
      {
        internal PROP_c1fa1c5d41c642c4bca709f5ba8bb82b()
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

      private sealed class PROP_f6d9fc159f654e8bb204662402035c64 : HardwiredMemberDescriptor
      {
        internal PROP_f6d9fc159f654e8bb204662402035c64()
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

      private sealed class PROP_99002a24b668423f834df9cefb5031eb : HardwiredMemberDescriptor
      {
        internal PROP_99002a24b668423f834df9cefb5031eb()
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

      private sealed class PROP_6f2ccbf93afc48728c436e0c953937d1 : HardwiredMemberDescriptor
      {
        internal PROP_6f2ccbf93afc48728c436e0c953937d1()
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

      private sealed class PROP_b2f048dc57e044c7bd1440d5c0f0dd8c : HardwiredMemberDescriptor
      {
        internal PROP_b2f048dc57e044c7bd1440d5c0f0dd8c()
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

      private sealed class PROP_74fd922f03b64b4e9c77160cca46c635 : HardwiredMemberDescriptor
      {
        internal PROP_74fd922f03b64b4e9c77160cca46c635()
          : base(typeof (IndicatorKind), "kind", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }
    }

    private sealed class TYPE_4642a60d7b544bb4bc7838968e30a632 : HardwiredUserDataDescriptor
    {
      internal TYPE_4642a60d7b544bb4bc7838968e30a632()
        : base(typeof (ContainerSpell))
      {
        this.AddMember("get_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4642a60d7b544bb4bc7838968e30a632.MTHD_4d8fa9c327ef4216a0352767653e7859()
        }));
        this.AddMember("set_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4642a60d7b544bb4bc7838968e30a632.MTHD_63d1ca032d134def8c657c9fb5699672()
        }));
        this.AddMember("get_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4642a60d7b544bb4bc7838968e30a632.MTHD_4be36a66cd5e4d5db90712dbe82f3fb5()
        }));
        this.AddMember("set_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4642a60d7b544bb4bc7838968e30a632.MTHD_a85643bc1f2847cb866ec9ac8207dee3()
        }));
        this.AddMember("get_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4642a60d7b544bb4bc7838968e30a632.MTHD_920ff79286204fc28f27729d8da0df94()
        }));
        this.AddMember("set_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4642a60d7b544bb4bc7838968e30a632.MTHD_6dea878cc1c44d8fa8c425a5c0372125()
        }));
        this.AddMember("get_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4642a60d7b544bb4bc7838968e30a632.MTHD_41362b9cb8b44563a549317b2c5eb33a()
        }));
        this.AddMember("set_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4642a60d7b544bb4bc7838968e30a632.MTHD_f7ab88f7cc154d32aba765129a4befcb()
        }));
        this.AddMember("get_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4642a60d7b544bb4bc7838968e30a632.MTHD_7eee839029ca43afab85a5858cc7db4a()
        }));
        this.AddMember("set_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4642a60d7b544bb4bc7838968e30a632.MTHD_e252601116fe42ec8e5478dddd1124df()
        }));
        this.AddMember("get_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4642a60d7b544bb4bc7838968e30a632.MTHD_127a4b938b25449ba83fc8713d46fdfd()
        }));
        this.AddMember("set_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4642a60d7b544bb4bc7838968e30a632.MTHD_2cd00304c80147e39bb19b615ae3a9c9()
        }));
        this.AddMember("get_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4642a60d7b544bb4bc7838968e30a632.MTHD_d4e8f40763684c2b929a1214107d033f()
        }));
        this.AddMember("set_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4642a60d7b544bb4bc7838968e30a632.MTHD_cd9d8212008b4bea931b7c02259f85f0()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4642a60d7b544bb4bc7838968e30a632.MTHD_168f3555ef804a4c99936d31e8d9a5fb()
        }));
        this.AddMember("get_castType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_castType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4642a60d7b544bb4bc7838968e30a632.MTHD_4dabd3f1c1374a1283f44ac74ebe39a1()
        }));
        this.AddMember("get_damageType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damageType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4642a60d7b544bb4bc7838968e30a632.MTHD_4f12d2e8866a490c8595b2fa2cce6726()
        }));
        this.AddMember("get_book", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_book", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4642a60d7b544bb4bc7838968e30a632.MTHD_af17c0e3289a473b84538b4a5c19e229()
        }));
        this.AddMember("get_damage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damage", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4642a60d7b544bb4bc7838968e30a632.MTHD_d6086867e3cf42f78a8e73ee97e4cb5a()
        }));
        this.AddMember("get_explosionRadius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_explosionRadius", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4642a60d7b544bb4bc7838968e30a632.MTHD_aa72797aecf34c759910a25653f6adc0()
        }));
        this.AddMember("get_description", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_description", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4642a60d7b544bb4bc7838968e30a632.MTHD_515411593c0b4c4885bc9f2c2f2ffba6()
        }));
        this.AddMember("get_descriptionOnly", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionOnly", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4642a60d7b544bb4bc7838968e30a632.MTHD_15fd7ecf354a45b98be5f9335a47c1c1()
        }));
        this.AddMember("get_descriptionExtra", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionExtra", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4642a60d7b544bb4bc7838968e30a632.MTHD_75001a211fa945af9a98e5c11e877f48()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4642a60d7b544bb4bc7838968e30a632.MTHD_3dc09038f96e43babef32d8b1bdbe6e3()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4642a60d7b544bb4bc7838968e30a632.MTHD_0bf94c7fbe35400db6bdbd8b4de72cfd()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4642a60d7b544bb4bc7838968e30a632.MTHD_3a578f7b4a8e47459b6c1df2dc565153()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4642a60d7b544bb4bc7838968e30a632.MTHD_2fd15920acdc4643ade8ec4776868ff2()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4642a60d7b544bb4bc7838968e30a632.MTHD_3244215ae2704f6bb723aac2f4faa73a()
        }));
        this.AddMember("uses", (IMemberDescriptor) new Bridge.TYPE_4642a60d7b544bb4bc7838968e30a632.PROP_d4ef42225b5b4248ba78e7ff5839e56f());
        this.AddMember("maxUses", (IMemberDescriptor) new Bridge.TYPE_4642a60d7b544bb4bc7838968e30a632.PROP_43812ec4a97a45659233403b827990a5());
        this.AddMember("rechargeTime", (IMemberDescriptor) new Bridge.TYPE_4642a60d7b544bb4bc7838968e30a632.PROP_8fb8776d84214bdc9abfc5086922f513());
        this.AddMember("lastTurnFired", (IMemberDescriptor) new Bridge.TYPE_4642a60d7b544bb4bc7838968e30a632.PROP_2aede75a7d1c465fbbd83396a3c96b6b());
        this.AddMember("isPresent", (IMemberDescriptor) new Bridge.TYPE_4642a60d7b544bb4bc7838968e30a632.PROP_fe48fe26abb24d819e56b5ed800e7804());
        this.AddMember("locked", (IMemberDescriptor) new Bridge.TYPE_4642a60d7b544bb4bc7838968e30a632.PROP_c4d640284d2b4597a93d585dfbeb96c9());
        this.AddMember("turnsTillFirstUse", (IMemberDescriptor) new Bridge.TYPE_4642a60d7b544bb4bc7838968e30a632.PROP_3d4a73e661fd41baaa3fc15c35a0139b());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_4642a60d7b544bb4bc7838968e30a632.PROP_830b43a3ea7b487083ef37a477869760());
        this.AddMember("castType", (IMemberDescriptor) new Bridge.TYPE_4642a60d7b544bb4bc7838968e30a632.PROP_6ca7627582594cc4a816f464c36fff77());
        this.AddMember("damageType", (IMemberDescriptor) new Bridge.TYPE_4642a60d7b544bb4bc7838968e30a632.PROP_8835ceb69bd048cfac2a5c05df38d04f());
        this.AddMember("book", (IMemberDescriptor) new Bridge.TYPE_4642a60d7b544bb4bc7838968e30a632.PROP_7d0c74d2b15d48be92240ddc055f9cb3());
        this.AddMember("damage", (IMemberDescriptor) new Bridge.TYPE_4642a60d7b544bb4bc7838968e30a632.PROP_50133cdb1dcb45c28968b2690253b56f());
        this.AddMember("explosionRadius", (IMemberDescriptor) new Bridge.TYPE_4642a60d7b544bb4bc7838968e30a632.PROP_dba5511d02e141b5ab431d37df2ec30f());
        this.AddMember("description", (IMemberDescriptor) new Bridge.TYPE_4642a60d7b544bb4bc7838968e30a632.PROP_cee30f5bbf3d4e00bb88ac3fe1c3b8de());
        this.AddMember("descriptionOnly", (IMemberDescriptor) new Bridge.TYPE_4642a60d7b544bb4bc7838968e30a632.PROP_a80338266c06400a9799c69a63019b02());
        this.AddMember("descriptionExtra", (IMemberDescriptor) new Bridge.TYPE_4642a60d7b544bb4bc7838968e30a632.PROP_7d578c88cc80474496d24b3c9dc17d09());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_4642a60d7b544bb4bc7838968e30a632.PROP_72c0f9d997264eb8bd60676cb466b306());
      }

      private sealed class MTHD_4d8fa9c327ef4216a0352767653e7859 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4d8fa9c327ef4216a0352767653e7859()
        {
          this.Initialize("get_uses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).uses;
        }
      }

      private sealed class MTHD_63d1ca032d134def8c657c9fb5699672 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_63d1ca032d134def8c657c9fb5699672()
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

      private sealed class MTHD_4be36a66cd5e4d5db90712dbe82f3fb5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4be36a66cd5e4d5db90712dbe82f3fb5()
        {
          this.Initialize("get_maxUses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).maxUses;
        }
      }

      private sealed class MTHD_a85643bc1f2847cb866ec9ac8207dee3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a85643bc1f2847cb866ec9ac8207dee3()
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

      private sealed class MTHD_920ff79286204fc28f27729d8da0df94 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_920ff79286204fc28f27729d8da0df94()
        {
          this.Initialize("get_rechargeTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).rechargeTime;
        }
      }

      private sealed class MTHD_6dea878cc1c44d8fa8c425a5c0372125 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6dea878cc1c44d8fa8c425a5c0372125()
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

      private sealed class MTHD_41362b9cb8b44563a549317b2c5eb33a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_41362b9cb8b44563a549317b2c5eb33a()
        {
          this.Initialize("get_lastTurnFired", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).lastTurnFired;
        }
      }

      private sealed class MTHD_f7ab88f7cc154d32aba765129a4befcb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f7ab88f7cc154d32aba765129a4befcb()
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

      private sealed class MTHD_7eee839029ca43afab85a5858cc7db4a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7eee839029ca43afab85a5858cc7db4a()
        {
          this.Initialize("get_isPresent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).isPresent;
        }
      }

      private sealed class MTHD_e252601116fe42ec8e5478dddd1124df : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e252601116fe42ec8e5478dddd1124df()
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

      private sealed class MTHD_127a4b938b25449ba83fc8713d46fdfd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_127a4b938b25449ba83fc8713d46fdfd()
        {
          this.Initialize("get_locked", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).locked;
        }
      }

      private sealed class MTHD_2cd00304c80147e39bb19b615ae3a9c9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2cd00304c80147e39bb19b615ae3a9c9()
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

      private sealed class MTHD_d4e8f40763684c2b929a1214107d033f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d4e8f40763684c2b929a1214107d033f()
        {
          this.Initialize("get_turnsTillFirstUse", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).turnsTillFirstUse;
        }
      }

      private sealed class MTHD_cd9d8212008b4bea931b7c02259f85f0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cd9d8212008b4bea931b7c02259f85f0()
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

      private sealed class MTHD_168f3555ef804a4c99936d31e8d9a5fb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_168f3555ef804a4c99936d31e8d9a5fb()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class MTHD_4dabd3f1c1374a1283f44ac74ebe39a1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4dabd3f1c1374a1283f44ac74ebe39a1()
        {
          this.Initialize("get_castType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class MTHD_4f12d2e8866a490c8595b2fa2cce6726 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4f12d2e8866a490c8595b2fa2cce6726()
        {
          this.Initialize("get_damageType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class MTHD_af17c0e3289a473b84538b4a5c19e229 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_af17c0e3289a473b84538b4a5c19e229()
        {
          this.Initialize("get_book", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class MTHD_d6086867e3cf42f78a8e73ee97e4cb5a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d6086867e3cf42f78a8e73ee97e4cb5a()
        {
          this.Initialize("get_damage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class MTHD_aa72797aecf34c759910a25653f6adc0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aa72797aecf34c759910a25653f6adc0()
        {
          this.Initialize("get_explosionRadius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class MTHD_515411593c0b4c4885bc9f2c2f2ffba6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_515411593c0b4c4885bc9f2c2f2ffba6()
        {
          this.Initialize("get_description", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class MTHD_15fd7ecf354a45b98be5f9335a47c1c1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_15fd7ecf354a45b98be5f9335a47c1c1()
        {
          this.Initialize("get_descriptionOnly", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class MTHD_75001a211fa945af9a98e5c11e877f48 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_75001a211fa945af9a98e5c11e877f48()
        {
          this.Initialize("get_descriptionExtra", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class MTHD_3dc09038f96e43babef32d8b1bdbe6e3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3dc09038f96e43babef32d8b1bdbe6e3()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }

      private sealed class MTHD_0bf94c7fbe35400db6bdbd8b4de72cfd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0bf94c7fbe35400db6bdbd8b4de72cfd()
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

      private sealed class MTHD_3a578f7b4a8e47459b6c1df2dc565153 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3a578f7b4a8e47459b6c1df2dc565153()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_2fd15920acdc4643ade8ec4776868ff2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2fd15920acdc4643ade8ec4776868ff2()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_3244215ae2704f6bb723aac2f4faa73a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3244215ae2704f6bb723aac2f4faa73a()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_d4ef42225b5b4248ba78e7ff5839e56f : HardwiredMemberDescriptor
      {
        internal PROP_d4ef42225b5b4248ba78e7ff5839e56f()
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

      private sealed class PROP_43812ec4a97a45659233403b827990a5 : HardwiredMemberDescriptor
      {
        internal PROP_43812ec4a97a45659233403b827990a5()
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

      private sealed class PROP_8fb8776d84214bdc9abfc5086922f513 : HardwiredMemberDescriptor
      {
        internal PROP_8fb8776d84214bdc9abfc5086922f513()
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

      private sealed class PROP_2aede75a7d1c465fbbd83396a3c96b6b : HardwiredMemberDescriptor
      {
        internal PROP_2aede75a7d1c465fbbd83396a3c96b6b()
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

      private sealed class PROP_fe48fe26abb24d819e56b5ed800e7804 : HardwiredMemberDescriptor
      {
        internal PROP_fe48fe26abb24d819e56b5ed800e7804()
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

      private sealed class PROP_c4d640284d2b4597a93d585dfbeb96c9 : HardwiredMemberDescriptor
      {
        internal PROP_c4d640284d2b4597a93d585dfbeb96c9()
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

      private sealed class PROP_3d4a73e661fd41baaa3fc15c35a0139b : HardwiredMemberDescriptor
      {
        internal PROP_3d4a73e661fd41baaa3fc15c35a0139b()
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

      private sealed class PROP_830b43a3ea7b487083ef37a477869760 : HardwiredMemberDescriptor
      {
        internal PROP_830b43a3ea7b487083ef37a477869760()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class PROP_6ca7627582594cc4a816f464c36fff77 : HardwiredMemberDescriptor
      {
        internal PROP_6ca7627582594cc4a816f464c36fff77()
          : base(typeof (CastType), "castType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class PROP_8835ceb69bd048cfac2a5c05df38d04f : HardwiredMemberDescriptor
      {
        internal PROP_8835ceb69bd048cfac2a5c05df38d04f()
          : base(typeof (DamageType), "damageType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class PROP_7d0c74d2b15d48be92240ddc055f9cb3 : HardwiredMemberDescriptor
      {
        internal PROP_7d0c74d2b15d48be92240ddc055f9cb3()
          : base(typeof (BookOf), "book", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class PROP_50133cdb1dcb45c28968b2690253b56f : HardwiredMemberDescriptor
      {
        internal PROP_50133cdb1dcb45c28968b2690253b56f()
          : base(typeof (int), "damage", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class PROP_dba5511d02e141b5ab431d37df2ec30f : HardwiredMemberDescriptor
      {
        internal PROP_dba5511d02e141b5ab431d37df2ec30f()
          : base(typeof (int), "explosionRadius", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class PROP_cee30f5bbf3d4e00bb88ac3fe1c3b8de : HardwiredMemberDescriptor
      {
        internal PROP_cee30f5bbf3d4e00bb88ac3fe1c3b8de()
          : base(typeof (string), "description", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class PROP_a80338266c06400a9799c69a63019b02 : HardwiredMemberDescriptor
      {
        internal PROP_a80338266c06400a9799c69a63019b02()
          : base(typeof (string), "descriptionOnly", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class PROP_7d578c88cc80474496d24b3c9dc17d09 : HardwiredMemberDescriptor
      {
        internal PROP_7d578c88cc80474496d24b3c9dc17d09()
          : base(typeof (string), "descriptionExtra", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class PROP_72c0f9d997264eb8bd60676cb466b306 : HardwiredMemberDescriptor
      {
        internal PROP_72c0f9d997264eb8bd60676cb466b306()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }
    }

    private sealed class TYPE_6c8367819323494cae0f919b727ab62a : HardwiredUserDataDescriptor
    {
      internal TYPE_6c8367819323494cae0f919b727ab62a()
        : base(typeof (ContainerTower))
      {
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6c8367819323494cae0f919b727ab62a.MTHD_fdfa4bf64bf4465a9d7e475540c32b67()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6c8367819323494cae0f919b727ab62a.MTHD_cbd54f6afb664c9a95cb149a864fb503()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6c8367819323494cae0f919b727ab62a.MTHD_e550c61a6e8c4ef0afdc69b105310424()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6c8367819323494cae0f919b727ab62a.MTHD_2b985ae1a74547fc82948f8f6f737f21()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6c8367819323494cae0f919b727ab62a.MTHD_7b716d219fe84a22a4127f472ef84d80()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6c8367819323494cae0f919b727ab62a.MTHD_fa1a7c3ea0c644568795f3d57fde5b2e()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6c8367819323494cae0f919b727ab62a.MTHD_f42f98f6a07a45d4bafc5842def2c762()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6c8367819323494cae0f919b727ab62a.MTHD_c313e715c7e8451aa83aed5ff5153bb6()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6c8367819323494cae0f919b727ab62a.MTHD_f177b58476cb49a79173a9d1298e02b3()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6c8367819323494cae0f919b727ab62a.MTHD_e879393660c745808bb42e83ac4abdc6()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6c8367819323494cae0f919b727ab62a.MTHD_c1abd1e8d0a34307993f3bc448d556a4()
        }));
        this.AddMember("getType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6c8367819323494cae0f919b727ab62a.MTHD_f90d859dcfbf424496a5d20d1fad824a()
        }));
        this.AddMember("kill", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("kill", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6c8367819323494cae0f919b727ab62a.MTHD_3b59094ebc7545bda939fc93bfb16d2d()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6c8367819323494cae0f919b727ab62a.MTHD_a5b22371296943a381ee7263b55fd7cb()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6c8367819323494cae0f919b727ab62a.MTHD_7bb127d73a284072b8cf9099bda65bc9()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6c8367819323494cae0f919b727ab62a.MTHD_36ed0ade50db4eb0aafd983815679efd()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6c8367819323494cae0f919b727ab62a.MTHD_1cbcfede22244d7ebb229854dcb43540()
        }));
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_6c8367819323494cae0f919b727ab62a.PROP_0a9a911776e74a71817043760747cad2());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_6c8367819323494cae0f919b727ab62a.PROP_29a47859d24f4e21b6dc93c4f7d482ff());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_6c8367819323494cae0f919b727ab62a.PROP_04f237cc61ad4bc097f27b80728b8550());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_6c8367819323494cae0f919b727ab62a.PROP_3ae548e566a54cb4a543957abf61b37b());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_6c8367819323494cae0f919b727ab62a.PROP_98bb16a6a44145e0a8b6c02872da5c0b());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_6c8367819323494cae0f919b727ab62a.PROP_367f664cf698489d800fd97bb307d86d());
      }

      private sealed class MTHD_fdfa4bf64bf4465a9d7e475540c32b67 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fdfa4bf64bf4465a9d7e475540c32b67()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).health;
        }
      }

      private sealed class MTHD_cbd54f6afb664c9a95cb149a864fb503 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cbd54f6afb664c9a95cb149a864fb503()
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

      private sealed class MTHD_e550c61a6e8c4ef0afdc69b105310424 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e550c61a6e8c4ef0afdc69b105310424()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).maxHealth;
        }
      }

      private sealed class MTHD_2b985ae1a74547fc82948f8f6f737f21 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2b985ae1a74547fc82948f8f6f737f21()
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

      private sealed class MTHD_7b716d219fe84a22a4127f472ef84d80 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7b716d219fe84a22a4127f472ef84d80()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).x;
        }
      }

      private sealed class MTHD_fa1a7c3ea0c644568795f3d57fde5b2e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fa1a7c3ea0c644568795f3d57fde5b2e()
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

      private sealed class MTHD_f42f98f6a07a45d4bafc5842def2c762 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f42f98f6a07a45d4bafc5842def2c762()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).y;
        }
      }

      private sealed class MTHD_c313e715c7e8451aa83aed5ff5153bb6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c313e715c7e8451aa83aed5ff5153bb6()
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

      private sealed class MTHD_f177b58476cb49a79173a9d1298e02b3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f177b58476cb49a79173a9d1298e02b3()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).position;
        }
      }

      private sealed class MTHD_e879393660c745808bb42e83ac4abdc6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e879393660c745808bb42e83ac4abdc6()
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

      private sealed class MTHD_c1abd1e8d0a34307993f3bc448d556a4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c1abd1e8d0a34307993f3bc448d556a4()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }

      private sealed class MTHD_f90d859dcfbf424496a5d20d1fad824a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f90d859dcfbf424496a5d20d1fad824a()
        {
          this.Initialize("getType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).getType();
        }
      }

      private sealed class MTHD_3b59094ebc7545bda939fc93bfb16d2d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3b59094ebc7545bda939fc93bfb16d2d()
        {
          this.Initialize("kill", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerTower) obj).kill();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_a5b22371296943a381ee7263b55fd7cb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a5b22371296943a381ee7263b55fd7cb()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).GetHashCode();
        }
      }

      private sealed class MTHD_7bb127d73a284072b8cf9099bda65bc9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7bb127d73a284072b8cf9099bda65bc9()
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

      private sealed class MTHD_36ed0ade50db4eb0aafd983815679efd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_36ed0ade50db4eb0aafd983815679efd()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_1cbcfede22244d7ebb229854dcb43540 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1cbcfede22244d7ebb229854dcb43540()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_0a9a911776e74a71817043760747cad2 : HardwiredMemberDescriptor
      {
        internal PROP_0a9a911776e74a71817043760747cad2()
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

      private sealed class PROP_29a47859d24f4e21b6dc93c4f7d482ff : HardwiredMemberDescriptor
      {
        internal PROP_29a47859d24f4e21b6dc93c4f7d482ff()
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

      private sealed class PROP_04f237cc61ad4bc097f27b80728b8550 : HardwiredMemberDescriptor
      {
        internal PROP_04f237cc61ad4bc097f27b80728b8550()
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

      private sealed class PROP_3ae548e566a54cb4a543957abf61b37b : HardwiredMemberDescriptor
      {
        internal PROP_3ae548e566a54cb4a543957abf61b37b()
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

      private sealed class PROP_98bb16a6a44145e0a8b6c02872da5c0b : HardwiredMemberDescriptor
      {
        internal PROP_98bb16a6a44145e0a8b6c02872da5c0b()
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

      private sealed class PROP_367f664cf698489d800fd97bb307d86d : HardwiredMemberDescriptor
      {
        internal PROP_367f664cf698489d800fd97bb307d86d()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }
    }

    private sealed class TYPE_9172052d3c884097bd786517b4efd577 : HardwiredUserDataDescriptor
    {
      internal TYPE_9172052d3c884097bd786517b4efd577()
        : base(typeof (Educative.Point))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9172052d3c884097bd786517b4efd577.MTHD_cd4df40bf3584e93909dc28a0c04bde4(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9172052d3c884097bd786517b4efd577.MTHD_7fb02b0f1d6048b2bbdb33eace606fbd()
        }));
        this.AddMember("distance", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("distance", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9172052d3c884097bd786517b4efd577.MTHD_351b85c9901f407a9ee33c427a337bb9(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9172052d3c884097bd786517b4efd577.MTHD_16839eb6c0f6440da7fc9eb3afcf5f98()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9172052d3c884097bd786517b4efd577.MTHD_04f2d1a105084d768efccd41fe20244f()
        }));
        this.AddMember("copy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("copy", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9172052d3c884097bd786517b4efd577.MTHD_f93f24b5f3d246e990c084552dd0eeed()
        }));
        this.AddMember("normalized", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalized", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9172052d3c884097bd786517b4efd577.MTHD_1addb45b2f564a71900e20c48965d6e5()
        }));
        this.AddMember("normalize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalize", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9172052d3c884097bd786517b4efd577.MTHD_319b9bbeec8647e9a89e625e8fa49f31()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9172052d3c884097bd786517b4efd577.MTHD_7138b73bce0c481f97ca74a9fd5cda74()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9172052d3c884097bd786517b4efd577.MTHD_e128896e1d3541aea7457aa32a99a92b()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9172052d3c884097bd786517b4efd577.MTHD_fbcbc639ce9247cebb3097189195069a()
        }));
        this.AddMember("op_Subtraction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Subtraction", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9172052d3c884097bd786517b4efd577.MTHD_7cc8d1b80fe24268af4199837df1eb8c(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9172052d3c884097bd786517b4efd577.MTHD_7ad5f581d74f4ead85bb7d54f6067c81()
        }));
        this.AddMember("op_Addition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Addition", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9172052d3c884097bd786517b4efd577.MTHD_8ee37d2c8ed84d02b692749959944706(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9172052d3c884097bd786517b4efd577.MTHD_b41246301b4a4e9d97fa14e6b33f0dcf()
        }));
        this.AddMember("op_Multiply", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Multiply", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9172052d3c884097bd786517b4efd577.MTHD_40cc47460437443b84928f3e1f6fd3fd(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9172052d3c884097bd786517b4efd577.MTHD_9bde743d818a47a2acd75935ca03bd43()
        }));
        this.AddMember("op_Division", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Division", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9172052d3c884097bd786517b4efd577.MTHD_bcd228f2b1d4477f87a16080d4c52e42(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9172052d3c884097bd786517b4efd577.MTHD_cc976285f40640e09d24b4829137dfad()
        }));
        this.AddMember("op_Modulus", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Modulus", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9172052d3c884097bd786517b4efd577.MTHD_940c2544fbd440c2b6c64cd7fac6dfbf(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9172052d3c884097bd786517b4efd577.MTHD_24455a68332f40b4bb92924f4fb90116()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9172052d3c884097bd786517b4efd577.MTHD_0ab0e66c5ada4066884250c5873bec02()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9172052d3c884097bd786517b4efd577.MTHD_5c914551b6ed47cfa74e3d7b7ad130fe()
        }));
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_9172052d3c884097bd786517b4efd577.FLDV_70928c975ff4432fab63e86e65fa06f7());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_9172052d3c884097bd786517b4efd577.FLDV_46e634cd920d4601b861689b46e00ead());
      }

      private sealed class MTHD_cd4df40bf3584e93909dc28a0c04bde4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cd4df40bf3584e93909dc28a0c04bde4()
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

      private sealed class MTHD_7fb02b0f1d6048b2bbdb33eace606fbd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7fb02b0f1d6048b2bbdb33eace606fbd()
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

      private sealed class MTHD_351b85c9901f407a9ee33c427a337bb9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_351b85c9901f407a9ee33c427a337bb9()
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

      private sealed class MTHD_16839eb6c0f6440da7fc9eb3afcf5f98 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_16839eb6c0f6440da7fc9eb3afcf5f98()
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

      private sealed class MTHD_04f2d1a105084d768efccd41fe20244f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_04f2d1a105084d768efccd41fe20244f()
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

      private sealed class MTHD_f93f24b5f3d246e990c084552dd0eeed : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f93f24b5f3d246e990c084552dd0eeed()
        {
          this.Initialize("copy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).copy();
        }
      }

      private sealed class MTHD_1addb45b2f564a71900e20c48965d6e5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1addb45b2f564a71900e20c48965d6e5()
        {
          this.Initialize("normalized", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).normalized();
        }
      }

      private sealed class MTHD_319b9bbeec8647e9a89e625e8fa49f31 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_319b9bbeec8647e9a89e625e8fa49f31()
        {
          this.Initialize("normalize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((Educative.Point) obj).normalize();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_7138b73bce0c481f97ca74a9fd5cda74 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7138b73bce0c481f97ca74a9fd5cda74()
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

      private sealed class MTHD_e128896e1d3541aea7457aa32a99a92b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e128896e1d3541aea7457aa32a99a92b()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).GetHashCode();
        }
      }

      private sealed class MTHD_fbcbc639ce9247cebb3097189195069a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fbcbc639ce9247cebb3097189195069a()
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

      private sealed class MTHD_7cc8d1b80fe24268af4199837df1eb8c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7cc8d1b80fe24268af4199837df1eb8c()
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

      private sealed class MTHD_7ad5f581d74f4ead85bb7d54f6067c81 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7ad5f581d74f4ead85bb7d54f6067c81()
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

      private sealed class MTHD_8ee37d2c8ed84d02b692749959944706 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8ee37d2c8ed84d02b692749959944706()
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

      private sealed class MTHD_b41246301b4a4e9d97fa14e6b33f0dcf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b41246301b4a4e9d97fa14e6b33f0dcf()
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

      private sealed class MTHD_40cc47460437443b84928f3e1f6fd3fd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_40cc47460437443b84928f3e1f6fd3fd()
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

      private sealed class MTHD_9bde743d818a47a2acd75935ca03bd43 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9bde743d818a47a2acd75935ca03bd43()
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

      private sealed class MTHD_bcd228f2b1d4477f87a16080d4c52e42 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bcd228f2b1d4477f87a16080d4c52e42()
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

      private sealed class MTHD_cc976285f40640e09d24b4829137dfad : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cc976285f40640e09d24b4829137dfad()
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

      private sealed class MTHD_940c2544fbd440c2b6c64cd7fac6dfbf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_940c2544fbd440c2b6c64cd7fac6dfbf()
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

      private sealed class MTHD_24455a68332f40b4bb92924f4fb90116 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_24455a68332f40b4bb92924f4fb90116()
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

      private sealed class MTHD_0ab0e66c5ada4066884250c5873bec02 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0ab0e66c5ada4066884250c5873bec02()
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

      private sealed class MTHD_5c914551b6ed47cfa74e3d7b7ad130fe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5c914551b6ed47cfa74e3d7b7ad130fe()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_70928c975ff4432fab63e86e65fa06f7 : HardwiredMemberDescriptor
      {
        internal FLDV_70928c975ff4432fab63e86e65fa06f7()
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

      private sealed class FLDV_46e634cd920d4601b861689b46e00ead : HardwiredMemberDescriptor
      {
        internal FLDV_46e634cd920d4601b861689b46e00ead()
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

    private sealed class TYPE_f21b318e026945008dc7b94ca497dcf7 : HardwiredUserDataDescriptor
    {
      internal TYPE_f21b318e026945008dc7b94ca497dcf7()
        : base(typeof (Summon))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f21b318e026945008dc7b94ca497dcf7.MTHD_9da26659e1b24d5b852a538f3bd8baa7()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f21b318e026945008dc7b94ca497dcf7.MTHD_e8eb483b73f046ab8c5a89dccf8abb0a()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f21b318e026945008dc7b94ca497dcf7.MTHD_cfcb34a4f27c41dcb70c4a39f90fba9f()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f21b318e026945008dc7b94ca497dcf7.MTHD_529018aa8cae4b9b955abab1e7053a76()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f21b318e026945008dc7b94ca497dcf7.MTHD_d517316ad0574c0786302621c8dc374b()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f21b318e026945008dc7b94ca497dcf7.MTHD_d1b43080193e497e948c08df25a61074()
        }));
        this.AddMember("spell", (IMemberDescriptor) new Bridge.TYPE_f21b318e026945008dc7b94ca497dcf7.FLDV_c8278e048fda41718db9c0ed0fd06829());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_f21b318e026945008dc7b94ca497dcf7.FLDV_8688c80505a94120917d43b8fec13598());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_f21b318e026945008dc7b94ca497dcf7.FLDV_3fa8f30a9730471091e5705d94a71a76());
        this.AddMember("onPlayersPanel", (IMemberDescriptor) new Bridge.TYPE_f21b318e026945008dc7b94ca497dcf7.FLDV_0dcef86c5f7b413bb37aafc3c517dd4f());
        this.AddMember("useAI", (IMemberDescriptor) new Bridge.TYPE_f21b318e026945008dc7b94ca497dcf7.FLDV_2396ed5d814645ab80a637413747b7df());
        this.AddMember("no_AI_still_use_turn", (IMemberDescriptor) new Bridge.TYPE_f21b318e026945008dc7b94ca497dcf7.FLDV_966f487d4a0841afa85d232073b5886a());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_f21b318e026945008dc7b94ca497dcf7.FLDV_2045f9d11e8c4331b0a096911ec9ecf0());
        this.AddMember("playSound", (IMemberDescriptor) new Bridge.TYPE_f21b318e026945008dc7b94ca497dcf7.FLDV_24b22a555fa54c34b7dbb076742ca6df());
        this.AddMember("prestige", (IMemberDescriptor) new Bridge.TYPE_f21b318e026945008dc7b94ca497dcf7.FLDV_ed9ab64ce04d4307b974540e71381b31());
        this.AddMember("colors", (IMemberDescriptor) new Bridge.TYPE_f21b318e026945008dc7b94ca497dcf7.FLDV_fa2ce3ae1b0e4ea580052b727a09e691());
        this.AddMember("spells", (IMemberDescriptor) new Bridge.TYPE_f21b318e026945008dc7b94ca497dcf7.FLDV_da89b86507324345aafd4b4ec4525fa3());
        this.AddMember("outfit", (IMemberDescriptor) new Bridge.TYPE_f21b318e026945008dc7b94ca497dcf7.FLDV_64db48f718784298969fdc276e223b29());
        this.AddMember("elemental", (IMemberDescriptor) new Bridge.TYPE_f21b318e026945008dc7b94ca497dcf7.FLDV_38e614b2baaf46cea9601763a0ce3456());
      }

      private sealed class MTHD_9da26659e1b24d5b852a538f3bd8baa7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9da26659e1b24d5b852a538f3bd8baa7()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new Summon();
        }
      }

      private sealed class MTHD_e8eb483b73f046ab8c5a89dccf8abb0a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e8eb483b73f046ab8c5a89dccf8abb0a()
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

      private sealed class MTHD_cfcb34a4f27c41dcb70c4a39f90fba9f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cfcb34a4f27c41dcb70c4a39f90fba9f()
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

      private sealed class MTHD_529018aa8cae4b9b955abab1e7053a76 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_529018aa8cae4b9b955abab1e7053a76()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_d517316ad0574c0786302621c8dc374b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d517316ad0574c0786302621c8dc374b()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_d1b43080193e497e948c08df25a61074 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d1b43080193e497e948c08df25a61074()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_c8278e048fda41718db9c0ed0fd06829 : HardwiredMemberDescriptor
      {
        internal FLDV_c8278e048fda41718db9c0ed0fd06829()
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

      private sealed class FLDV_8688c80505a94120917d43b8fec13598 : HardwiredMemberDescriptor
      {
        internal FLDV_8688c80505a94120917d43b8fec13598()
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

      private sealed class FLDV_3fa8f30a9730471091e5705d94a71a76 : HardwiredMemberDescriptor
      {
        internal FLDV_3fa8f30a9730471091e5705d94a71a76()
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

      private sealed class FLDV_0dcef86c5f7b413bb37aafc3c517dd4f : HardwiredMemberDescriptor
      {
        internal FLDV_0dcef86c5f7b413bb37aafc3c517dd4f()
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

      private sealed class FLDV_2396ed5d814645ab80a637413747b7df : HardwiredMemberDescriptor
      {
        internal FLDV_2396ed5d814645ab80a637413747b7df()
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

      private sealed class FLDV_966f487d4a0841afa85d232073b5886a : HardwiredMemberDescriptor
      {
        internal FLDV_966f487d4a0841afa85d232073b5886a()
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

      private sealed class FLDV_2045f9d11e8c4331b0a096911ec9ecf0 : HardwiredMemberDescriptor
      {
        internal FLDV_2045f9d11e8c4331b0a096911ec9ecf0()
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

      private sealed class FLDV_24b22a555fa54c34b7dbb076742ca6df : HardwiredMemberDescriptor
      {
        internal FLDV_24b22a555fa54c34b7dbb076742ca6df()
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

      private sealed class FLDV_ed9ab64ce04d4307b974540e71381b31 : HardwiredMemberDescriptor
      {
        internal FLDV_ed9ab64ce04d4307b974540e71381b31()
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

      private sealed class FLDV_fa2ce3ae1b0e4ea580052b727a09e691 : HardwiredMemberDescriptor
      {
        internal FLDV_fa2ce3ae1b0e4ea580052b727a09e691()
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

      private sealed class FLDV_da89b86507324345aafd4b4ec4525fa3 : HardwiredMemberDescriptor
      {
        internal FLDV_da89b86507324345aafd4b4ec4525fa3()
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

      private sealed class FLDV_64db48f718784298969fdc276e223b29 : HardwiredMemberDescriptor
      {
        internal FLDV_64db48f718784298969fdc276e223b29()
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

      private sealed class FLDV_38e614b2baaf46cea9601763a0ce3456 : HardwiredMemberDescriptor
      {
        internal FLDV_38e614b2baaf46cea9601763a0ce3456()
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

    private sealed class TYPE_c1fbc464efa54cd7901fe9149961b176 : HardwiredUserDataDescriptor
    {
      internal TYPE_c1fbc464efa54cd7901fe9149961b176()
        : base(typeof (UIElement))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_fb4eb57c1ae9429b935e2e9c783d55ac()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_fe874d3f5bdd4e48b03679d6a0317e63()
        }));
        this.AddMember("get_visible", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_visible", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_9df98896475d44679310b23694e1ba6b()
        }));
        this.AddMember("set_visible", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_visible", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_53ebce8d2593436f9de9002cad5914e2()
        }));
        this.AddMember("get_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_a329ca2e29384f378e529b4def92e6d1()
        }));
        this.AddMember("set_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_33d0204d4a3b443fbfce9350f1998024()
        }));
        this.AddMember("get_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_433f2ecba20a439f9997e9107e970a95()
        }));
        this.AddMember("set_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_957a4588e5444f91b572ce746e18cc35()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_fc6941e10ced413aa539207b7cfd44c0()
        }));
        this.AddMember("set_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_63acc479197948739e89b1d83ad78fbc()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_290973b5fcd04e63a1898ffb402f1a44()
        }));
        this.AddMember("set_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_9c60db2a877f453ebf10a59306ea96ab()
        }));
        this.AddMember("get_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_79ac62f9122649b4a8dc20943fe2165d()
        }));
        this.AddMember("set_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_e8f2a4b79ee740169a72859daacba710()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_b6602f955dae4a89acebdf3102d7fc4d()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_f140a8bad9314cf68d19786e0130cbf2()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_77bf5cbadc464a43a9d3b8ac88ca0239()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_fd0a2812280c4983a11b926d829ba74a()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_3080bb7aa5754b319b320b987fe1e5c8()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_26ca22115b7347ebacafbe7a3c221f43()
        }));
        this.AddMember("get_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_c178ac11ddaf4da093cc2af26490c284()
        }));
        this.AddMember("set_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_47eee8313fe0468ca56aa5cc2590ea66()
        }));
        this.AddMember("get_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_1c15eaa946b846318bdd3053261253f4()
        }));
        this.AddMember("set_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_ef761125c94244e7b78c5eaa0bce80ad()
        }));
        this.AddMember("get_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_8cc291df41074b4894932a45efdf6bec()
        }));
        this.AddMember("set_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_a3f25675ef5c486f8235449a1e768ddb()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_dfb229e903b345688a5a9788d4fd2e12()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_0017ed12c67342ec8cc8d25bd34e1383()
        }));
        this.AddMember("get_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_0bdeb87ff2c4490a904284d4a43fce4b()
        }));
        this.AddMember("set_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_188c3ff2afe740cf9d59fb0e892a95ee()
        }));
        this.AddMember("get_onClick2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_b501e833c6ea4a8a961f43f16c6a0b83()
        }));
        this.AddMember("set_onClick2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_f4660d2005844b2fbb3d7f7a079e61d9()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_d0a035228a5d40548318c710146bfc2f()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_1130088515c74dbaac5e97f3321d0ca9()
        }));
        this.AddMember("get_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_3b70b0d685524aaf8c579ca71101a194()
        }));
        this.AddMember("set_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_f9af6a839c9a4f9dbdd34acecf389681()
        }));
        this.AddMember("get_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_5b9313d569624efbb7cc51ef067ddc46()
        }));
        this.AddMember("set_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_2074a79a38754dd9b083814f285542fe()
        }));
        this.AddMember("get_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_cd84ff5c6c684278b6011e1cd30a4463()
        }));
        this.AddMember("set_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_82b600662d17455f948d070531acbe24()
        }));
        this.AddMember("get_textColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_25be27ae9dd24f85944b4897c05aed59()
        }));
        this.AddMember("set_textColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_b2da7c9cceaa4136ba59e35b8dcb2557()
        }));
        this.AddMember("get_highlightColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_highlightColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_d659db431b31427a864d07c6fd046731()
        }));
        this.AddMember("set_highlightColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_highlightColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_c65d5d19d9ef452183e6f755876a8a96()
        }));
        this.AddMember("get_highlightColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_highlightColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_b6c72e039a6c4be79e7016771d4d7aee()
        }));
        this.AddMember("set_highlightColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_highlightColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_ca024df73e974f178e6c02f5920d4bb6()
        }));
        this.AddMember("get_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_110ab26e59ea4486873d3ba751efb8c5()
        }));
        this.AddMember("set_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_6d8cb9352e9c43e89e9465b9b76e2c86()
        }));
        this.AddMember("get_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_837be4abb93349b9b711b759441897dc()
        }));
        this.AddMember("set_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_6659e479272f42a2a206cac5cddfc459()
        }));
        this.AddMember("activateInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("activateInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_43621500d015412eb6bb4f3e0e76f242()
        }));
        this.AddMember("createUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createUI", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_60e319938db840758a98412482312038()
        }));
        this.AddMember("createInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_87766b38f76a46968c48ad96300f8357()
        }));
        this.AddMember("duplicate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("duplicate", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_a322fb4d791a4532ae022ef2db127bf7()
        }));
        this.AddMember("destroyHierarchy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroyHierarchy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_95ab9651364941d8811233bace8c2ea8()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_f6ad730522d84791b62c17b277e99618()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_ea533bb8bb264f5082d28f013cef2b41()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_ade0686513e9497bbf4e629994c09236()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_552f03ca6a0241fba81b24113b9dfb94()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.MTHD_8ba64b8b8bc94404aa36710fa36f5298()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.PROP_498f3dda19f749308d1ef730b89205a1());
        this.AddMember("visible", (IMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.PROP_46b05378728e4f909927e43b3024ec47());
        this.AddMember("graphic", (IMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.PROP_5ad2589e416e49f2b45dadd4e85e6240());
        this.AddMember("anchor", (IMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.PROP_b041469baed544ddbe99e8e20b4ad7ff());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.PROP_eafba266cf5149479eebf732da32fbd9());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.PROP_2291c083e9624bb88b5b4992577ea35d());
        this.AddMember("size", (IMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.PROP_92827addc0b34118994dbb3f30caae89());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.PROP_2fd05c880cc94fcf8085fd7c995f99b6());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.PROP_3217853755ca4259a2dd5aaa36cff88f());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.PROP_6c4a4ecf92774cc289c1b514140beac3());
        this.AddMember("pivot_x", (IMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.PROP_75b25b61d74c499caca2e185c830205b());
        this.AddMember("pivot_y", (IMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.PROP_3385632dc4804c92b894b81d2057ba15());
        this.AddMember("pivot", (IMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.PROP_52384f1d032746799fe8048fd5e69325());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.PROP_c77e1fe9b31d40f78a001c39b5c8e804());
        this.AddMember("onClick", (IMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.PROP_7339f0df8de9471ba9dd946dcb6a6c70());
        this.AddMember("onClick2", (IMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.PROP_507f62ebe6534e78a07f1b80e701c4cc());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.PROP_6fa4a24c4ce34db289fb42507e460f3a());
        this.AddMember("color2", (IMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.PROP_0413743ee4844de488c0e50fc594cda8());
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.PROP_9a9acff4a5c0474ab91ac7b0ae109973());
        this.AddMember("textColor", (IMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.PROP_ff2d5283b26e435d9d9444e6d225a439());
        this.AddMember("textColor2", (IMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.PROP_27314639386447dc8bf0521071b2720b());
        this.AddMember("highlightColor", (IMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.PROP_0ab94c3bb6e44b1cabc6db952fa91675());
        this.AddMember("highlightColor2", (IMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.PROP_e604a449d4eb434a9adc929ff827b3b9());
        this.AddMember("textStyle", (IMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.PROP_25adeb92aa8b48968433c3914a1dd398());
        this.AddMember("textSize", (IMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.PROP_3d2714d8956940a69dee573acb64f3a0());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.FLDV_159a923c7eb14d3daa06d656df5242c8());
        this.AddMember("clickID", (IMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.FLDV_c8904c9d1c59454ebb19a99c11543c55());
        this.AddMember("clickDestroy", (IMemberDescriptor) new Bridge.TYPE_c1fbc464efa54cd7901fe9149961b176.FLDV_f7eeda8d6fbd414eb12589c676a22b7a());
      }

      private sealed class MTHD_fb4eb57c1ae9429b935e2e9c783d55ac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fb4eb57c1ae9429b935e2e9c783d55ac()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new UIElement();
        }
      }

      private sealed class MTHD_fe874d3f5bdd4e48b03679d6a0317e63 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fe874d3f5bdd4e48b03679d6a0317e63()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class MTHD_9df98896475d44679310b23694e1ba6b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9df98896475d44679310b23694e1ba6b()
        {
          this.Initialize("get_visible", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).visible;
        }
      }

      private sealed class MTHD_53ebce8d2593436f9de9002cad5914e2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_53ebce8d2593436f9de9002cad5914e2()
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

      private sealed class MTHD_a329ca2e29384f378e529b4def92e6d1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a329ca2e29384f378e529b4def92e6d1()
        {
          this.Initialize("get_graphic", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return ((UIElement) obj).graphic;
        }
      }

      private sealed class MTHD_33d0204d4a3b443fbfce9350f1998024 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_33d0204d4a3b443fbfce9350f1998024()
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

      private sealed class MTHD_433f2ecba20a439f9997e9107e970a95 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_433f2ecba20a439f9997e9107e970a95()
        {
          this.Initialize("get_anchor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).anchor;
        }
      }

      private sealed class MTHD_957a4588e5444f91b572ce746e18cc35 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_957a4588e5444f91b572ce746e18cc35()
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

      private sealed class MTHD_fc6941e10ced413aa539207b7cfd44c0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fc6941e10ced413aa539207b7cfd44c0()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).width;
        }
      }

      private sealed class MTHD_63acc479197948739e89b1d83ad78fbc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_63acc479197948739e89b1d83ad78fbc()
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

      private sealed class MTHD_290973b5fcd04e63a1898ffb402f1a44 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_290973b5fcd04e63a1898ffb402f1a44()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).height;
        }
      }

      private sealed class MTHD_9c60db2a877f453ebf10a59306ea96ab : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9c60db2a877f453ebf10a59306ea96ab()
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

      private sealed class MTHD_79ac62f9122649b4a8dc20943fe2165d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_79ac62f9122649b4a8dc20943fe2165d()
        {
          this.Initialize("get_size", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).size;
        }
      }

      private sealed class MTHD_e8f2a4b79ee740169a72859daacba710 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e8f2a4b79ee740169a72859daacba710()
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

      private sealed class MTHD_b6602f955dae4a89acebdf3102d7fc4d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b6602f955dae4a89acebdf3102d7fc4d()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).x;
        }
      }

      private sealed class MTHD_f140a8bad9314cf68d19786e0130cbf2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f140a8bad9314cf68d19786e0130cbf2()
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

      private sealed class MTHD_77bf5cbadc464a43a9d3b8ac88ca0239 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_77bf5cbadc464a43a9d3b8ac88ca0239()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).y;
        }
      }

      private sealed class MTHD_fd0a2812280c4983a11b926d829ba74a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fd0a2812280c4983a11b926d829ba74a()
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

      private sealed class MTHD_3080bb7aa5754b319b320b987fe1e5c8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3080bb7aa5754b319b320b987fe1e5c8()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).position;
        }
      }

      private sealed class MTHD_26ca22115b7347ebacafbe7a3c221f43 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_26ca22115b7347ebacafbe7a3c221f43()
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

      private sealed class MTHD_c178ac11ddaf4da093cc2af26490c284 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c178ac11ddaf4da093cc2af26490c284()
        {
          this.Initialize("get_pivot_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_x;
        }
      }

      private sealed class MTHD_47eee8313fe0468ca56aa5cc2590ea66 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_47eee8313fe0468ca56aa5cc2590ea66()
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

      private sealed class MTHD_1c15eaa946b846318bdd3053261253f4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1c15eaa946b846318bdd3053261253f4()
        {
          this.Initialize("get_pivot_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_y;
        }
      }

      private sealed class MTHD_ef761125c94244e7b78c5eaa0bce80ad : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ef761125c94244e7b78c5eaa0bce80ad()
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

      private sealed class MTHD_8cc291df41074b4894932a45efdf6bec : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8cc291df41074b4894932a45efdf6bec()
        {
          this.Initialize("get_pivot", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot;
        }
      }

      private sealed class MTHD_a3f25675ef5c486f8235449a1e768ddb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a3f25675ef5c486f8235449a1e768ddb()
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

      private sealed class MTHD_dfb229e903b345688a5a9788d4fd2e12 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dfb229e903b345688a5a9788d4fd2e12()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).angle;
        }
      }

      private sealed class MTHD_0017ed12c67342ec8cc8d25bd34e1383 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0017ed12c67342ec8cc8d25bd34e1383()
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

      private sealed class MTHD_0bdeb87ff2c4490a904284d4a43fce4b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0bdeb87ff2c4490a904284d4a43fce4b()
        {
          this.Initialize("get_onClick", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick;
        }
      }

      private sealed class MTHD_188c3ff2afe740cf9d59fb0e892a95ee : HardwiredMethodMemberDescriptor
      {
        internal MTHD_188c3ff2afe740cf9d59fb0e892a95ee()
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

      private sealed class MTHD_b501e833c6ea4a8a961f43f16c6a0b83 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b501e833c6ea4a8a961f43f16c6a0b83()
        {
          this.Initialize("get_onClick2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick2;
        }
      }

      private sealed class MTHD_f4660d2005844b2fbb3d7f7a079e61d9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f4660d2005844b2fbb3d7f7a079e61d9()
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

      private sealed class MTHD_d0a035228a5d40548318c710146bfc2f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d0a035228a5d40548318c710146bfc2f()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color;
        }
      }

      private sealed class MTHD_1130088515c74dbaac5e97f3321d0ca9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1130088515c74dbaac5e97f3321d0ca9()
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

      private sealed class MTHD_3b70b0d685524aaf8c579ca71101a194 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3b70b0d685524aaf8c579ca71101a194()
        {
          this.Initialize("get_color2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color2;
        }
      }

      private sealed class MTHD_f9af6a839c9a4f9dbdd34acecf389681 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f9af6a839c9a4f9dbdd34acecf389681()
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

      private sealed class MTHD_5b9313d569624efbb7cc51ef067ddc46 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5b9313d569624efbb7cc51ef067ddc46()
        {
          this.Initialize("get_text", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).text;
        }
      }

      private sealed class MTHD_2074a79a38754dd9b083814f285542fe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2074a79a38754dd9b083814f285542fe()
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

      private sealed class MTHD_cd84ff5c6c684278b6011e1cd30a4463 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cd84ff5c6c684278b6011e1cd30a4463()
        {
          this.Initialize("get_textColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor;
        }
      }

      private sealed class MTHD_82b600662d17455f948d070531acbe24 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_82b600662d17455f948d070531acbe24()
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

      private sealed class MTHD_25be27ae9dd24f85944b4897c05aed59 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_25be27ae9dd24f85944b4897c05aed59()
        {
          this.Initialize("get_textColor2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor2;
        }
      }

      private sealed class MTHD_b2da7c9cceaa4136ba59e35b8dcb2557 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b2da7c9cceaa4136ba59e35b8dcb2557()
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

      private sealed class MTHD_d659db431b31427a864d07c6fd046731 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d659db431b31427a864d07c6fd046731()
        {
          this.Initialize("get_highlightColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).highlightColor;
        }
      }

      private sealed class MTHD_c65d5d19d9ef452183e6f755876a8a96 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c65d5d19d9ef452183e6f755876a8a96()
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

      private sealed class MTHD_b6c72e039a6c4be79e7016771d4d7aee : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b6c72e039a6c4be79e7016771d4d7aee()
        {
          this.Initialize("get_highlightColor2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).highlightColor2;
        }
      }

      private sealed class MTHD_ca024df73e974f178e6c02f5920d4bb6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ca024df73e974f178e6c02f5920d4bb6()
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

      private sealed class MTHD_110ab26e59ea4486873d3ba751efb8c5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_110ab26e59ea4486873d3ba751efb8c5()
        {
          this.Initialize("get_textStyle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textStyle;
        }
      }

      private sealed class MTHD_6d8cb9352e9c43e89e9465b9b76e2c86 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6d8cb9352e9c43e89e9465b9b76e2c86()
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

      private sealed class MTHD_837be4abb93349b9b711b759441897dc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_837be4abb93349b9b711b759441897dc()
        {
          this.Initialize("get_textSize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textSize;
        }
      }

      private sealed class MTHD_6659e479272f42a2a206cac5cddfc459 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6659e479272f42a2a206cac5cddfc459()
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

      private sealed class MTHD_43621500d015412eb6bb4f3e0e76f242 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_43621500d015412eb6bb4f3e0e76f242()
        {
          this.Initialize("activateInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).activateInput();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_60e319938db840758a98412482312038 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_60e319938db840758a98412482312038()
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

      private sealed class MTHD_87766b38f76a46968c48ad96300f8357 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_87766b38f76a46968c48ad96300f8357()
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

      private sealed class MTHD_a322fb4d791a4532ae022ef2db127bf7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a322fb4d791a4532ae022ef2db127bf7()
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

      private sealed class MTHD_95ab9651364941d8811233bace8c2ea8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_95ab9651364941d8811233bace8c2ea8()
        {
          this.Initialize("destroyHierarchy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroyHierarchy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_f6ad730522d84791b62c17b277e99618 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f6ad730522d84791b62c17b277e99618()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_ea533bb8bb264f5082d28f013cef2b41 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ea533bb8bb264f5082d28f013cef2b41()
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

      private sealed class MTHD_ade0686513e9497bbf4e629994c09236 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ade0686513e9497bbf4e629994c09236()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_552f03ca6a0241fba81b24113b9dfb94 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_552f03ca6a0241fba81b24113b9dfb94()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_8ba64b8b8bc94404aa36710fa36f5298 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8ba64b8b8bc94404aa36710fa36f5298()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_498f3dda19f749308d1ef730b89205a1 : HardwiredMemberDescriptor
      {
        internal PROP_498f3dda19f749308d1ef730b89205a1()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class PROP_46b05378728e4f909927e43b3024ec47 : HardwiredMemberDescriptor
      {
        internal PROP_46b05378728e4f909927e43b3024ec47()
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

      private sealed class PROP_5ad2589e416e49f2b45dadd4e85e6240 : HardwiredMemberDescriptor
      {
        internal PROP_5ad2589e416e49f2b45dadd4e85e6240()
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

      private sealed class PROP_b041469baed544ddbe99e8e20b4ad7ff : HardwiredMemberDescriptor
      {
        internal PROP_b041469baed544ddbe99e8e20b4ad7ff()
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

      private sealed class PROP_eafba266cf5149479eebf732da32fbd9 : HardwiredMemberDescriptor
      {
        internal PROP_eafba266cf5149479eebf732da32fbd9()
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

      private sealed class PROP_2291c083e9624bb88b5b4992577ea35d : HardwiredMemberDescriptor
      {
        internal PROP_2291c083e9624bb88b5b4992577ea35d()
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

      private sealed class PROP_92827addc0b34118994dbb3f30caae89 : HardwiredMemberDescriptor
      {
        internal PROP_92827addc0b34118994dbb3f30caae89()
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

      private sealed class PROP_2fd05c880cc94fcf8085fd7c995f99b6 : HardwiredMemberDescriptor
      {
        internal PROP_2fd05c880cc94fcf8085fd7c995f99b6()
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

      private sealed class PROP_3217853755ca4259a2dd5aaa36cff88f : HardwiredMemberDescriptor
      {
        internal PROP_3217853755ca4259a2dd5aaa36cff88f()
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

      private sealed class PROP_6c4a4ecf92774cc289c1b514140beac3 : HardwiredMemberDescriptor
      {
        internal PROP_6c4a4ecf92774cc289c1b514140beac3()
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

      private sealed class PROP_75b25b61d74c499caca2e185c830205b : HardwiredMemberDescriptor
      {
        internal PROP_75b25b61d74c499caca2e185c830205b()
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

      private sealed class PROP_3385632dc4804c92b894b81d2057ba15 : HardwiredMemberDescriptor
      {
        internal PROP_3385632dc4804c92b894b81d2057ba15()
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

      private sealed class PROP_52384f1d032746799fe8048fd5e69325 : HardwiredMemberDescriptor
      {
        internal PROP_52384f1d032746799fe8048fd5e69325()
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

      private sealed class PROP_c77e1fe9b31d40f78a001c39b5c8e804 : HardwiredMemberDescriptor
      {
        internal PROP_c77e1fe9b31d40f78a001c39b5c8e804()
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

      private sealed class PROP_7339f0df8de9471ba9dd946dcb6a6c70 : HardwiredMemberDescriptor
      {
        internal PROP_7339f0df8de9471ba9dd946dcb6a6c70()
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

      private sealed class PROP_507f62ebe6534e78a07f1b80e701c4cc : HardwiredMemberDescriptor
      {
        internal PROP_507f62ebe6534e78a07f1b80e701c4cc()
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

      private sealed class PROP_6fa4a24c4ce34db289fb42507e460f3a : HardwiredMemberDescriptor
      {
        internal PROP_6fa4a24c4ce34db289fb42507e460f3a()
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

      private sealed class PROP_0413743ee4844de488c0e50fc594cda8 : HardwiredMemberDescriptor
      {
        internal PROP_0413743ee4844de488c0e50fc594cda8()
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

      private sealed class PROP_9a9acff4a5c0474ab91ac7b0ae109973 : HardwiredMemberDescriptor
      {
        internal PROP_9a9acff4a5c0474ab91ac7b0ae109973()
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

      private sealed class PROP_ff2d5283b26e435d9d9444e6d225a439 : HardwiredMemberDescriptor
      {
        internal PROP_ff2d5283b26e435d9d9444e6d225a439()
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

      private sealed class PROP_27314639386447dc8bf0521071b2720b : HardwiredMemberDescriptor
      {
        internal PROP_27314639386447dc8bf0521071b2720b()
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

      private sealed class PROP_0ab94c3bb6e44b1cabc6db952fa91675 : HardwiredMemberDescriptor
      {
        internal PROP_0ab94c3bb6e44b1cabc6db952fa91675()
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

      private sealed class PROP_e604a449d4eb434a9adc929ff827b3b9 : HardwiredMemberDescriptor
      {
        internal PROP_e604a449d4eb434a9adc929ff827b3b9()
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

      private sealed class PROP_25adeb92aa8b48968433c3914a1dd398 : HardwiredMemberDescriptor
      {
        internal PROP_25adeb92aa8b48968433c3914a1dd398()
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

      private sealed class PROP_3d2714d8956940a69dee573acb64f3a0 : HardwiredMemberDescriptor
      {
        internal PROP_3d2714d8956940a69dee573acb64f3a0()
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

      private sealed class FLDV_159a923c7eb14d3daa06d656df5242c8 : HardwiredMemberDescriptor
      {
        internal FLDV_159a923c7eb14d3daa06d656df5242c8()
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

      private sealed class FLDV_c8904c9d1c59454ebb19a99c11543c55 : HardwiredMemberDescriptor
      {
        internal FLDV_c8904c9d1c59454ebb19a99c11543c55()
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

      private sealed class FLDV_f7eeda8d6fbd414eb12589c676a22b7a : HardwiredMemberDescriptor
      {
        internal FLDV_f7eeda8d6fbd414eb12589c676a22b7a()
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

    private sealed class TYPE_a2a6983aa4c4430ea21f2895da5f0c8d : HardwiredUserDataDescriptor
    {
      internal TYPE_a2a6983aa4c4430ea21f2895da5f0c8d()
        : base(typeof (MyPoll.Item))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a2a6983aa4c4430ea21f2895da5f0c8d.MTHD_24c89eae74a14d0c803e72a25d29dbb7()
        }));
        this.AddMember("addAnswer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addAnswer", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a2a6983aa4c4430ea21f2895da5f0c8d.MTHD_8ed806bc3c97415cb90075fbae00fc67()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a2a6983aa4c4430ea21f2895da5f0c8d.MTHD_f750238525a54364bbf65d52f4fad93d()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a2a6983aa4c4430ea21f2895da5f0c8d.MTHD_960cd4a6f8d840c49cae62a6c7ce5502()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a2a6983aa4c4430ea21f2895da5f0c8d.MTHD_270abd5776d8496580b5cd89164e6443()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a2a6983aa4c4430ea21f2895da5f0c8d.MTHD_ccaa1db3ff38473781d34e5d0104d141()
        }));
        this.AddMember("question", (IMemberDescriptor) new Bridge.TYPE_a2a6983aa4c4430ea21f2895da5f0c8d.FLDV_5d800afca2684b508f0eda85aa08d1aa());
        this.AddMember("multipleSelection", (IMemberDescriptor) new Bridge.TYPE_a2a6983aa4c4430ea21f2895da5f0c8d.FLDV_8aa8dd9289d246d9b6ff59b272d22ce9());
        this.AddMember("requiresAnswer", (IMemberDescriptor) new Bridge.TYPE_a2a6983aa4c4430ea21f2895da5f0c8d.FLDV_4223264206364f008441b6e23a82addf());
        this.AddMember("answers", (IMemberDescriptor) new Bridge.TYPE_a2a6983aa4c4430ea21f2895da5f0c8d.FLDV_cb7e032cc8e248e680b8d3836c5cb2b6());
      }

      private sealed class MTHD_24c89eae74a14d0c803e72a25d29dbb7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_24c89eae74a14d0c803e72a25d29dbb7()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Item();
        }
      }

      private sealed class MTHD_8ed806bc3c97415cb90075fbae00fc67 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8ed806bc3c97415cb90075fbae00fc67()
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

      private sealed class MTHD_f750238525a54364bbf65d52f4fad93d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f750238525a54364bbf65d52f4fad93d()
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

      private sealed class MTHD_960cd4a6f8d840c49cae62a6c7ce5502 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_960cd4a6f8d840c49cae62a6c7ce5502()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_270abd5776d8496580b5cd89164e6443 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_270abd5776d8496580b5cd89164e6443()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_ccaa1db3ff38473781d34e5d0104d141 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ccaa1db3ff38473781d34e5d0104d141()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_5d800afca2684b508f0eda85aa08d1aa : HardwiredMemberDescriptor
      {
        internal FLDV_5d800afca2684b508f0eda85aa08d1aa()
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

      private sealed class FLDV_8aa8dd9289d246d9b6ff59b272d22ce9 : HardwiredMemberDescriptor
      {
        internal FLDV_8aa8dd9289d246d9b6ff59b272d22ce9()
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

      private sealed class FLDV_4223264206364f008441b6e23a82addf : HardwiredMemberDescriptor
      {
        internal FLDV_4223264206364f008441b6e23a82addf()
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

      private sealed class FLDV_cb7e032cc8e248e680b8d3836c5cb2b6 : HardwiredMemberDescriptor
      {
        internal FLDV_cb7e032cc8e248e680b8d3836c5cb2b6()
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

    private sealed class TYPE_1a16ed1ca86b4e9cbfadc19af1733415 : HardwiredUserDataDescriptor
    {
      internal TYPE_1a16ed1ca86b4e9cbfadc19af1733415()
        : base(typeof (MyPoll.Answer))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1a16ed1ca86b4e9cbfadc19af1733415.MTHD_f5a8b0109fbb4f248d2354f58a1bf727()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1a16ed1ca86b4e9cbfadc19af1733415.MTHD_f9b5479f3d5b4862b2a1152cb3ce14ec()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1a16ed1ca86b4e9cbfadc19af1733415.MTHD_b5041019a3124eae9820d96ef5c14091()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1a16ed1ca86b4e9cbfadc19af1733415.MTHD_b43f5ab37bf44ac085ccdce12e5fa55f()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1a16ed1ca86b4e9cbfadc19af1733415.MTHD_40679aeb0056446a8c5d520b14d3ab5d()
        }));
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_1a16ed1ca86b4e9cbfadc19af1733415.FLDV_3319ce25562a47d698270b35d51a0224());
        this.AddMember("allowUserInput", (IMemberDescriptor) new Bridge.TYPE_1a16ed1ca86b4e9cbfadc19af1733415.FLDV_dc99113fe99448f0bc2afe3280231843());
        this.AddMember("checkable", (IMemberDescriptor) new Bridge.TYPE_1a16ed1ca86b4e9cbfadc19af1733415.FLDV_4b2604e5873c4eb3a589b0d831e67d0c());
        this.AddMember("userInput", (IMemberDescriptor) new Bridge.TYPE_1a16ed1ca86b4e9cbfadc19af1733415.FLDV_5b826e0334654e7abea04bb6e51e7bdf());
        this.AddMember("isChecked", (IMemberDescriptor) new Bridge.TYPE_1a16ed1ca86b4e9cbfadc19af1733415.FLDV_3e79d1bc8611482aaf766eec47fc34ba());
      }

      private sealed class MTHD_f5a8b0109fbb4f248d2354f58a1bf727 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f5a8b0109fbb4f248d2354f58a1bf727()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Answer();
        }
      }

      private sealed class MTHD_f9b5479f3d5b4862b2a1152cb3ce14ec : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f9b5479f3d5b4862b2a1152cb3ce14ec()
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

      private sealed class MTHD_b5041019a3124eae9820d96ef5c14091 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b5041019a3124eae9820d96ef5c14091()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_b43f5ab37bf44ac085ccdce12e5fa55f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b43f5ab37bf44ac085ccdce12e5fa55f()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_40679aeb0056446a8c5d520b14d3ab5d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_40679aeb0056446a8c5d520b14d3ab5d()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_3319ce25562a47d698270b35d51a0224 : HardwiredMemberDescriptor
      {
        internal FLDV_3319ce25562a47d698270b35d51a0224()
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

      private sealed class FLDV_dc99113fe99448f0bc2afe3280231843 : HardwiredMemberDescriptor
      {
        internal FLDV_dc99113fe99448f0bc2afe3280231843()
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

      private sealed class FLDV_4b2604e5873c4eb3a589b0d831e67d0c : HardwiredMemberDescriptor
      {
        internal FLDV_4b2604e5873c4eb3a589b0d831e67d0c()
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

      private sealed class FLDV_5b826e0334654e7abea04bb6e51e7bdf : HardwiredMemberDescriptor
      {
        internal FLDV_5b826e0334654e7abea04bb6e51e7bdf()
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

      private sealed class FLDV_3e79d1bc8611482aaf766eec47fc34ba : HardwiredMemberDescriptor
      {
        internal FLDV_3e79d1bc8611482aaf766eec47fc34ba()
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

    private sealed class TYPE_0def1c4b6d6c474590cae7ce0c6b09e3 : HardwiredUserDataDescriptor
    {
      internal TYPE_0def1c4b6d6c474590cae7ce0c6b09e3()
        : base(typeof (MyPoll))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0def1c4b6d6c474590cae7ce0c6b09e3.MTHD_4c94e5c614a34efdad131c2d3e0f595a()
        }));
        this.AddMember("GetQuestionsAsString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetQuestionsAsString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0def1c4b6d6c474590cae7ce0c6b09e3.MTHD_78036c8bd48f4c6cb44c9f8c54579ac4()
        }));
        this.AddMember("SanitizeResponses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("SanitizeResponses", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0def1c4b6d6c474590cae7ce0c6b09e3.MTHD_23058601e7794a8e93fa217db1ec2388()
        }));
        this.AddMember("addItem", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addItem", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0def1c4b6d6c474590cae7ce0c6b09e3.MTHD_057c2a8159544dc591fde55525d88c08()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0def1c4b6d6c474590cae7ce0c6b09e3.MTHD_3f58bdc1940d44d9ae862dc5c91820a6()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0def1c4b6d6c474590cae7ce0c6b09e3.MTHD_35f0b4c14cb9410dbda7c37e4b5f306b()
        }));
        this.AddMember("fromString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fromString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0def1c4b6d6c474590cae7ce0c6b09e3.MTHD_05a2393ed01f4983b81da51c44adbf93()
        }));
        this.AddMember("sendToServer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("sendToServer", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0def1c4b6d6c474590cae7ce0c6b09e3.MTHD_5e36a0356b7841498dc65dcbde4229bd()
        }));
        this.AddMember("closePoll", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("closePoll", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0def1c4b6d6c474590cae7ce0c6b09e3.MTHD_a88b467c9d4044e8925ed736c7968364()
        }));
        this.AddMember("test", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("test", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0def1c4b6d6c474590cae7ce0c6b09e3.MTHD_abcc67d0d49545599dd07ce166afa3ab()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0def1c4b6d6c474590cae7ce0c6b09e3.MTHD_f817ad8fe973417cab577c08c645c99c()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0def1c4b6d6c474590cae7ce0c6b09e3.MTHD_ad12591a3f004cf0beb9e17ea25706f2()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0def1c4b6d6c474590cae7ce0c6b09e3.MTHD_62d77aa92dd3428db7aff69dbd84253b()
        }));
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_0def1c4b6d6c474590cae7ce0c6b09e3.FLDV_728604e6b1c648f4a6886380ef1edc71());
        this.AddMember("id", (IMemberDescriptor) new Bridge.TYPE_0def1c4b6d6c474590cae7ce0c6b09e3.FLDV_fbb999d1e8df4a6dbdd255a988883be1());
        this.AddMember("items", (IMemberDescriptor) new Bridge.TYPE_0def1c4b6d6c474590cae7ce0c6b09e3.FLDV_5cde4901c80940a19f5d1517ba356363());
        this.AddMember("isPublic", (IMemberDescriptor) new Bridge.TYPE_0def1c4b6d6c474590cae7ce0c6b09e3.FLDV_3a98b7c5417a4feeb055c09f069bcbe8());
        this.AddMember("MsgRetrieve", (IMemberDescriptor) new Bridge.TYPE_0def1c4b6d6c474590cae7ce0c6b09e3.FLDV_8766eb17c22b4ddb92e540fa38892921());
        this.AddMember("MsgSubmit", (IMemberDescriptor) new Bridge.TYPE_0def1c4b6d6c474590cae7ce0c6b09e3.FLDV_a0b2f0476f6247e8927b0ded29f36b63());
        this.AddMember("MsgCreate", (IMemberDescriptor) new Bridge.TYPE_0def1c4b6d6c474590cae7ce0c6b09e3.FLDV_1311dbbd09ea4a20b68bba0fe2968ded());
        this.AddMember("MsgResults", (IMemberDescriptor) new Bridge.TYPE_0def1c4b6d6c474590cae7ce0c6b09e3.FLDV_a993c61ffdc1462bb34a469e6a10ee52());
        this.AddMember("Item", (IMemberDescriptor) new Bridge.TYPE_0def1c4b6d6c474590cae7ce0c6b09e3.DVAL_73ae9b73ac304eadad1c1cff78ab0f7a());
        this.AddMember("Answer", (IMemberDescriptor) new Bridge.TYPE_0def1c4b6d6c474590cae7ce0c6b09e3.DVAL_bc7c6051877c435d911d1ef2b26098ab());
      }

      private sealed class MTHD_4c94e5c614a34efdad131c2d3e0f595a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4c94e5c614a34efdad131c2d3e0f595a()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll();
        }
      }

      private sealed class MTHD_78036c8bd48f4c6cb44c9f8c54579ac4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_78036c8bd48f4c6cb44c9f8c54579ac4()
        {
          this.Initialize("GetQuestionsAsString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).GetQuestionsAsString();
        }
      }

      private sealed class MTHD_23058601e7794a8e93fa217db1ec2388 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_23058601e7794a8e93fa217db1ec2388()
        {
          this.Initialize("SanitizeResponses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).SanitizeResponses();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_057c2a8159544dc591fde55525d88c08 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_057c2a8159544dc591fde55525d88c08()
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

      private sealed class MTHD_3f58bdc1940d44d9ae862dc5c91820a6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3f58bdc1940d44d9ae862dc5c91820a6()
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

      private sealed class MTHD_35f0b4c14cb9410dbda7c37e4b5f306b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_35f0b4c14cb9410dbda7c37e4b5f306b()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).ToString();
        }
      }

      private sealed class MTHD_05a2393ed01f4983b81da51c44adbf93 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_05a2393ed01f4983b81da51c44adbf93()
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

      private sealed class MTHD_5e36a0356b7841498dc65dcbde4229bd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5e36a0356b7841498dc65dcbde4229bd()
        {
          this.Initialize("sendToServer", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).sendToServer();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_a88b467c9d4044e8925ed736c7968364 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a88b467c9d4044e8925ed736c7968364()
        {
          this.Initialize("closePoll", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          MyPoll.closePoll();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_abcc67d0d49545599dd07ce166afa3ab : HardwiredMethodMemberDescriptor
      {
        internal MTHD_abcc67d0d49545599dd07ce166afa3ab()
        {
          this.Initialize("test", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).test();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_f817ad8fe973417cab577c08c645c99c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f817ad8fe973417cab577c08c645c99c()
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

      private sealed class MTHD_ad12591a3f004cf0beb9e17ea25706f2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ad12591a3f004cf0beb9e17ea25706f2()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_62d77aa92dd3428db7aff69dbd84253b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_62d77aa92dd3428db7aff69dbd84253b()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_728604e6b1c648f4a6886380ef1edc71 : HardwiredMemberDescriptor
      {
        internal FLDV_728604e6b1c648f4a6886380ef1edc71()
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

      private sealed class FLDV_fbb999d1e8df4a6dbdd255a988883be1 : HardwiredMemberDescriptor
      {
        internal FLDV_fbb999d1e8df4a6dbdd255a988883be1()
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

      private sealed class FLDV_5cde4901c80940a19f5d1517ba356363 : HardwiredMemberDescriptor
      {
        internal FLDV_5cde4901c80940a19f5d1517ba356363()
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

      private sealed class FLDV_3a98b7c5417a4feeb055c09f069bcbe8 : HardwiredMemberDescriptor
      {
        internal FLDV_3a98b7c5417a4feeb055c09f069bcbe8()
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

      private sealed class FLDV_8766eb17c22b4ddb92e540fa38892921 : HardwiredMemberDescriptor
      {
        internal FLDV_8766eb17c22b4ddb92e540fa38892921()
          : base(typeof (byte), "MsgRetrieve", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 1;
        }
      }

      private sealed class FLDV_a0b2f0476f6247e8927b0ded29f36b63 : HardwiredMemberDescriptor
      {
        internal FLDV_a0b2f0476f6247e8927b0ded29f36b63()
          : base(typeof (byte), "MsgSubmit", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 2;
        }
      }

      private sealed class FLDV_1311dbbd09ea4a20b68bba0fe2968ded : HardwiredMemberDescriptor
      {
        internal FLDV_1311dbbd09ea4a20b68bba0fe2968ded()
          : base(typeof (byte), "MsgCreate", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 3;
        }
      }

      private sealed class FLDV_a993c61ffdc1462bb34a469e6a10ee52 : HardwiredMemberDescriptor
      {
        internal FLDV_a993c61ffdc1462bb34a469e6a10ee52()
          : base(typeof (byte), "MsgResults", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 4;
        }
      }

      private sealed class DVAL_73ae9b73ac304eadad1c1cff78ab0f7a : DynValueMemberDescriptor
      {
        internal DVAL_73ae9b73ac304eadad1c1cff78ab0f7a()
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

      private sealed class DVAL_bc7c6051877c435d911d1ef2b26098ab : DynValueMemberDescriptor
      {
        internal DVAL_bc7c6051877c435d911d1ef2b26098ab()
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

    private sealed class TYPE_95914849b5aa4edaa7fe64de41e6f6b1 : HardwiredUserDataDescriptor
    {
      internal TYPE_95914849b5aa4edaa7fe64de41e6f6b1()
        : base(typeof (LuaColor))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_95914849b5aa4edaa7fe64de41e6f6b1.MTHD_a840c598d1444a36817e612a2b2d9230()
        }));
        this.AddMember("toHex", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("toHex", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_95914849b5aa4edaa7fe64de41e6f6b1.MTHD_4e12520aca394a4da378e1d79b77339e()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_95914849b5aa4edaa7fe64de41e6f6b1.MTHD_bcf4f11fa36046ada95b61ce5b8d40eb(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_95914849b5aa4edaa7fe64de41e6f6b1.MTHD_e89d5744959a4c55bdb4fb024fb1b7ce()
        }));
        this.AddMember("From", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("From", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_95914849b5aa4edaa7fe64de41e6f6b1.MTHD_db0c9a6f788f4927b482615e035fb5cf(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_95914849b5aa4edaa7fe64de41e6f6b1.MTHD_5643576de6e74608892b46d8946a331b()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_95914849b5aa4edaa7fe64de41e6f6b1.MTHD_3d37bc8d382842f0a04bc1b5293c3728()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_95914849b5aa4edaa7fe64de41e6f6b1.MTHD_138f8e68feaa4f599ddf6e866a5dd1bc()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_95914849b5aa4edaa7fe64de41e6f6b1.MTHD_5016cfc9ccaf4755abebde7f1a62d871()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_95914849b5aa4edaa7fe64de41e6f6b1.MTHD_654e5c137ef649c8a0390bd786df4a97()
        }));
        this.AddMember("r", (IMemberDescriptor) new Bridge.TYPE_95914849b5aa4edaa7fe64de41e6f6b1.FLDV_b1d667e484d743e2878f80dcab5b3df1());
        this.AddMember("g", (IMemberDescriptor) new Bridge.TYPE_95914849b5aa4edaa7fe64de41e6f6b1.FLDV_534b6d52a6834dbd8b7ca171c17cf028());
        this.AddMember("b", (IMemberDescriptor) new Bridge.TYPE_95914849b5aa4edaa7fe64de41e6f6b1.FLDV_a2940a98c73141be8ada5e617daa57ff());
        this.AddMember("a", (IMemberDescriptor) new Bridge.TYPE_95914849b5aa4edaa7fe64de41e6f6b1.FLDV_3466d037dfb1402f9972697b123ea79d());
        this.AddMember("white", (IMemberDescriptor) new Bridge.TYPE_95914849b5aa4edaa7fe64de41e6f6b1.FLDV_5f36a05fea65418f9092e64b0f6ca162());
      }

      private sealed class MTHD_a840c598d1444a36817e612a2b2d9230 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a840c598d1444a36817e612a2b2d9230()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new LuaColor();
        }
      }

      private sealed class MTHD_4e12520aca394a4da378e1d79b77339e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4e12520aca394a4da378e1d79b77339e()
        {
          this.Initialize("toHex", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((LuaColor) obj).toHex();
        }
      }

      private sealed class MTHD_bcf4f11fa36046ada95b61ce5b8d40eb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bcf4f11fa36046ada95b61ce5b8d40eb()
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

      private sealed class MTHD_e89d5744959a4c55bdb4fb024fb1b7ce : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e89d5744959a4c55bdb4fb024fb1b7ce()
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

      private sealed class MTHD_db0c9a6f788f4927b482615e035fb5cf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_db0c9a6f788f4927b482615e035fb5cf()
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

      private sealed class MTHD_5643576de6e74608892b46d8946a331b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5643576de6e74608892b46d8946a331b()
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

      private sealed class MTHD_3d37bc8d382842f0a04bc1b5293c3728 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3d37bc8d382842f0a04bc1b5293c3728()
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

      private sealed class MTHD_138f8e68feaa4f599ddf6e866a5dd1bc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_138f8e68feaa4f599ddf6e866a5dd1bc()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_5016cfc9ccaf4755abebde7f1a62d871 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5016cfc9ccaf4755abebde7f1a62d871()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_654e5c137ef649c8a0390bd786df4a97 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_654e5c137ef649c8a0390bd786df4a97()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_b1d667e484d743e2878f80dcab5b3df1 : HardwiredMemberDescriptor
      {
        internal FLDV_b1d667e484d743e2878f80dcab5b3df1()
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

      private sealed class FLDV_534b6d52a6834dbd8b7ca171c17cf028 : HardwiredMemberDescriptor
      {
        internal FLDV_534b6d52a6834dbd8b7ca171c17cf028()
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

      private sealed class FLDV_a2940a98c73141be8ada5e617daa57ff : HardwiredMemberDescriptor
      {
        internal FLDV_a2940a98c73141be8ada5e617daa57ff()
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

      private sealed class FLDV_3466d037dfb1402f9972697b123ea79d : HardwiredMemberDescriptor
      {
        internal FLDV_3466d037dfb1402f9972697b123ea79d()
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

      private sealed class FLDV_5f36a05fea65418f9092e64b0f6ca162 : HardwiredMemberDescriptor
      {
        internal FLDV_5f36a05fea65418f9092e64b0f6ca162()
          : base(typeof (LuaColor), "white", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) LuaColor.white;
        }
      }
    }

    private sealed class TYPE_618224c4e7a54910995fc48f16312449 : HardwiredUserDataDescriptor
    {
      internal TYPE_618224c4e7a54910995fc48f16312449()
        : base(typeof (TalkOptions))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_618224c4e7a54910995fc48f16312449.MTHD_782447a94aef4acbb89d8b8d5e1e3c68()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_618224c4e7a54910995fc48f16312449.MTHD_0880967ad01942f99bf5312fcccda907()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_618224c4e7a54910995fc48f16312449.MTHD_5c555f3ad9eb42abb2d3ca77675c7225()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_618224c4e7a54910995fc48f16312449.MTHD_1c1035ef159642849bbb0292cc2b97ef()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_618224c4e7a54910995fc48f16312449.MTHD_dc4829168591408693923c1f8d6c914d()
        }));
      }

      private sealed class MTHD_782447a94aef4acbb89d8b8d5e1e3c68 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_782447a94aef4acbb89d8b8d5e1e3c68()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new TalkOptions();
        }
      }

      private sealed class MTHD_0880967ad01942f99bf5312fcccda907 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0880967ad01942f99bf5312fcccda907()
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

      private sealed class MTHD_5c555f3ad9eb42abb2d3ca77675c7225 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5c555f3ad9eb42abb2d3ca77675c7225()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_1c1035ef159642849bbb0292cc2b97ef : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1c1035ef159642849bbb0292cc2b97ef()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_dc4829168591408693923c1f8d6c914d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dc4829168591408693923c1f8d6c914d()
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
