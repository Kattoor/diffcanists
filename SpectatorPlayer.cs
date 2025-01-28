
using UnityEngine;
using UnityEngine.UI;

public class SpectatorPlayer : MonoBehaviour
{
  public int selectedSpellIndex = -1;
  private FixedInt rot_z = (FixedInt) 0;
  private GameObject meter;
  internal GameObject[] meter_subs;
  private Image meterFill;
  private bool LockMeter;
  private bool extendedShot;
  private Vector3 mouseWorldPos;
  private Vector3 diff;
  private float offset;
  private bool selectingSpell;
  public Creature selected;

  public static SpectatorPlayer Instance { get; private set; }

  private void Awake()
  {
    SpectatorPlayer.Instance = this;
    this.meter = Object.Instantiate<GameObject>(HUD.instance.specMeter);
    this.meter_subs = new GameObject[this.meter.transform.childCount];
    for (int index = 0; index < this.meter_subs.Length; ++index)
      this.meter_subs[index] = this.meter.transform.GetChild(index).gameObject;
    this.meterFill = this.meter_subs[0].transform.GetChild(1).GetComponent<Image>();
    this.meterFill.fillAmount = 0.0f;
    this.meter.SetActive(false);
    this.LockMeter = false;
    int tomatoes = Client.MyAccount.tomatoes;
    foreach (SpellButton specTomato in HUD.instance.specTomatoes)
      specTomato.SetVisual(specTomato.nameOfSpell, specTomato.nameOfSpell, tomatoes, 0, false);
  }

  private void OnDestroy()
  {
    if (!((Object) SpectatorPlayer.Instance == (Object) this))
      return;
    SpectatorPlayer.Instance = (SpectatorPlayer) null;
  }

  public void UnselectSpell()
  {
    this.selectingSpell = false;
    this.selectedSpellIndex = -1;
    this.ToggleExtendedShot(hardInput.GetKey("Extended Shot"));
    HUD.instance.PressingFire = false;
    HUD.instance.panelFireControls.SetActive(false);
    MyContextMenu.CloseInstance();
    MyToolTip.Close();
  }

  public void SetSpell(int i)
  {
    if (Client.MyAccount.tomatoes <= 0 && !Client.game.isSandbox)
    {
      this.UnselectSpell();
      MyToolTip.Show("You can buy more tomatoes at the shop.", -1f);
    }
    else
    {
      this.selectingSpell = true;
      this.selectedSpellIndex = i;
      for (int index = 0; index < this.meter_subs.Length; ++index)
        this.meter_subs[index].SetActive(true);
      CursorList.Instance.SetCursor(0, CursorMode.Auto);
      HUD.instance.panelFireControls.SetActive(true);
      HUD.instance.panelAimControls.SetActive(false);
    }
  }

  public void ToggleExtendedShot(bool v)
  {
    this.extendedShot = v;
    HUD.instance.buttonAlt.AlwaysOn = v;
    float x = 1f;
    if ((Object) this.meter_subs[0] == (Object) null)
      return;
    if (v)
      x = 1f + Player.LinearExtend(Player.GetPowerLevel(this.rot_z), (FixedInt) 1).ToFloat();
    this.meter_subs[0].transform.localScale = new Vector3(x, 1f, 1f);
  }

  public void UpdateMouseWorldPos(bool force = false)
  {
    if (!force && Player.IsPointerOverGameObject(0) || !force && HUD.UseTouchControls)
      return;
    this.mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    this.mouseWorldPos.z = 0.0f;
  }

  public void MouseUp()
  {
    if (this.selectedSpellIndex == -1)
      return;
    this.SendFire();
  }

  private void SendFire()
  {
    Spectator.AskTomato(this.selectedSpellIndex, this.rot_z.ToFloat(), this.meterFill.fillAmount);
    this.selectedSpellIndex = -1;
  }

  private void Update()
  {
    if (this.selectedSpellIndex > -1)
    {
      if (!this.meter.activeSelf)
        this.meter.SetActive(true);
      if (MyInput.GetMouseButtonDown(1))
        this.UnselectSpell();
      else if (MyInput.GetMouseButtonUp(0) && !this.selectingSpell)
      {
        this.SendFire();
      }
      else
      {
        if (MyInput.GetMouseButton(0) || HUD.instance.PressingFire)
        {
          if (!HUD.UseTouchControls || HUD.instance.PressingFire)
          {
            if ((double) this.meterFill.fillAmount < 1.0)
              this.meterFill.fillAmount += Time.deltaTime * 0.45f;
          }
          else
            this.UpdateMouseWorldPos(true);
        }
        else
        {
          if (this.selectingSpell)
            this.selectingSpell = false;
          if ((double) this.meterFill.fillAmount > 0.0)
            this.meterFill.fillAmount = 0.0f;
        }
        Vector3 zero = Vector3.zero;
        Vector3 position = this.selected.transform.position;
        this.meter.transform.position = position;
        this.UpdateMouseWorldPos(true);
        this.diff = this.mouseWorldPos - position;
        if (HUD.UseTouchControls)
        {
          if (!Player.IsPointerOverGameObject(0) && (MyInput.GetMouseButton(0) || Input.touchCount == 1) && !HUD.instance.PressingOnScreenControl)
            this.rot_z = MyInput.GetMouseButton(0) ? (FixedInt) (Mathf.Atan2(this.diff.y, this.diff.x) * 57.29578f) : this.rot_z;
        }
        else
          this.rot_z = (FixedInt) (Mathf.Atan2(this.diff.y, this.diff.x) * 57.29578f);
        this.offset = 0.0f;
        if (this.extendedShot && this.selectedSpellIndex > -1)
        {
          this.rot_z = Player.ClampAngle(this.rot_z);
          this.ToggleExtendedShot(true);
          this.offset = (float) ((int) Player.GetPowerLevel(this.rot_z) * 4);
        }
        this.meter_subs[0].transform.rotation = Quaternion.Euler(0.0f, 0.0f, this.rot_z.ToFloat());
        this.meter_subs[0].transform.localPosition = (Vector3) Global.VelocityRight(this.rot_z, (FixedInt) (this.selected.radius - 5)).ToSinglePrecision();
      }
    }
    else
    {
      if (!this.meter.activeSelf)
        return;
      this.meter.SetActive(false);
      this.meterFill.fillAmount = 0.0f;
    }
  }
}
