
using TMPro;
using UnityEngine;

namespace ntw.CurvedTextMeshPro
{
  [ExecuteInEditMode]
  public abstract class TextProOnACurve : MonoBehaviour
  {
    private int ScreenSizeX = -1;
    private int ScreenSizeY = -1;
    private TMP_Text m_TextComponent;
    private int delay;
    private bool m_forceUpdate;

    private void Awake()
    {
      this.m_TextComponent = this.gameObject.GetComponent<TMP_Text>();
    }

    private void OnEnable()
    {
      this.m_forceUpdate = true;
    }

    protected void Update()
    {
      if (!this.m_forceUpdate && !this.m_TextComponent.havePropertiesChanged && (!this.ParametersHaveChanged() && this.ScreenSizeX == Screen.width) && (this.ScreenSizeY == Screen.height && this.delay <= 0))
        return;
      if (this.ScreenSizeX != Screen.width || this.ScreenSizeY != Screen.height)
        this.delay = 10;
      --this.delay;
      this.ScreenSizeX = Screen.width;
      this.ScreenSizeY = Screen.height;
      this.m_forceUpdate = false;
      this.m_TextComponent.ForceMeshUpdate(false, false);
      TMP_TextInfo textInfo = this.m_TextComponent.textInfo;
      int characterCount = textInfo.characterCount;
      if (characterCount == 0)
        return;
      float x1 = this.m_TextComponent.bounds.min.x;
      float x2 = this.m_TextComponent.bounds.max.x;
      for (int charIdx = 0; charIdx < characterCount; ++charIdx)
      {
        if (textInfo.characterInfo[charIdx].isVisible)
        {
          int vertexIndex = textInfo.characterInfo[charIdx].vertexIndex;
          int materialReferenceIndex = textInfo.characterInfo[charIdx].materialReferenceIndex;
          Vector3[] vertices = textInfo.meshInfo[materialReferenceIndex].vertices;
          Vector3 charMidBaselinePos = (Vector3) new Vector2((float) (((double) vertices[vertexIndex].x + (double) vertices[vertexIndex + 2].x) / 2.0), textInfo.characterInfo[charIdx].baseLine);
          vertices[vertexIndex] += -charMidBaselinePos;
          vertices[vertexIndex + 1] += -charMidBaselinePos;
          vertices[vertexIndex + 2] += -charMidBaselinePos;
          vertices[vertexIndex + 3] += -charMidBaselinePos;
          float zeroToOnePos = (float) (((double) charMidBaselinePos.x - (double) x1) / ((double) x2 - (double) x1));
          Matrix4x4 transformationMatrix = this.ComputeTransformationMatrix(charMidBaselinePos, zeroToOnePos, textInfo, charIdx);
          vertices[vertexIndex] = transformationMatrix.MultiplyPoint3x4(vertices[vertexIndex]);
          vertices[vertexIndex + 1] = transformationMatrix.MultiplyPoint3x4(vertices[vertexIndex + 1]);
          vertices[vertexIndex + 2] = transformationMatrix.MultiplyPoint3x4(vertices[vertexIndex + 2]);
          vertices[vertexIndex + 3] = transformationMatrix.MultiplyPoint3x4(vertices[vertexIndex + 3]);
        }
      }
      this.m_TextComponent.UpdateVertexData();
    }

    protected abstract bool ParametersHaveChanged();

    protected abstract Matrix4x4 ComputeTransformationMatrix(
      Vector3 charMidBaselinePos,
      float zeroToOnePos,
      TMP_TextInfo textInfo,
      int charIdx);
  }
}
