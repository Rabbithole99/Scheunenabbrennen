using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeuerlöscherSound : MonoBehaviour
{
    public AudioClip SoundToPlay;
    public float Volume;
    AudioSource audio;
    public bool played = false;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();

    }
    public void FeuerExt()
    {
        if (!played)
        {
            audio.PlayOneShot(SoundToPlay, Volume);
            played = true;
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
