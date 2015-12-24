using UnityEngine;
using System.Collections;

public class ViewManager : MonoBehaviour {

	/// <summary>
	/// The singleton instance.
	/// </summary>
	public static ViewManager instance;

	/// <summary>
	/// The starmap UI.
	/// </summary>
	public StarmapUI StarmapUI;

	/// <summary>
	/// The planet UI.
	/// </summary>
	public CommandUI CommandUI;

	// UI Overlay
	public ShopUI ShopUI;

	// TODO: find a better way get which UI to display
	// UI display is based on the ship's planet variable, as well as if the player has opened some menu
	public bool shopping;

	void Awake() {
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy(gameObject);
		
		DontDestroyOnLoad(gameObject);
	}

	void Update()
	{
		Planet planet = GameManager.instance.ship.planet;

		// TODO: set UIs to id # to make switching easier
		if (planet == null)
		{
			StarmapUI.gameObject.SetActive (true);
			CommandUI.gameObject.SetActive (false);
		}
		else
		{
			StarmapUI.gameObject.SetActive (false);
			CommandUI.gameObject.SetActive (true);
			CommandUI.Init(planet);
		}

		if (shopping)
		{
			ShopUI.gameObject.SetActive (true);
		}
		else
		{
			ShopUI.gameObject.SetActive (false);
		}
	}

	public void setShopping(bool b)
	{
		shopping = b;
	}
}