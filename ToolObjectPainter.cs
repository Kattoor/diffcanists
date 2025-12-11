
using UnityEngine;

public class ToolObjectPainter : IMapEditorTool
{
  public void OnMouseDown(bool leftClick)
  {
    Point mousePos = MapEditor.GetMousePos();
    if ((double) MapEditor.getObjectHue == 1.0 && (double) MapEditor.getObjectScale == 1.0 && (double) MapEditor.getObjectRot == 0.0)
    {
      ZMap selectedLayer = MapEditor.Instance.selectedLayer;
      Texture2D tex = MapEditor.Instance._tex;
      int x = mousePos.x;
      int y = mousePos.y + MapEditor.Instance._tex.height / 2;
      int num = MapEditor.getObjectBehind & leftClick ? 1 : 0;
      Color? nullable = leftClick ? (MapEditor.getObjectColor.a == byte.MaxValue ? new Color?((Color) MapEditor.getObjectColor) : new Color?()) : new Color?(Color.clear);
      Color32? overrideColor = nullable.HasValue ? new Color32?((Color32) nullable.GetValueOrDefault()) : new Color32?();
      selectedLayer.Editor_Object(tex, x, y, num != 0, false, overrideColor);
    }
    else
    {
      ZMap selectedLayer = MapEditor.Instance.selectedLayer;
      Surface src = new Surface(MapEditor.Instance._tex);
      int x = mousePos.x;
      int y = mousePos.y;
      double getObjectRot = (double) MapEditor.getObjectRot;
      int num1 = !MapEditor.getObjectBehind ? 1 : (!leftClick ? 1 : 0);
      double getObjectHue = (double) MapEditor.getObjectHue;
      double getObjectScale = (double) MapEditor.getObjectScale;
      int num2 = MapEditor.getObjectFlipX ? 1 : 0;
      Color? nullable = leftClick ? (MapEditor.getObjectColor.a == byte.MaxValue ? new Color?((Color) MapEditor.getObjectColor) : new Color?()) : new Color?(Color.clear);
      Color32? overrideColor = nullable.HasValue ? new Color32?((Color32) nullable.GetValueOrDefault()) : new Color32?();
      RotateImage.Editor_RenderHUE(selectedLayer, src, x, y, (float) getObjectRot, num1 != 0, (float) getObjectHue, (float) getObjectScale, num2 != 0, overrideColor);
    }
    MapEditor.Instance.SaveDo_Pixels();
    MapEditor.Instance.selectedLayer.Apply();
  }

  public void OnMouseDrag(bool leftClick)
  {
  }

  public void OnMouseUp(bool leftClick)
  {
  }
}
