
public class ServerState
{
  public byte playersTurn = byte.MaxValue;
  public float turnTime;
  public float countdown;
  public ServerState.Busy changeBusy;

  public ServerState.Busy busy
  {
    get
    {
      return this.changeBusy;
    }
    set
    {
      if (this.changeBusy == ServerState.Busy.Ended)
        return;
      this.changeBusy = value;
    }
  }

  public void Serialize(myBinaryWriter w)
  {
    w.Write(this.turnTime);
    w.Write(this.countdown);
    w.Write(this.playersTurn);
    w.Write((byte) this.busy);
  }

  public void DeSerialize(myBinaryReader r)
  {
    this.turnTime = r.ReadSingle();
    this.countdown = r.ReadSingle();
    this.playersTurn = r.ReadByte();
    this.busy = (ServerState.Busy) r.ReadByte();
  }

  public enum Busy : byte
  {
    Not_started,
    No,
    Between_Turns,
    Moving,
    Starting_Turn,
    Ended,
    Waiting_For_Server_Reply,
    Tutorial_Pause,
    Moving_NoCountdown,
  }
}
