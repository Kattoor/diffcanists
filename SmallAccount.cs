
using Hazel;

public class SmallAccount
{
  public string name = "";
  public string clan = "";
  public string oldName = "";
  public short Rating;
  public short Rating1;
  public short Rating2;
  public AccountType accountType;
  public byte experience;
  public ulong discord;
  public int displayedIcon;
  public byte displayClanPrefix;
  public Clan.Roles clanRole;
  public Location location;
  public byte prestige;
  public int server;

  public void Serialize(myBinaryWriter w)
  {
    w.Write(this.name);
    w.Write(this.Rating);
    w.Write(this.Rating1);
    w.Write(this.Rating2);
    w.Write((int) this.accountType);
    w.Write(this.experience);
    w.Write(this.discord);
    w.Write(this.displayedIcon);
    w.Write(this.displayClanPrefix);
    w.Write(this.clan);
    w.Write((byte) this.clanRole);
    w.Write(this.location.Online() ? (byte) 1 : (byte) 0);
    w.Write(this.prestige);
    w.Write(this.oldName);
    w.Write(this.server);
  }

  public void Deserialize(myBinaryReader r)
  {
    this.name = r.ReadString();
    this.Rating = r.ReadInt16();
    this.Rating1 = r.ReadInt16();
    this.Rating2 = r.ReadInt16();
    this.accountType = (AccountType) r.ReadInt32();
    this.experience = r.ReadByte();
    this.discord = r.ReadUInt64();
    this.displayedIcon = r.ReadInt32();
    this.displayClanPrefix = r.ReadByte();
    this.clan = r.ReadString();
    this.clanRole = (Clan.Roles) r.ReadByte();
    this.location = r.ReadByte() == (byte) 1 ? Location.Ingame : Location.Disconnecting;
    this.prestige = r.ReadByte();
    this.oldName = r.ReadString();
    this.server = r.ReadInt32();
  }
}
