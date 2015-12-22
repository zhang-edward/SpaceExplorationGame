using UnityEngine;
using System.Collections;

public class StarmapUI : MonoBehaviour {

	TravelController travelControl = new TravelController();

	public void Travel(Planet planet)
	{
		TravelController.Travel (planet);
	}
}
