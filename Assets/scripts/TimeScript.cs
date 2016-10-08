using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;
public class TimeScript : MonoBehaviour {
	public Text time;
	public float y;
	RectTransform rect;
	void Start(){
		rect = time.GetComponent<RectTransform> ();
	}
	void Update () {
		if (UIStateScript.uiState == "MAIN") {
			y = -360f;
		} else {
			y = 2000f;
		}
		rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, y);
		time.text = DateTime.Now.ToLongTimeString();
	}
}
