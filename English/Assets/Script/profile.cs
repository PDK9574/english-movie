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

void Start()
    {
        checkLogin();
        int nInt = PlayerPrefs.GetInt("ID");
        string sString = PlayerPrefs.GetString("username");
        show_id.text = nInt.ToString() ;
        show_name.text = sString.ToString();
        Debug.Log("nInt: " + nInt.ToString() + ", sString: " + sString);
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
    public void load_changePwd_Page(){
        SceneManager.LoadScene("變更密碼");
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

public void ContactMe(){
    Application.OpenURL("mailto:brian2003.tw@gmail.com");
 }

    public void checkLogin(){
        if( PlayerPrefs.GetInt("ID")==0 ){
            SceneManager.LoadScene("login");
        }
    }
}