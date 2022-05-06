using Assets;
using UnityEngine;

using System.Data;
using  UnityEngine.UI;

public class Test : MonoBehaviour
{
    public Text text;
	
	void Start () {
        SqlAccess sql = new SqlAccess();
		sql.CreateTableAutoID("testtest",new string[] {"id","name","password"},new string[] {"int","text","text"});
       // sql.CreateTableAutoID("jl", new string[] { "id", "name", "qq", "email", "blog" }, new string[] { "int", "text", "text", "text", "text" });
        //sql.InsertInto("jl", new string[] { "name", "qq", "email", "blog" }, new string[] { "jianglei", "289187120", "[email protected]", "jianglei.com" });
        //  sql.InsertInto("jl", new string[] { "name", "qq", "email", "blog" }, new string[] { "lizhih", "34546546", "[email protected]", "lizhih.com" });
	   // sql.Delete("jl", new string[] {"id"}, new string[] {"2"});
       	DataSet ds=sql.QuerySet("Select *  from user");
		
		text = GameObject.Find("TestText").GetComponent<Text>();
		
	    if (ds!=null)
	    {
	        DataTable table = ds.Tables[0];
			// 找值
			// string name = table.Rows[0][0].ToString();
			// Debug.Log(name);

	

			//印出 datatable 
			// for (int i=0; i<ds.Tables[0].Rows.Count; i++) {
			// 	for(int j=0;j<ds.Tables[0].Columns.Count;j++)
			// 	{				
			// 		str+=ds.Tables[0].Rows[i][j].ToString().Trim()+"    ";
			// 		if(j==ds.Tables[0].Columns.Count-1)
			// 		{
			// 			print(str);
			// 			str="";
			// 		}
			// 	}
			// }
	        foreach (DataRow dataRow in table.Rows)
	        {
	            foreach (DataColumn dataColumn in table.Columns)
	            {
	                Debug.Log(dataRow[dataColumn]);
					
					
	                text.text += "  "+dataRow[dataColumn].ToString();
	            }
	        }
	    }
		
        sql.Close();
	}
	
	
	void Update () {
	
	}
}