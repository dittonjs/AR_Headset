using UnityEngine;
using System.Collections;


public class MicInput : MonoBehaviour {
	AudioClip clip;
	void Start() {
		StartCoroutine (GetMicInput());
	}

	IEnumerator GetMicInput(){
		//Debug.Log ("RECORDING");
		AudioSource aud = GetComponent<AudioSource>();
//		clip = Microphone.Start("External Microphone", false, 3, 44100);
//		yield return new WaitForSeconds (3);
//		Microphone.End("External Microphone");

//		SavWav.Save ("myvoice1", clip);
//		yield return new WaitForSeconds (2);
		string url = Application.persistentDataPath + "/myvoice.wav";
//		Convert.ToBase64String(byte[] data)
//		Debug.Log (url.ToString());
		WWW audioloader = new WWW ("file:///" + url);
//
		yield return audioloader;
		Debug.Log (audioloader.text);

//		var asdf = Convert.ToBase64String(byte[] aud.clip);  

		aud.clip = audioloader.GetAudioClip(false, false, AudioType.WAV);
		aud.Play ();
//


//		aud.Play();	
	}
}
