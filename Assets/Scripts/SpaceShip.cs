using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Universidad del Valle de Guatemala
 * Marlon Fuentes - Jorge Azmitia
 * Funcion: Clase que da funcionabilidad a la nave
 */
public class SpaceShip : MonoBehaviour {
	
	//se declara el componennte rigidbody2d y la velocidad de la nave
    Rigidbody2D rb;
    float speed = 10f;
	// Use this for initialization
	
	//obtenemos el componente del gameobject en cuestion
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
		//mientras el juego no haya terminado contunuamos moviendo la nave
		if (GameController.instance.gameOver==false){
		
		//declaramos que el movimiento en x depende del acelerometro del dispositivo
        float movX = Input.acceleration.x;
        rb.transform.Translate(Vector2.right * speed * movX * Time.deltaTime);
		
		}
		
	}
	
	public void OnTriggerEnter2D (Collider2D collision)
	{
		//cuando la nave entre dentro de un collider triger se reproduce el sonido de muerte, y se declara que el juego ha terminado
		SoundManagerScript.PlaySound("death");
		GameController.instance.gameOver=true;
	}
	
	public void OnCollisionEnter2D(Collision2D collision)
    {      
		GameController.instance.gameOver=true;
	}
	
}
