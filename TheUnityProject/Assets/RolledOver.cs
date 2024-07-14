using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.Animations;

public class RolledOver : MonoBehaviour
{
    public Transform reset;
    public BoxCollider rolledOver;
    public bool isflipped = false;
    public float timer = 2f;
    public float flip =  2f; 
    public float timerLeft;
    public BoxCollider rolledLeft;

    public BoxCollider rolledRight;
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
            reset.Rotate(180,0,0);
            Debug.Log("no time left");
            timerLeft = timer;
            isflipped = false;

        }


        if (Vector3.Dot(Vector3.up, transform.up) < 1)
        {
           float vinkel = Mathf.Acos(Vector3.Dot(Vector3.up, transform.up) / (Vector3.up.magnitude * transform.up.magnitude));
           print(vinkel * Mathf.Rad2Deg);
        }


    }

    
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            isflipped = false;
            timerLeft = timer;
            Debug.Log("TriggerExit");
            
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
