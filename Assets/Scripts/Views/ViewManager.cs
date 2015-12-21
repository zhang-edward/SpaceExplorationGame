using UnityEngine;
using System.Collections;

public class ViewManager : MonoBehaviour {

	public static ViewManager instance;

	// UI
	public GameObject StarmapUI;
	public GameObject PlanetUI;

	// UI Overlay
	public GameObject ShopUI;

	// TODO: find a better way get which UI to display
	// UI display is based on the ship's planet variable, as well as if the player has opened some menu
	public bool shopping;

	void Update()
	{
		Planet planet = GameManager.instance.ship.planet;

		// TODO: set UIs to id # to make switching easier
		if (planet == null)
		{
			StarmapUI.SetActive (true);
			PlanetUI.SetActive (false);
		}
		else
		{
			StarmapUI.SetActive (false);
			PlanetUI.SetActive (true);
		}

		if (shopping)
		{
			ShopUI.SetActive (true);
		}
		else
		{
			ShopUI.SetActive (false);
		}
	}
}
