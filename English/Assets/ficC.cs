using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class ficC : MonoBehaviour
{
    private RawImage image;
    private List<UniGif.GifTexture> textureList;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<RawImage>();

        string filePath = Application.dataPath + "/ficAni.gif";
        Stream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
        byte[] bytes = new byte[stream.Length];
        stream.Read(bytes, 0, (int)stream.Length);// READING
        //USING TOUR
        StartCoroutine(UniGif.GetTextureListCoroutine(bytes, LoadGifHandler));
    }
    //pic playing 
    int index = -1;
    //time counter
    float timer = 0;
    void LoadGifHandler(List<UniGif.GifTexture> list, int count, int width, int height)
    {
        textureList = list;
        index = 0;
    }
    // Update is called once per frame
    void Update()
    {
        if (index == -1)
        {
            return;

        }
        //show pic
        timer += Time.deltaTime;
        if (timer >= 0.09f)
        {
            timer = 0;
            //display pic
            image.texture = textureList[index++].m_texture2d;
            //if done reset t 0
            if (index >= textureList.Count)
            {
                index = 0;
            }
        }
    }
}
