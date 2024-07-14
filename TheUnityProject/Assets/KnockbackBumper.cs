using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockbackBumper : MonoBehaviour
{
    public float knockbackValue;

    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "car")
        {
            Vector3 direction = (transform.position - other.transform.position).normalized;
            rb.AddForce(direction * knockbackValue);
        }
    }
}

