using UnityEngine.SceneManagement;
using UnityEngine;
using Assets;
using System.Security.Cryptography;
using System;
using UnityEngine.UI;
using System.Text;
using System.Data;

public class User : MonoBehaviour
{
    public InputField username;
    public InputField password;
    public InputField email;
    public Text loginMsg;
    SqlAccess sql;
    public GameObject forgotPassword;
    void Start()
    {
        checkLogin();
        forgotPassword.SetActive(false);
    }
    public void register()
    {
        //密碼加密
        SHA256 sha256 = new SHA256CryptoServiceProvider();
        string resultSha256 = Convert.ToBase64String(sha256.ComputeHash(Encoding.Default.GetBytes(password.text)));

        string regDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        sql = new SqlAccess();
        DataSet ds = sql.QuerySet("Select * from user where username ='" + username.text + "'");
        DataTable table = ds.Tables[0];
        if (table.Rows.Count == 0)
        {
            DataSet ds2 = sql.QuerySet("Select * from user where email ='" + email.text + "'");
            DataTable table2 = ds2.Tables[0];
            if (table2.Rows.Count == 0)
            {
                if (isSpace(username) && isSpace(password) && isSpace(email))
                {
                    sql.InsertInto("user", new string[] { "username", "password", "email", "createTime" }, new string[] { username.text, resultSha256, email.text, regDate });
                    loginMsg.text = "註冊成功";
                }
                else
                {
                    loginMsg.text = "帳密不能為空值";
                }
            }
            else
            {
                loginMsg.text = "此Email已經使用過，請換一個!";
            }
        }
        else
        {
            loginMsg.text = "此帳號已經使用過，請換一個!";
        }

        sql.Close();
    }

    public void Login()
    {
        SHA256 sha256 = new SHA256CryptoServiceProvider();
        string resultSha256 = Convert.ToBase64String(sha256.ComputeHash(Encoding.Default.GetBytes(password.text)));

        sql = new SqlAccess();
        if(username.text == "manager3467" && password.text == "123"){
            SceneManager.LoadScene("管理者頁面");
        }else{
             if (username.text != null && password.text != null)
            {
                DataSet ds = sql.QuerySet("Select id from user where username ='" + username.text + "' and password ='" + resultSha256 + "'");
                DataTable table = ds.Tables[0];
                foreach (DataRow dataRow in table.Rows)
                {
                    foreach (DataColumn dataColumn in table.Columns)
                    {
                        Debug.Log("登入ID:" + dataRow[dataColumn]);
                        int userid = Int32.Parse(dataRow[dataColumn].ToString());
                        PlayerPrefs.SetInt("ID", userid);
                        PlayerPrefs.SetString("username", username.text);
                    }
                }
                if (table.Rows.Count > 0)
                {

                    loginMsg.text = "歡迎" + username.text + "登入";
                    SceneManager.LoadScene("首頁");
                }
                else
                {
                    loginMsg.text = "帳號或密碼錯誤";
                    forgotPassword.SetActive(true);
                }
            }
            sql.Close();
        }
       
    }

    public static bool isLogin()
    {
        if (PlayerPrefs.GetInt("ID") != 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void forgotPwd()
    {
        SceneManager.LoadScene("忘記密碼");
    }
    ///<summary>
    /// 輸入的TextField 是否為空 回傳bool
    ///</summary>
    ///<param name = "inputField">inputField</param>
    public bool isSpace(InputField inputField)
    {
        if (inputField.text.Length != 0)
        {
            return true;
        }
        return false;
    }
    //檢查登入狀態
    private void checkLogin()
    {
        if (PlayerPrefs.GetInt("ID") != 0 && PlayerPrefs.GetString("username") != null)
        {
            SceneManager.LoadScene("首頁");
        }
        else
        {
            loginMsg.text = "請先登入";
        }
        // int nInt = PlayerPrefs.GetInt("ID");
        // string sString = PlayerPrefs.GetString("username");
    }

}
