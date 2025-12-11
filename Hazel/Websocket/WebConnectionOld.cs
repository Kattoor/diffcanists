
using System;
using System.Net.WebSockets;

namespace Hazel.Websocket
{
  public class WebConnectionOld
  {
    public player_info player = new player_info();
    public string EndPoint = "";
    public int checkMessagesReceived = -1;
    public WebSocket socket;
    public bool Connected;
    public int id;
    public int messagesReceived;

    public event System.Action<WebConnectionOld, byte[]> ReceivedData;

    public WebConnectionOld(WebSocket ws, string e, int id)
    {
      this.socket = ws;
      this.EndPoint = e.Split(':', StringSplitOptions.None)[0];
      this.id = id;
      this.Connected = true;
    }

    public void DataReceived(byte[] b)
    {
      System.Action<WebConnectionOld, byte[]> receivedData = this.ReceivedData;
      if (receivedData == null)
        return;
      receivedData(this, b);
    }

    public WebConnectionOld()
    {
    }

    public string name
    {
      get
      {
        return this.player.account.name;
      }
      set
      {
        this.player.account.name = value;
      }
    }

    public Account account
    {
      get
      {
        return this.player.account;
      }
      set
      {
        this.player.account = value;
      }
    }
  }
}
