using UnityEngine;
using System.Collections;

public class PlanetUI : MonoBehaviour {

	private Ship ship;

	// Use this for initialization
	void Awake () {
		ship = GameManager.instance.ship;
	}


	/// <summary>
	/// Assigns the crew.
	/// </summary>
	/// <param name="crew">Crew.</param>
	/// <param name="action">Action.</param>
	public void AssignCrew()
	{
	}
}
