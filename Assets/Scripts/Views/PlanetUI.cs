using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlanetUI : MonoBehaviour {

	private Ship ship;

	/// <summary>
	/// The crew that this UI is currently assigning actions to
	/// </summary>
	private List<Crew> crewList;

	/// <summary>
	/// The index of the crew.
	/// </summary>
	private int crewIndex = 0;

	// Use this for initialization
	void Awake ()
	{
		ship = GameManager.instance.ship;
		crewList = ship.GetCrew();
	}


	/// <summary>
	/// Assigns the crew.
	/// </summary>
	/// <param name="crew">Crew.</param>
	/// <param name="actionNum">0 = Explore, 1 = Harvest.</param>
	public void PickActions(int actionNum)
	{
		GameManager.instance.AssignAction(crewList[crewIndex], actionNum);
		if (crewIndex < crewList.Count)
		{
			crewIndex ++;
		}
		else
		{
			GameManager.instance.DoActions();
			crewIndex = 0;
		}
	}
}
