using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animDoorCloseLower : MonoBehaviour
{

    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }
    public void start() { anim.Play("door_open_r"); }
    // Update is called once per frame
    void Update()
    {
        
    }
}
