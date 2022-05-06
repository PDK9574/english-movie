using System.Collections;
using System.Collections.Generic;
using System.Data;
using Assets;
using UnityEngine;
using UnityEngine.UI;

public class Dict : MonoBehaviour
{

    public Text text;
    public InputField inputField;
	
	public void Search () {
        SqlAccess sql = new SqlAccess();

        //sql.CreateTableAutoID("jl", new string[] { "id", "name", "qq", "email", "blog" }, new string[] { "int", "text", "text", "text", "text" });
        //sql.InsertInto("jl", new string[] { "name", "qq", "email", "blog" }, new string[] { "jianglei", "289187120", "[email protected]", "jianglei.com" });
        //sql.InsertInto("jl", new string[] { "name", "qq", "email", "blog" }, new string[] { "lizhih", "34546546", "[email protected]", "lizhih.com" });
        //sql.Delete("jl", new string[] { "id" }, new string[] { "2" });
		//查單字
        // DataSet ds=sql.QuerySet("Select * from dictionary where english ="+"'"+inputField.text+"'");
		DataSet ds=sql.QuerySet("Select * from dictionary where id = 1 or id = 2");
	
		
	    if (ds!=null)
	    {
	        DataTable table = ds.Tables[0];
			// 找值
			// string name = table.Rows[0][0].ToString();
			// Debug.Log(name);
			
			
		


			//修改Text
	        // foreach (DataRow dataRow in table.Rows)
	        // {
	        //     foreach (DataColumn dataColumn in table.Columns)
	        //     {
            //        	// 印出所有
	        //         // Debug.Log(dataRow[dataColumn]);
			// 		Debug.Log(dataRow[0]);
					
	        //         text.text += "  "+dataRow[dataColumn].ToString();
	        //     }
	        // }

			//印出 datatable 
			// SqlAccess.LogDatatable(ds);
			
			//印出 datatable 
			// for (int i=0; i<ds.Tables[0].Rows.Count; i++) {
			// 	for(int j=0;j<ds.Tables[0].Columns.Count;j++)
			// 	{				
			// 		str+=ds.Tables[0].Rows[i][j].ToString().Trim()+"    ";
			// 		if(j==ds.Tables[0].Columns.Count-1)
			// 		{
			// 			Debug.Log(str);
			// 			str="";
			// 		}
			// 	}
			// }
			


	    }
		
        sql.Close();
	}
	
	
    // Update is called once per frame
    void Update()
    {
        
    }
}
