
using UnityEngine;

#nullable disable
public class ToolTexturePainter : IMapEditorTool
{
  public void OnMouseDown(bool leftClick)
  {
    Point mousePos = MapEditor.GetMousePos();
    if (MapEditor.Instance.drop_texShape.value <= 0)
    {
      ZMap selectedLayer = MapEditor.Instance.selectedLayer;
      Texture2D tex = MapEditor.Instance._tex;
      int brushSize = MapEditor.Instance.brushSize;
      int x = mousePos.x;
      int y = mousePos.y;
      int num = MapEditor.getTextureIgnoreExisting & leftClick ? 1 : 0;
      double getTextureHue = (double) MapEditor.getTextureHue;
      Color? nullable = leftClick ? (MapEditor.getTextureColor.a == byte.MaxValue ? new Color?((Color) MapEditor.getTextureColor) : new Color?()) : new Color?(Color.clear);
      Color32? overrideColor = nullable.HasValue ? new Color32?((Color32) nullable.GetValueOrDefault()) : new Color32?();
      selectedLayer.Editor_Texture_Restrained_Cirle(tex, brushSize, x, y, num != 0, false, (float) getTextureHue, overrideColor);
    }
    else
    {
      ZMap selectedLayer = MapEditor.Instance.selectedLayer;
      Texture2D tex = MapEditor.Instance._tex;
      int brushSize = MapEditor.Instance.brushSize;
      int x = mousePos.x;
      int y = mousePos.y;
      int num = MapEditor.getTextureIgnoreExisting & leftClick ? 1 : 0;
      double getTextureHue = (double) MapEditor.getTextureHue;
      Color? nullable = leftClick ? (MapEditor.getTextureColor.a == byte.MaxValue ? new Color?((Color) MapEditor.getTextureColor) : new Color?()) : new Color?(Color.clear);
      Color32? overrideColor = nullable.HasValue ? new Color32?((Color32) nullable.GetValueOrDefault()) : new Color32?();
      selectedLayer.Editor_Texture_Restrained_Square(tex, brushSize, x, y, num != 0, false, (float) getTextureHue, overrideColor);
    }
    if (MapEditor.Instance.curPixelStack == null)
      MapEditor.Instance.curPixelStack = new MapEditor.UndoPixels();
    MapEditor.UndoPixels.GetChanged(MapEditor.Instance.curPixelStack);
    MapEditor.Instance.selectedLayer.Apply();
  }

  public void OnMouseDrag(bool leftClick) => this.OnMouseDown(leftClick);

  public void OnMouseUp(bool leftClick) => MapEditor.Instance.SaveDo_Pixels();
}
