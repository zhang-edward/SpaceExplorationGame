using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Ship : MonoBehaviour {

	/// <summary>
	/// The crew.
	/// </summary>
	public List<Crew> crewList { get; set; }

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
	public Planet planet { get; set; }

	/// <summary>
	/// The crew prefab.
	/// </summary>
	public GameObject crewPrefab;

	/// <summary>
	/// Initialize this instance
	/// </summary>
	void Start() {
		Init ();
	}

	/// <summary>
	/// Init this instance.
	/// </summary>
	void Init() {
		resources = new Dictionary<Resource, int> ();
		crewList = new List<Crew>();
		for (int i = 0; i < 2; i++) {
			GameObject o = Instantiate(crewPrefab, transform.position, Quaternion.identity) as GameObject;
			Crew newCrew = o.GetComponent<Crew>();
			newCrew.Name = "Crew " + i;
			newCrew.health = 10;
			newCrew.strength = 5;
			crewList.Add(newCrew);
		}
	}

	/// <summary>
	/// Adds the resources.
	/// </summary>
	/// <param name="res">Res.</param>
	/// <param name="num">Number.</param>
	public void AddResources(Resource res, int num) {
		if (resources.ContainsKey (res)) {
			resources [res] += num;
		} else {
			resources.Add(res, num);
		}
	}

	/// <summary>
	/// Adds amount of money.
	/// </summary>
	/// <param name="amt">Amt.</param>
	public void AddMoney(int amt) {
		money += amt;
	}
}
