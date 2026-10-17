using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class radioemitter : MonoBehaviour
{

    FMOD.Studio.EventInstance instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = FMODUnity.RuntimeManager.CreateInstance("event:/Radio");
        instance.start();
        FMODUnity.RuntimeManager.AttachInstanceToGameObject(instance, gameObject, GetComponent<Rigidbody>());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
