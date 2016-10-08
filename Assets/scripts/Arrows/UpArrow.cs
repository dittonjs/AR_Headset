using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class UpArrow : MonoBehaviour {
	Text myText;
	// Use this for initialization
	void Start () {
		myText = GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {
		if (UIStateScript.uiState == "MAIN" ||
			UIStateScript.uiState == "HOTEL2" ||
			UIStateScript.uiState == "HOTEL3" 
		) {
			myText.text = "^";
		} else {
			myText.text = "";
		}
	}
}