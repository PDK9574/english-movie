using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using System.Security.Cryptography;
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

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("HELLO");
        
    }
    public void Reset_Password()
    {
        string default_password="6c7nGrky/ehjM40Ivk3p3+OeoEm9r7NCzmWexUULaa4=";//預設為abcd1234
        sql = new SqlAccess();
        DataSet ds = sql.QuerySet("Select * from english.user where email='" + email.text + "'");
        DataTable table = ds.Tables[0];
        if (table.Rows.Count != 0)
        {
            sql.UpdateInto("english.user", new string[] { "password" }, new string[] { default_password }, "email", email.text);
            EmailAction();
            Debug.Log("已重設密碼");           
        }
        else
        {
            Debug.Log("找不到此信箱!");
            infoMsg.text="找不到此信箱!";
        }

        sql.Close();
    }
    public void EmailAction()   //寄信
    {
        string regDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        MailMessage mailMessage = new MailMessage();
        SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
        Attachment attachment = new Attachment(@"Assets/image/Capoo.gif");    //指定要夾帶的物件路徑

        mailMessage.From = new MailAddress("brian2003.tw@gmail.com", "MovieFun", System.Text.Encoding.UTF8);
        mailMessage.To.Add(email.text);
        mailMessage.Subject = "MovieFun系統";
        mailMessage.Body = "已重設密碼，預設為abcd1234" + "\n" + regDate;
        mailMessage.SubjectEncoding = System.Text.Encoding.UTF8;
        mailMessage.BodyEncoding = System.Text.Encoding.UTF8;
        // mailMessage.Attachments.Add(attachment);
        mailMessage.Priority = MailPriority.High;

        smtpClient.Port = 587;
        smtpClient.Credentials = new System.Net.NetworkCredential("brian2003.tw@gmail.com", "khgkwxqkqjnzanxz") as ICredentialsByHost;
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
        infoMsg.text="已重設密碼，請至信箱查看!";
    }
    public void backMenu(){
        SceneManager.LoadScene("首頁");
    }
}
