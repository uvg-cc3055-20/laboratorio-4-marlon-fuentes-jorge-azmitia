using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour {
    public static GameController instance;
	public int score =0 ;
	public float time;
	public Text timeLabel;
	public bool gameOver = false;
	// Use this for initialization
	void Start () {
        instance = this;
//		timeLabel.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (gameOver == false){
		time += Time.deltaTime;
		timeLabel.text=time.ToString("n2");
		}
		
		if (gameOver == true){
			
			
			SceneManager.LoadScene("Scene_0");

		}
		
	}
}
