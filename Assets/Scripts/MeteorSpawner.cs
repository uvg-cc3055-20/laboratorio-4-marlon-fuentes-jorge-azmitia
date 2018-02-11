using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Universidad del Valle de Guatemala
 * Marlon Fuentes - Jorge Azmitia
 * Funcion: Clase que permite a los meteoritos spawn
 */
public class MeteorSpawner : MonoBehaviour {
	
	//se declara el gameobject meteoro, el tiempo en el que este aparece y el tiempo que este lleva en pantalla
    public GameObject meteor;
    float spawnTime = 2f;
    float elapsedTime = 0f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		//mientras que el tiempo que ha pasado sea menor que el tiempo de aparicion, se sigue sumando tiempo
        if (elapsedTime < spawnTime)
        {
            elapsedTime += Time.deltaTime;
        }
		//cuando el tiempo que ha pasado, sobrepasa al tiempo de aparicion, se genera un nuevo meteoro que aparece entre la posicion -3 y 3 y se reinicia el tiempo
        else
        {
            float random = Random.Range(-3f, 3f);
            Instantiate(meteor, new Vector3(random,5,0),Quaternion.identity);
            elapsedTime = 0;
        }
	}
}
