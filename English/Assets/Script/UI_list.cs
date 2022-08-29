using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System;
using Assets;

//監聽按鈕
public static class ButtonExtension
{
    public static void AddEventListener<T>(this Button button, T param, Action<T> OnClick)
    {
        button.onClick.AddListener(delegate ()
        {
            OnClick(param);
        });
    }
}
public class UI_list : MonoBehaviour
{
    public int movietype_id;
    public Text movieDetail;
    public int movieid;

    // Start is called before the first frame update
    void Start()
    {
        //顯示金句列表
        GameObject 金句 = transform.GetChild(0).gameObject;
        GameObject g;
        SqlAccess sql = new SqlAccess();
        DataSet ds = sql.QuerySet("SELECT ch_movie_name,sentence,chinese,b.id FROM english.moviesentence as a join english.movie as b on a.movie_id=b.id where movietype_id='" + movietype_id + "'");
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
                    g.transform.GetChild(2).GetComponent<Text>().text = "《" + Name + "》";
                    g.GetComponent<Button>().AddEventListener(i, Detail);
                }
                Destroy(金句);
            }
        }
    }
    public void Detail(int itemIndex)
   {
        SqlAccess sql = new SqlAccess();

        DataSet ds = sql.QuerySet("SELECT ch_movie_name,sentence,chinese,a.id  FROM english.moviesentence as a join english.movie as b on a.movie_id=b.id where movietype_id='" + movietype_id + "'");

        movieDetail.text = ds.Tables[0].Rows[itemIndex][1].ToString() + "\n\n" + ds.Tables[0].Rows[itemIndex][2].ToString() + "\n\n《" + ds.Tables[0].Rows[itemIndex][0].ToString() + "》";
        movieid = Convert.ToInt32(ds.Tables[0].Rows[itemIndex][3]);
        //紀錄觀看次數
        DataSet ds1=sql.QuerySet("select count(*) from hotmv where movieid ='"+movieid+"'");
        if(Convert.ToInt32(ds1.Tables[0].Rows[0][0])>0){
           sql.QuerySet("UPDATE hotmv SET views=views+1 WHERE movieid='"+movieid+"'");
            Debug.Log("電影id"+movieid+"資料觀看次數新增");
        }else{
            sql.QuerySet("INSERT INTO `english`.`hotmv` (`views`,`movieid`, `lastupdateTime`) VALUES ('1','"+movieid+"', '2022-06-06 11:41:37');");
            Debug.Log("電影id"+movieid+"資料觀看次數新增");
        }
     

    }
    /// <summary>
    /// 收藏功能
    /// </summary>
    public void Favorite(){
        SqlAccess sql = new SqlAccess();
        Debug.Log("現在頁面電影id"+movieid);
        Debug.Log("現在頁面使用者id"+PlayerPrefs.GetInt("ID"));
        DataSet ds1=sql.QuerySet("select count(*) from favorite where userid ='"+PlayerPrefs.GetInt("ID")+"' and favoriteid = '"+movieid+"'");
        if(User.isLogin()){
            if(Convert.ToInt32(ds1.Tables[0].Rows[0][0])>0){
                Debug.Log("你已收藏");
            }else{
                DataSet ds = sql.QuerySet("insert into favorite(userid,favoriteid) VALUES ("+PlayerPrefs.GetInt("ID")+","+movieid+")");
                Debug.Log("收藏成功");
            }
        }
    }


}