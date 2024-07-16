using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class deathplane : MonoBehaviour
{
    public int Rounds; 
    public int ScoreP1;
    public int ScoreP2;
    public bool P2Win;
    public bool P1Win;
    public static deathplane instance; 
    public GameObject Round1; 
    public GameObject Round2; 
    public GameObject Round3; 
    public float zoomSpeed = 5f;
    public float roundStartTimer;
    public float targetFov = 60f;
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
        roundStartTimer = 1.5f;
        Camera.main.enabled = true;
    }
// Update is called once per frame
    void Update()
    {
        if (Camera.main.fieldOfView == 60)
        {
            roundStartTimer = roundStartTimer - Time.deltaTime;
        }
        else
        {
            roundStartTimer = 1.5f;
        }
        
        if (Rounds == 3 && Camera.main.fieldOfView == 60 && roundStartTimer >0)
        {
            Round1.SetActive(true);
        }

        if (Rounds == 3 && Camera.main.fieldOfView == 60 && roundStartTimer <= 0)
        {
            Round1.SetActive(false);
        }

        if (Rounds == 2 && Camera.main.fieldOfView == 60 && roundStartTimer >0)
        {
            Round2.SetActive(true);
        }

        if (Rounds == 2 && Camera.main.fieldOfView == 60 && roundStartTimer <= 0)
        {
            Round2.SetActive(false);
        }

        if (Rounds == 1 && Camera.main.fieldOfView == 60 && roundStartTimer >0)
        {
            Round3.SetActive(true);
        }

        if (Rounds == 1 && Camera.main.fieldOfView == 60 && roundStartTimer <= 0)
        {
            Round3.SetActive(false);
        }
        if (Rounds == 0)
        {
            print("endofgame");
            float WhoWon = ScoreP1 - ScoreP2;
            if (WhoWon < 0)
            {
                P2Win = true;
                print("deathplane win2");
                Camera.main.enabled = false;
            }
            else
            {
                P1Win = true;
                print("deathplane win1");
                Camera.main.enabled = false;
            }
        }

        Camera.main.fieldOfView = Mathf.MoveTowards(Camera.main.fieldOfView, targetFov, Time.deltaTime * zoomSpeed);
        //if (Rounds <= 0 && Input.GetKeyDown(KeyCode.Escape))
        // {
        //SceneManager.LoadScene("Menu");
        //}


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
