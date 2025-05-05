
#nullable disable
public struct HsvColor(double h, double s, double v)
{
  public double H = h;
  public double S = s;
  public double V = v;

  public float normalizedH
  {
    get => (float) this.H / 360f;
    set => this.H = (double) value * 360.0;
  }

  public float normalizedS
  {
    get => (float) this.S;
    set => this.S = (double) value;
  }

  public float normalizedV
  {
    get => (float) this.V;
    set => this.V = (double) value;
  }

  public override string ToString()
  {
    return "{" + this.H.ToString("f2") + "," + this.S.ToString("f2") + "," + this.V.ToString("f2") + "}";
  }
}
