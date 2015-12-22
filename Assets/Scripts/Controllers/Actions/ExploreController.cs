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
		Debug.Log (planet.GetCivType ());
		Debug.Log (combatchance + " = combatchance");
		if (combatchance == 0) {
			IsCombat = true;
			Debug.Log(member.Name + " Ran into an alien!");
		}
		planet.Explored += 1;
		Debug.Log (member.Name + " Explored Planet!");
		return null;
	}
}
