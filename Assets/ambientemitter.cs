using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ambientemitter : MonoBehaviour
{
    FMOD.Studio.EventInstance instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = FMODUnity.RuntimeManager.CreateInstance("event:/Ambience");
        instance.start();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
