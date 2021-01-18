using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundmanager : MonoBehaviour
{


    public static AudioClip jump, correct, deathsound, xd ;
    static AudioSource ses;
    // Start is called before the first frame update
    void Start()
    {

        jump = Resources.Load<AudioClip>("jump");
        correct = Resources.Load<AudioClip>("correct");
        deathsound = Resources.Load<AudioClip>("deathsound");
        xd = Resources.Load<AudioClip>("xd");


        ses = GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "jump":
                ses.PlayOneShot(jump);
                break;
            case "correct":
                ses.PlayOneShot(correct);
                break;
            case "deathsound":
                ses.PlayOneShot(deathsound);
                break;
            case "xd":
                ses.PlayOneShot(xd);
                break;
        }
    }
    public static void stop()
    {
        ses.Stop();
    }
}
    