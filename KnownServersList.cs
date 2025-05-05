
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;

#nullable disable
[Serializable]
public class KnownServersList
{
  public List<KnownServers> servers = new List<KnownServers>();

  public static void Get(MonoBehaviour g, Action<KnownServersList> a)
  {
    g.StartCoroutine(KnownServersList._Get(a));
  }

  private static IEnumerator _Get(Action<KnownServersList> a)
  {
    using (UnityWebRequest webRequest = UnityWebRequest.Get("...url..."))
    {
      webRequest.timeout = 5;
      yield return (object) webRequest.SendWebRequest();
      if (webRequest.isHttpError || webRequest.isNetworkError)
        Debug.LogError((object) webRequest.error);
      Action<KnownServersList> action = a;
      if (action != null)
        action(JsonUtility.FromJson<KnownServersList>(webRequest.downloadHandler.text));
    }
  }

  public void ToJson()
  {
    Global.systemCopyBuffer = JsonUtility.ToJson((object) this);
    Debug.Log((object) ("Known Severs copied to clipboard: " + Global.systemCopyBuffer));
  }

  public static async Task<KnownServersList> GetServerList()
  {
    using (UnityWebRequest webRequest = UnityWebRequest.Get("https://secure.arcanists.com/ServerList.json"))
    {
      try
      {
        UnityWebRequest unityWebRequest = await webRequest.SendWebRequest();
        if (!webRequest.isNetworkError)
          return JsonConvert.DeserializeObject<KnownServersList>(webRequest.downloadHandler.text);
        Debug.LogError((object) ("Error Getting Server list " + webRequest.error));
      }
      catch (Exception ex)
      {
        Debug.LogError((object) ("ERROR Getting Server list " + ex.ToString()));
      }
    }
    return Inert.Instance.servers;
  }
}
