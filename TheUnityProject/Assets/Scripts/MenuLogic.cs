using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuLogic : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Sumo minigame");
    }
        
    

}
