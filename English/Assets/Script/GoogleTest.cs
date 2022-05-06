using System.Collections;
using System.Collections.Generic;
using GooglePlayGames;
using UnityEngine;

public class GoogleTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Social.localUser.Authenticate (success => {
    if (success) {
         Debug.Log("Login with Google Play Games done. IdToken: " + ((PlayGamesLocalUser)Social.localUser).GetIdToken());
     
    } else {
    Debug.Log ("登錄失敗");
    }
    });
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
