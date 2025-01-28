
using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ColorPresets : MonoBehaviour
{
  public ColorPicker picker;
  public List<Image> presets;
  public List<UIOnHover> buttons;
  public Image createPresetImage;

  private void Awake()
  {
    string path = SaveFolder.persistentDataPath + Path.DirectorySeparatorChar.ToString() + "PresetColors.pcolors";
    if (File.Exists(path))
    {
      using (MemoryStream memoryStream = new MemoryStream(File.ReadAllBytes(path)))
      {
        using (BinaryReader binaryReader = new BinaryReader((Stream) memoryStream))
        {
          int num = binaryReader.ReadInt32();
          for (int index = 0; index < num; ++index)
          {
            if (index < this.presets.Count)
            {
              Color white = Color.white;
              white.r = binaryReader.ReadSingle();
              white.g = binaryReader.ReadSingle();
              white.b = binaryReader.ReadSingle();
              white.a = binaryReader.ReadSingle();
              this.presets[index].gameObject.SetActive(true);
              this.presets[index].color = white;
            }
            else
              break;
          }
        }
      }
    }
    for (int index = 0; index < this.buttons.Count; ++index)
    {
      int e = index;
      this.buttons[index].onRightClick.AddListener((UnityAction) (() => this.ContextMenu(e)));
    }
    this.picker.onValueChanged.AddListener(new UnityAction<Color>(this.ColorChanged));
  }

  public void CreatePresetButton()
  {
    for (int i = 0; i < this.presets.Count; ++i)
    {
      if (!this.presets[i].gameObject.activeSelf)
      {
        this.presets[i].gameObject.SetActive(true);
        this.presets[i].GetComponent<Image>().color = this.picker.CurrentColor;
        this.Save(i);
        break;
      }
    }
  }

  private void Save(int i)
  {
    string path = SaveFolder.persistentDataPath + Path.DirectorySeparatorChar.ToString() + "PresetColors.pcolors";
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (BinaryWriter binaryWriter = new BinaryWriter((Stream) memoryStream))
      {
        binaryWriter.Write(i + 1);
        for (int index = 0; index <= i; ++index)
        {
          Color color = this.presets[index].color;
          binaryWriter.Write(color.r);
          binaryWriter.Write(color.g);
          binaryWriter.Write(color.b);
          binaryWriter.Write(color.a);
        }
      }
      File.WriteAllBytes(path, memoryStream.ToArray());
    }
  }

  public void PresetSelect(Image sender)
  {
    if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
    {
      int index = this.presets.FindIndex((Predicate<Image>) (x => (UnityEngine.Object) x == (UnityEngine.Object) sender));
      if (index == -1)
        return;
      this.Delete(index);
    }
    else if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
    {
      int index = this.presets.FindIndex((Predicate<Image>) (x => (UnityEngine.Object) x == (UnityEngine.Object) sender));
      if (index == -1)
        return;
      this.UpdateItem(index);
    }
    else
      this.picker.CurrentColor = sender.color;
  }

  public void ContextMenu(int i)
  {
    MyContextMenu myContextMenu = MyContextMenu.Show();
    myContextMenu.AddItem("Delete (Hotkey: Ctrl+Click)", (Action) (() => this.Delete(i)), (Color) ColorScheme.GetColor(MyContextMenu.ColorRed));
    myContextMenu.AddItem("Update (Hotkey: Shift+Click)", (Action) (() => this.UpdateItem(i)), (Color) ColorScheme.GetColor(MyContextMenu.ColorYellow));
    myContextMenu.Rebuild(false);
  }

  private void Delete(int index)
  {
    for (; index + 1 < this.presets.Count && this.presets[index + 1].gameObject.activeSelf; ++index)
      this.presets[index].color = this.presets[index + 1].color;
    this.presets[index].gameObject.SetActive(false);
    this.Save(index - 1);
  }

  private void UpdateItem(int i)
  {
    this.presets[i].color = this.picker.CurrentColor;
    for (; i < this.presets.Count; ++i)
    {
      if (!this.presets[i].gameObject.activeSelf)
      {
        this.Save(i);
        return;
      }
    }
    this.Save(this.presets.Count - 1);
  }

  private void ColorChanged(Color color)
  {
    this.createPresetImage.color = color;
  }
}
