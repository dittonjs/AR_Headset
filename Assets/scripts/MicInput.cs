using UnityEngine;
using System.Collections;

public class MicInput : MonoBehaviour {

	void Start() {
		StartCoroutine (GetMicInput());
	}

	IEnumerator GetMicInput(){
		AudioSource aud = GetComponent<AudioSource>();
		aud.clip = Microphone.Start("External Microphone", false, 10, 44100);
		yield return new WaitForSeconds (10);
		Microphone.End("External Microphone");
		aud.Play();	
	}
}
