using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class RolledOver : MonoBehaviour
{
    public Transform reset;
    public BoxCollider rolledOver;
    public bool isflipped = false;
    public float timer = 2f;
    public Vector3 flip = new Vector3(0, 2, 0); 
    public float timerLeft;
    // Start is called before the first frame update
    void Start()
    {
        
        timerLeft = timer;
    }

    // Update is called once per frame
    void Update()
    {
        if (isflipped == true)
        {
            timerLeft = timerLeft - Time.deltaTime;
        }
        if (timerLeft <= 0)
        {
            transform.position = flip;
            reset.Rotate(0,0,180);
            transform.position = flip;
            Debug.Log("no time left");
            timerLeft = timer;

        }

       
        
            
    }

    
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            timerLeft = timer;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            Debug.Log("Upside down");
            isflipped = true;
        }
    }
}
