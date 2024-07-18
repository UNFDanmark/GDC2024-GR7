
using UnityEngine;
using UnityEngine.SceneManagement;

public class Winscreen : MonoBehaviour
{
    public GameObject P2Winscreen;
    public GameObject P1Winscreen;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (deathplane.instance.P1Win )
        {
            P1Winscreen.SetActive(P1Winscreen);
            print("p1win");
        }
        else
        {
            P1Winscreen.SetActive(false);
        }

        if (deathplane.instance.P2Win )
        {
            P2Winscreen.SetActive(P2Winscreen);
            print("p2win");
        }
        else
        {
            P2Winscreen.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Camera.main != null)
            {
                Camera.main.enabled = true;
                
            }
            SceneManager.LoadScene("Menu");
        }
    } 
}
