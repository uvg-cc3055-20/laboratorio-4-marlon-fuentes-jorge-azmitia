using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainController : MonoBehaviour {


public Text score;

	// Use this for initialization
	void Start () {
		
		//PlayerPrefs.SetFloat("score",0);
		score.text ="HighScore: "+ PlayerPrefs.GetFloat("score",0).ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
			if (GameController.instance.time > PlayerPrefs.GetFloat("score",0)){
			PlayerPrefs.SetFloat("Score",GameController.instance.time);					
				
			}
			score.text = "HighScore: "+ PlayerPrefs.GetFloat("score").ToString("n2");
		
	}
}
