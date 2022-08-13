using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class profile : MonoBehaviour
{
    public InputField test;
    public Text show_id;
    public Text show_name;
    public Text Text;
    UnityWebRequest w_Texture;
    UnityWebRequest default_avatar_Texture;//取預設大頭貼
    UnityWebRequest avatar_Texture;//取用戶的大頭貼
    public RawImage Event;
    public RawImage avatar;


    IEnumerator Start()
    {
        
        //==============取用戶大頭貼==============
        int nInt = PlayerPrefs.GetInt("ID");
        string sString = PlayerPrefs.GetString("username");
        show_id.text = nInt.ToString() ;
        show_name.text = sString.ToString();
        Debug.Log("nInt: " + nInt.ToString() + ", sString: " + sString);
        avatar_Texture = UnityWebRequestTexture.GetTexture("http://english.tk888.me/avatar/" + nInt.ToString() + ".png");
        default_avatar_Texture = UnityWebRequestTexture.GetTexture("http://english.tk888.me/avatar/default.png");

        yield return avatar_Texture.SendWebRequest();
        yield return default_avatar_Texture.SendWebRequest();

        if (avatar_Texture.isNetworkError || avatar_Texture.isHttpError)
        {
            avatar.texture = DownloadHandlerTexture.GetContent(default_avatar_Texture);
            avatar.SetNativeSize();
            avatar.rectTransform.sizeDelta = new Vector2(300, 300);//設定頭貼大小300*300
            //Debug.Log(avatar_Texture.error);
        }
        else
        {
            avatar.texture = DownloadHandlerTexture.GetContent(avatar_Texture);
            avatar.SetNativeSize();
            avatar.rectTransform.sizeDelta = new Vector2(300, 300);
        }
        //==============取活動貼圖，可以更改(目前無用處)==============
        w_Texture = UnityWebRequestTexture.GetTexture("http://english.tk888.me/event.png");
        yield return w_Texture.SendWebRequest();

        if (w_Texture.isNetworkError || w_Texture.isHttpError)
        {
            Debug.Log(w_Texture.error);
        }
        else
        {
            Event.texture = DownloadHandlerTexture.GetContent(w_Texture);
            Event.SetNativeSize();
            Event.rectTransform.sizeDelta = new Vector2(945, 420);
        }
        // // Load();
        // //StartCoroutine(Download_File());
        checkLogin();
    }

    IEnumerator Download_File()
    {
        string url = "https://i.imgur.com/heCxlGL.jpg"; // 欲下載圖片的網路位址
        string savePath = "d:/unity.jpg"; // 圖片下載後的儲存路徑

        var uwr = new UnityWebRequest(url);
        uwr.method = UnityWebRequest.kHttpVerbGET;
        var dh = new DownloadHandlerFile(savePath);
        dh.removeFileOnAbort = true;
        uwr.downloadHandler = dh;
        yield return uwr.SendWebRequest();
        if (uwr.isNetworkError || uwr.isHttpError) { Debug.Log(uwr.error); }
        else { Debug.Log("檔案已下載到:" + savePath); }
    }

    public void Save()
    {
        PlayerPrefs.SetInt("ID", 1);
        PlayerPrefs.SetString("username", test.text);
        
    }
    public void logout()
    {
        PlayerPrefs.DeleteKey("ID");
        PlayerPrefs.DeleteKey("username");
        SceneManager.LoadScene("login");
    }
    public void Load()
    {
        int nInt = PlayerPrefs.GetInt("ID");
        string sString = PlayerPrefs.GetString("username");
        show_id.text= "ID:" + nInt.ToString() ;
        show_name.text="用戶名:" + sString.ToString();
        Debug.Log("nInt: " + nInt.ToString() + ", sString: " + sString);
    }
    public IEnumerator show_profile()
    {
        int nInt = PlayerPrefs.GetInt("ID");
        default_avatar_Texture = UnityWebRequestTexture.GetTexture("http://english.tk888.me/avatar/default.png");
        avatar_Texture = UnityWebRequestTexture.GetTexture("http://english.tk888.me/avatar/" + nInt.ToString() + ".png");
        yield return avatar_Texture.SendWebRequest();
        if (avatar_Texture.error == "404")
        {
            avatar.texture = DownloadHandlerTexture.GetContent(default_avatar_Texture);
            avatar.SetNativeSize();
            //Debug.Log(avatar_Texture.error);
        }
        else
        {
            avatar.texture = DownloadHandlerTexture.GetContent(avatar_Texture);
            avatar.SetNativeSize();
        }
    }
    public void checkLogin(){
        if( PlayerPrefs.GetInt("ID")==0 ){
            SceneManager.LoadScene("login");
        }
    }
}