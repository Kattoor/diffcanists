
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

public class MyLog
{
  private ReaderWriterLockSlim _readWriteLock = new ReaderWriterLockSlim();
  private string openFile = "";
  private FileStream stream;
  private StreamWriter writer;
  private StreamReader reader;
  private static MyLog _inst;

  private static MyLog instance
  {
    get
    {
      if (MyLog._inst == null)
        MyLog._inst = new MyLog();
      return MyLog._inst;
    }
  }

  private MyLog()
  {
    this.OpenSteam("MyLog.txt");
  }

  public MyLog(string s)
  {
    this.OpenSteam(s);
  }

  ~MyLog()
  {
    this.Dispose();
  }

  private void OpenSteam(string file)
  {
    this.openFile = file;
    this.stream = new FileStream(file, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
    this.writer = new StreamWriter((Stream) this.stream);
    this.reader = new StreamReader((Stream) this.stream);
  }

  public void Dispose()
  {
    this.stream.Flush();
    this.writer.Dispose();
    this.reader.Dispose();
    this.stream.Close();
    this.stream.Dispose();
  }

  public void Log(string s)
  {
    s = Server.GetTime() + s;
    this._readWriteLock.EnterWriteLock();
    try
    {
      this.writer.WriteLine(s);
      this.writer.Flush();
    }
    finally
    {
      this._readWriteLock.ExitWriteLock();
    }
  }

  public void LogNoTime(string s)
  {
    this._readWriteLock.EnterWriteLock();
    try
    {
      this.writer.WriteLine(s);
      this.writer.Flush();
    }
    finally
    {
      this._readWriteLock.ExitWriteLock();
    }
  }

  public static string GetAllText()
  {
    return MyLog.instance._GetAllText();
  }

  internal string _GetAllText()
  {
    this._readWriteLock.EnterWriteLock();
    string str = "";
    try
    {
      long position = this.writer.BaseStream.Position;
      this.reader.BaseStream.Position = 0L;
      str = this.reader.ReadToEnd();
      this.writer.BaseStream.Position = position;
    }
    finally
    {
      this._readWriteLock.ExitWriteLock();
    }
    return str;
  }

  public static void MainLog(string s)
  {
    MyLog.instance.Log(s);
    Server.Instance?.communicator?.SendMsg(s);
  }

  public static void MainClear()
  {
    MyLog.instance.Clear();
  }

  public void Clear()
  {
    using (FileStream fileStream = new FileStream(this.openFile + ".bak", FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite))
    {
      using (StreamWriter streamWriter = new StreamWriter((Stream) fileStream))
      {
        fileStream.Seek(0L, SeekOrigin.End);
        streamWriter.WriteLine("[Date of Bak] " + DateTime.Now.ToShortDateString());
        streamWriter.Write(this._GetAllText());
      }
    }
    this.Dispose();
    this.OpenSteam(this.openFile);
  }

  public void Clear(string[] newData)
  {
    this.Dispose();
    this.OpenSteam(this.openFile);
    this._readWriteLock.EnterWriteLock();
    try
    {
      foreach (string str in newData)
        this.writer.WriteLine(str);
      this.writer.Flush();
    }
    finally
    {
      this._readWriteLock.ExitWriteLock();
    }
  }

  public void Clear(List<string> newData)
  {
    this.Dispose();
    this.OpenSteam(this.openFile);
    this._readWriteLock.EnterWriteLock();
    try
    {
      foreach (string str in newData)
        this.writer.WriteLine(str);
      this.writer.Flush();
    }
    finally
    {
      this._readWriteLock.ExitWriteLock();
    }
  }
}
