using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class deathplane : MonoBehaviour
{
    public float Rounds; 
    public int ScoreP1;
    public int ScoreP2;
    public bool P2Win;
    public bool P1Win;
    public static deathplane instance;

    public Camera Main;
    // Start is called before the first frame updates
    void Start()
    {
        Rounds = 3;
        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        
        ScoreP1 = 0;
        ScoreP2 = 0;
        P1Win = false;
        P2Win = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Rounds == 0)
        {
            print("endofgame");
            float WhoWon = ScoreP1 - ScoreP2;
            if (WhoWon < 0)
            {
                P2Win = true;
                print("deathplane win2");
            }
            else
            {
                P1Win = true;
                print("deathplane win1");
            }
        }


    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger?");
        if (other.gameObject.CompareTag("car1"))
        {
            Debug.Log("Score P2");
            ScoreP2 = ScoreP2 + 1;
            Rounds = Rounds - 1;
            SceneManager.LoadScene("Sumo minigame");

        }
        if (other.gameObject.CompareTag("car2"))
        {
            Debug.Log("Score P1");
            ScoreP1 = ScoreP1 + 1;
            Rounds = Rounds - 1;
            SceneManager.LoadScene("Sumo minigame");
        }
    }
}
