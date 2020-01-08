using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;


public class GVR_Button_Quit : MonoBehaviour
{

    public Image ImgCircle;
    public UnityEvent GVRClick;
    public float totalTime = 2;
    bool gvrstatus;
    public float gvrTimer;
    public Scene first;



    void Update()
    {
        if (gvrstatus)
        {
            gvrTimer += Time.deltaTime;
            ImgCircle.fillAmount = gvrTimer / totalTime;
        }
        if (gvrTimer > totalTime)
        {
            Application.Quit();


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