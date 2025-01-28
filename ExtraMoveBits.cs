
public static class ExtraMoveBits
{
  public static byte Compress(
    bool sprinting,
    bool noGlide,
    bool noIceJump,
    bool highJump,
    bool longJump)
  {
    return (byte) ((sprinting ? 1 : 0) | (noGlide ? 2 : 0) | (noIceJump ? 4 : 0) | (highJump ? 8 : 0) | (longJump ? 16 : 0));
  }

  public static bool IsSprinting(int b)
  {
    return false;
  }

  public static bool NoGlide(int b)
  {
    return (uint) (b & 2) > 0U;
  }

  public static bool NoIceJump(int b)
  {
    return (uint) (b & 4) > 0U;
  }

  public static bool HighJump(int b)
  {
    return (uint) (b & 8) > 0U;
  }

  public static bool LongJump(int b)
  {
    return (uint) (b & 16) > 0U;
  }
}
