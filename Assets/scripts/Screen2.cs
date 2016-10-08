using UnityEngine;
using System.Collections;

public class Screen2 : MonoBehaviour {
	RectTransform rect;
	// Use this for initialization
	void Start () {
		rect = GetComponent<RectTransform> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (UIStateScript.uiState == "SPEECH") {
			rect.anchoredPosition = new Vector2 (rect.anchoredPosition.x, 0f);
		} else {
			rect.anchoredPosition = new Vector2 (rect.anchoredPosition.x, -5000f);
		}
	}
}
