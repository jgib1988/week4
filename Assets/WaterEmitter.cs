using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterEmitter : MonoBehaviour
{

    FMOD.Studio.EventInstance waterfallEvent;
    // Start is called before the first frame update
    void Start()
    {
        waterfallEvent = FMODUnity.RuntimeManager.CreateInstance("event:/Waterfall");
        waterfallEvent.start();
        FMODUnity.RuntimeManager.AttachInstanceToGameObject(waterfallEvent, gameObject, GetComponent<Rigidbody>());

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
