using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bababooey : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            Debug.Log("Running on Android");
        }
        else if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            Debug.Log("Running on iOS");
        }
        else
        {
            Debug.Log("Running on another platform");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
