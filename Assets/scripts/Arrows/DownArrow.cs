using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class DownArrow : MonoBehaviour {
	Text myText;
	// Use this for initialization
	void Start () {
		myText = GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {
		if (UIStateScript.uiState == "SPEECH" ||
			UIStateScript.uiState == "SECOND" ||
			UIStateScript.uiState == "HOTEL2" ||
			UIStateScript.uiState == "FLIGHT2" ||
			UIStateScript.uiState == "FLIGHT3") {
			myText.text = "v";
		} else {
			myText.text = "";
		}
	}
}
