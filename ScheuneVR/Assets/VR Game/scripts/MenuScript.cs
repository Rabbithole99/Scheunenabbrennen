using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

    public void SceneSwitch(){
        SceneManager.LoadScene(2);}

    public void ExitAPP()
    {
        Application.Quit();
    }

   
}
