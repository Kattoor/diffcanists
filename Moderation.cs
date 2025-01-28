
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using UnityEngine;

public class Moderation
{
  private static readonly HttpClient Client = new HttpClient();
  private string apiKey = "your-api-key-here";
  private string moderationEndpoint = "https://api.openai.com/v1/moderations";

  public static async void Test(string input)
  {
    UriBuilder uriBuilder = new UriBuilder("https://api.openai.com/v1/moderations");
    Dictionary<string, string> dictionary = new Dictionary<string, string>()
    {
      {
        "Content-Type",
        "application/json"
      },
      {
        "Authorization",
        "REDACTED"
      }
    };
    string str1 = JsonConvert.SerializeObject((object) new ModerationRequest(input));
    using (HttpRequestMessage requestMessage = new HttpRequestMessage(new HttpMethod("POST"), uriBuilder.Uri))
    {
      if (!string.IsNullOrWhiteSpace(str1) && JToken.Parse(str1).HasValues)
        requestMessage.Content = (HttpContent) new StringContent(str1, Encoding.UTF8, "application/json");
      foreach (KeyValuePair<string, string> keyValuePair in dictionary)
        requestMessage.Headers.TryAddWithoutValidation(keyValuePair.Key, keyValuePair.Value);
      using (CancellationTokenSource cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(10.0)))
      {
        CancellationToken token = cancellationTokenSource.Token;
        using (HttpResponseMessage response = await Moderation.Client.SendAsync(requestMessage, token))
        {
          string str2 = await response.Content.ReadAsStringAsync();
          if (response.IsSuccessStatusCode)
          {
            Debug.Log((object) str2);
            return;
          }
          Debug.LogError((object) ("Failed to RETRIEVE " + input + " <> " + (object) response.StatusCode));
        }
      }
    }
  }
}
