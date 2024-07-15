using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathplane : MonoBehaviour
{
    public int Score;
    public int displayScore;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger?");
        if (other.gameObject.CompareTag("car1") || other.gameObject.CompareTag("car2"))
        {
            Debug.Log("sCORE");
            Score = Score + 1;
            displayScore = Score / 2;
        }
        
    }
}
