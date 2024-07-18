using UnityEngine;

public class RolledOver : MonoBehaviour
{
    public Transform reset;
    public BoxCollider rolledOver;
    public bool isflipped = false;
    public float timer = 5f;
    public float flip =  2f; 
    public float timerLeft;
    public Transform carRotate;
    public Rigidbody carRb;
    // Start is called before the first frame update
    void Start()
    {
        
        timerLeft = timer;
    }

    // Update is called once per frame
    void Update()
    {
        
        
        
            //reset.position = new Vector3(transform.position.x, transform.position.y + flip, transform.position.z);
            //reset.Rotate(180,0,0);
            //Debug.Log("no time left");
            
            isflipped = false;


        if (Vector3.Dot(Vector3.up, carRotate.up) < 0.5)
        {
            timerLeft = timerLeft - Time.deltaTime;
            //print(timerLeft);
            if (timerLeft <= 0)
            {
                float vinkel = Mathf.Acos(Vector3.Dot(Vector3.up, carRotate.up));
                //print(vinkel * Mathf.Rad2Deg);
                //reset.position = new Vector3(transform.position.x, transform.position.y + flip, transform.position.z);
                Quaternion targetRotation = Quaternion.FromToRotation(carRotate.up, Vector3.up) * carRotate.rotation; 
                carRotate.rotation = Quaternion.Slerp(carRotate.rotation, targetRotation, Time.deltaTime * 1000f);
                print("tried to rotate");
                timerLeft = timer;
                print("reset timer");
            }
           
            
        }
        else
        {
            timerLeft = timer;
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
