using System;
using System.Data;
using Assets;
using UnityEngine;
using UnityEngine.UI;
public class SqlOperate : MonoBehaviour
{
  public Text text;
  public int movieid;
  void Start(){

  }
    public void InsertUserCreate(){
        SqlAccess sql = new SqlAccess();
        sql.InsertInto("usercreate",new string [] {"sentence","chinese","moviename","movietype","time","uploadTime","create_id"},
        new string[] {"I like to watch video ","我喜歡看影片","蜘蛛人","愛情","23:50:55.999",SqlAccess.DateTimeNormalize(DateTime.Now) ,"20"});
		Debug.Log("新增成功");
        sql.Close();
    }
    public void showSentence(){
        text.text="";
        SqlAccess sql = new SqlAccess();
        DataSet ds=sql.QuerySet("SELECT ch_movie_name,sentence,chinese FROM english.moviesentence as a join english.movie as b on a.movie_id=b.id where movietype_id='"+movieid+"'");
        if(sql.isDataSetNull(ds)!=true){
         string str = "";
            if (ds!=null){   
                for (int i=0; i<ds.Tables[0].Rows.Count; i++) {
                    for(int j=0;j<ds.Tables[0].Columns.Count;j++)
                    {	     		
                        str+=ds.Tables[0].Rows[i][j].ToString().Trim()+"\n";
                        text.text+=str;
                        str="";
                        // if(j==ds.Tables[0].Columns.Count-1)
                        // {
                        //     text.text+=str;
                        //     str="";
                        // }
                        Debug.Log(ds.Tables[0].Rows[i][j].ToString());
                    }
                }
            }
        }
    }
    
}
