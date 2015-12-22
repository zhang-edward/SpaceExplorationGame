using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class CommandUI : MonoBehaviour {

	/// <summary>
	/// The planet that this ui is representing.
	/// </summary>
	private Planet planet;

	/// <summary>
	/// The player ship.
	/// </summary>
	private Ship ship;

	/// <summary>
	/// The crew that this UI is currently assigning actions to
	/// </summary>
	private List<Crew> crewList;

	/// <summary>
	/// The index of the crew.
	/// </summary>
	private int crewIndex = 0;

	
	// UI stuff
	public Text crewText;
	public Text planetInfo;


	// Use this for initialization
	void Awake ()
	{
		ship = GameManager.instance.ship;
	}

	public void Init(Planet planet)
	{
		this.planet = planet;
		string civType = "Civilization Type: " + planet.GetCivType();
		planetInfo.text = planet.Name + "\n" + civType;
		crewList = ship.crewList;

	}

	/// <summary>
	/// Assigns the crew.
	/// </summary>
	/// <param name="crew">Crew.</param>
	/// <param name="actionNum">0 = Explore, 1 = Harvest.</param>
	public void PickActions(int actionNum)
	{
		GameManager.instance.AssignAction(crewList[crewIndex], actionNum);
		if (crewIndex < crewList.Count - 1)
		{
			crewIndex ++;
			crewText.text = "Crew #" + crewIndex;
		}
		else
		{
			crewText.text = "Doing Actions!";
			GameManager.instance.DoActions();
			crewIndex = 0;
		}
	}

	public void GoToStarmap()
	{
		ship.planet = null;
	}
}
