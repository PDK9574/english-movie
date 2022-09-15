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
    public InputField 類型;
    public InputField 句子時間;
    public void Click()
    {
        SqlAccess sql = new SqlAccess();
        if(句子.text == String.Empty ||中文.text == String.Empty || 電影名.text == String.Empty || 類型.text == String.Empty || 句子時間.text == String.Empty){
            Debug.Log("null");
        }else{
        sql.InsertInto("usercreate",new string [] {"sentence","chinese","moviename","movietype","time","uploadTime","create_id"},
        new string[] {句子.text,中文.text,電影名.text,類型.text,句子時間.text,SqlAccess.DateTimeNormalize(DateTime.Now) ,PlayerPrefs.GetInt("ID").ToString()});
		Debug.Log("新增成功");
        }
        sql.Close();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
