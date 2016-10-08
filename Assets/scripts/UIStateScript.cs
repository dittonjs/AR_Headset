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
			case "THIRD":
				UIStateScript.uiState = "MAIN";
				Debug.Log (UIStateScript.uiState);
				break;
			case "FLIGHT2":
				UIStateScript.uiState = "SPEECH";
				Debug.Log (UIStateScript.uiState);
				break;
			case "FLIGHT3":
				UIStateScript.uiState = "FLIGHT2";
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
			case "MAIN":
				UIStateScript.uiState = "THIRD";
				Debug.Log (UIStateScript.uiState);
				break;
			case "HOTEL2":
				UIStateScript.uiState = "MAIN";
				Debug.Log (UIStateScript.uiState);
				break;
			case "HOTEL3":
				UIStateScript.uiState = "MAIN";
				Debug.Log (UIStateScript.uiState);
				break;
			case "SPEECH":
				UIStateScript.uiState = "FLIGHT2";
				Debug.Log (UIStateScript.uiState);
				break;
			case "FLIGHT2":
				UIStateScript.uiState = "FLIGHT3";
				Debug.Log (UIStateScript.uiState);
				break;
			
			default:
				break;
			}
		}
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			switch (UIStateScript.uiState) {
				case "MAIN":
					UIStateScript.uiState = "SPEECH";
					Debug.Log (UIStateScript.uiState);
					break;
				case "HOTEL2":
					UIStateScript.uiState = "SECOND";
					Debug.Log (UIStateScript.uiState);
					break;
				case "HOTEL3":
					UIStateScript.uiState = "HOTEL2";
					Debug.Log (UIStateScript.uiState);
					break;
				default:
					break;
			}
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			switch (UIStateScript.uiState) {
			case "SPEECH":
				UIStateScript.uiState = "MAIN";
				Debug.Log (UIStateScript.uiState);
				break;
			case "SECOND":
				UIStateScript.uiState = "HOTEL2";
				Debug.Log (UIStateScript.uiState);
				break;
			case "HOTEL2":
				UIStateScript.uiState = "HOTEL3";
				Debug.Log (UIStateScript.uiState);
				break;
			case "FLIGHT2":
				UIStateScript.uiState = "MAIN";
				Debug.Log (UIStateScript.uiState);
				break;
			case "FLIGHT3":
				UIStateScript.uiState = "MAIN";
				Debug.Log (UIStateScript.uiState);
				break;
			default:
				break;
			}
		}
	}
}
