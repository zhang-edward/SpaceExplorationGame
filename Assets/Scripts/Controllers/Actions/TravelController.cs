using UnityEngine;
using System.Collections;

public class TravelController {

	/// <summary>
	/// Travel this instance.
	/// </summary>
	public static string Travel(Planet dest) {
		GameManager.instance.ship.planet = dest;
		Debug.Log ("Ship travelled to " + dest.Name);
		return "Ship travelled to "  + dest.Name;
	}
}
