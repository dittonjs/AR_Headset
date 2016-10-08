using UnityEngine;
using System.Collections;

public class FlightData : MonoBehaviour
{
	string urlEndpointResponse = "http://api.sandbox.amadeus.com/v1.2/flights/low-fare-search?origin=IST&destination=BOS&departure_date=2016-10-15&return_date=2016-10-21&number_of_results=3&apikey=82MJopwOHjYA7vlW0eywE06KFRqGXdfZ";

	// Use this for initialization
	void Start ()
	{
		WWW www = new WWW(urlEndpointResponse);
		StartCoroutine(WaitForRequest(www));
	}

	IEnumerator WaitForRequest(WWW www)
	{
		yield return www;

		// check for errors
		if (www.error == null)
		{
			Debug.Log ("asdf" + www.text);
			JSONObject data = new JSONObject (www.text);
			Debug.Log (data);
//			string weather = data.GetField ("weather") [0].GetField ("main").ToString();
//			string temperature = data.GetField("main").GetField("temp").ToString();
//			weatherText.text = weather + " | " + temperature;

		} else {
			Debug.Log("WWW Error: "+ www.error);
		}    
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}

