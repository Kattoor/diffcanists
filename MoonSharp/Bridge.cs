
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
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_63e41aa2399241de936f9d0e3cca64eb());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_3537cb9d4d4e4b299135923c102ff5cd());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_581b06d047ba4597a4c2ac65495a0827());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_6a155dac15874566bf665a4981ed2ff1());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_74af1a6cc35648a5a3e139d2a0eb8011());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_c8e24ec930764cf9a4add3d694cd9b69());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_12148485094142e394f2aa9351b7a259());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_67e3a4ecde2f4b11900b5d089dfbd498());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_9e44052e6886400cbe7185b0dce26d80());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_deffe13bb7124a9983aa86c031d6eb60());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_a204abffaf3244e98236b98d30e7426d());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_a7c4e6eab11e4e18822b1898145c2af7());
    }

    private sealed class TYPE_ee2ddc2a3be947daa34e4e056f7e3582 : HardwiredUserDataDescriptor
    {
      internal TYPE_ee2ddc2a3be947daa34e4e056f7e3582()
        : base(typeof (ContainerGame))
      {
        this.AddMember("getUser", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getUser", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_9346cf14003543429443e39010fa18cc()
        }));
        this.AddMember("getPlayers", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayers", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_b4045708a9c548c0818bd620fdd2201f()
        }));
        this.AddMember("getPlayerCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayerCount", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_5d354f4e704449509666a80450a11c58()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_2f0caa534cdd413193f61850a7601bed()
        }));
        this.AddMember("findCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_d3867df4b56a4f1582d7a4aafe86197d()
        }));
        this.AddMember("findEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findEffectors", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_2f63c162a9874e1ab662e6a2f6d1088b()
        }));
        this.AddMember("LineCast", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCast", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_96f87402fec442a499d3f62c452846f7()
        }));
        this.AddMember("LineCastOnlyCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_8304f693223a4747b14ef220662fafb3()
        }));
        this.AddMember("LineCastOnlyTerrain", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyTerrain", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_a75d419e8d0f4dbd8d6aa33f293c55b1()
        }));
        this.AddMember("ShowInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ShowInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_df3bfb00613b44ebbbcd2d5ea37a8985()
        }));
        this.AddMember("Talk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Talk", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_917042a20c3a438e8a093778126570ee()
        }));
        this.AddMember("get_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_82cfd7cc8671418caf1e5434caadd71b()
        }));
        this.AddMember("set_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_2c914c90e0da4d719375438cf75b63ae()
        }));
        this.AddMember("get_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_0723e06d396b486ca61f9aede635c765()
        }));
        this.AddMember("set_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_464cd654234b41449d30903ccef65479()
        }));
        this.AddMember("get_totalTimeElapsed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_totalTimeElapsed", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_c89b485e3d394db08c66739bacf0f6f8()
        }));
        this.AddMember("get_turnTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnTime", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_b99ec56bc4834aa496d55c50e7be915a()
        }));
        this.AddMember("get_frame", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frame", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_894d35ed1d774ebfac249afcfb12c825()
        }));
        this.AddMember("random", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("random", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_bda4243812484d0189f4b7444725e900()
        }));
        this.AddMember("get_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_b74a60c56d5e4c5d8e0058cdd8b072cd()
        }));
        this.AddMember("set_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_88b4405e56b34cb99d2258a2f9b3009f()
        }));
        this.AddMember("get_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_bfe42bed81704c35a3d25d3964ee32d8()
        }));
        this.AddMember("set_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_d48c41fb7952464ca31b750809df1cea()
        }));
        this.AddMember("get_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_598076c75a464e4484e00a7bce9b8c21()
        }));
        this.AddMember("set_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_f241cd90676b4adfa0760ad7011d4662()
        }));
        this.AddMember("get_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_29d65bb99f91495aa30da7a9ee264d6f()
        }));
        this.AddMember("set_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_e96e18a169624f40bc9c3456371d9d45()
        }));
        this.AddMember("get_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_40819318dcec4789bcb821f4dea00c11()
        }));
        this.AddMember("set_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_2e56fbcd2d984a4cb4f23bb1a2f167cd()
        }));
        this.AddMember("get_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_3ca38a1e48f343c58555361912315e3c()
        }));
        this.AddMember("set_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_79df67bf423340239f678da90f0c4203()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_d401b68d586441dea7692405181f6d86()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_2be2cd08552343799afcacec1099e61d()
        }));
        this.AddMember("get_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_a114c868e568420a834653333f139367()
        }));
        this.AddMember("set_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_74097e72756541f1b5fd72f436e20d23()
        }));
        this.AddMember("get_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_447884187bcc4aa8a6093295ca8b5c23()
        }));
        this.AddMember("set_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_9d23df41f31346bc943886e4e9a0fe64()
        }));
        this.AddMember("get_waiting", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waiting", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_2ffe54d53593456ab69ea48028b9d4bd()
        }));
        this.AddMember("get_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_31880a9c65a2461ba1f5aafb583446cf()
        }));
        this.AddMember("set_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_494edad38dad4c9e8a75afa09ac16fc7()
        }));
        this.AddMember("get_busy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_busy", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_8f24d68cfabe496496e44252dfbfdb43()
        }));
        this.AddMember("get_ongoing", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_ongoing", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_e3d5017b10574221b2877d5994ce4fc5()
        }));
        this.AddMember("get_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_cf9c350d0bac4ed4b1a22e7678b4b6c8()
        }));
        this.AddMember("set_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_8c30f0985a4f45649a1b96f3b9d719f8()
        }));
        this.AddMember("get_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_16a230ec14364123acec6f9a63692af0()
        }));
        this.AddMember("set_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_7b9c234312cc43609f522d8f989f72b0()
        }));
        this.AddMember("get_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_403e2b499caf4a909354486a48c05fc9()
        }));
        this.AddMember("set_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_f16fed994a534ca5a195d3c8db14b00b()
        }));
        this.AddMember("get_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_271c2ebb1b394e88a9a9f7d3ce68af27()
        }));
        this.AddMember("set_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_ec2db18be2ef405884378defa9eb24bc()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_5dab2415e3554f158c5cfde97a5666c3()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_bea7a7b0e3414260b59c84066964d014()
        }));
        this.AddMember("get_mousePosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mousePosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_7ef2bc59f4ae428f8dfb8fd30045a36c()
        }));
        this.AddMember("get_mouseOverUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mouseOverUI", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_b5319b1eab6249e9aa0fdf0a33979f84()
        }));
        this.AddMember("worldToCanvas", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("worldToCanvas", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_c13296a246cf44e9936992e847f7be61()
        }));
        this.AddMember("canvasToWorld", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("canvasToWorld", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_27d5513805f44087a594e52235d38857()
        }));
        this.AddMember("get_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_6eaf68e0fa6843ac93f214f8f00f5de0()
        }));
        this.AddMember("set_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_1f5f67fb3e89431ca3e658b97c77e118()
        }));
        this.AddMember("get_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_ebea816f22ea4ff7bc7916c95015edf3()
        }));
        this.AddMember("set_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_b6ccf349c34a4283b9a9fe06ab920dd8()
        }));
        this.AddMember("getMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_9f34eaf81fee4109a4a2f5ee986bea59()
        }));
        this.AddMember("setMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_61e3f6c94a804476aa1c9a09b6a01be0()
        }));
        this.AddMember("drawRectangle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawRectangle", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_802df10c19e74964a9337c4551349593()
        }));
        this.AddMember("drawEllipseOutline", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipseOutline", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_7ee275e222914d80883aeeb601b8d91b()
        }));
        this.AddMember("drawEllipse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipse", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_7f416c8d76844d53929d83452618067c()
        }));
        this.AddMember("blit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_f2e984e198c24886ad80010207f8c705()
        }));
        this.AddMember("blitRotate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blitRotate", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_414c1078e8bb4818b843a32420f09279()
        }));
        this.AddMember("applyDraw", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("applyDraw", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_17c2163e07204af4ae33a6f585ed466a()
        }));
        this.AddMember("get_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_6bec9a99e9c443d8baf66dc73c3cddef()
        }));
        this.AddMember("set_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_2b19c280f962433898c66c51ba9d965b()
        }));
        this.AddMember("get_isUsingTouchControls", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isUsingTouchControls", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_0eb4c522a4ff49849beef160e95a6a4e()
        }));
        this.AddMember("clientRefreshSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clientRefreshSpells", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_57db2cfea6ce4140b3c428ede5ce4b4d()
        }));
        this.AddMember("startCoroutine", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("startCoroutine", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_9235eb0e0dca4b82ad66f45e95a9764b()
        }));
        this.AddMember("devCommand", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("devCommand", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_32763e76981b4f3b8d9dfaf7cc016f07()
        }));
        this.AddMember("win", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("win", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_0aff092310bb4cc8aae8b9dc5bc27b6f()
        }));
        this.AddMember("lose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("lose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_9d0dd7185e2c4ac9a7449f164a236e32()
        }));
        this.AddMember("nextTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("nextTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_b3e8406784b444328376485d81336b57()
        }));
        this.AddMember("resetMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("resetMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_f322803b0c76494f9137808417e87568()
        }));
        this.AddMember("clearMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_37c5130c15b6424b937c6ff5729a9d07()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_12f199d2e54446849173d1f2ea24b056()
        }));
        this.AddMember("getSpellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellEnum", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_d0e7c566b834473b9a03b02064bdb119()
        }));
        this.AddMember("getSpellName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_a0c06e716fb549b48f8ce1228a2c1796()
        }));
        this.AddMember("getMapID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapID", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_a2edb73c1c1b431581c9b1dabf48df63()
        }));
        this.AddMember("getMapRealName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapRealName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_1dd117de4e774c10a557acaf5f6b0506()
        }));
        this.AddMember("getMapShortName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapShortName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_6d9b82298afa420fb553a88826873a84()
        }));
        this.AddMember("getArmageddonName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getArmageddonName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_e4ca0ad2b31f487ca38930b5ffadd413()
        }));
        this.AddMember("panCamera", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("panCamera", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_175a66359e234abea8373188bd2c9b0a()
        }));
        this.AddMember("getInputString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getInputString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_54658211b8214c28ab841cab18a6af17()
        }));
        this.AddMember("get_screenWidth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenWidth", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_0640500bdf1d45db9d1c4463f5f61e37()
        }));
        this.AddMember("get_screenHeight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenHeight", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_e98f02cf8b114df0b572beef63647832()
        }));
        this.AddMember("createCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createCreature", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_925a87f343f44afaad708217ea87ff6e()
        }));
        this.AddMember("clearIndicators", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearIndicators", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_368f1ce5f500485fa0630c62e5501ee1()
        }));
        this.AddMember("createIndicator", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createIndicator", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_7985e014b9d643d7b04994361958a666()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_a0363336a9f640c69c0f639f219be60d()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_1a22f1b9d5b549feaf7761c32bb7d27f()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_d17622eb8942439195d95aa84056ac70()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.MTHD_3dc4a70a9c6c4609aa325f24c5b1727f()
        }));
        this.AddMember("turn", (IMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.PROP_8981fbf5f1c345a4aa101cbea82950ba());
        this.AddMember("timeLimit", (IMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.PROP_0be95ee103274aaba76f4850f328337c());
        this.AddMember("totalTimeElapsed", (IMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.PROP_520e2aecc949437ba9a3a32b51bd9b5a());
        this.AddMember("turnTime", (IMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.PROP_25c94a39395a40d0b6d3fe3565bc147a());
        this.AddMember("frame", (IMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.PROP_2e1b662a690a4b1e9993a59040307a0e());
        this.AddMember("winOnDeath", (IMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.PROP_8e3f9f7be4be44239bdcb9ff5f2b9ca4());
        this.AddMember("allowMovement", (IMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.PROP_14af2ff38c4447a5800831f8d7d87834());
        this.AddMember("allowInput", (IMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.PROP_3f64ed72856a41e385829b60bc72a18a());
        this.AddMember("allowCallbacks", (IMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.PROP_f67b01ad439741bfaaeda1024a4d2a8a());
        this.AddMember("allowSkipTurn", (IMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.PROP_3dd8e823873247c8ab45bde9da3ef565());
        this.AddMember("terrainDestruction", (IMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.PROP_f169f682e1fc447da6770edfde9a86b9());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.PROP_6a9cbdac40f74befae53d59ee93c8622());
        this.AddMember("armageddon", (IMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.PROP_388b103121e74ace8ffc5dede6386da5());
        this.AddMember("armageddonTurn", (IMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.PROP_64bb3bca86844085ba5644ce12b0c23d());
        this.AddMember("waiting", (IMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.PROP_2fe3e6adf6b448d698be129b51ccfe02());
        this.AddMember("paused", (IMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.PROP_f2ee0ec0f9c444f9824ff7c2cb976628());
        this.AddMember("busy", (IMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.PROP_86182857da5444f3807d627278c25141());
        this.AddMember("ongoing", (IMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.PROP_6ea84ecc59c94dc3a18aa8d2c893ef8d());
        this.AddMember("gravity", (IMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.PROP_722710fb32f441a6badad4bf6a040f28());
        this.AddMember("wind", (IMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.PROP_0ab6965cb70c432199e486af4d7fe12d());
        this.AddMember("windDir", (IMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.PROP_55e3c0971d8b48e8a3248b87f1d41775());
        this.AddMember("windPower", (IMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.PROP_894472bac31b488ea8f1cf0c6509fdcb());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.PROP_30c22aee602f49529f66f3cb9b82b06a());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.PROP_d2293fe82bfa465f84f1fe3cb442b3c3());
        this.AddMember("mousePosition", (IMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.PROP_8e8e9f974837465a9be69b7d0eaba0ba());
        this.AddMember("mouseOverUI", (IMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.PROP_bb7c6bd8e82744b696102863f3c21368());
        this.AddMember("cameraPosition", (IMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.PROP_5aef7b93c9e14841aa858f0c41b726ab());
        this.AddMember("cameraZoom", (IMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.PROP_a65cd71b1cf9454088701c404e323cf8());
        this.AddMember("allowBounce", (IMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.PROP_094ee8464d754bd399a9a4f818487cd7());
        this.AddMember("isUsingTouchControls", (IMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.PROP_7ed7961946e9446782c98a6ba86cb4d1());
        this.AddMember("screenWidth", (IMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.PROP_1c6b311692dc4b3da8a15e67782957e2());
        this.AddMember("screenHeight", (IMemberDescriptor) new Bridge.TYPE_ee2ddc2a3be947daa34e4e056f7e3582.PROP_b83da9c699ce4dc2a51ca723c20e3778());
      }

      private sealed class MTHD_9346cf14003543429443e39010fa18cc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9346cf14003543429443e39010fa18cc()
        {
          this.Initialize("getUser", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getUser();
        }
      }

      private sealed class MTHD_b4045708a9c548c0818bd620fdd2201f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b4045708a9c548c0818bd620fdd2201f()
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

      private sealed class MTHD_5d354f4e704449509666a80450a11c58 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5d354f4e704449509666a80450a11c58()
        {
          this.Initialize("getPlayerCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getPlayerCount();
        }
      }

      private sealed class MTHD_2f0caa534cdd413193f61850a7601bed : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2f0caa534cdd413193f61850a7601bed()
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

      private sealed class MTHD_d3867df4b56a4f1582d7a4aafe86197d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d3867df4b56a4f1582d7a4aafe86197d()
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

      private sealed class MTHD_2f63c162a9874e1ab662e6a2f6d1088b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2f63c162a9874e1ab662e6a2f6d1088b()
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

      private sealed class MTHD_96f87402fec442a499d3f62c452846f7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_96f87402fec442a499d3f62c452846f7()
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

      private sealed class MTHD_8304f693223a4747b14ef220662fafb3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8304f693223a4747b14ef220662fafb3()
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

      private sealed class MTHD_a75d419e8d0f4dbd8d6aa33f293c55b1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a75d419e8d0f4dbd8d6aa33f293c55b1()
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

      private sealed class MTHD_df3bfb00613b44ebbbcd2d5ea37a8985 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_df3bfb00613b44ebbbcd2d5ea37a8985()
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

      private sealed class MTHD_917042a20c3a438e8a093778126570ee : HardwiredMethodMemberDescriptor
      {
        internal MTHD_917042a20c3a438e8a093778126570ee()
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

      private sealed class MTHD_82cfd7cc8671418caf1e5434caadd71b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_82cfd7cc8671418caf1e5434caadd71b()
        {
          this.Initialize("get_turn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turn;
        }
      }

      private sealed class MTHD_2c914c90e0da4d719375438cf75b63ae : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2c914c90e0da4d719375438cf75b63ae()
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

      private sealed class MTHD_0723e06d396b486ca61f9aede635c765 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0723e06d396b486ca61f9aede635c765()
        {
          this.Initialize("get_timeLimit", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).timeLimit;
        }
      }

      private sealed class MTHD_464cd654234b41449d30903ccef65479 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_464cd654234b41449d30903ccef65479()
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

      private sealed class MTHD_c89b485e3d394db08c66739bacf0f6f8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c89b485e3d394db08c66739bacf0f6f8()
        {
          this.Initialize("get_totalTimeElapsed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class MTHD_b99ec56bc4834aa496d55c50e7be915a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b99ec56bc4834aa496d55c50e7be915a()
        {
          this.Initialize("get_turnTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class MTHD_894d35ed1d774ebfac249afcfb12c825 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_894d35ed1d774ebfac249afcfb12c825()
        {
          this.Initialize("get_frame", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class MTHD_bda4243812484d0189f4b7444725e900 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bda4243812484d0189f4b7444725e900()
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

      private sealed class MTHD_b74a60c56d5e4c5d8e0058cdd8b072cd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b74a60c56d5e4c5d8e0058cdd8b072cd()
        {
          this.Initialize("get_winOnDeath", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).winOnDeath;
        }
      }

      private sealed class MTHD_88b4405e56b34cb99d2258a2f9b3009f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_88b4405e56b34cb99d2258a2f9b3009f()
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

      private sealed class MTHD_bfe42bed81704c35a3d25d3964ee32d8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bfe42bed81704c35a3d25d3964ee32d8()
        {
          this.Initialize("get_allowMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMovement;
        }
      }

      private sealed class MTHD_d48c41fb7952464ca31b750809df1cea : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d48c41fb7952464ca31b750809df1cea()
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

      private sealed class MTHD_598076c75a464e4484e00a7bce9b8c21 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_598076c75a464e4484e00a7bce9b8c21()
        {
          this.Initialize("get_allowInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowInput;
        }
      }

      private sealed class MTHD_f241cd90676b4adfa0760ad7011d4662 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f241cd90676b4adfa0760ad7011d4662()
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

      private sealed class MTHD_29d65bb99f91495aa30da7a9ee264d6f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_29d65bb99f91495aa30da7a9ee264d6f()
        {
          this.Initialize("get_allowCallbacks", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowCallbacks;
        }
      }

      private sealed class MTHD_e96e18a169624f40bc9c3456371d9d45 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e96e18a169624f40bc9c3456371d9d45()
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

      private sealed class MTHD_40819318dcec4789bcb821f4dea00c11 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_40819318dcec4789bcb821f4dea00c11()
        {
          this.Initialize("get_allowSkipTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowSkipTurn;
        }
      }

      private sealed class MTHD_2e56fbcd2d984a4cb4f23bb1a2f167cd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2e56fbcd2d984a4cb4f23bb1a2f167cd()
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

      private sealed class MTHD_3ca38a1e48f343c58555361912315e3c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3ca38a1e48f343c58555361912315e3c()
        {
          this.Initialize("get_terrainDestruction", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).terrainDestruction;
        }
      }

      private sealed class MTHD_79df67bf423340239f678da90f0c4203 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_79df67bf423340239f678da90f0c4203()
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

      private sealed class MTHD_d401b68d586441dea7692405181f6d86 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d401b68d586441dea7692405181f6d86()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).takeDamage;
        }
      }

      private sealed class MTHD_2be2cd08552343799afcacec1099e61d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2be2cd08552343799afcacec1099e61d()
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

      private sealed class MTHD_a114c868e568420a834653333f139367 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a114c868e568420a834653333f139367()
        {
          this.Initialize("get_armageddon", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddon;
        }
      }

      private sealed class MTHD_74097e72756541f1b5fd72f436e20d23 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_74097e72756541f1b5fd72f436e20d23()
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

      private sealed class MTHD_447884187bcc4aa8a6093295ca8b5c23 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_447884187bcc4aa8a6093295ca8b5c23()
        {
          this.Initialize("get_armageddonTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddonTurn;
        }
      }

      private sealed class MTHD_9d23df41f31346bc943886e4e9a0fe64 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9d23df41f31346bc943886e4e9a0fe64()
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

      private sealed class MTHD_2ffe54d53593456ab69ea48028b9d4bd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2ffe54d53593456ab69ea48028b9d4bd()
        {
          this.Initialize("get_waiting", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class MTHD_31880a9c65a2461ba1f5aafb583446cf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_31880a9c65a2461ba1f5aafb583446cf()
        {
          this.Initialize("get_paused", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).paused;
        }
      }

      private sealed class MTHD_494edad38dad4c9e8a75afa09ac16fc7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_494edad38dad4c9e8a75afa09ac16fc7()
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

      private sealed class MTHD_8f24d68cfabe496496e44252dfbfdb43 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8f24d68cfabe496496e44252dfbfdb43()
        {
          this.Initialize("get_busy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class MTHD_e3d5017b10574221b2877d5994ce4fc5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e3d5017b10574221b2877d5994ce4fc5()
        {
          this.Initialize("get_ongoing", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class MTHD_cf9c350d0bac4ed4b1a22e7678b4b6c8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cf9c350d0bac4ed4b1a22e7678b4b6c8()
        {
          this.Initialize("get_gravity", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).gravity;
        }
      }

      private sealed class MTHD_8c30f0985a4f45649a1b96f3b9d719f8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8c30f0985a4f45649a1b96f3b9d719f8()
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

      private sealed class MTHD_16a230ec14364123acec6f9a63692af0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_16a230ec14364123acec6f9a63692af0()
        {
          this.Initialize("get_wind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).wind;
        }
      }

      private sealed class MTHD_7b9c234312cc43609f522d8f989f72b0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7b9c234312cc43609f522d8f989f72b0()
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

      private sealed class MTHD_403e2b499caf4a909354486a48c05fc9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_403e2b499caf4a909354486a48c05fc9()
        {
          this.Initialize("get_windDir", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windDir;
        }
      }

      private sealed class MTHD_f16fed994a534ca5a195d3c8db14b00b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f16fed994a534ca5a195d3c8db14b00b()
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

      private sealed class MTHD_271c2ebb1b394e88a9a9f7d3ce68af27 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_271c2ebb1b394e88a9a9f7d3ce68af27()
        {
          this.Initialize("get_windPower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windPower;
        }
      }

      private sealed class MTHD_ec2db18be2ef405884378defa9eb24bc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ec2db18be2ef405884378defa9eb24bc()
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

      private sealed class MTHD_5dab2415e3554f158c5cfde97a5666c3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5dab2415e3554f158c5cfde97a5666c3()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class MTHD_bea7a7b0e3414260b59c84066964d014 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bea7a7b0e3414260b59c84066964d014()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class MTHD_7ef2bc59f4ae428f8dfb8fd30045a36c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7ef2bc59f4ae428f8dfb8fd30045a36c()
        {
          this.Initialize("get_mousePosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class MTHD_b5319b1eab6249e9aa0fdf0a33979f84 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b5319b1eab6249e9aa0fdf0a33979f84()
        {
          this.Initialize("get_mouseOverUI", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class MTHD_c13296a246cf44e9936992e847f7be61 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c13296a246cf44e9936992e847f7be61()
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

      private sealed class MTHD_27d5513805f44087a594e52235d38857 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_27d5513805f44087a594e52235d38857()
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

      private sealed class MTHD_6eaf68e0fa6843ac93f214f8f00f5de0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6eaf68e0fa6843ac93f214f8f00f5de0()
        {
          this.Initialize("get_cameraPosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraPosition;
        }
      }

      private sealed class MTHD_1f5f67fb3e89431ca3e658b97c77e118 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1f5f67fb3e89431ca3e658b97c77e118()
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

      private sealed class MTHD_ebea816f22ea4ff7bc7916c95015edf3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ebea816f22ea4ff7bc7916c95015edf3()
        {
          this.Initialize("get_cameraZoom", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraZoom;
        }
      }

      private sealed class MTHD_b6ccf349c34a4283b9a9fe06ab920dd8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b6ccf349c34a4283b9a9fe06ab920dd8()
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

      private sealed class MTHD_9f34eaf81fee4109a4a2f5ee986bea59 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9f34eaf81fee4109a4a2f5ee986bea59()
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

      private sealed class MTHD_61e3f6c94a804476aa1c9a09b6a01be0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_61e3f6c94a804476aa1c9a09b6a01be0()
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

      private sealed class MTHD_802df10c19e74964a9337c4551349593 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_802df10c19e74964a9337c4551349593()
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

      private sealed class MTHD_7ee275e222914d80883aeeb601b8d91b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7ee275e222914d80883aeeb601b8d91b()
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

      private sealed class MTHD_7f416c8d76844d53929d83452618067c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7f416c8d76844d53929d83452618067c()
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

      private sealed class MTHD_f2e984e198c24886ad80010207f8c705 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f2e984e198c24886ad80010207f8c705()
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

      private sealed class MTHD_414c1078e8bb4818b843a32420f09279 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_414c1078e8bb4818b843a32420f09279()
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

      private sealed class MTHD_17c2163e07204af4ae33a6f585ed466a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_17c2163e07204af4ae33a6f585ed466a()
        {
          this.Initialize("applyDraw", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).applyDraw();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_6bec9a99e9c443d8baf66dc73c3cddef : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6bec9a99e9c443d8baf66dc73c3cddef()
        {
          this.Initialize("get_allowBounce", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowBounce;
        }
      }

      private sealed class MTHD_2b19c280f962433898c66c51ba9d965b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2b19c280f962433898c66c51ba9d965b()
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

      private sealed class MTHD_0eb4c522a4ff49849beef160e95a6a4e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0eb4c522a4ff49849beef160e95a6a4e()
        {
          this.Initialize("get_isUsingTouchControls", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class MTHD_57db2cfea6ce4140b3c428ede5ce4b4d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_57db2cfea6ce4140b3c428ede5ce4b4d()
        {
          this.Initialize("clientRefreshSpells", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clientRefreshSpells();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_9235eb0e0dca4b82ad66f45e95a9764b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9235eb0e0dca4b82ad66f45e95a9764b()
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

      private sealed class MTHD_32763e76981b4f3b8d9dfaf7cc016f07 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_32763e76981b4f3b8d9dfaf7cc016f07()
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

      private sealed class MTHD_0aff092310bb4cc8aae8b9dc5bc27b6f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0aff092310bb4cc8aae8b9dc5bc27b6f()
        {
          this.Initialize("win", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).win();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_9d0dd7185e2c4ac9a7449f164a236e32 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9d0dd7185e2c4ac9a7449f164a236e32()
        {
          this.Initialize("lose", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).lose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_b3e8406784b444328376485d81336b57 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b3e8406784b444328376485d81336b57()
        {
          this.Initialize("nextTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).nextTurn();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_f322803b0c76494f9137808417e87568 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f322803b0c76494f9137808417e87568()
        {
          this.Initialize("resetMap", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).resetMap();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_37c5130c15b6424b937c6ff5729a9d07 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_37c5130c15b6424b937c6ff5729a9d07()
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

      private sealed class MTHD_12f199d2e54446849173d1f2ea24b056 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_12f199d2e54446849173d1f2ea24b056()
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

      private sealed class MTHD_d0e7c566b834473b9a03b02064bdb119 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d0e7c566b834473b9a03b02064bdb119()
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

      private sealed class MTHD_a0c06e716fb549b48f8ce1228a2c1796 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a0c06e716fb549b48f8ce1228a2c1796()
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

      private sealed class MTHD_a2edb73c1c1b431581c9b1dabf48df63 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a2edb73c1c1b431581c9b1dabf48df63()
        {
          this.Initialize("getMapID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getMapID();
        }
      }

      private sealed class MTHD_1dd117de4e774c10a557acaf5f6b0506 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1dd117de4e774c10a557acaf5f6b0506()
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

      private sealed class MTHD_6d9b82298afa420fb553a88826873a84 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6d9b82298afa420fb553a88826873a84()
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

      private sealed class MTHD_e4ca0ad2b31f487ca38930b5ffadd413 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e4ca0ad2b31f487ca38930b5ffadd413()
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

      private sealed class MTHD_175a66359e234abea8373188bd2c9b0a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_175a66359e234abea8373188bd2c9b0a()
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

      private sealed class MTHD_54658211b8214c28ab841cab18a6af17 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_54658211b8214c28ab841cab18a6af17()
        {
          this.Initialize("getInputString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getInputString();
        }
      }

      private sealed class MTHD_0640500bdf1d45db9d1c4463f5f61e37 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0640500bdf1d45db9d1c4463f5f61e37()
        {
          this.Initialize("get_screenWidth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class MTHD_e98f02cf8b114df0b572beef63647832 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e98f02cf8b114df0b572beef63647832()
        {
          this.Initialize("get_screenHeight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }

      private sealed class MTHD_925a87f343f44afaad708217ea87ff6e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_925a87f343f44afaad708217ea87ff6e()
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

      private sealed class MTHD_368f1ce5f500485fa0630c62e5501ee1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_368f1ce5f500485fa0630c62e5501ee1()
        {
          this.Initialize("clearIndicators", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clearIndicators();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_7985e014b9d643d7b04994361958a666 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7985e014b9d643d7b04994361958a666()
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

      private sealed class MTHD_a0363336a9f640c69c0f639f219be60d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a0363336a9f640c69c0f639f219be60d()
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

      private sealed class MTHD_1a22f1b9d5b549feaf7761c32bb7d27f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1a22f1b9d5b549feaf7761c32bb7d27f()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_d17622eb8942439195d95aa84056ac70 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d17622eb8942439195d95aa84056ac70()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_3dc4a70a9c6c4609aa325f24c5b1727f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3dc4a70a9c6c4609aa325f24c5b1727f()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_8981fbf5f1c345a4aa101cbea82950ba : HardwiredMemberDescriptor
      {
        internal PROP_8981fbf5f1c345a4aa101cbea82950ba()
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

      private sealed class PROP_0be95ee103274aaba76f4850f328337c : HardwiredMemberDescriptor
      {
        internal PROP_0be95ee103274aaba76f4850f328337c()
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

      private sealed class PROP_520e2aecc949437ba9a3a32b51bd9b5a : HardwiredMemberDescriptor
      {
        internal PROP_520e2aecc949437ba9a3a32b51bd9b5a()
          : base(typeof (double), "totalTimeElapsed", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class PROP_25c94a39395a40d0b6d3fe3565bc147a : HardwiredMemberDescriptor
      {
        internal PROP_25c94a39395a40d0b6d3fe3565bc147a()
          : base(typeof (double), "turnTime", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class PROP_2e1b662a690a4b1e9993a59040307a0e : HardwiredMemberDescriptor
      {
        internal PROP_2e1b662a690a4b1e9993a59040307a0e()
          : base(typeof (int), "frame", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class PROP_8e3f9f7be4be44239bdcb9ff5f2b9ca4 : HardwiredMemberDescriptor
      {
        internal PROP_8e3f9f7be4be44239bdcb9ff5f2b9ca4()
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

      private sealed class PROP_14af2ff38c4447a5800831f8d7d87834 : HardwiredMemberDescriptor
      {
        internal PROP_14af2ff38c4447a5800831f8d7d87834()
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

      private sealed class PROP_3f64ed72856a41e385829b60bc72a18a : HardwiredMemberDescriptor
      {
        internal PROP_3f64ed72856a41e385829b60bc72a18a()
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

      private sealed class PROP_f67b01ad439741bfaaeda1024a4d2a8a : HardwiredMemberDescriptor
      {
        internal PROP_f67b01ad439741bfaaeda1024a4d2a8a()
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

      private sealed class PROP_3dd8e823873247c8ab45bde9da3ef565 : HardwiredMemberDescriptor
      {
        internal PROP_3dd8e823873247c8ab45bde9da3ef565()
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

      private sealed class PROP_f169f682e1fc447da6770edfde9a86b9 : HardwiredMemberDescriptor
      {
        internal PROP_f169f682e1fc447da6770edfde9a86b9()
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

      private sealed class PROP_6a9cbdac40f74befae53d59ee93c8622 : HardwiredMemberDescriptor
      {
        internal PROP_6a9cbdac40f74befae53d59ee93c8622()
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

      private sealed class PROP_388b103121e74ace8ffc5dede6386da5 : HardwiredMemberDescriptor
      {
        internal PROP_388b103121e74ace8ffc5dede6386da5()
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

      private sealed class PROP_64bb3bca86844085ba5644ce12b0c23d : HardwiredMemberDescriptor
      {
        internal PROP_64bb3bca86844085ba5644ce12b0c23d()
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

      private sealed class PROP_2fe3e6adf6b448d698be129b51ccfe02 : HardwiredMemberDescriptor
      {
        internal PROP_2fe3e6adf6b448d698be129b51ccfe02()
          : base(typeof (bool), "waiting", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class PROP_f2ee0ec0f9c444f9824ff7c2cb976628 : HardwiredMemberDescriptor
      {
        internal PROP_f2ee0ec0f9c444f9824ff7c2cb976628()
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

      private sealed class PROP_86182857da5444f3807d627278c25141 : HardwiredMemberDescriptor
      {
        internal PROP_86182857da5444f3807d627278c25141()
          : base(typeof (bool), "busy", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class PROP_6ea84ecc59c94dc3a18aa8d2c893ef8d : HardwiredMemberDescriptor
      {
        internal PROP_6ea84ecc59c94dc3a18aa8d2c893ef8d()
          : base(typeof (bool), "ongoing", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class PROP_722710fb32f441a6badad4bf6a040f28 : HardwiredMemberDescriptor
      {
        internal PROP_722710fb32f441a6badad4bf6a040f28()
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

      private sealed class PROP_0ab6965cb70c432199e486af4d7fe12d : HardwiredMemberDescriptor
      {
        internal PROP_0ab6965cb70c432199e486af4d7fe12d()
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

      private sealed class PROP_55e3c0971d8b48e8a3248b87f1d41775 : HardwiredMemberDescriptor
      {
        internal PROP_55e3c0971d8b48e8a3248b87f1d41775()
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

      private sealed class PROP_894472bac31b488ea8f1cf0c6509fdcb : HardwiredMemberDescriptor
      {
        internal PROP_894472bac31b488ea8f1cf0c6509fdcb()
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

      private sealed class PROP_30c22aee602f49529f66f3cb9b82b06a : HardwiredMemberDescriptor
      {
        internal PROP_30c22aee602f49529f66f3cb9b82b06a()
          : base(typeof (int), "width", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class PROP_d2293fe82bfa465f84f1fe3cb442b3c3 : HardwiredMemberDescriptor
      {
        internal PROP_d2293fe82bfa465f84f1fe3cb442b3c3()
          : base(typeof (int), "height", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class PROP_8e8e9f974837465a9be69b7d0eaba0ba : HardwiredMemberDescriptor
      {
        internal PROP_8e8e9f974837465a9be69b7d0eaba0ba()
          : base(typeof (Educative.Point), "mousePosition", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class PROP_bb7c6bd8e82744b696102863f3c21368 : HardwiredMemberDescriptor
      {
        internal PROP_bb7c6bd8e82744b696102863f3c21368()
          : base(typeof (bool), "mouseOverUI", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class PROP_5aef7b93c9e14841aa858f0c41b726ab : HardwiredMemberDescriptor
      {
        internal PROP_5aef7b93c9e14841aa858f0c41b726ab()
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

      private sealed class PROP_a65cd71b1cf9454088701c404e323cf8 : HardwiredMemberDescriptor
      {
        internal PROP_a65cd71b1cf9454088701c404e323cf8()
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

      private sealed class PROP_094ee8464d754bd399a9a4f818487cd7 : HardwiredMemberDescriptor
      {
        internal PROP_094ee8464d754bd399a9a4f818487cd7()
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

      private sealed class PROP_7ed7961946e9446782c98a6ba86cb4d1 : HardwiredMemberDescriptor
      {
        internal PROP_7ed7961946e9446782c98a6ba86cb4d1()
          : base(typeof (bool), "isUsingTouchControls", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class PROP_1c6b311692dc4b3da8a15e67782957e2 : HardwiredMemberDescriptor
      {
        internal PROP_1c6b311692dc4b3da8a15e67782957e2()
          : base(typeof (double), "screenWidth", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class PROP_b83da9c699ce4dc2a51ca723c20e3778 : HardwiredMemberDescriptor
      {
        internal PROP_b83da9c699ce4dc2a51ca723c20e3778()
          : base(typeof (double), "screenHeight", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }
    }

    private sealed class TYPE_63e41aa2399241de936f9d0e3cca64eb : HardwiredUserDataDescriptor
    {
      internal TYPE_63e41aa2399241de936f9d0e3cca64eb()
        : base(typeof (ContainerPlayer))
      {
        this.AddMember("get_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_63e41aa2399241de936f9d0e3cca64eb.MTHD_20a876f4383b4da2949f77e8214ee2c8()
        }));
        this.AddMember("set_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_63e41aa2399241de936f9d0e3cca64eb.MTHD_b5bbaade68c0439280c2a24c7891a49b()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_63e41aa2399241de936f9d0e3cca64eb.MTHD_153d2c0c8a8e44ffaf9a6cf8c67628c9()
        }));
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_63e41aa2399241de936f9d0e3cca64eb.MTHD_162aab4a231b4c979cbd72a3b92e7ce8()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_63e41aa2399241de936f9d0e3cca64eb.MTHD_b870ff728a1847569daed8fbb23be11a()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_63e41aa2399241de936f9d0e3cca64eb.MTHD_281f4705c8c141abb3071d8377b06d04()
        }));
        this.AddMember("getCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreature", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_63e41aa2399241de936f9d0e3cca64eb.MTHD_6edab63cc1ac40149eaf9b7877a0deba()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_63e41aa2399241de936f9d0e3cca64eb.MTHD_f8aa6c7b15b740c18cd0fa93ff48f4de()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_63e41aa2399241de936f9d0e3cca64eb.MTHD_495473c6a2834b94ab46e45b51044826()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_63e41aa2399241de936f9d0e3cca64eb.MTHD_8c8b28c3bf4343f79371191fff0df87c()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_63e41aa2399241de936f9d0e3cca64eb.MTHD_95d7d3d2b9c24aebac9cb9ba97d0549e()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_63e41aa2399241de936f9d0e3cca64eb.MTHD_f1e26c649d9a484582cecffd0c60bbef()
        }));
        this.AddMember("localTurn", (IMemberDescriptor) new Bridge.TYPE_63e41aa2399241de936f9d0e3cca64eb.PROP_38b88468fab943dc948f54ca204e437e());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_63e41aa2399241de936f9d0e3cca64eb.PROP_2735bf3b8754453baa3b7cbaea2ce7ae());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_63e41aa2399241de936f9d0e3cca64eb.PROP_3a45421dd4bb438a8fb4aa3ce1a7bf1d());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_63e41aa2399241de936f9d0e3cca64eb.PROP_547b9846245e4cb29d26dc140a2c1dcd());
      }

      private sealed class MTHD_20a876f4383b4da2949f77e8214ee2c8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_20a876f4383b4da2949f77e8214ee2c8()
        {
          this.Initialize("get_localTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).localTurn;
        }
      }

      private sealed class MTHD_b5bbaade68c0439280c2a24c7891a49b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b5bbaade68c0439280c2a24c7891a49b()
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

      private sealed class MTHD_153d2c0c8a8e44ffaf9a6cf8c67628c9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_153d2c0c8a8e44ffaf9a6cf8c67628c9()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class MTHD_162aab4a231b4c979cbd72a3b92e7ce8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_162aab4a231b4c979cbd72a3b92e7ce8()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class MTHD_b870ff728a1847569daed8fbb23be11a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b870ff728a1847569daed8fbb23be11a()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }

      private sealed class MTHD_281f4705c8c141abb3071d8377b06d04 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_281f4705c8c141abb3071d8377b06d04()
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

      private sealed class MTHD_6edab63cc1ac40149eaf9b7877a0deba : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6edab63cc1ac40149eaf9b7877a0deba()
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

      private sealed class MTHD_f8aa6c7b15b740c18cd0fa93ff48f4de : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f8aa6c7b15b740c18cd0fa93ff48f4de()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).getMinionCount();
        }
      }

      private sealed class MTHD_495473c6a2834b94ab46e45b51044826 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_495473c6a2834b94ab46e45b51044826()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).GetHashCode();
        }
      }

      private sealed class MTHD_8c8b28c3bf4343f79371191fff0df87c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8c8b28c3bf4343f79371191fff0df87c()
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

      private sealed class MTHD_95d7d3d2b9c24aebac9cb9ba97d0549e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_95d7d3d2b9c24aebac9cb9ba97d0549e()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_f1e26c649d9a484582cecffd0c60bbef : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f1e26c649d9a484582cecffd0c60bbef()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_38b88468fab943dc948f54ca204e437e : HardwiredMemberDescriptor
      {
        internal PROP_38b88468fab943dc948f54ca204e437e()
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

      private sealed class PROP_2735bf3b8754453baa3b7cbaea2ce7ae : HardwiredMemberDescriptor
      {
        internal PROP_2735bf3b8754453baa3b7cbaea2ce7ae()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class PROP_3a45421dd4bb438a8fb4aa3ce1a7bf1d : HardwiredMemberDescriptor
      {
        internal PROP_3a45421dd4bb438a8fb4aa3ce1a7bf1d()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class PROP_547b9846245e4cb29d26dc140a2c1dcd : HardwiredMemberDescriptor
      {
        internal PROP_547b9846245e4cb29d26dc140a2c1dcd()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }
    }

    private sealed class TYPE_b18e773b76984300836369291d57c208 : HardwiredUserDataDescriptor
    {
      internal TYPE_b18e773b76984300836369291d57c208()
        : base(typeof (ContainerCreature))
      {
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_75cc46fc47f446699f3590b07e180041()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_c7d1c2b0d1864ecfb847071cc6551014()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_49e5203dd1e242a882d9c3a58f326d00()
        }));
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_9de48a54c7224309a111b22b37213986()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_329b6389d13c4ec68e89ce4dc1908a3f()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_a0a364338ecf4f5facbdb25a12a2c285()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_7b187e2e616048b38e80a11aa084e46d()
        }));
        this.AddMember("get_healthAndTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_healthAndTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_79535441d7864c9d8ee624fe1af38231()
        }));
        this.AddMember("get_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_6f628b794857491f80ae43f2c53c7494()
        }));
        this.AddMember("set_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_97e2cacbf66f4ffb84d102a46416705b()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_4a6b92ab90df45f695c71b05fa4005fd()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_9aef5d7a090249ae9735c30549b24bae()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_a62dc5b5e93a4687a7740a02768d9f6c()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_7b53b9e5eb5d416993b035744f20a1a2()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_531f56502ce54fb6ac4202c3b8a89885()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_ee0b46acdfc64f75b95ff9f03b682290()
        }));
        this.AddMember("get_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_4c39ad589df74e20b59d18da50c091be()
        }));
        this.AddMember("set_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_59fa4a23c4ce4c31b326b330ade4171c()
        }));
        this.AddMember("get_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_34646fb030f942278c3c4fde1c05e138()
        }));
        this.AddMember("set_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_81f442d1a9104972aab5765486b94729()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_25da918e4f5646da97f1c34fbb343730()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_0204751372d0424db5c2c478c7f76628()
        }));
        this.AddMember("get_inTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_f9fe6fec39854bc39c6f1c63a00e3766()
        }));
        this.AddMember("get_isMoving", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMoving", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_27c58df108eb4ce896eb37d989f2c3f6()
        }));
        this.AddMember("get_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_611ecdd887f24a188cbd4bff03795b85()
        }));
        this.AddMember("set_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_67513e23a7f848209e4b6a0a4cc290a3()
        }));
        this.AddMember("get_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_8ca08641c698458ba183165dd89ad120()
        }));
        this.AddMember("set_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_95e83186286c497d89a936313a952756()
        }));
        this.AddMember("get_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_cad0d6b0611c4f7284aff2839da15e73()
        }));
        this.AddMember("set_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_fdf65c71241e45ceafdfd46b8eb64701()
        }));
        this.AddMember("get_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_a4866e31ebb646d0bf470907b84cee52()
        }));
        this.AddMember("set_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_f2943d70652345b0809a0f7f59b99213()
        }));
        this.AddMember("get_inWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_6c4a9f88c4f546f6a102138405afc931()
        }));
        this.AddMember("get_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_571e16dc1e38487595c6d75770c638e7()
        }));
        this.AddMember("set_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_f62fa9333fff428aaba78ae5b1c288b9()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_59677ca2d3864de38e318d5311f16a95()
        }));
        this.AddMember("set_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_1393a1256a3944f1ac0794ac0d8084ee()
        }));
        this.AddMember("get_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_81ae4ba96c3a41688e372792bf201ac7()
        }));
        this.AddMember("set_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_4206cfa194d84df4a7eefdab7a09595b()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_79aede3bfb1a49099e20e71bbd707357()
        }));
        this.AddMember("get_isRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_fc70a02d5b94464690c5918c4f7bc553()
        }));
        this.AddMember("get_isMounted", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMounted", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_eef8ef0b42b84151af33abc17f0001d7()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_148e07c513bb41f8b9d5bdb464093ae8()
        }));
        this.AddMember("get_isPawn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPawn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_c348020107e442ea9d2ac1e2335a69d8()
        }));
        this.AddMember("get_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_6a2f60184ae6455b8789e856dfd366a3()
        }));
        this.AddMember("set_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_15783b10ddd0403fbf67273623c34bfc()
        }));
        this.AddMember("get_isMountable", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMountable", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_62a9df25b2b04cadbe10fbf114c20ca0()
        }));
        this.AddMember("get_canMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_canMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_4f82e2b2adea49d9b4a56bd36f2eac2d()
        }));
        this.AddMember("get_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_d86279e352624359ad8f11565eb04aa0()
        }));
        this.AddMember("set_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_4086e191cb8e4e5ca6a416828db5f250()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_af7f96244fc64b78a5822bbf86e820f2()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_11ce37f7faea469b9c595f286e14ac3a()
        }));
        this.AddMember("getRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_5b5e2188572349b18a70d92f2bb9cb87()
        }));
        this.AddMember("getMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_bb16454b42fe49f6b256cf8f8c418b9d()
        }));
        this.AddMember("getTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_d83c76f68bd44ebd97c924d7f65fb92c()
        }));
        this.AddMember("LongJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LongJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_e6ac5e179da0497ca7fad5b480969020()
        }));
        this.AddMember("HighJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("HighJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_e611aedcde79412fb6fe15dec5e686a7()
        }));
        this.AddMember("Walk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Walk", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_7d96acda7297455d80cefb73641f7d2e()
        }));
        this.AddMember("setDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_2ca5e372795048f6b8fd57403fed5d87()
        }));
        this.AddMember("getFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_448d4900265443d49c800a330b68b684()
        }));
        this.AddMember("getActivateableFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_3ad98d7d5fef41fd8e16ed0eb47415cd()
        }));
        this.AddMember("getActivateableFamiliarBookID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarBookID", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_3c92055571c949df9c80983434dadc64()
        }));
        this.AddMember("increaseFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("increaseFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_299a86be348e4ef389cf4883ee2cded5()
        }));
        this.AddMember("inside", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("inside", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_3751c5931692447da83c9ac05f3d00d3(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_c4fda91c9fe441f88818ce8eac9d9a40()
        }));
        this.AddMember("overlap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("overlap", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_e923c38cd32c4ff693c2c9f496bf8117(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_cc2d6afd115040d9809d6453aff5753b()
        }));
        this.AddMember("die", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("die", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_e14c08a560d3436b9fbd3d808955b4e1()
        }));
        this.AddMember("addSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_b1bf746e34ad41c6b460ab90551f4e06()
        }));
        this.AddMember("removeSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("removeSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_8c5cfa13faf740298159c27eb4be9800(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_9ca5fc919dd241c593d10b88b0e1e760()
        }));
        this.AddMember("getSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpells", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_aacb249ccfc845c4bb8011c71d2329f2()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_b99a5c34606e4a8684962a5453f06d84()
        }));
        this.AddMember("getSpellCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_fe68f098c8114f5aa6ee8f5c44bef9ff()
        }));
        this.AddMember("castedCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_856c41403af94d64b76d5f4c473ac1c1()
        }));
        this.AddMember("castedCountThisTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCountThisTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_a171d111cce14bd0b0c287db312f9e22()
        }));
        this.AddMember("castedDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_fc6a67ccd1484e418508cd2dbf3951c0()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_74dd2f89a08347a8b14940e8289852c1()
        }));
        this.AddMember("castSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_cbbac9283ded4610a3bc3146ea9d2563()
        }));
        this.AddMember("fireAt", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fireAt", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_87bdf75548864c0d9343b5b3011d3dfe(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_412c0a3dd8394b2fb83d09e964694f64()
        }));
        this.AddMember("getEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getEffectors", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_0c2d9c29ce844a66a45ac4405b4bf018(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_c34629d412134e2db22abcc896c23bfe()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_ef55fbd9256444538d5df05906487391()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_7e0155baed614f33995409719fa3a438()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_8916401e8e08417fa3da7b0df01ad647()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_1038fea183024cdd8fff588f42e7ad7a()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_d44a899aeb9841dbab95c11d175f637e()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.MTHD_f422075f60484638b7b1d00c57381454()
        }));
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.PROP_89b4e6ee84a94e5b9f19f7b71b6eb17c());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.PROP_55bcba04ee8a40fdb1fa17afbb03fff9());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.PROP_36ae507adbcd4b51b3ee1fc14fb154cf());
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.PROP_b2a5c0d15b19494dbba74bb83881f989());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.PROP_082741f2c95b476890d64579631fb689());
        this.AddMember("healthAndTower", (IMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.PROP_0c6227bb472d4583abd32293f07da891());
        this.AddMember("shield", (IMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.PROP_22ab5dc6a63740769ec530109f41fe17());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.PROP_ad398a78b00f45a8bfc8dd93b1e39a8d());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.PROP_2c2cf69b05a243f48868bf01ab0be057());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.PROP_f0ae939d4c1f4cc2ad4fbe37bab9d146());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.PROP_85297bc5da584a0c916a8be69f662a06());
        this.AddMember("weight", (IMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.PROP_3249c14708dd4ccdacb4381f8ca6ae49());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.PROP_f59b010833444ad8bb798ec90cc42d14());
        this.AddMember("inTower", (IMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.PROP_9512e62cfa2b437090ca28fa62ca36d1());
        this.AddMember("isMoving", (IMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.PROP_02b6ef7dca3e4984ac3dde7c166f7210());
        this.AddMember("stunned", (IMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.PROP_e6d345ed1f1e4ea399b817fc1ec05746());
        this.AddMember("superStunned", (IMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.PROP_0de30f9a84b3422fa9b05ee68952218d());
        this.AddMember("waterWalking", (IMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.PROP_5e83e2bcf83546438d4c05455929b2ba());
        this.AddMember("frostWalking", (IMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.PROP_0c418db28aa94c1aaf35b91a45ebe9ca());
        this.AddMember("inWater", (IMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.PROP_52c654de9d644f5886f8e8b985cc5c0b());
        this.AddMember("diesInWater", (IMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.PROP_14553aa1c0d6445db93b45bd6e97c10f());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.PROP_52ff0557171444d9b2935fad24d76d35());
        this.AddMember("race", (IMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.PROP_663ad29b66d3491cb65b7c16adfbf553());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.PROP_39c34431cd38475eb7ed864f3e5689ca());
        this.AddMember("isRider", (IMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.PROP_685230aafb7c4b858d4843df53dfa639());
        this.AddMember("isMounted", (IMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.PROP_2887ae569f804b6aa24444c4167bcc68());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.PROP_7635cbd2732f46bcb0bcfb44584b2d91());
        this.AddMember("isPawn", (IMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.PROP_173696969a02470481f899c8abcd82d0());
        this.AddMember("isFlying", (IMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.PROP_d8dcd93c0f784baca1af90e2c65c085d());
        this.AddMember("isMountable", (IMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.PROP_76a496154dc34b3891fd54dd63a1f557());
        this.AddMember("canMount", (IMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.PROP_9a3a20bccac441529a2f856539073ea1());
        this.AddMember("arcaneMonster", (IMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.PROP_4ef5712b8a744d19a9edc0568a3ec831());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_b18e773b76984300836369291d57c208.PROP_25500334e8a744d0bbeb2a7cfce98568());
      }

      private sealed class MTHD_75cc46fc47f446699f3590b07e180041 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_75cc46fc47f446699f3590b07e180041()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class MTHD_c7d1c2b0d1864ecfb847071cc6551014 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c7d1c2b0d1864ecfb847071cc6551014()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class MTHD_49e5203dd1e242a882d9c3a58f326d00 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_49e5203dd1e242a882d9c3a58f326d00()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class MTHD_9de48a54c7224309a111b22b37213986 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9de48a54c7224309a111b22b37213986()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).health;
        }
      }

      private sealed class MTHD_329b6389d13c4ec68e89ce4dc1908a3f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_329b6389d13c4ec68e89ce4dc1908a3f()
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

      private sealed class MTHD_a0a364338ecf4f5facbdb25a12a2c285 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a0a364338ecf4f5facbdb25a12a2c285()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).maxHealth;
        }
      }

      private sealed class MTHD_7b187e2e616048b38e80a11aa084e46d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7b187e2e616048b38e80a11aa084e46d()
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

      private sealed class MTHD_79535441d7864c9d8ee624fe1af38231 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_79535441d7864c9d8ee624fe1af38231()
        {
          this.Initialize("get_healthAndTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class MTHD_6f628b794857491f80ae43f2c53c7494 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6f628b794857491f80ae43f2c53c7494()
        {
          this.Initialize("get_shield", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).shield;
        }
      }

      private sealed class MTHD_97e2cacbf66f4ffb84d102a46416705b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_97e2cacbf66f4ffb84d102a46416705b()
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

      private sealed class MTHD_4a6b92ab90df45f695c71b05fa4005fd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4a6b92ab90df45f695c71b05fa4005fd()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).x;
        }
      }

      private sealed class MTHD_9aef5d7a090249ae9735c30549b24bae : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9aef5d7a090249ae9735c30549b24bae()
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

      private sealed class MTHD_a62dc5b5e93a4687a7740a02768d9f6c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a62dc5b5e93a4687a7740a02768d9f6c()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).y;
        }
      }

      private sealed class MTHD_7b53b9e5eb5d416993b035744f20a1a2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7b53b9e5eb5d416993b035744f20a1a2()
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

      private sealed class MTHD_531f56502ce54fb6ac4202c3b8a89885 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_531f56502ce54fb6ac4202c3b8a89885()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).position;
        }
      }

      private sealed class MTHD_ee0b46acdfc64f75b95ff9f03b682290 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ee0b46acdfc64f75b95ff9f03b682290()
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

      private sealed class MTHD_4c39ad589df74e20b59d18da50c091be : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4c39ad589df74e20b59d18da50c091be()
        {
          this.Initialize("get_parent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).parent;
        }
      }

      private sealed class MTHD_59fa4a23c4ce4c31b326b330ade4171c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_59fa4a23c4ce4c31b326b330ade4171c()
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

      private sealed class MTHD_34646fb030f942278c3c4fde1c05e138 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_34646fb030f942278c3c4fde1c05e138()
        {
          this.Initialize("get_weight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).weight;
        }
      }

      private sealed class MTHD_81f442d1a9104972aab5765486b94729 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_81f442d1a9104972aab5765486b94729()
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

      private sealed class MTHD_25da918e4f5646da97f1c34fbb343730 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_25da918e4f5646da97f1c34fbb343730()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).radius;
        }
      }

      private sealed class MTHD_0204751372d0424db5c2c478c7f76628 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0204751372d0424db5c2c478c7f76628()
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

      private sealed class MTHD_f9fe6fec39854bc39c6f1c63a00e3766 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f9fe6fec39854bc39c6f1c63a00e3766()
        {
          this.Initialize("get_inTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class MTHD_27c58df108eb4ce896eb37d989f2c3f6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_27c58df108eb4ce896eb37d989f2c3f6()
        {
          this.Initialize("get_isMoving", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class MTHD_611ecdd887f24a188cbd4bff03795b85 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_611ecdd887f24a188cbd4bff03795b85()
        {
          this.Initialize("get_stunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).stunned;
        }
      }

      private sealed class MTHD_67513e23a7f848209e4b6a0a4cc290a3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_67513e23a7f848209e4b6a0a4cc290a3()
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

      private sealed class MTHD_8ca08641c698458ba183165dd89ad120 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8ca08641c698458ba183165dd89ad120()
        {
          this.Initialize("get_superStunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).superStunned;
        }
      }

      private sealed class MTHD_95e83186286c497d89a936313a952756 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_95e83186286c497d89a936313a952756()
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

      private sealed class MTHD_cad0d6b0611c4f7284aff2839da15e73 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cad0d6b0611c4f7284aff2839da15e73()
        {
          this.Initialize("get_waterWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).waterWalking;
        }
      }

      private sealed class MTHD_fdf65c71241e45ceafdfd46b8eb64701 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fdf65c71241e45ceafdfd46b8eb64701()
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

      private sealed class MTHD_a4866e31ebb646d0bf470907b84cee52 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a4866e31ebb646d0bf470907b84cee52()
        {
          this.Initialize("get_frostWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).frostWalking;
        }
      }

      private sealed class MTHD_f2943d70652345b0809a0f7f59b99213 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f2943d70652345b0809a0f7f59b99213()
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

      private sealed class MTHD_6c4a9f88c4f546f6a102138405afc931 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6c4a9f88c4f546f6a102138405afc931()
        {
          this.Initialize("get_inWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class MTHD_571e16dc1e38487595c6d75770c638e7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_571e16dc1e38487595c6d75770c638e7()
        {
          this.Initialize("get_diesInWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).diesInWater;
        }
      }

      private sealed class MTHD_f62fa9333fff428aaba78ae5b1c288b9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f62fa9333fff428aaba78ae5b1c288b9()
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

      private sealed class MTHD_59677ca2d3864de38e318d5311f16a95 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_59677ca2d3864de38e318d5311f16a95()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).type;
        }
      }

      private sealed class MTHD_1393a1256a3944f1ac0794ac0d8084ee : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1393a1256a3944f1ac0794ac0d8084ee()
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

      private sealed class MTHD_81ae4ba96c3a41688e372792bf201ac7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_81ae4ba96c3a41688e372792bf201ac7()
        {
          this.Initialize("get_race", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).race;
        }
      }

      private sealed class MTHD_4206cfa194d84df4a7eefdab7a09595b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4206cfa194d84df4a7eefdab7a09595b()
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

      private sealed class MTHD_79aede3bfb1a49099e20e71bbd707357 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_79aede3bfb1a49099e20e71bbd707357()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class MTHD_fc70a02d5b94464690c5918c4f7bc553 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fc70a02d5b94464690c5918c4f7bc553()
        {
          this.Initialize("get_isRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class MTHD_eef8ef0b42b84151af33abc17f0001d7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eef8ef0b42b84151af33abc17f0001d7()
        {
          this.Initialize("get_isMounted", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class MTHD_148e07c513bb41f8b9d5bdb464093ae8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_148e07c513bb41f8b9d5bdb464093ae8()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class MTHD_c348020107e442ea9d2ac1e2335a69d8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c348020107e442ea9d2ac1e2335a69d8()
        {
          this.Initialize("get_isPawn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class MTHD_6a2f60184ae6455b8789e856dfd366a3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6a2f60184ae6455b8789e856dfd366a3()
        {
          this.Initialize("get_isFlying", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isFlying;
        }
      }

      private sealed class MTHD_15783b10ddd0403fbf67273623c34bfc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_15783b10ddd0403fbf67273623c34bfc()
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

      private sealed class MTHD_62a9df25b2b04cadbe10fbf114c20ca0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_62a9df25b2b04cadbe10fbf114c20ca0()
        {
          this.Initialize("get_isMountable", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class MTHD_4f82e2b2adea49d9b4a56bd36f2eac2d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4f82e2b2adea49d9b4a56bd36f2eac2d()
        {
          this.Initialize("get_canMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class MTHD_d86279e352624359ad8f11565eb04aa0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d86279e352624359ad8f11565eb04aa0()
        {
          this.Initialize("get_arcaneMonster", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).arcaneMonster;
        }
      }

      private sealed class MTHD_4086e191cb8e4e5ca6a416828db5f250 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4086e191cb8e4e5ca6a416828db5f250()
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

      private sealed class MTHD_af7f96244fc64b78a5822bbf86e820f2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_af7f96244fc64b78a5822bbf86e820f2()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).takeDamage;
        }
      }

      private sealed class MTHD_11ce37f7faea469b9c595f286e14ac3a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_11ce37f7faea469b9c595f286e14ac3a()
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

      private sealed class MTHD_5b5e2188572349b18a70d92f2bb9cb87 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5b5e2188572349b18a70d92f2bb9cb87()
        {
          this.Initialize("getRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getRider();
        }
      }

      private sealed class MTHD_bb16454b42fe49f6b256cf8f8c418b9d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bb16454b42fe49f6b256cf8f8c418b9d()
        {
          this.Initialize("getMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMount();
        }
      }

      private sealed class MTHD_d83c76f68bd44ebd97c924d7f65fb92c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d83c76f68bd44ebd97c924d7f65fb92c()
        {
          this.Initialize("getTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getTower();
        }
      }

      private sealed class MTHD_e6ac5e179da0497ca7fad5b480969020 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e6ac5e179da0497ca7fad5b480969020()
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

      private sealed class MTHD_e611aedcde79412fb6fe15dec5e686a7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e611aedcde79412fb6fe15dec5e686a7()
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

      private sealed class MTHD_7d96acda7297455d80cefb73641f7d2e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7d96acda7297455d80cefb73641f7d2e()
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

      private sealed class MTHD_2ca5e372795048f6b8fd57403fed5d87 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2ca5e372795048f6b8fd57403fed5d87()
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

      private sealed class MTHD_448d4900265443d49c800a330b68b684 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_448d4900265443d49c800a330b68b684()
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

      private sealed class MTHD_3ad98d7d5fef41fd8e16ed0eb47415cd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3ad98d7d5fef41fd8e16ed0eb47415cd()
        {
          this.Initialize("getActivateableFamiliarLevel", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarLevel();
        }
      }

      private sealed class MTHD_3c92055571c949df9c80983434dadc64 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3c92055571c949df9c80983434dadc64()
        {
          this.Initialize("getActivateableFamiliarBookID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarBookID();
        }
      }

      private sealed class MTHD_299a86be348e4ef389cf4883ee2cded5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_299a86be348e4ef389cf4883ee2cded5()
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

      private sealed class MTHD_3751c5931692447da83c9ac05f3d00d3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3751c5931692447da83c9ac05f3d00d3()
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

      private sealed class MTHD_c4fda91c9fe441f88818ce8eac9d9a40 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c4fda91c9fe441f88818ce8eac9d9a40()
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

      private sealed class MTHD_e923c38cd32c4ff693c2c9f496bf8117 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e923c38cd32c4ff693c2c9f496bf8117()
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

      private sealed class MTHD_cc2d6afd115040d9809d6453aff5753b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cc2d6afd115040d9809d6453aff5753b()
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

      private sealed class MTHD_e14c08a560d3436b9fbd3d808955b4e1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e14c08a560d3436b9fbd3d808955b4e1()
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

      private sealed class MTHD_b1bf746e34ad41c6b460ab90551f4e06 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b1bf746e34ad41c6b460ab90551f4e06()
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

      private sealed class MTHD_8c5cfa13faf740298159c27eb4be9800 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8c5cfa13faf740298159c27eb4be9800()
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

      private sealed class MTHD_9ca5fc919dd241c593d10b88b0e1e760 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9ca5fc919dd241c593d10b88b0e1e760()
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

      private sealed class MTHD_aacb249ccfc845c4bb8011c71d2329f2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aacb249ccfc845c4bb8011c71d2329f2()
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

      private sealed class MTHD_b99a5c34606e4a8684962a5453f06d84 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b99a5c34606e4a8684962a5453f06d84()
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

      private sealed class MTHD_fe68f098c8114f5aa6ee8f5c44bef9ff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fe68f098c8114f5aa6ee8f5c44bef9ff()
        {
          this.Initialize("getSpellCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getSpellCount();
        }
      }

      private sealed class MTHD_856c41403af94d64b76d5f4c473ac1c1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_856c41403af94d64b76d5f4c473ac1c1()
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

      private sealed class MTHD_a171d111cce14bd0b0c287db312f9e22 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a171d111cce14bd0b0c287db312f9e22()
        {
          this.Initialize("castedCountThisTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).castedCountThisTurn();
        }
      }

      private sealed class MTHD_fc6a67ccd1484e418508cd2dbf3951c0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fc6a67ccd1484e418508cd2dbf3951c0()
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

      private sealed class MTHD_74dd2f89a08347a8b14940e8289852c1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_74dd2f89a08347a8b14940e8289852c1()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMinionCount();
        }
      }

      private sealed class MTHD_cbbac9283ded4610a3bc3146ea9d2563 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cbbac9283ded4610a3bc3146ea9d2563()
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

      private sealed class MTHD_87bdf75548864c0d9343b5b3011d3dfe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_87bdf75548864c0d9343b5b3011d3dfe()
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

      private sealed class MTHD_412c0a3dd8394b2fb83d09e964694f64 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_412c0a3dd8394b2fb83d09e964694f64()
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

      private sealed class MTHD_0c2d9c29ce844a66a45ac4405b4bf018 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0c2d9c29ce844a66a45ac4405b4bf018()
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

      private sealed class MTHD_c34629d412134e2db22abcc896c23bfe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c34629d412134e2db22abcc896c23bfe()
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

      private sealed class MTHD_ef55fbd9256444538d5df05906487391 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ef55fbd9256444538d5df05906487391()
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

      private sealed class MTHD_7e0155baed614f33995409719fa3a438 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7e0155baed614f33995409719fa3a438()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).GetHashCode();
        }
      }

      private sealed class MTHD_8916401e8e08417fa3da7b0df01ad647 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8916401e8e08417fa3da7b0df01ad647()
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

      private sealed class MTHD_1038fea183024cdd8fff588f42e7ad7a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1038fea183024cdd8fff588f42e7ad7a()
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

      private sealed class MTHD_d44a899aeb9841dbab95c11d175f637e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d44a899aeb9841dbab95c11d175f637e()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_f422075f60484638b7b1d00c57381454 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f422075f60484638b7b1d00c57381454()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_89b4e6ee84a94e5b9f19f7b71b6eb17c : HardwiredMemberDescriptor
      {
        internal PROP_89b4e6ee84a94e5b9f19f7b71b6eb17c()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class PROP_55bcba04ee8a40fdb1fa17afbb03fff9 : HardwiredMemberDescriptor
      {
        internal PROP_55bcba04ee8a40fdb1fa17afbb03fff9()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class PROP_36ae507adbcd4b51b3ee1fc14fb154cf : HardwiredMemberDescriptor
      {
        internal PROP_36ae507adbcd4b51b3ee1fc14fb154cf()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class PROP_b2a5c0d15b19494dbba74bb83881f989 : HardwiredMemberDescriptor
      {
        internal PROP_b2a5c0d15b19494dbba74bb83881f989()
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

      private sealed class PROP_082741f2c95b476890d64579631fb689 : HardwiredMemberDescriptor
      {
        internal PROP_082741f2c95b476890d64579631fb689()
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

      private sealed class PROP_0c6227bb472d4583abd32293f07da891 : HardwiredMemberDescriptor
      {
        internal PROP_0c6227bb472d4583abd32293f07da891()
          : base(typeof (int), "healthAndTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class PROP_22ab5dc6a63740769ec530109f41fe17 : HardwiredMemberDescriptor
      {
        internal PROP_22ab5dc6a63740769ec530109f41fe17()
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

      private sealed class PROP_ad398a78b00f45a8bfc8dd93b1e39a8d : HardwiredMemberDescriptor
      {
        internal PROP_ad398a78b00f45a8bfc8dd93b1e39a8d()
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

      private sealed class PROP_2c2cf69b05a243f48868bf01ab0be057 : HardwiredMemberDescriptor
      {
        internal PROP_2c2cf69b05a243f48868bf01ab0be057()
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

      private sealed class PROP_f0ae939d4c1f4cc2ad4fbe37bab9d146 : HardwiredMemberDescriptor
      {
        internal PROP_f0ae939d4c1f4cc2ad4fbe37bab9d146()
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

      private sealed class PROP_85297bc5da584a0c916a8be69f662a06 : HardwiredMemberDescriptor
      {
        internal PROP_85297bc5da584a0c916a8be69f662a06()
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

      private sealed class PROP_3249c14708dd4ccdacb4381f8ca6ae49 : HardwiredMemberDescriptor
      {
        internal PROP_3249c14708dd4ccdacb4381f8ca6ae49()
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

      private sealed class PROP_f59b010833444ad8bb798ec90cc42d14 : HardwiredMemberDescriptor
      {
        internal PROP_f59b010833444ad8bb798ec90cc42d14()
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

      private sealed class PROP_9512e62cfa2b437090ca28fa62ca36d1 : HardwiredMemberDescriptor
      {
        internal PROP_9512e62cfa2b437090ca28fa62ca36d1()
          : base(typeof (bool), "inTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class PROP_02b6ef7dca3e4984ac3dde7c166f7210 : HardwiredMemberDescriptor
      {
        internal PROP_02b6ef7dca3e4984ac3dde7c166f7210()
          : base(typeof (bool), "isMoving", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class PROP_e6d345ed1f1e4ea399b817fc1ec05746 : HardwiredMemberDescriptor
      {
        internal PROP_e6d345ed1f1e4ea399b817fc1ec05746()
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

      private sealed class PROP_0de30f9a84b3422fa9b05ee68952218d : HardwiredMemberDescriptor
      {
        internal PROP_0de30f9a84b3422fa9b05ee68952218d()
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

      private sealed class PROP_5e83e2bcf83546438d4c05455929b2ba : HardwiredMemberDescriptor
      {
        internal PROP_5e83e2bcf83546438d4c05455929b2ba()
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

      private sealed class PROP_0c418db28aa94c1aaf35b91a45ebe9ca : HardwiredMemberDescriptor
      {
        internal PROP_0c418db28aa94c1aaf35b91a45ebe9ca()
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

      private sealed class PROP_52c654de9d644f5886f8e8b985cc5c0b : HardwiredMemberDescriptor
      {
        internal PROP_52c654de9d644f5886f8e8b985cc5c0b()
          : base(typeof (bool), "inWater", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class PROP_14553aa1c0d6445db93b45bd6e97c10f : HardwiredMemberDescriptor
      {
        internal PROP_14553aa1c0d6445db93b45bd6e97c10f()
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

      private sealed class PROP_52ff0557171444d9b2935fad24d76d35 : HardwiredMemberDescriptor
      {
        internal PROP_52ff0557171444d9b2935fad24d76d35()
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

      private sealed class PROP_663ad29b66d3491cb65b7c16adfbf553 : HardwiredMemberDescriptor
      {
        internal PROP_663ad29b66d3491cb65b7c16adfbf553()
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

      private sealed class PROP_39c34431cd38475eb7ed864f3e5689ca : HardwiredMemberDescriptor
      {
        internal PROP_39c34431cd38475eb7ed864f3e5689ca()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class PROP_685230aafb7c4b858d4843df53dfa639 : HardwiredMemberDescriptor
      {
        internal PROP_685230aafb7c4b858d4843df53dfa639()
          : base(typeof (bool), "isRider", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class PROP_2887ae569f804b6aa24444c4167bcc68 : HardwiredMemberDescriptor
      {
        internal PROP_2887ae569f804b6aa24444c4167bcc68()
          : base(typeof (bool), "isMounted", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class PROP_7635cbd2732f46bcb0bcfb44584b2d91 : HardwiredMemberDescriptor
      {
        internal PROP_7635cbd2732f46bcb0bcfb44584b2d91()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class PROP_173696969a02470481f899c8abcd82d0 : HardwiredMemberDescriptor
      {
        internal PROP_173696969a02470481f899c8abcd82d0()
          : base(typeof (bool), "isPawn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class PROP_d8dcd93c0f784baca1af90e2c65c085d : HardwiredMemberDescriptor
      {
        internal PROP_d8dcd93c0f784baca1af90e2c65c085d()
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

      private sealed class PROP_76a496154dc34b3891fd54dd63a1f557 : HardwiredMemberDescriptor
      {
        internal PROP_76a496154dc34b3891fd54dd63a1f557()
          : base(typeof (bool), "isMountable", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class PROP_9a3a20bccac441529a2f856539073ea1 : HardwiredMemberDescriptor
      {
        internal PROP_9a3a20bccac441529a2f856539073ea1()
          : base(typeof (bool), "canMount", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class PROP_4ef5712b8a744d19a9edc0568a3ec831 : HardwiredMemberDescriptor
      {
        internal PROP_4ef5712b8a744d19a9edc0568a3ec831()
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

      private sealed class PROP_25500334e8a744d0bbeb2a7cfce98568 : HardwiredMemberDescriptor
      {
        internal PROP_25500334e8a744d0bbeb2a7cfce98568()
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

    private sealed class TYPE_3537cb9d4d4e4b299135923c102ff5cd : HardwiredUserDataDescriptor
    {
      internal TYPE_3537cb9d4d4e4b299135923c102ff5cd()
        : base(typeof (ContainerEffector))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3537cb9d4d4e4b299135923c102ff5cd.MTHD_82845be0af554e3d9bcf669a13ede5b6()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3537cb9d4d4e4b299135923c102ff5cd.MTHD_1c015be4178546e0a94f6f1e59e38ee6()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3537cb9d4d4e4b299135923c102ff5cd.MTHD_68be0d46f78447fcadb0163e042e449b()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3537cb9d4d4e4b299135923c102ff5cd.MTHD_95d6f404f17144b2958dd74cc2aab174()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3537cb9d4d4e4b299135923c102ff5cd.MTHD_31ccd062cad348abad0ef4db79a7e0ea()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3537cb9d4d4e4b299135923c102ff5cd.MTHD_8b80603561e446d4925ad84c12f4c4c5()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3537cb9d4d4e4b299135923c102ff5cd.MTHD_0a29ca9cad15498eae8f1904f478c324()
        }));
        this.AddMember("get_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3537cb9d4d4e4b299135923c102ff5cd.MTHD_f68ba5431df64d10a71d1359f9c050a5()
        }));
        this.AddMember("set_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3537cb9d4d4e4b299135923c102ff5cd.MTHD_dc16e950b0b84ffdac6835e9d0dbe901()
        }));
        this.AddMember("get_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3537cb9d4d4e4b299135923c102ff5cd.MTHD_a157717c98454cf698f37d648bbcece0()
        }));
        this.AddMember("set_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3537cb9d4d4e4b299135923c102ff5cd.MTHD_53e80156a636433f9b37f4e560cdab42()
        }));
        this.AddMember("get_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3537cb9d4d4e4b299135923c102ff5cd.MTHD_bd0b5a47cd0d409aaf1802e7cd1ec3ea()
        }));
        this.AddMember("set_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3537cb9d4d4e4b299135923c102ff5cd.MTHD_1b31e03924cd48228b5d0e12d71aa68b()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3537cb9d4d4e4b299135923c102ff5cd.MTHD_3dfa3d854a0345ba854d4ee111acbad8()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3537cb9d4d4e4b299135923c102ff5cd.MTHD_7bcf72e0acad4bdd93c33bd5a099bc91()
        }));
        this.AddMember("turnPassed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("turnPassed", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3537cb9d4d4e4b299135923c102ff5cd.MTHD_7fadff9128aa47f5beaa26bb1734442b()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3537cb9d4d4e4b299135923c102ff5cd.MTHD_9fc3ef2eaf9d403e9010521c5c26f61e()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3537cb9d4d4e4b299135923c102ff5cd.MTHD_0a6a8f4d18e2486485adb99e01305b9c()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3537cb9d4d4e4b299135923c102ff5cd.MTHD_ecfba8ede224454da7089add226e5627()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3537cb9d4d4e4b299135923c102ff5cd.MTHD_fc095664d7f34e80a9ac58a5a9d6de6b()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_3537cb9d4d4e4b299135923c102ff5cd.PROP_faf3088faaf247a487400d609ff5139e());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_3537cb9d4d4e4b299135923c102ff5cd.PROP_63e2a20ba11142b58f79ffb67dde96e9());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_3537cb9d4d4e4b299135923c102ff5cd.PROP_214af3d7bcd849fabd7b1919ded6f72e());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_3537cb9d4d4e4b299135923c102ff5cd.PROP_f0a3da48b32d4bd08587a872c0a28348());
        this.AddMember("turnsAlive", (IMemberDescriptor) new Bridge.TYPE_3537cb9d4d4e4b299135923c102ff5cd.PROP_386ce3d8ae094ff6b6c54d596f3630f8());
        this.AddMember("maxTurnsAlive", (IMemberDescriptor) new Bridge.TYPE_3537cb9d4d4e4b299135923c102ff5cd.PROP_af7c1357aa534df297036517eecb828d());
        this.AddMember("active", (IMemberDescriptor) new Bridge.TYPE_3537cb9d4d4e4b299135923c102ff5cd.PROP_38256c0ade7546bc8e28d6fc4708f0ea());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_3537cb9d4d4e4b299135923c102ff5cd.PROP_4c4411eca8134f4683e14241b00129b2());
      }

      private sealed class MTHD_82845be0af554e3d9bcf669a13ede5b6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_82845be0af554e3d9bcf669a13ede5b6()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class MTHD_1c015be4178546e0a94f6f1e59e38ee6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1c015be4178546e0a94f6f1e59e38ee6()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).x;
        }
      }

      private sealed class MTHD_68be0d46f78447fcadb0163e042e449b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_68be0d46f78447fcadb0163e042e449b()
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

      private sealed class MTHD_95d6f404f17144b2958dd74cc2aab174 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_95d6f404f17144b2958dd74cc2aab174()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).y;
        }
      }

      private sealed class MTHD_31ccd062cad348abad0ef4db79a7e0ea : HardwiredMethodMemberDescriptor
      {
        internal MTHD_31ccd062cad348abad0ef4db79a7e0ea()
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

      private sealed class MTHD_8b80603561e446d4925ad84c12f4c4c5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8b80603561e446d4925ad84c12f4c4c5()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).position;
        }
      }

      private sealed class MTHD_0a29ca9cad15498eae8f1904f478c324 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0a29ca9cad15498eae8f1904f478c324()
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

      private sealed class MTHD_f68ba5431df64d10a71d1359f9c050a5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f68ba5431df64d10a71d1359f9c050a5()
        {
          this.Initialize("get_turnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).turnsAlive;
        }
      }

      private sealed class MTHD_dc16e950b0b84ffdac6835e9d0dbe901 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dc16e950b0b84ffdac6835e9d0dbe901()
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

      private sealed class MTHD_a157717c98454cf698f37d648bbcece0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a157717c98454cf698f37d648bbcece0()
        {
          this.Initialize("get_maxTurnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).maxTurnsAlive;
        }
      }

      private sealed class MTHD_53e80156a636433f9b37f4e560cdab42 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_53e80156a636433f9b37f4e560cdab42()
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

      private sealed class MTHD_bd0b5a47cd0d409aaf1802e7cd1ec3ea : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bd0b5a47cd0d409aaf1802e7cd1ec3ea()
        {
          this.Initialize("get_active", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).active;
        }
      }

      private sealed class MTHD_1b31e03924cd48228b5d0e12d71aa68b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1b31e03924cd48228b5d0e12d71aa68b()
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

      private sealed class MTHD_3dfa3d854a0345ba854d4ee111acbad8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3dfa3d854a0345ba854d4ee111acbad8()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }

      private sealed class MTHD_7bcf72e0acad4bdd93c33bd5a099bc91 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7bcf72e0acad4bdd93c33bd5a099bc91()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_7fadff9128aa47f5beaa26bb1734442b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7fadff9128aa47f5beaa26bb1734442b()
        {
          this.Initialize("turnPassed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).turnPassed();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_9fc3ef2eaf9d403e9010521c5c26f61e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9fc3ef2eaf9d403e9010521c5c26f61e()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).GetHashCode();
        }
      }

      private sealed class MTHD_0a6a8f4d18e2486485adb99e01305b9c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0a6a8f4d18e2486485adb99e01305b9c()
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

      private sealed class MTHD_ecfba8ede224454da7089add226e5627 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ecfba8ede224454da7089add226e5627()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_fc095664d7f34e80a9ac58a5a9d6de6b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fc095664d7f34e80a9ac58a5a9d6de6b()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_faf3088faaf247a487400d609ff5139e : HardwiredMemberDescriptor
      {
        internal PROP_faf3088faaf247a487400d609ff5139e()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class PROP_63e2a20ba11142b58f79ffb67dde96e9 : HardwiredMemberDescriptor
      {
        internal PROP_63e2a20ba11142b58f79ffb67dde96e9()
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

      private sealed class PROP_214af3d7bcd849fabd7b1919ded6f72e : HardwiredMemberDescriptor
      {
        internal PROP_214af3d7bcd849fabd7b1919ded6f72e()
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

      private sealed class PROP_f0a3da48b32d4bd08587a872c0a28348 : HardwiredMemberDescriptor
      {
        internal PROP_f0a3da48b32d4bd08587a872c0a28348()
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

      private sealed class PROP_386ce3d8ae094ff6b6c54d596f3630f8 : HardwiredMemberDescriptor
      {
        internal PROP_386ce3d8ae094ff6b6c54d596f3630f8()
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

      private sealed class PROP_af7c1357aa534df297036517eecb828d : HardwiredMemberDescriptor
      {
        internal PROP_af7c1357aa534df297036517eecb828d()
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

      private sealed class PROP_38256c0ade7546bc8e28d6fc4708f0ea : HardwiredMemberDescriptor
      {
        internal PROP_38256c0ade7546bc8e28d6fc4708f0ea()
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

      private sealed class PROP_4c4411eca8134f4683e14241b00129b2 : HardwiredMemberDescriptor
      {
        internal PROP_4c4411eca8134f4683e14241b00129b2()
          : base(typeof (EffectorType), "type", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }
    }

    private sealed class TYPE_581b06d047ba4597a4c2ac65495a0827 : HardwiredUserDataDescriptor
    {
      internal TYPE_581b06d047ba4597a4c2ac65495a0827()
        : base(typeof (ContainerIndicator))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_581b06d047ba4597a4c2ac65495a0827.MTHD_26677dee7b0a4395950785dd5b2b88aa()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_581b06d047ba4597a4c2ac65495a0827.MTHD_5b373ae047ac4233b740af44d453ebe5()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_581b06d047ba4597a4c2ac65495a0827.MTHD_5a68785f1aab42c498876dd59fbc53b7()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_581b06d047ba4597a4c2ac65495a0827.MTHD_957e64a5d9ba41a39c79af8a19b4a9bc()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_581b06d047ba4597a4c2ac65495a0827.MTHD_6728afbf7fc7460787fdd83c2ba6b88e()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_581b06d047ba4597a4c2ac65495a0827.MTHD_11976b978c5f4e7ca884c6cb6b95b56b()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_581b06d047ba4597a4c2ac65495a0827.MTHD_0a4864cf6671433a98385f8fad7ff73d()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_581b06d047ba4597a4c2ac65495a0827.MTHD_acc1480839f747789b3b8e867c120074()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_581b06d047ba4597a4c2ac65495a0827.MTHD_cecccbb55ca444b1a027739512c8004f()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_581b06d047ba4597a4c2ac65495a0827.MTHD_02375a4740d740189a32e4881a40e28b()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_581b06d047ba4597a4c2ac65495a0827.MTHD_d28d023ca8ca49e2a21f5dfca7a4638f()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_581b06d047ba4597a4c2ac65495a0827.MTHD_dc2cf131f4624a8dbd4cdb35364465cf()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_581b06d047ba4597a4c2ac65495a0827.MTHD_aba42bf09f2c4dd1ada0f73b42af1297()
        }));
        this.AddMember("get_kind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_kind", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_581b06d047ba4597a4c2ac65495a0827.MTHD_58bb41ab19bb4033839773d303ac545e()
        }));
        this.AddMember("Destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Destroy", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_581b06d047ba4597a4c2ac65495a0827.MTHD_9b74435819494d76b265f705294b7742()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_581b06d047ba4597a4c2ac65495a0827.MTHD_d8de3df08131426788b837f96d72d4ec()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_581b06d047ba4597a4c2ac65495a0827.MTHD_1d87b3d20e014814a15073b486e9f202()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_581b06d047ba4597a4c2ac65495a0827.MTHD_7af44aa5044c4e70bcfa64884583177d()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_581b06d047ba4597a4c2ac65495a0827.MTHD_007feef2ae6848a7a34c1b80ac858850()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_581b06d047ba4597a4c2ac65495a0827.PROP_c9ae6b2b93714f23b67fd789c3a5744d());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_581b06d047ba4597a4c2ac65495a0827.PROP_e1168aca5786466186c3569f3f9863c1());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_581b06d047ba4597a4c2ac65495a0827.PROP_5a33d280e40b4bf5a7a7f1d9c96e9157());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_581b06d047ba4597a4c2ac65495a0827.PROP_c0c7e4745fba4f2dbb83fcf477e54eec());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_581b06d047ba4597a4c2ac65495a0827.PROP_bb5dd38dafa44f369b3bc9ae2b823bf1());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_581b06d047ba4597a4c2ac65495a0827.PROP_3479e138ca1d46f681812ee725a99434());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_581b06d047ba4597a4c2ac65495a0827.PROP_6ae3e097db214cdf9e95c8b50d30dc9c());
        this.AddMember("kind", (IMemberDescriptor) new Bridge.TYPE_581b06d047ba4597a4c2ac65495a0827.PROP_b82f11b6a9884b32a8638a66a0552f30());
      }

      private sealed class MTHD_26677dee7b0a4395950785dd5b2b88aa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_26677dee7b0a4395950785dd5b2b88aa()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class MTHD_5b373ae047ac4233b740af44d453ebe5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5b373ae047ac4233b740af44d453ebe5()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).x;
        }
      }

      private sealed class MTHD_5a68785f1aab42c498876dd59fbc53b7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5a68785f1aab42c498876dd59fbc53b7()
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

      private sealed class MTHD_957e64a5d9ba41a39c79af8a19b4a9bc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_957e64a5d9ba41a39c79af8a19b4a9bc()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).y;
        }
      }

      private sealed class MTHD_6728afbf7fc7460787fdd83c2ba6b88e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6728afbf7fc7460787fdd83c2ba6b88e()
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

      private sealed class MTHD_11976b978c5f4e7ca884c6cb6b95b56b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_11976b978c5f4e7ca884c6cb6b95b56b()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).radius;
        }
      }

      private sealed class MTHD_0a4864cf6671433a98385f8fad7ff73d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0a4864cf6671433a98385f8fad7ff73d()
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

      private sealed class MTHD_acc1480839f747789b3b8e867c120074 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_acc1480839f747789b3b8e867c120074()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).position;
        }
      }

      private sealed class MTHD_cecccbb55ca444b1a027739512c8004f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cecccbb55ca444b1a027739512c8004f()
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

      private sealed class MTHD_02375a4740d740189a32e4881a40e28b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_02375a4740d740189a32e4881a40e28b()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).angle;
        }
      }

      private sealed class MTHD_d28d023ca8ca49e2a21f5dfca7a4638f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d28d023ca8ca49e2a21f5dfca7a4638f()
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

      private sealed class MTHD_dc2cf131f4624a8dbd4cdb35364465cf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dc2cf131f4624a8dbd4cdb35364465cf()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color;
        }
      }

      private sealed class MTHD_aba42bf09f2c4dd1ada0f73b42af1297 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aba42bf09f2c4dd1ada0f73b42af1297()
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

      private sealed class MTHD_58bb41ab19bb4033839773d303ac545e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_58bb41ab19bb4033839773d303ac545e()
        {
          this.Initialize("get_kind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }

      private sealed class MTHD_9b74435819494d76b265f705294b7742 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9b74435819494d76b265f705294b7742()
        {
          this.Initialize("Destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerIndicator) obj).Destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_d8de3df08131426788b837f96d72d4ec : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d8de3df08131426788b837f96d72d4ec()
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

      private sealed class MTHD_1d87b3d20e014814a15073b486e9f202 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1d87b3d20e014814a15073b486e9f202()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_7af44aa5044c4e70bcfa64884583177d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7af44aa5044c4e70bcfa64884583177d()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_007feef2ae6848a7a34c1b80ac858850 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_007feef2ae6848a7a34c1b80ac858850()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_c9ae6b2b93714f23b67fd789c3a5744d : HardwiredMemberDescriptor
      {
        internal PROP_c9ae6b2b93714f23b67fd789c3a5744d()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class PROP_e1168aca5786466186c3569f3f9863c1 : HardwiredMemberDescriptor
      {
        internal PROP_e1168aca5786466186c3569f3f9863c1()
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

      private sealed class PROP_5a33d280e40b4bf5a7a7f1d9c96e9157 : HardwiredMemberDescriptor
      {
        internal PROP_5a33d280e40b4bf5a7a7f1d9c96e9157()
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

      private sealed class PROP_c0c7e4745fba4f2dbb83fcf477e54eec : HardwiredMemberDescriptor
      {
        internal PROP_c0c7e4745fba4f2dbb83fcf477e54eec()
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

      private sealed class PROP_bb5dd38dafa44f369b3bc9ae2b823bf1 : HardwiredMemberDescriptor
      {
        internal PROP_bb5dd38dafa44f369b3bc9ae2b823bf1()
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

      private sealed class PROP_3479e138ca1d46f681812ee725a99434 : HardwiredMemberDescriptor
      {
        internal PROP_3479e138ca1d46f681812ee725a99434()
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

      private sealed class PROP_6ae3e097db214cdf9e95c8b50d30dc9c : HardwiredMemberDescriptor
      {
        internal PROP_6ae3e097db214cdf9e95c8b50d30dc9c()
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

      private sealed class PROP_b82f11b6a9884b32a8638a66a0552f30 : HardwiredMemberDescriptor
      {
        internal PROP_b82f11b6a9884b32a8638a66a0552f30()
          : base(typeof (IndicatorKind), "kind", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }
    }

    private sealed class TYPE_6a155dac15874566bf665a4981ed2ff1 : HardwiredUserDataDescriptor
    {
      internal TYPE_6a155dac15874566bf665a4981ed2ff1()
        : base(typeof (ContainerSpell))
      {
        this.AddMember("get_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6a155dac15874566bf665a4981ed2ff1.MTHD_294679694f944e1e8ed89f2290ff6f0a()
        }));
        this.AddMember("set_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6a155dac15874566bf665a4981ed2ff1.MTHD_ab1ee0f494bc4b86b2cca129cca5b0b0()
        }));
        this.AddMember("get_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6a155dac15874566bf665a4981ed2ff1.MTHD_3820f68a323e47c7acc807d3e6f19fb7()
        }));
        this.AddMember("set_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6a155dac15874566bf665a4981ed2ff1.MTHD_ef1d35b4c0c344f5a099cf81036bbda9()
        }));
        this.AddMember("get_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6a155dac15874566bf665a4981ed2ff1.MTHD_f61a51fa21b1491ea4732e4db41a3444()
        }));
        this.AddMember("set_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6a155dac15874566bf665a4981ed2ff1.MTHD_89fb942d5e2c4e208813bb271a790b8e()
        }));
        this.AddMember("get_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6a155dac15874566bf665a4981ed2ff1.MTHD_aca5dc98afec4e32b316ab2fdc5cc69c()
        }));
        this.AddMember("set_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6a155dac15874566bf665a4981ed2ff1.MTHD_bd93ea3fed3d4368b4f3325178940f99()
        }));
        this.AddMember("get_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6a155dac15874566bf665a4981ed2ff1.MTHD_74ca761befe3419b845c202aa5f860d1()
        }));
        this.AddMember("set_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6a155dac15874566bf665a4981ed2ff1.MTHD_96c89da73d0b4ef893fdf2ba70e66c5b()
        }));
        this.AddMember("get_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6a155dac15874566bf665a4981ed2ff1.MTHD_33b07d007ca3450787d5cfb88e97c1bc()
        }));
        this.AddMember("set_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6a155dac15874566bf665a4981ed2ff1.MTHD_235f16cb9e6d41c1a4fa14afc70a91c4()
        }));
        this.AddMember("get_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6a155dac15874566bf665a4981ed2ff1.MTHD_f73770e7405d43f2950ec1bee5123944()
        }));
        this.AddMember("set_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6a155dac15874566bf665a4981ed2ff1.MTHD_78abd5f4c9024527908098d0b54d009a()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6a155dac15874566bf665a4981ed2ff1.MTHD_87e76c4d3d1c4981bc2ab2cf753fd70c()
        }));
        this.AddMember("get_castType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_castType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6a155dac15874566bf665a4981ed2ff1.MTHD_706018e8a23e4b95ac782bd1c37b35be()
        }));
        this.AddMember("get_damageType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damageType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6a155dac15874566bf665a4981ed2ff1.MTHD_f53379d7d33d4fada9325fc8629a6c11()
        }));
        this.AddMember("get_book", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_book", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6a155dac15874566bf665a4981ed2ff1.MTHD_581050ed91a84a62996ae0c1dd65c763()
        }));
        this.AddMember("get_damage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damage", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6a155dac15874566bf665a4981ed2ff1.MTHD_5c526f97ba7b4764b1ccd305aec987f7()
        }));
        this.AddMember("get_explosionRadius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_explosionRadius", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6a155dac15874566bf665a4981ed2ff1.MTHD_cf9479ac1d18474ea16f3194856db075()
        }));
        this.AddMember("get_description", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_description", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6a155dac15874566bf665a4981ed2ff1.MTHD_ee6d9b6b237c4b84a302ed1b1279182c()
        }));
        this.AddMember("get_descriptionOnly", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionOnly", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6a155dac15874566bf665a4981ed2ff1.MTHD_d922edcc1f9a459ab1a5be750de747cb()
        }));
        this.AddMember("get_descriptionExtra", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionExtra", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6a155dac15874566bf665a4981ed2ff1.MTHD_1ad0544efe36453980d8fa26d37eef74()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6a155dac15874566bf665a4981ed2ff1.MTHD_eaa76560055143519ae149d228ffe849()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6a155dac15874566bf665a4981ed2ff1.MTHD_e6d40cd9d7ee4b979d52ce2af8f9c52b()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6a155dac15874566bf665a4981ed2ff1.MTHD_5dd79e75e8e340de835ffef36c7ae231()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6a155dac15874566bf665a4981ed2ff1.MTHD_c5a3f30ec3a94680bb27e10f5431f426()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6a155dac15874566bf665a4981ed2ff1.MTHD_aa80412c25024195b744d6ef5b77250c()
        }));
        this.AddMember("uses", (IMemberDescriptor) new Bridge.TYPE_6a155dac15874566bf665a4981ed2ff1.PROP_c1e715c7b62c4506a5903722d221bedc());
        this.AddMember("maxUses", (IMemberDescriptor) new Bridge.TYPE_6a155dac15874566bf665a4981ed2ff1.PROP_c87dbabe44234c558f870b052325bd17());
        this.AddMember("rechargeTime", (IMemberDescriptor) new Bridge.TYPE_6a155dac15874566bf665a4981ed2ff1.PROP_d02f5725bc954f7f915222cdc9410067());
        this.AddMember("lastTurnFired", (IMemberDescriptor) new Bridge.TYPE_6a155dac15874566bf665a4981ed2ff1.PROP_066cfbaa0c9d4e83ad67be43832a9a0c());
        this.AddMember("isPresent", (IMemberDescriptor) new Bridge.TYPE_6a155dac15874566bf665a4981ed2ff1.PROP_338b46c602be4f83aeb05ab90c0bd7e6());
        this.AddMember("locked", (IMemberDescriptor) new Bridge.TYPE_6a155dac15874566bf665a4981ed2ff1.PROP_0e64e5bb1bbc4471a679c944b816bfbc());
        this.AddMember("turnsTillFirstUse", (IMemberDescriptor) new Bridge.TYPE_6a155dac15874566bf665a4981ed2ff1.PROP_5c7d9e902a874376b20620dd8515fd5a());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_6a155dac15874566bf665a4981ed2ff1.PROP_c8fd6821dc754688813219a9a4a99198());
        this.AddMember("castType", (IMemberDescriptor) new Bridge.TYPE_6a155dac15874566bf665a4981ed2ff1.PROP_b95e616b55ad4678a643c1fdb3b88444());
        this.AddMember("damageType", (IMemberDescriptor) new Bridge.TYPE_6a155dac15874566bf665a4981ed2ff1.PROP_7c8c003f9da04eb4a1219bbadc058721());
        this.AddMember("book", (IMemberDescriptor) new Bridge.TYPE_6a155dac15874566bf665a4981ed2ff1.PROP_8a1f90617e4749dcb0c3e552ca30f4d0());
        this.AddMember("damage", (IMemberDescriptor) new Bridge.TYPE_6a155dac15874566bf665a4981ed2ff1.PROP_e87c3c2077f74b7b80f0fdd91fb5d26d());
        this.AddMember("explosionRadius", (IMemberDescriptor) new Bridge.TYPE_6a155dac15874566bf665a4981ed2ff1.PROP_25c73ac0ec164247ab61c41ce8347898());
        this.AddMember("description", (IMemberDescriptor) new Bridge.TYPE_6a155dac15874566bf665a4981ed2ff1.PROP_5b3ff7f70690461981aef0b146dbc88a());
        this.AddMember("descriptionOnly", (IMemberDescriptor) new Bridge.TYPE_6a155dac15874566bf665a4981ed2ff1.PROP_883a47dac22b427d98d41e1c6333a82e());
        this.AddMember("descriptionExtra", (IMemberDescriptor) new Bridge.TYPE_6a155dac15874566bf665a4981ed2ff1.PROP_b95fc8456fed425ab324c0319b7177c7());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_6a155dac15874566bf665a4981ed2ff1.PROP_d6408cee893c4daf8e36f78cc91361cf());
      }

      private sealed class MTHD_294679694f944e1e8ed89f2290ff6f0a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_294679694f944e1e8ed89f2290ff6f0a()
        {
          this.Initialize("get_uses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).uses;
        }
      }

      private sealed class MTHD_ab1ee0f494bc4b86b2cca129cca5b0b0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ab1ee0f494bc4b86b2cca129cca5b0b0()
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

      private sealed class MTHD_3820f68a323e47c7acc807d3e6f19fb7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3820f68a323e47c7acc807d3e6f19fb7()
        {
          this.Initialize("get_maxUses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).maxUses;
        }
      }

      private sealed class MTHD_ef1d35b4c0c344f5a099cf81036bbda9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ef1d35b4c0c344f5a099cf81036bbda9()
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

      private sealed class MTHD_f61a51fa21b1491ea4732e4db41a3444 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f61a51fa21b1491ea4732e4db41a3444()
        {
          this.Initialize("get_rechargeTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).rechargeTime;
        }
      }

      private sealed class MTHD_89fb942d5e2c4e208813bb271a790b8e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_89fb942d5e2c4e208813bb271a790b8e()
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

      private sealed class MTHD_aca5dc98afec4e32b316ab2fdc5cc69c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aca5dc98afec4e32b316ab2fdc5cc69c()
        {
          this.Initialize("get_lastTurnFired", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).lastTurnFired;
        }
      }

      private sealed class MTHD_bd93ea3fed3d4368b4f3325178940f99 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bd93ea3fed3d4368b4f3325178940f99()
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

      private sealed class MTHD_74ca761befe3419b845c202aa5f860d1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_74ca761befe3419b845c202aa5f860d1()
        {
          this.Initialize("get_isPresent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).isPresent;
        }
      }

      private sealed class MTHD_96c89da73d0b4ef893fdf2ba70e66c5b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_96c89da73d0b4ef893fdf2ba70e66c5b()
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

      private sealed class MTHD_33b07d007ca3450787d5cfb88e97c1bc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_33b07d007ca3450787d5cfb88e97c1bc()
        {
          this.Initialize("get_locked", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).locked;
        }
      }

      private sealed class MTHD_235f16cb9e6d41c1a4fa14afc70a91c4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_235f16cb9e6d41c1a4fa14afc70a91c4()
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

      private sealed class MTHD_f73770e7405d43f2950ec1bee5123944 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f73770e7405d43f2950ec1bee5123944()
        {
          this.Initialize("get_turnsTillFirstUse", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).turnsTillFirstUse;
        }
      }

      private sealed class MTHD_78abd5f4c9024527908098d0b54d009a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_78abd5f4c9024527908098d0b54d009a()
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

      private sealed class MTHD_87e76c4d3d1c4981bc2ab2cf753fd70c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_87e76c4d3d1c4981bc2ab2cf753fd70c()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class MTHD_706018e8a23e4b95ac782bd1c37b35be : HardwiredMethodMemberDescriptor
      {
        internal MTHD_706018e8a23e4b95ac782bd1c37b35be()
        {
          this.Initialize("get_castType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class MTHD_f53379d7d33d4fada9325fc8629a6c11 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f53379d7d33d4fada9325fc8629a6c11()
        {
          this.Initialize("get_damageType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class MTHD_581050ed91a84a62996ae0c1dd65c763 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_581050ed91a84a62996ae0c1dd65c763()
        {
          this.Initialize("get_book", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class MTHD_5c526f97ba7b4764b1ccd305aec987f7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5c526f97ba7b4764b1ccd305aec987f7()
        {
          this.Initialize("get_damage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class MTHD_cf9479ac1d18474ea16f3194856db075 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cf9479ac1d18474ea16f3194856db075()
        {
          this.Initialize("get_explosionRadius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class MTHD_ee6d9b6b237c4b84a302ed1b1279182c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ee6d9b6b237c4b84a302ed1b1279182c()
        {
          this.Initialize("get_description", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class MTHD_d922edcc1f9a459ab1a5be750de747cb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d922edcc1f9a459ab1a5be750de747cb()
        {
          this.Initialize("get_descriptionOnly", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class MTHD_1ad0544efe36453980d8fa26d37eef74 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1ad0544efe36453980d8fa26d37eef74()
        {
          this.Initialize("get_descriptionExtra", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class MTHD_eaa76560055143519ae149d228ffe849 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eaa76560055143519ae149d228ffe849()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }

      private sealed class MTHD_e6d40cd9d7ee4b979d52ce2af8f9c52b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e6d40cd9d7ee4b979d52ce2af8f9c52b()
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

      private sealed class MTHD_5dd79e75e8e340de835ffef36c7ae231 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5dd79e75e8e340de835ffef36c7ae231()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_c5a3f30ec3a94680bb27e10f5431f426 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c5a3f30ec3a94680bb27e10f5431f426()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_aa80412c25024195b744d6ef5b77250c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aa80412c25024195b744d6ef5b77250c()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_c1e715c7b62c4506a5903722d221bedc : HardwiredMemberDescriptor
      {
        internal PROP_c1e715c7b62c4506a5903722d221bedc()
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

      private sealed class PROP_c87dbabe44234c558f870b052325bd17 : HardwiredMemberDescriptor
      {
        internal PROP_c87dbabe44234c558f870b052325bd17()
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

      private sealed class PROP_d02f5725bc954f7f915222cdc9410067 : HardwiredMemberDescriptor
      {
        internal PROP_d02f5725bc954f7f915222cdc9410067()
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

      private sealed class PROP_066cfbaa0c9d4e83ad67be43832a9a0c : HardwiredMemberDescriptor
      {
        internal PROP_066cfbaa0c9d4e83ad67be43832a9a0c()
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

      private sealed class PROP_338b46c602be4f83aeb05ab90c0bd7e6 : HardwiredMemberDescriptor
      {
        internal PROP_338b46c602be4f83aeb05ab90c0bd7e6()
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

      private sealed class PROP_0e64e5bb1bbc4471a679c944b816bfbc : HardwiredMemberDescriptor
      {
        internal PROP_0e64e5bb1bbc4471a679c944b816bfbc()
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

      private sealed class PROP_5c7d9e902a874376b20620dd8515fd5a : HardwiredMemberDescriptor
      {
        internal PROP_5c7d9e902a874376b20620dd8515fd5a()
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

      private sealed class PROP_c8fd6821dc754688813219a9a4a99198 : HardwiredMemberDescriptor
      {
        internal PROP_c8fd6821dc754688813219a9a4a99198()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class PROP_b95e616b55ad4678a643c1fdb3b88444 : HardwiredMemberDescriptor
      {
        internal PROP_b95e616b55ad4678a643c1fdb3b88444()
          : base(typeof (CastType), "castType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class PROP_7c8c003f9da04eb4a1219bbadc058721 : HardwiredMemberDescriptor
      {
        internal PROP_7c8c003f9da04eb4a1219bbadc058721()
          : base(typeof (DamageType), "damageType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class PROP_8a1f90617e4749dcb0c3e552ca30f4d0 : HardwiredMemberDescriptor
      {
        internal PROP_8a1f90617e4749dcb0c3e552ca30f4d0()
          : base(typeof (BookOf), "book", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class PROP_e87c3c2077f74b7b80f0fdd91fb5d26d : HardwiredMemberDescriptor
      {
        internal PROP_e87c3c2077f74b7b80f0fdd91fb5d26d()
          : base(typeof (int), "damage", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class PROP_25c73ac0ec164247ab61c41ce8347898 : HardwiredMemberDescriptor
      {
        internal PROP_25c73ac0ec164247ab61c41ce8347898()
          : base(typeof (int), "explosionRadius", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class PROP_5b3ff7f70690461981aef0b146dbc88a : HardwiredMemberDescriptor
      {
        internal PROP_5b3ff7f70690461981aef0b146dbc88a()
          : base(typeof (string), "description", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class PROP_883a47dac22b427d98d41e1c6333a82e : HardwiredMemberDescriptor
      {
        internal PROP_883a47dac22b427d98d41e1c6333a82e()
          : base(typeof (string), "descriptionOnly", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class PROP_b95fc8456fed425ab324c0319b7177c7 : HardwiredMemberDescriptor
      {
        internal PROP_b95fc8456fed425ab324c0319b7177c7()
          : base(typeof (string), "descriptionExtra", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class PROP_d6408cee893c4daf8e36f78cc91361cf : HardwiredMemberDescriptor
      {
        internal PROP_d6408cee893c4daf8e36f78cc91361cf()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }
    }

    private sealed class TYPE_74af1a6cc35648a5a3e139d2a0eb8011 : HardwiredUserDataDescriptor
    {
      internal TYPE_74af1a6cc35648a5a3e139d2a0eb8011()
        : base(typeof (ContainerTower))
      {
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_74af1a6cc35648a5a3e139d2a0eb8011.MTHD_363040dfb2da4f71a0df7bf89746b502()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_74af1a6cc35648a5a3e139d2a0eb8011.MTHD_42c02fef4f724ab087fc704ea5ed4f6a()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_74af1a6cc35648a5a3e139d2a0eb8011.MTHD_8ba30fe44d5d4e64b7ad94172180a97d()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_74af1a6cc35648a5a3e139d2a0eb8011.MTHD_513a394e6ed14f68aa9057c08151377c()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_74af1a6cc35648a5a3e139d2a0eb8011.MTHD_0afb32fa5cda4152aa9b2a6401a3b025()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_74af1a6cc35648a5a3e139d2a0eb8011.MTHD_6290855bcbf543d1bcfe00d3e6c8e021()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_74af1a6cc35648a5a3e139d2a0eb8011.MTHD_a87128dd73ff40fabae325b570985091()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_74af1a6cc35648a5a3e139d2a0eb8011.MTHD_1e9271c1458241df8cf8554683c79212()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_74af1a6cc35648a5a3e139d2a0eb8011.MTHD_4eb0d47f6da1435daa10852640d27aab()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_74af1a6cc35648a5a3e139d2a0eb8011.MTHD_871f22a6d7b34ba985688529225f8201()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_74af1a6cc35648a5a3e139d2a0eb8011.MTHD_eddfe6327f7047bc8c85c2e348208277()
        }));
        this.AddMember("getType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_74af1a6cc35648a5a3e139d2a0eb8011.MTHD_928a396ed4a9429592bb420d8f154b16()
        }));
        this.AddMember("kill", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("kill", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_74af1a6cc35648a5a3e139d2a0eb8011.MTHD_d18c8c5a1af14439937a5d4fd0ebb55d()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_74af1a6cc35648a5a3e139d2a0eb8011.MTHD_b5b693d2d1194df1a28b374507051dec()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_74af1a6cc35648a5a3e139d2a0eb8011.MTHD_4821eac8719f4598ad9f9dc2be725f8a()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_74af1a6cc35648a5a3e139d2a0eb8011.MTHD_22f419d685534decb57d248e69e6c2ee()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_74af1a6cc35648a5a3e139d2a0eb8011.MTHD_addc3976a4264f88bc47d42638066a43()
        }));
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_74af1a6cc35648a5a3e139d2a0eb8011.PROP_71573c12d184458681b031b61086b7be());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_74af1a6cc35648a5a3e139d2a0eb8011.PROP_623f7fd4e4744c71b7ac7855607ea917());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_74af1a6cc35648a5a3e139d2a0eb8011.PROP_bf1da7ec106044fc82044bbf55856b97());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_74af1a6cc35648a5a3e139d2a0eb8011.PROP_b7d659dede42416aad22793d9ba17b38());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_74af1a6cc35648a5a3e139d2a0eb8011.PROP_68e1bce27ea940849b4e6643764ab6fb());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_74af1a6cc35648a5a3e139d2a0eb8011.PROP_d777892f8fe6429faefd2edb23f08397());
      }

      private sealed class MTHD_363040dfb2da4f71a0df7bf89746b502 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_363040dfb2da4f71a0df7bf89746b502()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).health;
        }
      }

      private sealed class MTHD_42c02fef4f724ab087fc704ea5ed4f6a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_42c02fef4f724ab087fc704ea5ed4f6a()
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

      private sealed class MTHD_8ba30fe44d5d4e64b7ad94172180a97d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8ba30fe44d5d4e64b7ad94172180a97d()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).maxHealth;
        }
      }

      private sealed class MTHD_513a394e6ed14f68aa9057c08151377c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_513a394e6ed14f68aa9057c08151377c()
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

      private sealed class MTHD_0afb32fa5cda4152aa9b2a6401a3b025 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0afb32fa5cda4152aa9b2a6401a3b025()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).x;
        }
      }

      private sealed class MTHD_6290855bcbf543d1bcfe00d3e6c8e021 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6290855bcbf543d1bcfe00d3e6c8e021()
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

      private sealed class MTHD_a87128dd73ff40fabae325b570985091 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a87128dd73ff40fabae325b570985091()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).y;
        }
      }

      private sealed class MTHD_1e9271c1458241df8cf8554683c79212 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1e9271c1458241df8cf8554683c79212()
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

      private sealed class MTHD_4eb0d47f6da1435daa10852640d27aab : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4eb0d47f6da1435daa10852640d27aab()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).position;
        }
      }

      private sealed class MTHD_871f22a6d7b34ba985688529225f8201 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_871f22a6d7b34ba985688529225f8201()
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

      private sealed class MTHD_eddfe6327f7047bc8c85c2e348208277 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eddfe6327f7047bc8c85c2e348208277()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }

      private sealed class MTHD_928a396ed4a9429592bb420d8f154b16 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_928a396ed4a9429592bb420d8f154b16()
        {
          this.Initialize("getType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).getType();
        }
      }

      private sealed class MTHD_d18c8c5a1af14439937a5d4fd0ebb55d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d18c8c5a1af14439937a5d4fd0ebb55d()
        {
          this.Initialize("kill", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerTower) obj).kill();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_b5b693d2d1194df1a28b374507051dec : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b5b693d2d1194df1a28b374507051dec()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).GetHashCode();
        }
      }

      private sealed class MTHD_4821eac8719f4598ad9f9dc2be725f8a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4821eac8719f4598ad9f9dc2be725f8a()
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

      private sealed class MTHD_22f419d685534decb57d248e69e6c2ee : HardwiredMethodMemberDescriptor
      {
        internal MTHD_22f419d685534decb57d248e69e6c2ee()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_addc3976a4264f88bc47d42638066a43 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_addc3976a4264f88bc47d42638066a43()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_71573c12d184458681b031b61086b7be : HardwiredMemberDescriptor
      {
        internal PROP_71573c12d184458681b031b61086b7be()
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

      private sealed class PROP_623f7fd4e4744c71b7ac7855607ea917 : HardwiredMemberDescriptor
      {
        internal PROP_623f7fd4e4744c71b7ac7855607ea917()
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

      private sealed class PROP_bf1da7ec106044fc82044bbf55856b97 : HardwiredMemberDescriptor
      {
        internal PROP_bf1da7ec106044fc82044bbf55856b97()
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

      private sealed class PROP_b7d659dede42416aad22793d9ba17b38 : HardwiredMemberDescriptor
      {
        internal PROP_b7d659dede42416aad22793d9ba17b38()
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

      private sealed class PROP_68e1bce27ea940849b4e6643764ab6fb : HardwiredMemberDescriptor
      {
        internal PROP_68e1bce27ea940849b4e6643764ab6fb()
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

      private sealed class PROP_d777892f8fe6429faefd2edb23f08397 : HardwiredMemberDescriptor
      {
        internal PROP_d777892f8fe6429faefd2edb23f08397()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }
    }

    private sealed class TYPE_c8e24ec930764cf9a4add3d694cd9b69 : HardwiredUserDataDescriptor
    {
      internal TYPE_c8e24ec930764cf9a4add3d694cd9b69()
        : base(typeof (Educative.Point))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c8e24ec930764cf9a4add3d694cd9b69.MTHD_933da7312ede4f159214eef518870d11(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c8e24ec930764cf9a4add3d694cd9b69.MTHD_c660f58b00c54bb295acc1370520974e()
        }));
        this.AddMember("distance", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("distance", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c8e24ec930764cf9a4add3d694cd9b69.MTHD_d0f54d20f9fb47548d69e0b376cc090e(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c8e24ec930764cf9a4add3d694cd9b69.MTHD_ad2decc05fb646bdb7ba519e11dc6eda()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c8e24ec930764cf9a4add3d694cd9b69.MTHD_c1d3eef715a84833b0fda7f4aeaca65c()
        }));
        this.AddMember("copy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("copy", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c8e24ec930764cf9a4add3d694cd9b69.MTHD_0e3b8331d8de4d4bae6cae76812783bc()
        }));
        this.AddMember("normalized", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalized", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c8e24ec930764cf9a4add3d694cd9b69.MTHD_efe6b56921cb47e4ae76933984b4c2b8()
        }));
        this.AddMember("normalize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalize", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c8e24ec930764cf9a4add3d694cd9b69.MTHD_4b2d67f769e244f695845cda22d626f1()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c8e24ec930764cf9a4add3d694cd9b69.MTHD_48b2aeceefcb4ee883cb71a59fe5ee5b()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c8e24ec930764cf9a4add3d694cd9b69.MTHD_9a6596f7e3f244f39c953f19fba321ac()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c8e24ec930764cf9a4add3d694cd9b69.MTHD_04baf809dedf4a9ebd67da7d4c31866c()
        }));
        this.AddMember("op_Subtraction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Subtraction", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c8e24ec930764cf9a4add3d694cd9b69.MTHD_a2e8daab15f54755956f7d578cdb401c(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c8e24ec930764cf9a4add3d694cd9b69.MTHD_742ef31f8f2143c5a2289623a8dcb2be()
        }));
        this.AddMember("op_Addition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Addition", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c8e24ec930764cf9a4add3d694cd9b69.MTHD_31eb6c191ec64bbcb0108a49cc97529b(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c8e24ec930764cf9a4add3d694cd9b69.MTHD_45bc90d3deff4f0bb2594712a63457f5()
        }));
        this.AddMember("op_Multiply", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Multiply", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c8e24ec930764cf9a4add3d694cd9b69.MTHD_035f14caf27d4608909d61f624273715(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c8e24ec930764cf9a4add3d694cd9b69.MTHD_a4e47ed7b4d04e4597af5157e0c0ad40()
        }));
        this.AddMember("op_Division", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Division", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c8e24ec930764cf9a4add3d694cd9b69.MTHD_f862175d7e5b449aa0cb5663a2cac139(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c8e24ec930764cf9a4add3d694cd9b69.MTHD_e33523b0cbe24fb4b213b1288ce5c976()
        }));
        this.AddMember("op_Modulus", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Modulus", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c8e24ec930764cf9a4add3d694cd9b69.MTHD_c4b9f18bce064a97b5f47883bbeb4ee6(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c8e24ec930764cf9a4add3d694cd9b69.MTHD_2f49dc9480174581b6e1f6e7552e0b14()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c8e24ec930764cf9a4add3d694cd9b69.MTHD_78dcde3199e0488f8f307acde665db67()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c8e24ec930764cf9a4add3d694cd9b69.MTHD_4177f96155e445b9ace60d097d21d96c()
        }));
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_c8e24ec930764cf9a4add3d694cd9b69.FLDV_b2203076f73844c8ad93326804fa9b6f());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_c8e24ec930764cf9a4add3d694cd9b69.FLDV_6791dd27a52b4fbda78309c5c52376f7());
      }

      private sealed class MTHD_933da7312ede4f159214eef518870d11 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_933da7312ede4f159214eef518870d11()
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

      private sealed class MTHD_c660f58b00c54bb295acc1370520974e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c660f58b00c54bb295acc1370520974e()
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

      private sealed class MTHD_d0f54d20f9fb47548d69e0b376cc090e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d0f54d20f9fb47548d69e0b376cc090e()
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

      private sealed class MTHD_ad2decc05fb646bdb7ba519e11dc6eda : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ad2decc05fb646bdb7ba519e11dc6eda()
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

      private sealed class MTHD_c1d3eef715a84833b0fda7f4aeaca65c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c1d3eef715a84833b0fda7f4aeaca65c()
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

      private sealed class MTHD_0e3b8331d8de4d4bae6cae76812783bc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0e3b8331d8de4d4bae6cae76812783bc()
        {
          this.Initialize("copy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).copy();
        }
      }

      private sealed class MTHD_efe6b56921cb47e4ae76933984b4c2b8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_efe6b56921cb47e4ae76933984b4c2b8()
        {
          this.Initialize("normalized", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).normalized();
        }
      }

      private sealed class MTHD_4b2d67f769e244f695845cda22d626f1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4b2d67f769e244f695845cda22d626f1()
        {
          this.Initialize("normalize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((Educative.Point) obj).normalize();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_48b2aeceefcb4ee883cb71a59fe5ee5b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_48b2aeceefcb4ee883cb71a59fe5ee5b()
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

      private sealed class MTHD_9a6596f7e3f244f39c953f19fba321ac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9a6596f7e3f244f39c953f19fba321ac()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).GetHashCode();
        }
      }

      private sealed class MTHD_04baf809dedf4a9ebd67da7d4c31866c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_04baf809dedf4a9ebd67da7d4c31866c()
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

      private sealed class MTHD_a2e8daab15f54755956f7d578cdb401c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a2e8daab15f54755956f7d578cdb401c()
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

      private sealed class MTHD_742ef31f8f2143c5a2289623a8dcb2be : HardwiredMethodMemberDescriptor
      {
        internal MTHD_742ef31f8f2143c5a2289623a8dcb2be()
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

      private sealed class MTHD_31eb6c191ec64bbcb0108a49cc97529b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_31eb6c191ec64bbcb0108a49cc97529b()
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

      private sealed class MTHD_45bc90d3deff4f0bb2594712a63457f5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_45bc90d3deff4f0bb2594712a63457f5()
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

      private sealed class MTHD_035f14caf27d4608909d61f624273715 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_035f14caf27d4608909d61f624273715()
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

      private sealed class MTHD_a4e47ed7b4d04e4597af5157e0c0ad40 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a4e47ed7b4d04e4597af5157e0c0ad40()
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

      private sealed class MTHD_f862175d7e5b449aa0cb5663a2cac139 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f862175d7e5b449aa0cb5663a2cac139()
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

      private sealed class MTHD_e33523b0cbe24fb4b213b1288ce5c976 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e33523b0cbe24fb4b213b1288ce5c976()
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

      private sealed class MTHD_c4b9f18bce064a97b5f47883bbeb4ee6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c4b9f18bce064a97b5f47883bbeb4ee6()
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

      private sealed class MTHD_2f49dc9480174581b6e1f6e7552e0b14 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2f49dc9480174581b6e1f6e7552e0b14()
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

      private sealed class MTHD_78dcde3199e0488f8f307acde665db67 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_78dcde3199e0488f8f307acde665db67()
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

      private sealed class MTHD_4177f96155e445b9ace60d097d21d96c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4177f96155e445b9ace60d097d21d96c()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_b2203076f73844c8ad93326804fa9b6f : HardwiredMemberDescriptor
      {
        internal FLDV_b2203076f73844c8ad93326804fa9b6f()
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

      private sealed class FLDV_6791dd27a52b4fbda78309c5c52376f7 : HardwiredMemberDescriptor
      {
        internal FLDV_6791dd27a52b4fbda78309c5c52376f7()
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

    private sealed class TYPE_12148485094142e394f2aa9351b7a259 : HardwiredUserDataDescriptor
    {
      internal TYPE_12148485094142e394f2aa9351b7a259()
        : base(typeof (Summon))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_12148485094142e394f2aa9351b7a259.MTHD_947d87601de94a97ba69e06c893c6ec7()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_12148485094142e394f2aa9351b7a259.MTHD_f5c99d2cd8574f208182b980015d4ff0()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_12148485094142e394f2aa9351b7a259.MTHD_3bee3bee518444d29cc36fc558fad61d()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_12148485094142e394f2aa9351b7a259.MTHD_655042ba522a409299e0ee0763d4b56d()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_12148485094142e394f2aa9351b7a259.MTHD_54c777a0f6a447cba5067a725579f1f3()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_12148485094142e394f2aa9351b7a259.MTHD_587fb3e100134ffeaedf7db755721bc1()
        }));
        this.AddMember("spell", (IMemberDescriptor) new Bridge.TYPE_12148485094142e394f2aa9351b7a259.FLDV_250366e94d8a47f3a286c8b499759242());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_12148485094142e394f2aa9351b7a259.FLDV_abdc933bfbfc40fa880827d184483f3f());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_12148485094142e394f2aa9351b7a259.FLDV_3cfa52252ccb4131bf7d6e3c36d217f5());
        this.AddMember("onPlayersPanel", (IMemberDescriptor) new Bridge.TYPE_12148485094142e394f2aa9351b7a259.FLDV_2766213f9a5d45fdaea15e0b54f6ddef());
        this.AddMember("useAI", (IMemberDescriptor) new Bridge.TYPE_12148485094142e394f2aa9351b7a259.FLDV_a892d7f3e8ba447aab129ffd196b10d3());
        this.AddMember("no_AI_still_use_turn", (IMemberDescriptor) new Bridge.TYPE_12148485094142e394f2aa9351b7a259.FLDV_f451acf65f934196b620b57fb5884da7());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_12148485094142e394f2aa9351b7a259.FLDV_2f9b4133ffaa49319434351123913c35());
        this.AddMember("playSound", (IMemberDescriptor) new Bridge.TYPE_12148485094142e394f2aa9351b7a259.FLDV_e5ded6c10a19407b8fdb59e66bbe3b05());
        this.AddMember("colors", (IMemberDescriptor) new Bridge.TYPE_12148485094142e394f2aa9351b7a259.FLDV_31e1a705b2134d8b89ec41abf8ba9112());
        this.AddMember("spells", (IMemberDescriptor) new Bridge.TYPE_12148485094142e394f2aa9351b7a259.FLDV_309bd0e62e784f28ac550838805fea12());
        this.AddMember("outfit", (IMemberDescriptor) new Bridge.TYPE_12148485094142e394f2aa9351b7a259.FLDV_2e0e08f9455f4422a80429b6afc5cb11());
        this.AddMember("elemental", (IMemberDescriptor) new Bridge.TYPE_12148485094142e394f2aa9351b7a259.FLDV_1a32f0427c59432e8af6565ebf79f1e7());
      }

      private sealed class MTHD_947d87601de94a97ba69e06c893c6ec7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_947d87601de94a97ba69e06c893c6ec7()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new Summon();
        }
      }

      private sealed class MTHD_f5c99d2cd8574f208182b980015d4ff0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f5c99d2cd8574f208182b980015d4ff0()
        {
          this.Initialize("construct", true, new ParameterDescriptor[10]
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
            new ParameterDescriptor("elemental", typeof (BookOf), true, (object) new DefaultValue(), false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          if (argscount <= 0)
            return (object) Summon.construct((object) null, (Educative.Point) null, 1, (Table) null, true, false, "", (Table) null, (Table) null, BookOf.Nothing);
          if (argscount <= 1)
            return (object) Summon.construct(pars[0], (Educative.Point) null, 1, (Table) null, true, false, "", (Table) null, (Table) null, BookOf.Nothing);
          if (argscount <= 2)
            return (object) Summon.construct(pars[0], (Educative.Point) pars[1], 1, (Table) null, true, false, "", (Table) null, (Table) null, BookOf.Nothing);
          if (argscount <= 3)
            return (object) Summon.construct(pars[0], (Educative.Point) pars[1], (int) pars[2], (Table) null, true, false, "", (Table) null, (Table) null, BookOf.Nothing);
          if (argscount <= 4)
            return (object) Summon.construct(pars[0], (Educative.Point) pars[1], (int) pars[2], (Table) pars[3], true, false, "", (Table) null, (Table) null, BookOf.Nothing);
          if (argscount <= 5)
            return (object) Summon.construct(pars[0], (Educative.Point) pars[1], (int) pars[2], (Table) pars[3], (bool) pars[4], false, "", (Table) null, (Table) null, BookOf.Nothing);
          if (argscount <= 6)
            return (object) Summon.construct(pars[0], (Educative.Point) pars[1], (int) pars[2], (Table) pars[3], (bool) pars[4], (bool) pars[5], "", (Table) null, (Table) null, BookOf.Nothing);
          if (argscount <= 7)
            return (object) Summon.construct(pars[0], (Educative.Point) pars[1], (int) pars[2], (Table) pars[3], (bool) pars[4], (bool) pars[5], (string) pars[6], (Table) null, (Table) null, BookOf.Nothing);
          if (argscount <= 8)
            return (object) Summon.construct(pars[0], (Educative.Point) pars[1], (int) pars[2], (Table) pars[3], (bool) pars[4], (bool) pars[5], (string) pars[6], (Table) pars[7], (Table) null, BookOf.Nothing);
          return argscount <= 9 ? (object) Summon.construct(pars[0], (Educative.Point) pars[1], (int) pars[2], (Table) pars[3], (bool) pars[4], (bool) pars[5], (string) pars[6], (Table) pars[7], (Table) pars[8], BookOf.Nothing) : (object) Summon.construct(pars[0], (Educative.Point) pars[1], (int) pars[2], (Table) pars[3], (bool) pars[4], (bool) pars[5], (string) pars[6], (Table) pars[7], (Table) pars[8], (BookOf) pars[9]);
        }
      }

      private sealed class MTHD_3bee3bee518444d29cc36fc558fad61d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3bee3bee518444d29cc36fc558fad61d()
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

      private sealed class MTHD_655042ba522a409299e0ee0763d4b56d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_655042ba522a409299e0ee0763d4b56d()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_54c777a0f6a447cba5067a725579f1f3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_54c777a0f6a447cba5067a725579f1f3()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_587fb3e100134ffeaedf7db755721bc1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_587fb3e100134ffeaedf7db755721bc1()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_250366e94d8a47f3a286c8b499759242 : HardwiredMemberDescriptor
      {
        internal FLDV_250366e94d8a47f3a286c8b499759242()
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

      private sealed class FLDV_abdc933bfbfc40fa880827d184483f3f : HardwiredMemberDescriptor
      {
        internal FLDV_abdc933bfbfc40fa880827d184483f3f()
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

      private sealed class FLDV_3cfa52252ccb4131bf7d6e3c36d217f5 : HardwiredMemberDescriptor
      {
        internal FLDV_3cfa52252ccb4131bf7d6e3c36d217f5()
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

      private sealed class FLDV_2766213f9a5d45fdaea15e0b54f6ddef : HardwiredMemberDescriptor
      {
        internal FLDV_2766213f9a5d45fdaea15e0b54f6ddef()
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

      private sealed class FLDV_a892d7f3e8ba447aab129ffd196b10d3 : HardwiredMemberDescriptor
      {
        internal FLDV_a892d7f3e8ba447aab129ffd196b10d3()
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

      private sealed class FLDV_f451acf65f934196b620b57fb5884da7 : HardwiredMemberDescriptor
      {
        internal FLDV_f451acf65f934196b620b57fb5884da7()
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

      private sealed class FLDV_2f9b4133ffaa49319434351123913c35 : HardwiredMemberDescriptor
      {
        internal FLDV_2f9b4133ffaa49319434351123913c35()
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

      private sealed class FLDV_e5ded6c10a19407b8fdb59e66bbe3b05 : HardwiredMemberDescriptor
      {
        internal FLDV_e5ded6c10a19407b8fdb59e66bbe3b05()
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

      private sealed class FLDV_31e1a705b2134d8b89ec41abf8ba9112 : HardwiredMemberDescriptor
      {
        internal FLDV_31e1a705b2134d8b89ec41abf8ba9112()
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

      private sealed class FLDV_309bd0e62e784f28ac550838805fea12 : HardwiredMemberDescriptor
      {
        internal FLDV_309bd0e62e784f28ac550838805fea12()
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

      private sealed class FLDV_2e0e08f9455f4422a80429b6afc5cb11 : HardwiredMemberDescriptor
      {
        internal FLDV_2e0e08f9455f4422a80429b6afc5cb11()
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

      private sealed class FLDV_1a32f0427c59432e8af6565ebf79f1e7 : HardwiredMemberDescriptor
      {
        internal FLDV_1a32f0427c59432e8af6565ebf79f1e7()
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

    private sealed class TYPE_d6df1413e71f4404b0a22b0db88f6861 : HardwiredUserDataDescriptor
    {
      internal TYPE_d6df1413e71f4404b0a22b0db88f6861()
        : base(typeof (UIElement))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.MTHD_91f58e9cb9574e1f8e7b4a029d35d07c()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.MTHD_b23ea58b12784adf8d4c90d141ff536b()
        }));
        this.AddMember("get_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.MTHD_de2cedc1457543b3aca23577957ab7ab()
        }));
        this.AddMember("set_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.MTHD_c4e24e9f1cee4ddfb31502dc623acb91()
        }));
        this.AddMember("get_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.MTHD_bbe8f587c5e74c69a00a658db57c6cd4()
        }));
        this.AddMember("set_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.MTHD_5b50b264e2524cc2b460912bc82c4854()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.MTHD_e97833e7b165482cb59243c190b45b5b()
        }));
        this.AddMember("set_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.MTHD_4e00d2aa645045e9a3cb911ab76b6ad6()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.MTHD_2df21230de6e416e84b8045d30c4e33e()
        }));
        this.AddMember("set_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.MTHD_c77c9f6874cb4d31b85a87fba8937895()
        }));
        this.AddMember("get_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.MTHD_9cb593876b1741ba91418c8d8249b5e7()
        }));
        this.AddMember("set_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.MTHD_8747fdac134942a0b82e2bc7b9796e13()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.MTHD_f91b1f33ad64436585358b32bf39f679()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.MTHD_ae68d638afa6498fb3ffcc3a5d8e78bc()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.MTHD_1462241882484420b52960b8b01e5016()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.MTHD_f58952ed984a4a5ab3ac1753f9bc4ef8()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.MTHD_ca600b7f9f194926bbcb44da14b13a33()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.MTHD_2af3c6f08d714e3bb869b15a45740a79()
        }));
        this.AddMember("get_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.MTHD_28dab3188ebf4e6dabb82102f8aec011()
        }));
        this.AddMember("set_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.MTHD_561cfa0cf73e4be88d782234f1cc7f7f()
        }));
        this.AddMember("get_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.MTHD_bb4f62b9cd654110842c86135b0504a2()
        }));
        this.AddMember("set_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.MTHD_e60827a4491b48e5bd8ba164bc2a896a()
        }));
        this.AddMember("get_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.MTHD_3277b0f136ac4d87b65a4acfa94ee3af()
        }));
        this.AddMember("set_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.MTHD_33b96d5260a34945ab68f9c4dd00abc0()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.MTHD_e3b873cef3c840e0a7ab1d8bd0684f85()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.MTHD_c6e0441f6c5b49c5a11c124963f9fb44()
        }));
        this.AddMember("get_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.MTHD_bcaacc3687e84ed7b0cfe2040feb97c5()
        }));
        this.AddMember("set_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.MTHD_4c9e713364df42e2a9710be3e91acdb3()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.MTHD_4a523b57463b4434b09000c33a861c06()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.MTHD_84308f55b41843c4a82029294304f2de()
        }));
        this.AddMember("get_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.MTHD_29bce9d5b5504c3f8c299030a79e688a()
        }));
        this.AddMember("set_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.MTHD_7ba6341e6b244e739c25d084f323b774()
        }));
        this.AddMember("get_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.MTHD_9c9f041b22e1474e8f788eb042b0eeba()
        }));
        this.AddMember("set_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.MTHD_94a97d56a5a3400ab8cf6d36dbfc4530()
        }));
        this.AddMember("get_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.MTHD_a98016bb3fd14ee3beffe0950b255f7e()
        }));
        this.AddMember("set_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.MTHD_7f3ee64f1534401ab26b126b3d96afd6()
        }));
        this.AddMember("get_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.MTHD_2e46444b3fd04d5f819495d786d33e20()
        }));
        this.AddMember("set_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.MTHD_fdc853468f5c4207be80c3164b4ba11e()
        }));
        this.AddMember("activateInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("activateInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.MTHD_d8e30a5a41c9403498041592d5364d64()
        }));
        this.AddMember("createUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createUI", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.MTHD_9dbe5899503b449bb4d2d29b8add50c0()
        }));
        this.AddMember("createInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.MTHD_fa66142ed52c483395b780a7da41bf97()
        }));
        this.AddMember("duplicate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("duplicate", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.MTHD_aaa919a6086d40a7b2e51ff028b39a76()
        }));
        this.AddMember("destroyHierarchy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroyHierarchy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.MTHD_83f8bcda95c64eeb87eac71e277c5137()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.MTHD_1dd1828a74094b6fa01426d03f5f428f()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.MTHD_c07c16c2b4724e798ee32cab796b7280()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.MTHD_3bd56b9f1b234c71abddc6d7e558fbc0()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.MTHD_de052c09b7b14c069057a216896a2a27()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.MTHD_c214481ad12c437b99ce74f7ed21648d()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.PROP_72de92fe10a14e689f40d62c7d0d17c3());
        this.AddMember("graphic", (IMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.PROP_55a44326d52a4cacb6f38bcd5adf72e9());
        this.AddMember("anchor", (IMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.PROP_0034e59090c0492da70d260daf496fb6());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.PROP_5e147a6d90234ca8b6abf7ff52b4f21c());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.PROP_66499ce4d9e14c3f8b141ac7c2e20204());
        this.AddMember("size", (IMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.PROP_60fd97b770d14367b324da7f8317c028());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.PROP_d949e77cb38e4acd99b02a32b36c0fed());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.PROP_84c261a7733745f6ba321c62f872c197());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.PROP_f366ab7946cb4932970c33b911fe8e8b());
        this.AddMember("pivot_x", (IMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.PROP_a415de63ec34450a913062c31f126b19());
        this.AddMember("pivot_y", (IMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.PROP_a9cb825e3fa94642a05c852146759a6f());
        this.AddMember("pivot", (IMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.PROP_b6f0cc96df3544149d140548a0008bec());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.PROP_7bbd1f01eedb4fa493b42d3ce9796369());
        this.AddMember("onClick", (IMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.PROP_dd2606756033427ba7500f63626f2476());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.PROP_46c7e14a4498446fb5c8d4f1a9563494());
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.PROP_02de50c5bfa94715a494809e7bb564a9());
        this.AddMember("textColor", (IMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.PROP_71ff7446da5d402b95d14572a6a6bb03());
        this.AddMember("textStyle", (IMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.PROP_6c884a9ade97433eb79a80952370c039());
        this.AddMember("textSize", (IMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.PROP_6aea5b948df14f2e953ddc5797208c7b());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.FLDV_22d7213629804fa4b07e77312c173ab1());
        this.AddMember("clickID", (IMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.FLDV_4d0528222f2f45ec85b26d78b068300d());
        this.AddMember("clickDestroy", (IMemberDescriptor) new Bridge.TYPE_d6df1413e71f4404b0a22b0db88f6861.FLDV_907cbc6eb9a7485a92756fcadc2b0d01());
      }

      private sealed class MTHD_91f58e9cb9574e1f8e7b4a029d35d07c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_91f58e9cb9574e1f8e7b4a029d35d07c()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new UIElement();
        }
      }

      private sealed class MTHD_b23ea58b12784adf8d4c90d141ff536b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b23ea58b12784adf8d4c90d141ff536b()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class MTHD_de2cedc1457543b3aca23577957ab7ab : HardwiredMethodMemberDescriptor
      {
        internal MTHD_de2cedc1457543b3aca23577957ab7ab()
        {
          this.Initialize("get_graphic", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return ((UIElement) obj).graphic;
        }
      }

      private sealed class MTHD_c4e24e9f1cee4ddfb31502dc623acb91 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c4e24e9f1cee4ddfb31502dc623acb91()
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

      private sealed class MTHD_bbe8f587c5e74c69a00a658db57c6cd4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bbe8f587c5e74c69a00a658db57c6cd4()
        {
          this.Initialize("get_anchor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).anchor;
        }
      }

      private sealed class MTHD_5b50b264e2524cc2b460912bc82c4854 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5b50b264e2524cc2b460912bc82c4854()
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

      private sealed class MTHD_e97833e7b165482cb59243c190b45b5b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e97833e7b165482cb59243c190b45b5b()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).width;
        }
      }

      private sealed class MTHD_4e00d2aa645045e9a3cb911ab76b6ad6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4e00d2aa645045e9a3cb911ab76b6ad6()
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

      private sealed class MTHD_2df21230de6e416e84b8045d30c4e33e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2df21230de6e416e84b8045d30c4e33e()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).height;
        }
      }

      private sealed class MTHD_c77c9f6874cb4d31b85a87fba8937895 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c77c9f6874cb4d31b85a87fba8937895()
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

      private sealed class MTHD_9cb593876b1741ba91418c8d8249b5e7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9cb593876b1741ba91418c8d8249b5e7()
        {
          this.Initialize("get_size", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).size;
        }
      }

      private sealed class MTHD_8747fdac134942a0b82e2bc7b9796e13 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8747fdac134942a0b82e2bc7b9796e13()
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

      private sealed class MTHD_f91b1f33ad64436585358b32bf39f679 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f91b1f33ad64436585358b32bf39f679()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).x;
        }
      }

      private sealed class MTHD_ae68d638afa6498fb3ffcc3a5d8e78bc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ae68d638afa6498fb3ffcc3a5d8e78bc()
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

      private sealed class MTHD_1462241882484420b52960b8b01e5016 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1462241882484420b52960b8b01e5016()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).y;
        }
      }

      private sealed class MTHD_f58952ed984a4a5ab3ac1753f9bc4ef8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f58952ed984a4a5ab3ac1753f9bc4ef8()
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

      private sealed class MTHD_ca600b7f9f194926bbcb44da14b13a33 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ca600b7f9f194926bbcb44da14b13a33()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).position;
        }
      }

      private sealed class MTHD_2af3c6f08d714e3bb869b15a45740a79 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2af3c6f08d714e3bb869b15a45740a79()
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

      private sealed class MTHD_28dab3188ebf4e6dabb82102f8aec011 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_28dab3188ebf4e6dabb82102f8aec011()
        {
          this.Initialize("get_pivot_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_x;
        }
      }

      private sealed class MTHD_561cfa0cf73e4be88d782234f1cc7f7f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_561cfa0cf73e4be88d782234f1cc7f7f()
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

      private sealed class MTHD_bb4f62b9cd654110842c86135b0504a2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bb4f62b9cd654110842c86135b0504a2()
        {
          this.Initialize("get_pivot_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_y;
        }
      }

      private sealed class MTHD_e60827a4491b48e5bd8ba164bc2a896a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e60827a4491b48e5bd8ba164bc2a896a()
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

      private sealed class MTHD_3277b0f136ac4d87b65a4acfa94ee3af : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3277b0f136ac4d87b65a4acfa94ee3af()
        {
          this.Initialize("get_pivot", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot;
        }
      }

      private sealed class MTHD_33b96d5260a34945ab68f9c4dd00abc0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_33b96d5260a34945ab68f9c4dd00abc0()
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

      private sealed class MTHD_e3b873cef3c840e0a7ab1d8bd0684f85 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e3b873cef3c840e0a7ab1d8bd0684f85()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).angle;
        }
      }

      private sealed class MTHD_c6e0441f6c5b49c5a11c124963f9fb44 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c6e0441f6c5b49c5a11c124963f9fb44()
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

      private sealed class MTHD_bcaacc3687e84ed7b0cfe2040feb97c5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bcaacc3687e84ed7b0cfe2040feb97c5()
        {
          this.Initialize("get_onClick", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick;
        }
      }

      private sealed class MTHD_4c9e713364df42e2a9710be3e91acdb3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4c9e713364df42e2a9710be3e91acdb3()
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

      private sealed class MTHD_4a523b57463b4434b09000c33a861c06 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4a523b57463b4434b09000c33a861c06()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color;
        }
      }

      private sealed class MTHD_84308f55b41843c4a82029294304f2de : HardwiredMethodMemberDescriptor
      {
        internal MTHD_84308f55b41843c4a82029294304f2de()
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

      private sealed class MTHD_29bce9d5b5504c3f8c299030a79e688a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_29bce9d5b5504c3f8c299030a79e688a()
        {
          this.Initialize("get_text", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).text;
        }
      }

      private sealed class MTHD_7ba6341e6b244e739c25d084f323b774 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7ba6341e6b244e739c25d084f323b774()
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

      private sealed class MTHD_9c9f041b22e1474e8f788eb042b0eeba : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9c9f041b22e1474e8f788eb042b0eeba()
        {
          this.Initialize("get_textColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor;
        }
      }

      private sealed class MTHD_94a97d56a5a3400ab8cf6d36dbfc4530 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_94a97d56a5a3400ab8cf6d36dbfc4530()
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

      private sealed class MTHD_a98016bb3fd14ee3beffe0950b255f7e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a98016bb3fd14ee3beffe0950b255f7e()
        {
          this.Initialize("get_textStyle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textStyle;
        }
      }

      private sealed class MTHD_7f3ee64f1534401ab26b126b3d96afd6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7f3ee64f1534401ab26b126b3d96afd6()
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

      private sealed class MTHD_2e46444b3fd04d5f819495d786d33e20 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2e46444b3fd04d5f819495d786d33e20()
        {
          this.Initialize("get_textSize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textSize;
        }
      }

      private sealed class MTHD_fdc853468f5c4207be80c3164b4ba11e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fdc853468f5c4207be80c3164b4ba11e()
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

      private sealed class MTHD_d8e30a5a41c9403498041592d5364d64 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d8e30a5a41c9403498041592d5364d64()
        {
          this.Initialize("activateInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).activateInput();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_9dbe5899503b449bb4d2d29b8add50c0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9dbe5899503b449bb4d2d29b8add50c0()
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

      private sealed class MTHD_fa66142ed52c483395b780a7da41bf97 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fa66142ed52c483395b780a7da41bf97()
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

      private sealed class MTHD_aaa919a6086d40a7b2e51ff028b39a76 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aaa919a6086d40a7b2e51ff028b39a76()
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

      private sealed class MTHD_83f8bcda95c64eeb87eac71e277c5137 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_83f8bcda95c64eeb87eac71e277c5137()
        {
          this.Initialize("destroyHierarchy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroyHierarchy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_1dd1828a74094b6fa01426d03f5f428f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1dd1828a74094b6fa01426d03f5f428f()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_c07c16c2b4724e798ee32cab796b7280 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c07c16c2b4724e798ee32cab796b7280()
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

      private sealed class MTHD_3bd56b9f1b234c71abddc6d7e558fbc0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3bd56b9f1b234c71abddc6d7e558fbc0()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_de052c09b7b14c069057a216896a2a27 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_de052c09b7b14c069057a216896a2a27()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_c214481ad12c437b99ce74f7ed21648d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c214481ad12c437b99ce74f7ed21648d()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_72de92fe10a14e689f40d62c7d0d17c3 : HardwiredMemberDescriptor
      {
        internal PROP_72de92fe10a14e689f40d62c7d0d17c3()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class PROP_55a44326d52a4cacb6f38bcd5adf72e9 : HardwiredMemberDescriptor
      {
        internal PROP_55a44326d52a4cacb6f38bcd5adf72e9()
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

      private sealed class PROP_0034e59090c0492da70d260daf496fb6 : HardwiredMemberDescriptor
      {
        internal PROP_0034e59090c0492da70d260daf496fb6()
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

      private sealed class PROP_5e147a6d90234ca8b6abf7ff52b4f21c : HardwiredMemberDescriptor
      {
        internal PROP_5e147a6d90234ca8b6abf7ff52b4f21c()
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

      private sealed class PROP_66499ce4d9e14c3f8b141ac7c2e20204 : HardwiredMemberDescriptor
      {
        internal PROP_66499ce4d9e14c3f8b141ac7c2e20204()
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

      private sealed class PROP_60fd97b770d14367b324da7f8317c028 : HardwiredMemberDescriptor
      {
        internal PROP_60fd97b770d14367b324da7f8317c028()
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

      private sealed class PROP_d949e77cb38e4acd99b02a32b36c0fed : HardwiredMemberDescriptor
      {
        internal PROP_d949e77cb38e4acd99b02a32b36c0fed()
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

      private sealed class PROP_84c261a7733745f6ba321c62f872c197 : HardwiredMemberDescriptor
      {
        internal PROP_84c261a7733745f6ba321c62f872c197()
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

      private sealed class PROP_f366ab7946cb4932970c33b911fe8e8b : HardwiredMemberDescriptor
      {
        internal PROP_f366ab7946cb4932970c33b911fe8e8b()
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

      private sealed class PROP_a415de63ec34450a913062c31f126b19 : HardwiredMemberDescriptor
      {
        internal PROP_a415de63ec34450a913062c31f126b19()
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

      private sealed class PROP_a9cb825e3fa94642a05c852146759a6f : HardwiredMemberDescriptor
      {
        internal PROP_a9cb825e3fa94642a05c852146759a6f()
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

      private sealed class PROP_b6f0cc96df3544149d140548a0008bec : HardwiredMemberDescriptor
      {
        internal PROP_b6f0cc96df3544149d140548a0008bec()
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

      private sealed class PROP_7bbd1f01eedb4fa493b42d3ce9796369 : HardwiredMemberDescriptor
      {
        internal PROP_7bbd1f01eedb4fa493b42d3ce9796369()
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

      private sealed class PROP_dd2606756033427ba7500f63626f2476 : HardwiredMemberDescriptor
      {
        internal PROP_dd2606756033427ba7500f63626f2476()
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

      private sealed class PROP_46c7e14a4498446fb5c8d4f1a9563494 : HardwiredMemberDescriptor
      {
        internal PROP_46c7e14a4498446fb5c8d4f1a9563494()
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

      private sealed class PROP_02de50c5bfa94715a494809e7bb564a9 : HardwiredMemberDescriptor
      {
        internal PROP_02de50c5bfa94715a494809e7bb564a9()
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

      private sealed class PROP_71ff7446da5d402b95d14572a6a6bb03 : HardwiredMemberDescriptor
      {
        internal PROP_71ff7446da5d402b95d14572a6a6bb03()
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

      private sealed class PROP_6c884a9ade97433eb79a80952370c039 : HardwiredMemberDescriptor
      {
        internal PROP_6c884a9ade97433eb79a80952370c039()
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

      private sealed class PROP_6aea5b948df14f2e953ddc5797208c7b : HardwiredMemberDescriptor
      {
        internal PROP_6aea5b948df14f2e953ddc5797208c7b()
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

      private sealed class FLDV_22d7213629804fa4b07e77312c173ab1 : HardwiredMemberDescriptor
      {
        internal FLDV_22d7213629804fa4b07e77312c173ab1()
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

      private sealed class FLDV_4d0528222f2f45ec85b26d78b068300d : HardwiredMemberDescriptor
      {
        internal FLDV_4d0528222f2f45ec85b26d78b068300d()
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

      private sealed class FLDV_907cbc6eb9a7485a92756fcadc2b0d01 : HardwiredMemberDescriptor
      {
        internal FLDV_907cbc6eb9a7485a92756fcadc2b0d01()
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

    private sealed class TYPE_67e3a4ecde2f4b11900b5d089dfbd498 : HardwiredUserDataDescriptor
    {
      internal TYPE_67e3a4ecde2f4b11900b5d089dfbd498()
        : base(typeof (MyPoll.Item))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_67e3a4ecde2f4b11900b5d089dfbd498.MTHD_968b2c8b298b444096732d8e8a27008a()
        }));
        this.AddMember("addAnswer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addAnswer", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_67e3a4ecde2f4b11900b5d089dfbd498.MTHD_8658b6d381774ea1a0e32a37b544eac8()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_67e3a4ecde2f4b11900b5d089dfbd498.MTHD_57f834e7a09a4e7fadc698d22f63736b()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_67e3a4ecde2f4b11900b5d089dfbd498.MTHD_5071916428d84f79a0db7807907b21c6()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_67e3a4ecde2f4b11900b5d089dfbd498.MTHD_eda53a715b454299af9d7e7fe8c77be9()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_67e3a4ecde2f4b11900b5d089dfbd498.MTHD_3166e6e236794ad481f742815f4a4b0a()
        }));
        this.AddMember("question", (IMemberDescriptor) new Bridge.TYPE_67e3a4ecde2f4b11900b5d089dfbd498.FLDV_853a7203c6b044268681356b082ffbe2());
        this.AddMember("multipleSelection", (IMemberDescriptor) new Bridge.TYPE_67e3a4ecde2f4b11900b5d089dfbd498.FLDV_07a813cbf4104d9b83d1bf9c074b42dc());
        this.AddMember("requiresAnswer", (IMemberDescriptor) new Bridge.TYPE_67e3a4ecde2f4b11900b5d089dfbd498.FLDV_297115451639492f80fd4d58dad57f4e());
        this.AddMember("answers", (IMemberDescriptor) new Bridge.TYPE_67e3a4ecde2f4b11900b5d089dfbd498.FLDV_198d7cc1142541a7aae5e9d971b2f7ed());
      }

      private sealed class MTHD_968b2c8b298b444096732d8e8a27008a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_968b2c8b298b444096732d8e8a27008a()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Item();
        }
      }

      private sealed class MTHD_8658b6d381774ea1a0e32a37b544eac8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8658b6d381774ea1a0e32a37b544eac8()
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

      private sealed class MTHD_57f834e7a09a4e7fadc698d22f63736b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_57f834e7a09a4e7fadc698d22f63736b()
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

      private sealed class MTHD_5071916428d84f79a0db7807907b21c6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5071916428d84f79a0db7807907b21c6()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_eda53a715b454299af9d7e7fe8c77be9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eda53a715b454299af9d7e7fe8c77be9()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_3166e6e236794ad481f742815f4a4b0a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3166e6e236794ad481f742815f4a4b0a()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_853a7203c6b044268681356b082ffbe2 : HardwiredMemberDescriptor
      {
        internal FLDV_853a7203c6b044268681356b082ffbe2()
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

      private sealed class FLDV_07a813cbf4104d9b83d1bf9c074b42dc : HardwiredMemberDescriptor
      {
        internal FLDV_07a813cbf4104d9b83d1bf9c074b42dc()
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

      private sealed class FLDV_297115451639492f80fd4d58dad57f4e : HardwiredMemberDescriptor
      {
        internal FLDV_297115451639492f80fd4d58dad57f4e()
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

      private sealed class FLDV_198d7cc1142541a7aae5e9d971b2f7ed : HardwiredMemberDescriptor
      {
        internal FLDV_198d7cc1142541a7aae5e9d971b2f7ed()
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

    private sealed class TYPE_9e44052e6886400cbe7185b0dce26d80 : HardwiredUserDataDescriptor
    {
      internal TYPE_9e44052e6886400cbe7185b0dce26d80()
        : base(typeof (MyPoll.Answer))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9e44052e6886400cbe7185b0dce26d80.MTHD_5da96b32205740849b207d0a07ce31cf()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9e44052e6886400cbe7185b0dce26d80.MTHD_029eed692af546feba0cf30a8652cc63()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9e44052e6886400cbe7185b0dce26d80.MTHD_c711bfa8fe7d492399ad6198ba85f1b1()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9e44052e6886400cbe7185b0dce26d80.MTHD_46e0b5f561d14b7cb885c27fbdb27f0a()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9e44052e6886400cbe7185b0dce26d80.MTHD_6a08d6e4d01e48e68f401e13558a3f18()
        }));
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_9e44052e6886400cbe7185b0dce26d80.FLDV_cc4aaba8cd114584bec50475daf53a73());
        this.AddMember("allowUserInput", (IMemberDescriptor) new Bridge.TYPE_9e44052e6886400cbe7185b0dce26d80.FLDV_c6dcba85862c4eddb9ab18362e7e416d());
        this.AddMember("checkable", (IMemberDescriptor) new Bridge.TYPE_9e44052e6886400cbe7185b0dce26d80.FLDV_14c4541c6dbb49be9c68ba3e4728b07d());
        this.AddMember("userInput", (IMemberDescriptor) new Bridge.TYPE_9e44052e6886400cbe7185b0dce26d80.FLDV_93d19aacadc947398f8c69fcdb66e496());
        this.AddMember("isChecked", (IMemberDescriptor) new Bridge.TYPE_9e44052e6886400cbe7185b0dce26d80.FLDV_968c6882e102454cbbc770ab65481d92());
      }

      private sealed class MTHD_5da96b32205740849b207d0a07ce31cf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5da96b32205740849b207d0a07ce31cf()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Answer();
        }
      }

      private sealed class MTHD_029eed692af546feba0cf30a8652cc63 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_029eed692af546feba0cf30a8652cc63()
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

      private sealed class MTHD_c711bfa8fe7d492399ad6198ba85f1b1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c711bfa8fe7d492399ad6198ba85f1b1()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_46e0b5f561d14b7cb885c27fbdb27f0a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_46e0b5f561d14b7cb885c27fbdb27f0a()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_6a08d6e4d01e48e68f401e13558a3f18 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6a08d6e4d01e48e68f401e13558a3f18()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_cc4aaba8cd114584bec50475daf53a73 : HardwiredMemberDescriptor
      {
        internal FLDV_cc4aaba8cd114584bec50475daf53a73()
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

      private sealed class FLDV_c6dcba85862c4eddb9ab18362e7e416d : HardwiredMemberDescriptor
      {
        internal FLDV_c6dcba85862c4eddb9ab18362e7e416d()
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

      private sealed class FLDV_14c4541c6dbb49be9c68ba3e4728b07d : HardwiredMemberDescriptor
      {
        internal FLDV_14c4541c6dbb49be9c68ba3e4728b07d()
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

      private sealed class FLDV_93d19aacadc947398f8c69fcdb66e496 : HardwiredMemberDescriptor
      {
        internal FLDV_93d19aacadc947398f8c69fcdb66e496()
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

      private sealed class FLDV_968c6882e102454cbbc770ab65481d92 : HardwiredMemberDescriptor
      {
        internal FLDV_968c6882e102454cbbc770ab65481d92()
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

    private sealed class TYPE_deffe13bb7124a9983aa86c031d6eb60 : HardwiredUserDataDescriptor
    {
      internal TYPE_deffe13bb7124a9983aa86c031d6eb60()
        : base(typeof (MyPoll))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_deffe13bb7124a9983aa86c031d6eb60.MTHD_21119c555de64ae9821ac9085f70dbb8()
        }));
        this.AddMember("GetQuestionsAsString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetQuestionsAsString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_deffe13bb7124a9983aa86c031d6eb60.MTHD_ce9563187ab44d01a7193a93a8efdd36()
        }));
        this.AddMember("SanitizeResponses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("SanitizeResponses", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_deffe13bb7124a9983aa86c031d6eb60.MTHD_843c5fdc1ce9433296082fb3de2f6e72()
        }));
        this.AddMember("addItem", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addItem", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_deffe13bb7124a9983aa86c031d6eb60.MTHD_7047529abdbf469d8cad9baef917a129()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_deffe13bb7124a9983aa86c031d6eb60.MTHD_76ac07aeb30d466bb3f4ba87d1f86d35()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_deffe13bb7124a9983aa86c031d6eb60.MTHD_75be244d9ffe4902829f1d2f52da286d()
        }));
        this.AddMember("fromString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fromString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_deffe13bb7124a9983aa86c031d6eb60.MTHD_3402bec9ba4d45d7aebf3649a5192adb()
        }));
        this.AddMember("sendToServer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("sendToServer", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_deffe13bb7124a9983aa86c031d6eb60.MTHD_bc28f34dfa5a4a5da685f2f7651746c0()
        }));
        this.AddMember("closePoll", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("closePoll", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_deffe13bb7124a9983aa86c031d6eb60.MTHD_9b753682c657439f8d36c1ae82e9a8e2()
        }));
        this.AddMember("test", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("test", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_deffe13bb7124a9983aa86c031d6eb60.MTHD_b7af128b7abd47fab14aac67e9e54b48()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_deffe13bb7124a9983aa86c031d6eb60.MTHD_bb3c559d37bb4b118cc5489341bc5b34()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_deffe13bb7124a9983aa86c031d6eb60.MTHD_448fd772d1894d589c8a4559d910236b()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_deffe13bb7124a9983aa86c031d6eb60.MTHD_3fdda6ad9f824db39796b4483d39c354()
        }));
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_deffe13bb7124a9983aa86c031d6eb60.FLDV_d46f029637d94db0a0970dfea5b10eca());
        this.AddMember("id", (IMemberDescriptor) new Bridge.TYPE_deffe13bb7124a9983aa86c031d6eb60.FLDV_f2cb864f59ea4184b2d62d5e7e66cbcd());
        this.AddMember("items", (IMemberDescriptor) new Bridge.TYPE_deffe13bb7124a9983aa86c031d6eb60.FLDV_6497e346808744a8863f189ae495317c());
        this.AddMember("isPublic", (IMemberDescriptor) new Bridge.TYPE_deffe13bb7124a9983aa86c031d6eb60.FLDV_b5650a31eebc432db62355d08e72e2d0());
        this.AddMember("MsgRetrieve", (IMemberDescriptor) new Bridge.TYPE_deffe13bb7124a9983aa86c031d6eb60.FLDV_722264a915d2405d9e67e033409b46a5());
        this.AddMember("MsgSubmit", (IMemberDescriptor) new Bridge.TYPE_deffe13bb7124a9983aa86c031d6eb60.FLDV_f4ab791602d94e029b3a6eceafcf2efb());
        this.AddMember("MsgCreate", (IMemberDescriptor) new Bridge.TYPE_deffe13bb7124a9983aa86c031d6eb60.FLDV_b91ae2bf4f37411d9a8a6abc96dba626());
        this.AddMember("MsgResults", (IMemberDescriptor) new Bridge.TYPE_deffe13bb7124a9983aa86c031d6eb60.FLDV_4eb7821e9a5d47eebaa6784dd849ab96());
        this.AddMember("Item", (IMemberDescriptor) new Bridge.TYPE_deffe13bb7124a9983aa86c031d6eb60.DVAL_5f31396ea5d5449e80ab9acf59891d16());
        this.AddMember("Answer", (IMemberDescriptor) new Bridge.TYPE_deffe13bb7124a9983aa86c031d6eb60.DVAL_ca4b30c7ea154f78b94f25f09bc28a35());
      }

      private sealed class MTHD_21119c555de64ae9821ac9085f70dbb8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_21119c555de64ae9821ac9085f70dbb8()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll();
        }
      }

      private sealed class MTHD_ce9563187ab44d01a7193a93a8efdd36 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ce9563187ab44d01a7193a93a8efdd36()
        {
          this.Initialize("GetQuestionsAsString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).GetQuestionsAsString();
        }
      }

      private sealed class MTHD_843c5fdc1ce9433296082fb3de2f6e72 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_843c5fdc1ce9433296082fb3de2f6e72()
        {
          this.Initialize("SanitizeResponses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).SanitizeResponses();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_7047529abdbf469d8cad9baef917a129 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7047529abdbf469d8cad9baef917a129()
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

      private sealed class MTHD_76ac07aeb30d466bb3f4ba87d1f86d35 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_76ac07aeb30d466bb3f4ba87d1f86d35()
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

      private sealed class MTHD_75be244d9ffe4902829f1d2f52da286d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_75be244d9ffe4902829f1d2f52da286d()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).ToString();
        }
      }

      private sealed class MTHD_3402bec9ba4d45d7aebf3649a5192adb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3402bec9ba4d45d7aebf3649a5192adb()
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

      private sealed class MTHD_bc28f34dfa5a4a5da685f2f7651746c0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bc28f34dfa5a4a5da685f2f7651746c0()
        {
          this.Initialize("sendToServer", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).sendToServer();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_9b753682c657439f8d36c1ae82e9a8e2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9b753682c657439f8d36c1ae82e9a8e2()
        {
          this.Initialize("closePoll", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          MyPoll.closePoll();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_b7af128b7abd47fab14aac67e9e54b48 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b7af128b7abd47fab14aac67e9e54b48()
        {
          this.Initialize("test", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).test();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_bb3c559d37bb4b118cc5489341bc5b34 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bb3c559d37bb4b118cc5489341bc5b34()
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

      private sealed class MTHD_448fd772d1894d589c8a4559d910236b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_448fd772d1894d589c8a4559d910236b()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_3fdda6ad9f824db39796b4483d39c354 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3fdda6ad9f824db39796b4483d39c354()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_d46f029637d94db0a0970dfea5b10eca : HardwiredMemberDescriptor
      {
        internal FLDV_d46f029637d94db0a0970dfea5b10eca()
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

      private sealed class FLDV_f2cb864f59ea4184b2d62d5e7e66cbcd : HardwiredMemberDescriptor
      {
        internal FLDV_f2cb864f59ea4184b2d62d5e7e66cbcd()
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

      private sealed class FLDV_6497e346808744a8863f189ae495317c : HardwiredMemberDescriptor
      {
        internal FLDV_6497e346808744a8863f189ae495317c()
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

      private sealed class FLDV_b5650a31eebc432db62355d08e72e2d0 : HardwiredMemberDescriptor
      {
        internal FLDV_b5650a31eebc432db62355d08e72e2d0()
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

      private sealed class FLDV_722264a915d2405d9e67e033409b46a5 : HardwiredMemberDescriptor
      {
        internal FLDV_722264a915d2405d9e67e033409b46a5()
          : base(typeof (byte), "MsgRetrieve", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 1;
        }
      }

      private sealed class FLDV_f4ab791602d94e029b3a6eceafcf2efb : HardwiredMemberDescriptor
      {
        internal FLDV_f4ab791602d94e029b3a6eceafcf2efb()
          : base(typeof (byte), "MsgSubmit", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 2;
        }
      }

      private sealed class FLDV_b91ae2bf4f37411d9a8a6abc96dba626 : HardwiredMemberDescriptor
      {
        internal FLDV_b91ae2bf4f37411d9a8a6abc96dba626()
          : base(typeof (byte), "MsgCreate", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 3;
        }
      }

      private sealed class FLDV_4eb7821e9a5d47eebaa6784dd849ab96 : HardwiredMemberDescriptor
      {
        internal FLDV_4eb7821e9a5d47eebaa6784dd849ab96()
          : base(typeof (byte), "MsgResults", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 4;
        }
      }

      private sealed class DVAL_5f31396ea5d5449e80ab9acf59891d16 : DynValueMemberDescriptor
      {
        internal DVAL_5f31396ea5d5449e80ab9acf59891d16()
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

      private sealed class DVAL_ca4b30c7ea154f78b94f25f09bc28a35 : DynValueMemberDescriptor
      {
        internal DVAL_ca4b30c7ea154f78b94f25f09bc28a35()
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

    private sealed class TYPE_a204abffaf3244e98236b98d30e7426d : HardwiredUserDataDescriptor
    {
      internal TYPE_a204abffaf3244e98236b98d30e7426d()
        : base(typeof (LuaColor))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a204abffaf3244e98236b98d30e7426d.MTHD_237c2389520e4017a85777ff9c59fe8a()
        }));
        this.AddMember("toHex", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("toHex", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a204abffaf3244e98236b98d30e7426d.MTHD_52adc79a028b4969863124b9d93fb8d9()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a204abffaf3244e98236b98d30e7426d.MTHD_739f9cc1c2f24d30939f72feed54e22a(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a204abffaf3244e98236b98d30e7426d.MTHD_e81bbaaa57544428921f96c008230fcc()
        }));
        this.AddMember("From", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("From", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a204abffaf3244e98236b98d30e7426d.MTHD_5d7d203b67514d5c9667f3302303ad1f(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a204abffaf3244e98236b98d30e7426d.MTHD_decb4bf9874245a7ad13c458c6ed0fda()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a204abffaf3244e98236b98d30e7426d.MTHD_057a5ebe018f43eda8d59c68fc83a62f()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a204abffaf3244e98236b98d30e7426d.MTHD_afae4deffa9f46b4bd88054e2aae9e3c()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a204abffaf3244e98236b98d30e7426d.MTHD_6885d9f0083f432b92722f61b4bcde3b()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a204abffaf3244e98236b98d30e7426d.MTHD_0ee46a56d1a44eab8c64c538903d15cf()
        }));
        this.AddMember("r", (IMemberDescriptor) new Bridge.TYPE_a204abffaf3244e98236b98d30e7426d.FLDV_599911f34e7b4e33a39c787e3e9a9df8());
        this.AddMember("g", (IMemberDescriptor) new Bridge.TYPE_a204abffaf3244e98236b98d30e7426d.FLDV_18b5ea9cf6494c66bf4be0a0de97c1a4());
        this.AddMember("b", (IMemberDescriptor) new Bridge.TYPE_a204abffaf3244e98236b98d30e7426d.FLDV_80f2311e2e944765bc77d0b69339a27a());
        this.AddMember("a", (IMemberDescriptor) new Bridge.TYPE_a204abffaf3244e98236b98d30e7426d.FLDV_e6f22ed26cfa45899fa9afdff1ab048d());
      }

      private sealed class MTHD_237c2389520e4017a85777ff9c59fe8a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_237c2389520e4017a85777ff9c59fe8a()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new LuaColor();
        }
      }

      private sealed class MTHD_52adc79a028b4969863124b9d93fb8d9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_52adc79a028b4969863124b9d93fb8d9()
        {
          this.Initialize("toHex", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((LuaColor) obj).toHex();
        }
      }

      private sealed class MTHD_739f9cc1c2f24d30939f72feed54e22a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_739f9cc1c2f24d30939f72feed54e22a()
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

      private sealed class MTHD_e81bbaaa57544428921f96c008230fcc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e81bbaaa57544428921f96c008230fcc()
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

      private sealed class MTHD_5d7d203b67514d5c9667f3302303ad1f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5d7d203b67514d5c9667f3302303ad1f()
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

      private sealed class MTHD_decb4bf9874245a7ad13c458c6ed0fda : HardwiredMethodMemberDescriptor
      {
        internal MTHD_decb4bf9874245a7ad13c458c6ed0fda()
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

      private sealed class MTHD_057a5ebe018f43eda8d59c68fc83a62f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_057a5ebe018f43eda8d59c68fc83a62f()
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

      private sealed class MTHD_afae4deffa9f46b4bd88054e2aae9e3c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_afae4deffa9f46b4bd88054e2aae9e3c()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_6885d9f0083f432b92722f61b4bcde3b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6885d9f0083f432b92722f61b4bcde3b()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_0ee46a56d1a44eab8c64c538903d15cf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0ee46a56d1a44eab8c64c538903d15cf()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_599911f34e7b4e33a39c787e3e9a9df8 : HardwiredMemberDescriptor
      {
        internal FLDV_599911f34e7b4e33a39c787e3e9a9df8()
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

      private sealed class FLDV_18b5ea9cf6494c66bf4be0a0de97c1a4 : HardwiredMemberDescriptor
      {
        internal FLDV_18b5ea9cf6494c66bf4be0a0de97c1a4()
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

      private sealed class FLDV_80f2311e2e944765bc77d0b69339a27a : HardwiredMemberDescriptor
      {
        internal FLDV_80f2311e2e944765bc77d0b69339a27a()
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

      private sealed class FLDV_e6f22ed26cfa45899fa9afdff1ab048d : HardwiredMemberDescriptor
      {
        internal FLDV_e6f22ed26cfa45899fa9afdff1ab048d()
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
    }

    private sealed class TYPE_a7c4e6eab11e4e18822b1898145c2af7 : HardwiredUserDataDescriptor
    {
      internal TYPE_a7c4e6eab11e4e18822b1898145c2af7()
        : base(typeof (TalkOptions))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a7c4e6eab11e4e18822b1898145c2af7.MTHD_42f98d11032a4833bace634a92782eb5()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a7c4e6eab11e4e18822b1898145c2af7.MTHD_0fc9e82ed6fb4322a2c0c47175748cc8()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a7c4e6eab11e4e18822b1898145c2af7.MTHD_ec7fe0f163ad465b93182ce1196e2205()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a7c4e6eab11e4e18822b1898145c2af7.MTHD_378a9cabd9764f218d65799586190620()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a7c4e6eab11e4e18822b1898145c2af7.MTHD_842206c315174b5daa739b95ef256173()
        }));
      }

      private sealed class MTHD_42f98d11032a4833bace634a92782eb5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_42f98d11032a4833bace634a92782eb5()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new TalkOptions();
        }
      }

      private sealed class MTHD_0fc9e82ed6fb4322a2c0c47175748cc8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0fc9e82ed6fb4322a2c0c47175748cc8()
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

      private sealed class MTHD_ec7fe0f163ad465b93182ce1196e2205 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ec7fe0f163ad465b93182ce1196e2205()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_378a9cabd9764f218d65799586190620 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_378a9cabd9764f218d65799586190620()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_842206c315174b5daa739b95ef256173 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_842206c315174b5daa739b95ef256173()
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
