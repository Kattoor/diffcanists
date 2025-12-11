
using MoonSharp.Interpreter;
using System;
using UnityEngine;

namespace Educative
{
  public class ContainerIndicator
  {
    [MoonSharpHidden]
    public GameObject indicator;
    [MoonSharpHidden]
    public IndicatorKind _kind;
    [MoonSharpHidden]
    private double _radius;
    [MoonSharpHidden]
    private Tutorial tutorial;

    [MoonSharpHidden]
    public ContainerIndicator(GameObject s)
    {
      throw new Exception("Notimplemented");
    }

    [MoonSharpHidden]
    public ContainerIndicator(Tutorial t, GameObject s, IndicatorKind k, double radius)
    {
      this.indicator = s;
      this._kind = k;
      this._radius = radius;
      this.tutorial = t;
    }

    public bool isDead
    {
      get
      {
        return (UnityEngine.Object) this.indicator == (UnityEngine.Object) null;
      }
    }

    public int x
    {
      get
      {
        return (int) this.indicator.transform.position.x;
      }
      set
      {
        this.indicator.transform.position = new Vector3((float) value, this.indicator.transform.position.y);
      }
    }

    public int y
    {
      get
      {
        return (int) this.indicator.transform.position.y;
      }
      set
      {
        this.indicator.transform.position = new Vector3(this.indicator.transform.position.x, (float) value);
      }
    }

    public double radius
    {
      get
      {
        return this._radius;
      }
      set
      {
        this._radius = value;
        if (this.kind != IndicatorKind.Area)
          return;
        this.indicator.transform.localScale = new Vector3((float) this._radius / 128f, (float) this._radius / 128f, 1f);
      }
    }

    public Point position
    {
      get
      {
        return new Point((double) (int) this.indicator.transform.position.x, (double) (int) this.indicator.transform.position.y);
      }
      set
      {
        this.indicator.transform.position = new Vector3((float) value.x, (float) value.y);
      }
    }

    public double angle
    {
      get
      {
        return (double) this.indicator.transform.localEulerAngles.z;
      }
      set
      {
        this.indicator.transform.localEulerAngles = new Vector3(0.0f, 0.0f, (float) value);
      }
    }

    public string color
    {
      get
      {
        return ColorUtility.ToHtmlStringRGB(this.indicator.GetComponentInChildren<SpriteRenderer>().color);
      }
      set
      {
        Color color;
        if (!ColorUtility.TryParseHtmlString(value, out color))
          return;
        this.indicator.GetComponentInChildren<SpriteRenderer>().color = color;
      }
    }

    public LuaColor color2
    {
      get
      {
        return LuaColor.From((Color32) this.indicator.GetComponentInChildren<SpriteRenderer>().color);
      }
      set
      {
        this.indicator.GetComponentInChildren<SpriteRenderer>().color = (Color) LuaColor.From(value);
      }
    }

    public IndicatorKind kind
    {
      get
      {
        return this._kind;
      }
    }

    public void setIcon(object spellObj)
    {
      Spell spell = ContainerGame.getSpell(spellObj, (ZCreature) null);
      if (!((UnityEngine.Object) spell != (UnityEngine.Object) null))
        return;
      this.indicator.GetComponentInChildren<SpriteRenderer>().sprite = ClientResources.Instance.GetSpellIcon(spell.name);
    }

    public void Destroy()
    {
      this.tutorial.activeIndicators.Remove(this);
      UnityEngine.Object.Destroy((UnityEngine.Object) this.indicator);
      this.indicator = (GameObject) null;
    }
  }
}
