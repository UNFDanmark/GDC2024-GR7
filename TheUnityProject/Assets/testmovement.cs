using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testmovement : MonoBehaviour
{
    [SerializeField] public Rigidbody testcar;

    private float accelerationMultiplier = 3;

    private Vector2 input = Vector2.zero;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        accelerate();
    }

    void accelerate()
    {
        testcar.drag = 0;
        testcar.AddForce(testcar.transform.forward * accelerationMultiplier * input.y);
    }

    void brake()
    {
        if (testcar.velocity.z <= 0)
            return;
    }
}