using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class EnglishSound : MonoBehaviour
{
    public AudioSource musicSource;
    public AudioClip stream_music;
    public Text movieDetail;


    //按按鈕
    // public void RequestWeb()
    // {
    //     // A correct website page.
    //     StartCoroutine( LoadAudio("https://dict.youdao.com/dictvoice?audio=apple&type=1"));

    //     // A non-existing page.
    //     // StartCoroutine(GetRequest("https://error.html"));
    // }

    public void btnSound()
    {
        StartCoroutine(downloadVoice(movieDetail.text.ToString()));
    }
    public void GetVoice()
    {
        string englishText = PlayerPrefs.GetString("Search");
        // if(isEnglish(inputField.text)){
        StartCoroutine(downloadVoice(englishText));
        // }else{
        //     Debug.Log("請輸入英文");
        // }
    }



    private IEnumerator downloadVoice(string englishText)
    {
        string url = "https://dict.youdao.com/dictvoice?audio=" + englishText + "&type=2";
        using (UnityWebRequest www = UnityWebRequestMultimedia.GetAudioClip(url, AudioType.MPEG))//AudioType 類型有可能不對
        {

            yield return www.SendWebRequest();//等待載入完成

            switch (www.result)//結果
            {
                case UnityWebRequest.Result.ConnectionError://連接問題
                    Debug.Log(www.error);
                    break;
                case UnityWebRequest.Result.DataProcessingError:
                    Debug.LogError(": Error: " + www.error);
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
    public bool isEnglish(string strInput)
    {
        Regex reg = new Regex("^[A-Za-z]+$");
        if (reg.IsMatch(strInput))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
