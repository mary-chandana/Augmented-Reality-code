using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class MultipleVB : MonoBehaviour
{
    public GameObject cybeGO, linuGO, webdGO;
    VirtualButtonBehaviour[] vrb;
    // Start is called before the first frame update
    void Start()
    {
        cybeGO.SetActive(false);
        linuGO.SetActive(false);
        webdGO.SetActive(false);

        vrb = GetComponentsInChildren<VirtualButtonBehaviour>();

        for (int i = 0; i < vrb.Length; i++)
        {
            vrb[i].RegisterOnButtonPressed(onButtonPressed);
            vrb[i].RegisterOnButtonReleased(onButtonReleased);
        }
    }


    public void onButtonPressed(VirtualButtonBehaviour vb)
    {
        if (vb.VirtualButtonName == "CybeVB")
        {
            cybeGO.SetActive(true);
            linuGO.SetActive(false);
            webdGO.SetActive(false);
        }

        else if (vb.VirtualButtonName == "LinuVB")
        {
            cybeGO.SetActive(false);
            linuGO.SetActive(true);
            webdGO.SetActive(false);
        }

        else if (vb.VirtualButtonName == "WebdVB")
        {
            cybeGO.SetActive(false);
            linuGO.SetActive(false);
            webdGO.SetActive(true);
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
