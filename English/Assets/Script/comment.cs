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
        sql = new SqlAccess();
        DataSet ds = sql.QuerySet("Select id,text,authorid,lastupdateTime from comment");
        DataTable table = ds.Tables[0];
        showmessage.text = "";
        for (int j = 0; j < ds.Tables[0].Rows.Count; j++)
        {
            string id = table.Rows[j][0].ToString();
            string comment = table.Rows[j][1].ToString();
            string author = table.Rows[j][2].ToString();
            string date = table.Rows[j][3].ToString();

            DateTime dt = new DateTime();
            DateTime.TryParse(date, out dt);
            date = dt.ToString("yyyy/MM/dd");
            showmessage.text += id + ".用戶" + author + " 說 " + comment + " (" + date + ")\n";
        }

        
    }

    // Update is called once per frame
    public void send()
    {
        string Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        sql = new SqlAccess();
        sql.InsertInto("comment", new string[] { "text", "lastupdateTime", "authorid" }, new string[] { messagebox.text, Date, PlayerPrefs.GetInt("ID").ToString() });
        Start();
    }

}
