
using UnityEngine;
using System.Collections;
 
public class AndroidPhoto : MonoBehaviour {
 
	// Use this for initialization
	void Start () {
	
	}
	
        //打开相册	
	public void OpenPhoto()
	{
		AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
		AndroidJavaObject jo = jc.GetStatic<AndroidJavaObject>("currentActivity");
		jo.Call("OpenGallery");       
	}
        
        //打开相机
	public void OpenCamera()
	{
		AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
		AndroidJavaObject jo = jc.GetStatic<AndroidJavaObject>("currentActivity");
		jo.Call("takephoto");       
	}
 
	public void GetImagePath(string imagePath)
	{ 
		if (imagePath == null)
			return;
		StartCoroutine("LoadImage",imagePath);
	}
 
	public void GetTakeImagePath(string imagePath)
	{
		if (imagePath == null)
			return;
		StartCoroutine("LoadImage",imagePath);
	}
		
	// private IEnumerator LoadImage(string imagePath)
	// {
	// 	WWW www = new WWW ("file://"+imagePath);
	// 	yield return www;
	// 	if (www.error == null) {
    //                    //成功读取图片，写自己的逻辑
	// 		GetComponent<ChangePhoto>().LoadAndroidImageOK(www.texture);
	// 	}else{
	// 		Debug.LogError("LoadImage>>>www.error:"+www.error);
	// 	}
}

