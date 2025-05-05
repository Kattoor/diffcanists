
#nullable disable
public static class DamageTypeExtensions
{
  public static bool IsSting(this DamageType d)
  {
    return d == DamageType.Sting || d == DamageType.StingUndead;
  }

  public static bool IsDeath(this DamageType d)
  {
    return d == DamageType.Death || d == DamageType.StingUndead;
  }
}
