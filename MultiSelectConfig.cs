
using System;
using UnityEngine;

public class MultiSelectConfig : MonoBehaviour
{
  public SpellImageList spells;
  public SettingsPlayer settings;

  public void ClickChangeSpells()
  {
    SpellLobbyChange.Create(this.settings, (Action<SettingsPlayer>) (s =>
    {
      this.settings.CopySpells(s, true);
      this.spells.SetSpells(s);
    }), false, Validation.Default, false, (Action) null, false, (Restrictions) null);
  }

  public void ClickResetSpells()
  {
    this.settings.CopySpells(Client.settingsPlayer, true);
    this.spells.SetSpells(this.settings);
  }

  public void ClickChangeOutfit()
  {
    ChangeOutfitMenu.Create(false, true, this.settings, (Action<SettingsPlayer>) (s =>
    {
      this.settings.CopyOutfit(s);
      this.UpdateOutfit();
    }));
  }

  public void ClickResetOutfit()
  {
    this.settings.CopyOutfit(Client.settingsPlayer);
    this.UpdateOutfit();
  }

  internal void UpdateOutfit()
  {
    this.settings.VerifyOutfit(Client.cosmetics, (Account) null);
    ConfigurePlayer.EquipAll(Client.Name, this.spells.uIPlayerCharacter, this.settings);
  }

  public void ClickElementalIcon()
  {
    ElementalSelection.Create((RectTransform) Controller.Instance.transform, this.settings._spells, (Action<BookOf>) (b =>
    {
      this.settings.fullBook = (byte) (b + 1);
      this.spells.SetSpells(this.settings);
    }), true);
  }
}
