using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;




public class UpUserImage : MonoBehaviour
{
  
   public RawImage showImage;
    public Button loadImage;

        void Start()
         {
            //  PhotoButtonClick();
              loadImage.onClick.AddListener(() =>
            {
                showImage.texture = GetNativeFile(Application.dataPath+"/UserImg/test.png");
            });
                //Get the path of the Game data folder
         }
        
        /// <summary>
        /// 拍照按钮的功能实现
        /// </summary>
        private void PhotoButtonClick()
        {
            // string fName = DateTime.Now.ToString("yyyyMMddHHmmss") + ".png";//用时间作为图片的名称，保证唯一性
            string fName = "test.png";
            PlayerPrefs.SetString("photoName", fName);//将名字存储，为了方便获取
            StartCoroutine(UploadPNG(fName));
        }

        /// <summary>
        /// 截取图片
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private IEnumerator UploadPNG(string fileName)
        {
            yield return new WaitForEndOfFrame();
            // U3D 截图
            int width = Screen.width;
            int height = Screen.height;
            Texture2D tex = new Texture2D(width, height, TextureFormat.RGB24, false);
            tex.ReadPixels(new Rect(0, 0, width, height), 0, 0);
            tex.Apply();
            byte[] bytes = tex.EncodeToPNG();
            GameObject.Destroy(tex);
            string path = PathForFile(fileName);//移动平台的判断
            SaveNativeFile(bytes, path);//保存图片到本地
        }

    /// <summary>
     /// 判断平台
     /// </summary>
     /// <param name="filename"></param>
     /// <returns></returns>
     public string PathForFile(string filename)
     {
        
        //  if (Application.platform == RuntimePlatform.Android)
        //  {
        //      string path = Application.persistentDataPath;
        //      path = path.Substring(0, path.LastIndexOf('/'));
        //     
        //  }
        //  else {
            
            
             
        //  }
    
        string  path = Application.dataPath+"/UserImg/";
         path = path.Substring(0, path.LastIndexOf('/'));
         
         Debug.Log(path);

        return Path.Combine(path, filename);
     }
     /// <summary>
     /// 在本地保存文件
     /// </summary>
     /// <param name="bytes"></param>
     /// <param name="path"></param>
     public void SaveNativeFile(byte[] bytes, string path)
     {
         FileStream fs = new FileStream(path, FileMode.Create);
         fs.Write(bytes, 0, bytes.Length);
         fs.Flush();
         fs.Close();
     }


//上述是保存在移动平台的代码，下面则是读取到移动平台的图片
    /// <summary>
    /// 获取到本地的图片
    /// </summary>
    /// <param name="path"></param>
    public Texture2D GetNativeFile(string path)
    {
        try
        {
            var pathName = path;
            var bytes = ReadFile(pathName);
            int width = Screen.width;
            int height = Screen.height;
            var texture = new Texture2D(width,height);
            texture.LoadImage(bytes);
            return texture;
        }
        catch (Exception e)
        {
            Debug.Log(e);

        }
        return null;
    }
    public byte[] ReadFile(string filePath)
    {
        var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
        fs.Seek(0, SeekOrigin.Begin);
        var binary = new byte[fs.Length];
        fs.Read(binary, 0, binary.Length);
        fs.Close();
        return binary;
    }

}
