﻿using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name){
		Debug.Log("Level Load Requested for: " + name );
		Application.LoadLevel(name);
	}
	
	public void QuitRequest(){
		Debug.Log ("Quiting");
		Application.Quit();
	}
}
