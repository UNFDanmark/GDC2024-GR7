using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockbackBumper : MonoBehaviour
{
    public float knockbackValue;

    public Rigidbody rbPlayer;
    public Rigidbody rbEnemy;
    public Transform TRplayer;
    public Transform TRenemy;
    public Transform knockbackOrigin;
    //public Transform Knockback;
    public float explosionMultiplier = 1000f;
    public float speedKnockback;
    public float explosionRadius = 20f;
    public string enemytag;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

   // void OnTriggerEnter(Collider other)
    //{ 
        
       // Debug.Log("Triggered");
        
       // if (other.gameObject.CompareTag(enemytag))
       // {
           // Vector3 positionV3 = knockbackOrigin.position;
            //Vector3 ResultingKnockback = TRplayer.forward * speedKnockback + TRenemy.forward;
            //rbEnemy.AddForce(ResultingKnockback);
            //rbPlayer2.AddExplosionForce(explosionMultiplier, positionV3,explosionRadius, 100f);
           // Vector3 vel = rbPlayer2.velocity;
            //vel.y = 100f;
            //bPlayer2.velocity = vel;
            //Debug.Log("POW!");
            //Vector3 direction = (transform.position - other.transform.position).normalized;
            //rbPlayer1.AddForce(direction * knockbackValue);
            
            
        //}
    //}
}

