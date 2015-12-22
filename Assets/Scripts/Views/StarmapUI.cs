using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StarmapUI : MonoBehaviour {

	TravelController travelControl = new TravelController();

	/// <summary>
	/// The starmap used to generate views.
	/// </summary>
	public Starmap starmap;

	/// <summary>
	/// The planet buttons.
	/// </summary>
	private List<PlanetButton> planetButtons;

	/// <summary>
	/// The planet button prefab.
	/// </summary>
	public GameObject planetButtonPrefab;

	void Start()
	{
		Init ();
	}

	/// <summary>
	/// Initialize this instance.
	/// </summary>
	public void Init()
	{
		// Instantiate planet ui buttons using planet data from starmap model
		foreach (Planet planet in starmap.planets)
		{
			GameObject o = Instantiate(planetButtonPrefab, Vector3.zero, Quaternion.identity) as GameObject;
			o.transform.SetParent (this.transform);		// for organization in the hierarchy

			// TODO: make a parent class of Starmap Button for other objects like asteroids, space stations, etc.
			PlanetButton pButton = o.GetComponent<PlanetButton>();
			// initialize the planetButton, passing in a reference to this ui and the planet data
			pButton.Init(this, planet);
		}
		Debug.Log ("Planets Generated: " + starmap.planets.Count);
	}

	public void Travel(Planet planet)
	{
		TravelController.Travel (planet);
	}
}
