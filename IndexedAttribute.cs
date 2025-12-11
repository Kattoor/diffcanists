
using System;

[AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
internal sealed class IndexedAttribute : Attribute
{
  public string IndexName { get; }

  public IndexedAttribute(string indexName = null)
  {
    this.IndexName = indexName;
  }
}
