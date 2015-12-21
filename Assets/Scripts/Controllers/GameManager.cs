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

	/// <summary>
	/// Reference to the ship.
	/// </summary>
	public static Ship ship;

	/// <summary>
	/// The ship prefab used to instantiate the ship.
	/// </summary>
	public GameObject shipPrefab;

	/// <summary>
	/// The list of crew to action mappings.
	/// </summary>
	public Dictionary<Crew, Action> actionList;
	
	/// <summary>
	/// Allow players to pick actions.
	/// </summary>
	public void PickActions() {
		if (travel) {
			//TODO: Hardcoded, get planet input from View Manager
			Planet dest = null;
			TravelController.Travel(ship, dest);
		}
	}

}
