
public static class CombineShort
{
  public static int To(short a, short b)
  {
    return (int) a | (int) b << 16;
  }

  public static short Low(int a)
  {
    return (short) a;
  }

  public static short High(int b)
  {
    return (short) (b >> 16);
  }
}
