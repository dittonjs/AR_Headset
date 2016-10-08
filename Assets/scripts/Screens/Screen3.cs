using UnityEngine;
using System.Collections;

public class Screen3 : MonoBehaviour {
	RectTransform rect;
	// Use this for initialization
	void Start () {
		rect = GetComponent<RectTransform> ();
	}

	// Update is called once per frame
	void Update () {
		if (UIStateScript.uiState == "SECOND") {
			rect.anchoredPosition = new Vector2 (rect.anchoredPosition.x, 0f);
			if (Input.GetKeyDown (KeyCode.Return)) {
				TextToSpeech.SpeakText ("Ok, I just booked that for you.");
			}
		} else {
			rect.anchoredPosition = new Vector2 (rect.anchoredPosition.x, -5000f);
		}
	}
}
