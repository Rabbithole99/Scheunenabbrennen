using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
	public AudioClip triggerSound;
	AudioSource audioSource;
	
    void Start()
    {
		audioSource = GetComponent<AudioSource>();
		
        
    }

    void Update()
    {
		
        
    }
	
	private void OnTriggerEnter(Collider other)
	{
		if(triggerSound != null)
		{
			audioSource.PlayOneShot(triggerSound, 0.05F);
		}
	}
	
	 void OnTriggerExit(Collider other)
      {
           AudioSource audio = GetComponent<AudioSource>();
           audio.Stop();
      }
	
	
	
	
}
