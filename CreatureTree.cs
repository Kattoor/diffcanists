
using UnityEngine;

public class CreatureTree : Creature
{
  public Texture2D texture;
  public ExplosionCutout cutoutTexture;
  public bool isButterflyJar;
  public bool isStructure;

  public override ZCreature Get()
  {
    return (ZCreature) new ZCreatureTree()
    {
      baseTree = this
    };
  }

  [ContextMenu("Find Pixels Top")]
  private void FindpixelsTop()
  {
    Texture2D texture = this.GetComponent<SpriteRenderer>().sprite.texture;
    Color32[] pixels32 = texture.GetPixels32();
    new Coords[1][0] = new Coords(1, 1);
    string str1 = "Coords[] c = { ";
    int num1 = 0;
    int num2 = texture.width / 2;
    int num3 = texture.height / 2;
    for (int index1 = 0; index1 < texture.width; ++index1)
    {
      for (int index2 = texture.height - 1; index2 > 0; --index2)
      {
        if ((index2 == 0 || pixels32[index1 + index2 * texture.width].a == (byte) 0) && pixels32[index1 + (index2 - 1) * texture.width].a != (byte) 0)
        {
          string[] strArray = new string[6]
          {
            str1,
            "new Coords(",
            null,
            null,
            null,
            null
          };
          int num4 = index1 - num2;
          strArray[2] = num4.ToString();
          strArray[3] = ", ";
          num4 = index2 - num3;
          strArray[4] = num4.ToString();
          strArray[5] = "), ";
          str1 = string.Concat(strArray);
          ++num1;
        }
      }
    }
    string str2 = str1 + " };";
    Debug.Log((object) ("Found: " + num1.ToString()));
    Debug.Log((object) str2);
  }
}
