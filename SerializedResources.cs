
using Junk;
using System;
using System.Collections.Generic;
using UnityEngine;

public class SerializedResources : MonoBehaviour
{
  public List<SerializedResources.MapGroup> mapGroups = new List<SerializedResources.MapGroup>();
  public List<Texture2D> NotDestroyed = new List<Texture2D>();
  public List<Junk.Resources> resourceObjects = new List<Junk.Resources>();
  public Texture2D brdige;
  public Texture2D developer;
  public Texture2D developer2;
  public List<PerlinHelper> perlinObjects;

  public static SerializedResources Instance { get; private set; }

  public void LoadResources(MapEnum map)
  {
  }

  private void Awake()
  {
    this.Init();
  }

  public void Init()
  {
    if (this.resourceObjects.Count > 0)
      this.resourceObjects.Clear();
    SerializedResources.Instance = this;
    Junk.Resources.SetBridge(this.brdige);
    Junk.Resources.SetDeveloper(this.developer);
    Junk.Resources.SetDeveloper2(this.developer2);
    foreach (SerializedResources.MapGroup mapGroup in this.mapGroups)
      this.resourceObjects.Add(new Junk.Resources(mapGroup));
  }

  private void OnDestroy()
  {
    if (!((UnityEngine.Object) SerializedResources.Instance == (UnityEngine.Object) this))
      return;
    SerializedResources.Instance = (SerializedResources) null;
  }

  public void DisposeResources()
  {
  }

  [Serializable]
  public class MapGroup
  {
    public List<SerializedResources.Resource> resources = new List<SerializedResources.Resource>();
    public Texture2D bgTexture;
    public Texture2D grass;
    public Texture2D underbelly;
  }

  [Serializable]
  public class Resource
  {
    public bool level = true;
    public bool front = true;
    public Texture2D texture;
    public int offX;
    public int offY;
    public bool rotate;
    public bool flatten;
  }
}
