
using System;

public static class BuildConstants
{
  public static readonly DateTime buildDate = new DateTime(638376705087331609L);
  public const string version = "1.0.0.4";
  public const BuildConstants.ReleaseType releaseType = BuildConstants.ReleaseType.NewReleaseType;
  public const BuildConstants.Platform platform = BuildConstants.Platform.Android;
  public const BuildConstants.Architecture architecture = BuildConstants.Architecture.Android;
  public const BuildConstants.Distribution distribution = BuildConstants.Distribution.None;

  public enum ReleaseType
  {
    None,
    NewReleaseType,
  }

  public enum Platform
  {
    None,
    Android,
    Linux,
    macOS,
    WebGL,
    PC,
  }

  public enum Architecture
  {
    None,
    Android,
    Linux_x64,
    macOS,
    WebGL,
    Windows_x64,
  }

  public enum Distribution
  {
    None,
  }
}
