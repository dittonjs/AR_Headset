using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WeatherScript : MonoBehaviour {
	public Text weatherText;

	void Awake () {
		Debug.Log ("HERE");
		string url = "api.openweathermap.org/data/2.5/weather?zip=84321&APPID=4eac3f75191b45b083f1b27d84ba634a";
		WWW www = new WWW(url);
		StartCoroutine(WaitForRequest(www));
	}

	IEnumerator WaitForRequest(WWW www)
	{
		yield return www;

		// check for errors
		if (www.error == null)
		{
			JSONObject data = new JSONObject (www.text);
			Debug.Log (data);
			string weather = data.GetField ("weather") [0].GetField ("main").ToString();
			string temperature = data.GetField("main").GetField("temp").ToString();
			weatherText.text = weather + " | " + temperature;

		} else {
			Debug.Log("WWW Error: "+ www.error);
		}    
	}
}
	

