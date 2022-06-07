
using System.Data;
using Assets;
using UnityEngine;
using UnityEngine.UI;

public class Search : MonoBehaviour
{
    // Start is called before the first frame update
    
    public Text showEnglish;
    public Text show_CH_pos;
    public GameObject sentence;
    public GameObject scrollbar;

    public GameObject dicitonaryshow;
    void Start()
    {
      

       
        string english=PlayerPrefs.GetString("Search");
        int searchtype = PlayerPrefs.GetInt("Searchtype");
        //搜尋字典
        if(searchtype== 1){
            //不顯示金句
            sentence.SetActive(false);
            scrollbar.SetActive(false);
            SqlAccess sql = new SqlAccess();
            DataSet ds=sql.QuerySet("Select english,chinese,pos from dictionary where english ='"+english+"'");
           

            if(sql.isDataSetNull(ds)!=true){
            SqlAccess.LogDatatable(ds);
            showEnglish.text = ds.Tables[0].Rows[0][0].ToString();
            show_CH_pos.text = ds.Tables[0].Rows[0][1].ToString()+"\n"+ds.Tables[0].Rows[0][2].ToString();
            }else{
                showEnglish.text = "找不到";
                show_CH_pos.text = "找不到";
            }
            sql.Close();
        //搜尋金句
        }else if(searchtype == 0){

            //不顯示字典
            dicitonaryshow.SetActive(false);
            GameObject 金句 = transform.GetChild(0).gameObject;
            GameObject g;
            SqlAccess sql = new SqlAccess();
            // DataSet ds=sql.QuerySet("SELECT ms.sentence, ms.chinese,m.ch_movie_name FROM moviesentence ms JOIN movie m ON ms.movie_id = m.id WHERE sentence LIKE'"+"%ach%"+"'"); 
           DataSet ds = sql.QuerySet("SELECT ms.sentence, ms.chinese,m.ch_movie_name FROM english.moviesentence ms JOIN english.movie m ON ms.movie_id = m.id WHERE sentence LIKE '"+"%ach%"+"'");
            if (sql.isDataSetNull(ds) != true)
            {
                if (ds != null)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        string Name = ds.Tables[0].Rows[i][2].ToString().Trim();
                        string En = ds.Tables[0].Rows[i][0].ToString().Trim();
                        string Ch = ds.Tables[0].Rows[i][1].ToString().Trim();
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
   
   
}
