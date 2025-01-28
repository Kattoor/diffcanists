
using UnityEngine;
using UnityEngine.EventSystems;

public class ResizedRect : UIBehaviour
{
  protected override void OnRectTransformDimensionsChange()
  {
    base.OnRectTransformDimensionsChange();
    if (!((Object) ChatBox.Instance != (Object) null))
      return;
    ChatBox.Instance.Resized();
  }
}
