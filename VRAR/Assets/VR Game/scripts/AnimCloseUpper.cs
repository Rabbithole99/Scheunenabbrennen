using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimCloseUpper
   : MonoBehaviour
{

    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

    }
    public void start() { anim.Play("door_open_l"); }
    // Update is called once per frame
    void Update()
    {

    }
}
