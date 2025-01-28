
using System;

public static class BuildConstants
{
  public static readonly DateTime buildDate = new DateTime(638680085640810784L);
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
    PC,
    Android,
  }

  public enum Architecture
  {
    None,
    Linux_x64,
    macOS,
    Windows_x64,
    Android,
  }

  public enum Distribution
  {
    None,
  }
}
