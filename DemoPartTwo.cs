using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class MultipleVB : MonoBehaviour
{
    public GameObject flutGO, arduGO, augmGO, nukeGO;
    VirtualButtonBehaviour[] vrb;
    // Start is called before the first frame update
    void Start()
    {
        flutGO.SetActive(false);
        arduGO.SetActive(false);
        augmGO.SetActive(false);
        nukeGO.SetActive(false);

        vrb = GetComponentsInChildren<VirtualButtonBehaviour>();

        for (int i = 0; i < vrb.Length; i++)
        {
            vrb[i].RegisterOnButtonPressed(onButtonPressed);
            vrb[i].RegisterOnButtonReleased(onButtonReleased);
        }
    }

    public void onButtonPressed(VirtualButtonBehaviour vb)
    {
        if (vb.VirtualButtonName == "FlutVB")
        {
            flutGO.SetActive(true);
            arduGO.SetActive(false);
            augmGO.SetActive(false);
            nukeGO.SetActive(false);
        }

        else if (vb.VirtualButtonName == "ArduVB")
        {
            flutGO.SetActive(false);
            arduGO.SetActive(true);
            augmGO.SetActive(false);
            nukeGO.SetActive(false);
        }

        else if (vb.VirtualButtonName == "AugmVB")
        {
            flutGO.SetActive(false);
            arduGO.SetActive(false);
            augmGO.SetActive(true);
            nukeGO.SetActive(false);
        }

        else if (vb.VirtualButtonName == "NukeVB")
        {
            flutGO.SetActive(false);
            arduGO.SetActive(false);
            augmGO.SetActive(false);
            nukeGO.SetActive(true);
        }

        else
        {
            throw new UnityException(vb.VirtualButtonName + "Virtual button not supported");
        }
    }

    public void onButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button Released");
    }
}

