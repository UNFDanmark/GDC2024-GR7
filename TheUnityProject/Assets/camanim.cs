using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class camanim : MonoBehaviour
{
    public Animator CamAnimator;
    
    
    // Start is called before the first frame update
    void Start()
    {
        //CamAnimator = GetComponent<Animator>();
        if (deathplane.instance.Rounds == 3)
        {
            //CamAnimator.Play("Round1");
            CamAnimator.SetTrigger("Round1");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ShowRound()
    {
        if (deathplane.instance.Rounds == 3)
        {
            //deathplane.instance.Round1.SetActive(true);
            GameObject.FindWithTag("Round1Splash").GetComponent<Image>().enabled = true;
            print("1");
            GameObject.FindWithTag("AudioRound1").GetComponent<AudioSource>().Play();
        }

        if (deathplane.instance.Rounds == 2)
        {
            GameObject.FindWithTag("Round2Splash").GetComponent<Image>().enabled = true;
            print("2");
            GameObject.FindWithTag("AudioRound2").GetComponent<AudioSource>().Play();
        }
        if (deathplane.instance.Rounds == 1)
        {
            GameObject.FindWithTag("Sound3Splash").GetComponent<Image>().enabled = true;
            print("3");
            GameObject.FindWithTag("AudioRound3").GetComponent<AudioSource>().Play();
        }
    }

    public void HideRound()
    {
        if (deathplane.instance.Rounds == 3)
        {
            GameObject.FindWithTag("Round1Splash").GetComponent<Image>().enabled = false;
//            deathplane.instance.Round1.SetActive(false);
        }

        if (deathplane.instance.Rounds == 2)
        {
            GameObject.FindWithTag("Round2Splash").GetComponent<Image>().enabled = false;
        }
        if (deathplane.instance.Rounds == 1)
        {
            GameObject.FindWithTag("Sound3Splash").GetComponent<Image>().enabled = false;
        }
    }
}
