using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public Animator anim;

     void Start()
    {
        StartCoroutine(shake());
        
    }


    IEnumerator shake()
    {   anim = GetComponent<Animator>();
        yield return new WaitForSeconds(2.5f);
        anim.Play("cameraShake");
        yield return new WaitForSeconds(1.5f);
        anim.Play("New State");
        
        yield return new WaitForSeconds(11.0f);
        anim.Play("cameraShake");
        yield return new WaitForSeconds(2.0f);
        anim.Play("New State");

       

    }
  
    
    void Update()
    {
        
    }
}
