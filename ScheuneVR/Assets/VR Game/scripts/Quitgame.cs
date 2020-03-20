using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quitgame : MonoBehaviour
{
 public GameObject completeLevelUI;
	 
	 public void CompleteLevel () 
	 {
		 completeLevelUI.SetActive(true);
         SceneManager.LoadScene(1);
	 }
	 
	 void OnTriggerEnter ()
	 {
		 CompleteLevel ();
         
        
    }
}
