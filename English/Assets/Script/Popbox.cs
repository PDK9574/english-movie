using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using Assets;
using System;
using UnityEngine.UI;
using System.Data;

public class Popbox : MonoBehaviour
{
    public Text Ans;
    public InputField N1;
    public InputField N2;
    Coroutine c = null;

    public void showPop(GameObject g)
    {
        if (c != null)
            StopCoroutine(c);
        StartCoroutine(Pop (g,Vector3.one));
    }
    public void hidePop(GameObject g)
    {
        if (c != null)
            StopCoroutine(c);
        StartCoroutine(Pop (g,Vector3.zero));
    }
    public void calculate(){
        int i =Int16.Parse(N1.text);
        int j = Int16.Parse(N2.text);
        int answer=i+j;
        Ans.text=answer.ToString();
    }
    IEnumerator Pop(GameObject g,Vector3 v3){
        float i=0;
        while(i<1){
            i+=Time.deltaTime;
            g.transform.localScale=Vector3.Lerp(g.transform.localScale,v3,i);
            yield return new WaitForFixedUpdate();
        }
        c=null;
    }
}
