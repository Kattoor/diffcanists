
using System;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineInstance
{
  private ushort _expansions = 1;
  private IEnumerator<float>[] SlowUpdateProcesses = new IEnumerator<float>[64];
  public int NumberOfSlowUpdateCoroutines;
  private bool _isRunningSpell;
  public bool forceArmageddon;
  private bool _runningSlowUpdate;
  private int _nextSlowUpdateProcessSlot;
  private int _tempNumber;
  private const int ProcessArrayChunkSize = 64;
  private const int InitialBufferSizeLarge = 256;
  private const int InitialBufferSizeMedium = 64;
  private const int InitialBufferSizeSmall = 8;

  public bool isRunningSpell
  {
    get
    {
      return this._isRunningSpell;
    }
    set
    {
      if (value != this._isRunningSpell)
      {
        this._isRunningSpell = value;
        HUD.instance?.ToggleWaitingText();
      }
      else
        this._isRunningSpell = value;
    }
  }

  public bool Busy()
  {
    return this.NumberOfSlowUpdateCoroutines > 0;
  }

  public void ServerUpdate()
  {
    this._tempNumber = this._nextSlowUpdateProcessSlot;
    int index1;
    for (int index2 = index1 = 0; index2 < this._nextSlowUpdateProcessSlot; ++index2)
    {
      if (this.SlowUpdateProcesses[index2] != null)
      {
        if (index2 < this._tempNumber)
        {
          try
          {
            if (!this.SlowUpdateProcesses[index2].MoveNext())
              this.SlowUpdateProcesses[index2] = (IEnumerator<float>) null;
            else if (this.SlowUpdateProcesses[index2] != null)
            {
              if (float.IsNaN(this.SlowUpdateProcesses[index2].Current))
                this.SlowUpdateProcesses[index2] = (IEnumerator<float>) null;
            }
          }
          catch (Exception ex)
          {
            Debug.LogError((object) ex);
            this.SlowUpdateProcesses[index2] = (IEnumerator<float>) null;
          }
        }
        if (index2 != index1)
          this.SlowUpdateProcesses[index1] = this.SlowUpdateProcesses[index2];
        ++index1;
      }
    }
    for (int index2 = index1; index2 < this._nextSlowUpdateProcessSlot; ++index2)
      this.SlowUpdateProcesses[index2] = (IEnumerator<float>) null;
    this.NumberOfSlowUpdateCoroutines = this._nextSlowUpdateProcessSlot = index1;
    if (this.isRunningSpell && this.NumberOfSlowUpdateCoroutines == 0)
      this.isRunningSpell = false;
    if (!this.forceArmageddon || this.NumberOfSlowUpdateCoroutines != 0)
      return;
    this.forceArmageddon = false;
  }

  public void CopyOver(CoroutineInstance b, bool immediate = true)
  {
    for (int index = 0; index < b.NumberOfSlowUpdateCoroutines; ++index)
    {
      this.RunSpell(b.SlowUpdateProcesses[index], immediate);
      b.SlowUpdateProcesses[index] = (IEnumerator<float>) null;
    }
    b.NumberOfSlowUpdateCoroutines = 0;
    b._nextSlowUpdateProcessSlot = 0;
  }

  public IEnumerator<float> RunCoroutine(IEnumerator<float> coroutine, bool immediate = true)
  {
    if (coroutine == null)
      return (IEnumerator<float>) null;
    if (immediate)
    {
      ++this.NumberOfSlowUpdateCoroutines;
      if (!coroutine.MoveNext() || float.IsNaN(coroutine.Current))
        return (IEnumerator<float>) null;
    }
    if (this._nextSlowUpdateProcessSlot >= this.SlowUpdateProcesses.Length)
    {
      IEnumerator<float>[] slowUpdateProcesses = this.SlowUpdateProcesses;
      this.SlowUpdateProcesses = new IEnumerator<float>[this.SlowUpdateProcesses.Length + 64 * (int) this._expansions++];
      for (int index = 0; index < slowUpdateProcesses.Length; ++index)
        this.SlowUpdateProcesses[index] = slowUpdateProcesses[index];
    }
    int index1 = this._nextSlowUpdateProcessSlot++;
    this.NumberOfSlowUpdateCoroutines = this._nextSlowUpdateProcessSlot;
    this.SlowUpdateProcesses[index1] = coroutine;
    return coroutine;
  }

  public IEnumerator<float> RunSpell(IEnumerator<float> coroutine, bool immediate = true)
  {
    if (coroutine == null)
      return (IEnumerator<float>) null;
    this.isRunningSpell = true;
    if (immediate)
    {
      ++this.NumberOfSlowUpdateCoroutines;
      if (!coroutine.MoveNext() || float.IsNaN(coroutine.Current))
        return (IEnumerator<float>) null;
    }
    if (this._nextSlowUpdateProcessSlot >= this.SlowUpdateProcesses.Length)
    {
      IEnumerator<float>[] slowUpdateProcesses = this.SlowUpdateProcesses;
      this.SlowUpdateProcesses = new IEnumerator<float>[this.SlowUpdateProcesses.Length + 64 * (int) this._expansions++];
      for (int index = 0; index < slowUpdateProcesses.Length; ++index)
        this.SlowUpdateProcesses[index] = slowUpdateProcesses[index];
    }
    int index1 = this._nextSlowUpdateProcessSlot++;
    this.NumberOfSlowUpdateCoroutines = this._nextSlowUpdateProcessSlot;
    this.SlowUpdateProcesses[index1] = coroutine;
    return coroutine;
  }

  private void CoindexKill(int coindex)
  {
    this.SlowUpdateProcesses[coindex] = (IEnumerator<float>) null;
  }

  private bool CoindexMatches(int coindex, IEnumerator<float> handle)
  {
    return this.SlowUpdateProcesses[coindex] == handle;
  }

  public void KillAllCoroutines()
  {
    this.SlowUpdateProcesses = new IEnumerator<float>[64];
    this.NumberOfSlowUpdateCoroutines = 0;
    this._nextSlowUpdateProcessSlot = 0;
    this._expansions = (ushort) 1;
  }

  public int KillCoroutines(IEnumerator<float> coroutine)
  {
    int num = 0;
    for (int index = 0; index < this._nextSlowUpdateProcessSlot; ++index)
    {
      if (this.SlowUpdateProcesses[index] == coroutine)
      {
        this.SlowUpdateProcesses[index] = (IEnumerator<float>) null;
        ++num;
      }
    }
    return num;
  }
}
