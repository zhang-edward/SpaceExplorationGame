using UnityEngine;
using System.Collections;

public class TravelController {

	/// <summary>
	/// Travel this instance.
	/// </summary>
	public static string Travel(Planet dest) {
		GameManager.instance.ship.SetPlanet(dest);
		return "Ship travelled to "  + dest.GetName();
	}
}
