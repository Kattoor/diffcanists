
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
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_b4a7a397f4b04af3bed5f2c9effe4fce());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_9e78cea92e7e420dbcd873db914e23c5());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_b1eb8448437047c080241cbd90d51a99());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_04793c50e8164d5aaaf90bac62bf1306());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_714124776a8c4271a7fa6ae42b8d45b2());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_b040c9735f764ce3a6497ba208a832eb());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_ad2b55cc1eaa4f2fa27cf990878849ff());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_a9e0ec7a4c944a1d9cfe617880c4b430());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_2fee70b8a3bd4e2fa2aeb1d4901aaf68());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_f2366f6bc0dc47648a80f3de380c0dac());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_3180108a70c94607a7eb760e2ab9279f());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_637167e11d77431dad8b07281596f882());
    }

    private sealed class TYPE_66d4394cd5ac444a82a0643a60f46faa : HardwiredUserDataDescriptor
    {
      internal TYPE_66d4394cd5ac444a82a0643a60f46faa()
        : base(typeof (ContainerGame))
      {
        this.AddMember("getUser", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getUser", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_31a09ad11a964430afe4916ca29050c2()
        }));
        this.AddMember("getPlayers", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayers", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_0c0e970e465b4d8da1bd025d26ef4f9b()
        }));
        this.AddMember("getPlayerCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayerCount", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_4868ae8be0384dd58198eb5fe8815e82()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_fbc5b206461642a99cf0251bd97532ee()
        }));
        this.AddMember("findCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_27dd06cef66448b7924432e06c50d6b1()
        }));
        this.AddMember("findEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findEffectors", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_eafa5edcaa41457a9a282aef656ced14()
        }));
        this.AddMember("LineCast", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCast", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_7c8569200e5248d18c2f1f4ac37e7f5e()
        }));
        this.AddMember("LineCastOnlyCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_8c3ee41949f147ce812e8d2cff1c2a37()
        }));
        this.AddMember("LineCastOnlyTerrain", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyTerrain", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_173767a90ea94f798df834e289f29a5b()
        }));
        this.AddMember("ShowInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ShowInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_95e5d54ef226417787bcd5b6fded4456()
        }));
        this.AddMember("hideInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("hideInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_0d87129436b44370ad78e11ae4714926()
        }));
        this.AddMember("Talk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Talk", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_e791431d6a7145489f3905d2ef7736b5()
        }));
        this.AddMember("get_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_c2c3d343aa51470cb4e12667efecdfb6()
        }));
        this.AddMember("set_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_ba4a1914fc31452cb8f23027a100dfcc()
        }));
        this.AddMember("get_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_a4bcc4e585314417b9522a0a8587c818()
        }));
        this.AddMember("set_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_08bfff06c9264148889d000e66e6e5b9()
        }));
        this.AddMember("get_totalTimeElapsed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_totalTimeElapsed", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_c0a6b2308cb840bfa74d9ce4e9f28c05()
        }));
        this.AddMember("get_turnTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnTime", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_40f1e4edb1cc46cea406b92242d7e49f()
        }));
        this.AddMember("get_frame", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frame", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_8a04d5d6ff354e4d9f757f983d18e989()
        }));
        this.AddMember("random", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("random", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_52312c84a3bb41faa6278c9d5ff53fe0()
        }));
        this.AddMember("get_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_da57d3dc888c477c9017182c385c23bd()
        }));
        this.AddMember("set_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_2bd275718e6644cc965d98e5cff9c425()
        }));
        this.AddMember("get_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_f3bddcb4921c44d4a3486f552cb0f3a3()
        }));
        this.AddMember("set_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_dd5a0cf5a0194de488a949659803091f()
        }));
        this.AddMember("get_allowMinionMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMinionMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_69207aff450645e2a12de56a66e89b93()
        }));
        this.AddMember("set_allowMinionMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMinionMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_d0acb1c904ed4a398272fcac3f42e6b9()
        }));
        this.AddMember("get_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_941b905873f64a41b88be73497640dac()
        }));
        this.AddMember("set_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_c34c92397fca47ccb286d8bb5af4b6df()
        }));
        this.AddMember("get_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_679fa5096ec04dbbbdb76c9ad2b49fb6()
        }));
        this.AddMember("set_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_f60f51a5aaa848e09542ad978ddd2a4b()
        }));
        this.AddMember("get_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_35405c49968c4d5da753a07194290f7c()
        }));
        this.AddMember("set_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_148ace85fed54473bb7148e26e19732e()
        }));
        this.AddMember("get_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_819670634b3343bc966d20239abf1a0a()
        }));
        this.AddMember("set_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_59203364ea194090b5bf20614db808ae()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_9174924a5f524c90a5a9ac24f727fc98()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_f1a000256f0945ebaea45552a5d8ebb1()
        }));
        this.AddMember("get_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_ef3af91174f94e8f90b0fbc3e8dccf90()
        }));
        this.AddMember("set_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_a5a4933c0f454fb1b65d3eb9810f9b08()
        }));
        this.AddMember("get_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_991a35c8db334ec4b4f888775ec70a4e()
        }));
        this.AddMember("set_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_b4f15ffd1e0e42419ff5c5fd1c3852a2()
        }));
        this.AddMember("get_waiting", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waiting", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_64c0cb32ac1c4ff788e9848b36c94215()
        }));
        this.AddMember("get_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_b15fa354b9a94e739df3867476eec6f4()
        }));
        this.AddMember("set_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_ed749b5b4047415bac227384434916a6()
        }));
        this.AddMember("get_busy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_busy", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_965c39cd200d437daac4c9a25172e878()
        }));
        this.AddMember("get_ongoing", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_ongoing", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_e49e423412074686911b1ba8379373c6()
        }));
        this.AddMember("get_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_ddc4b3ec6c22448e91ef35d4c2638f53()
        }));
        this.AddMember("set_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_dfae7cc3d2e14e8797cd88ad38d350c0()
        }));
        this.AddMember("get_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_8a307b5225c64e618bf6fd46df486c77()
        }));
        this.AddMember("set_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_014726faf7134d64a971207645c2127b()
        }));
        this.AddMember("get_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_d6e6665a27cc41ef946dd840b835c41b()
        }));
        this.AddMember("set_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_fb0ec2be46d844d29f71820543465546()
        }));
        this.AddMember("get_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_a6de89d079d14dc6a49e1dcfeaccc636()
        }));
        this.AddMember("set_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_50f882f095f94092a75893d0fd215788()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_c9adbb86aaf1447ebd9745039a16f83d()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_b0ac044390634d868a31271675ad0052()
        }));
        this.AddMember("get_mousePosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mousePosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_5c2f959c3c3845afbff2aa625cff05a8()
        }));
        this.AddMember("get_mouseOverUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mouseOverUI", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_aef71b161b8346ed905266444e325bc4()
        }));
        this.AddMember("worldToCanvas", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("worldToCanvas", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_8b9eb0a25b694ffe8cefdd309f7b22a8()
        }));
        this.AddMember("canvasToWorld", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("canvasToWorld", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_3f2d4f41fa6e4120b176b8d49b8889d4()
        }));
        this.AddMember("get_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_6e56ce681167498090dac1eed0767ff0()
        }));
        this.AddMember("set_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_bb33fac6b3ad44d0b9bf7481ad5e1e99()
        }));
        this.AddMember("get_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_9aba257b0c59404ab37275b666e618b5()
        }));
        this.AddMember("set_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_223830f94e9e4a268fc1bd4407412856()
        }));
        this.AddMember("getMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_abdcdba0d9f74d0f9308b15dd47b60b7()
        }));
        this.AddMember("setMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_85fda6d892b04ff8ba1e8612f423e1d1()
        }));
        this.AddMember("Dispose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Dispose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_6ca20470a1764ca193c38d2e44d28724()
        }));
        this.AddMember("drawImage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawImage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_476dfadeb9b1494f903585df1560be4e()
        }));
        this.AddMember("drawRectangle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawRectangle", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_942c5b6d6e6f4d6689ccf600a99a1fa8()
        }));
        this.AddMember("drawEllipseOutline", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipseOutline", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_b2a0f5b09ab848019dd37ca6e94eb5d3()
        }));
        this.AddMember("drawEllipse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipse", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_5d196eb570ec43e0a4fb679418d7b485()
        }));
        this.AddMember("blit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_b9d380f6c448427fbf0ae3667a2758bb()
        }));
        this.AddMember("blitRotate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blitRotate", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_f70937c5bd5147e3930b33021ee70dfd()
        }));
        this.AddMember("applyDraw", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("applyDraw", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_4d1775bfcb804bfe8a0bf4a753db04a8()
        }));
        this.AddMember("get_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_c244a8f9361d43468f9b13a7bf994185()
        }));
        this.AddMember("set_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_f92fbd16f0924ba092d2cad9f33a8127()
        }));
        this.AddMember("get_isUsingTouchControls", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isUsingTouchControls", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_5724543de86b4d28a16a407e52efd224()
        }));
        this.AddMember("clientRefreshSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clientRefreshSpells", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_143fac85d6894625b27f9ee2c7382365()
        }));
        this.AddMember("startCoroutine", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("startCoroutine", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_9948e6fade9f453da936066c8a9c4156()
        }));
        this.AddMember("devCommand", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("devCommand", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_018637e7ab64473c9f17e7272eb2a8ed()
        }));
        this.AddMember("win", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("win", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_61cbacacc897416f81d59df3dcafc476()
        }));
        this.AddMember("lose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("lose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_84edd712ce844ee69a1e524e499852bb()
        }));
        this.AddMember("nextTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("nextTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_b2bf80f6b9524c489718bb741419e752()
        }));
        this.AddMember("resetMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("resetMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_87ebb2b9cb814c94a056b1cde36df095()
        }));
        this.AddMember("clearMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_328838d65782438894dccd5010cb58ac()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_bf02ba97b0d7484abe5873b80337e80f()
        }));
        this.AddMember("getSpellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellEnum", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_978d68c3d646442d9d42c44912d6ef27()
        }));
        this.AddMember("getSpellName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_7682bf47cb364775bf6bbd3424b1f053()
        }));
        this.AddMember("getMapID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapID", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_900f244cfefe445fb3901c2671485fa2()
        }));
        this.AddMember("getMapRealName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapRealName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_6b4da38dd0cd495682d7ca5daa0ea556()
        }));
        this.AddMember("getMapShortName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapShortName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_f4e63372326c454aac231cfeb3548032()
        }));
        this.AddMember("getArmageddonName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getArmageddonName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_d4cff97bf4b54ac9b3ae66066b30b577()
        }));
        this.AddMember("panCamera", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("panCamera", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_5531ee6a4a5b4a77ba38dcf222c147bd()
        }));
        this.AddMember("cameraFollow", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("cameraFollow", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_678469d66ab443c0acee38f80eb4d2a0()
        }));
        this.AddMember("getInputString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getInputString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_67fa25913b9449cc947e67175989d24e()
        }));
        this.AddMember("get_screenWidth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenWidth", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_c5b31e0f6bf241dbbe1eef2a4c8a39bc()
        }));
        this.AddMember("get_screenHeight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenHeight", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_12f098d58f6a405396249080ff99d801()
        }));
        this.AddMember("createCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createCreature", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_b4bb7bd9e39a43dd8c2c2b50689ad763()
        }));
        this.AddMember("clearIndicators", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearIndicators", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_39e386645546476385b80db7fd04b54b()
        }));
        this.AddMember("createIndicator", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createIndicator", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_8c55deee4a3f46339ade48765e71bd75(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_d4e096768eb64e7f9af84a997d4b7cd4()
        }));
        this.AddMember("getKeyBinds", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getKeyBinds", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_1b77a2e2812e41e5ae673d22d1ffca4f()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_82421dec76234ec1a4aaffd0452f0237()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_b2615e71d51b45159f266712eb1f44be()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_c01f3d8575f74bb18c88b57ae9ecd4d8()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.MTHD_e9704baffb924da7a2f96734f09e1dc0()
        }));
        this.AddMember("turn", (IMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.PROP_7f912c67619f4c1a8827db0339050917());
        this.AddMember("timeLimit", (IMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.PROP_754cd795e04f49c9a96f8d8ee38868ec());
        this.AddMember("totalTimeElapsed", (IMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.PROP_0421c540f923467e8e7e41f1315d4155());
        this.AddMember("turnTime", (IMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.PROP_eef9423f2f1c4dd08ef6acb2dbc5da51());
        this.AddMember("frame", (IMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.PROP_be6dbfda678f49aba32943a9bf4a5e88());
        this.AddMember("winOnDeath", (IMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.PROP_98f5443b1e4646bc9b18b48d9c3fb093());
        this.AddMember("allowMovement", (IMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.PROP_e8117a1ed2b7495287f8b50ed3f4de3a());
        this.AddMember("allowMinionMovement", (IMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.PROP_03b74a340fad48368d424daee3e81fcb());
        this.AddMember("allowInput", (IMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.PROP_c696f47e05c04e05be90b70006f67334());
        this.AddMember("allowCallbacks", (IMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.PROP_5f72f60868f44afb964fbd1d5262e3b9());
        this.AddMember("allowSkipTurn", (IMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.PROP_b903a3876dc74931b607d1010d4d84e7());
        this.AddMember("terrainDestruction", (IMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.PROP_c9c390494ef0469195e2aba39c891beb());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.PROP_e724bc509e894b7b8c9ab440988d0a3c());
        this.AddMember("armageddon", (IMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.PROP_acf0f33007ed4439902f1fa5ceac91d9());
        this.AddMember("armageddonTurn", (IMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.PROP_8cd8c0657c9747aeb22843d71319cbe4());
        this.AddMember("waiting", (IMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.PROP_a4edd60d135142afbf94c21d285e0f0b());
        this.AddMember("paused", (IMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.PROP_aac3f85fba9244f1bff434b59f350570());
        this.AddMember("busy", (IMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.PROP_74c8a83065c84e13bce92e92d4dfc253());
        this.AddMember("ongoing", (IMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.PROP_8ce69efd748f41c98acab4ef82ffb82d());
        this.AddMember("gravity", (IMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.PROP_08c16a043b9845b8b1f0214af0936ce2());
        this.AddMember("wind", (IMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.PROP_9630ade491f044ba84cea7b9db36a794());
        this.AddMember("windDir", (IMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.PROP_8dc1f4d06c7b4d50b1ee493b05a63f3f());
        this.AddMember("windPower", (IMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.PROP_5433b87479a546bb88922819a09dc07d());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.PROP_5d4470921cee4a0c9c4808d072295375());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.PROP_ce3be6350dd9417e84d6809f997a9036());
        this.AddMember("mousePosition", (IMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.PROP_f8afb61eb4bf4fa3bcd42d4b04d09b59());
        this.AddMember("mouseOverUI", (IMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.PROP_41aefb25798f47309ee96c95fec619a8());
        this.AddMember("cameraPosition", (IMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.PROP_c00842cbb5f247bf94cac23080684427());
        this.AddMember("cameraZoom", (IMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.PROP_f0a869a05196472da75b2225fc623895());
        this.AddMember("allowBounce", (IMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.PROP_8b38787ada94428597d3f17abd424d22());
        this.AddMember("isUsingTouchControls", (IMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.PROP_cab4b6eb57714dfbba3f6ce18df090b4());
        this.AddMember("screenWidth", (IMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.PROP_76d35708c30e4e9a9109a14108b87148());
        this.AddMember("screenHeight", (IMemberDescriptor) new Bridge.TYPE_66d4394cd5ac444a82a0643a60f46faa.PROP_57337d578496492fb742b798b0f5a005());
      }

      private sealed class MTHD_31a09ad11a964430afe4916ca29050c2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_31a09ad11a964430afe4916ca29050c2()
        {
          this.Initialize("getUser", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getUser();
        }
      }

      private sealed class MTHD_0c0e970e465b4d8da1bd025d26ef4f9b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0c0e970e465b4d8da1bd025d26ef4f9b()
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

      private sealed class MTHD_4868ae8be0384dd58198eb5fe8815e82 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4868ae8be0384dd58198eb5fe8815e82()
        {
          this.Initialize("getPlayerCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getPlayerCount();
        }
      }

      private sealed class MTHD_fbc5b206461642a99cf0251bd97532ee : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fbc5b206461642a99cf0251bd97532ee()
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

      private sealed class MTHD_27dd06cef66448b7924432e06c50d6b1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_27dd06cef66448b7924432e06c50d6b1()
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

      private sealed class MTHD_eafa5edcaa41457a9a282aef656ced14 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eafa5edcaa41457a9a282aef656ced14()
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

      private sealed class MTHD_7c8569200e5248d18c2f1f4ac37e7f5e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7c8569200e5248d18c2f1f4ac37e7f5e()
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

      private sealed class MTHD_8c3ee41949f147ce812e8d2cff1c2a37 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8c3ee41949f147ce812e8d2cff1c2a37()
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

      private sealed class MTHD_173767a90ea94f798df834e289f29a5b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_173767a90ea94f798df834e289f29a5b()
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

      private sealed class MTHD_95e5d54ef226417787bcd5b6fded4456 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_95e5d54ef226417787bcd5b6fded4456()
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

      private sealed class MTHD_0d87129436b44370ad78e11ae4714926 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0d87129436b44370ad78e11ae4714926()
        {
          this.Initialize("hideInfo", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).hideInfo();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_e791431d6a7145489f3905d2ef7736b5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e791431d6a7145489f3905d2ef7736b5()
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

      private sealed class MTHD_c2c3d343aa51470cb4e12667efecdfb6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c2c3d343aa51470cb4e12667efecdfb6()
        {
          this.Initialize("get_turn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turn;
        }
      }

      private sealed class MTHD_ba4a1914fc31452cb8f23027a100dfcc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ba4a1914fc31452cb8f23027a100dfcc()
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

      private sealed class MTHD_a4bcc4e585314417b9522a0a8587c818 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a4bcc4e585314417b9522a0a8587c818()
        {
          this.Initialize("get_timeLimit", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).timeLimit;
        }
      }

      private sealed class MTHD_08bfff06c9264148889d000e66e6e5b9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_08bfff06c9264148889d000e66e6e5b9()
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

      private sealed class MTHD_c0a6b2308cb840bfa74d9ce4e9f28c05 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c0a6b2308cb840bfa74d9ce4e9f28c05()
        {
          this.Initialize("get_totalTimeElapsed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class MTHD_40f1e4edb1cc46cea406b92242d7e49f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_40f1e4edb1cc46cea406b92242d7e49f()
        {
          this.Initialize("get_turnTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class MTHD_8a04d5d6ff354e4d9f757f983d18e989 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8a04d5d6ff354e4d9f757f983d18e989()
        {
          this.Initialize("get_frame", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class MTHD_52312c84a3bb41faa6278c9d5ff53fe0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_52312c84a3bb41faa6278c9d5ff53fe0()
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

      private sealed class MTHD_da57d3dc888c477c9017182c385c23bd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_da57d3dc888c477c9017182c385c23bd()
        {
          this.Initialize("get_winOnDeath", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).winOnDeath;
        }
      }

      private sealed class MTHD_2bd275718e6644cc965d98e5cff9c425 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2bd275718e6644cc965d98e5cff9c425()
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

      private sealed class MTHD_f3bddcb4921c44d4a3486f552cb0f3a3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f3bddcb4921c44d4a3486f552cb0f3a3()
        {
          this.Initialize("get_allowMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMovement;
        }
      }

      private sealed class MTHD_dd5a0cf5a0194de488a949659803091f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dd5a0cf5a0194de488a949659803091f()
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

      private sealed class MTHD_69207aff450645e2a12de56a66e89b93 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_69207aff450645e2a12de56a66e89b93()
        {
          this.Initialize("get_allowMinionMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMinionMovement;
        }
      }

      private sealed class MTHD_d0acb1c904ed4a398272fcac3f42e6b9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d0acb1c904ed4a398272fcac3f42e6b9()
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

      private sealed class MTHD_941b905873f64a41b88be73497640dac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_941b905873f64a41b88be73497640dac()
        {
          this.Initialize("get_allowInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowInput;
        }
      }

      private sealed class MTHD_c34c92397fca47ccb286d8bb5af4b6df : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c34c92397fca47ccb286d8bb5af4b6df()
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

      private sealed class MTHD_679fa5096ec04dbbbdb76c9ad2b49fb6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_679fa5096ec04dbbbdb76c9ad2b49fb6()
        {
          this.Initialize("get_allowCallbacks", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowCallbacks;
        }
      }

      private sealed class MTHD_f60f51a5aaa848e09542ad978ddd2a4b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f60f51a5aaa848e09542ad978ddd2a4b()
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

      private sealed class MTHD_35405c49968c4d5da753a07194290f7c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_35405c49968c4d5da753a07194290f7c()
        {
          this.Initialize("get_allowSkipTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowSkipTurn;
        }
      }

      private sealed class MTHD_148ace85fed54473bb7148e26e19732e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_148ace85fed54473bb7148e26e19732e()
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

      private sealed class MTHD_819670634b3343bc966d20239abf1a0a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_819670634b3343bc966d20239abf1a0a()
        {
          this.Initialize("get_terrainDestruction", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).terrainDestruction;
        }
      }

      private sealed class MTHD_59203364ea194090b5bf20614db808ae : HardwiredMethodMemberDescriptor
      {
        internal MTHD_59203364ea194090b5bf20614db808ae()
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

      private sealed class MTHD_9174924a5f524c90a5a9ac24f727fc98 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9174924a5f524c90a5a9ac24f727fc98()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).takeDamage;
        }
      }

      private sealed class MTHD_f1a000256f0945ebaea45552a5d8ebb1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f1a000256f0945ebaea45552a5d8ebb1()
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

      private sealed class MTHD_ef3af91174f94e8f90b0fbc3e8dccf90 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ef3af91174f94e8f90b0fbc3e8dccf90()
        {
          this.Initialize("get_armageddon", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddon;
        }
      }

      private sealed class MTHD_a5a4933c0f454fb1b65d3eb9810f9b08 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a5a4933c0f454fb1b65d3eb9810f9b08()
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

      private sealed class MTHD_991a35c8db334ec4b4f888775ec70a4e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_991a35c8db334ec4b4f888775ec70a4e()
        {
          this.Initialize("get_armageddonTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddonTurn;
        }
      }

      private sealed class MTHD_b4f15ffd1e0e42419ff5c5fd1c3852a2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b4f15ffd1e0e42419ff5c5fd1c3852a2()
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

      private sealed class MTHD_64c0cb32ac1c4ff788e9848b36c94215 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_64c0cb32ac1c4ff788e9848b36c94215()
        {
          this.Initialize("get_waiting", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class MTHD_b15fa354b9a94e739df3867476eec6f4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b15fa354b9a94e739df3867476eec6f4()
        {
          this.Initialize("get_paused", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).paused;
        }
      }

      private sealed class MTHD_ed749b5b4047415bac227384434916a6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ed749b5b4047415bac227384434916a6()
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

      private sealed class MTHD_965c39cd200d437daac4c9a25172e878 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_965c39cd200d437daac4c9a25172e878()
        {
          this.Initialize("get_busy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class MTHD_e49e423412074686911b1ba8379373c6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e49e423412074686911b1ba8379373c6()
        {
          this.Initialize("get_ongoing", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class MTHD_ddc4b3ec6c22448e91ef35d4c2638f53 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ddc4b3ec6c22448e91ef35d4c2638f53()
        {
          this.Initialize("get_gravity", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).gravity;
        }
      }

      private sealed class MTHD_dfae7cc3d2e14e8797cd88ad38d350c0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dfae7cc3d2e14e8797cd88ad38d350c0()
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

      private sealed class MTHD_8a307b5225c64e618bf6fd46df486c77 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8a307b5225c64e618bf6fd46df486c77()
        {
          this.Initialize("get_wind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).wind;
        }
      }

      private sealed class MTHD_014726faf7134d64a971207645c2127b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_014726faf7134d64a971207645c2127b()
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

      private sealed class MTHD_d6e6665a27cc41ef946dd840b835c41b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d6e6665a27cc41ef946dd840b835c41b()
        {
          this.Initialize("get_windDir", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windDir;
        }
      }

      private sealed class MTHD_fb0ec2be46d844d29f71820543465546 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fb0ec2be46d844d29f71820543465546()
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

      private sealed class MTHD_a6de89d079d14dc6a49e1dcfeaccc636 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a6de89d079d14dc6a49e1dcfeaccc636()
        {
          this.Initialize("get_windPower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windPower;
        }
      }

      private sealed class MTHD_50f882f095f94092a75893d0fd215788 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_50f882f095f94092a75893d0fd215788()
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

      private sealed class MTHD_c9adbb86aaf1447ebd9745039a16f83d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c9adbb86aaf1447ebd9745039a16f83d()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class MTHD_b0ac044390634d868a31271675ad0052 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b0ac044390634d868a31271675ad0052()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class MTHD_5c2f959c3c3845afbff2aa625cff05a8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5c2f959c3c3845afbff2aa625cff05a8()
        {
          this.Initialize("get_mousePosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class MTHD_aef71b161b8346ed905266444e325bc4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aef71b161b8346ed905266444e325bc4()
        {
          this.Initialize("get_mouseOverUI", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class MTHD_8b9eb0a25b694ffe8cefdd309f7b22a8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8b9eb0a25b694ffe8cefdd309f7b22a8()
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

      private sealed class MTHD_3f2d4f41fa6e4120b176b8d49b8889d4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3f2d4f41fa6e4120b176b8d49b8889d4()
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

      private sealed class MTHD_6e56ce681167498090dac1eed0767ff0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6e56ce681167498090dac1eed0767ff0()
        {
          this.Initialize("get_cameraPosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraPosition;
        }
      }

      private sealed class MTHD_bb33fac6b3ad44d0b9bf7481ad5e1e99 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bb33fac6b3ad44d0b9bf7481ad5e1e99()
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

      private sealed class MTHD_9aba257b0c59404ab37275b666e618b5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9aba257b0c59404ab37275b666e618b5()
        {
          this.Initialize("get_cameraZoom", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraZoom;
        }
      }

      private sealed class MTHD_223830f94e9e4a268fc1bd4407412856 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_223830f94e9e4a268fc1bd4407412856()
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

      private sealed class MTHD_abdcdba0d9f74d0f9308b15dd47b60b7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_abdcdba0d9f74d0f9308b15dd47b60b7()
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

      private sealed class MTHD_85fda6d892b04ff8ba1e8612f423e1d1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_85fda6d892b04ff8ba1e8612f423e1d1()
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

      private sealed class MTHD_6ca20470a1764ca193c38d2e44d28724 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6ca20470a1764ca193c38d2e44d28724()
        {
          this.Initialize("Dispose", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ContainerGame.Dispose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_476dfadeb9b1494f903585df1560be4e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_476dfadeb9b1494f903585df1560be4e()
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

      private sealed class MTHD_942c5b6d6e6f4d6689ccf600a99a1fa8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_942c5b6d6e6f4d6689ccf600a99a1fa8()
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

      private sealed class MTHD_b2a0f5b09ab848019dd37ca6e94eb5d3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b2a0f5b09ab848019dd37ca6e94eb5d3()
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

      private sealed class MTHD_5d196eb570ec43e0a4fb679418d7b485 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5d196eb570ec43e0a4fb679418d7b485()
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

      private sealed class MTHD_b9d380f6c448427fbf0ae3667a2758bb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b9d380f6c448427fbf0ae3667a2758bb()
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

      private sealed class MTHD_f70937c5bd5147e3930b33021ee70dfd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f70937c5bd5147e3930b33021ee70dfd()
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

      private sealed class MTHD_4d1775bfcb804bfe8a0bf4a753db04a8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4d1775bfcb804bfe8a0bf4a753db04a8()
        {
          this.Initialize("applyDraw", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).applyDraw();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_c244a8f9361d43468f9b13a7bf994185 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c244a8f9361d43468f9b13a7bf994185()
        {
          this.Initialize("get_allowBounce", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowBounce;
        }
      }

      private sealed class MTHD_f92fbd16f0924ba092d2cad9f33a8127 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f92fbd16f0924ba092d2cad9f33a8127()
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

      private sealed class MTHD_5724543de86b4d28a16a407e52efd224 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5724543de86b4d28a16a407e52efd224()
        {
          this.Initialize("get_isUsingTouchControls", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class MTHD_143fac85d6894625b27f9ee2c7382365 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_143fac85d6894625b27f9ee2c7382365()
        {
          this.Initialize("clientRefreshSpells", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clientRefreshSpells();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_9948e6fade9f453da936066c8a9c4156 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9948e6fade9f453da936066c8a9c4156()
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

      private sealed class MTHD_018637e7ab64473c9f17e7272eb2a8ed : HardwiredMethodMemberDescriptor
      {
        internal MTHD_018637e7ab64473c9f17e7272eb2a8ed()
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

      private sealed class MTHD_61cbacacc897416f81d59df3dcafc476 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_61cbacacc897416f81d59df3dcafc476()
        {
          this.Initialize("win", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).win();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_84edd712ce844ee69a1e524e499852bb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_84edd712ce844ee69a1e524e499852bb()
        {
          this.Initialize("lose", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).lose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_b2bf80f6b9524c489718bb741419e752 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b2bf80f6b9524c489718bb741419e752()
        {
          this.Initialize("nextTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).nextTurn();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_87ebb2b9cb814c94a056b1cde36df095 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_87ebb2b9cb814c94a056b1cde36df095()
        {
          this.Initialize("resetMap", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).resetMap();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_328838d65782438894dccd5010cb58ac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_328838d65782438894dccd5010cb58ac()
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

      private sealed class MTHD_bf02ba97b0d7484abe5873b80337e80f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bf02ba97b0d7484abe5873b80337e80f()
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

      private sealed class MTHD_978d68c3d646442d9d42c44912d6ef27 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_978d68c3d646442d9d42c44912d6ef27()
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

      private sealed class MTHD_7682bf47cb364775bf6bbd3424b1f053 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7682bf47cb364775bf6bbd3424b1f053()
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

      private sealed class MTHD_900f244cfefe445fb3901c2671485fa2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_900f244cfefe445fb3901c2671485fa2()
        {
          this.Initialize("getMapID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getMapID();
        }
      }

      private sealed class MTHD_6b4da38dd0cd495682d7ca5daa0ea556 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6b4da38dd0cd495682d7ca5daa0ea556()
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

      private sealed class MTHD_f4e63372326c454aac231cfeb3548032 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f4e63372326c454aac231cfeb3548032()
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

      private sealed class MTHD_d4cff97bf4b54ac9b3ae66066b30b577 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d4cff97bf4b54ac9b3ae66066b30b577()
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

      private sealed class MTHD_5531ee6a4a5b4a77ba38dcf222c147bd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5531ee6a4a5b4a77ba38dcf222c147bd()
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

      private sealed class MTHD_678469d66ab443c0acee38f80eb4d2a0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_678469d66ab443c0acee38f80eb4d2a0()
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

      private sealed class MTHD_67fa25913b9449cc947e67175989d24e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_67fa25913b9449cc947e67175989d24e()
        {
          this.Initialize("getInputString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getInputString();
        }
      }

      private sealed class MTHD_c5b31e0f6bf241dbbe1eef2a4c8a39bc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c5b31e0f6bf241dbbe1eef2a4c8a39bc()
        {
          this.Initialize("get_screenWidth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class MTHD_12f098d58f6a405396249080ff99d801 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_12f098d58f6a405396249080ff99d801()
        {
          this.Initialize("get_screenHeight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }

      private sealed class MTHD_b4bb7bd9e39a43dd8c2c2b50689ad763 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b4bb7bd9e39a43dd8c2c2b50689ad763()
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

      private sealed class MTHD_39e386645546476385b80db7fd04b54b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_39e386645546476385b80db7fd04b54b()
        {
          this.Initialize("clearIndicators", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clearIndicators();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_8c55deee4a3f46339ade48765e71bd75 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8c55deee4a3f46339ade48765e71bd75()
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

      private sealed class MTHD_d4e096768eb64e7f9af84a997d4b7cd4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d4e096768eb64e7f9af84a997d4b7cd4()
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

      private sealed class MTHD_1b77a2e2812e41e5ae673d22d1ffca4f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1b77a2e2812e41e5ae673d22d1ffca4f()
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

      private sealed class MTHD_82421dec76234ec1a4aaffd0452f0237 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_82421dec76234ec1a4aaffd0452f0237()
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

      private sealed class MTHD_b2615e71d51b45159f266712eb1f44be : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b2615e71d51b45159f266712eb1f44be()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_c01f3d8575f74bb18c88b57ae9ecd4d8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c01f3d8575f74bb18c88b57ae9ecd4d8()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_e9704baffb924da7a2f96734f09e1dc0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e9704baffb924da7a2f96734f09e1dc0()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_7f912c67619f4c1a8827db0339050917 : HardwiredMemberDescriptor
      {
        internal PROP_7f912c67619f4c1a8827db0339050917()
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

      private sealed class PROP_754cd795e04f49c9a96f8d8ee38868ec : HardwiredMemberDescriptor
      {
        internal PROP_754cd795e04f49c9a96f8d8ee38868ec()
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

      private sealed class PROP_0421c540f923467e8e7e41f1315d4155 : HardwiredMemberDescriptor
      {
        internal PROP_0421c540f923467e8e7e41f1315d4155()
          : base(typeof (double), "totalTimeElapsed", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class PROP_eef9423f2f1c4dd08ef6acb2dbc5da51 : HardwiredMemberDescriptor
      {
        internal PROP_eef9423f2f1c4dd08ef6acb2dbc5da51()
          : base(typeof (double), "turnTime", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class PROP_be6dbfda678f49aba32943a9bf4a5e88 : HardwiredMemberDescriptor
      {
        internal PROP_be6dbfda678f49aba32943a9bf4a5e88()
          : base(typeof (int), "frame", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class PROP_98f5443b1e4646bc9b18b48d9c3fb093 : HardwiredMemberDescriptor
      {
        internal PROP_98f5443b1e4646bc9b18b48d9c3fb093()
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

      private sealed class PROP_e8117a1ed2b7495287f8b50ed3f4de3a : HardwiredMemberDescriptor
      {
        internal PROP_e8117a1ed2b7495287f8b50ed3f4de3a()
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

      private sealed class PROP_03b74a340fad48368d424daee3e81fcb : HardwiredMemberDescriptor
      {
        internal PROP_03b74a340fad48368d424daee3e81fcb()
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

      private sealed class PROP_c696f47e05c04e05be90b70006f67334 : HardwiredMemberDescriptor
      {
        internal PROP_c696f47e05c04e05be90b70006f67334()
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

      private sealed class PROP_5f72f60868f44afb964fbd1d5262e3b9 : HardwiredMemberDescriptor
      {
        internal PROP_5f72f60868f44afb964fbd1d5262e3b9()
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

      private sealed class PROP_b903a3876dc74931b607d1010d4d84e7 : HardwiredMemberDescriptor
      {
        internal PROP_b903a3876dc74931b607d1010d4d84e7()
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

      private sealed class PROP_c9c390494ef0469195e2aba39c891beb : HardwiredMemberDescriptor
      {
        internal PROP_c9c390494ef0469195e2aba39c891beb()
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

      private sealed class PROP_e724bc509e894b7b8c9ab440988d0a3c : HardwiredMemberDescriptor
      {
        internal PROP_e724bc509e894b7b8c9ab440988d0a3c()
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

      private sealed class PROP_acf0f33007ed4439902f1fa5ceac91d9 : HardwiredMemberDescriptor
      {
        internal PROP_acf0f33007ed4439902f1fa5ceac91d9()
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

      private sealed class PROP_8cd8c0657c9747aeb22843d71319cbe4 : HardwiredMemberDescriptor
      {
        internal PROP_8cd8c0657c9747aeb22843d71319cbe4()
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

      private sealed class PROP_a4edd60d135142afbf94c21d285e0f0b : HardwiredMemberDescriptor
      {
        internal PROP_a4edd60d135142afbf94c21d285e0f0b()
          : base(typeof (bool), "waiting", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class PROP_aac3f85fba9244f1bff434b59f350570 : HardwiredMemberDescriptor
      {
        internal PROP_aac3f85fba9244f1bff434b59f350570()
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

      private sealed class PROP_74c8a83065c84e13bce92e92d4dfc253 : HardwiredMemberDescriptor
      {
        internal PROP_74c8a83065c84e13bce92e92d4dfc253()
          : base(typeof (bool), "busy", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class PROP_8ce69efd748f41c98acab4ef82ffb82d : HardwiredMemberDescriptor
      {
        internal PROP_8ce69efd748f41c98acab4ef82ffb82d()
          : base(typeof (bool), "ongoing", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class PROP_08c16a043b9845b8b1f0214af0936ce2 : HardwiredMemberDescriptor
      {
        internal PROP_08c16a043b9845b8b1f0214af0936ce2()
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

      private sealed class PROP_9630ade491f044ba84cea7b9db36a794 : HardwiredMemberDescriptor
      {
        internal PROP_9630ade491f044ba84cea7b9db36a794()
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

      private sealed class PROP_8dc1f4d06c7b4d50b1ee493b05a63f3f : HardwiredMemberDescriptor
      {
        internal PROP_8dc1f4d06c7b4d50b1ee493b05a63f3f()
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

      private sealed class PROP_5433b87479a546bb88922819a09dc07d : HardwiredMemberDescriptor
      {
        internal PROP_5433b87479a546bb88922819a09dc07d()
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

      private sealed class PROP_5d4470921cee4a0c9c4808d072295375 : HardwiredMemberDescriptor
      {
        internal PROP_5d4470921cee4a0c9c4808d072295375()
          : base(typeof (int), "width", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class PROP_ce3be6350dd9417e84d6809f997a9036 : HardwiredMemberDescriptor
      {
        internal PROP_ce3be6350dd9417e84d6809f997a9036()
          : base(typeof (int), "height", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class PROP_f8afb61eb4bf4fa3bcd42d4b04d09b59 : HardwiredMemberDescriptor
      {
        internal PROP_f8afb61eb4bf4fa3bcd42d4b04d09b59()
          : base(typeof (Educative.Point), "mousePosition", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class PROP_41aefb25798f47309ee96c95fec619a8 : HardwiredMemberDescriptor
      {
        internal PROP_41aefb25798f47309ee96c95fec619a8()
          : base(typeof (bool), "mouseOverUI", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class PROP_c00842cbb5f247bf94cac23080684427 : HardwiredMemberDescriptor
      {
        internal PROP_c00842cbb5f247bf94cac23080684427()
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

      private sealed class PROP_f0a869a05196472da75b2225fc623895 : HardwiredMemberDescriptor
      {
        internal PROP_f0a869a05196472da75b2225fc623895()
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

      private sealed class PROP_8b38787ada94428597d3f17abd424d22 : HardwiredMemberDescriptor
      {
        internal PROP_8b38787ada94428597d3f17abd424d22()
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

      private sealed class PROP_cab4b6eb57714dfbba3f6ce18df090b4 : HardwiredMemberDescriptor
      {
        internal PROP_cab4b6eb57714dfbba3f6ce18df090b4()
          : base(typeof (bool), "isUsingTouchControls", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class PROP_76d35708c30e4e9a9109a14108b87148 : HardwiredMemberDescriptor
      {
        internal PROP_76d35708c30e4e9a9109a14108b87148()
          : base(typeof (double), "screenWidth", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class PROP_57337d578496492fb742b798b0f5a005 : HardwiredMemberDescriptor
      {
        internal PROP_57337d578496492fb742b798b0f5a005()
          : base(typeof (double), "screenHeight", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }
    }

    private sealed class TYPE_b4a7a397f4b04af3bed5f2c9effe4fce : HardwiredUserDataDescriptor
    {
      internal TYPE_b4a7a397f4b04af3bed5f2c9effe4fce()
        : base(typeof (ContainerPlayer))
      {
        this.AddMember("get_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b4a7a397f4b04af3bed5f2c9effe4fce.MTHD_91ff3fa640d8452293110ca6834cf8b6()
        }));
        this.AddMember("set_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b4a7a397f4b04af3bed5f2c9effe4fce.MTHD_00635b0ba7eb466bac05a9dbd2681e20()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b4a7a397f4b04af3bed5f2c9effe4fce.MTHD_d0cbd5d298834c47aa72365908bdf22d()
        }));
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b4a7a397f4b04af3bed5f2c9effe4fce.MTHD_b761230252694161bdba604aa065c5ae()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b4a7a397f4b04af3bed5f2c9effe4fce.MTHD_0d93835c30904d419a5be3efdd0e504d()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b4a7a397f4b04af3bed5f2c9effe4fce.MTHD_95c0e1ab5c4a4c0ba42f0179a46c8f79()
        }));
        this.AddMember("getCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreature", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b4a7a397f4b04af3bed5f2c9effe4fce.MTHD_f430b24f858d44f1b7c065364c7b5e59()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b4a7a397f4b04af3bed5f2c9effe4fce.MTHD_f16741b174d94809b86ce55c450c4948()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b4a7a397f4b04af3bed5f2c9effe4fce.MTHD_64d3782da1184b7bb2876168f7bb4e1d()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b4a7a397f4b04af3bed5f2c9effe4fce.MTHD_8c19da2d841f497b94c5970943f0c046()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b4a7a397f4b04af3bed5f2c9effe4fce.MTHD_ab81abfe893a44c3bcb72b0b625f87fe()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b4a7a397f4b04af3bed5f2c9effe4fce.MTHD_9e2851bc0a8343b29ec24b34e208c5e8()
        }));
        this.AddMember("localTurn", (IMemberDescriptor) new Bridge.TYPE_b4a7a397f4b04af3bed5f2c9effe4fce.PROP_6e3feb0d9bfb45a490170b860335ccff());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_b4a7a397f4b04af3bed5f2c9effe4fce.PROP_139506c82f5c4cf0b02c1b42fe9afd5c());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_b4a7a397f4b04af3bed5f2c9effe4fce.PROP_18d944ac4e694975b3246fb6b36d18d0());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_b4a7a397f4b04af3bed5f2c9effe4fce.PROP_d7087747595142cdbca4dca0ac0211e5());
      }

      private sealed class MTHD_91ff3fa640d8452293110ca6834cf8b6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_91ff3fa640d8452293110ca6834cf8b6()
        {
          this.Initialize("get_localTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).localTurn;
        }
      }

      private sealed class MTHD_00635b0ba7eb466bac05a9dbd2681e20 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_00635b0ba7eb466bac05a9dbd2681e20()
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

      private sealed class MTHD_d0cbd5d298834c47aa72365908bdf22d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d0cbd5d298834c47aa72365908bdf22d()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class MTHD_b761230252694161bdba604aa065c5ae : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b761230252694161bdba604aa065c5ae()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class MTHD_0d93835c30904d419a5be3efdd0e504d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0d93835c30904d419a5be3efdd0e504d()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }

      private sealed class MTHD_95c0e1ab5c4a4c0ba42f0179a46c8f79 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_95c0e1ab5c4a4c0ba42f0179a46c8f79()
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

      private sealed class MTHD_f430b24f858d44f1b7c065364c7b5e59 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f430b24f858d44f1b7c065364c7b5e59()
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

      private sealed class MTHD_f16741b174d94809b86ce55c450c4948 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f16741b174d94809b86ce55c450c4948()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).getMinionCount();
        }
      }

      private sealed class MTHD_64d3782da1184b7bb2876168f7bb4e1d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_64d3782da1184b7bb2876168f7bb4e1d()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).GetHashCode();
        }
      }

      private sealed class MTHD_8c19da2d841f497b94c5970943f0c046 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8c19da2d841f497b94c5970943f0c046()
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

      private sealed class MTHD_ab81abfe893a44c3bcb72b0b625f87fe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ab81abfe893a44c3bcb72b0b625f87fe()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_9e2851bc0a8343b29ec24b34e208c5e8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9e2851bc0a8343b29ec24b34e208c5e8()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_6e3feb0d9bfb45a490170b860335ccff : HardwiredMemberDescriptor
      {
        internal PROP_6e3feb0d9bfb45a490170b860335ccff()
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

      private sealed class PROP_139506c82f5c4cf0b02c1b42fe9afd5c : HardwiredMemberDescriptor
      {
        internal PROP_139506c82f5c4cf0b02c1b42fe9afd5c()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class PROP_18d944ac4e694975b3246fb6b36d18d0 : HardwiredMemberDescriptor
      {
        internal PROP_18d944ac4e694975b3246fb6b36d18d0()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class PROP_d7087747595142cdbca4dca0ac0211e5 : HardwiredMemberDescriptor
      {
        internal PROP_d7087747595142cdbca4dca0ac0211e5()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }
    }

    private sealed class TYPE_cb08f94430e647a3ac001403b714e1dd : HardwiredUserDataDescriptor
    {
      internal TYPE_cb08f94430e647a3ac001403b714e1dd()
        : base(typeof (ContainerCreature))
      {
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_c7d10fe1342b47ad9fddc9c0f5e43cb6()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_e7c3425008f046b0962d0f512e8ce53c()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_6741cd8a35934df1a9766c08e0d387f2()
        }));
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_d86b02c844534b429d78c4cad0e739fd()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_c9e0e2327cae4f2e925d20b95d25dd3b()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_bae1f15135b1453a8b53f8471f849b5e()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_c8a394a10cb94af48da8e959547cbac5()
        }));
        this.AddMember("get_healthAndTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_healthAndTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_3e60fb7aada64519960c4bdd22dcccaa()
        }));
        this.AddMember("get_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_d9c3c333a9f14da89c88831815032771()
        }));
        this.AddMember("set_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_32df2938f3f44550bd987189eb8f68a6()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_be6c70f0206a48a88a2b07256ea61258()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_4fe2799a03d4443294fbabaaa86b370a()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_7b08af11eaf24863aaef15142206f248()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_1ac22f395ba045c68918d00c39ebf66a()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_a3a3c84cf61f41d4bcd964186d1d1716()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_be366b8fe0ab420b89ecdc8ce97a3a49()
        }));
        this.AddMember("get_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_7f83370d324642b784dd137a92a616e9()
        }));
        this.AddMember("set_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_54eadb9eccf94b22b7824c4f5cb54175()
        }));
        this.AddMember("get_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_7b49ebbe37fc435ca739cdb1c0e3e243()
        }));
        this.AddMember("set_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_1b894786d3bf455caa47027dd4b83b2e()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_9d9745889cb74a5d8ffedc3946bec27f()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_9884eb6c0982446ebaa04e9f1593e037()
        }));
        this.AddMember("get_inTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_3a46e4eb947e4e7a831887ff06e0de58()
        }));
        this.AddMember("get_isMoving", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMoving", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_505fbff5363f4a2284d225140fbaf1b2()
        }));
        this.AddMember("get_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_ecbfda5cfb514473b7bef4367ca2e0e0()
        }));
        this.AddMember("set_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_053c85fe04be47f6b4bc1d3fc7bcaa32()
        }));
        this.AddMember("get_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_4952633a83564a7aa4afee313ee608bf()
        }));
        this.AddMember("set_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_ab9c6be9f3484455a0ec241c367e4785()
        }));
        this.AddMember("get_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_ac05055a319b4c5786a52e4bbe394d03()
        }));
        this.AddMember("set_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_316ae6179a16444093c7459c3fd40555()
        }));
        this.AddMember("get_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_1fc07876c9de452ba24a6d7aa9b30de8()
        }));
        this.AddMember("set_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_8c48887fc4754fb2a3f83473bd299448()
        }));
        this.AddMember("get_inWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_28ce6a2f8770417aabe2ea33f4968057()
        }));
        this.AddMember("get_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_e22367dd344b42899a8ab6f990119cb2()
        }));
        this.AddMember("set_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_62a4e33e4a59434c86fef1ce8398cf91()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_a02ac7cea4cd49888ddba793cc758a15()
        }));
        this.AddMember("set_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_3f467ca0fc4d4fdfb35c6da160c7677c()
        }));
        this.AddMember("get_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_a2e8ed0f0d3f424cbdbaf5dc7857c2ac()
        }));
        this.AddMember("set_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_107c92b8b0ba434eb5c65502aca223b6()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_f2c7df3854544ef1b106ff4d7c41da06()
        }));
        this.AddMember("get_isRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_95f4a0cd3bf04db09224ba7c8dcd7f4a()
        }));
        this.AddMember("get_isMounted", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMounted", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_c033aa6ee1c7416390e884249dc8b285()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_664caad165924e7fa72d0dcbb10963fe()
        }));
        this.AddMember("get_isPawn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPawn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_11fd6b1b6a2c4a02931a309d1f364a15()
        }));
        this.AddMember("get_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_6734413022354ab6be8b6ef403c1aeae()
        }));
        this.AddMember("set_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_b03b763b81e4447d96f93d8fb363f749()
        }));
        this.AddMember("get_isMountable", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMountable", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_4fc6bdd0e3b44741a2975bea8242c16f()
        }));
        this.AddMember("get_canMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_canMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_0140162d7ee9416b9648b18371f688ac()
        }));
        this.AddMember("get_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_5d64cb03515048c7b265d646fb21aa81()
        }));
        this.AddMember("set_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_b4ac8911f5bb49f7bc3385fed0e94972()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_35bfbec3e35743089048ee696f552b89()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_9eff210d5502432381e27b296bea549b()
        }));
        this.AddMember("getRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_cb354622d8e147f1ba714d8690d1e273()
        }));
        this.AddMember("getMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_4ff0caa0b6b645389c10ac4d98cc02a6()
        }));
        this.AddMember("getTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_fcf5688c8e9145edaf8a32fb9b5c02b2()
        }));
        this.AddMember("LongJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LongJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_ae1c1debafe94a44b5b56a56d8e2de7d()
        }));
        this.AddMember("HighJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("HighJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_5f9f47adfb6e4f7783a26ec41a85ea82()
        }));
        this.AddMember("Walk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Walk", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_6e9cc49e88a44b569480cca573c892be()
        }));
        this.AddMember("setDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_45b3c58efa764a3699a365479b7194f1()
        }));
        this.AddMember("getDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_92f1c4c5cf874b8790da2295ae4822af()
        }));
        this.AddMember("getFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_f7bad09e0d0e46b997b596d8c6a85e2d()
        }));
        this.AddMember("getActivateableFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_d79ee360f45c467ea3d5971752fb6740()
        }));
        this.AddMember("getActivateableFamiliarBookID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarBookID", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_67b980ef57ba4bd7890bfca3037db0b8()
        }));
        this.AddMember("increaseFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("increaseFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_eb24f7ae93d54c6ea5b877e060f1cb76()
        }));
        this.AddMember("inside", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("inside", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_dc8e7d4a9bfe48a4b1dbdc123acca378(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_eaf380676c3a4b48be495aef7f560dc6()
        }));
        this.AddMember("overlap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("overlap", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_c36369c023c148638b96cb38e8d47f21(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_0c95ff9188a54972b211f5f517b00497()
        }));
        this.AddMember("die", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("die", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_428da6c5e06f49b5a4026fa9b50caf7b()
        }));
        this.AddMember("addSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_9e5ce7f41606472ab612af8d07c87d17()
        }));
        this.AddMember("removeSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("removeSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_3e3c9bbf01674fd4b3f277828d02d56e(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_49c7ab04bc544543879bc375b3783f06()
        }));
        this.AddMember("getSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpells", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_042c8906f4ab4656bd96c6e7c9b9995d()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_4b206c96f9f749daa34109c38cbac874()
        }));
        this.AddMember("getSpellCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_2e587e4d66c04a8ca916bb2a41411619()
        }));
        this.AddMember("castedCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_11931d9991974552afb044d2c3ca8efe()
        }));
        this.AddMember("castedCountThisTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCountThisTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_3849a1160b7f4b7b8f5255d4c783898f()
        }));
        this.AddMember("castedDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_e01de6fb127b48fd809280bfc4e8eec7()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_f6849ba8f40c4e468bd4cf3c075cbc0f()
        }));
        this.AddMember("castSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_70147d8e35fd49ad8c9fc681d87e6be7()
        }));
        this.AddMember("angleToFire", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("angleToFire", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_8980579b8054442c89e7ed55396d1fab()
        }));
        this.AddMember("powerToFire", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("powerToFire", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_d3d9ab4606f24bd287be65fa76c7d6c5()
        }));
        this.AddMember("fireAt", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fireAt", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_1fd358900833421e8274979219b664f2(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_7ec561fe54d94417a6a9467735e7d42a()
        }));
        this.AddMember("getEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getEffectors", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_f3ec03ee51764d52a992b351369404be(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_2d66251c8f1b4b99b59e3d23aeacc23b()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_4a175a92e8d3457fb614fec50efe22b5()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_085b2265b7104da19d0ec1b0df706e42()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_29f0d58ca2224cdba6fcf1f968de408e()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_ac32a36bf8b14981ac4be5e2ada2b276()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_f9c38f97cc0a4de8b194573bdfc5e212()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.MTHD_2de6d85a63844408adcbd5d80a4c2883()
        }));
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.PROP_13482df9b09e40b6bf6d2f82f712f005());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.PROP_f1d0e0c34a34468aa7cddd872c90def4());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.PROP_452783df8bca4bb4bbcdf625753b1ba4());
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.PROP_2b87c77c3b614fa5aa7b997572ad29e6());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.PROP_b93026bfabbb483fa019017ecfb82b85());
        this.AddMember("healthAndTower", (IMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.PROP_75b5051944164eceab9ebe554856cd5f());
        this.AddMember("shield", (IMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.PROP_0f8b9fa690454996b215f8ffd3842ef6());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.PROP_432b39e96e314086ab3799a98eae3e6c());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.PROP_091e3597055f4c94806ba3ff4f3fa3b7());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.PROP_2172c5aa2eff4e4ba6794184acce07f1());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.PROP_53074ba6da684ab28fcd200c15999726());
        this.AddMember("weight", (IMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.PROP_d3f41e1c30e1404793c8445587468e1d());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.PROP_92d4173645c149bc83d4509de06ae6c1());
        this.AddMember("inTower", (IMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.PROP_401668bafdc842c5acc99f7229be29fc());
        this.AddMember("isMoving", (IMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.PROP_4a6871a3a15e4b7486d4d587d6aad93a());
        this.AddMember("stunned", (IMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.PROP_a3f00c5d0de54ee082e09d87acfa3c6d());
        this.AddMember("superStunned", (IMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.PROP_03f04aa9620f4efbb7323fd2534fb55c());
        this.AddMember("waterWalking", (IMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.PROP_38b2e20031ab489eb431e6bcdf26cbc4());
        this.AddMember("frostWalking", (IMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.PROP_96987a0aa9254998a951b5921a511f8b());
        this.AddMember("inWater", (IMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.PROP_6d8616d29fff43688f9b4b776775e8d0());
        this.AddMember("diesInWater", (IMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.PROP_8fb6781c50ab4701a46ab6fc6cff6e85());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.PROP_6f3ec2c9eda64652801e41e470018d1b());
        this.AddMember("race", (IMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.PROP_edbe91b186ea4a9bb1f34aef87f10d28());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.PROP_fdcc0b2793934b60bcb9d563d80d04bd());
        this.AddMember("isRider", (IMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.PROP_aaed24fe6c0b4de98a7286109dc7ef0e());
        this.AddMember("isMounted", (IMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.PROP_4d6f77880ff444bb80a4a374ec1090b3());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.PROP_a783fc1b97344fedb3831e87801e5393());
        this.AddMember("isPawn", (IMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.PROP_50e976e17f984976ba31e5846ad78d98());
        this.AddMember("isFlying", (IMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.PROP_c42388bca80d46cdacea22275b19197c());
        this.AddMember("isMountable", (IMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.PROP_af9d154c2aec4d4f8ee71464223207dd());
        this.AddMember("canMount", (IMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.PROP_ce1d7de1804f4e20a3984262a30556f1());
        this.AddMember("arcaneMonster", (IMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.PROP_bfbb8e90062c420fa4d3cfda86095908());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_cb08f94430e647a3ac001403b714e1dd.PROP_5f30a17dca9f4f15893605a4f51181fc());
      }

      private sealed class MTHD_c7d10fe1342b47ad9fddc9c0f5e43cb6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c7d10fe1342b47ad9fddc9c0f5e43cb6()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class MTHD_e7c3425008f046b0962d0f512e8ce53c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e7c3425008f046b0962d0f512e8ce53c()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class MTHD_6741cd8a35934df1a9766c08e0d387f2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6741cd8a35934df1a9766c08e0d387f2()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class MTHD_d86b02c844534b429d78c4cad0e739fd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d86b02c844534b429d78c4cad0e739fd()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).health;
        }
      }

      private sealed class MTHD_c9e0e2327cae4f2e925d20b95d25dd3b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c9e0e2327cae4f2e925d20b95d25dd3b()
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

      private sealed class MTHD_bae1f15135b1453a8b53f8471f849b5e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bae1f15135b1453a8b53f8471f849b5e()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).maxHealth;
        }
      }

      private sealed class MTHD_c8a394a10cb94af48da8e959547cbac5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c8a394a10cb94af48da8e959547cbac5()
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

      private sealed class MTHD_3e60fb7aada64519960c4bdd22dcccaa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3e60fb7aada64519960c4bdd22dcccaa()
        {
          this.Initialize("get_healthAndTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class MTHD_d9c3c333a9f14da89c88831815032771 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d9c3c333a9f14da89c88831815032771()
        {
          this.Initialize("get_shield", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).shield;
        }
      }

      private sealed class MTHD_32df2938f3f44550bd987189eb8f68a6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_32df2938f3f44550bd987189eb8f68a6()
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

      private sealed class MTHD_be6c70f0206a48a88a2b07256ea61258 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_be6c70f0206a48a88a2b07256ea61258()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).x;
        }
      }

      private sealed class MTHD_4fe2799a03d4443294fbabaaa86b370a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4fe2799a03d4443294fbabaaa86b370a()
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

      private sealed class MTHD_7b08af11eaf24863aaef15142206f248 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7b08af11eaf24863aaef15142206f248()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).y;
        }
      }

      private sealed class MTHD_1ac22f395ba045c68918d00c39ebf66a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1ac22f395ba045c68918d00c39ebf66a()
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

      private sealed class MTHD_a3a3c84cf61f41d4bcd964186d1d1716 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a3a3c84cf61f41d4bcd964186d1d1716()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).position;
        }
      }

      private sealed class MTHD_be366b8fe0ab420b89ecdc8ce97a3a49 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_be366b8fe0ab420b89ecdc8ce97a3a49()
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

      private sealed class MTHD_7f83370d324642b784dd137a92a616e9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7f83370d324642b784dd137a92a616e9()
        {
          this.Initialize("get_parent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).parent;
        }
      }

      private sealed class MTHD_54eadb9eccf94b22b7824c4f5cb54175 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_54eadb9eccf94b22b7824c4f5cb54175()
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

      private sealed class MTHD_7b49ebbe37fc435ca739cdb1c0e3e243 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7b49ebbe37fc435ca739cdb1c0e3e243()
        {
          this.Initialize("get_weight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).weight;
        }
      }

      private sealed class MTHD_1b894786d3bf455caa47027dd4b83b2e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1b894786d3bf455caa47027dd4b83b2e()
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

      private sealed class MTHD_9d9745889cb74a5d8ffedc3946bec27f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9d9745889cb74a5d8ffedc3946bec27f()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).radius;
        }
      }

      private sealed class MTHD_9884eb6c0982446ebaa04e9f1593e037 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9884eb6c0982446ebaa04e9f1593e037()
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

      private sealed class MTHD_3a46e4eb947e4e7a831887ff06e0de58 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3a46e4eb947e4e7a831887ff06e0de58()
        {
          this.Initialize("get_inTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class MTHD_505fbff5363f4a2284d225140fbaf1b2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_505fbff5363f4a2284d225140fbaf1b2()
        {
          this.Initialize("get_isMoving", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class MTHD_ecbfda5cfb514473b7bef4367ca2e0e0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ecbfda5cfb514473b7bef4367ca2e0e0()
        {
          this.Initialize("get_stunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).stunned;
        }
      }

      private sealed class MTHD_053c85fe04be47f6b4bc1d3fc7bcaa32 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_053c85fe04be47f6b4bc1d3fc7bcaa32()
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

      private sealed class MTHD_4952633a83564a7aa4afee313ee608bf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4952633a83564a7aa4afee313ee608bf()
        {
          this.Initialize("get_superStunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).superStunned;
        }
      }

      private sealed class MTHD_ab9c6be9f3484455a0ec241c367e4785 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ab9c6be9f3484455a0ec241c367e4785()
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

      private sealed class MTHD_ac05055a319b4c5786a52e4bbe394d03 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ac05055a319b4c5786a52e4bbe394d03()
        {
          this.Initialize("get_waterWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).waterWalking;
        }
      }

      private sealed class MTHD_316ae6179a16444093c7459c3fd40555 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_316ae6179a16444093c7459c3fd40555()
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

      private sealed class MTHD_1fc07876c9de452ba24a6d7aa9b30de8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1fc07876c9de452ba24a6d7aa9b30de8()
        {
          this.Initialize("get_frostWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).frostWalking;
        }
      }

      private sealed class MTHD_8c48887fc4754fb2a3f83473bd299448 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8c48887fc4754fb2a3f83473bd299448()
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

      private sealed class MTHD_28ce6a2f8770417aabe2ea33f4968057 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_28ce6a2f8770417aabe2ea33f4968057()
        {
          this.Initialize("get_inWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class MTHD_e22367dd344b42899a8ab6f990119cb2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e22367dd344b42899a8ab6f990119cb2()
        {
          this.Initialize("get_diesInWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).diesInWater;
        }
      }

      private sealed class MTHD_62a4e33e4a59434c86fef1ce8398cf91 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_62a4e33e4a59434c86fef1ce8398cf91()
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

      private sealed class MTHD_a02ac7cea4cd49888ddba793cc758a15 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a02ac7cea4cd49888ddba793cc758a15()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).type;
        }
      }

      private sealed class MTHD_3f467ca0fc4d4fdfb35c6da160c7677c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3f467ca0fc4d4fdfb35c6da160c7677c()
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

      private sealed class MTHD_a2e8ed0f0d3f424cbdbaf5dc7857c2ac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a2e8ed0f0d3f424cbdbaf5dc7857c2ac()
        {
          this.Initialize("get_race", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).race;
        }
      }

      private sealed class MTHD_107c92b8b0ba434eb5c65502aca223b6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_107c92b8b0ba434eb5c65502aca223b6()
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

      private sealed class MTHD_f2c7df3854544ef1b106ff4d7c41da06 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f2c7df3854544ef1b106ff4d7c41da06()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class MTHD_95f4a0cd3bf04db09224ba7c8dcd7f4a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_95f4a0cd3bf04db09224ba7c8dcd7f4a()
        {
          this.Initialize("get_isRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class MTHD_c033aa6ee1c7416390e884249dc8b285 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c033aa6ee1c7416390e884249dc8b285()
        {
          this.Initialize("get_isMounted", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class MTHD_664caad165924e7fa72d0dcbb10963fe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_664caad165924e7fa72d0dcbb10963fe()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class MTHD_11fd6b1b6a2c4a02931a309d1f364a15 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_11fd6b1b6a2c4a02931a309d1f364a15()
        {
          this.Initialize("get_isPawn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class MTHD_6734413022354ab6be8b6ef403c1aeae : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6734413022354ab6be8b6ef403c1aeae()
        {
          this.Initialize("get_isFlying", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isFlying;
        }
      }

      private sealed class MTHD_b03b763b81e4447d96f93d8fb363f749 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b03b763b81e4447d96f93d8fb363f749()
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

      private sealed class MTHD_4fc6bdd0e3b44741a2975bea8242c16f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4fc6bdd0e3b44741a2975bea8242c16f()
        {
          this.Initialize("get_isMountable", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class MTHD_0140162d7ee9416b9648b18371f688ac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0140162d7ee9416b9648b18371f688ac()
        {
          this.Initialize("get_canMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class MTHD_5d64cb03515048c7b265d646fb21aa81 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5d64cb03515048c7b265d646fb21aa81()
        {
          this.Initialize("get_arcaneMonster", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).arcaneMonster;
        }
      }

      private sealed class MTHD_b4ac8911f5bb49f7bc3385fed0e94972 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b4ac8911f5bb49f7bc3385fed0e94972()
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

      private sealed class MTHD_35bfbec3e35743089048ee696f552b89 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_35bfbec3e35743089048ee696f552b89()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).takeDamage;
        }
      }

      private sealed class MTHD_9eff210d5502432381e27b296bea549b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9eff210d5502432381e27b296bea549b()
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

      private sealed class MTHD_cb354622d8e147f1ba714d8690d1e273 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cb354622d8e147f1ba714d8690d1e273()
        {
          this.Initialize("getRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getRider();
        }
      }

      private sealed class MTHD_4ff0caa0b6b645389c10ac4d98cc02a6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4ff0caa0b6b645389c10ac4d98cc02a6()
        {
          this.Initialize("getMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMount();
        }
      }

      private sealed class MTHD_fcf5688c8e9145edaf8a32fb9b5c02b2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fcf5688c8e9145edaf8a32fb9b5c02b2()
        {
          this.Initialize("getTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getTower();
        }
      }

      private sealed class MTHD_ae1c1debafe94a44b5b56a56d8e2de7d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ae1c1debafe94a44b5b56a56d8e2de7d()
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

      private sealed class MTHD_5f9f47adfb6e4f7783a26ec41a85ea82 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5f9f47adfb6e4f7783a26ec41a85ea82()
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

      private sealed class MTHD_6e9cc49e88a44b569480cca573c892be : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6e9cc49e88a44b569480cca573c892be()
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

      private sealed class MTHD_45b3c58efa764a3699a365479b7194f1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_45b3c58efa764a3699a365479b7194f1()
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

      private sealed class MTHD_92f1c4c5cf874b8790da2295ae4822af : HardwiredMethodMemberDescriptor
      {
        internal MTHD_92f1c4c5cf874b8790da2295ae4822af()
        {
          this.Initialize("getDirection", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getDirection();
        }
      }

      private sealed class MTHD_f7bad09e0d0e46b997b596d8c6a85e2d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f7bad09e0d0e46b997b596d8c6a85e2d()
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

      private sealed class MTHD_d79ee360f45c467ea3d5971752fb6740 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d79ee360f45c467ea3d5971752fb6740()
        {
          this.Initialize("getActivateableFamiliarLevel", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarLevel();
        }
      }

      private sealed class MTHD_67b980ef57ba4bd7890bfca3037db0b8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_67b980ef57ba4bd7890bfca3037db0b8()
        {
          this.Initialize("getActivateableFamiliarBookID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarBookID();
        }
      }

      private sealed class MTHD_eb24f7ae93d54c6ea5b877e060f1cb76 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eb24f7ae93d54c6ea5b877e060f1cb76()
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

      private sealed class MTHD_dc8e7d4a9bfe48a4b1dbdc123acca378 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dc8e7d4a9bfe48a4b1dbdc123acca378()
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

      private sealed class MTHD_eaf380676c3a4b48be495aef7f560dc6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eaf380676c3a4b48be495aef7f560dc6()
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

      private sealed class MTHD_c36369c023c148638b96cb38e8d47f21 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c36369c023c148638b96cb38e8d47f21()
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

      private sealed class MTHD_0c95ff9188a54972b211f5f517b00497 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0c95ff9188a54972b211f5f517b00497()
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

      private sealed class MTHD_428da6c5e06f49b5a4026fa9b50caf7b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_428da6c5e06f49b5a4026fa9b50caf7b()
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

      private sealed class MTHD_9e5ce7f41606472ab612af8d07c87d17 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9e5ce7f41606472ab612af8d07c87d17()
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

      private sealed class MTHD_3e3c9bbf01674fd4b3f277828d02d56e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3e3c9bbf01674fd4b3f277828d02d56e()
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

      private sealed class MTHD_49c7ab04bc544543879bc375b3783f06 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_49c7ab04bc544543879bc375b3783f06()
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

      private sealed class MTHD_042c8906f4ab4656bd96c6e7c9b9995d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_042c8906f4ab4656bd96c6e7c9b9995d()
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

      private sealed class MTHD_4b206c96f9f749daa34109c38cbac874 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4b206c96f9f749daa34109c38cbac874()
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

      private sealed class MTHD_2e587e4d66c04a8ca916bb2a41411619 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2e587e4d66c04a8ca916bb2a41411619()
        {
          this.Initialize("getSpellCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getSpellCount();
        }
      }

      private sealed class MTHD_11931d9991974552afb044d2c3ca8efe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_11931d9991974552afb044d2c3ca8efe()
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

      private sealed class MTHD_3849a1160b7f4b7b8f5255d4c783898f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3849a1160b7f4b7b8f5255d4c783898f()
        {
          this.Initialize("castedCountThisTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).castedCountThisTurn();
        }
      }

      private sealed class MTHD_e01de6fb127b48fd809280bfc4e8eec7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e01de6fb127b48fd809280bfc4e8eec7()
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

      private sealed class MTHD_f6849ba8f40c4e468bd4cf3c075cbc0f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f6849ba8f40c4e468bd4cf3c075cbc0f()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMinionCount();
        }
      }

      private sealed class MTHD_70147d8e35fd49ad8c9fc681d87e6be7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_70147d8e35fd49ad8c9fc681d87e6be7()
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

      private sealed class MTHD_8980579b8054442c89e7ed55396d1fab : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8980579b8054442c89e7ed55396d1fab()
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

      private sealed class MTHD_d3d9ab4606f24bd287be65fa76c7d6c5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d3d9ab4606f24bd287be65fa76c7d6c5()
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

      private sealed class MTHD_1fd358900833421e8274979219b664f2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1fd358900833421e8274979219b664f2()
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

      private sealed class MTHD_7ec561fe54d94417a6a9467735e7d42a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7ec561fe54d94417a6a9467735e7d42a()
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

      private sealed class MTHD_f3ec03ee51764d52a992b351369404be : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f3ec03ee51764d52a992b351369404be()
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

      private sealed class MTHD_2d66251c8f1b4b99b59e3d23aeacc23b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2d66251c8f1b4b99b59e3d23aeacc23b()
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

      private sealed class MTHD_4a175a92e8d3457fb614fec50efe22b5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4a175a92e8d3457fb614fec50efe22b5()
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

      private sealed class MTHD_085b2265b7104da19d0ec1b0df706e42 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_085b2265b7104da19d0ec1b0df706e42()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).GetHashCode();
        }
      }

      private sealed class MTHD_29f0d58ca2224cdba6fcf1f968de408e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_29f0d58ca2224cdba6fcf1f968de408e()
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

      private sealed class MTHD_ac32a36bf8b14981ac4be5e2ada2b276 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ac32a36bf8b14981ac4be5e2ada2b276()
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

      private sealed class MTHD_f9c38f97cc0a4de8b194573bdfc5e212 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f9c38f97cc0a4de8b194573bdfc5e212()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_2de6d85a63844408adcbd5d80a4c2883 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2de6d85a63844408adcbd5d80a4c2883()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_13482df9b09e40b6bf6d2f82f712f005 : HardwiredMemberDescriptor
      {
        internal PROP_13482df9b09e40b6bf6d2f82f712f005()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class PROP_f1d0e0c34a34468aa7cddd872c90def4 : HardwiredMemberDescriptor
      {
        internal PROP_f1d0e0c34a34468aa7cddd872c90def4()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class PROP_452783df8bca4bb4bbcdf625753b1ba4 : HardwiredMemberDescriptor
      {
        internal PROP_452783df8bca4bb4bbcdf625753b1ba4()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class PROP_2b87c77c3b614fa5aa7b997572ad29e6 : HardwiredMemberDescriptor
      {
        internal PROP_2b87c77c3b614fa5aa7b997572ad29e6()
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

      private sealed class PROP_b93026bfabbb483fa019017ecfb82b85 : HardwiredMemberDescriptor
      {
        internal PROP_b93026bfabbb483fa019017ecfb82b85()
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

      private sealed class PROP_75b5051944164eceab9ebe554856cd5f : HardwiredMemberDescriptor
      {
        internal PROP_75b5051944164eceab9ebe554856cd5f()
          : base(typeof (int), "healthAndTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class PROP_0f8b9fa690454996b215f8ffd3842ef6 : HardwiredMemberDescriptor
      {
        internal PROP_0f8b9fa690454996b215f8ffd3842ef6()
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

      private sealed class PROP_432b39e96e314086ab3799a98eae3e6c : HardwiredMemberDescriptor
      {
        internal PROP_432b39e96e314086ab3799a98eae3e6c()
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

      private sealed class PROP_091e3597055f4c94806ba3ff4f3fa3b7 : HardwiredMemberDescriptor
      {
        internal PROP_091e3597055f4c94806ba3ff4f3fa3b7()
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

      private sealed class PROP_2172c5aa2eff4e4ba6794184acce07f1 : HardwiredMemberDescriptor
      {
        internal PROP_2172c5aa2eff4e4ba6794184acce07f1()
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

      private sealed class PROP_53074ba6da684ab28fcd200c15999726 : HardwiredMemberDescriptor
      {
        internal PROP_53074ba6da684ab28fcd200c15999726()
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

      private sealed class PROP_d3f41e1c30e1404793c8445587468e1d : HardwiredMemberDescriptor
      {
        internal PROP_d3f41e1c30e1404793c8445587468e1d()
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

      private sealed class PROP_92d4173645c149bc83d4509de06ae6c1 : HardwiredMemberDescriptor
      {
        internal PROP_92d4173645c149bc83d4509de06ae6c1()
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

      private sealed class PROP_401668bafdc842c5acc99f7229be29fc : HardwiredMemberDescriptor
      {
        internal PROP_401668bafdc842c5acc99f7229be29fc()
          : base(typeof (bool), "inTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class PROP_4a6871a3a15e4b7486d4d587d6aad93a : HardwiredMemberDescriptor
      {
        internal PROP_4a6871a3a15e4b7486d4d587d6aad93a()
          : base(typeof (bool), "isMoving", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class PROP_a3f00c5d0de54ee082e09d87acfa3c6d : HardwiredMemberDescriptor
      {
        internal PROP_a3f00c5d0de54ee082e09d87acfa3c6d()
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

      private sealed class PROP_03f04aa9620f4efbb7323fd2534fb55c : HardwiredMemberDescriptor
      {
        internal PROP_03f04aa9620f4efbb7323fd2534fb55c()
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

      private sealed class PROP_38b2e20031ab489eb431e6bcdf26cbc4 : HardwiredMemberDescriptor
      {
        internal PROP_38b2e20031ab489eb431e6bcdf26cbc4()
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

      private sealed class PROP_96987a0aa9254998a951b5921a511f8b : HardwiredMemberDescriptor
      {
        internal PROP_96987a0aa9254998a951b5921a511f8b()
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

      private sealed class PROP_6d8616d29fff43688f9b4b776775e8d0 : HardwiredMemberDescriptor
      {
        internal PROP_6d8616d29fff43688f9b4b776775e8d0()
          : base(typeof (bool), "inWater", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class PROP_8fb6781c50ab4701a46ab6fc6cff6e85 : HardwiredMemberDescriptor
      {
        internal PROP_8fb6781c50ab4701a46ab6fc6cff6e85()
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

      private sealed class PROP_6f3ec2c9eda64652801e41e470018d1b : HardwiredMemberDescriptor
      {
        internal PROP_6f3ec2c9eda64652801e41e470018d1b()
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

      private sealed class PROP_edbe91b186ea4a9bb1f34aef87f10d28 : HardwiredMemberDescriptor
      {
        internal PROP_edbe91b186ea4a9bb1f34aef87f10d28()
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

      private sealed class PROP_fdcc0b2793934b60bcb9d563d80d04bd : HardwiredMemberDescriptor
      {
        internal PROP_fdcc0b2793934b60bcb9d563d80d04bd()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class PROP_aaed24fe6c0b4de98a7286109dc7ef0e : HardwiredMemberDescriptor
      {
        internal PROP_aaed24fe6c0b4de98a7286109dc7ef0e()
          : base(typeof (bool), "isRider", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class PROP_4d6f77880ff444bb80a4a374ec1090b3 : HardwiredMemberDescriptor
      {
        internal PROP_4d6f77880ff444bb80a4a374ec1090b3()
          : base(typeof (bool), "isMounted", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class PROP_a783fc1b97344fedb3831e87801e5393 : HardwiredMemberDescriptor
      {
        internal PROP_a783fc1b97344fedb3831e87801e5393()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class PROP_50e976e17f984976ba31e5846ad78d98 : HardwiredMemberDescriptor
      {
        internal PROP_50e976e17f984976ba31e5846ad78d98()
          : base(typeof (bool), "isPawn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class PROP_c42388bca80d46cdacea22275b19197c : HardwiredMemberDescriptor
      {
        internal PROP_c42388bca80d46cdacea22275b19197c()
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

      private sealed class PROP_af9d154c2aec4d4f8ee71464223207dd : HardwiredMemberDescriptor
      {
        internal PROP_af9d154c2aec4d4f8ee71464223207dd()
          : base(typeof (bool), "isMountable", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class PROP_ce1d7de1804f4e20a3984262a30556f1 : HardwiredMemberDescriptor
      {
        internal PROP_ce1d7de1804f4e20a3984262a30556f1()
          : base(typeof (bool), "canMount", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class PROP_bfbb8e90062c420fa4d3cfda86095908 : HardwiredMemberDescriptor
      {
        internal PROP_bfbb8e90062c420fa4d3cfda86095908()
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

      private sealed class PROP_5f30a17dca9f4f15893605a4f51181fc : HardwiredMemberDescriptor
      {
        internal PROP_5f30a17dca9f4f15893605a4f51181fc()
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

    private sealed class TYPE_9e78cea92e7e420dbcd873db914e23c5 : HardwiredUserDataDescriptor
    {
      internal TYPE_9e78cea92e7e420dbcd873db914e23c5()
        : base(typeof (ContainerEffector))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9e78cea92e7e420dbcd873db914e23c5.MTHD_a43c0a8f0d2a4d4e88293efb8ce90904()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9e78cea92e7e420dbcd873db914e23c5.MTHD_83a028ceb3374a108b8e3aaf50a268d3()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9e78cea92e7e420dbcd873db914e23c5.MTHD_5e4549c1829c4b6e9d1d7a8f003d37de()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9e78cea92e7e420dbcd873db914e23c5.MTHD_c3124e966e084c0d9ba9944b56b25c47()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9e78cea92e7e420dbcd873db914e23c5.MTHD_5c3a4a46551448708c1c0ba9c5cbdecb()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9e78cea92e7e420dbcd873db914e23c5.MTHD_52bca55507d64016b88570f035623945()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9e78cea92e7e420dbcd873db914e23c5.MTHD_a6d13c25ff4341f7981be5848c12089e()
        }));
        this.AddMember("get_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9e78cea92e7e420dbcd873db914e23c5.MTHD_bf0bc38e4489460d8dc6d11807ea8274()
        }));
        this.AddMember("set_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9e78cea92e7e420dbcd873db914e23c5.MTHD_7b2ed31d99b547e58400528e906bfb5b()
        }));
        this.AddMember("get_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9e78cea92e7e420dbcd873db914e23c5.MTHD_a7fdc38a29de4c1f8ccb47558bf02cda()
        }));
        this.AddMember("set_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9e78cea92e7e420dbcd873db914e23c5.MTHD_3b81b01f51934f499df2298cebb53f77()
        }));
        this.AddMember("get_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9e78cea92e7e420dbcd873db914e23c5.MTHD_6d1a6248351b4205ae5cb993b2bc6b77()
        }));
        this.AddMember("set_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9e78cea92e7e420dbcd873db914e23c5.MTHD_95e4732c44544a6f82b1279fa201abfb()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9e78cea92e7e420dbcd873db914e23c5.MTHD_a115475236a647a4b01a64d46973e392()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9e78cea92e7e420dbcd873db914e23c5.MTHD_1c044f902d944e30938dd65483b80c75()
        }));
        this.AddMember("turnPassed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("turnPassed", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9e78cea92e7e420dbcd873db914e23c5.MTHD_2fd3b90d37964894986646a5937f2b9e()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9e78cea92e7e420dbcd873db914e23c5.MTHD_860c05568cc84c4b93c36a22f092ae77()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9e78cea92e7e420dbcd873db914e23c5.MTHD_14be0309fd33488eaa97815757f22ba5()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9e78cea92e7e420dbcd873db914e23c5.MTHD_3452673085e94584bd80c3b195730a4b()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9e78cea92e7e420dbcd873db914e23c5.MTHD_beadaac22cbb4ea8af3c8f48be6d0b6f()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_9e78cea92e7e420dbcd873db914e23c5.PROP_27cfda300a504acba05b172182b766c2());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_9e78cea92e7e420dbcd873db914e23c5.PROP_187070c009f64b498b8e6b69e79850c3());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_9e78cea92e7e420dbcd873db914e23c5.PROP_2b72882b456949aaa3e231c0de4de97f());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_9e78cea92e7e420dbcd873db914e23c5.PROP_0dd63638f3634d40939b9efd111bed36());
        this.AddMember("turnsAlive", (IMemberDescriptor) new Bridge.TYPE_9e78cea92e7e420dbcd873db914e23c5.PROP_c25957d48d0f4819ac53b97e06661aaa());
        this.AddMember("maxTurnsAlive", (IMemberDescriptor) new Bridge.TYPE_9e78cea92e7e420dbcd873db914e23c5.PROP_ebb3a88334454c17ab0585e736225255());
        this.AddMember("active", (IMemberDescriptor) new Bridge.TYPE_9e78cea92e7e420dbcd873db914e23c5.PROP_c03e9254ad424ae2bdf07b51025bbd85());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_9e78cea92e7e420dbcd873db914e23c5.PROP_2f2be8dc7008488a9a8e85793f36b965());
      }

      private sealed class MTHD_a43c0a8f0d2a4d4e88293efb8ce90904 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a43c0a8f0d2a4d4e88293efb8ce90904()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class MTHD_83a028ceb3374a108b8e3aaf50a268d3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_83a028ceb3374a108b8e3aaf50a268d3()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).x;
        }
      }

      private sealed class MTHD_5e4549c1829c4b6e9d1d7a8f003d37de : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5e4549c1829c4b6e9d1d7a8f003d37de()
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

      private sealed class MTHD_c3124e966e084c0d9ba9944b56b25c47 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c3124e966e084c0d9ba9944b56b25c47()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).y;
        }
      }

      private sealed class MTHD_5c3a4a46551448708c1c0ba9c5cbdecb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5c3a4a46551448708c1c0ba9c5cbdecb()
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

      private sealed class MTHD_52bca55507d64016b88570f035623945 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_52bca55507d64016b88570f035623945()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).position;
        }
      }

      private sealed class MTHD_a6d13c25ff4341f7981be5848c12089e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a6d13c25ff4341f7981be5848c12089e()
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

      private sealed class MTHD_bf0bc38e4489460d8dc6d11807ea8274 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bf0bc38e4489460d8dc6d11807ea8274()
        {
          this.Initialize("get_turnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).turnsAlive;
        }
      }

      private sealed class MTHD_7b2ed31d99b547e58400528e906bfb5b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7b2ed31d99b547e58400528e906bfb5b()
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

      private sealed class MTHD_a7fdc38a29de4c1f8ccb47558bf02cda : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a7fdc38a29de4c1f8ccb47558bf02cda()
        {
          this.Initialize("get_maxTurnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).maxTurnsAlive;
        }
      }

      private sealed class MTHD_3b81b01f51934f499df2298cebb53f77 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3b81b01f51934f499df2298cebb53f77()
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

      private sealed class MTHD_6d1a6248351b4205ae5cb993b2bc6b77 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6d1a6248351b4205ae5cb993b2bc6b77()
        {
          this.Initialize("get_active", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).active;
        }
      }

      private sealed class MTHD_95e4732c44544a6f82b1279fa201abfb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_95e4732c44544a6f82b1279fa201abfb()
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

      private sealed class MTHD_a115475236a647a4b01a64d46973e392 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a115475236a647a4b01a64d46973e392()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }

      private sealed class MTHD_1c044f902d944e30938dd65483b80c75 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1c044f902d944e30938dd65483b80c75()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_2fd3b90d37964894986646a5937f2b9e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2fd3b90d37964894986646a5937f2b9e()
        {
          this.Initialize("turnPassed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).turnPassed();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_860c05568cc84c4b93c36a22f092ae77 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_860c05568cc84c4b93c36a22f092ae77()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).GetHashCode();
        }
      }

      private sealed class MTHD_14be0309fd33488eaa97815757f22ba5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_14be0309fd33488eaa97815757f22ba5()
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

      private sealed class MTHD_3452673085e94584bd80c3b195730a4b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3452673085e94584bd80c3b195730a4b()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_beadaac22cbb4ea8af3c8f48be6d0b6f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_beadaac22cbb4ea8af3c8f48be6d0b6f()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_27cfda300a504acba05b172182b766c2 : HardwiredMemberDescriptor
      {
        internal PROP_27cfda300a504acba05b172182b766c2()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class PROP_187070c009f64b498b8e6b69e79850c3 : HardwiredMemberDescriptor
      {
        internal PROP_187070c009f64b498b8e6b69e79850c3()
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

      private sealed class PROP_2b72882b456949aaa3e231c0de4de97f : HardwiredMemberDescriptor
      {
        internal PROP_2b72882b456949aaa3e231c0de4de97f()
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

      private sealed class PROP_0dd63638f3634d40939b9efd111bed36 : HardwiredMemberDescriptor
      {
        internal PROP_0dd63638f3634d40939b9efd111bed36()
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

      private sealed class PROP_c25957d48d0f4819ac53b97e06661aaa : HardwiredMemberDescriptor
      {
        internal PROP_c25957d48d0f4819ac53b97e06661aaa()
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

      private sealed class PROP_ebb3a88334454c17ab0585e736225255 : HardwiredMemberDescriptor
      {
        internal PROP_ebb3a88334454c17ab0585e736225255()
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

      private sealed class PROP_c03e9254ad424ae2bdf07b51025bbd85 : HardwiredMemberDescriptor
      {
        internal PROP_c03e9254ad424ae2bdf07b51025bbd85()
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

      private sealed class PROP_2f2be8dc7008488a9a8e85793f36b965 : HardwiredMemberDescriptor
      {
        internal PROP_2f2be8dc7008488a9a8e85793f36b965()
          : base(typeof (EffectorType), "type", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }
    }

    private sealed class TYPE_b1eb8448437047c080241cbd90d51a99 : HardwiredUserDataDescriptor
    {
      internal TYPE_b1eb8448437047c080241cbd90d51a99()
        : base(typeof (ContainerIndicator))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b1eb8448437047c080241cbd90d51a99.MTHD_a147ae7e861d47ac8504789bd5457beb()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b1eb8448437047c080241cbd90d51a99.MTHD_f96533be08424133b477988c00b9f62d()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b1eb8448437047c080241cbd90d51a99.MTHD_d0b5fef193f14c46a064edab68b8bc7a()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b1eb8448437047c080241cbd90d51a99.MTHD_9e066414587b4177aad963bdd6718b4f()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b1eb8448437047c080241cbd90d51a99.MTHD_9e995000c21442c3b5aa73b547bf8e5c()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b1eb8448437047c080241cbd90d51a99.MTHD_b1115d5c5ddc4d84bf05392f2ab97bd5()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b1eb8448437047c080241cbd90d51a99.MTHD_5bb432f030024dfb97f562f4a787c2a5()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b1eb8448437047c080241cbd90d51a99.MTHD_d2d0b120aa01476c82a2d4046554cd5c()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b1eb8448437047c080241cbd90d51a99.MTHD_cb5e1823917542fa8be89ef1584f008b()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b1eb8448437047c080241cbd90d51a99.MTHD_ff8db6a2a938478fbd44624122cfa487()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b1eb8448437047c080241cbd90d51a99.MTHD_0c0abaac72944371a73be23440810615()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b1eb8448437047c080241cbd90d51a99.MTHD_6763a6bfa4f448f4b533b5eb4c8f945e()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b1eb8448437047c080241cbd90d51a99.MTHD_1a17c3533047441fb5097bdb04f152fe()
        }));
        this.AddMember("get_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color2", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b1eb8448437047c080241cbd90d51a99.MTHD_e1e54480694b484b9325871e694169cd()
        }));
        this.AddMember("set_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color2", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b1eb8448437047c080241cbd90d51a99.MTHD_ee7bb967220046d886839871f3223962()
        }));
        this.AddMember("get_kind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_kind", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b1eb8448437047c080241cbd90d51a99.MTHD_97f2076c4aa94958aeb3f0a73083e9ea()
        }));
        this.AddMember("setIcon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setIcon", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b1eb8448437047c080241cbd90d51a99.MTHD_da00b378381140d09f38e89ef5e21040()
        }));
        this.AddMember("Destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Destroy", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b1eb8448437047c080241cbd90d51a99.MTHD_664ec32d4d634ecab356672e26d59bf7()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b1eb8448437047c080241cbd90d51a99.MTHD_c64d042b531c47c6abb1206543ccc106()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b1eb8448437047c080241cbd90d51a99.MTHD_84e0036420db4e67af06beeb56d3f29e()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b1eb8448437047c080241cbd90d51a99.MTHD_b700446ccce046aab1df49f58cdecbb5()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b1eb8448437047c080241cbd90d51a99.MTHD_24a3cee2273b4606a9e5c8fd554587e7()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_b1eb8448437047c080241cbd90d51a99.PROP_0edb406d4da2434d9bee0cf9decc0ca6());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_b1eb8448437047c080241cbd90d51a99.PROP_394be2643ffe4ffdb111944ed6697952());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_b1eb8448437047c080241cbd90d51a99.PROP_f99d20c3c7354f4d93ef7e0f6e73cf92());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_b1eb8448437047c080241cbd90d51a99.PROP_306583e0ab3e4b56afc299ab6335b363());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_b1eb8448437047c080241cbd90d51a99.PROP_91bb51c6d5954214b6a570178f034309());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_b1eb8448437047c080241cbd90d51a99.PROP_c3c9f6a367b6411490d7b17c78c8101f());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_b1eb8448437047c080241cbd90d51a99.PROP_80cadf81f6b041f898a2fe3a70b33551());
        this.AddMember("color2", (IMemberDescriptor) new Bridge.TYPE_b1eb8448437047c080241cbd90d51a99.PROP_05d72b7608c645739699d0456838e737());
        this.AddMember("kind", (IMemberDescriptor) new Bridge.TYPE_b1eb8448437047c080241cbd90d51a99.PROP_65438bff50124c8c9218995194fb2146());
      }

      private sealed class MTHD_a147ae7e861d47ac8504789bd5457beb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a147ae7e861d47ac8504789bd5457beb()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class MTHD_f96533be08424133b477988c00b9f62d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f96533be08424133b477988c00b9f62d()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).x;
        }
      }

      private sealed class MTHD_d0b5fef193f14c46a064edab68b8bc7a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d0b5fef193f14c46a064edab68b8bc7a()
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

      private sealed class MTHD_9e066414587b4177aad963bdd6718b4f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9e066414587b4177aad963bdd6718b4f()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).y;
        }
      }

      private sealed class MTHD_9e995000c21442c3b5aa73b547bf8e5c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9e995000c21442c3b5aa73b547bf8e5c()
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

      private sealed class MTHD_b1115d5c5ddc4d84bf05392f2ab97bd5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b1115d5c5ddc4d84bf05392f2ab97bd5()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).radius;
        }
      }

      private sealed class MTHD_5bb432f030024dfb97f562f4a787c2a5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5bb432f030024dfb97f562f4a787c2a5()
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

      private sealed class MTHD_d2d0b120aa01476c82a2d4046554cd5c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d2d0b120aa01476c82a2d4046554cd5c()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).position;
        }
      }

      private sealed class MTHD_cb5e1823917542fa8be89ef1584f008b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cb5e1823917542fa8be89ef1584f008b()
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

      private sealed class MTHD_ff8db6a2a938478fbd44624122cfa487 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ff8db6a2a938478fbd44624122cfa487()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).angle;
        }
      }

      private sealed class MTHD_0c0abaac72944371a73be23440810615 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0c0abaac72944371a73be23440810615()
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

      private sealed class MTHD_6763a6bfa4f448f4b533b5eb4c8f945e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6763a6bfa4f448f4b533b5eb4c8f945e()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color;
        }
      }

      private sealed class MTHD_1a17c3533047441fb5097bdb04f152fe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1a17c3533047441fb5097bdb04f152fe()
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

      private sealed class MTHD_e1e54480694b484b9325871e694169cd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e1e54480694b484b9325871e694169cd()
        {
          this.Initialize("get_color2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color2;
        }
      }

      private sealed class MTHD_ee7bb967220046d886839871f3223962 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ee7bb967220046d886839871f3223962()
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

      private sealed class MTHD_97f2076c4aa94958aeb3f0a73083e9ea : HardwiredMethodMemberDescriptor
      {
        internal MTHD_97f2076c4aa94958aeb3f0a73083e9ea()
        {
          this.Initialize("get_kind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }

      private sealed class MTHD_da00b378381140d09f38e89ef5e21040 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_da00b378381140d09f38e89ef5e21040()
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

      private sealed class MTHD_664ec32d4d634ecab356672e26d59bf7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_664ec32d4d634ecab356672e26d59bf7()
        {
          this.Initialize("Destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerIndicator) obj).Destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_c64d042b531c47c6abb1206543ccc106 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c64d042b531c47c6abb1206543ccc106()
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

      private sealed class MTHD_84e0036420db4e67af06beeb56d3f29e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_84e0036420db4e67af06beeb56d3f29e()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_b700446ccce046aab1df49f58cdecbb5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b700446ccce046aab1df49f58cdecbb5()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_24a3cee2273b4606a9e5c8fd554587e7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_24a3cee2273b4606a9e5c8fd554587e7()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_0edb406d4da2434d9bee0cf9decc0ca6 : HardwiredMemberDescriptor
      {
        internal PROP_0edb406d4da2434d9bee0cf9decc0ca6()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class PROP_394be2643ffe4ffdb111944ed6697952 : HardwiredMemberDescriptor
      {
        internal PROP_394be2643ffe4ffdb111944ed6697952()
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

      private sealed class PROP_f99d20c3c7354f4d93ef7e0f6e73cf92 : HardwiredMemberDescriptor
      {
        internal PROP_f99d20c3c7354f4d93ef7e0f6e73cf92()
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

      private sealed class PROP_306583e0ab3e4b56afc299ab6335b363 : HardwiredMemberDescriptor
      {
        internal PROP_306583e0ab3e4b56afc299ab6335b363()
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

      private sealed class PROP_91bb51c6d5954214b6a570178f034309 : HardwiredMemberDescriptor
      {
        internal PROP_91bb51c6d5954214b6a570178f034309()
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

      private sealed class PROP_c3c9f6a367b6411490d7b17c78c8101f : HardwiredMemberDescriptor
      {
        internal PROP_c3c9f6a367b6411490d7b17c78c8101f()
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

      private sealed class PROP_80cadf81f6b041f898a2fe3a70b33551 : HardwiredMemberDescriptor
      {
        internal PROP_80cadf81f6b041f898a2fe3a70b33551()
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

      private sealed class PROP_05d72b7608c645739699d0456838e737 : HardwiredMemberDescriptor
      {
        internal PROP_05d72b7608c645739699d0456838e737()
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

      private sealed class PROP_65438bff50124c8c9218995194fb2146 : HardwiredMemberDescriptor
      {
        internal PROP_65438bff50124c8c9218995194fb2146()
          : base(typeof (IndicatorKind), "kind", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }
    }

    private sealed class TYPE_04793c50e8164d5aaaf90bac62bf1306 : HardwiredUserDataDescriptor
    {
      internal TYPE_04793c50e8164d5aaaf90bac62bf1306()
        : base(typeof (ContainerSpell))
      {
        this.AddMember("get_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04793c50e8164d5aaaf90bac62bf1306.MTHD_78c22f2d5c664d73900a1064220835f3()
        }));
        this.AddMember("set_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04793c50e8164d5aaaf90bac62bf1306.MTHD_a13159533cb546b496494e1ff3139257()
        }));
        this.AddMember("get_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04793c50e8164d5aaaf90bac62bf1306.MTHD_fa6f7a69cfaa4ea0835ada1d07ab6c1c()
        }));
        this.AddMember("set_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04793c50e8164d5aaaf90bac62bf1306.MTHD_537e6e0b28774bfcb9bfd024ca61e1bf()
        }));
        this.AddMember("get_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04793c50e8164d5aaaf90bac62bf1306.MTHD_3d87cce11a814779a93c05aa0b06ed19()
        }));
        this.AddMember("set_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04793c50e8164d5aaaf90bac62bf1306.MTHD_e37d3d91ecc74394b29a5216f8dfa808()
        }));
        this.AddMember("get_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04793c50e8164d5aaaf90bac62bf1306.MTHD_99f5e37648ed4103a9027e056b9cd9bf()
        }));
        this.AddMember("set_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04793c50e8164d5aaaf90bac62bf1306.MTHD_c420c957bcb64217b9639b3147dfe1df()
        }));
        this.AddMember("get_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04793c50e8164d5aaaf90bac62bf1306.MTHD_5127a2c247e54b73a929b4b0b85dd42f()
        }));
        this.AddMember("set_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04793c50e8164d5aaaf90bac62bf1306.MTHD_fe21d0ec5fdf456795a3a661a3a2191d()
        }));
        this.AddMember("get_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04793c50e8164d5aaaf90bac62bf1306.MTHD_5d5877aec2074f3f97640d207929e7cf()
        }));
        this.AddMember("set_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04793c50e8164d5aaaf90bac62bf1306.MTHD_de29e2af941548eeb4e990beabdea8bb()
        }));
        this.AddMember("get_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04793c50e8164d5aaaf90bac62bf1306.MTHD_04adc7ab404a4fd083e4601e1a922ccb()
        }));
        this.AddMember("set_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04793c50e8164d5aaaf90bac62bf1306.MTHD_712abedfac00436a8b1702da82db6c95()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04793c50e8164d5aaaf90bac62bf1306.MTHD_5ef2ce1a488e49cb9f767aa6e673b6d7()
        }));
        this.AddMember("get_castType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_castType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04793c50e8164d5aaaf90bac62bf1306.MTHD_6e3ff181f383467a92379a9397304558()
        }));
        this.AddMember("get_damageType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damageType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04793c50e8164d5aaaf90bac62bf1306.MTHD_c70b13d5b6fb4f86bc90ef995c36c3c2()
        }));
        this.AddMember("get_book", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_book", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04793c50e8164d5aaaf90bac62bf1306.MTHD_b0acd742fd5c4bcdbd8f39b402c3ccac()
        }));
        this.AddMember("get_damage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damage", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04793c50e8164d5aaaf90bac62bf1306.MTHD_405f889c19be4fb3b44a926c692667cb()
        }));
        this.AddMember("get_explosionRadius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_explosionRadius", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04793c50e8164d5aaaf90bac62bf1306.MTHD_5ab6b4faad43476f9b9c64f88bb29b9c()
        }));
        this.AddMember("get_description", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_description", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04793c50e8164d5aaaf90bac62bf1306.MTHD_a4d4b49b1a754242a0eb9c3d4f90d201()
        }));
        this.AddMember("get_descriptionOnly", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionOnly", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04793c50e8164d5aaaf90bac62bf1306.MTHD_be33b18fb5204e569ce47a412bda57a1()
        }));
        this.AddMember("get_descriptionExtra", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionExtra", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04793c50e8164d5aaaf90bac62bf1306.MTHD_1c61b871d7f146508a8d66b2a1f22cc1()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04793c50e8164d5aaaf90bac62bf1306.MTHD_f00f0790728d428b93f44584a1a0da3b()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04793c50e8164d5aaaf90bac62bf1306.MTHD_350bd6b1e1cc498cb9b8408f811d88b5()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04793c50e8164d5aaaf90bac62bf1306.MTHD_304fab7779aa4b9c89a5f696387c9ac2()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04793c50e8164d5aaaf90bac62bf1306.MTHD_f2b4499d1fda4cbbb24fc4483e0544f6()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04793c50e8164d5aaaf90bac62bf1306.MTHD_bf8aae5bfb644b8ab41a69b0ac8a8406()
        }));
        this.AddMember("uses", (IMemberDescriptor) new Bridge.TYPE_04793c50e8164d5aaaf90bac62bf1306.PROP_cb46b6313ad0408aaac003bf3945b264());
        this.AddMember("maxUses", (IMemberDescriptor) new Bridge.TYPE_04793c50e8164d5aaaf90bac62bf1306.PROP_d3b3c79ae1064da6ac36220e9608126c());
        this.AddMember("rechargeTime", (IMemberDescriptor) new Bridge.TYPE_04793c50e8164d5aaaf90bac62bf1306.PROP_e176bae036a14e6387b3486c46f8ddcb());
        this.AddMember("lastTurnFired", (IMemberDescriptor) new Bridge.TYPE_04793c50e8164d5aaaf90bac62bf1306.PROP_8df43a61d13440638113f32dc93651ea());
        this.AddMember("isPresent", (IMemberDescriptor) new Bridge.TYPE_04793c50e8164d5aaaf90bac62bf1306.PROP_3479faecda954581986304ab5ebe5bc7());
        this.AddMember("locked", (IMemberDescriptor) new Bridge.TYPE_04793c50e8164d5aaaf90bac62bf1306.PROP_bed57194d3a049a1b021ae115473f57d());
        this.AddMember("turnsTillFirstUse", (IMemberDescriptor) new Bridge.TYPE_04793c50e8164d5aaaf90bac62bf1306.PROP_1f85cfd76eb24be3b7bd2618555155ff());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_04793c50e8164d5aaaf90bac62bf1306.PROP_51cce8fc2e82489cae450bd04230c7a9());
        this.AddMember("castType", (IMemberDescriptor) new Bridge.TYPE_04793c50e8164d5aaaf90bac62bf1306.PROP_95d216c1204e4c50888955e430933a08());
        this.AddMember("damageType", (IMemberDescriptor) new Bridge.TYPE_04793c50e8164d5aaaf90bac62bf1306.PROP_dd95d888e2a74d31b2af2aa92c999608());
        this.AddMember("book", (IMemberDescriptor) new Bridge.TYPE_04793c50e8164d5aaaf90bac62bf1306.PROP_60878290d59e47c58d075b7b20ff1195());
        this.AddMember("damage", (IMemberDescriptor) new Bridge.TYPE_04793c50e8164d5aaaf90bac62bf1306.PROP_90d13c42fe9f4b5eb1a9ef4b9453f315());
        this.AddMember("explosionRadius", (IMemberDescriptor) new Bridge.TYPE_04793c50e8164d5aaaf90bac62bf1306.PROP_8f4142e71950426aa39e4bd76e6efa36());
        this.AddMember("description", (IMemberDescriptor) new Bridge.TYPE_04793c50e8164d5aaaf90bac62bf1306.PROP_96a540f969934c9387491ed4b8e3ca3d());
        this.AddMember("descriptionOnly", (IMemberDescriptor) new Bridge.TYPE_04793c50e8164d5aaaf90bac62bf1306.PROP_a9bdb8a997a24746a4180a35ff33d655());
        this.AddMember("descriptionExtra", (IMemberDescriptor) new Bridge.TYPE_04793c50e8164d5aaaf90bac62bf1306.PROP_6b8f791e2ea04f70b0e70a855965ea2b());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_04793c50e8164d5aaaf90bac62bf1306.PROP_ea968fd7cd9947c9a7ad44cbedac5dd9());
      }

      private sealed class MTHD_78c22f2d5c664d73900a1064220835f3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_78c22f2d5c664d73900a1064220835f3()
        {
          this.Initialize("get_uses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).uses;
        }
      }

      private sealed class MTHD_a13159533cb546b496494e1ff3139257 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a13159533cb546b496494e1ff3139257()
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

      private sealed class MTHD_fa6f7a69cfaa4ea0835ada1d07ab6c1c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fa6f7a69cfaa4ea0835ada1d07ab6c1c()
        {
          this.Initialize("get_maxUses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).maxUses;
        }
      }

      private sealed class MTHD_537e6e0b28774bfcb9bfd024ca61e1bf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_537e6e0b28774bfcb9bfd024ca61e1bf()
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

      private sealed class MTHD_3d87cce11a814779a93c05aa0b06ed19 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3d87cce11a814779a93c05aa0b06ed19()
        {
          this.Initialize("get_rechargeTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).rechargeTime;
        }
      }

      private sealed class MTHD_e37d3d91ecc74394b29a5216f8dfa808 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e37d3d91ecc74394b29a5216f8dfa808()
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

      private sealed class MTHD_99f5e37648ed4103a9027e056b9cd9bf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_99f5e37648ed4103a9027e056b9cd9bf()
        {
          this.Initialize("get_lastTurnFired", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).lastTurnFired;
        }
      }

      private sealed class MTHD_c420c957bcb64217b9639b3147dfe1df : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c420c957bcb64217b9639b3147dfe1df()
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

      private sealed class MTHD_5127a2c247e54b73a929b4b0b85dd42f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5127a2c247e54b73a929b4b0b85dd42f()
        {
          this.Initialize("get_isPresent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).isPresent;
        }
      }

      private sealed class MTHD_fe21d0ec5fdf456795a3a661a3a2191d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fe21d0ec5fdf456795a3a661a3a2191d()
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

      private sealed class MTHD_5d5877aec2074f3f97640d207929e7cf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5d5877aec2074f3f97640d207929e7cf()
        {
          this.Initialize("get_locked", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).locked;
        }
      }

      private sealed class MTHD_de29e2af941548eeb4e990beabdea8bb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_de29e2af941548eeb4e990beabdea8bb()
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

      private sealed class MTHD_04adc7ab404a4fd083e4601e1a922ccb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_04adc7ab404a4fd083e4601e1a922ccb()
        {
          this.Initialize("get_turnsTillFirstUse", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).turnsTillFirstUse;
        }
      }

      private sealed class MTHD_712abedfac00436a8b1702da82db6c95 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_712abedfac00436a8b1702da82db6c95()
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

      private sealed class MTHD_5ef2ce1a488e49cb9f767aa6e673b6d7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5ef2ce1a488e49cb9f767aa6e673b6d7()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class MTHD_6e3ff181f383467a92379a9397304558 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6e3ff181f383467a92379a9397304558()
        {
          this.Initialize("get_castType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class MTHD_c70b13d5b6fb4f86bc90ef995c36c3c2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c70b13d5b6fb4f86bc90ef995c36c3c2()
        {
          this.Initialize("get_damageType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class MTHD_b0acd742fd5c4bcdbd8f39b402c3ccac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b0acd742fd5c4bcdbd8f39b402c3ccac()
        {
          this.Initialize("get_book", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class MTHD_405f889c19be4fb3b44a926c692667cb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_405f889c19be4fb3b44a926c692667cb()
        {
          this.Initialize("get_damage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class MTHD_5ab6b4faad43476f9b9c64f88bb29b9c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5ab6b4faad43476f9b9c64f88bb29b9c()
        {
          this.Initialize("get_explosionRadius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class MTHD_a4d4b49b1a754242a0eb9c3d4f90d201 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a4d4b49b1a754242a0eb9c3d4f90d201()
        {
          this.Initialize("get_description", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class MTHD_be33b18fb5204e569ce47a412bda57a1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_be33b18fb5204e569ce47a412bda57a1()
        {
          this.Initialize("get_descriptionOnly", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class MTHD_1c61b871d7f146508a8d66b2a1f22cc1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1c61b871d7f146508a8d66b2a1f22cc1()
        {
          this.Initialize("get_descriptionExtra", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class MTHD_f00f0790728d428b93f44584a1a0da3b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f00f0790728d428b93f44584a1a0da3b()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }

      private sealed class MTHD_350bd6b1e1cc498cb9b8408f811d88b5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_350bd6b1e1cc498cb9b8408f811d88b5()
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

      private sealed class MTHD_304fab7779aa4b9c89a5f696387c9ac2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_304fab7779aa4b9c89a5f696387c9ac2()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_f2b4499d1fda4cbbb24fc4483e0544f6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f2b4499d1fda4cbbb24fc4483e0544f6()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_bf8aae5bfb644b8ab41a69b0ac8a8406 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bf8aae5bfb644b8ab41a69b0ac8a8406()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_cb46b6313ad0408aaac003bf3945b264 : HardwiredMemberDescriptor
      {
        internal PROP_cb46b6313ad0408aaac003bf3945b264()
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

      private sealed class PROP_d3b3c79ae1064da6ac36220e9608126c : HardwiredMemberDescriptor
      {
        internal PROP_d3b3c79ae1064da6ac36220e9608126c()
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

      private sealed class PROP_e176bae036a14e6387b3486c46f8ddcb : HardwiredMemberDescriptor
      {
        internal PROP_e176bae036a14e6387b3486c46f8ddcb()
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

      private sealed class PROP_8df43a61d13440638113f32dc93651ea : HardwiredMemberDescriptor
      {
        internal PROP_8df43a61d13440638113f32dc93651ea()
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

      private sealed class PROP_3479faecda954581986304ab5ebe5bc7 : HardwiredMemberDescriptor
      {
        internal PROP_3479faecda954581986304ab5ebe5bc7()
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

      private sealed class PROP_bed57194d3a049a1b021ae115473f57d : HardwiredMemberDescriptor
      {
        internal PROP_bed57194d3a049a1b021ae115473f57d()
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

      private sealed class PROP_1f85cfd76eb24be3b7bd2618555155ff : HardwiredMemberDescriptor
      {
        internal PROP_1f85cfd76eb24be3b7bd2618555155ff()
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

      private sealed class PROP_51cce8fc2e82489cae450bd04230c7a9 : HardwiredMemberDescriptor
      {
        internal PROP_51cce8fc2e82489cae450bd04230c7a9()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class PROP_95d216c1204e4c50888955e430933a08 : HardwiredMemberDescriptor
      {
        internal PROP_95d216c1204e4c50888955e430933a08()
          : base(typeof (CastType), "castType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class PROP_dd95d888e2a74d31b2af2aa92c999608 : HardwiredMemberDescriptor
      {
        internal PROP_dd95d888e2a74d31b2af2aa92c999608()
          : base(typeof (DamageType), "damageType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class PROP_60878290d59e47c58d075b7b20ff1195 : HardwiredMemberDescriptor
      {
        internal PROP_60878290d59e47c58d075b7b20ff1195()
          : base(typeof (BookOf), "book", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class PROP_90d13c42fe9f4b5eb1a9ef4b9453f315 : HardwiredMemberDescriptor
      {
        internal PROP_90d13c42fe9f4b5eb1a9ef4b9453f315()
          : base(typeof (int), "damage", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class PROP_8f4142e71950426aa39e4bd76e6efa36 : HardwiredMemberDescriptor
      {
        internal PROP_8f4142e71950426aa39e4bd76e6efa36()
          : base(typeof (int), "explosionRadius", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class PROP_96a540f969934c9387491ed4b8e3ca3d : HardwiredMemberDescriptor
      {
        internal PROP_96a540f969934c9387491ed4b8e3ca3d()
          : base(typeof (string), "description", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class PROP_a9bdb8a997a24746a4180a35ff33d655 : HardwiredMemberDescriptor
      {
        internal PROP_a9bdb8a997a24746a4180a35ff33d655()
          : base(typeof (string), "descriptionOnly", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class PROP_6b8f791e2ea04f70b0e70a855965ea2b : HardwiredMemberDescriptor
      {
        internal PROP_6b8f791e2ea04f70b0e70a855965ea2b()
          : base(typeof (string), "descriptionExtra", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class PROP_ea968fd7cd9947c9a7ad44cbedac5dd9 : HardwiredMemberDescriptor
      {
        internal PROP_ea968fd7cd9947c9a7ad44cbedac5dd9()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }
    }

    private sealed class TYPE_714124776a8c4271a7fa6ae42b8d45b2 : HardwiredUserDataDescriptor
    {
      internal TYPE_714124776a8c4271a7fa6ae42b8d45b2()
        : base(typeof (ContainerTower))
      {
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_714124776a8c4271a7fa6ae42b8d45b2.MTHD_1ca8cc7a158f4893865b2a6180c1758a()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_714124776a8c4271a7fa6ae42b8d45b2.MTHD_d7646246fd174b099ec4329a773d9c19()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_714124776a8c4271a7fa6ae42b8d45b2.MTHD_422924c41ed048b38a5dca20f81eddc4()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_714124776a8c4271a7fa6ae42b8d45b2.MTHD_b535c74078794de7abd84d30180861bc()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_714124776a8c4271a7fa6ae42b8d45b2.MTHD_c136f548183844749b0fa3c60a2a02be()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_714124776a8c4271a7fa6ae42b8d45b2.MTHD_a3de6255a7b04ba386b89b1958db2b07()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_714124776a8c4271a7fa6ae42b8d45b2.MTHD_779c5448153e4daeaa0a949da4d12f7a()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_714124776a8c4271a7fa6ae42b8d45b2.MTHD_1208744ee9884fd6b00bf8f47c0b90ca()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_714124776a8c4271a7fa6ae42b8d45b2.MTHD_dcb46ab8530e4262a764aa18eb944549()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_714124776a8c4271a7fa6ae42b8d45b2.MTHD_b6a84c7379c1452db50857ea7cf913b2()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_714124776a8c4271a7fa6ae42b8d45b2.MTHD_ff4c6fbf0f3449309122f2d0d40f147a()
        }));
        this.AddMember("getType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_714124776a8c4271a7fa6ae42b8d45b2.MTHD_4852472084ef449aa533d605e7bd1a7a()
        }));
        this.AddMember("kill", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("kill", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_714124776a8c4271a7fa6ae42b8d45b2.MTHD_e4c0ead8832a4864a12173031a576361()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_714124776a8c4271a7fa6ae42b8d45b2.MTHD_f1aef51e852743a3b1f69303d5ae5c9d()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_714124776a8c4271a7fa6ae42b8d45b2.MTHD_3d2e3ca77e8d4b81a77f863e5062d52e()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_714124776a8c4271a7fa6ae42b8d45b2.MTHD_e5a9023b8e964b96a2d30c7ca1133978()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_714124776a8c4271a7fa6ae42b8d45b2.MTHD_9cda1aa9a9a54fa0b19554f4a6848486()
        }));
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_714124776a8c4271a7fa6ae42b8d45b2.PROP_b94e5af87e1244799bcdca37769d72a2());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_714124776a8c4271a7fa6ae42b8d45b2.PROP_e9f685dda84f4c059a8ca4121d3e8fc1());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_714124776a8c4271a7fa6ae42b8d45b2.PROP_c369317779f642a9bcc11785af46a8bf());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_714124776a8c4271a7fa6ae42b8d45b2.PROP_4aa405539a3b4166a51fb2129a638f55());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_714124776a8c4271a7fa6ae42b8d45b2.PROP_69700ce6b7fe4cedbd588dedca9bdf37());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_714124776a8c4271a7fa6ae42b8d45b2.PROP_3b3c4bf5eebf4ee3b799b935227bc36a());
      }

      private sealed class MTHD_1ca8cc7a158f4893865b2a6180c1758a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1ca8cc7a158f4893865b2a6180c1758a()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).health;
        }
      }

      private sealed class MTHD_d7646246fd174b099ec4329a773d9c19 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d7646246fd174b099ec4329a773d9c19()
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

      private sealed class MTHD_422924c41ed048b38a5dca20f81eddc4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_422924c41ed048b38a5dca20f81eddc4()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).maxHealth;
        }
      }

      private sealed class MTHD_b535c74078794de7abd84d30180861bc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b535c74078794de7abd84d30180861bc()
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

      private sealed class MTHD_c136f548183844749b0fa3c60a2a02be : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c136f548183844749b0fa3c60a2a02be()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).x;
        }
      }

      private sealed class MTHD_a3de6255a7b04ba386b89b1958db2b07 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a3de6255a7b04ba386b89b1958db2b07()
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

      private sealed class MTHD_779c5448153e4daeaa0a949da4d12f7a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_779c5448153e4daeaa0a949da4d12f7a()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).y;
        }
      }

      private sealed class MTHD_1208744ee9884fd6b00bf8f47c0b90ca : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1208744ee9884fd6b00bf8f47c0b90ca()
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

      private sealed class MTHD_dcb46ab8530e4262a764aa18eb944549 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dcb46ab8530e4262a764aa18eb944549()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).position;
        }
      }

      private sealed class MTHD_b6a84c7379c1452db50857ea7cf913b2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b6a84c7379c1452db50857ea7cf913b2()
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

      private sealed class MTHD_ff4c6fbf0f3449309122f2d0d40f147a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ff4c6fbf0f3449309122f2d0d40f147a()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }

      private sealed class MTHD_4852472084ef449aa533d605e7bd1a7a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4852472084ef449aa533d605e7bd1a7a()
        {
          this.Initialize("getType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).getType();
        }
      }

      private sealed class MTHD_e4c0ead8832a4864a12173031a576361 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e4c0ead8832a4864a12173031a576361()
        {
          this.Initialize("kill", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerTower) obj).kill();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_f1aef51e852743a3b1f69303d5ae5c9d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f1aef51e852743a3b1f69303d5ae5c9d()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).GetHashCode();
        }
      }

      private sealed class MTHD_3d2e3ca77e8d4b81a77f863e5062d52e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3d2e3ca77e8d4b81a77f863e5062d52e()
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

      private sealed class MTHD_e5a9023b8e964b96a2d30c7ca1133978 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e5a9023b8e964b96a2d30c7ca1133978()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_9cda1aa9a9a54fa0b19554f4a6848486 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9cda1aa9a9a54fa0b19554f4a6848486()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_b94e5af87e1244799bcdca37769d72a2 : HardwiredMemberDescriptor
      {
        internal PROP_b94e5af87e1244799bcdca37769d72a2()
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

      private sealed class PROP_e9f685dda84f4c059a8ca4121d3e8fc1 : HardwiredMemberDescriptor
      {
        internal PROP_e9f685dda84f4c059a8ca4121d3e8fc1()
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

      private sealed class PROP_c369317779f642a9bcc11785af46a8bf : HardwiredMemberDescriptor
      {
        internal PROP_c369317779f642a9bcc11785af46a8bf()
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

      private sealed class PROP_4aa405539a3b4166a51fb2129a638f55 : HardwiredMemberDescriptor
      {
        internal PROP_4aa405539a3b4166a51fb2129a638f55()
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

      private sealed class PROP_69700ce6b7fe4cedbd588dedca9bdf37 : HardwiredMemberDescriptor
      {
        internal PROP_69700ce6b7fe4cedbd588dedca9bdf37()
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

      private sealed class PROP_3b3c4bf5eebf4ee3b799b935227bc36a : HardwiredMemberDescriptor
      {
        internal PROP_3b3c4bf5eebf4ee3b799b935227bc36a()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }
    }

    private sealed class TYPE_b040c9735f764ce3a6497ba208a832eb : HardwiredUserDataDescriptor
    {
      internal TYPE_b040c9735f764ce3a6497ba208a832eb()
        : base(typeof (Educative.Point))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b040c9735f764ce3a6497ba208a832eb.MTHD_159cb477f5e547fbb666d6895e60fb70(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b040c9735f764ce3a6497ba208a832eb.MTHD_550bb146b7fb4d86880bb1a406ec4842()
        }));
        this.AddMember("distance", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("distance", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b040c9735f764ce3a6497ba208a832eb.MTHD_1119034bc15848008a8c4625aa6dcd24(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b040c9735f764ce3a6497ba208a832eb.MTHD_df4442102c5c403183664fe2126712f3()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b040c9735f764ce3a6497ba208a832eb.MTHD_6b815990568d46359c5657c8fe3a010c()
        }));
        this.AddMember("copy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("copy", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b040c9735f764ce3a6497ba208a832eb.MTHD_3bf8a7a286bf49dcb2995795095b5c0c()
        }));
        this.AddMember("normalized", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalized", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b040c9735f764ce3a6497ba208a832eb.MTHD_97ec415d608142c3a93f7355795ea5b2()
        }));
        this.AddMember("normalize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalize", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b040c9735f764ce3a6497ba208a832eb.MTHD_5ca93d0f550e48568094b46874b2c2ed()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b040c9735f764ce3a6497ba208a832eb.MTHD_9c53220797fe463b9d181b472f40c2fb()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b040c9735f764ce3a6497ba208a832eb.MTHD_7de4af8b05ae44e3be7348f0d31cb1da()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b040c9735f764ce3a6497ba208a832eb.MTHD_7ad56386b38c4386a3bbf77eb451d4ab()
        }));
        this.AddMember("op_Subtraction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Subtraction", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b040c9735f764ce3a6497ba208a832eb.MTHD_cffc1ba0dd854207ae1251fd26dd426d(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b040c9735f764ce3a6497ba208a832eb.MTHD_b6283c2dace7497b8a26eb646b0fe9f6()
        }));
        this.AddMember("op_Addition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Addition", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b040c9735f764ce3a6497ba208a832eb.MTHD_6445bef7a24e4bfea963f14c4eb8a09a(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b040c9735f764ce3a6497ba208a832eb.MTHD_8cba7637c25944d09bc742f545c74adb()
        }));
        this.AddMember("op_Multiply", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Multiply", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b040c9735f764ce3a6497ba208a832eb.MTHD_ff3e382457f6403296a85d0092a81fde(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b040c9735f764ce3a6497ba208a832eb.MTHD_70cac09cde934375b713e27f3f83487b()
        }));
        this.AddMember("op_Division", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Division", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b040c9735f764ce3a6497ba208a832eb.MTHD_41b02e1842344181bbad60d1b9a90343(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b040c9735f764ce3a6497ba208a832eb.MTHD_4c5a0eff1b0842ad8210680b9c8781cb()
        }));
        this.AddMember("op_Modulus", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Modulus", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b040c9735f764ce3a6497ba208a832eb.MTHD_303c774f9375492fa439779861720a89(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b040c9735f764ce3a6497ba208a832eb.MTHD_9a26524eb804435d9c634fa3062c14d9()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b040c9735f764ce3a6497ba208a832eb.MTHD_71eb911dd22c40bc84b663f2c8eaf303()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b040c9735f764ce3a6497ba208a832eb.MTHD_a28c4db787584ceaa9f094496995775f()
        }));
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_b040c9735f764ce3a6497ba208a832eb.FLDV_f2d629fe3bfb45c4ab1cff9b09b3ae91());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_b040c9735f764ce3a6497ba208a832eb.FLDV_bece10bdc138447799d859c211425f95());
      }

      private sealed class MTHD_159cb477f5e547fbb666d6895e60fb70 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_159cb477f5e547fbb666d6895e60fb70()
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

      private sealed class MTHD_550bb146b7fb4d86880bb1a406ec4842 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_550bb146b7fb4d86880bb1a406ec4842()
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

      private sealed class MTHD_1119034bc15848008a8c4625aa6dcd24 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1119034bc15848008a8c4625aa6dcd24()
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

      private sealed class MTHD_df4442102c5c403183664fe2126712f3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_df4442102c5c403183664fe2126712f3()
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

      private sealed class MTHD_6b815990568d46359c5657c8fe3a010c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6b815990568d46359c5657c8fe3a010c()
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

      private sealed class MTHD_3bf8a7a286bf49dcb2995795095b5c0c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3bf8a7a286bf49dcb2995795095b5c0c()
        {
          this.Initialize("copy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).copy();
        }
      }

      private sealed class MTHD_97ec415d608142c3a93f7355795ea5b2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_97ec415d608142c3a93f7355795ea5b2()
        {
          this.Initialize("normalized", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).normalized();
        }
      }

      private sealed class MTHD_5ca93d0f550e48568094b46874b2c2ed : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5ca93d0f550e48568094b46874b2c2ed()
        {
          this.Initialize("normalize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((Educative.Point) obj).normalize();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_9c53220797fe463b9d181b472f40c2fb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9c53220797fe463b9d181b472f40c2fb()
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

      private sealed class MTHD_7de4af8b05ae44e3be7348f0d31cb1da : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7de4af8b05ae44e3be7348f0d31cb1da()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).GetHashCode();
        }
      }

      private sealed class MTHD_7ad56386b38c4386a3bbf77eb451d4ab : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7ad56386b38c4386a3bbf77eb451d4ab()
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

      private sealed class MTHD_cffc1ba0dd854207ae1251fd26dd426d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cffc1ba0dd854207ae1251fd26dd426d()
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

      private sealed class MTHD_b6283c2dace7497b8a26eb646b0fe9f6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b6283c2dace7497b8a26eb646b0fe9f6()
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

      private sealed class MTHD_6445bef7a24e4bfea963f14c4eb8a09a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6445bef7a24e4bfea963f14c4eb8a09a()
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

      private sealed class MTHD_8cba7637c25944d09bc742f545c74adb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8cba7637c25944d09bc742f545c74adb()
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

      private sealed class MTHD_ff3e382457f6403296a85d0092a81fde : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ff3e382457f6403296a85d0092a81fde()
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

      private sealed class MTHD_70cac09cde934375b713e27f3f83487b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_70cac09cde934375b713e27f3f83487b()
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

      private sealed class MTHD_41b02e1842344181bbad60d1b9a90343 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_41b02e1842344181bbad60d1b9a90343()
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

      private sealed class MTHD_4c5a0eff1b0842ad8210680b9c8781cb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4c5a0eff1b0842ad8210680b9c8781cb()
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

      private sealed class MTHD_303c774f9375492fa439779861720a89 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_303c774f9375492fa439779861720a89()
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

      private sealed class MTHD_9a26524eb804435d9c634fa3062c14d9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9a26524eb804435d9c634fa3062c14d9()
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

      private sealed class MTHD_71eb911dd22c40bc84b663f2c8eaf303 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_71eb911dd22c40bc84b663f2c8eaf303()
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

      private sealed class MTHD_a28c4db787584ceaa9f094496995775f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a28c4db787584ceaa9f094496995775f()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_f2d629fe3bfb45c4ab1cff9b09b3ae91 : HardwiredMemberDescriptor
      {
        internal FLDV_f2d629fe3bfb45c4ab1cff9b09b3ae91()
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

      private sealed class FLDV_bece10bdc138447799d859c211425f95 : HardwiredMemberDescriptor
      {
        internal FLDV_bece10bdc138447799d859c211425f95()
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

    private sealed class TYPE_ad2b55cc1eaa4f2fa27cf990878849ff : HardwiredUserDataDescriptor
    {
      internal TYPE_ad2b55cc1eaa4f2fa27cf990878849ff()
        : base(typeof (Summon))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ad2b55cc1eaa4f2fa27cf990878849ff.MTHD_490148cf6b024321b8ca635c901e8d9f()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ad2b55cc1eaa4f2fa27cf990878849ff.MTHD_019a07a814f941c7a6490eaeb19d9023()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ad2b55cc1eaa4f2fa27cf990878849ff.MTHD_42936501a8514919af8584c24e477c3c()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ad2b55cc1eaa4f2fa27cf990878849ff.MTHD_8a27a2a9e08a43178e9da0c2b2dbae6a()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ad2b55cc1eaa4f2fa27cf990878849ff.MTHD_df09ef7aafe0411aa2bac8b148c1bcac()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ad2b55cc1eaa4f2fa27cf990878849ff.MTHD_a08efeb0f28f4e08928efb9b20980634()
        }));
        this.AddMember("spell", (IMemberDescriptor) new Bridge.TYPE_ad2b55cc1eaa4f2fa27cf990878849ff.FLDV_59b55c97fdad4e87806fdb14136b25b5());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_ad2b55cc1eaa4f2fa27cf990878849ff.FLDV_23e94eca2d99483e8129af0dcacbd419());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_ad2b55cc1eaa4f2fa27cf990878849ff.FLDV_dd5be341cac74973a8ac1370e187c2f1());
        this.AddMember("onPlayersPanel", (IMemberDescriptor) new Bridge.TYPE_ad2b55cc1eaa4f2fa27cf990878849ff.FLDV_6fa1cfd2a53f4ccc841329470ea315cc());
        this.AddMember("useAI", (IMemberDescriptor) new Bridge.TYPE_ad2b55cc1eaa4f2fa27cf990878849ff.FLDV_2beb42f0ac034cd6b55d0333137b99e4());
        this.AddMember("no_AI_still_use_turn", (IMemberDescriptor) new Bridge.TYPE_ad2b55cc1eaa4f2fa27cf990878849ff.FLDV_21dbd93b616e4892851d3f505043a453());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_ad2b55cc1eaa4f2fa27cf990878849ff.FLDV_2378359a77914be08f85b0f6c479d6b4());
        this.AddMember("playSound", (IMemberDescriptor) new Bridge.TYPE_ad2b55cc1eaa4f2fa27cf990878849ff.FLDV_7c7531819a8f49d29bef499653f711c4());
        this.AddMember("prestige", (IMemberDescriptor) new Bridge.TYPE_ad2b55cc1eaa4f2fa27cf990878849ff.FLDV_dbc3464db8fb4320bdcbd68039984380());
        this.AddMember("colors", (IMemberDescriptor) new Bridge.TYPE_ad2b55cc1eaa4f2fa27cf990878849ff.FLDV_a3586ea1ac3d481881f222d9e385db09());
        this.AddMember("spells", (IMemberDescriptor) new Bridge.TYPE_ad2b55cc1eaa4f2fa27cf990878849ff.FLDV_518b2b4fec164ae2af52b54a18f497c0());
        this.AddMember("outfit", (IMemberDescriptor) new Bridge.TYPE_ad2b55cc1eaa4f2fa27cf990878849ff.FLDV_ab22262d286a4e078205fd02b1d04384());
        this.AddMember("elemental", (IMemberDescriptor) new Bridge.TYPE_ad2b55cc1eaa4f2fa27cf990878849ff.FLDV_dbe628dede7943e5b5a90f31607f49e0());
      }

      private sealed class MTHD_490148cf6b024321b8ca635c901e8d9f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_490148cf6b024321b8ca635c901e8d9f()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new Summon();
        }
      }

      private sealed class MTHD_019a07a814f941c7a6490eaeb19d9023 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_019a07a814f941c7a6490eaeb19d9023()
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

      private sealed class MTHD_42936501a8514919af8584c24e477c3c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_42936501a8514919af8584c24e477c3c()
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

      private sealed class MTHD_8a27a2a9e08a43178e9da0c2b2dbae6a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8a27a2a9e08a43178e9da0c2b2dbae6a()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_df09ef7aafe0411aa2bac8b148c1bcac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_df09ef7aafe0411aa2bac8b148c1bcac()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_a08efeb0f28f4e08928efb9b20980634 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a08efeb0f28f4e08928efb9b20980634()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_59b55c97fdad4e87806fdb14136b25b5 : HardwiredMemberDescriptor
      {
        internal FLDV_59b55c97fdad4e87806fdb14136b25b5()
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

      private sealed class FLDV_23e94eca2d99483e8129af0dcacbd419 : HardwiredMemberDescriptor
      {
        internal FLDV_23e94eca2d99483e8129af0dcacbd419()
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

      private sealed class FLDV_dd5be341cac74973a8ac1370e187c2f1 : HardwiredMemberDescriptor
      {
        internal FLDV_dd5be341cac74973a8ac1370e187c2f1()
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

      private sealed class FLDV_6fa1cfd2a53f4ccc841329470ea315cc : HardwiredMemberDescriptor
      {
        internal FLDV_6fa1cfd2a53f4ccc841329470ea315cc()
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

      private sealed class FLDV_2beb42f0ac034cd6b55d0333137b99e4 : HardwiredMemberDescriptor
      {
        internal FLDV_2beb42f0ac034cd6b55d0333137b99e4()
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

      private sealed class FLDV_21dbd93b616e4892851d3f505043a453 : HardwiredMemberDescriptor
      {
        internal FLDV_21dbd93b616e4892851d3f505043a453()
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

      private sealed class FLDV_2378359a77914be08f85b0f6c479d6b4 : HardwiredMemberDescriptor
      {
        internal FLDV_2378359a77914be08f85b0f6c479d6b4()
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

      private sealed class FLDV_7c7531819a8f49d29bef499653f711c4 : HardwiredMemberDescriptor
      {
        internal FLDV_7c7531819a8f49d29bef499653f711c4()
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

      private sealed class FLDV_dbc3464db8fb4320bdcbd68039984380 : HardwiredMemberDescriptor
      {
        internal FLDV_dbc3464db8fb4320bdcbd68039984380()
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

      private sealed class FLDV_a3586ea1ac3d481881f222d9e385db09 : HardwiredMemberDescriptor
      {
        internal FLDV_a3586ea1ac3d481881f222d9e385db09()
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

      private sealed class FLDV_518b2b4fec164ae2af52b54a18f497c0 : HardwiredMemberDescriptor
      {
        internal FLDV_518b2b4fec164ae2af52b54a18f497c0()
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

      private sealed class FLDV_ab22262d286a4e078205fd02b1d04384 : HardwiredMemberDescriptor
      {
        internal FLDV_ab22262d286a4e078205fd02b1d04384()
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

      private sealed class FLDV_dbe628dede7943e5b5a90f31607f49e0 : HardwiredMemberDescriptor
      {
        internal FLDV_dbe628dede7943e5b5a90f31607f49e0()
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

    private sealed class TYPE_626d783ccb4e4c13afefca8680b0df70 : HardwiredUserDataDescriptor
    {
      internal TYPE_626d783ccb4e4c13afefca8680b0df70()
        : base(typeof (UIElement))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_bed2c6a8c88b4aee83d53b5bfd8968ef()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_b169985e6fe642059fff735af504d44e()
        }));
        this.AddMember("get_visible", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_visible", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_6ee26706071e4359a4ec4247b7c6e3a9()
        }));
        this.AddMember("set_visible", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_visible", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_4270015f37bb42babdf43d1627456444()
        }));
        this.AddMember("get_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_eefa1325ba9743eba67aef835f08afd9()
        }));
        this.AddMember("set_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_1040b2d43de8442ebea554c79438d5f2()
        }));
        this.AddMember("get_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_aba6613148984a8da9d850d8e6cf828f()
        }));
        this.AddMember("set_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_b75bb5fe53ba4232babb72212767ae5e()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_48de87cfe5f04184a0667a3f5ea2a0d8()
        }));
        this.AddMember("set_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_90d41d17cda444cdb083437a0af8371e()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_22b814181dbe41cc99ddfdee9dd00239()
        }));
        this.AddMember("set_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_2fa103fa62f647bf842293a633cbf72b()
        }));
        this.AddMember("get_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_1a4c703619cb47b58e09a9251b2d54a8()
        }));
        this.AddMember("set_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_563867f8cc55469d87605ee73479d46a()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_1a24470366354cecba9008a9544f8020()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_cf8f8f29e683431097bf87943a820d19()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_2086345e984e4a82ad4d7b8bdaeb65fe()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_444a47d894a5437e9e21bd4f36d57186()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_3879f18bad764fef9817a8459b954080()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_b10a2d2dc2fc40b68ef5d987153a6f2c()
        }));
        this.AddMember("get_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_5d2e0f8219294ca29943920c82b8ce3c()
        }));
        this.AddMember("set_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_990d038e7e90456098566f3447a6909f()
        }));
        this.AddMember("get_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_eab03f800e8544148cd3e10feee097a6()
        }));
        this.AddMember("set_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_1576b2185c4f4f5f97a95e0ad1dfe95d()
        }));
        this.AddMember("get_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_16e8f3389fed4c639117aabcab91e7cf()
        }));
        this.AddMember("set_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_53c2106f48164aa4843e8b6130cf19db()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_864f71f65af248569fb520bb9171ecf9()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_ef63814af8144250a97be552201ee29b()
        }));
        this.AddMember("get_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_d5c97ab8d5e648fdae2a4116328aee79()
        }));
        this.AddMember("set_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_fd08febf5cdb4995bb402f9858625ce9()
        }));
        this.AddMember("get_onClick2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_d75738b1e4a44c2d8be41d83ff600b97()
        }));
        this.AddMember("set_onClick2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_7104566e1eb8464dbdc7a3b8e4efbcac()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_6416eb13df744e81a0ef9003617b9a08()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_b78cce300e5848aa952480e31cff5e0e()
        }));
        this.AddMember("get_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_181469ed18bf4f4dacba865861cab259()
        }));
        this.AddMember("set_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_98e5747fda1b448fa37ddafbbe3075d6()
        }));
        this.AddMember("get_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_75efa82389254ef881343e2b4f6c414f()
        }));
        this.AddMember("set_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_7097b62975a04c84b7be5d07567a9045()
        }));
        this.AddMember("get_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_4c3d338798b949fcb526df51fe79c6ea()
        }));
        this.AddMember("set_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_685d98429add4e318861d25db3ec11b3()
        }));
        this.AddMember("get_textColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_e1a84ad7ad744f92ae9c5acdefc17fc9()
        }));
        this.AddMember("set_textColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_5c01b0a840d540a29ed5db22ef320f24()
        }));
        this.AddMember("get_highlightColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_highlightColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_9bcea8593f8f4f5eaaf3bb25213376ca()
        }));
        this.AddMember("set_highlightColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_highlightColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_7cbfd73417da415dbc1b7f92039ad120()
        }));
        this.AddMember("get_highlightColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_highlightColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_a64ed6b60dfe433abb8413fc8207d606()
        }));
        this.AddMember("set_highlightColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_highlightColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_97f64976e54348d6bccdf4527605ed78()
        }));
        this.AddMember("get_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_acc39d7060a249289be25f9531fc95f3()
        }));
        this.AddMember("set_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_ddb3871edd8443f2a42596964176359f()
        }));
        this.AddMember("get_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_9cdfd80acb8843bfb8122a5e8559b0d4()
        }));
        this.AddMember("set_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_08d0b2972241499686698ac5c4fab7a1()
        }));
        this.AddMember("activateInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("activateInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_a3a5651c85db4f3882ef917261ce5777()
        }));
        this.AddMember("createUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createUI", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_9c29f7a97d864b63a0e36bc9a510f77e()
        }));
        this.AddMember("createInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_a703c7acd57a4450975b60ccf9a66fe9()
        }));
        this.AddMember("duplicate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("duplicate", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_3bcd6d863bd94e6893a1eb41af04d810()
        }));
        this.AddMember("destroyHierarchy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroyHierarchy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_e76f3a60a1e2400c8a9c16370dcee408()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_9a6f771f29864213a5c5aae6b5da8794()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_afc3df7c48e445f188f7b2acda016778()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_d80892f21f1343b0ae9347e9f0420405()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_3e12f282715348ceae15939a59a5ca82()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.MTHD_94a0919a1e0c451eb57857dabc418a50()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.PROP_6adb03fe5ee64e0480dbd2bb8da8e798());
        this.AddMember("visible", (IMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.PROP_2053394455c742959d27cb418160eeda());
        this.AddMember("graphic", (IMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.PROP_36e55fc03d1b47019f9e33f678b974bd());
        this.AddMember("anchor", (IMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.PROP_fa2aa6195d1d47bd89a9e7407e704fa0());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.PROP_baffc3900fb742d8b9c803b8cb9fd2b9());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.PROP_9a74ca9930b8483aa0558ac290995100());
        this.AddMember("size", (IMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.PROP_d72c2d451d664d948a10d2b083287024());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.PROP_f0a7268377d5462a927df2a9e569bcb7());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.PROP_8706b33d962045b0985b028e768d57f8());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.PROP_1dd260affd974426a7acf40aa2e4d991());
        this.AddMember("pivot_x", (IMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.PROP_72dcacba01e749b589d92688aad7f374());
        this.AddMember("pivot_y", (IMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.PROP_6cae3bc0adb94b9791fb0d7e8086371b());
        this.AddMember("pivot", (IMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.PROP_cd8d56b73c644b3fa90e1c7955bc24f2());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.PROP_bf49e8f9220046f5a88e93913e56569e());
        this.AddMember("onClick", (IMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.PROP_d9555eaeb1ed471ba48b5bed87829b12());
        this.AddMember("onClick2", (IMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.PROP_370f79f6aaec40d4b7fe96b5d95239f0());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.PROP_120cd544c2da4b7e8954adb6e0172533());
        this.AddMember("color2", (IMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.PROP_b9bea23bc7984fc5b5959e15e19b161f());
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.PROP_bc13a5d358484dedb1e8d7514830dd62());
        this.AddMember("textColor", (IMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.PROP_42d50f72b13c4f4dbbf971eb22256154());
        this.AddMember("textColor2", (IMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.PROP_6d7f0b9952554c4494abe462db8566a0());
        this.AddMember("highlightColor", (IMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.PROP_428fb57b74634f44a6a02b556e51dbe2());
        this.AddMember("highlightColor2", (IMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.PROP_4ee3d8d8a1c94c23a9efa908118c446a());
        this.AddMember("textStyle", (IMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.PROP_3c3b8cadb6f64eb3b4ab7a4f7174add8());
        this.AddMember("textSize", (IMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.PROP_a11be180e9ca4d5d8de14c5b95278b75());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.FLDV_f50149c6e09c4b3ea976dfce667f13f1());
        this.AddMember("clickID", (IMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.FLDV_93313154c47b4e0f8948a37e65ac9592());
        this.AddMember("clickDestroy", (IMemberDescriptor) new Bridge.TYPE_626d783ccb4e4c13afefca8680b0df70.FLDV_467b3148947948b1a63199fa7f1f1aa1());
      }

      private sealed class MTHD_bed2c6a8c88b4aee83d53b5bfd8968ef : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bed2c6a8c88b4aee83d53b5bfd8968ef()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new UIElement();
        }
      }

      private sealed class MTHD_b169985e6fe642059fff735af504d44e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b169985e6fe642059fff735af504d44e()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class MTHD_6ee26706071e4359a4ec4247b7c6e3a9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6ee26706071e4359a4ec4247b7c6e3a9()
        {
          this.Initialize("get_visible", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).visible;
        }
      }

      private sealed class MTHD_4270015f37bb42babdf43d1627456444 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4270015f37bb42babdf43d1627456444()
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

      private sealed class MTHD_eefa1325ba9743eba67aef835f08afd9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eefa1325ba9743eba67aef835f08afd9()
        {
          this.Initialize("get_graphic", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return ((UIElement) obj).graphic;
        }
      }

      private sealed class MTHD_1040b2d43de8442ebea554c79438d5f2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1040b2d43de8442ebea554c79438d5f2()
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

      private sealed class MTHD_aba6613148984a8da9d850d8e6cf828f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aba6613148984a8da9d850d8e6cf828f()
        {
          this.Initialize("get_anchor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).anchor;
        }
      }

      private sealed class MTHD_b75bb5fe53ba4232babb72212767ae5e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b75bb5fe53ba4232babb72212767ae5e()
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

      private sealed class MTHD_48de87cfe5f04184a0667a3f5ea2a0d8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_48de87cfe5f04184a0667a3f5ea2a0d8()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).width;
        }
      }

      private sealed class MTHD_90d41d17cda444cdb083437a0af8371e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_90d41d17cda444cdb083437a0af8371e()
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

      private sealed class MTHD_22b814181dbe41cc99ddfdee9dd00239 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_22b814181dbe41cc99ddfdee9dd00239()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).height;
        }
      }

      private sealed class MTHD_2fa103fa62f647bf842293a633cbf72b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2fa103fa62f647bf842293a633cbf72b()
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

      private sealed class MTHD_1a4c703619cb47b58e09a9251b2d54a8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1a4c703619cb47b58e09a9251b2d54a8()
        {
          this.Initialize("get_size", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).size;
        }
      }

      private sealed class MTHD_563867f8cc55469d87605ee73479d46a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_563867f8cc55469d87605ee73479d46a()
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

      private sealed class MTHD_1a24470366354cecba9008a9544f8020 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1a24470366354cecba9008a9544f8020()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).x;
        }
      }

      private sealed class MTHD_cf8f8f29e683431097bf87943a820d19 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cf8f8f29e683431097bf87943a820d19()
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

      private sealed class MTHD_2086345e984e4a82ad4d7b8bdaeb65fe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2086345e984e4a82ad4d7b8bdaeb65fe()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).y;
        }
      }

      private sealed class MTHD_444a47d894a5437e9e21bd4f36d57186 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_444a47d894a5437e9e21bd4f36d57186()
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

      private sealed class MTHD_3879f18bad764fef9817a8459b954080 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3879f18bad764fef9817a8459b954080()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).position;
        }
      }

      private sealed class MTHD_b10a2d2dc2fc40b68ef5d987153a6f2c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b10a2d2dc2fc40b68ef5d987153a6f2c()
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

      private sealed class MTHD_5d2e0f8219294ca29943920c82b8ce3c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5d2e0f8219294ca29943920c82b8ce3c()
        {
          this.Initialize("get_pivot_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_x;
        }
      }

      private sealed class MTHD_990d038e7e90456098566f3447a6909f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_990d038e7e90456098566f3447a6909f()
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

      private sealed class MTHD_eab03f800e8544148cd3e10feee097a6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eab03f800e8544148cd3e10feee097a6()
        {
          this.Initialize("get_pivot_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_y;
        }
      }

      private sealed class MTHD_1576b2185c4f4f5f97a95e0ad1dfe95d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1576b2185c4f4f5f97a95e0ad1dfe95d()
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

      private sealed class MTHD_16e8f3389fed4c639117aabcab91e7cf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_16e8f3389fed4c639117aabcab91e7cf()
        {
          this.Initialize("get_pivot", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot;
        }
      }

      private sealed class MTHD_53c2106f48164aa4843e8b6130cf19db : HardwiredMethodMemberDescriptor
      {
        internal MTHD_53c2106f48164aa4843e8b6130cf19db()
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

      private sealed class MTHD_864f71f65af248569fb520bb9171ecf9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_864f71f65af248569fb520bb9171ecf9()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).angle;
        }
      }

      private sealed class MTHD_ef63814af8144250a97be552201ee29b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ef63814af8144250a97be552201ee29b()
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

      private sealed class MTHD_d5c97ab8d5e648fdae2a4116328aee79 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d5c97ab8d5e648fdae2a4116328aee79()
        {
          this.Initialize("get_onClick", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick;
        }
      }

      private sealed class MTHD_fd08febf5cdb4995bb402f9858625ce9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fd08febf5cdb4995bb402f9858625ce9()
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

      private sealed class MTHD_d75738b1e4a44c2d8be41d83ff600b97 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d75738b1e4a44c2d8be41d83ff600b97()
        {
          this.Initialize("get_onClick2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick2;
        }
      }

      private sealed class MTHD_7104566e1eb8464dbdc7a3b8e4efbcac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7104566e1eb8464dbdc7a3b8e4efbcac()
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

      private sealed class MTHD_6416eb13df744e81a0ef9003617b9a08 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6416eb13df744e81a0ef9003617b9a08()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color;
        }
      }

      private sealed class MTHD_b78cce300e5848aa952480e31cff5e0e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b78cce300e5848aa952480e31cff5e0e()
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

      private sealed class MTHD_181469ed18bf4f4dacba865861cab259 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_181469ed18bf4f4dacba865861cab259()
        {
          this.Initialize("get_color2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color2;
        }
      }

      private sealed class MTHD_98e5747fda1b448fa37ddafbbe3075d6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_98e5747fda1b448fa37ddafbbe3075d6()
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

      private sealed class MTHD_75efa82389254ef881343e2b4f6c414f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_75efa82389254ef881343e2b4f6c414f()
        {
          this.Initialize("get_text", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).text;
        }
      }

      private sealed class MTHD_7097b62975a04c84b7be5d07567a9045 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7097b62975a04c84b7be5d07567a9045()
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

      private sealed class MTHD_4c3d338798b949fcb526df51fe79c6ea : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4c3d338798b949fcb526df51fe79c6ea()
        {
          this.Initialize("get_textColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor;
        }
      }

      private sealed class MTHD_685d98429add4e318861d25db3ec11b3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_685d98429add4e318861d25db3ec11b3()
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

      private sealed class MTHD_e1a84ad7ad744f92ae9c5acdefc17fc9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e1a84ad7ad744f92ae9c5acdefc17fc9()
        {
          this.Initialize("get_textColor2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor2;
        }
      }

      private sealed class MTHD_5c01b0a840d540a29ed5db22ef320f24 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5c01b0a840d540a29ed5db22ef320f24()
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

      private sealed class MTHD_9bcea8593f8f4f5eaaf3bb25213376ca : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9bcea8593f8f4f5eaaf3bb25213376ca()
        {
          this.Initialize("get_highlightColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).highlightColor;
        }
      }

      private sealed class MTHD_7cbfd73417da415dbc1b7f92039ad120 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7cbfd73417da415dbc1b7f92039ad120()
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

      private sealed class MTHD_a64ed6b60dfe433abb8413fc8207d606 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a64ed6b60dfe433abb8413fc8207d606()
        {
          this.Initialize("get_highlightColor2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).highlightColor2;
        }
      }

      private sealed class MTHD_97f64976e54348d6bccdf4527605ed78 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_97f64976e54348d6bccdf4527605ed78()
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

      private sealed class MTHD_acc39d7060a249289be25f9531fc95f3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_acc39d7060a249289be25f9531fc95f3()
        {
          this.Initialize("get_textStyle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textStyle;
        }
      }

      private sealed class MTHD_ddb3871edd8443f2a42596964176359f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ddb3871edd8443f2a42596964176359f()
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

      private sealed class MTHD_9cdfd80acb8843bfb8122a5e8559b0d4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9cdfd80acb8843bfb8122a5e8559b0d4()
        {
          this.Initialize("get_textSize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textSize;
        }
      }

      private sealed class MTHD_08d0b2972241499686698ac5c4fab7a1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_08d0b2972241499686698ac5c4fab7a1()
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

      private sealed class MTHD_a3a5651c85db4f3882ef917261ce5777 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a3a5651c85db4f3882ef917261ce5777()
        {
          this.Initialize("activateInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).activateInput();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_9c29f7a97d864b63a0e36bc9a510f77e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9c29f7a97d864b63a0e36bc9a510f77e()
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

      private sealed class MTHD_a703c7acd57a4450975b60ccf9a66fe9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a703c7acd57a4450975b60ccf9a66fe9()
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

      private sealed class MTHD_3bcd6d863bd94e6893a1eb41af04d810 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3bcd6d863bd94e6893a1eb41af04d810()
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

      private sealed class MTHD_e76f3a60a1e2400c8a9c16370dcee408 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e76f3a60a1e2400c8a9c16370dcee408()
        {
          this.Initialize("destroyHierarchy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroyHierarchy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_9a6f771f29864213a5c5aae6b5da8794 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9a6f771f29864213a5c5aae6b5da8794()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_afc3df7c48e445f188f7b2acda016778 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_afc3df7c48e445f188f7b2acda016778()
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

      private sealed class MTHD_d80892f21f1343b0ae9347e9f0420405 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d80892f21f1343b0ae9347e9f0420405()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_3e12f282715348ceae15939a59a5ca82 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3e12f282715348ceae15939a59a5ca82()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_94a0919a1e0c451eb57857dabc418a50 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_94a0919a1e0c451eb57857dabc418a50()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_6adb03fe5ee64e0480dbd2bb8da8e798 : HardwiredMemberDescriptor
      {
        internal PROP_6adb03fe5ee64e0480dbd2bb8da8e798()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class PROP_2053394455c742959d27cb418160eeda : HardwiredMemberDescriptor
      {
        internal PROP_2053394455c742959d27cb418160eeda()
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

      private sealed class PROP_36e55fc03d1b47019f9e33f678b974bd : HardwiredMemberDescriptor
      {
        internal PROP_36e55fc03d1b47019f9e33f678b974bd()
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

      private sealed class PROP_fa2aa6195d1d47bd89a9e7407e704fa0 : HardwiredMemberDescriptor
      {
        internal PROP_fa2aa6195d1d47bd89a9e7407e704fa0()
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

      private sealed class PROP_baffc3900fb742d8b9c803b8cb9fd2b9 : HardwiredMemberDescriptor
      {
        internal PROP_baffc3900fb742d8b9c803b8cb9fd2b9()
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

      private sealed class PROP_9a74ca9930b8483aa0558ac290995100 : HardwiredMemberDescriptor
      {
        internal PROP_9a74ca9930b8483aa0558ac290995100()
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

      private sealed class PROP_d72c2d451d664d948a10d2b083287024 : HardwiredMemberDescriptor
      {
        internal PROP_d72c2d451d664d948a10d2b083287024()
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

      private sealed class PROP_f0a7268377d5462a927df2a9e569bcb7 : HardwiredMemberDescriptor
      {
        internal PROP_f0a7268377d5462a927df2a9e569bcb7()
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

      private sealed class PROP_8706b33d962045b0985b028e768d57f8 : HardwiredMemberDescriptor
      {
        internal PROP_8706b33d962045b0985b028e768d57f8()
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

      private sealed class PROP_1dd260affd974426a7acf40aa2e4d991 : HardwiredMemberDescriptor
      {
        internal PROP_1dd260affd974426a7acf40aa2e4d991()
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

      private sealed class PROP_72dcacba01e749b589d92688aad7f374 : HardwiredMemberDescriptor
      {
        internal PROP_72dcacba01e749b589d92688aad7f374()
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

      private sealed class PROP_6cae3bc0adb94b9791fb0d7e8086371b : HardwiredMemberDescriptor
      {
        internal PROP_6cae3bc0adb94b9791fb0d7e8086371b()
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

      private sealed class PROP_cd8d56b73c644b3fa90e1c7955bc24f2 : HardwiredMemberDescriptor
      {
        internal PROP_cd8d56b73c644b3fa90e1c7955bc24f2()
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

      private sealed class PROP_bf49e8f9220046f5a88e93913e56569e : HardwiredMemberDescriptor
      {
        internal PROP_bf49e8f9220046f5a88e93913e56569e()
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

      private sealed class PROP_d9555eaeb1ed471ba48b5bed87829b12 : HardwiredMemberDescriptor
      {
        internal PROP_d9555eaeb1ed471ba48b5bed87829b12()
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

      private sealed class PROP_370f79f6aaec40d4b7fe96b5d95239f0 : HardwiredMemberDescriptor
      {
        internal PROP_370f79f6aaec40d4b7fe96b5d95239f0()
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

      private sealed class PROP_120cd544c2da4b7e8954adb6e0172533 : HardwiredMemberDescriptor
      {
        internal PROP_120cd544c2da4b7e8954adb6e0172533()
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

      private sealed class PROP_b9bea23bc7984fc5b5959e15e19b161f : HardwiredMemberDescriptor
      {
        internal PROP_b9bea23bc7984fc5b5959e15e19b161f()
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

      private sealed class PROP_bc13a5d358484dedb1e8d7514830dd62 : HardwiredMemberDescriptor
      {
        internal PROP_bc13a5d358484dedb1e8d7514830dd62()
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

      private sealed class PROP_42d50f72b13c4f4dbbf971eb22256154 : HardwiredMemberDescriptor
      {
        internal PROP_42d50f72b13c4f4dbbf971eb22256154()
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

      private sealed class PROP_6d7f0b9952554c4494abe462db8566a0 : HardwiredMemberDescriptor
      {
        internal PROP_6d7f0b9952554c4494abe462db8566a0()
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

      private sealed class PROP_428fb57b74634f44a6a02b556e51dbe2 : HardwiredMemberDescriptor
      {
        internal PROP_428fb57b74634f44a6a02b556e51dbe2()
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

      private sealed class PROP_4ee3d8d8a1c94c23a9efa908118c446a : HardwiredMemberDescriptor
      {
        internal PROP_4ee3d8d8a1c94c23a9efa908118c446a()
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

      private sealed class PROP_3c3b8cadb6f64eb3b4ab7a4f7174add8 : HardwiredMemberDescriptor
      {
        internal PROP_3c3b8cadb6f64eb3b4ab7a4f7174add8()
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

      private sealed class PROP_a11be180e9ca4d5d8de14c5b95278b75 : HardwiredMemberDescriptor
      {
        internal PROP_a11be180e9ca4d5d8de14c5b95278b75()
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

      private sealed class FLDV_f50149c6e09c4b3ea976dfce667f13f1 : HardwiredMemberDescriptor
      {
        internal FLDV_f50149c6e09c4b3ea976dfce667f13f1()
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

      private sealed class FLDV_93313154c47b4e0f8948a37e65ac9592 : HardwiredMemberDescriptor
      {
        internal FLDV_93313154c47b4e0f8948a37e65ac9592()
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

      private sealed class FLDV_467b3148947948b1a63199fa7f1f1aa1 : HardwiredMemberDescriptor
      {
        internal FLDV_467b3148947948b1a63199fa7f1f1aa1()
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

    private sealed class TYPE_a9e0ec7a4c944a1d9cfe617880c4b430 : HardwiredUserDataDescriptor
    {
      internal TYPE_a9e0ec7a4c944a1d9cfe617880c4b430()
        : base(typeof (MyPoll.Item))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a9e0ec7a4c944a1d9cfe617880c4b430.MTHD_3de5b95dec4d444aa5a9df2f65812f53()
        }));
        this.AddMember("addAnswer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addAnswer", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a9e0ec7a4c944a1d9cfe617880c4b430.MTHD_9bd0ed1895504dc7b8a86a2d64f50a72()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a9e0ec7a4c944a1d9cfe617880c4b430.MTHD_f1ddc2ddf4d943be99ea035a206049c7()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a9e0ec7a4c944a1d9cfe617880c4b430.MTHD_7bc308740ae042f88304ec2a2ee6455d()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a9e0ec7a4c944a1d9cfe617880c4b430.MTHD_3b8a6da23aff443d9b9de3b86405b48e()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a9e0ec7a4c944a1d9cfe617880c4b430.MTHD_b32fdb0c589c4c6da4052060d9e39d1e()
        }));
        this.AddMember("question", (IMemberDescriptor) new Bridge.TYPE_a9e0ec7a4c944a1d9cfe617880c4b430.FLDV_bfee9f4112854465b5ddae53b31ebd8f());
        this.AddMember("multipleSelection", (IMemberDescriptor) new Bridge.TYPE_a9e0ec7a4c944a1d9cfe617880c4b430.FLDV_65ba5ee67e4a440e9779195d79ccb1f6());
        this.AddMember("requiresAnswer", (IMemberDescriptor) new Bridge.TYPE_a9e0ec7a4c944a1d9cfe617880c4b430.FLDV_f05ea0be457642f49d7707c05f0a457f());
        this.AddMember("answers", (IMemberDescriptor) new Bridge.TYPE_a9e0ec7a4c944a1d9cfe617880c4b430.FLDV_638a84d3ad7949808b54c8ac7c3f60ed());
      }

      private sealed class MTHD_3de5b95dec4d444aa5a9df2f65812f53 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3de5b95dec4d444aa5a9df2f65812f53()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Item();
        }
      }

      private sealed class MTHD_9bd0ed1895504dc7b8a86a2d64f50a72 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9bd0ed1895504dc7b8a86a2d64f50a72()
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

      private sealed class MTHD_f1ddc2ddf4d943be99ea035a206049c7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f1ddc2ddf4d943be99ea035a206049c7()
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

      private sealed class MTHD_7bc308740ae042f88304ec2a2ee6455d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7bc308740ae042f88304ec2a2ee6455d()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_3b8a6da23aff443d9b9de3b86405b48e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3b8a6da23aff443d9b9de3b86405b48e()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_b32fdb0c589c4c6da4052060d9e39d1e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b32fdb0c589c4c6da4052060d9e39d1e()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_bfee9f4112854465b5ddae53b31ebd8f : HardwiredMemberDescriptor
      {
        internal FLDV_bfee9f4112854465b5ddae53b31ebd8f()
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

      private sealed class FLDV_65ba5ee67e4a440e9779195d79ccb1f6 : HardwiredMemberDescriptor
      {
        internal FLDV_65ba5ee67e4a440e9779195d79ccb1f6()
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

      private sealed class FLDV_f05ea0be457642f49d7707c05f0a457f : HardwiredMemberDescriptor
      {
        internal FLDV_f05ea0be457642f49d7707c05f0a457f()
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

      private sealed class FLDV_638a84d3ad7949808b54c8ac7c3f60ed : HardwiredMemberDescriptor
      {
        internal FLDV_638a84d3ad7949808b54c8ac7c3f60ed()
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

    private sealed class TYPE_2fee70b8a3bd4e2fa2aeb1d4901aaf68 : HardwiredUserDataDescriptor
    {
      internal TYPE_2fee70b8a3bd4e2fa2aeb1d4901aaf68()
        : base(typeof (MyPoll.Answer))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2fee70b8a3bd4e2fa2aeb1d4901aaf68.MTHD_01ec17e4c1bc4892857a071b4ca937e8()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2fee70b8a3bd4e2fa2aeb1d4901aaf68.MTHD_07e99a72e8ab4801af259cdfce97fa78()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2fee70b8a3bd4e2fa2aeb1d4901aaf68.MTHD_185c8d1c9fed4c0fa3a28f692265b7dc()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2fee70b8a3bd4e2fa2aeb1d4901aaf68.MTHD_a2237c894a7f4149be393b69cffb7e64()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2fee70b8a3bd4e2fa2aeb1d4901aaf68.MTHD_d07be981d22c40c483fd6608d0dee0c3()
        }));
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_2fee70b8a3bd4e2fa2aeb1d4901aaf68.FLDV_77903a70eab04f409f36fec859a60529());
        this.AddMember("allowUserInput", (IMemberDescriptor) new Bridge.TYPE_2fee70b8a3bd4e2fa2aeb1d4901aaf68.FLDV_36690afcd5924e56ba76f0554b6114fb());
        this.AddMember("checkable", (IMemberDescriptor) new Bridge.TYPE_2fee70b8a3bd4e2fa2aeb1d4901aaf68.FLDV_b05237d16d8d438b978cb148a00aa124());
        this.AddMember("userInput", (IMemberDescriptor) new Bridge.TYPE_2fee70b8a3bd4e2fa2aeb1d4901aaf68.FLDV_87c5784d10934ff7bdcc1d334d903c9e());
        this.AddMember("isChecked", (IMemberDescriptor) new Bridge.TYPE_2fee70b8a3bd4e2fa2aeb1d4901aaf68.FLDV_bc8d495ddf584bb0ab6d67860d7ca554());
      }

      private sealed class MTHD_01ec17e4c1bc4892857a071b4ca937e8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_01ec17e4c1bc4892857a071b4ca937e8()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Answer();
        }
      }

      private sealed class MTHD_07e99a72e8ab4801af259cdfce97fa78 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_07e99a72e8ab4801af259cdfce97fa78()
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

      private sealed class MTHD_185c8d1c9fed4c0fa3a28f692265b7dc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_185c8d1c9fed4c0fa3a28f692265b7dc()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_a2237c894a7f4149be393b69cffb7e64 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a2237c894a7f4149be393b69cffb7e64()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_d07be981d22c40c483fd6608d0dee0c3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d07be981d22c40c483fd6608d0dee0c3()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_77903a70eab04f409f36fec859a60529 : HardwiredMemberDescriptor
      {
        internal FLDV_77903a70eab04f409f36fec859a60529()
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

      private sealed class FLDV_36690afcd5924e56ba76f0554b6114fb : HardwiredMemberDescriptor
      {
        internal FLDV_36690afcd5924e56ba76f0554b6114fb()
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

      private sealed class FLDV_b05237d16d8d438b978cb148a00aa124 : HardwiredMemberDescriptor
      {
        internal FLDV_b05237d16d8d438b978cb148a00aa124()
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

      private sealed class FLDV_87c5784d10934ff7bdcc1d334d903c9e : HardwiredMemberDescriptor
      {
        internal FLDV_87c5784d10934ff7bdcc1d334d903c9e()
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

      private sealed class FLDV_bc8d495ddf584bb0ab6d67860d7ca554 : HardwiredMemberDescriptor
      {
        internal FLDV_bc8d495ddf584bb0ab6d67860d7ca554()
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

    private sealed class TYPE_f2366f6bc0dc47648a80f3de380c0dac : HardwiredUserDataDescriptor
    {
      internal TYPE_f2366f6bc0dc47648a80f3de380c0dac()
        : base(typeof (MyPoll))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f2366f6bc0dc47648a80f3de380c0dac.MTHD_85387e6e00794851aca6e9a392306442()
        }));
        this.AddMember("GetQuestionsAsString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetQuestionsAsString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f2366f6bc0dc47648a80f3de380c0dac.MTHD_314234b55d5d46b6b5944383ca460d9c()
        }));
        this.AddMember("SanitizeResponses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("SanitizeResponses", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f2366f6bc0dc47648a80f3de380c0dac.MTHD_e7a46fce03014dff8b1aa3098861a405()
        }));
        this.AddMember("addItem", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addItem", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f2366f6bc0dc47648a80f3de380c0dac.MTHD_3dfd3d162fac4aa2bdb7a668ff2ee599()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f2366f6bc0dc47648a80f3de380c0dac.MTHD_858f0ee6947e4ed0a8fa45aad77ea689()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f2366f6bc0dc47648a80f3de380c0dac.MTHD_b05a5406d7684ddb8cf60d0b28034a3f()
        }));
        this.AddMember("fromString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fromString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f2366f6bc0dc47648a80f3de380c0dac.MTHD_515741fee7874df08d076be265b3db5e()
        }));
        this.AddMember("sendToServer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("sendToServer", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f2366f6bc0dc47648a80f3de380c0dac.MTHD_1154848a4e594757ac1b4ab17a828de7()
        }));
        this.AddMember("closePoll", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("closePoll", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f2366f6bc0dc47648a80f3de380c0dac.MTHD_e46fe602dbb74a9196b549c8a0b4d63a()
        }));
        this.AddMember("test", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("test", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f2366f6bc0dc47648a80f3de380c0dac.MTHD_ecb807fc5e58492caf691029cc161767()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f2366f6bc0dc47648a80f3de380c0dac.MTHD_45caca389be942e38b7c9e38c31805ae()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f2366f6bc0dc47648a80f3de380c0dac.MTHD_0e975b942adc46c4a0da569b89eb7c83()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f2366f6bc0dc47648a80f3de380c0dac.MTHD_810f2252d3c54e068eec4693b313dd5e()
        }));
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_f2366f6bc0dc47648a80f3de380c0dac.FLDV_2bdb86d792e44abd890b0d981965543e());
        this.AddMember("id", (IMemberDescriptor) new Bridge.TYPE_f2366f6bc0dc47648a80f3de380c0dac.FLDV_40c8ba92e90d4eceaec999112426a296());
        this.AddMember("items", (IMemberDescriptor) new Bridge.TYPE_f2366f6bc0dc47648a80f3de380c0dac.FLDV_bf7bc09948fb4a63a39a3625a9c0f91a());
        this.AddMember("isPublic", (IMemberDescriptor) new Bridge.TYPE_f2366f6bc0dc47648a80f3de380c0dac.FLDV_177bbefa68404aaaacd62a7c68948d5f());
        this.AddMember("MsgRetrieve", (IMemberDescriptor) new Bridge.TYPE_f2366f6bc0dc47648a80f3de380c0dac.FLDV_e344b0e1298d47b5acb5d924d8105ea9());
        this.AddMember("MsgSubmit", (IMemberDescriptor) new Bridge.TYPE_f2366f6bc0dc47648a80f3de380c0dac.FLDV_6923d27dae4f4eafbc992a312047ae1e());
        this.AddMember("MsgCreate", (IMemberDescriptor) new Bridge.TYPE_f2366f6bc0dc47648a80f3de380c0dac.FLDV_73002b28ce4548a586819efc49fe7cc7());
        this.AddMember("MsgResults", (IMemberDescriptor) new Bridge.TYPE_f2366f6bc0dc47648a80f3de380c0dac.FLDV_c26e33e3b7e34da7be6f3a22720dd06e());
        this.AddMember("Item", (IMemberDescriptor) new Bridge.TYPE_f2366f6bc0dc47648a80f3de380c0dac.DVAL_9ca881ebcf55443eabcc5131a46a67ab());
        this.AddMember("Answer", (IMemberDescriptor) new Bridge.TYPE_f2366f6bc0dc47648a80f3de380c0dac.DVAL_f0dd9e31c22846cead2ac054c2117563());
      }

      private sealed class MTHD_85387e6e00794851aca6e9a392306442 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_85387e6e00794851aca6e9a392306442()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll();
        }
      }

      private sealed class MTHD_314234b55d5d46b6b5944383ca460d9c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_314234b55d5d46b6b5944383ca460d9c()
        {
          this.Initialize("GetQuestionsAsString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).GetQuestionsAsString();
        }
      }

      private sealed class MTHD_e7a46fce03014dff8b1aa3098861a405 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e7a46fce03014dff8b1aa3098861a405()
        {
          this.Initialize("SanitizeResponses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).SanitizeResponses();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_3dfd3d162fac4aa2bdb7a668ff2ee599 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3dfd3d162fac4aa2bdb7a668ff2ee599()
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

      private sealed class MTHD_858f0ee6947e4ed0a8fa45aad77ea689 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_858f0ee6947e4ed0a8fa45aad77ea689()
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

      private sealed class MTHD_b05a5406d7684ddb8cf60d0b28034a3f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b05a5406d7684ddb8cf60d0b28034a3f()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).ToString();
        }
      }

      private sealed class MTHD_515741fee7874df08d076be265b3db5e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_515741fee7874df08d076be265b3db5e()
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

      private sealed class MTHD_1154848a4e594757ac1b4ab17a828de7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1154848a4e594757ac1b4ab17a828de7()
        {
          this.Initialize("sendToServer", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).sendToServer();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_e46fe602dbb74a9196b549c8a0b4d63a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e46fe602dbb74a9196b549c8a0b4d63a()
        {
          this.Initialize("closePoll", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          MyPoll.closePoll();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_ecb807fc5e58492caf691029cc161767 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ecb807fc5e58492caf691029cc161767()
        {
          this.Initialize("test", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).test();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_45caca389be942e38b7c9e38c31805ae : HardwiredMethodMemberDescriptor
      {
        internal MTHD_45caca389be942e38b7c9e38c31805ae()
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

      private sealed class MTHD_0e975b942adc46c4a0da569b89eb7c83 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0e975b942adc46c4a0da569b89eb7c83()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_810f2252d3c54e068eec4693b313dd5e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_810f2252d3c54e068eec4693b313dd5e()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_2bdb86d792e44abd890b0d981965543e : HardwiredMemberDescriptor
      {
        internal FLDV_2bdb86d792e44abd890b0d981965543e()
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

      private sealed class FLDV_40c8ba92e90d4eceaec999112426a296 : HardwiredMemberDescriptor
      {
        internal FLDV_40c8ba92e90d4eceaec999112426a296()
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

      private sealed class FLDV_bf7bc09948fb4a63a39a3625a9c0f91a : HardwiredMemberDescriptor
      {
        internal FLDV_bf7bc09948fb4a63a39a3625a9c0f91a()
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

      private sealed class FLDV_177bbefa68404aaaacd62a7c68948d5f : HardwiredMemberDescriptor
      {
        internal FLDV_177bbefa68404aaaacd62a7c68948d5f()
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

      private sealed class FLDV_e344b0e1298d47b5acb5d924d8105ea9 : HardwiredMemberDescriptor
      {
        internal FLDV_e344b0e1298d47b5acb5d924d8105ea9()
          : base(typeof (byte), "MsgRetrieve", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 1;
        }
      }

      private sealed class FLDV_6923d27dae4f4eafbc992a312047ae1e : HardwiredMemberDescriptor
      {
        internal FLDV_6923d27dae4f4eafbc992a312047ae1e()
          : base(typeof (byte), "MsgSubmit", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 2;
        }
      }

      private sealed class FLDV_73002b28ce4548a586819efc49fe7cc7 : HardwiredMemberDescriptor
      {
        internal FLDV_73002b28ce4548a586819efc49fe7cc7()
          : base(typeof (byte), "MsgCreate", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 3;
        }
      }

      private sealed class FLDV_c26e33e3b7e34da7be6f3a22720dd06e : HardwiredMemberDescriptor
      {
        internal FLDV_c26e33e3b7e34da7be6f3a22720dd06e()
          : base(typeof (byte), "MsgResults", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 4;
        }
      }

      private sealed class DVAL_9ca881ebcf55443eabcc5131a46a67ab : DynValueMemberDescriptor
      {
        internal DVAL_9ca881ebcf55443eabcc5131a46a67ab()
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

      private sealed class DVAL_f0dd9e31c22846cead2ac054c2117563 : DynValueMemberDescriptor
      {
        internal DVAL_f0dd9e31c22846cead2ac054c2117563()
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

    private sealed class TYPE_3180108a70c94607a7eb760e2ab9279f : HardwiredUserDataDescriptor
    {
      internal TYPE_3180108a70c94607a7eb760e2ab9279f()
        : base(typeof (LuaColor))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3180108a70c94607a7eb760e2ab9279f.MTHD_a462982423be4d21ae7cff0579ef9e5e()
        }));
        this.AddMember("toHex", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("toHex", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3180108a70c94607a7eb760e2ab9279f.MTHD_c2c83b0f8958465c90ad58b7fa24148a()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3180108a70c94607a7eb760e2ab9279f.MTHD_07931ffd898a4a1786adb805e9be76fa(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3180108a70c94607a7eb760e2ab9279f.MTHD_61b34a5b8ddc410d8e6706c761c39254()
        }));
        this.AddMember("From", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("From", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3180108a70c94607a7eb760e2ab9279f.MTHD_e36d37f6dc014655baa6455f2711e0d1(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3180108a70c94607a7eb760e2ab9279f.MTHD_eca0dfb1eac3432a9e2bc38ab6730a18()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3180108a70c94607a7eb760e2ab9279f.MTHD_6e94585dbafd49a6ab5283d7d8b43c4a()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3180108a70c94607a7eb760e2ab9279f.MTHD_4ec30df60c964efabe1168180265baa8()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3180108a70c94607a7eb760e2ab9279f.MTHD_e59da5c8013a4415975d75a6e001502b()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3180108a70c94607a7eb760e2ab9279f.MTHD_51242aa9c7b4473eb893f332adbe5dbb()
        }));
        this.AddMember("r", (IMemberDescriptor) new Bridge.TYPE_3180108a70c94607a7eb760e2ab9279f.FLDV_c051662b4ce345a7968ed036fec4cb09());
        this.AddMember("g", (IMemberDescriptor) new Bridge.TYPE_3180108a70c94607a7eb760e2ab9279f.FLDV_6c1dbeb53eae4a568c109ce0af386a4c());
        this.AddMember("b", (IMemberDescriptor) new Bridge.TYPE_3180108a70c94607a7eb760e2ab9279f.FLDV_53b2aae88a0f4a8a906f27479d9136ff());
        this.AddMember("a", (IMemberDescriptor) new Bridge.TYPE_3180108a70c94607a7eb760e2ab9279f.FLDV_bd825efc404142eba7a80568e5eb804a());
        this.AddMember("white", (IMemberDescriptor) new Bridge.TYPE_3180108a70c94607a7eb760e2ab9279f.FLDV_1eea45209501435082f2db0fc2077030());
      }

      private sealed class MTHD_a462982423be4d21ae7cff0579ef9e5e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a462982423be4d21ae7cff0579ef9e5e()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new LuaColor();
        }
      }

      private sealed class MTHD_c2c83b0f8958465c90ad58b7fa24148a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c2c83b0f8958465c90ad58b7fa24148a()
        {
          this.Initialize("toHex", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((LuaColor) obj).toHex();
        }
      }

      private sealed class MTHD_07931ffd898a4a1786adb805e9be76fa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_07931ffd898a4a1786adb805e9be76fa()
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

      private sealed class MTHD_61b34a5b8ddc410d8e6706c761c39254 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_61b34a5b8ddc410d8e6706c761c39254()
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

      private sealed class MTHD_e36d37f6dc014655baa6455f2711e0d1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e36d37f6dc014655baa6455f2711e0d1()
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

      private sealed class MTHD_eca0dfb1eac3432a9e2bc38ab6730a18 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eca0dfb1eac3432a9e2bc38ab6730a18()
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

      private sealed class MTHD_6e94585dbafd49a6ab5283d7d8b43c4a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6e94585dbafd49a6ab5283d7d8b43c4a()
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

      private sealed class MTHD_4ec30df60c964efabe1168180265baa8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4ec30df60c964efabe1168180265baa8()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_e59da5c8013a4415975d75a6e001502b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e59da5c8013a4415975d75a6e001502b()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_51242aa9c7b4473eb893f332adbe5dbb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_51242aa9c7b4473eb893f332adbe5dbb()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_c051662b4ce345a7968ed036fec4cb09 : HardwiredMemberDescriptor
      {
        internal FLDV_c051662b4ce345a7968ed036fec4cb09()
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

      private sealed class FLDV_6c1dbeb53eae4a568c109ce0af386a4c : HardwiredMemberDescriptor
      {
        internal FLDV_6c1dbeb53eae4a568c109ce0af386a4c()
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

      private sealed class FLDV_53b2aae88a0f4a8a906f27479d9136ff : HardwiredMemberDescriptor
      {
        internal FLDV_53b2aae88a0f4a8a906f27479d9136ff()
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

      private sealed class FLDV_bd825efc404142eba7a80568e5eb804a : HardwiredMemberDescriptor
      {
        internal FLDV_bd825efc404142eba7a80568e5eb804a()
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

      private sealed class FLDV_1eea45209501435082f2db0fc2077030 : HardwiredMemberDescriptor
      {
        internal FLDV_1eea45209501435082f2db0fc2077030()
          : base(typeof (LuaColor), "white", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) LuaColor.white;
        }
      }
    }

    private sealed class TYPE_637167e11d77431dad8b07281596f882 : HardwiredUserDataDescriptor
    {
      internal TYPE_637167e11d77431dad8b07281596f882()
        : base(typeof (TalkOptions))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_637167e11d77431dad8b07281596f882.MTHD_44ba43df838449c5a06545526b41fd46()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_637167e11d77431dad8b07281596f882.MTHD_416f97a0251e426dbcf1f94113340817()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_637167e11d77431dad8b07281596f882.MTHD_1117f85f152c45a28187680d5a161a62()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_637167e11d77431dad8b07281596f882.MTHD_dbc9c9b8703d4a678d424fcd2ca63c5a()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_637167e11d77431dad8b07281596f882.MTHD_409b7c7c84c545429e0d9bb201f9021d()
        }));
      }

      private sealed class MTHD_44ba43df838449c5a06545526b41fd46 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_44ba43df838449c5a06545526b41fd46()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new TalkOptions();
        }
      }

      private sealed class MTHD_416f97a0251e426dbcf1f94113340817 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_416f97a0251e426dbcf1f94113340817()
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

      private sealed class MTHD_1117f85f152c45a28187680d5a161a62 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1117f85f152c45a28187680d5a161a62()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_dbc9c9b8703d4a678d424fcd2ca63c5a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dbc9c9b8703d4a678d424fcd2ca63c5a()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_409b7c7c84c545429e0d9bb201f9021d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_409b7c7c84c545429e0d9bb201f9021d()
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
