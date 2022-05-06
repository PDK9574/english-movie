
using System;
using System.Data;
using Assets;
using UnityEngine;
using UnityEngine.UI;
public class SqlOperate : MonoBehaviour
{
  public Text text;
  void Start(){
      Debug.Log(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
  }
    public void InsertUserCreate(){
        SqlAccess sql = new SqlAccess();
        sql.InsertInto("usercreate",new string [] {"sentence","chinese","moviename","movietype","time","uploadTime","create_id"},
        new string[] {"I like to watch video ","我喜歡看影片","蜘蛛人","愛情","23:50:55.999",SqlAccess.DateTimeNormalize(DateTime.Now) ,"20"});
		Debug.Log("新增成功");
        sql.Close();
    }
    public void Search(){
      
    }
	
}
