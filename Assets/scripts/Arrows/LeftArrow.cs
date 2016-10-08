using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class LeftArrow : MonoBehaviour {
	Text myText;
	// Use this for initialization
	void Start () {
		myText = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (UIStateScript.uiState == "MAIN" ||
		   UIStateScript.uiState == "THIRD" ||
		   UIStateScript.uiState == "FLIGHT2" ||
		   UIStateScript.uiState == "FLIGHT3") {
			myText.text = "<";
		} else {
			myText.text = "";
		}
	}
}
