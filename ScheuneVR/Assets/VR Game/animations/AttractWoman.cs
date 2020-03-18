using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttractWoman : MonoBehaviour
{

    [SerializeField] private Animator animationController;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        { animationController.SetBool("attract", true); }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        { animationController.SetBool("Attract", false); }
    }
}
