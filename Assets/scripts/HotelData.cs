﻿using UnityEngine;
using System.Collections;
using System;

public class HotelData : MonoBehaviour
{
	string urlEndpointResponse = "https://api.sandbox.amadeus.com/v1.2/hotels/search-airport?apikey=82MJopwOHjYA7vlW0eywE06KFRqGXdfZ&location=BOS&check_in=2016-03-14&check_out=2016-03-16&amenity=RESTAURANT&amenity=PARKING&number_of_results=2\n";
	string hotelName = "";
	string hotelPrice = "";
	string hotelRating = "";

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

			JSONObject data = new JSONObject (www.text);
			Debug.Log (data);

//			hotelName = data.GetField ("results")[0].GetField ("fare").GetField ("total_price").ToString();
//			hotelPrice = data.GetField ("results")[0].GetField ("itineraries")[0].GetField ("outbound").GetField ("flights")[0].GetField ("origin").GetField("airport").ToString();
//			hotelRating = data.GetField ("results")[0].GetField ("itineraries")[0].GetField ("outbound").GetField ("flights")[0].GetField ("origin").GetField("terminal").ToString();

		} else {
			Debug.Log("WWW Error: "+ www.error);
		}    
	}

	// Update is called once per frame
	void Update ()
	{

	}
}
