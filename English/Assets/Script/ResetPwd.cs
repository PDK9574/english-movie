using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System.Security.Cryptography;
using UnityEngine.SceneManagement;
// using System.Security.Cryptography;
using Assets;
using System;
using UnityEngine.UI;
using System.Net;
using System.Text;
using System.Net.Mail;
using System.Data;

public class ResetPwd : MonoBehaviour
{
    SqlAccess sql;
    public Text infoMsg;
    public InputField email;
    public InputField name;
    public InputField old_pwd;
    public InputField new_pwd1;
    public InputField new_pwd2;

    // Start is called before the first frame update

    void Start()
    {
        Debug.Log("HELLO");

    }
    public void change_Password()//變更密碼
    {
        int nInt = PlayerPrefs.GetInt("ID");
        SHA256 sha256 = new SHA256CryptoServiceProvider();
        string old_pwdSha256 = Convert.ToBase64String(sha256.ComputeHash(Encoding.Default.GetBytes(old_pwd.text)));
        string new_pwdSha256 = Convert.ToBase64String(sha256.ComputeHash(Encoding.Default.GetBytes(new_pwd1.text)));
        sql = new SqlAccess();

        if (old_pwd.text != null)
        {
            DataSet ds = sql.QuerySet("Select * from user where id ='" + nInt + "' and password ='" + old_pwdSha256 + "'");
            DataTable table = ds.Tables[0];
            Debug.Log(nInt);
            Debug.Log(old_pwdSha256);
            Debug.Log(table.Rows.Count);
            if (table.Rows.Count > 0)
            {
                if (new_pwd1.text == new_pwd2.text)
                {
                    sql.UpdateInto("english.user", new string[] { "password" }, new string[] { new_pwdSha256 }, "id", nInt.ToString());
                    infoMsg.text = "變更密碼成功";

                    PlayerPrefs.DeleteKey("ID");
                    PlayerPrefs.DeleteKey("username");
                    SceneManager.LoadScene("login");
                }
                else
                {
                    infoMsg.text = "新密碼不一致!";
                }
            }
            else
            {
                infoMsg.text = "舊密碼錯誤";
            }
        }
        sql.Close();

    }
    public void Reset_Password()//重設密碼
    {
        string default_password = "6c7nGrky/ehjM40Ivk3p3+OeoEm9r7NCzmWexUULaa4=";//預設為abcd1234
        sql = new SqlAccess();
        DataSet ds = sql.QuerySet("Select * from english.user where email='" + email.text + "' and username='"+name.text+"'");
        DataTable table = ds.Tables[0];
        if (table.Rows.Count != 0)
        {
            sql.UpdateInto("english.user", new string[] { "password" }, new string[] { default_password }, "email", email.text);
            EmailAction("重設密碼通知","親愛的使用者"+name.text+"您好，已為您重設密碼，預設為abcd1234，成功登入後請盡速更換密碼以保護帳戶安全");
            Debug.Log("已重設密碼");
        }
        else
        {
            Debug.Log("找不到此信箱!");
            infoMsg.text = "找不到此信箱!";
        }

        sql.Close();
    }
    public void EmailAction(string title,string body)   //寄信
    {
        string regDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        MailMessage mailMessage = new MailMessage();
        SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
        Attachment attachment = new Attachment(@"Assets/image/Capoo.gif");    //指定要夾帶的物件路徑

        mailMessage.From = new MailAddress("brian2003.tw@gmail.com", "MovieFun系統", System.Text.Encoding.UTF8);
        mailMessage.To.Add(email.text);
        mailMessage.Subject = title;
        mailMessage.Body = body + "\n\n" + regDate;
        mailMessage.SubjectEncoding = System.Text.Encoding.UTF8;
        mailMessage.BodyEncoding = System.Text.Encoding.UTF8;
        // mailMessage.Attachments.Add(attachment);
        mailMessage.Priority = MailPriority.High;

        smtpClient.Port = 587;
        smtpClient.Credentials = new System.Net.NetworkCredential("brian2003.tw@gmail.com", "iwbzlaqwsldvqref") as ICredentialsByHost;
        smtpClient.EnableSsl = true;

        ServicePointManager.ServerCertificateValidationCallback = delegate (object sender,
                                        System.Security.Cryptography.X509Certificates.X509Certificate certificate,
                                        System.Security.Cryptography.X509Certificates.X509Chain chain,
                                        System.Net.Security.SslPolicyErrors sslPolicyErrors)
                                        {
                                            return true;
                                        };

        smtpClient.Send(mailMessage);

        Debug.Log("寄信完成！！");
        infoMsg.text = "已重設密碼，請至信箱查看!";
    }
    public void backMenu()
    {
        SceneManager.LoadScene("首頁");
    }
}
