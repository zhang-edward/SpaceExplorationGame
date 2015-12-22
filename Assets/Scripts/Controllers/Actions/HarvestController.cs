using UnityEngine;
using System.Collections;

public class HarvestController : Action {

	/// <summary>
	/// Does the action to the crew.
	/// </summary>
	/// <param name="crew">Crew.</param>
	/// <param name="member">Member.</param>
	public override string DoAction(Crew member, Planet planet, Ship ship) {
		Resource[] res = planet.GetResourceTypes ();
		int resnum = Random.Range (0, planet.ResourceLevel);

		//TODO: Randomly Generate resource amounts
		ship.AddResources (res [resnum], 5);
		planet.RemoveResources (res [resnum], 5);

		Debug.Log (member.Name + " got 5 " + res[resnum].Name + "!");
		return member.Name + " got 5 " + res[resnum].Name + "!"; 
	}
}
