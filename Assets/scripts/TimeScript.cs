using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;
public class TimeScript : MonoBehaviour {
	public Text time;
	void Update () {
		time.text = DateTime.Now.ToLongTimeString();
	}
}
