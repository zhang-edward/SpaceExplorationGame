using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

	public static GameManager instance;
	private bool travel = false;
	public bool Travel {
		get{ return travel;}
		set{ travel = value;}
	}

	public Starmap starmap;

	/// <summary>
	/// Reference to the ship.
	/// </summary>
	public Ship ship;

	/// <summary>
	/// The ship prefab used to instantiate the ship.
	/// </summary>
	public GameObject shipPrefab;

	/// <summary>
	/// The list of crew to action mappings.
	/// </summary>
	public Dictionary<Crew, Action> actionList = new Dictionary<Crew, Action>();

	/// <summary>
	/// Initialize this instance
	/// </summary>
	void Awake() {
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy(gameObject);

		DontDestroyOnLoad(gameObject);
	}

	/// <summary>
	/// Allow players to pick actions.
	/// </summary>
	public void AssignAction(Crew crew, int actionNum) {

		if (actionNum == 0)
		{
			actionList[crew] = new HarvestController();
		}
		else if (actionNum == 1)
		{
			actionList[crew] = new ExploreController();
		}

		/*if (travel) {
			Planet dest = null; //FIXME
			TravelController.Travel (ship, dest);
		} else {
			foreach (Crew member in ship.GetCrew()){
				string actionName = null; // FIXME 
				switch(actionName) {
					case "harvest": 
						actionList[member] = new HarvestController();
						break;
					case "explore":
						actionList[member] = new ExploreController();
						break;
					default:
						break;
				}
			}
		}*/
	}

	/// <summary>
	/// Does the actions for each crew member.
	/// </summary>
	public void DoActions() {
		foreach (KeyValuePair<Crew, Action> entry in actionList) {
			entry.Value.DoAction(entry.Key, ship.GetPlanet(), ship); 
		}
	}
}
