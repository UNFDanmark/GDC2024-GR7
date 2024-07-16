using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        if (deathplane.instance.P1Win == true)
        {
            P1Winscreen.SetActive(P1Winscreen);
            print("p1win");
        }

        if (deathplane.instance.P2Win == true)
        {
            P2Winscreen.SetActive(P2Winscreen);
            print("p2win");
        }
    }
}
