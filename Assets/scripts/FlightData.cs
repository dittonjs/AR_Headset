using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;
public class FlightData : MonoBehaviour
{
	string urlEndpointResponse = "http://api.sandbox.amadeus.com/v1.2/flights/low-fare-search?origin=IST&destination=BOS&departure_date=2016-10-15&return_date=2016-10-21&number_of_results=3&apikey=82MJopwOHjYA7vlW0eywE06KFRqGXdfZ";
	string totalPrice = "";
	string initialAirport = "";
	string initialTerminal = "";
	string outboundDateTime = "";
	string inboundDateTime = "";
	public Text price;
	public Text outbound;
	public Text inbound;

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

			totalPrice = data.GetField ("results")[0].GetField ("fare").GetField ("total_price").ToString();
			initialAirport = data.GetField ("results")[0].GetField ("itineraries")[0].GetField ("outbound").GetField ("flights")[0].GetField ("origin").GetField("airport").ToString();
			initialTerminal = data.GetField ("results")[0].GetField ("itineraries")[0].GetField ("outbound").GetField ("flights")[0].GetField ("origin").GetField("terminal").ToString();
			outboundDateTime = data.GetField ("results")[0].GetField ("itineraries")[0].GetField ("outbound").GetField ("flights")[0].GetField ("departs_at").ToString();
			inboundDateTime = data.GetField ("results")[0].GetField ("itineraries")[0].GetField ("inbound").GetField ("flights")[0].GetField ("departs_at").ToString();
			price.text = totalPrice;
			outbound.text = outboundDateTime;
			inbound.text = inboundDateTime;

		} else {
			Debug.Log("WWW Error: "+ www.error);
		}    
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}

