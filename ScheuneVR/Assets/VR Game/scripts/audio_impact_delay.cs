using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio_impact_delay : MonoBehaviour
{
    AudioSource myAudio;
    

    void Start()
    {
        myAudio = GetComponent<AudioSource>();
        Invoke("playAudio", 15.0f);
        
    }

    void playAudio()
    {
        myAudio.Play();
        

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
