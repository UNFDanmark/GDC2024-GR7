using UnityEngine;

public class car2 : MonoBehaviour
{
    public float knockbackValue;

    public Rigidbody rbPlayer1;
    public Rigidbody rbPlayer2;
    public Transform knockbackOrigin;
    //public Transform Knockback;
    public float explosionMultiplier = 1000f;

    public float explosionRadius = 20f;
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
        
        Debug.Log("Triggered");
        
        if (other.gameObject.CompareTag("car2"))
        {
            Vector3 positionV3 = knockbackOrigin.position;
            //rbPlayer2.AddExplosionForce(explosionMultiplier, positionV3,explosionRadius, 100f);
            Vector3 vel = rbPlayer2.velocity;
            vel.y = 100f;
            rbPlayer2.velocity = vel;
            Debug.Log("POW!");
            //Vector3 direction = (transform.position - other.transform.position).normalized;
            //rbPlayer1.AddForce(direction * knockbackValue);
        }
    }
}