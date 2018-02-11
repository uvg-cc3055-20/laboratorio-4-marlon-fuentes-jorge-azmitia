using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Universidad del Valle de Guatemala
 * Marlon Fuentes - Jorge Azmitia
 * Funcion: Clase que permite a los meteoritos moverse y destruirse fuera del margen 
 */
public class Meteor : MonoBehaviour {
	
	//se declara el componente de rigidbody y la velocidad de los meteoros
    Rigidbody2D rb;
    float speed = 10f;
	
	
    // Use this for initialization
	
	//en la funcion start de obtiene el componente rigidbody del gameobject en cuestion
    void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	
	void Update () {
		//se hace que el gameobject se vaya moviendo con una velocidad predefinida
        rb.transform.Translate(Vector3.down * speed * Time.deltaTime);
		//y que en el momento en el que salga de pantalla este se destruya
        if (rb.transform.position.y < -5.19)
        {
            Destroy(gameObject);
        }
    }
}
