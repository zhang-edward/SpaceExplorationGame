using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StarmapUI : MonoBehaviour {

	TravelController travelControl = new TravelController();

	/// <summary>
	/// The starmap.
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
		foreach (Planet planet in starmap.planets)
		{
			GameObject o = Instantiate(planetButtonPrefab, Vector3.zero, Quaternion.identity) as GameObject;

			o.transform.SetParent (this.transform);

			PlanetButton pButton = o.GetComponent<PlanetButton>();
			pButton.Init(planet);
		}
	}

	public void Travel(PlanetButton pButton)
	{
		Planet planet = pButton.planet;
		TravelController.Travel (planet);
	}
}
