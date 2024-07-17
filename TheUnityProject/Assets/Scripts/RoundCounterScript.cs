using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundCounterScript : MonoBehaviour
{
    public GameObject roundnumber;
    // Start is called before the first frame update
    void Start()
    {
        int round = roundnumber.GetComponent<deathplane>().Rounds;
        print(round);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
