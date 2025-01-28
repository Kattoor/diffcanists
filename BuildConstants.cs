
using System;

public static class BuildConstants
{
  public static readonly DateTime buildDate = new DateTime(638735266448398963L);
  public const string version = "1.0.0.8";
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
