using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Ship : MonoBehaviour {

	/// <summary>
	/// The crew.
	/// </summary>
	public List<Crew> crewList;

	/// <summary>
	/// The money.
	/// </summary>
	public float Money { get; set; }

	/// <summary>
	/// The resources.
	/// </summary>
	private Dictionary<Resource, int> resources;
	public Dictionary<Resource, int> Resources {
		get{return resources;}
	}

	/// <summary>
	/// The planet.
	/// </summary>
	public Planet planet { get; set; }

	/// <summary>
	/// The crew prefab.
	/// </summary>
	public GameObject crewPrefab;

	void Awake()
	{
		crewList = new List<Crew>();
	}

	/// <summary>
	/// Initialize this instance
	/// </summary>
	void Start() {
		Init();
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
		ViewManager.instance.ShipUI.Init (this);
	}

	/// <summary>
	/// Adds the resources.
	/// </summary>
	/// <param name="res">Resource.</param>
	/// <param name="num">Number.</param>
	public void AddResources(Resource res, int num) {
		if (resources.ContainsKey (res)) {
			resources [res] += num;
		} else {
			resources.Add(res, num);
		}
		Debug.Log ("Ship has " + resources[res] + " resources");
	}

	public void RemoveResources(Resource res, int amt) {
		if (resources.ContainsKey(res))
		{
			if (resources[res] >= amt)
				resources[res] -= amt;
			else
				Debug.LogWarning ("Trying to take away " + amt + " resources when only " + resources[res] + " are available!");
		}
	}

	/// <summary>
	/// Adds amount of money.
	/// </summary>
	/// <param name="amt">Amt.</param>
	public void AddMoney(int amt) {
		Money += amt;
		Debug.Log ("Ship now has " + Money + " money");
	}

	public void RemoveMoney(int amt) {
		Money += amt;
	}

	/// <summary>
	/// Gets the resources.
	/// </summary>
	/// <returns>The resources.</returns>
	public Dictionary<Resource, int> getResources() {
		Debug.Log (resources);
		return resources;
	}
	
}
