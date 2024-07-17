using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamScriptP2Win : MonoBehaviour
{
    public Camera P2winCam;
    // Start is called before the first frame update
    void Start()
    {
        P2winCam.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (deathplane.instance.P2Win == true)
        {
            P2winCam.enabled = true;
            Camera.main.enabled = false;
        }
    }
}
