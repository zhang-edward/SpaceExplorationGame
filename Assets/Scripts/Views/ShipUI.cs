using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class ShipUI : MonoBehaviour {

	/// <summary>
	/// The ship that this ui refers to
	/// </summary>
	public Ship ship; 

	/// <summary>
	/// UI Listing all resources.
	/// </summary>
	public Text resources;

	/// <summary>
	/// UI Listing the amount of money.
	/// </summary>
	public Text money;

	/// <summary>
	/// UI Listing the crew
	/// </summary>
	public Text crew;

	// Use this for initialization
	void Start () {
	}

	/// <summary>
	/// Initialize this instance.
	/// </summary>
	void Init() {
		this.ship = GameManager.instance.ship;
		setResources ();
		setMoney ();
		setCrew ();
	}

	/// <summary>
	/// Sets the resource UI.
	/// </summary>
	void setResources() {
		Dictionary<Resource, int> res = ship.getResources ();
		Debug.Log (res);
		foreach (KeyValuePair<Resource, int> entry in res) {
			resources.text = entry.Key.Name + ": " + entry.Value + "\n\n";
		}
	}

	/// <summary>
	/// Sets the money UI.
	/// </summary>
	void setMoney() {
		money.text = ship.Money.ToString ();
	}

	/// <summary>
	/// Sets the crew UI.
	/// </summary>
	void setCrew() {
		List<Crew> crews = ship.crewList;
		foreach (Crew member in crews) {
			crew.text = member.Name + "\n Health: " + member.health 
						+ "\n Strength: " + member.strength;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
