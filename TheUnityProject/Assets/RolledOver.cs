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
    public float flip =  2f; 
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
            reset.position = new Vector3(transform.position.x, transform.position.y + flip, transform.position.z);
            reset.Rotate(0,0,180);
            Debug.Log("no time left");
            timerLeft = timer;
            isflipped = false;

        }

       
        
            
    }

    
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            timerLeft = timer;
        }
    }
     public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            Debug.Log("Upside down");
            isflipped = true;
        }
    }
}
