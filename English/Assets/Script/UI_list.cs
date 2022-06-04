using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UI;
using System;
using Assets;

public class UI_list : MonoBehaviour
{
    public int movietype_id;

    // Start is called before the first frame update
    void Start()
    {
        //顯示金句列表
        GameObject 金句 = transform.GetChild(0).gameObject;
        GameObject g;
        SqlAccess sql = new SqlAccess();
        DataSet ds = sql.QuerySet("SELECT ch_movie_name,sentence,chinese FROM english.moviesentence as a join english.movie as b on a.movie_id=b.id where movietype_id='" + movietype_id + "'");
        if (sql.isDataSetNull(ds) != true)
        {
            if (ds != null)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    string Name = ds.Tables[0].Rows[i][0].ToString().Trim();
                    string En = ds.Tables[0].Rows[i][1].ToString().Trim();
                    string Ch = ds.Tables[0].Rows[i][2].ToString().Trim();
                    g = Instantiate(金句, transform);
                    g.transform.GetChild(0).GetComponent<Text>().text = En;
                    g.transform.GetChild(1).GetComponent<Text>().text = Ch;
                    g.transform.GetChild(2).GetComponent<Text>().text = "《"+Name+"》";
                }
                Destroy(金句);
            }
        }
    }
}
