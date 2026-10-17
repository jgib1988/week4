using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FootstepManager : MonoBehaviour
{
    public List<AudioClip> grassSteps = new List<AudioClip>();
    public List<AudioClip> waterSteps = new List<AudioClip>();
    public List<AudioClip> caveSteps = new List<AudioClip>();

    private enum Surface { grass, water, cave};
    private Surface surface;

    private List<AudioClip> currentList;

    private AudioSource source;

    private void Start()
    {
        source = GetComponent<AudioSource>();            
    }

    public void PlayStep ()
    {
        if(currentList == null)
            return;

        AudioClip clip = currentList[Random.Range(0, currentList.Count)];
        //source.PlayOneShot(clip);
        FMODUnity.RuntimeManager.PlayOneShot(FMODUnity.EventReference.Find("event:/Step"), transform.position);
    }

    private void SelectStepList ()
    {
        switch (surface)
        {
            case Surface.grass:
                currentList = grassSteps;
                break;
            case Surface.water:
                currentList = waterSteps;
                break;
            case Surface.cave:
                currentList = caveSteps;
                break;
            default:
                currentList = null;
                break;
        }
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.transform.tag == "Grass")
        {
            surface = Surface.grass;
            FMODUnity.RuntimeManager.StudioSystem.setParameterByName("FloorType", 0);
        }

        if (hit.transform.tag == "Water")
        {
            surface = Surface.water;
            FMODUnity.RuntimeManager.StudioSystem.setParameterByName("FloorType", 1);
        }

        if (hit.transform.tag == "Cave")
        {
            surface = Surface.cave;
            FMODUnity.RuntimeManager.StudioSystem.setParameterByName("FloorType", 2);
        }

        SelectStepList();
        
    }

}
