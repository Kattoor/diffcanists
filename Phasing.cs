
using UnityEngine;

public class Phasing : MonoBehaviour
{
  public ZMyCollider cre;
  public Transform child;
  public SpriteMask sr;

  private void Update()
  {
    if (!((ZComponent) this.cre == (object) null) && this.cre.enabled && this.cre.ghosted)
      return;
    Object.Destroy((Object) this.gameObject);
  }

  public void Init(ZMyCollider c, int x, int y, int r)
  {
    this.cre = c;
    if (c.shape == MyCollider.Shape.Polygon)
    {
      if ((ZComponent) c.tower != (object) null)
      {
        Transform child = c.tower.gameObject.transform.GetChild(0);
        this.transform.position = child.position;
        this.sr.sprite = child.GetComponent<SpriteRenderer>().sprite;
      }
      else
        this.sr.sprite = c.creature.gameObject.transform.GetComponent<SpriteRenderer>().sprite;
      this.transform.localScale = new Vector3(1f, 1f, 1f);
      float num = 1f / 256f * (float) r;
      this.child.localScale = new Vector3(num, num);
    }
    else
    {
      this.transform.localScale = new Vector3((float) (((double) c.radius + 1.0) / 256.0 * 2.0), (float) (((double) c.radius + 1.0) / 256.0 * 2.0), 1f);
      float num = (float) ((double) r / (double) c.radius / 2.0);
      this.child.localScale = new Vector3(num, num);
    }
    this.child.transform.position = new Vector3((float) x, (float) y);
  }
}
