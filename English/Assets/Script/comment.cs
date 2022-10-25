using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets;
using UnityEngine.UI;
using System.Data;
using System;

public class comment : MonoBehaviour
{
    public InputField messagebox;
    public Text showmessage;
    SqlAccess sql;

    // Start is called before the first frame update
    void Start()
    {
        sentence(); 
    }

    // Update is called once per frame
    public void send_sentence()
    {
        string Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        sql = new SqlAccess();
        sql.InsertInto("comment", new string[] { "text", "lastupdateTime", "authorid","c_type" }, new string[] { messagebox.text, Date, PlayerPrefs.GetInt("ID").ToString(),"sentence" });
        sentence();
    }
    public void send_other()
    {
        string Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        sql = new SqlAccess();
        sql.InsertInto("comment", new string[] { "text", "lastupdateTime", "authorid","c_type"  }, new string[] { messagebox.text, Date, PlayerPrefs.GetInt("ID").ToString(),"other" });
        other();
    }

    public void sentence() {
        sql = new SqlAccess();
        DataSet ds = sql.QuerySet("Select text,authorid,lastupdateTime from english.comment where c_type='sentence'");
        DataTable table = ds.Tables[0];
        showmessage.text = "";
        for (int j = 0; j < ds.Tables[0].Rows.Count; j++)
        {
            // string id = table.Rows[j][0].ToString();
            string comment = table.Rows[j][0].ToString();
            string author = table.Rows[j][1].ToString();
            string date = table.Rows[j][2].ToString();

            DateTime dt = new DateTime();
            DateTime.TryParse(date, out dt);
            date = dt.ToString("yyyy/MM/dd");
            showmessage.text += "用戶 "+author + " 說 " + comment + " (" + date + ")\n";
        }
    }
    public void other(){
        sql = new SqlAccess();
        DataSet ds = sql.QuerySet("Select text,authorid,lastupdateTime from english.comment where c_type='other'");
        DataTable table = ds.Tables[0];
        showmessage.text = "";
        for (int j = 0; j < ds.Tables[0].Rows.Count; j++)
        {
            // string id = table.Rows[j][0].ToString();
            string comment = table.Rows[j][0].ToString();
            string author = table.Rows[j][1].ToString();
            string date = table.Rows[j][2].ToString();

            DateTime dt = new DateTime();
            DateTime.TryParse(date, out dt);
            date = dt.ToString("yyyy/MM/dd");
            showmessage.text += "用戶 "+author + " 說 " + comment + " (" + date + ")\n";
        }
    }

}
