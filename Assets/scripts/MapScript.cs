using UnityEngine;
using System.Collections;

public class MapScript : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		float y;
		if (UIStateScript.uiState == "THIRD") {
			y = 1f;
		} else {
			y = 12f;
		}
		transform.position = new Vector3 (transform.position.x, y, 0f);
	}
}
