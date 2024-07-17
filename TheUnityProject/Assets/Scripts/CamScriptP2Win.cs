using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamScriptP2Win : MonoBehaviour
{
    public Camera P2winCam;

    private bool winMusicStarted = false;
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
            if (winMusicStarted == false)
            {
                GameObject.FindWithTag("BattleMusic").GetComponent<AudioSource>().Stop();
                GameObject.FindWithTag("WinMusic").GetComponent<AudioSource>().Play();
                GameObject.FindWithTag("P2Win").GetComponent<AudioSource>().Play();
                winMusicStarted = true;
            }
            P2winCam.enabled = true;
            if (Camera.main != null)
            {
                Camera.main.enabled = false;
            }
        }
        
    }
}
