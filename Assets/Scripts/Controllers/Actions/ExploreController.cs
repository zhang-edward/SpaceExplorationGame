using UnityEngine;
using System.Collections;

public class ExploreController : Action {

	/// <summary>
	/// Does the action to the crew.
	/// </summary>
	/// <param name="crew">Crew.</param>
	/// <param name="member">Member.</param>
	public override string DoAction(Crew member, Planet planet, Ship ship) {
		int combatchance = Random.Range (0, planet.GetCivType() * 3);
		if (combatchance == 0) {
			IsCombat = true;
			Debug.Log(member.Name + " Ran into an alien!");
		}
		planet.Explored += 5; 
		if (planet.Explored >= 10) {
			string msg = DiscoverResource(planet);
			Debug.Log(msg);
		}
		Debug.Log (member.Name + " Explored Planet!");
		return member.Name + "Explored " + planet.Name;
	}

	public string DiscoverResource(Planet planet) {
		Resource[] resources = planet.GetResourceTypes ();
		planet.Explored = 0;
		planet.ResourceLevel ++;
		if (planet.ResourceLevel < 6) {
			planet.AddResources (resources [planet.ResourceLevel], 100);
			return "Discovered " + resources[planet.ResourceLevel].Name; 
		} else {
			int randres = Random.Range(0, 6);
			planet.AddResources(resources[randres], 100);
			return "Discovered more " + resources[randres].Name;
		}
	}
}