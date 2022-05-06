using System.Collections;
using  UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneFaded : MonoBehaviour
{
    
    public Image blackimage;
    public AnimationCurve curve;
   
    void Start(){
        
        StartCoroutine("FadedIn");
    }
    public void FadedTo(string scene){
        StartCoroutine(FadedOut(scene));
    }
    IEnumerator FadedIn(){
        float t = 1f;
        while (t>=0){
            t-=Time.deltaTime;
            float a = curve.Evaluate(t);
            blackimage.color = new Color(0f,0f,0f,a);
            yield return null;
        }
    }
      IEnumerator FadedOut(string scene){
        float t = 0f;
        while (t<=1){
            t+=Time.deltaTime;
            float a = curve.Evaluate(t);
            blackimage.color = new Color(0f,0f,0f,a);
            yield return null;
        }
        SceneManager.LoadScene(scene);

    }
}
