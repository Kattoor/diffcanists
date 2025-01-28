
using UnityEngine;

public class SelectionArrow : MonoBehaviour
{
  private float cur = 0.5f;
  private bool down = true;
  private Vector3 top = new Vector3(0.0f, 40f, 0.0f);
  private Vector3 bottom = new Vector3(0.0f, -40f, 0.0f);
  private Transform child;
  private ZCreature creature;
  private float delayActive;

  internal static SelectionArrow Instance { get; private set; }

  private void Awake()
  {
    SelectionArrow.Instance = this;
  }

  private void OnDestroy()
  {
    if (!((Object) SelectionArrow.Instance == (Object) this))
      return;
    SelectionArrow.Instance = (SelectionArrow) null;
  }

  private void Start()
  {
    this.child = this.transform.GetChild(0);
    if (!((Object) Player.Instance != (Object) null))
      return;
    this.UpdateColor(Player.Instance.person.clientColor);
  }

  public void UpdateColor(Color c)
  {
    if (!((Object) Player.Instance != (Object) null))
      return;
    this.child.GetComponent<SpriteRenderer>().color = c;
  }

  private void LateUpdate()
  {
    if ((Object) Player.Instance == (Object) null)
      Object.Destroy((Object) this.gameObject);
    else if ((double) this.delayActive > 0.0 && (ZComponent) Player.Instance.selected == (object) this.creature)
    {
      if (hardInput.GetKey("Move Left") || hardInput.GetKey("Move Right") || Player.Instance.selected.isMoving)
        return;
      this.delayActive -= Time.deltaTime;
    }
    else if (!Player.Instance.person.yourTurn || (ZComponent) Player.Instance.selected == (object) null || (Object) Player.Instance.selectedSpell != (Object) null)
    {
      if (!this.child.gameObject.activeSelf)
        return;
      this.cur = 0.5f;
      this.down = true;
      this.child.localPosition = Vector3.zero;
      this.child.gameObject.SetActive(false);
    }
    else if (hardInput.GetKey("Move Left") || hardInput.GetKey("Move Right") || Player.Instance.selected.isMoving)
    {
      this.delayActive = 2f;
      if (!this.child.gameObject.activeSelf)
        return;
      this.cur = 0.5f;
      this.down = true;
      this.child.localPosition = Vector3.zero;
      this.child.gameObject.SetActive(false);
    }
    else if (Player.Instance.person.game.serverState.busy != ServerState.Busy.No || Player.Instance.person.game.ongoing.NumberOfSlowUpdateCoroutines > 0)
    {
      if (!this.child.gameObject.activeSelf)
        return;
      this.cur = 0.5f;
      this.down = true;
      this.child.localPosition = Vector3.zero;
      this.child.gameObject.SetActive(false);
    }
    else
    {
      if (!this.child.gameObject.activeSelf)
        this.child.gameObject.SetActive(true);
      this.delayActive = 0.0f;
      this.creature = Player.Instance.selected;
      this.transform.position = this.creature.transform.position + new Vector3(0.0f, (float) (72 + this.creature.GetRadius()), 0.0f);
      if (this.down)
      {
        this.cur += Time.deltaTime * 1.25f;
        if ((double) this.cur >= 1.0)
        {
          this.cur = 1f;
          this.down = false;
        }
      }
      else
      {
        this.cur -= Time.deltaTime * 1.25f;
        if ((double) this.cur <= 0.0)
        {
          this.cur = 0.0f;
          this.down = true;
        }
      }
      this.child.localPosition = Vector3.Slerp(this.top, this.bottom, this.cur);
    }
  }
}
