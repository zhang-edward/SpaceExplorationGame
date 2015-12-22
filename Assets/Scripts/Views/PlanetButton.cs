using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlanetButton : MonoBehaviour {

	/// <summary>
	/// The planet data.
	/// </summary>
	public Planet planet;

	public Sprite sprite;

	public void Init (Planet planet)
	{
		this.planet = planet;

		// TODO: pick sprite based on planet data
		GetComponent<Image>().sprite = sprite;
	}
}
