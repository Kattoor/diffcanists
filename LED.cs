
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LED : MonoBehaviour
{
  public int columnCount = 7;
  public int rowCount = 7;
  private Color colorOn = Color.green;
  private Color colorOff = Color.grey;
  private List<Image> array = new List<Image>();
  private char c = 'a';
  private StringBuilder b = new StringBuilder();
  public RectTransform gridContainer;

  private void Start()
  {
    this.GenerateGrid();
  }

  private void GenerateGrid()
  {
    Rect rect = this.gridContainer.rect;
    double num1 = (double) rect.width / (double) this.columnCount;
    rect = this.gridContainer.rect;
    double num2 = (double) rect.height / (double) this.rowCount;
    float num3 = Mathf.Min((float) num1, (float) num2);
    GameObject original = new GameObject("ImagePrefab", new System.Type[1]
    {
      typeof (RectTransform)
    });
    original.AddComponent<Image>();
    for (int index1 = 0; index1 < this.rowCount; ++index1)
    {
      for (int index2 = 0; index2 < this.columnCount; ++index2)
      {
        int num4 = index1;
        int num5 = index2;
        GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(original, (Transform) this.gridContainer);
        Image image = gameObject.GetComponent<Image>();
        image.rectTransform.sizeDelta = new Vector2(num3, num3);
        image.rectTransform.anchoredPosition = new Vector2((float) num5 * num3, (float) -num4 * num3);
        this.array.Add(image);
        EventTrigger eventTrigger = gameObject.AddComponent<EventTrigger>();
        EventTrigger.Entry entry1 = new EventTrigger.Entry();
        entry1.eventID = EventTriggerType.PointerEnter;
        entry1.callback.AddListener((UnityAction<BaseEventData>) (data =>
        {
          if (!MyInput.GetMouseButton(0))
            return;
          image.color = this.IsOn(image) ? this.colorOff : this.colorOn;
        }));
        eventTrigger.triggers.Add(entry1);
        EventTrigger.Entry entry2 = new EventTrigger.Entry();
        entry2.eventID = EventTriggerType.PointerDown;
        entry2.callback.AddListener((UnityAction<BaseEventData>) (data => image.color = this.IsOn(image) ? this.colorOff : this.colorOn));
        eventTrigger.triggers.Add(entry2);
      }
    }
    UnityEngine.Object.Destroy((UnityEngine.Object) original);
    this.ResetGrid();
  }

  public void ResetGrid()
  {
    foreach (Image componentsInChild in this.gridContainer.GetComponentsInChildren<Image>())
    {
      if ((UnityEngine.Object) componentsInChild.transform != (UnityEngine.Object) componentsInChild)
        componentsInChild.color = this.colorOff;
    }
  }

  public void Save()
  {
    this.b.Append(this.c).Append(" = {");
    for (int index1 = 0; index1 < 7; ++index1)
    {
      int num = 0;
      for (int index2 = 0; index2 < 7; ++index2)
        num |= this.IsOn(this.array[index1 * 7 + index2]) ? 1 << index2 : 0;
      this.b.Append(num);
      if (index1 < 6)
        this.b.Append(", ");
    }
    this.b.Append("},\n");
    Debug.Log((object) this.b);
    Global.systemCopyBuffer = this.b.ToString();
    ++this.c;
    Debug.Log((object) ("Now do " + this.c.ToString()));
  }

  private bool IsOn(Image i)
  {
    return (double) i.color.r == 0.0;
  }
}
