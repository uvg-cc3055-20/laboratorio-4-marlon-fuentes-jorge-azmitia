using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/*
 * Universidad del Valle de Guatemala
 * Marlon Fuentes - Jorge Azmitia
 * Funcion: Clase que permite las transiciones del menu al juego. 
 */
public class MainMenuManager : MonoBehaviour {


//se declara el metodo que nos carga la escena en la que se juega, accion que se realiza al apachar el boton
	public void PlayGame()
    {
        SceneManager.LoadScene("Scene_1");
    }
}
