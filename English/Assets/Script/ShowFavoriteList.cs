using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets;
using System.Data;
using UnityEngine.UI;

public class ShowFavoriteList : MonoBehaviour
{
    public void Start(){
        GameObject 收藏句子 = transform.GetChild(0).gameObject;
        GameObject g;
        SqlAccess sql = new SqlAccess();
        DataSet ds = sql.QuerySet("SELECT ms.sentence,ms.chinese,m.ch_movie_name "+
        "FROM english.moviesentence ms "+
        "join english.favorite f on ms.id = f.favoriteid "+
        "join english.movie m on m.id = ms.movie_id  where userid = '"+PlayerPrefs.GetInt("ID")+"'");
        if (sql.isDataSetNull(ds) != true)
        {
            if (ds != null)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    string 英文句子 = ds.Tables[0].Rows[i][0].ToString().Trim();
                    string 中文 = ds.Tables[0].Rows[i][1].ToString().Trim();
                    string 分享者 = ds.Tables[0].Rows[i][2].ToString().Trim();
                    g = Instantiate(收藏句子, transform);
                    g.transform.GetChild(0).GetComponent<Text>().text = 英文句子 ;
                    g.transform.GetChild(1).GetComponent<Text>().text = 中文;
                    g.transform.GetChild(2).GetComponent<Text>().text ="《"+ 分享者+ "》";
                 
                }
                Destroy(收藏句子);
            }
        }
        sql.Close();
    }
    // 收藏句子顯示
    public void Show(){
   
    }

}
