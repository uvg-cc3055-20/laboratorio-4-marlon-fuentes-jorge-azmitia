using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour {
    public GameObject meteor;
    float spawnTime = 2f;
    float elapsedTime = 0f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (elapsedTime < spawnTime)
        {
            elapsedTime += Time.deltaTime;
        }
        else
        {
            float random = Random.Range(-3f, 3f);
            Instantiate(meteor, new Vector3(random,5,0),Quaternion.identity);
            elapsedTime = 0;
        }
	}
}
