
#nullable disable
public interface MySerializeable
{
  void Serialize(myBinaryWriter w);

  void Deserialize(myBinaryReader r);
}
