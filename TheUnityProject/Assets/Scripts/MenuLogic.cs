using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuLogic : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Real Sumo");
        if (deathplane.instance != null)
        {
            deathplane.instance.P2Win = false;
            deathplane.instance.P1Win = false;
            deathplane.instance.ScoreP1 = 0;
            deathplane.instance.ScoreP2 = 0;
            deathplane.instance.Rounds = 3;
            GameObject.FindWithTag("BattleMusic").GetComponent<AudioSource>().Play();
            //GameObject.FindWithTag("WinMusic").GetComponent<AudioSource>().Stop();
            //GameObject.FindWithTag("P1Win").GetComponent<AudioSource>().Stop();
        }
       
    }
        
    

}
