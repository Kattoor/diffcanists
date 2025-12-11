
using System.Threading;

public static class BidenLog
{
  private static MyLog log;
  private static int count;
  private static int offset;

  public static void Log(string s)
  {
    if (BidenLog.log == null)
    {
      BidenLog.log = new MyLog("biden.txt");
      BidenLog.count = 0;
      BidenLog.offset = 0;
    }
    BidenLog.log.LogNoTime(s + " :" + (object) Thread.CurrentThread.ManagedThreadId);
    ++BidenLog.count;
    if (BidenLog.count <= 100000)
      return;
    ++BidenLog.offset;
    BidenLog.count = 0;
    BidenLog.log.Dispose();
    BidenLog.log = new MyLog("biden" + (object) BidenLog.offset + ".txt");
  }
}
