using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Ship : MonoBehaviour {

	/// <summary>
	/// The instance.
	/// </summary>
	public static Ship instance;

	/// <summary>
	/// The crew.
	/// </summary>
	private List<Crew> crew;

	/// <summary>
	/// The money.
	/// </summary>
	private float money;

	/// <summary>
	/// The resources.
	/// </summary>
	private Dictionary<Resource, int> resources;

	/// <summary>
	/// The planet.
	/// </summary>
	private Planet planet;

	/// <summary>
	/// Adds the resources.
	/// </summary>
	/// <param name="res">Res.</param>
	/// <param name="num">Number.</param>
	public void AddResources(Resource res, int num) {
		resources [res] += num;
	}

	/// <summary>
	/// Adds amount of money.
	/// </summary>
	/// <param name="amt">Amt.</param>
	public void AddMoney(int amt) {
		money += amt;
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="Ship"/> class.
	/// </summary>
	public Planet GetPlanet() {
		return planet;
	}

	/// <summary>
	/// Sets the planet.
	/// </summary>
	public void SetPlanet(Planet planet) {
		this.planet = planet;
	}

	/// <summary>
	/// Gets the crew.
	/// </summary>
	/// <returns>The crew.</returns>
	public List<Crew> GetCrew() {
		return crew;
	}

	/// <summary>
	/// Sets the crew.
	/// </summary>
	/// <param name="crew">Crew.</param>
	public void SetCrew(List<Crew> crew) {
		this.crew = crew;
	}
}
