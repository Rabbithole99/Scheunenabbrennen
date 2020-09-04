using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feuerlöschen : MonoBehaviour
{

    public GameObject dings;
    // Start is called before the first frame update
   public void  loeschen()
    {
        dings.SetActive(false);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
