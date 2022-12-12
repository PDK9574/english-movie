using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using System.Data;
using Assets;

public class Knowledge : MonoBehaviour
{
    public Text textrank;
    public Text textshow;
    public InputField InputFieldans;
    public GameObject rawimage;
    public GameObject rawimage2;

    public static int intNowRandomNum = 0;
    // Start is called before the first frame update
    void Start()
    {   
        leaderboard();
        Show();
    }

    public void Show()
    {
        System.Random random = new System.Random();
        intNowRandomNum = 0;
        intNowRandomNum = random.Next(10);
        SqlAccess sql = new SqlAccess();
        DataSet ds = sql.QuerySet("SELECT sentence FROM english.moviesentence  where id='" + intNowRandomNum + "'");
        DataSet dsa = sql.QuerySet("SELECT chinese FROM english.moviesentence  where id='" + intNowRandomNum + "'");
        DataSet dsb = sql.QuerySet("SELECT special_text FROM english.moviesentence  where id='" + intNowRandomNum + "'");
        SqlAccess.LogDatatable(ds);
        SqlAccess.LogDatatable(dsa);
        SqlAccess.LogDatatable(dsb);
        string sg = dsa.Tables[0].Rows[0][0].ToString();
        string st = ds.Tables[0].Rows[0][0].ToString();
        string sp = dsb.Tables[0].Rows[0][0].ToString();
        string[] single = st.Split(' ');
        string k = " ";
        for (int s = 0; s < single.Length; s++)
        {
            {
                if (sp == single[s])
                {
                    k += "____";
                }
                else
                    k += single[s] + " ";
            }
        }
        textshow.text = k + sg;
        rawimage2.SetActive(false);
        rawimage.SetActive(false);
        InputFieldans.text="";
        Debug.Log(intNowRandomNum);

    }
    public void Ans()
    {

        string enter = InputFieldans.text;
        SqlAccess sql = new SqlAccess();
        DataSet ds = sql.QuerySet("SELECT special_text FROM english.moviesentence  where id='" + intNowRandomNum + "'");
        SqlAccess.LogDatatable(ds);
        string single = ds.Tables[0].Rows[0][0].ToString();
        {
            if (enter == single)
            {
                DataSet ds2 = sql.QuerySet("UPDATE user SET point=point+1 WHERE id='" + PlayerPrefs.GetInt("ID") + "'");
                rawimage.SetActive(true);
                rawimage2.SetActive(false);

            }
            else {
                rawimage2.SetActive(true);
                rawimage.SetActive(false);
            }
        }
    }
    public void enter()
    {
        SqlAccess sql = new SqlAccess();
        DataSet ds4 = sql.QuerySet("SELECT username,point FROM english.user  where point != 0 order by point desc limit 3 ");
        SqlAccess.LogDatatable(ds4);
        int point;
        String name;
        textrank.text = "";
        for (int a = 0; a < ds4.Tables[0].Rows.Count; a++)
        {
            string poin = " ";
            poin = ds4.Tables[0].Rows[a][1].ToString();
            point = Int32.Parse(poin);
            name = ds4.Tables[0].Rows[a][0].ToString();
            textrank.text += "用戶" + name + "有" + point + "點\n";
        }
    }
    // Update is called once per frame
    public void leaderboard(){
        textrank.text="";
        SqlAccess sql = new SqlAccess();
        DataSet ds4 = sql.QuerySet("SELECT username,point FROM english.user  where point != 0 order by point desc limit 5");
        SqlAccess.LogDatatable(ds4);
        int point;
        String name;
        for (int a = 0; a < ds4.Tables[0].Rows.Count; a++)
        {
            string poin=" ";
            poin = ds4.Tables[0].Rows[a][1].ToString();
            point = Int32.Parse(poin);
            name = ds4.Tables[0].Rows[a][0].ToString();
            textrank.text+="用戶" + name + "有" + point + "點\n";
        }
    }
}
