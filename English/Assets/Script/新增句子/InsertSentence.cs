using System;
using System.Collections;
using System.Collections.Generic;
using Assets;
using UnityEngine;
using UnityEngine.UI;
public class InsertSentence : MonoBehaviour
{
    // Start is called before the first frame update
    public InputField 句子;
    public InputField 中文;
    public InputField 電影名;
    public Dropdown 類型;
    public InputField 句子時間;
    public Text 提示文字;
    public GameObject 審核;
     public void Start()
    {
        //Adds a listener to the main input field and invokes a method when the value changes.
    }


    public bool isChinese(char c)
    {
        return c >= 0x4E00 && c<= 0x9FA5;
    }
    // Invoked when the value of the text field changes
    //是否為中文
    public bool checkString(string str)
    {
        
        char[] ch = str.ToCharArray();
            if (str != null)
            {
                for (int i = 0; i < ch.Length; i++)
                {
                    if (isChinese(ch [i]))
                    {
                       return true;
                    }
                }
            }
            return false;

    }
    public void Click()
    {
        SqlAccess sql = new SqlAccess();
        
        if(句子.text == String.Empty ||中文.text == String.Empty || 電影名.text == String.Empty || 類型.options[類型.value].text == String.Empty || 句子時間.text == String.Empty){
            提示文字.text ="存在空資料";
            Debug.Log("null");
        }else if(checkString(中文.text)&&checkString(電影名.text)&&checkString(類型.options[類型.value].text)){
            sql.InsertInto("usercreate",new string [] {"sentence","chinese","moviename","movietype","time","uploadTime","create_id"},
            new string[] {句子.text,中文.text,電影名.text,類型.options[類型.value].text,句子時間.text,SqlAccess.DateTimeNormalize(DateTime.Now) ,PlayerPrefs.GetInt("ID").ToString()});
            Debug.Log("新增成功");
            審核.SetActive(true);
        }else{
            提示文字.text ="類型錯誤";
            Debug.Log("類型錯誤");
        }
        sql.Close();
        
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
