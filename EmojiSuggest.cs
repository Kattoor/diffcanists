
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EmojiSuggest : MonoBehaviour
{
  private List<TMP_Text> items = new List<TMP_Text>();
  private List<UIOnHover> itemButtons = new List<UIOnHover>();
  private int curIndex = -1;
  public InputFieldPlus targetInput;
  public TMP_Text pfab;
  public RectTransform container;
  private int curActive;

  public bool ActiveSelection
  {
    get
    {
      return this.gameObject.activeInHierarchy && this.curIndex >= 0;
    }
  }

  private void OnDisable()
  {
    this.ClearSelection();
  }

  private void ClearSelection()
  {
    if (this.itemButtons.Count >= this.curIndex && this.curIndex >= 0 && this.curIndex < this.curActive)
      this.itemButtons[this.curIndex].OnExit(false);
    this.curIndex = -1;
  }

  public void Search(string n)
  {
    if (EmojiInfo.Search(n))
    {
      int index = 0;
      for (EmojiInfo.Cat searchResults = EmojiInfo.searchResults; index < searchResults.list.Count && index < 15; ++index)
      {
        if (this.items.Count <= index)
        {
          TMP_Text tmpText = Object.Instantiate<TMP_Text>(this.pfab, this.pfab.transform.parent);
          UIOnHover component = tmpText.GetComponent<UIOnHover>();
          this.items.Add(tmpText);
          this.itemButtons.Add(component);
        }
        this.items[index].text = "<sprite name=\"" + searchResults.list[index].realName + "\"> <size=18>:" + searchResults.list[index].name + ":";
        this.items[index].name = "<sprite name=\"" + searchResults.list[index].realName + "\">";
        this.items[index].gameObject.SetActive(true);
      }
      this.curActive = index;
      this.container.sizeDelta = new Vector2(this.container.sizeDelta.x, (float) (index * 28 + 16));
      for (; index < this.items.Count; ++index)
        this.items[index].gameObject.SetActive(false);
      this.gameObject.SetActive(true);
    }
    else
      this.gameObject.SetActive(false);
  }

  private void Update()
  {
    if (Input.GetKeyDown(KeyCode.DownArrow))
    {
      if (this.itemButtons.Count >= this.curIndex && this.curIndex >= 0)
        this.itemButtons[this.curIndex].OnExit(false);
      ++this.curIndex;
      if (this.curIndex >= this.curActive)
        this.curIndex = 0;
      this.itemButtons[this.curIndex].OnEnter(false);
    }
    else if (Input.GetKeyDown(KeyCode.UpArrow))
    {
      if (this.itemButtons.Count >= this.curIndex && this.curIndex >= 0)
        this.itemButtons[this.curIndex].OnExit(false);
      --this.curIndex;
      if (this.curIndex < 0)
        this.curIndex = this.curActive - 1;
      this.itemButtons[this.curIndex].OnEnter(false);
    }
    else if (Input.GetKeyDown(KeyCode.LeftArrow))
    {
      this.ClearSelection();
    }
    else
    {
      if (!Input.GetKeyDown(KeyCode.RightArrow) && !Input.GetKeyDown(KeyCode.Return) || (this.curIndex >= this.curActive || this.curIndex < 0))
        return;
      if (this.itemButtons.Count >= this.curIndex && this.curIndex >= 0)
        this.itemButtons[this.curIndex].OnExit(false);
      this.itemButtons[this.curIndex].onClick.Invoke();
    }
  }

  public void ClickEmoji(TMP_Text t)
  {
    this.gameObject.SetActive(false);
    this.targetInput.ReplaceEmoji(t.name);
  }

  public void OnHover()
  {
    this.ClearSelection();
  }
}
