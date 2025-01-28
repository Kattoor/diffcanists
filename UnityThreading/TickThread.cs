
using System;
using System.Collections;
using System.Threading;

namespace UnityThreading
{
  public sealed class TickThread : ThreadBase
  {
    private ManualResetEvent tickEvent = new ManualResetEvent(false);
    private Action action;
    private int tickLengthInMilliseconds;

    public TickThread(Action action, int tickLengthInMilliseconds)
      : this(action, tickLengthInMilliseconds, true)
    {
    }

    public TickThread(Action action, int tickLengthInMilliseconds, bool autoStartThread)
      : base(nameof (TickThread), Dispatcher.CurrentNoThrow, false)
    {
      this.tickLengthInMilliseconds = tickLengthInMilliseconds;
      this.action = action;
      if (!autoStartThread)
        return;
      this.Start();
    }

    protected override IEnumerator Do()
    {
      while (!this.exitEvent.InterWaitOne(0))
      {
        this.action();
        if (WaitHandle.WaitAny(new WaitHandle[2]
        {
          (WaitHandle) this.exitEvent,
          (WaitHandle) this.tickEvent
        }, this.tickLengthInMilliseconds) == 0)
          return (IEnumerator) null;
      }
      return (IEnumerator) null;
    }
  }
}
