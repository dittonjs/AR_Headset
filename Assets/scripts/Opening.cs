using UnityEngine;
using System.Collections;
using UnityEngine.Windows;
public class Opening : MonoBehaviour {

	// Use this for initialization
	void Start () {
		TextToSpeech.SpeakText ("Welcome to Smart Life Augmented Reality.");
	}

	void Update(){
		if (Input.GetKeyDown (KeyCode.Space)) {
			Application.LoadLevel (1);
		}
	}
}	
