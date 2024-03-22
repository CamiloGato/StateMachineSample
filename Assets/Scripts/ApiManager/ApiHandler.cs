using Cysharp.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

namespace ApiManager
{
    public class ApiHandler : MonoBehaviour
    {
        public string urlImage;
        public string urlData;
        
        public string user;

        public Image image;
        public TMP_Text text;
        
        
        [ContextMenu("Request")]
        private async void MakeRequest()
        {
            Texture2D myTexture2D = await RequestTexture(urlImage);
            Sprite convertToSprite = Sprite.Create(
                myTexture2D,
                new Rect(0.0f, 0.0f, myTexture2D.width, myTexture2D.height),
                new Vector2(0.5f, 0.5f), 
                100.0f
                );
            image.sprite = convertToSprite;

            text.text = await RequestText(urlData);

        }

        public async UniTask<Texture2D> RequestTexture(string requestUrl)
        {
            
            using var webRequest = new UnityWebRequest(); // Create an instance of Unity Web Request
            
            webRequest.downloadHandler = new DownloadHandlerTexture(); // Create the download handler
            webRequest.url = requestUrl; // Setup the Url
            webRequest.method = UnityWebRequest.kHttpVerbGET; // Setup the HTTP Method
            webRequest.SetRequestHeader("User", user); // Optional SetUp Headers
            
            await webRequest.SendWebRequest(); // Send the request and await it
            
            Texture2D result = ((DownloadHandlerTexture)webRequest.downloadHandler).texture; // Get the response from downloadedHandler
            
            return result;
            
        }
        
        public async UniTask<string> RequestText(string requestUrl)
        {
            
            using var webRequest = new UnityWebRequest(); // Create an instance of Unity Web Request
            
            webRequest.downloadHandler = new DownloadHandlerBuffer(); // Create the download handler
            webRequest.url = requestUrl; // Setup the Url
            webRequest.method = UnityWebRequest.kHttpVerbGET; // Setup the HTTP Method
            webRequest.SetRequestHeader("User", user); // Optional SetUp Headers
            
            await webRequest.SendWebRequest(); // Send the request and await it
            
            string result = webRequest.downloadHandler.text; // Get the response from downloadedHandler
            
            return result;
            
        }
        
    }
}