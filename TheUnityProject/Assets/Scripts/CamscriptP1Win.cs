using UnityEngine;

public class CamscriptP1Win : MonoBehaviour
{
    public Camera P1WinCam;
    private bool winMusicStarted = false;
    
    // Start is called before the first frame update
    void Start()
    {
        P1WinCam.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (deathplane.instance.P1Win)
        {

            if (winMusicStarted == false)
            {
                GameObject.FindWithTag("BattleMusic").GetComponent<AudioSource>().Stop();
                GameObject.FindWithTag("WinMusic").GetComponent<AudioSource>().Play();
                GameObject.FindWithTag("P1Win").GetComponent<AudioSource>().Play();
                winMusicStarted = true;
            }
            
            P1WinCam.enabled = true;

            if (Camera.main != null)
            {
                Camera.main.enabled = false;
            }
        }
    }
}
