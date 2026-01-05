
using System;
using UnityEngine;

public class SafeAreaFitter : MonoBehaviour
{
  public SafeAreaFitter.Movement movement;

  private void Start()
  {
    this.UpdatePosition();
  }

  public void SetPosition(Vector2 p)
  {
    ((RectTransform) this.transform).anchoredPosition = p;
    this.UpdatePosition();
  }

  public void UpdatePosition()
  {
  }

  [Serializable]
  public enum Movement
  {
    Left,
    Right,
    Up,
    Down,
  }
}
