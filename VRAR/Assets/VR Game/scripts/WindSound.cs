using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindSound : MonoBehaviour
{
    AudioSource myAudio;
    
    // Start is called before the first frame update
    public void Start()
    {
        myAudio = GetComponent<AudioSource>();
        Invoke("stopAudio", 2.0f);
    }

    public void stopAudio()
    {
        myAudio.Stop();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
