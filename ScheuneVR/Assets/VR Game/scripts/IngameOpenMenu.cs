using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class IngameOpenMenu : MonoBehaviour
{


    public Image imgGaze;

    public float totalTime = 2;
    bool gvrStatus;
    float gvrTimer;

    public int distanceOfRay = 10;
    private RaycastHit _hit;



   
    void Start()
    {

    }

    void Update()
    {
        if (gvrStatus)
        {
            gvrTimer += Time.deltaTime;
            imgGaze.fillAmount = gvrTimer / totalTime;
        }

        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));

        if (Physics.Raycast(ray, out _hit, distanceOfRay))
        {
            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("IngameMenu"))
            {

                SceneManager.LoadScene(0); 
            }
        }

    }


    public void GVROn()
    {

        gvrStatus = true;

    }

    public void GVROFF()
    {

        gvrStatus = false;
        gvrTimer = 0;
        imgGaze.fillAmount = 0;
    }


}
