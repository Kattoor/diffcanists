
using UnityEngine;
using UnityEngine.SceneManagement;

public class EmptyScene : MonoBehaviour
{
  private void OnGUI()
  {
    if (GUILayout.Button("Load empty"))
      SceneManager.LoadScene("Empty");
    if (!GUILayout.Button("Load main"))
      return;
    SceneManager.LoadScene("mainmenu");
  }
}
