using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;


public class CloseDoor : MonoBehaviour
{

    public Image ImgCircle;
    public UnityEvent GVRClick;
    public float totalTime = 2;
    bool gvrstatus;
    public float gvrTimer;
   
    AudioClip myAudio;
    AudioSource audio;
    public float Volume;
    public bool played = false;

    void Update()
    {
        if (gvrstatus)
        {
            gvrTimer += Time.deltaTime;
            ImgCircle.fillAmount = gvrTimer / totalTime;
        }
        if (gvrTimer > totalTime)
        {
           

            audio = GetComponent<AudioSource>();
        audio.PlayOneShot(myAudio, Volume);
        played = true; 
            
            

             
           

        }
    }

   

    public void GvrOn()
    {
        gvrstatus = true;
    }

    public void GvrOff()
    {
        gvrstatus = false;
        gvrTimer = 0;
        ImgCircle.fillAmount = 0;
    }


}