using System.Collections;
using System.Collections.Generic;
using System.Data;
using Assets;
using UnityEngine;
using UnityEngine.UI;


public class Chart : MonoBehaviour
{
    // Start is called before the first frame update
    public Text shtext;
    public GameObject 滑動方塊;
    void Start()
    {
    
    }

    public void Click(){
        SqlAccess sql = new SqlAccess();
        DataSet ds=sql.QuerySet("SELECT en_movie_name,views " +
        "FROM english.hotmv hm join movie m "+
        "on hm.movieid = m.id order by views desc");

        shtext.text = "";
        滑動方塊.SetActive(true);
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            shtext.text+="電影名:" +ds.Tables[0].Rows[i][0] +"有"+ds.Tables[0].Rows[i][1]  +"次觀看數\n";
        }
        // var chart = gameObject.GetComponent<BarChart>();
        // if (chart == null)
        // {
        //     chart = gameObject.AddComponent<BarChart>();
        //     chart.Init();
        // } 
    }
    // Update is called once per frame
    public void Click2(){
        SqlAccess sql = new SqlAccess();
        DataSet ds=sql.QuerySet("SELECT typename,views " +
        "FROM english.hotmvtype hm join movietype m "+
        "on hm.typeid = m.id order by views desc");
        shtext.text = "";
        滑動方塊.SetActive(true);
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            shtext.text+="電影類型名:" +ds.Tables[0].Rows[i][0] + "有"+ds.Tables[0].Rows[i][1]  +"次觀看數\n";
        }
        
    }
}
