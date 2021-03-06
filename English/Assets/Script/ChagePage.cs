using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChagePage : MonoBehaviour
{
  
    public string pageName;
    public InputField searchField;
    public Dropdown searchtype;
    // public SceneFaded sceneFaded;

    // public void changePageWithAni(){
    //    sceneFaded.FadedTo(pageName);

    // }
    public void changePage(){
        SceneManager.LoadScene(pageName);
    }
    /// <summary>
    /// 換頁面同時設定參數
    /// </summary>
    public void chagePageAndSet(){
        PlayerPrefs.SetString("Search",searchField.text);
        PlayerPrefs.SetInt("Searchtype",searchtype.value);
        SceneManager.LoadScene(pageName);
    }

}
