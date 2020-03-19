using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quitgame : MonoBehaviour
{
 public GameObject completeLevelUI;
	 
	 public void CompleteLevel () 
	 {
		 completeLevelUI.SetActive(true);
	 }
	 
	 void OnTriggerEnter ()
	 {
		 CompleteLevel ();
	 }
}
