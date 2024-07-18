using UnityEngine;
using Random = UnityEngine.Random;

public class Honk : MonoBehaviour
{
    public AudioClip[] Honks;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("car2"))
        {
            AudioClip Clip = Honks[Random.Range(0, Honks.Length)];
            AudioSource.PlayClipAtPoint(Clip,transform.position);
        }
        
    }

    
}
