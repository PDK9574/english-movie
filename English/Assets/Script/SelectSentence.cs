using System.Collections;
using System.Collections.Generic;
using System.Data;
using Assets;
using UnityEngine;
using UnityEngine.UI;

public class SelectSentence : MonoBehaviour
{
    public Text showText;
    // Start is called before the first frame update
    void Start()
    {
      
    }
    public void Show(){
        SqlAccess sql = new SqlAccess();
        DataSet ds=sql.QuerySet("SELECT sentence FROM english.moviesentence  where id='"+"8"+"'");
        SqlAccess.LogDatatable(ds);
        showText.text=ds.Tables[0].Rows[0][0].ToString();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
