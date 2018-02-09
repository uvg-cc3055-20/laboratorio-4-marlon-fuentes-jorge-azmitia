using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour {



public static AudioClip deathsound;
static AudioSource audioSrc;

	// Use this for initialization
	void Start () {
		
		deathsound = Resources.Load<AudioClip>("death");
		
		audioSrc =  GetComponent<AudioSource>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	
	public static void PlaySound (string clip){
		
		switch (clip){
			
			
			case "death":
			
		audioSrc.PlayOneShot (deathsound);
		break;
			
			
		}
		
		
		
		
	}
	
	
}