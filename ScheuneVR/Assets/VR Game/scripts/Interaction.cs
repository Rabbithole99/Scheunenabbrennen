using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;


public class Interaction : MonoBehaviour
{

    public Image ImgCircle;
    public UnityEvent GVRClick;
    public float totalTime = 4;
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
            GVRClick.Invoke();


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
