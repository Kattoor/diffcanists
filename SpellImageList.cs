
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class SpellImageList : MonoBehaviour
{
  public Image[] spellSlot;
  public Image[] restricted;
  public Image elemental;
  public Image prestigeIcon;
  public UIPlayerCharacter uIPlayerCharacter;
  private SettingsPlayer _settingsPlayer;

  internal SettingsPlayer settingsPlayer
  {
    get => this._settingsPlayer ?? Client.settingsPlayer;
    set => this._settingsPlayer = value;
  }

  private void Awake()
  {
    this.SetSpells();
    if (!((UnityEngine.Object) this.prestigeIcon != (UnityEngine.Object) null))
      return;
    this.prestigeIcon.sprite = ClientResources.Instance._iconsPrestige[Mathf.Clamp((int) Client.MyAccount.prestige, 0, 10)];
  }

  public void ClickQuickChange() => SpellLobbyChange.Create();

  public void ClickPrestige() => Controller.ShowPrestigeMenu();

  public void UpdateOutfit()
  {
    Client.settingsPlayer.VerifyOutfit(Client.cosmetics);
    ConfigurePlayer.EquipAll(Client.Name, this.uIPlayerCharacter, this.settingsPlayer);
  }

  public void SetSpells()
  {
    this.SetSpells(this.settingsPlayer.spells, this.settingsPlayer.fullBook, this.settingsPlayer._spells);
  }

  public void SetSpells(SettingsPlayer s) => this.SetSpells(s.spells, s.fullBook, s._spells);

  public void SetSpells(byte[] spells, byte fullBook, SpellsOnly sp)
  {
    for (int index = 0; index < 16; ++index)
    {
      if (spells[index] != byte.MaxValue && (int) spells[index] < Inert.Instance._spells.Length)
      {
        this.spellSlot[index].sprite = !sp.IsAlt((int) spells[index]) ? ClientResources.Instance.icons.GetItem((int) spells[index]).Value : ClientResources.Instance.icons[Inert.Instance.altSpells[(int) spells[index]].name];
        this.spellSlot[index].enabled = true;
        this.restricted[index].gameObject.SetActive(Restrictions.IsSpellRestricted(sp, (int) spells[index]));
        int spell = (int) spells[index];
        if (Prestige.IsUnlocked(Client.MyAccount, spell) || !Client.viewSpellLocks.ViewLocked() && ((UnityEngine.Object) UnratedMenu.instance == (UnityEngine.Object) null || Client._gameFacts.GetStyle().HasStyle(GameStyle.Sandbox)))
        {
          if (!Restrictions.IsSpellRestricted(sp, spell))
          {
            if (Client.viewSpellLocks.ViewRestricted())
            {
              Restrictions restrictions = Server._restrictions;
              if ((restrictions != null ? (restrictions.CheckRestricted(this.settingsPlayer._spells, spell) ? 1 : 0) : 0) != 0)
                goto label_6;
            }
            this.restricted[index].gameObject.SetActive(false);
            continue;
          }
label_6:
          this.restricted[index].gameObject.SetActive(true);
          this.restricted[index].color = Color.red;
          this.restricted[index].sprite = ClientResources.Instance.imgRestricted;
        }
        else
        {
          this.restricted[index].sprite = Prestige.CanUnlock(Client.MyAccount, spell) == 0 ? (spell % 12 >= 10 ? ClientResources.Instance.imgBuyable3 : ClientResources.Instance.imgBuyable2) : ClientResources.Instance.imgLocked;
          this.restricted[index].color = Color.white;
          this.restricted[index].gameObject.SetActive(true);
        }
      }
      else
      {
        this.spellSlot[index].enabled = false;
        this.restricted[index].gameObject.SetActive(false);
      }
    }
    if ((int) fullBook >= ClientResources.Instance.spellBookIcons.Length)
      fullBook = (byte) 0;
    this.elemental.sprite = fullBook <= (byte) 0 || !sp.UsingAltBook((BookOf) ((int) fullBook - 1)) ? ClientResources.Instance.spellBookIcons[(int) fullBook] : ClientResources.Instance.altSpellBookIcons[(int) fullBook];
    this.elemental.transform.GetChild(0).gameObject.SetActive(fullBook > (byte) 0 && Restrictions.IsElementalRestricted(sp, (int) fullBook - 1));
  }

  public void ClickElementalIcon()
  {
    ElementalSelection.Create((RectTransform) Controller.Instance.transform, this.settingsPlayer._spells, (Action<BookOf>) (b => Client.AskToChangeElemental((byte) (b + 1))));
  }

  public void ClickSavedSpells()
  {
    if (RatedMenu.FindingOpponents)
      ChatBox.Instance?.NewChatMsg("Cannot change spells while finding opponents", (Color) ColorScheme.GetColor(Global.ColorSystem));
    else
      ChangeSpellBookMenu.Create(false);
  }

  public void ClickSavedOutfits()
  {
    CharacterCreation.Create(Client.settingsPlayer, (Action<SettingsPlayer>) (set => Client.AskToChangeOutfit(set)));
  }

  public void ClickSavedOutfitsSaved() => ChangeOutfitMenu.Create(false);

  public void ToolTip(string s) => MyToolTip.Show(s);

  public void HideToolTip() => MyToolTip.Close();
}
