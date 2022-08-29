using Assets;
using System.Data;
using UnityEngine;
using UnityEngine.UI;

public class Knowledge : MonoBehaviour
{
    public Text textshow;
    public Text textyes;
    public InputField InputFieldans;

    public static int intNowRandomNum = 0;
    // Start is called before the first frame update
    void Start()
    {
    } 
   
    public void Show()
    {
        System.Random random = new System.Random();
        intNowRandomNum = 0;
        intNowRandomNum = random.Next(30);
        SqlAccess sql = new SqlAccess();
        DataSet ds = sql.QuerySet("SELECT sentence FROM english.moviesentence  where id='" + intNowRandomNum + "'");
        DataSet dsa = sql.QuerySet("SELECT chinese FROM english.moviesentence  where id='" + intNowRandomNum + "'");
        DataSet dsb = sql.QuerySet("SELECT special_text FROM english.moviesentence  where id='" + intNowRandomNum + "'");
        SqlAccess.LogDatatable(ds);
        SqlAccess.LogDatatable(dsa);
        SqlAccess.LogDatatable(dsb);
        string sg= dsa.Tables[0].Rows[0][0].ToString();
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
        textshow.text = k+sg+ intNowRandomNum;
        
    }
    public void Ans()
    {       
        string enter = InputFieldans.text;
        SqlAccess sql = new SqlAccess();
        DataSet ds = sql.QuerySet("SELECT special_text FROM english.moviesentence  where id='" + intNowRandomNum + "'");
        SqlAccess.LogDatatable(ds);
        string single = ds.Tables[0].Rows[0][0].ToString();
        if (enter == single) { textyes.text = "®¥³ßµª¹ï"; }
        else textyes.text = "µª¿ù¤F";

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
