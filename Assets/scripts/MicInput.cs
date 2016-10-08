using UnityEngine;
using System.Collections;

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
		WWW audioloader = new WWW (url);
		Debug.Log ("SAVING");
		yield return audioloader;
		Debug.Log(audioloader.audioClip.name);
//		Debug.Log("did i break?");
//		aud.Play();	
	}
}
