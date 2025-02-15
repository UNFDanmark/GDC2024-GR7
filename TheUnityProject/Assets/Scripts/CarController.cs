using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarController : MonoBehaviour
{
    public enum Axel
    {
        Front,
        Rear
    }
    [Serializable]
    public struct Wheel
    {
        public GameObject wheelModel;
        public WheelCollider WheelCollider;
        public Axel axel; 
    }

    public Text player1Score;
    
    public float jumpSTR = 100000f;
    
    public float maxAcceleration = 30.0f;
    public float brakeAcceleration = 50.0f;

    public float turnSensitivity = 1.0f;
    public float maxSteeringAngle = 30.0f;
    public List<Wheel> wheels;
    float moveInput;
    float steerInput; 
    bool isgrounded = true;
    public Rigidbody carRB;

    void Start()
    {
        carRB = GetComponent<Rigidbody>();
        
        player1Score.text = "" + deathplane.instance.ScoreP1;
        //carRB.constraints = RigidbodyConstraints.FreezeAll;

    }
    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isgrounded == true)
        {
            isgrounded = false;
            carRB.AddForce(new Vector3(0, jumpSTR, 0), ForceMode.Impulse);
            Debug.Log("Itsa me mario");
        }
        GetInputs();
       /* if (Camera.main.fieldOfView == 60 && deathplane.instance.roundStartTimer <= 0)
        {
            carRB.constraints = RigidbodyConstraints.None;
            
        }

        if (deathplane.instance.P1Win)
        {
            carRB.constraints = RigidbodyConstraints.None;
        }*/
    }

    void LateUpdate()
    {
        Move();
        Steer();
    }

    void GetInputs()
    {
        moveInput = Input.GetAxisRaw("Vertical");
        steerInput = Input.GetAxisRaw("Horizontal");
       
    }

    void Move()
    {
        
        foreach(var wheel in wheels)
        {
            wheel.WheelCollider.motorTorque = moveInput * 3500 * maxAcceleration * Time.deltaTime;
        }
    }

    void Steer()
    {
        foreach (var wheel in wheels)
        {
            if (wheel.axel == Axel.Front)
            {
                var steeringAngle = steerInput * turnSensitivity * maxSteeringAngle;
                steeringAngle = Mathf.Lerp(wheel.WheelCollider.steerAngle, steeringAngle, 0.9f);
                wheel.WheelCollider.steerAngle = steeringAngle;
            }

            // if (moveInput < 0)
            //{
            //  wheel.WheelCollider.brakeTorque = Mathf.Abs(moveInput) * brakeAcceleration;
            //}
            //else
            //{
            //  wheel.WheelCollider.brakeTorque = 0;
            //}
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            Debug.Log("I be touchin grass");
            isgrounded = true;
        }
    }

   
}
