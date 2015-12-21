using UnityEngine;
using System.Collections;

public class StarmapUI : MonoBehaviour {

	public void Travel(Planet planet)
	{
		GameManager.instance.ship.SetPlanet(planet);
	}
}
