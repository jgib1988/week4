using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone : MonoBehaviour
{
    FMOD.Studio.EventInstance instance;
    

    private void Start()
     {
        instance = FMODUnity.RuntimeManager.CreateInstance("snapshot:/Zone");
        
    }


    public void OnTriggerEnter(Collider other)
    {
        instance.start();
    }

    public void OnTriggerExit(Collider other)
    {
        instance.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
    }
}
