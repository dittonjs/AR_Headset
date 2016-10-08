using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class RightArrow : MonoBehaviour {
	Text myText;
	// Use this for initialization
	void Start () {
		myText = GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {
		if (UIStateScript.uiState == "MAIN" ||
			UIStateScript.uiState == "SPEECH" ||
			UIStateScript.uiState == "FLIGHT2" ||
			UIStateScript.uiState == "HOTEL2" ||
			UIStateScript.uiState == "HOTEL3" ||
			UIStateScript.uiState == "SECOND") {
			myText.text = ">";
		} else {
			myText.text = "";
		}
	}
}