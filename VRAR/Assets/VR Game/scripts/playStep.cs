using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playStep : MonoBehaviour
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
    public void Doorsound()
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
