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

	public void PlayGame()
    {
        SceneManager.LoadScene("Scene_1");
    }
}
