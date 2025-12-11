
using Hazel;
using System;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UnratedTab : Catalogue
{
  public GameObject[] Advanced_Options;
  public GameObject[] Rated_Options;
  public TextMeshProUGUI txtAutoIncludeSpells;
  internal GameFacts _gameFacts;
  [Header("Groups")]
  public UIOnHover[] groupInvite;
  public UIOnHover[] groupPlayers;
  public UIOnHover[] groupSpectate;
  public UIOnHover[] groupTurnTime;
  public UIOnHover[] groupMapStyle;
  public UIOnHover[] groupArmageddon;
  public UIOnHover[] groupTeams;
  public UIOnHover[] groupPerTeam;
  public UIOnHover[] groupMapGen;
  public UIOnHover[] groupGameStyles;
  [Header("Custom Armageddon")]
  public GameObject panelCustomArmageddon;
  public Image[] _customArmageddonImages;
  public TMP_Text txtPlayerCount;
  public TMP_Text txtArmageddonStart;
  public TMP_Text txtStartHealth;
  public TMP_Text txtElementalLevel;
  public TMP_Text txtCountdown;
  public TMP_Text txtCountdownDelay;
  public TMP_Text txtCustomTime;
  public TMP_Text txtMapSize;
  public TMP_Text txtMapSizeHeight;
  public TMP_Text txtMapSeed;
  public UIOnHover buttonAdvanced;
  public UIOnHover buttonArmageddonTurn;
  public UIOnHover buttonTournament;
  public TMP_Text txtMapButton;
  public Image imgMapDesert;
  public Sprite[] sprDesert;
  public Image zombieMonkey;
  public Sprite spZombieMonkey;
  public Sprite spMonkey;
  public GameObject panelPlayersPerTeam;
  internal bool advanced;

  public static UnratedTab instance { get; private set; }

  public static void Popup(RectTransform p, GameFacts gf)
  {
    UnratedTab unratedTab = UnityEngine.Object.Instantiate<UnratedTab>(Controller.Instance.unratedTab, (Transform) p);
    unratedTab._gameFacts = gf;
    unratedTab.RefreshGameOptions();
    ((RectTransform) unratedTab.transform).anchoredPosition = new Vector2(0.0f, 0.0f);
  }

  private void Awake()
  {
    UnratedTab.instance = this;
  }

  internal void _Start()
  {
    this.RefreshGameOptions();
    foreach (GameObject advancedOption in this.Advanced_Options)
    {
      if ((UnityEngine.Object) advancedOption != (UnityEngine.Object) null)
        advancedOption.SetActive(this.advanced);
    }
    if (!this._gameFacts.GetRatedMode())
      return;
    foreach (GameObject ratedOption in this.Rated_Options)
    {
      if ((UnityEngine.Object) ratedOption != (UnityEngine.Object) null)
        ratedOption.SetActive(false);
    }
  }

  private void OnDestroy()
  {
    if (!((UnityEngine.Object) UnratedTab.instance == (UnityEngine.Object) this))
      return;
    UnratedTab.instance = (UnratedTab) null;
  }

  public void ClickShowRestrictions()
  {
    Restrictions restrictions = this._gameFacts.restrictions;
    UnratedMenu instance = UnratedMenu.instance;
    int num = instance != null ? (instance.IsFirst ? 1 : 0) : 0;
    PopupRestrictions.Create(restrictions, num != 0);
  }

  public void HoverSimiliarRating()
  {
    int num = Mathf.Max(1000, (int) Client.GetAccount(this._gameFacts.players[0], false).similarRating);
    string str1 = num.ToString();
    num = (int) Client.GetAccount(this._gameFacts.players[0], false).similarRating + 500;
    string str2 = num.ToString();
    MyToolTip.Show(str1 + "-" + str2, -1f, false);
  }

  public void ToggleAll(UIOnHover[] group)
  {
    for (int index = 0; index < group.Length; ++index)
    {
      if (group[index].AlwaysOn)
        group[index].AlwaysOn = false;
    }
  }

  public bool IsAdvanced()
  {
    foreach (GameObject advancedOption in this.Advanced_Options)
    {
      if ((UnityEngine.Object) advancedOption != (UnityEngine.Object) null)
      {
        foreach (UIOnHover componentsInChild in advancedOption.GetComponentsInChildren<UIOnHover>())
        {
          if (componentsInChild.AlwaysOn && !componentsInChild.gameObject.CompareTag("Ignore") && componentsInChild.gameObject.activeSelf)
            return true;
        }
      }
    }
    return false;
  }

  public void ClickToggleAdvanced()
  {
    this.ToggleAdvanced(!this.advanced);
  }

  public void ToggleAdvanced(bool v)
  {
    this.advanced = v;
    if ((UnityEngine.Object) this.buttonAdvanced != (UnityEngine.Object) null)
    {
      Global.SetPrefBool("prefadvanced", v);
      this.buttonAdvanced.AlwaysOn = this.advanced;
    }
    foreach (GameObject advancedOption in this.Advanced_Options)
    {
      if ((UnityEngine.Object) advancedOption != (UnityEngine.Object) null && (!this._gameFacts.GetRatedMode() || !((IEnumerable<GameObject>) this.Rated_Options).Contains<GameObject>(advancedOption)))
        advancedOption.SetActive(this.advanced);
    }
  }

  public void RefreshGameOptions()
  {
    if (this._gameFacts == null)
      this._gameFacts = Client._gameFacts;
    this.ToggleAll(this.groupInvite);
    this.ToggleAll(this.groupSpectate);
    this.ToggleAll(this.groupMapStyle);
    this.ToggleAll(this.groupArmageddon);
    this.ToggleAll(this.groupTeams);
    this.ToggleAll(this.groupPerTeam);
    this.ToggleAll(this.groupMapGen);
    this.ToggleAll(this.groupGameStyles);
    switch (this._gameFacts.GetInviteMode())
    {
      case InviteEnum.Invite_Only:
        this.groupInvite[0].AlwaysOn = true;
        break;
      case InviteEnum.Clan:
        this.groupInvite[1].AlwaysOn = true;
        break;
      case InviteEnum.Friends:
        this.groupInvite[2].AlwaysOn = true;
        break;
      case InviteEnum.Similar_Rating:
        this.groupInvite[3].AlwaysOn = true;
        break;
      case InviteEnum.Open:
        this.groupInvite[4].AlwaysOn = true;
        break;
      case InviteEnum.BookClub:
        this.groupInvite[5].AlwaysOn = true;
        break;
    }
    if (this._gameFacts.GetSpectatorMode())
      this.groupSpectate[1].AlwaysOn = true;
    this.imgMapDesert.sprite = this._gameFacts.settings.altGeneration ? this.sprDesert[1] : this.sprDesert[0];
    this.txtMapButton.text = this._gameFacts.settings.altGeneration ? "(alt)" + (this._gameFacts.settings.water != WaterStyle.Default ? "\n (" + this._gameFacts.settings.water.ToString().Replace('_', ' ') + ")" : "") : (this._gameFacts.settings.water != WaterStyle.Default ? "(" + this._gameFacts.settings.water.ToString().Replace('_', ' ') + ")" : "");
    this.txtCustomTime.text = this._gameFacts.customTime.ToString();
    MapEnum mapMode = this._gameFacts.GetMapMode();
    MapEnum armageddon = this._gameFacts.GetArmageddon();
    if (armageddon == ~MapEnum.Dont_Mind)
      this.groupArmageddon[this.groupArmageddon.Length - 1].AlwaysOn = true;
    foreach (MapEnum e in (MapEnum[]) Enum.GetValues(typeof (MapEnum)))
    {
      if (e != MapEnum.Dont_Mind)
      {
        if ((mapMode & e) != ~MapEnum.Dont_Mind)
          this.groupMapStyle[GameFacts.GetMapIndex(e)].AlwaysOn = true;
        if ((armageddon & e) != ~MapEnum.Dont_Mind)
          this.groupArmageddon[GameFacts.GetMapIndex(e)].AlwaysOn = true;
      }
    }
    if (this._gameFacts.GetTeamMode())
    {
      this.groupTeams[1].AlwaysOn = true;
      this.panelPlayersPerTeam.SetActive(!this._gameFacts.GetRatedMode());
    }
    else
    {
      this.groupTeams[0].AlwaysOn = true;
      this.panelPlayersPerTeam.SetActive(false);
    }
    if (this._gameFacts.GetMultiTeamMode())
      this.groupTeams[2].AlwaysOn = true;
    int style = (int) this._gameFacts.GetStyle();
    if (((GameStyle) style).HasStyle(GameStyle.Shuffle_Players))
      this.groupGameStyles[0].AlwaysOn = true;
    if (((GameStyle) style).HasStyle(GameStyle.Random_Spells))
      this.groupGameStyles[1].AlwaysOn = true;
    if (((GameStyle) style).HasStyle(GameStyle.Original_Spells_Only))
      this.groupGameStyles[2].AlwaysOn = true;
    if (((GameStyle) style).HasStyle(GameStyle.No_Movement))
      this.groupGameStyles[3].AlwaysOn = true;
    if (((GameStyle) style).HasStyle(GameStyle.Zero_Shield))
      this.groupGameStyles[4].AlwaysOn = true;
    if (((GameStyle) style).HasStyle(GameStyle.First_Turn_Teleport))
      this.groupGameStyles[5].AlwaysOn = true;
    if (((GameStyle) style).HasStyle(GameStyle.Elementals))
      this.groupGameStyles[6].AlwaysOn = true;
    if (((GameStyle) style).HasStyle(GameStyle.Bid))
      this.groupGameStyles[7].AlwaysOn = true;
    if (((GameStyle) style).HasStyle(GameStyle.Sandbox))
      this.groupGameStyles[8].AlwaysOn = true;
    if (((GameStyle) style).HasStyle(GameStyle.Arcane_Monster))
      this.groupGameStyles[9].AlwaysOn = true;
    if (((GameStyle) style).HasStyle(GameStyle.Watchtower))
      this.groupGameStyles[10].AlwaysOn = true;
    if (((GameStyle) style).HasStyle(GameStyle.Dynamic))
      this.groupGameStyles[11].AlwaysOn = true;
    this.groupGameStyles[7].gameObject.SetActive(false);
    this.groupGameStyles[8].gameObject.SetActive(!this._gameFacts.GetRatedMode());
    if (this._gameFacts.GetPlayersPerTeam() == PlayersPerTeam.Half)
      this.groupPerTeam[7].AlwaysOn = true;
    else
      this.groupPerTeam[Mathf.Clamp(this._gameFacts.GetNumberPlayersPerTeam() - 2, 0, 7)].AlwaysOn = true;
    this.buttonTournament.AlwaysOn = this._gameFacts.GetTournamentMode();
    this.buttonTournament.gameObject.SetActive(Client.MyAccount.accountType.IsModPlusTOParticipate() && !this._gameFacts.GetRatedMode() || this.buttonTournament.AlwaysOn);
    this.txtArmageddonStart.text = "Turn\n" + this._gameFacts.armageddonTurn.ToString();
    this.txtStartHealth.text = "Health: " + this._gameFacts.startHealth.ToString();
    this.txtMapSize.text = "Width: " + this._gameFacts.settings.mapWidth.ToString() + "%";
    this.txtMapSizeHeight.text = "Height: " + this._gameFacts.settings.mapHeight.ToString() + "%";
    this.txtMapSeed.text = "Seed: " + (this._gameFacts.settings.fixedMapSeed ? this._gameFacts.settings.mapSeed.ToString() : "Random");
    TMP_Text txtElementalLevel = this.txtElementalLevel;
    byte num = this._gameFacts.elementalLevel;
    string str1 = "Elementals\n" + num.ToString();
    txtElementalLevel.text = str1;
    this.txtCountdown.text = "Countdown: " + (this._gameFacts.countdownTime == (short) 0 ? "<#FF0000>X" : (this._gameFacts.countdownTime < (short) 0 ? "<sprite=23> " + Global.IntToTime((int) this._gameFacts.countdownTime, 10) : Global.IntToTime((int) this._gameFacts.countdownTime, 10)));
    TMP_Text txtCountdownDelay = this.txtCountdownDelay;
    string str2;
    if (this._gameFacts.countdownTime != (short) 0)
    {
      num = this._gameFacts.countdownDelay;
      str2 = num.ToString();
    }
    else
      str2 = "<#FF0000>X";
    string str3 = "Delay: " + str2;
    txtCountdownDelay.text = str3;
    TMP_Text txtPlayerCount = this.txtPlayerCount;
    num = this._gameFacts.customPlayerCount;
    string str4 = num.ToString();
    txtPlayerCount.text = str4;
    this.groupMapGen[0].AlwaysOn = this._gameFacts.settings.mapWidth != (byte) 100;
    this.groupMapGen[1].AlwaysOn = this._gameFacts.settings.mapHeight != (byte) 100;
    this.groupMapGen[2].AlwaysOn = this._gameFacts.settings.fixedMapSeed;
    this.groupPlayers[0].AlwaysOn = true;
    this.groupPlayers[1].AlwaysOn = this._gameFacts.startHealth != (ushort) 250;
    this.groupPlayers[2].AlwaysOn = this._gameFacts.restrictions != null && this._gameFacts.restrictions.AnyRestricted();
    this.buttonArmageddonTurn.AlwaysOn = this._gameFacts.armageddonTurn != (byte) 10;
    this.groupTurnTime[0].AlwaysOn = true;
    this.groupTurnTime[1].AlwaysOn = (uint) this._gameFacts.countdownTime > 0U;
    this.groupTurnTime[2].Interactable((uint) this._gameFacts.countdownTime > 0U);
    this.groupTurnTime[2].AlwaysOn = (uint) this._gameFacts.countdownTime > 0U;
    this.zombieMonkey.sprite = this._gameFacts.GetStyle().HasStyle(GameStyle.Zombie_Monkey) ? this.spZombieMonkey : this.spMonkey;
    if (this._gameFacts.settings.autoInclude != null && this._gameFacts.settings.autoInclude.Count > 0)
    {
      StringBuilderPlus stringBuilderPlus = new StringBuilderPlus();
      foreach (SpellEnum s in this._gameFacts.settings.autoInclude)
      {
        Spell spell = Inert.GetSpell(s);
        if ((UnityEngine.Object) spell != (UnityEngine.Object) null && spell.level <= 3)
          stringBuilderPlus.Append("<link=\"" + spell.name + "\"><sprite name=\"" + spell.name + "\"></link>");
      }
      this.txtAutoIncludeSpells.text = stringBuilderPlus.ToString();
    }
    else
      this.txtAutoIncludeSpells.text = "None";
    if (!this.advanced && this.IsAdvanced() || (UnityEngine.Object) this.buttonAdvanced != (UnityEngine.Object) null && Global.GetPrefBool("prefadvanced", false))
      this.ToggleAdvanced(true);
    if ((UnityEngine.Object) this.buttonAdvanced != (UnityEngine.Object) null)
      this.buttonAdvanced.AlwaysOn = this.advanced;
    List<SpellEnum> customArmageddon = this._gameFacts.settings.customArmageddon;
    if ((customArmageddon != null ? (__nonvirtual (customArmageddon.Count) > 0 ? 1 : 0) : 0) != 0)
    {
      this.panelCustomArmageddon.SetActive(true);
      int index;
      for (index = 0; index < this._gameFacts.settings.customArmageddon.Count && index < this._customArmageddonImages.Length; ++index)
      {
        Spell spell = Inert.GetSpell(this._gameFacts.settings.customArmageddon[index]);
        if ((UnityEngine.Object) spell == (UnityEngine.Object) null || spell.level > 3 && !GameFacts.AllowCustomArmageddon(spell.spellEnum))
        {
          this._gameFacts.settings.customArmageddon.RemoveAt(index);
          --index;
        }
        else
        {
          this._customArmageddonImages[index].sprite = ClientResources.Instance.GetSpellIcon(spell.name);
          this._customArmageddonImages[index].gameObject.SetActive(true);
        }
      }
      for (; index < this._customArmageddonImages.Length; ++index)
        this._customArmageddonImages[index].gameObject.SetActive(false);
    }
    else
      this.panelCustomArmageddon.SetActive(false);
  }

  public void ToolTip(string s)
  {
    MyToolTip.Show(s, -1f, false);
  }

  public void HoverCountdown()
  {
    MyToolTip.Show("Countdown: " + Mathf.Abs((int) this._gameFacts.countdownTime).ToString() + (this._gameFacts.countdownTime > (short) 0 ? " seconds<br>If time runs out you will get 5 second turns from then on." : " seconds<br><#FF0000>If time runs out you lose</color><br>Turn time is still used."), -1f, false);
  }

  public void HideToolTip()
  {
    MyToolTip.Close();
  }
}
