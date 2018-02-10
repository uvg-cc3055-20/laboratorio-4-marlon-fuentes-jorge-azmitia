using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Universidad del Valle de Guatemala
 * Marlon Fuentes - Jorge Azmitia
 * Funcion: Clase que permite a los meteoritos moverse y destruirse fuera del margen 
 */
public class Meteor : MonoBehaviour {
    Rigidbody2D rb;
    float speed = 10f;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        rb.transform.Translate(Vector3.down * speed * Time.deltaTime);
        if (rb.transform.position.y < -5.19)
        {
            Destroy(gameObject);
        }
    }
}
