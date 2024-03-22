using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;

namespace ApiManager
{
    public class ApiHandler : MonoBehaviour
    {
        public string url;
        
        private async void Awake()
        {
            print(await Request(url));
        }

        public async UniTask<string> Request(string requestUrl)
        {
            
            using var webRequest = new UnityWebRequest(); // Create an instance of Unity Web Request
            
            webRequest.downloadHandler = new DownloadHandlerBuffer(); // Create the download handler
            webRequest.url = requestUrl; // Setup the Url
            webRequest.method = UnityWebRequest.kHttpVerbGET; // Setup the HTTP Method
            webRequest.SetRequestHeader("User", "Dude"); // Optional SetUp Headers
            
            await webRequest.SendWebRequest(); // Send the request and await it
            
            string result = webRequest.downloadHandler?.text; // Get the response from downloadedHandler
            
            return result;
            
        }
        
    }
}