using UnityEngine;
using System.Collections;
using System;
using System.Text;
public class MicInput : MonoBehaviour {
	AudioClip clip;
	void Start() {
		StartCoroutine (GetMicInput());
	}

	IEnumerator GetMicInput(){
		Debug.Log ("RECORDING");
		AudioSource aud = GetComponent<AudioSource>();
		clip = Microphone.Start("External Microphone", false, 3, 44100);
		yield return new WaitForSeconds (3);
		Microphone.End("External Microphone");
		Debug.Log ("DONE RECORDING");
		SavWav.Save ("myvoice", clip);
		yield return new WaitForSeconds (2);
		string url = Application.persistentDataPath + "/myvoice.wav";
		Debug.Log (url);
		WWW audioloader = new WWW ("file:///"+url);
		Debug.Log ("SAVING");
		byte[] bytes = Encoding.ASCII.GetBytes (audioloader.text);
		string encodedText = Convert.ToBase64String (bytes);
		yield return audioloader;
		aud.clip = audioloader.GetAudioClip (false, false, AudioType.WAV);
		aud.Play();	
	}
}
