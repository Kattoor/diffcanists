
using System;

#nullable disable
public static class BuildConstants
{
  public static readonly DateTime buildDate = new DateTime(638819831693792948L);
  public const string version = "1.0.0.11";
  public const BuildConstants.ReleaseType releaseType = BuildConstants.ReleaseType.NewReleaseType;
  public const BuildConstants.Platform platform = BuildConstants.Platform.PC;
  public const BuildConstants.Architecture architecture = BuildConstants.Architecture.Windows_x64;
  public const BuildConstants.Distribution distribution = BuildConstants.Distribution.None;

  public enum ReleaseType
  {
    None,
    NewReleaseType,
  }

  public enum Platform
  {
    None,
    Linux,
    macOS,
    Android,
    PC,
  }

  public enum Architecture
  {
    None,
    Linux_x64,
    macOS,
    Android,
    Windows_x64,
  }

  public enum Distribution
  {
    None,
  }
}
