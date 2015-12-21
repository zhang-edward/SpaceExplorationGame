using UnityEngine;
using System.Collections;

public class ExploreController : Action {

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
	
	}

	/// <summary>
	/// Does the action to the crew.
	/// </summary>
	/// <param name="crew">Crew.</param>
	/// <param name="member">Member.</param>
	public override string DoAction(Crew member, Planet planet, Ship ship) {
		int combatchance = Random.Range (0, planet.GetCivType() * 3);
		if (combatchance == 1) {
			IsCombat = true;
			Debug.Log("Ran into an alien!");
		}
		planet.Explored += 1;
		Debug.Log ("Planet Explored!");
		return null;
	}
}
