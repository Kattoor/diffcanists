
using System.Runtime.Serialization;

namespace Educative
{
  public class CustomJsonSerializationBinder : SerializationBinder
  {
    private readonly string _namespaceToTypes;

    public CustomJsonSerializationBinder(string namespaceToTypes)
    {
      this._namespaceToTypes = namespaceToTypes;
    }

    public override void BindToName(
      System.Type serializedType,
      out string assemblyName,
      out string typeName)
    {
      assemblyName = (string) null;
      typeName = serializedType.FullName.Replace(this._namespaceToTypes, string.Empty).Trim('.');
    }

    public override System.Type BindToType(string assemblyName, string typeName)
    {
      return typeName.StartsWith("Educative.") ? System.Type.GetType(typeName) : (System.Type) null;
    }
  }
}
