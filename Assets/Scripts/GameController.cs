using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/*
 * Universidad del Valle de Guatemala
 * Marlon Fuentes - Jorge Azmitia
 * Funcion: Clase donde se encunetra el control del juego. 
 */

public class GameController : MonoBehaviour {
	
	
    public static GameController instance;
	public int score =0 ;
	public float time=0;
	public float finaltime;
	public Text timeLabel;
	public bool gameOver = false;
	// Use this for initialization
	void Start () {
		//se declara para poder llamar la instancia
        instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		
		//si el juego no se ha terminado, sigue sumando el tiempo en el contador del score
		if (gameOver == false){
		time += Time.deltaTime;
		timeLabel.text="Score: " + time.ToString("n2");
		}else{	
		//cuando el juego se termina llama a la pantalla del menu 
		SceneManager.LoadScene("Menu_Scene");
		}
	}
}
