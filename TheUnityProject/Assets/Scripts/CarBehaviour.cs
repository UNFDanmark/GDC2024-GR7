using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarBehaviour : MonoBehaviour
{
    public int speed = 10;
    public Transform rotation;
    public Transform CamR;
    public Rigidbody Car;

    // Start is called before the first frame update
    void Start()
    {
        Car = GetComponent<Rigidbody>();
    }
    

    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        var vertical = Input.GetAxisRaw("Vertical");
        float rotation = Input.GetAxisRaw("Rotation Horizontal");
        if (rotation > 30)
        {
            
        }

        Vector3 movement = new Vector3();
        movement.x = horizontal * speed;
        movement.z = vertical * speed;
        Car.velocity = movement;
        transform.Rotate(0,rotation,0);
    }
        
}

