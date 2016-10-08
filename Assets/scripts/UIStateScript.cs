using UnityEngine;
using System.Collections;

public class UIStateScript : MonoBehaviour {
	public static string uiState = "MAIN";

	void Update () {
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			switch (UIStateScript.uiState) {
			case "MAIN":
				UIStateScript.uiState = "SECOND";
				Debug.Log (UIStateScript.uiState);
				break;
			case "SECOND":
				UIStateScript.uiState = "THIRD";
				Debug.Log (UIStateScript.uiState);
				break;
			default:
				break;
			}
		}
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			switch (UIStateScript.uiState) {
			case "SECOND":
				UIStateScript.uiState = "MAIN";
				Debug.Log (UIStateScript.uiState);
				break;
			case "THIRD":
				UIStateScript.uiState = "SECOND";
				Debug.Log (UIStateScript.uiState);
				break;
			default:
				break;
			}
		}
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			UIStateScript.uiState = "SPEECH";
			Debug.Log (UIStateScript.uiState);
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			UIStateScript.uiState = "MAIN";
			Debug.Log (UIStateScript.uiState);
		}
	}
}
