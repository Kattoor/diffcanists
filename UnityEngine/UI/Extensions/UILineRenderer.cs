
using System;
using System.Collections.Generic;
using UnityEngine.Sprites;

namespace UnityEngine.UI.Extensions
{
  [AddComponentMenu("UI/Extensions/Primitives/UILineRenderer")]
  [RequireComponent(typeof (RectTransform))]
  public class UILineRenderer : UIPrimitiveBase
  {
    [SerializeField]
    [Tooltip("Thickness of the line")]
    internal float lineThickness = 2f;
    [SerializeField]
    [Tooltip("Resolution of the Bezier curve, different to line Resolution")]
    internal int bezierSegmentsPerCurve = 10;
    private const float MIN_MITER_JOIN = 0.2617994f;
    private const float MIN_BEVEL_NICE_JOIN = 0.5235988f;
    private static Vector2 UV_TOP_LEFT;
    private static Vector2 UV_BOTTOM_LEFT;
    private static Vector2 UV_TOP_CENTER_LEFT;
    private static Vector2 UV_TOP_CENTER_RIGHT;
    private static Vector2 UV_BOTTOM_CENTER_LEFT;
    private static Vector2 UV_BOTTOM_CENTER_RIGHT;
    private static Vector2 UV_TOP_RIGHT;
    private static Vector2 UV_BOTTOM_RIGHT;
    private static Vector2[] startUvs;
    private static Vector2[] middleUvs;
    private static Vector2[] endUvs;
    private static Vector2[] fullUvs;
    [SerializeField]
    [Tooltip("Points to draw lines between\n Can be improved using the Resolution Option")]
    internal Vector2[] m_points;
    [SerializeField]
    [Tooltip("Use the relative bounds of the Rect Transform (0,0 -> 0,1) or screen space coordinates")]
    internal bool relativeSize;
    [SerializeField]
    [Tooltip("Do the points identify a single line or split pairs of lines")]
    internal bool lineList;
    [SerializeField]
    [Tooltip("Add end caps to each line\nMultiple caps when used with Line List")]
    internal bool lineCaps;
    [Tooltip("The type of Join used between lines, Square/Mitre or Curved/Bevel")]
    public UILineRenderer.JoinType LineJoins;
    [Tooltip("Bezier method to apply to line, see docs for options\nCan't be used in conjunction with Resolution as Bezier already changes the resolution")]
    public UILineRenderer.BezierType BezierMode;
    [HideInInspector]
    public bool drivenExternally;

    public float LineThickness
    {
      get
      {
        return this.lineThickness;
      }
      set
      {
        this.lineThickness = value;
        this.SetAllDirty();
      }
    }

    public bool RelativeSize
    {
      get
      {
        return this.relativeSize;
      }
      set
      {
        this.relativeSize = value;
        this.SetAllDirty();
      }
    }

    public bool LineList
    {
      get
      {
        return this.lineList;
      }
      set
      {
        this.lineList = value;
        this.SetAllDirty();
      }
    }

    public bool LineCaps
    {
      get
      {
        return this.lineCaps;
      }
      set
      {
        this.lineCaps = value;
        this.SetAllDirty();
      }
    }

    public int BezierSegmentsPerCurve
    {
      get
      {
        return this.bezierSegmentsPerCurve;
      }
      set
      {
        this.bezierSegmentsPerCurve = value;
      }
    }

    public Vector2[] Points
    {
      get
      {
        return this.m_points;
      }
      set
      {
        if (this.m_points == value)
          return;
        this.m_points = value;
        this.SetAllDirty();
      }
    }

    protected override void OnPopulateMesh(VertexHelper vh)
    {
      if (this.m_points == null)
      {
        this.m_points = new Vector2[2];
        this.m_points[0] = Vector2.zero;
        this.m_points[1] = Vector2.down;
      }
      this.GeneratedUVs();
      Vector2[] vector2Array = this.m_points;
      if (this.BezierMode != UILineRenderer.BezierType.None && this.BezierMode != UILineRenderer.BezierType.Catenary && this.m_points.Length > 3)
      {
        BezierPath bezierPath = new BezierPath();
        bezierPath.SetControlPoints(vector2Array);
        bezierPath.SegmentsPerCurve = this.bezierSegmentsPerCurve;
        List<Vector2> vector2List;
        switch (this.BezierMode)
        {
          case UILineRenderer.BezierType.Basic:
            vector2List = bezierPath.GetDrawingPoints0();
            break;
          case UILineRenderer.BezierType.Improved:
            vector2List = bezierPath.GetDrawingPoints1();
            break;
          default:
            vector2List = bezierPath.GetDrawingPoints2();
            break;
        }
        vector2Array = vector2List.ToArray();
      }
      if (this.BezierMode == UILineRenderer.BezierType.Catenary && this.m_points.Length == 2)
        vector2Array = new CableCurve(vector2Array)
        {
          slack = this.Resoloution,
          steps = this.BezierSegmentsPerCurve
        }.Points();
      if (this.ImproveResolution != ResolutionMode.None)
        vector2Array = this.IncreaseResolution(vector2Array);
      float num1 = !this.relativeSize ? 1f : this.rectTransform.rect.width;
      float num2 = !this.relativeSize ? 1f : this.rectTransform.rect.height;
      float num3 = -this.rectTransform.pivot.x * num1;
      float num4 = -this.rectTransform.pivot.y * num2;
      vh.Clear();
      List<UIVertex[]> uiVertexArrayList = new List<UIVertex[]>();
      if (this.lineList)
      {
        for (int index = 1; index < vector2Array.Length; index += 2)
        {
          Vector2 start = vector2Array[index - 1];
          Vector2 end = vector2Array[index];
          start = new Vector2(start.x * num1 + num3, start.y * num2 + num4);
          end = new Vector2(end.x * num1 + num3, end.y * num2 + num4);
          if (this.lineCaps)
            uiVertexArrayList.Add(this.CreateLineCap(start, end, UILineRenderer.SegmentType.Start));
          uiVertexArrayList.Add(this.CreateLineSegment(start, end, UILineRenderer.SegmentType.Middle));
          if (this.lineCaps)
            uiVertexArrayList.Add(this.CreateLineCap(start, end, UILineRenderer.SegmentType.End));
        }
      }
      else
      {
        for (int index = 1; index < vector2Array.Length; ++index)
        {
          Vector2 start = vector2Array[index - 1];
          Vector2 end = vector2Array[index];
          start = new Vector2(start.x * num1 + num3, start.y * num2 + num4);
          end = new Vector2(end.x * num1 + num3, end.y * num2 + num4);
          if (this.lineCaps && index == 1)
            uiVertexArrayList.Add(this.CreateLineCap(start, end, UILineRenderer.SegmentType.Start));
          uiVertexArrayList.Add(this.CreateLineSegment(start, end, UILineRenderer.SegmentType.Middle));
          if (this.lineCaps && index == vector2Array.Length - 1)
            uiVertexArrayList.Add(this.CreateLineCap(start, end, UILineRenderer.SegmentType.End));
        }
      }
      for (int index = 0; index < uiVertexArrayList.Count; ++index)
      {
        if (!this.lineList && index < uiVertexArrayList.Count - 1)
        {
          Vector3 vector3_1 = uiVertexArrayList[index][1].position - uiVertexArrayList[index][2].position;
          Vector3 vector3_2 = uiVertexArrayList[index + 1][2].position - uiVertexArrayList[index + 1][1].position;
          float num5 = Vector2.Angle((Vector2) vector3_1, (Vector2) vector3_2) * ((float) Math.PI / 180f);
          float num6 = Mathf.Sign(Vector3.Cross(vector3_1.normalized, vector3_2.normalized).z);
          float num7 = this.lineThickness / (2f * Mathf.Tan(num5 / 2f));
          Vector3 vector3_3 = uiVertexArrayList[index][2].position - vector3_1.normalized * num7 * num6;
          Vector3 vector3_4 = uiVertexArrayList[index][3].position + vector3_1.normalized * num7 * num6;
          UILineRenderer.JoinType joinType = this.LineJoins;
          if (joinType == UILineRenderer.JoinType.Miter)
          {
            if ((double) num7 < (double) vector3_1.magnitude / 2.0 && (double) num7 < (double) vector3_2.magnitude / 2.0 && (double) num5 > 0.261799395084381)
            {
              uiVertexArrayList[index][2].position = vector3_3;
              uiVertexArrayList[index][3].position = vector3_4;
              uiVertexArrayList[index + 1][0].position = vector3_4;
              uiVertexArrayList[index + 1][1].position = vector3_3;
            }
            else
              joinType = UILineRenderer.JoinType.Bevel;
          }
          if (joinType == UILineRenderer.JoinType.Bevel)
          {
            if ((double) num7 < (double) vector3_1.magnitude / 2.0 && (double) num7 < (double) vector3_2.magnitude / 2.0 && (double) num5 > 0.523598790168762)
            {
              if ((double) num6 < 0.0)
              {
                uiVertexArrayList[index][2].position = vector3_3;
                uiVertexArrayList[index + 1][1].position = vector3_3;
              }
              else
              {
                uiVertexArrayList[index][3].position = vector3_4;
                uiVertexArrayList[index + 1][0].position = vector3_4;
              }
            }
            UIVertex[] verts = new UIVertex[4]
            {
              uiVertexArrayList[index][2],
              uiVertexArrayList[index][3],
              uiVertexArrayList[index + 1][0],
              uiVertexArrayList[index + 1][1]
            };
            vh.AddUIVertexQuad(verts);
          }
        }
        vh.AddUIVertexQuad(uiVertexArrayList[index]);
      }
      if (vh.currentVertCount <= 64000)
        return;
      Debug.LogError((object) ("Max Verticies size is 64000, current mesh vertcies count is [" + (object) vh.currentVertCount + "] - Cannot Draw"));
      vh.Clear();
    }

    private UIVertex[] CreateLineCap(
      Vector2 start,
      Vector2 end,
      UILineRenderer.SegmentType type)
    {
      if (type == UILineRenderer.SegmentType.Start)
        return this.CreateLineSegment(start - (end - start).normalized * this.lineThickness / 2f, start, UILineRenderer.SegmentType.Start);
      if (type == UILineRenderer.SegmentType.End)
      {
        Vector2 end1 = end + (end - start).normalized * this.lineThickness / 2f;
        return this.CreateLineSegment(end, end1, UILineRenderer.SegmentType.End);
      }
      Debug.LogError((object) "Bad SegmentType passed in to CreateLineCap. Must be SegmentType.Start or SegmentType.End");
      return (UIVertex[]) null;
    }

    private UIVertex[] CreateLineSegment(
      Vector2 start,
      Vector2 end,
      UILineRenderer.SegmentType type)
    {
      Vector2 vector2_1 = new Vector2(start.y - end.y, end.x - start.x).normalized * this.lineThickness / 2f;
      Vector2 vector2_2 = start - vector2_1;
      Vector2 vector2_3 = start + vector2_1;
      Vector2 vector2_4 = end + vector2_1;
      Vector2 vector2_5 = end - vector2_1;
      switch (type)
      {
        case UILineRenderer.SegmentType.Start:
          return this.SetVbo(new Vector2[4]
          {
            vector2_2,
            vector2_3,
            vector2_4,
            vector2_5
          }, UILineRenderer.startUvs);
        case UILineRenderer.SegmentType.End:
          return this.SetVbo(new Vector2[4]
          {
            vector2_2,
            vector2_3,
            vector2_4,
            vector2_5
          }, UILineRenderer.endUvs);
        case UILineRenderer.SegmentType.Full:
          return this.SetVbo(new Vector2[4]
          {
            vector2_2,
            vector2_3,
            vector2_4,
            vector2_5
          }, UILineRenderer.fullUvs);
        default:
          return this.SetVbo(new Vector2[4]
          {
            vector2_2,
            vector2_3,
            vector2_4,
            vector2_5
          }, UILineRenderer.middleUvs);
      }
    }

    protected override void GeneratedUVs()
    {
      if ((UnityEngine.Object) this.activeSprite != (UnityEngine.Object) null)
      {
        Vector4 outerUv = DataUtility.GetOuterUV(this.activeSprite);
        Vector4 innerUv = DataUtility.GetInnerUV(this.activeSprite);
        UILineRenderer.UV_TOP_LEFT = new Vector2(outerUv.x, outerUv.y);
        UILineRenderer.UV_BOTTOM_LEFT = new Vector2(outerUv.x, outerUv.w);
        UILineRenderer.UV_TOP_CENTER_LEFT = new Vector2(innerUv.x, innerUv.y);
        UILineRenderer.UV_TOP_CENTER_RIGHT = new Vector2(innerUv.z, innerUv.y);
        UILineRenderer.UV_BOTTOM_CENTER_LEFT = new Vector2(innerUv.x, innerUv.w);
        UILineRenderer.UV_BOTTOM_CENTER_RIGHT = new Vector2(innerUv.z, innerUv.w);
        UILineRenderer.UV_TOP_RIGHT = new Vector2(outerUv.z, outerUv.y);
        UILineRenderer.UV_BOTTOM_RIGHT = new Vector2(outerUv.z, outerUv.w);
      }
      else
      {
        UILineRenderer.UV_TOP_LEFT = Vector2.zero;
        UILineRenderer.UV_BOTTOM_LEFT = new Vector2(0.0f, 1f);
        UILineRenderer.UV_TOP_CENTER_LEFT = new Vector2(0.5f, 0.0f);
        UILineRenderer.UV_TOP_CENTER_RIGHT = new Vector2(0.5f, 0.0f);
        UILineRenderer.UV_BOTTOM_CENTER_LEFT = new Vector2(0.5f, 1f);
        UILineRenderer.UV_BOTTOM_CENTER_RIGHT = new Vector2(0.5f, 1f);
        UILineRenderer.UV_TOP_RIGHT = new Vector2(1f, 0.0f);
        UILineRenderer.UV_BOTTOM_RIGHT = Vector2.one;
      }
      UILineRenderer.startUvs = new Vector2[4]
      {
        UILineRenderer.UV_TOP_LEFT,
        UILineRenderer.UV_BOTTOM_LEFT,
        UILineRenderer.UV_BOTTOM_CENTER_LEFT,
        UILineRenderer.UV_TOP_CENTER_LEFT
      };
      UILineRenderer.middleUvs = new Vector2[4]
      {
        UILineRenderer.UV_TOP_CENTER_LEFT,
        UILineRenderer.UV_BOTTOM_CENTER_LEFT,
        UILineRenderer.UV_BOTTOM_CENTER_RIGHT,
        UILineRenderer.UV_TOP_CENTER_RIGHT
      };
      UILineRenderer.endUvs = new Vector2[4]
      {
        UILineRenderer.UV_TOP_CENTER_RIGHT,
        UILineRenderer.UV_BOTTOM_CENTER_RIGHT,
        UILineRenderer.UV_BOTTOM_RIGHT,
        UILineRenderer.UV_TOP_RIGHT
      };
      UILineRenderer.fullUvs = new Vector2[4]
      {
        UILineRenderer.UV_TOP_LEFT,
        UILineRenderer.UV_BOTTOM_LEFT,
        UILineRenderer.UV_BOTTOM_RIGHT,
        UILineRenderer.UV_TOP_RIGHT
      };
    }

    protected override void ResolutionToNativeSize(float distance)
    {
      if (!this.UseNativeSize)
        return;
      this.m_Resolution = distance / (this.activeSprite.rect.width / this.pixelsPerUnit);
      this.lineThickness = this.activeSprite.rect.height / this.pixelsPerUnit;
    }

    private enum SegmentType
    {
      Start,
      Middle,
      End,
      Full,
    }

    public enum JoinType
    {
      Bevel,
      Miter,
    }

    public enum BezierType
    {
      None,
      Quick,
      Basic,
      Improved,
      Catenary,
    }
  }
}
