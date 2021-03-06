﻿using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;
public class HotelData : MonoBehaviour
{
	string urlEndpointResponse = "https://api.sandbox.amadeus.com/v1.2/hotels/search-airport?apikey=82MJopwOHjYA7vlW0eywE06KFRqGXdfZ&location=BOS&check_in=2016-10-14&check_out=2016-10-16&amenity=RESTAURANT&amenity=PARKING&number_of_results=2";
	string hotelName = "";
	string hotelPrice = "";
	string hotelRating = "";
	public Text name;
	public Text price;
	public Text rating;

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
//			Debug.Log (data);

//			hotelName = data.GetField ("results")[0].GetField ("property_name").ToString();
			hotelPrice = data.GetField ("results")[0].GetField ("total_price").GetField ("amount").ToString();
//			hotelRating = data.GetField ("results")[0].GetField ("awards")[0].GetField ("rating").ToString();
			name.text = "Bunker";
			rating.text = "4 Star";
			price.text = hotelPrice;

		} else {
			Debug.Log("WWW Error: "+ www.error);
		}    
	}

	// Update is called once per frame
	void Update ()
	{

	}
}

