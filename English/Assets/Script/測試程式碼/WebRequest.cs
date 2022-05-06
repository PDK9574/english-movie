using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class WebRequest : MonoBehaviour
{
    public AudioSource musicSource;
    public AudioClip stream_music;
    public InputField inputField;
    //按按鈕
    // public void RequestWeb()
    // {
    //     // A correct website page.
    //     StartCoroutine( LoadAudio("https://dict.youdao.com/dictvoice?audio=apple&type=1"));

    //     // A non-existing page.
    //     // StartCoroutine(GetRequest("https://error.html"));
    // }
    public void GetVoice()
    {
        // if(isEnglish(inputField.text)){
        StartCoroutine(downloadVoice(inputField.text));
        // }else{
        //     Debug.Log("請輸入英文");
        // }
    }

 
 
      private IEnumerator downloadVoice(string englishText)
    {
        string uri = "https://dict.youdao.com/dictvoice?audio="+englishText+"&type=1";
         using (UnityWebRequest www = UnityWebRequestMultimedia.GetAudioClip(uri, AudioType.MPEG))//AudioType 類型有可能不對
         {
            
             yield return www.SendWebRequest();//等待載入完成
           
            switch (www.result)//結果
            {
            case UnityWebRequest.Result.ConnectionError://連接問題
                 Debug.Log(www.error);
                 break;
            case UnityWebRequest.Result.DataProcessingError:
                Debug.LogError( ": Error: " + www.error);
                break;
            case UnityWebRequest.Result.ProtocolError:
                Debug.LogError(": HTTP Error: " + www.error);
                break;
             case UnityWebRequest.Result.Success:    
                 stream_music = DownloadHandlerAudioClip.GetContent(www);
                 
                 musicSource.clip = stream_music;
                 musicSource.Play();
                 Debug.Log("success");
                 
                 break;
            }
           
          }
 
      }
      ///<summary>
      ///是否是26個英文字母組成
      ///</summary>
      ///<param name = "strInput"></param>
      ///<returns></returns>
      public  bool isEnglish(string strInput){
          Regex reg = new Regex("^[A-Za-z]+$");
          if( reg.IsMatch(strInput)){
              return true;
          }
          else{
              return false;
          }
      }

    //     IEnumerator GetRequest(string uri) //拜訪頁面
    // {
    //     using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
    //     {
    //         // Request and wait for the desired page.
    //         yield return webRequest.SendWebRequest();

    //         string[] pages = uri.Split('/');
    //         int page = pages.Length - 1;

    //         switch (webRequest.result)
    //         {
    //             case UnityWebRequest.Result.ConnectionError:
    //             case UnityWebRequest.Result.DataProcessingError:
    //                 Debug.LogError(pages[page] + ": Error: " + webRequest.error);
    //                 break;
    //             case UnityWebRequest.Result.ProtocolError:
    //                 Debug.LogError(pages[page] + ": HTTP Error: " + webRequest.error);
    //                 break;
    //             case UnityWebRequest.Result.Success:
    //                 Debug.Log(pages[page] + ":\nReceived: " + webRequest.downloadHandler.text);
                   
    //                 break;
    //         }
    //     }
    // }


    //     //  private IEnumerator LoadAudio(string uri) //輸入網址下載音樂
    // {
    //      using (UnityWebRequest www = UnityWebRequestMultimedia.GetAudioClip(uri, AudioType.MPEG))//AudioType 類型有可能不對
    //      {
            
    //          yield return www.SendWebRequest();//等待載入完成
           
    //         switch (www.result)//結果
    //         {
    //         case UnityWebRequest.Result.ConnectionError://連接問題
    //              Debug.Log(www.error);
    //              break;
    //         case UnityWebRequest.Result.DataProcessingError:
    //             Debug.LogError( ": Error: " + www.error);
    //             break;
    //         case UnityWebRequest.Result.ProtocolError:
    //             Debug.LogError(": HTTP Error: " + www.error);
    //             break;
    //          case UnityWebRequest.Result.Success:    
    //              stream_music = DownloadHandlerAudioClip.GetContent(www);
                 
    //              musicSource.clip = stream_music;
    //              musicSource.Play();
    //              Debug.Log("success");
                 
    //              break;
    //         }
           
    //       }
 
    //  }
}
