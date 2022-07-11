using System.Collections;
using System.Collections.Generic;
using Assets;
using UnityEngine;

public class ViewCounts : MonoBehaviour
{
    // Start is called before the first frame update
    public int movietype_id;
    void Start()
    {
        StartCoroutine(Count());
    }
    IEnumerator Count(){
        SqlAccess sql = new SqlAccess();
        sql.QuerySet("UPDATE hotmvtype SET views=views+1 WHERE typeid='"+movietype_id+"'");
        Debug.Log("成功增加在電影類型"+movietype_id);
        yield return null;
    }
   
}
