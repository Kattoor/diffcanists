
using System;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ElementalSelection : MonoBehaviour
{
  public GameObject pfab;
  public TMP_Text infoTxt;
  private Action<BookOf> action;

  public static ElementalSelection Instance { get; private set; }

  private void Awake()
  {
    ElementalSelection.Instance = this;
  }

  private void OnDestroy()
  {
    if (!((UnityEngine.Object) ElementalSelection.Instance == (UnityEngine.Object) this))
      return;
    ElementalSelection.Instance = (ElementalSelection) null;
  }

  public static void Create(
    RectTransform r,
    SpellsOnly sp,
    Action<BookOf> a,
    bool allowNone = true,
    params BookOf[] excluded)
  {
    if ((UnityEngine.Object) ElementalSelection.Instance != (UnityEngine.Object) null)
      UnityEngine.Object.Destroy((UnityEngine.Object) ElementalSelection.Instance.gameObject);
    ElementalSelection elementalSelection = UnityEngine.Object.Instantiate<ElementalSelection>(ClientResources.Instance.elementalSelection, (Transform) r);
    elementalSelection.action = a;
    elementalSelection.Setup(allowNone, sp, excluded);
  }

  private void Setup(bool allowNone, SpellsOnly sp, BookOf[] excluded)
  {
    if (excluded != null && excluded.Length != 0)
      this.infoTxt.text = "After prestiging you will have: Arcane, Fire Levels 1 & 2, Cogs, and the book of your choosing\n\nPick one";
    BookOf[] values = (BookOf[]) Enum.GetValues(typeof (BookOf));
    int num1 = 0;
    if (!allowNone)
      num1 = 1;
    float num2 = 0.0f;
    float num3 = 300f;
    if (excluded != null && excluded.Length != 0)
      num1 += excluded.Length;
    foreach (BookOf b in values)
    {
      if ((b != BookOf.Nothing || allowNone) && (excluded == null || !((IEnumerable<BookOf>) excluded).Contains<BookOf>(b)))
      {
        GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.pfab, this.transform);
        RectTransform transform = (RectTransform) gameObject.transform;
        int z = (int) b;
        float f = (float) (360.0 / (double) (values.Length - num1) * (double) num2 * (Math.PI / 180.0));
        Vector2 vector2 = new Vector2(Mathf.Sin(f) * num3, (float) ((double) Mathf.Cos(f) * (double) num3 - 100.0));
        transform.anchoredPosition = vector2;
        if (excluded != null && excluded.Length != 0)
        {
          gameObject.transform.GetChild(1).gameObject.SetActive(false);
          gameObject.GetComponent<UIOnHover>().onClick.AddListener((UnityAction) (() => this.OnSelect(z)));
        }
        else if (!Client.viewSpellLocks.ViewLocked() || Prestige.CanUseElemental(Client.MyAccount, z))
        {
          if (Client.viewSpellLocks.ViewRestricted())
          {
            Restrictions restrictions = Server._restrictions;
            if ((restrictions != null ? (restrictions.CheckElemental(sp, z) ? 1 : 0) : 0) != 0)
            {
              gameObject.transform.GetChild(1).gameObject.SetActive(true);
              gameObject.transform.GetChild(1).GetComponent<Image>().sprite = ClientResources.Instance.imgRestricted;
            }
          }
          gameObject.GetComponent<UIOnHover>().onClick.AddListener((UnityAction) (() => this.OnSelect(z)));
        }
        else
        {
          if (Client.viewSpellLocks.ViewRestricted())
          {
            Restrictions restrictions = Server._restrictions;
            if ((restrictions != null ? (restrictions.CheckElemental(sp, z) ? 1 : 0) : 0) != 0)
            {
              gameObject.transform.GetChild(1).gameObject.SetActive(true);
              gameObject.transform.GetChild(1).GetComponent<Image>().sprite = ClientResources.Instance.imgRestricted;
              goto label_19;
            }
          }
          gameObject.transform.GetChild(1).gameObject.SetActive(true);
        }
label_19:
        gameObject.GetComponent<Image>().sprite = !sp.UsingAltBook(b) ? ClientResources.Instance.spellBookIcons[(int) (b + 1)] : ClientResources.Instance.altSpellBookIcons[(int) (b + 1)];
        if ((excluded == null || excluded.Length == 0) && Restrictions.IsElementalRestricted(sp, z, (Restrictions) null))
          gameObject.transform.GetChild(0).gameObject.SetActive(true);
        gameObject.SetActive(true);
        ++num2;
      }
    }
    if (!allowNone)
      return;
    this.infoTxt.text += " - Defaults to Arcane.\nSelecting \"None\" will mean that if you change to this spellbook in the lobby you will not change the current element from the one you already had selected.";
  }

  private void OnSelect(int i)
  {
    Action<BookOf> action = this.action;
    if (action != null)
      action((BookOf) i);
    UnityEngine.Object.Destroy((UnityEngine.Object) this.gameObject);
  }
}
