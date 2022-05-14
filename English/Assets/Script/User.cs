using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using Assets;
using System;
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
    
    public void Login()
    {
        sql = new SqlAccess();
        if (username.text != null && password.text != null)
        {
            DataSet ds = sql.QuerySet("Select id from user where username ='" + username.text + "' and password ='" + password.text + "'");
            DataTable table = ds.Tables[0];
            foreach (DataRow dataRow in table.Rows)
            {
                foreach (DataColumn dataColumn in table.Columns)
                {
                    Debug.Log("登入ID:" + dataRow[dataColumn]);
                    int userid=Int32.Parse(dataRow[dataColumn].ToString());
                    PlayerPrefs.SetInt("ID", userid);
                    PlayerPrefs.SetString("username", username.text);
                }
            }
            if (table.Rows.Count > 0)
            {

                loginMsg.text = "歡迎" + username.text + "登入";
                SceneManager.LoadScene("logintest");
            }
            else
            {
                loginMsg.text = "帳號或密碼錯誤";
            }
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
