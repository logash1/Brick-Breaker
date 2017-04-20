﻿using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		Vector3 paddlePos = new Vector3 (0.5f, this.transform.position.y, 0f);
		
		float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;
		
		paddlePos.x = Mathf.Clamp(mousePosInBlocks, .5f, 15.5f);
		
		this.transform.position = paddlePos;
	
	}
}
