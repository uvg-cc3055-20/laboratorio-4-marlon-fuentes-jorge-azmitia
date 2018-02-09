using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour {
    Rigidbody2D rb;
    float speed = 10f;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
		
		if (GameController.instance.gameOver==false){
		
        float movX = Input.acceleration.x;
        rb.transform.Translate(Vector2.right * speed * movX * Time.deltaTime);
		
		}
		
	}
	
	
	public void OnTriggerEnter2D (Collider2D collision)
	{
			//	 Debug.Log(GameController.instance.time);
/*
		
		  
		  if (GameController.instance.time >PlayerPrefs.GetFloat("score")){
			  PlayerPrefs.SetFloat("score",GameController.instance.time);
			  
			  
		  }
	*/		
	
	
		//----------------------------------------SoundManagerScript.PlaySound("death");
		GameController.instance.gameOver=true;
		
	}
	
	public void OnCollisionEnter2D(Collision2D collision)
    {      

				// Debug.Log(GameController.instance.time);

		GameController.instance.gameOver=true;
		    }
	
}
