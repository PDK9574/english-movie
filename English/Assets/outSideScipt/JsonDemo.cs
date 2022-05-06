using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class JsonDemo : MonoBehaviour
{
    void Start()
    {

        //宣告一個Listy作為道具列表並存入兩個道具
        List<string> equips = new List<string>();
        equips.Add("sword");
        equips.Add("shield");

        //用剛剛宣告好的Class創建一個儲存數值的物件，並給予數值欄位對應的數值(例如生命設定為100，金錢250....)

        Data newData = new Data
        {
            health = 100,
            money = 250,
            equip = equips
        };

        //把剛剛創建好的數值物件轉為Json字串，並用JsonInfo參數儲存，接下來把這個字串寫入指定的檔案位置(下面紅色字請改成自己的路徑《都可以》最後面是檔案名稱)

        string jsonInfo = JsonUtility.ToJson(newData,true);
        File.WriteAllText(@"./Assets/savefile/file1.txt", jsonInfo);
        //File.WriteAllText(@"D:\unity\english_outside\English\Assets\savefile\file0.txt", jsonInfo);
        Debug.Log("寫入完成");
    }

}

//要儲存的資料用一個Class去儲存，裡面可以放各類型的資料(但是不能放Dictionary 很重要!!!我被呼弄很久)
public class Data
{
    public float health;
    public int money;
    public List<string> equip;
}