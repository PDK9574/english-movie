
using System.Data;
using Assets;
using UnityEngine;
using UnityEngine.UI;

public class Search : MonoBehaviour
{
    // Start is called before the first frame update
    
    public Text showEnglish;
    public Text show_CH_pos;
    void Start()
    {
        SqlAccess sql = new SqlAccess();
        string english=PlayerPrefs.GetString("Search");
        DataSet ds=sql.QuerySet("Select english,chinese,pos from dictionary where english ='"+english+"'");
        if(sql.isDataSetNull(ds)!=true){
        SqlAccess.LogDatatable(ds);
        showEnglish.text = ds.Tables[0].Rows[0][0].ToString();
        show_CH_pos.text = ds.Tables[0].Rows[0][1].ToString()+"\n"+ds.Tables[0].Rows[0][2].ToString();
        }else{
            showEnglish.text = "找不到";
            show_CH_pos.text = "找不到";
        }
        
    }
   
   
}
