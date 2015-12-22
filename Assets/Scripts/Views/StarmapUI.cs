using UnityEngine;
using System.Collections;

public class StarmapUI : MonoBehaviour {

	/// <summary>
	/// The starmap used to generate the views.
	/// </summary>
	public Starmap starmap;

	TravelController travelControl = new TravelController();

	public void Travel(Planet planet)
	{
		TravelController.Travel (planet);
	}
}
