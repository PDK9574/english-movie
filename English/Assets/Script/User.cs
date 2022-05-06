using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets;
using UnityEngine.UI;
using System.Data;

public class User: MonoBehaviour
{
    public InputField username;
    public InputField password;
    public Text loginMsg;
    SqlAccess sql;
    public void newUser(){
        sql= new SqlAccess();
        if(isSpace(username)&&isSpace(password)){
            DataSet ds=sql.InsertInto("user",new string[]{"username","password"},new string[]{username.text,password.text});          
            loginMsg.text="註冊成功";
        }else{
            loginMsg.text="帳密不能為空值";
        }
        sql.Close();
    }
    public void Login(){
        sql= new SqlAccess();
        int userid = 0;
        if(isSpace(username)&&isSpace(password)){
            // DataSet ds=sql.QuerySet("Select id from user where name ='" + username.text + "' and password ='" + password.text + "'");
            DataSet ds = sql.Select("user",new string[] {"id"},new string[] {"username","password"},new string[] {"=","="},new string [] {username.text,password.text});
            DataTable table = ds.Tables[0];
	        foreach (DataRow dataRow in table.Rows)
	        {
	            foreach (DataColumn dataColumn in table.Columns)
	            {
	                Debug.Log(dataRow[dataColumn]);
                    userid = (int)dataRow[dataColumn];
	            }
	        }
            if(table.Rows.Count>0){
                PlayerPrefs.SetInt("userid",userid);
                loginMsg.text ="登入成功";
               
            }else{
                loginMsg.text ="帳號或密碼錯誤";
            }
        }else{
             loginMsg.text ="帳號或密碼不能為空";
        }
        sql.Close();
    }
    public void isLogin(){
        if(PlayerPrefs.GetInt("userid")!=0){
         Debug.Log(PlayerPrefs.GetInt("userid"));
        }else{
             Debug.Log("你尚未登入");
        }
    }
    ///<summary>
    /// 輸入的TextField 是否為空 回傳bool
    ///</summary>
    ///<param name = "inputField">inputField</param>
    public bool isSpace(InputField inputField){
        if(inputField.text.Length !=0){
            return true;
        }
            return false;
    }
    
     
}
