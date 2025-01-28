
using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class EmojiPicker : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
  [SerializeField]
  private RectTransform container;
  private Action<int> action;

  public static EmojiPicker instance { get; private set; }

  private void Awake()
  {
    EmojiPicker.instance = this;
  }

  private void OnDestroy()
  {
    if (!((UnityEngine.Object) EmojiPicker.instance == (UnityEngine.Object) this))
      return;
    EmojiPicker.instance = (EmojiPicker) null;
  }

  public static void Show(Action<int> a)
  {
    if ((UnityEngine.Object) EmojiPicker.instance == (UnityEngine.Object) null)
      Controller.CreateEmojiMenu();
    EmojiPicker.instance._Show(a);
  }

  private void _Show(Action<int> a)
  {
    this.action = a;
    this.transform.SetAsLastSibling();
    this.gameObject.SetActive(true);
  }

  public static void Close()
  {
    EmojiPicker.instance.action = (Action<int>) null;
    EmojiPicker.instance.gameObject.SetActive(false);
  }

  private void Update()
  {
    if (!Input.GetKeyDown(KeyCode.F12))
      return;
    EmojiPicker.Close();
  }

  private void DebugPoint(PointerEventData ped)
  {
    Vector2 localPoint;
    if (!RectTransformUtility.ScreenPointToLocalPointInRectangle(this.container, ped.position, ped.pressEventCamera, out localPoint))
      return;
    if ((double) localPoint.x < -5.0 || (double) localPoint.y < -5.0 || ((double) localPoint.x > 805.0 || (double) localPoint.y > 883.0))
    {
      EmojiPicker.Close();
    }
    else
    {
      int num = (int) Mathf.Clamp(localPoint.x / 15.68627f, 0.0f, 51f) + 51 * (56 - (int) Mathf.Clamp(localPoint.y / 15.67857f, 0.0f, 56f)) - 51;
      Action<int> action = this.action;
      if (action != null)
        action(num);
      EmojiPicker.Close();
    }
  }

  public void OnPointerDown(PointerEventData eventData)
  {
    this.DebugPoint(eventData);
  }
}
