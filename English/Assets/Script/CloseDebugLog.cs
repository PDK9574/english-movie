using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDebugLog : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {   
        Debug.unityLogger.logEnabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
