
public class ToolBoxSelection : IMapEditorTool
{
  private static MapEditor.BoxSelection _old;

  public void OnMouseDown(bool leftClick)
  {
    ToolBoxSelection._old = MapEditor.Instance.boxSelection?.Copy();
    if (leftClick)
    {
      MapEditor.Instance.boxSelection = new MapEditor.BoxSelection(MapEditor.GetMousePos());
      MapEditor.Instance.RefreshBoxSelection();
    }
    else
    {
      MapEditor.Instance.boxSelection = (MapEditor.BoxSelection) null;
      MapEditor.Instance.RefreshBoxSelection();
    }
  }

  public void OnMouseDrag(bool leftClick)
  {
    if (!leftClick)
      return;
    MapEditor.Instance.boxSelection.SetEnd(MapEditor.GetMousePos());
    MapEditor.Instance.RefreshBoxSelection();
  }

  public void OnMouseUp(bool leftClick)
  {
    if (MapEditor.Instance.boxSelection == null && ToolBoxSelection._old == null || MapEditor.Instance.boxSelection != null && MapEditor.Instance.boxSelection.Equals((object) ToolBoxSelection._old))
      return;
    MapEditor.Instance.SaveDo_BoxSelection(ToolBoxSelection._old);
    if (MapEditor.Instance.boxSelection == null || !leftClick || MapEditor.Instance.boxSelection.width != 0 && MapEditor.Instance.boxSelection.height != 0)
      return;
    MapEditor.Instance.boxSelection = (MapEditor.BoxSelection) null;
    MapEditor.Instance.RefreshBoxSelection();
  }
}
