using UnityEngine;
using System.Collections;

public class TravelController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	/// <summary>
	/// Travel this instance.
	/// </summary>
	public static string Travel(Planet dest) {
		GameManager.instance.ship.SetPlanet (dest);
		return "Ship travelled to "  + dest.GetName();
	}
}
