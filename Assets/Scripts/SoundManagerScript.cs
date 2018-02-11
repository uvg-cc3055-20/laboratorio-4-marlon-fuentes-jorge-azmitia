using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Universidad del Valle de Guatemala
 * Marlon Fuentes - Jorge Azmitia
 * Funcion: Clase que da funcionabilidad a la nave
 */
public class SoundManagerScript : MonoBehaviour {


//se declara un nuevo audioclip y audiosource
public static AudioClip deathsound;
static AudioSource audioSrc;

	// Use this for initialization
	void Start () {
		
		//decimos que deathsound es la variable que almacena el clip de audio para el  sonido de muerte
		deathsound = Resources.Load<AudioClip>("death");
		
		//decimos que el audiosource estara relacionado con el componente en cuestion
		audioSrc =  GetComponent<AudioSource>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	
	public static void PlaySound (string clip){
		
		
		//hacemos un switch para poder llamar a diferentes sonidos aunque en este caso solo es uno
		switch (clip){
			
			//en el caso de que se quiera el sonido de muerte, este se reproduce una vez
			case "death":
			
		audioSrc.PlayOneShot (deathsound);
		break;
			
			
		}
		
		
		
		
	}
	
	
}