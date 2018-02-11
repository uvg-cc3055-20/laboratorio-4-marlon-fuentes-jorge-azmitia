using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*
 * Universidad del Valle de Guatemala
 * Marlon Fuentes - Jorge Azmitia
 * Funcion: Clase para obtener los valores y colocarlos en el menu. 
 */
public class MainController : MonoBehaviour {


public Text score;

	// Use this for initialization
	void Start () {

//hace que el "label" de texto en la pantalla principal muestre el punteo maximo que se tiene en el juego	
		score.text ="HighScore: "+ PlayerPrefs.GetFloat("score",0).ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
		
		//si el tiempo obtenido en la ultima partida es mayor que el puntaje maximo, este se vuelve el puntaje maximo
			if (GameController.instance.time > PlayerPrefs.GetFloat("score",0)){
			PlayerPrefs.SetFloat("Score",GameController.instance.time);					
			}
			
			//se despliega el valor del puntaje maximo 
			score.text = "HighScore: "+ PlayerPrefs.GetFloat("score").ToString("n2");
		
	}
}
