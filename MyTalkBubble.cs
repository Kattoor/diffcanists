
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class MyTalkBubble : MonoBehaviour
{
  public TMP_Text txt;
  public Image imageBG;
  public RectTransform container;
  private bool shown;

  public static MyTalkBubble Create()
  {
    return Object.Instantiate<MyTalkBubble>(Controller.Instance.myTalkBubble, Client.game.GetMapTransform());
  }

  public void Setup(string msg, Color32? chatColor = null, Color32? bgColor = null, float scale = 1f)
  {
    this.txt.text = msg;
    if (chatColor.HasValue)
      this.txt.color = (Color) this.ZeroAlpha(chatColor.Value);
    if (bgColor.HasValue)
      this.imageBG.color = (Color) this.ZeroAlpha(bgColor.Value);
    if ((double) scale == 1.0)
      return;
    this.transform.localScale = new Vector3(scale, scale, scale);
  }

  private Color32 ZeroAlpha(Color32 c) => new Color32(c.r, c.g, c.b, (byte) 0);

  public void Update()
  {
    float num1 = ((RectTransform) Controller.Instance.transform).sizeDelta.x * 0.5f;
    if ((double) ((RectTransform) this.container.GetChild(1)).sizeDelta.x > (double) num1)
    {
      float num2 = num1 - 1f;
      float x = num2;
      int num3 = 0;
      foreach (char ch in this.container.GetChild(1).GetComponent<TextMeshProUGUI>().text)
      {
        if (ch == '\n')
          ++num3;
      }
      float y = (float) (((double) ((RectTransform) this.container.GetChild(1)).sizeDelta.x / (double) num2 + 2.0 + (double) num3) * 28.430000305175781);
      this.container.GetChild(1).GetComponent<ContentSizeFitter>().enabled = false;
      this.container.GetComponent<ContentSizeFitter>().enabled = false;
      ((RectTransform) this.container.GetChild(1)).sizeDelta = new Vector2(x, y);
      this.container.sizeDelta = new Vector2(x + 20f, y);
    }
    if (this.shown)
      return;
    this.shown = true;
    TextMeshProUGUI component1 = this.container.GetChild(1).GetComponent<TextMeshProUGUI>();
    component1.color = component1.color with { a = 1f };
    Image component2 = this.container.GetComponent<Image>();
    Color color = component2.color with { a = 1f };
    component2.color = color;
    Image component3 = this.container.GetChild(0).GetComponent<Image>();
    color = component3.color with { a = 1f };
    component3.color = color;
  }

  private void OnMouseDown() => Object.Destroy((Object) this.gameObject);
}
