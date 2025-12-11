
public static class CombineBytes
{
  public static int To(byte a, byte b)
  {
    return (int) a | (int) b << 8;
  }

  public static byte Low(int a)
  {
    return (byte) a;
  }

  public static byte High(int b)
  {
    return (byte) (b >> 8);
  }
}
