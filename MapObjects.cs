
using UnityEngine;

public class MapObjects : MonoBehaviour
{
  [Header("Waves")]
  public SpriteRenderer[] waves;
  [Header("Dashes")]
  public Transform TopDash;
  public Transform LeftDash;
  public Transform RightDash;
  public Transform LeftCorner;
  public Transform RightCorner;
  public SpriteRenderer water;
  private Camera _camera;

  public static MapObjects Instance { get; private set; }

  private void Awake()
  {
    this._camera = Camera.main;
    if ((Object) MapObjects.Instance != (Object) null)
      Debug.LogError((object) "Duplicate MapObjects.cs");
    MapObjects.Instance = this;
  }

  private void OnDestroy()
  {
    if ((Object) MapObjects.Instance != (Object) this)
      Debug.LogError((object) "MapObjects.cs Instance is corrupted");
    else
      MapObjects.Instance = (MapObjects) null;
  }

  public void ColorWaves()
  {
    switch (Client._gameFacts.GetMapMode())
    {
      case MapEnum.Snowy_Hills:
        this.Adjust(0.0f, 0.0f, 0.2f);
        break;
      case MapEnum.Ocean_Floor:
        this.Adjust(0.08611111f, 0.0f, 0.06f);
        break;
      case MapEnum.Dark_Fortress:
        this.Adjust(0.4944444f, 0.0f, -0.2f);
        break;
      case MapEnum.Wasteland:
        foreach (SpriteRenderer wave in this.waves)
        {
          Color color = wave.color;
          color.r *= 0.5f;
          color.b *= 0.5f;
          color.g *= 0.5f;
          wave.color = color;
        }
        Color color1 = this.water.color;
        color1.r *= 0.5f;
        color1.b *= 0.5f;
        color1.g *= 0.5f;
        this.water.color = color1;
        break;
      case MapEnum.Murky_Swamp:
        this.Adjust(-0.05f, 0.0f, -0.13f);
        break;
      case MapEnum.Graveyard:
        this.Adjust(0.0f, -0.6f, -0.3f);
        break;
      case MapEnum.Alien_World:
        this.Adjust(-0.1694444f, 0.0f, -0.13f);
        break;
      case MapEnum.Ghostly_Halls:
        this.Adjust(0.2f, -0.68f, 0.16f);
        break;
      case MapEnum.Space_Nexus:
        this.Adjust(0.3083333f, 0.0f, -0.2f);
        break;
    }
  }

  private void Adjust(float h, float s, float v)
  {
    foreach (SpriteRenderer wave in this.waves)
      wave.color = ColorHSV.AdjustColor(wave.color, h, s, v);
    this.water.color = ColorHSV.AdjustColor(this.water.color, h, s, v);
  }

  public void SetWaves()
  {
    int num = Client.game.map.Width + 2164;
    foreach (SpriteRenderer wave in this.waves)
      wave.size = new Vector2((float) num, wave.size.y);
    this.water.size = new Vector2((float) num, 860f);
  }

  public void SetDashes()
  {
    this.TopDash.position = new Vector3((float) Client.map.Width * 0.5f, (float) (Client.map.Height + 7), 0.0f);
    this.TopDash.GetComponent<SpriteRenderer>().size = new Vector2((float) Client.map.Width, 14f);
    this.LeftDash.position = new Vector3(-7f, (float) Client.map.Height * 0.5f, 0.0f);
    this.LeftDash.GetComponent<SpriteRenderer>().size = new Vector2((float) Client.map.Height, 14f);
    this.RightDash.position = new Vector3((float) (Client.map.Width + 7), (float) Client.map.Height * 0.5f, 0.0f);
    this.RightDash.GetComponent<SpriteRenderer>().size = new Vector2((float) Client.map.Height, 14f);
    this.LeftCorner.position = new Vector3(-7f, (float) (Client.map.Height + 7), 0.0f);
    this.RightCorner.position = new Vector3((float) (Client.map.Width + 7), (float) (Client.map.Height + 7), 0.0f);
  }
}
