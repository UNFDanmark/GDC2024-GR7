using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamscriptP1Win : MonoBehaviour
{
    public Camera P1WinCam;
    // Start is called before the first frame update
    void Start()
    {
        P1WinCam.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (deathplane.instance.P1Win == true)
        {
            P1WinCam.enabled = true;
            Camera.main.enabled = false;
        }
    }
}
