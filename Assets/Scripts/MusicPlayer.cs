using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {
	
	static MusicPlayer instance;
	
	void Awake(){
		Debug.Log("Music player Awake " + GetInstanceID());
		if(instance != null){
			Destroy (gameObject);
			print ("Duplicate music player destroyed");
		} else {
			 instance = this;
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}
		
	void Start () {
		Debug.Log("Music player Start " + GetInstanceID());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
