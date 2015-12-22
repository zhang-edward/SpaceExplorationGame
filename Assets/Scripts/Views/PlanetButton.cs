using UnityEngine;
using System.Collections;

public class PlanetButton : MonoBehaviour {

	/// <summary>
	/// The planet data.
	/// </summary>
	public Planet planet;

	private StarmapUI starmapUI;

	/// <summary>
	/// The sprite.
	/// </summary>
	public Sprite sprite;

	/// <summary>
	/// The Sprite Renderer.
	/// </summary>
	private SpriteRenderer sr;

	void Awake()
	{
		sr = GetComponent<SpriteRenderer>();
	}

	public void Init (StarmapUI ui, Planet planet)
	{
		this.starmapUI = ui;
		this.planet = planet;
		Debug.Log ("Planet Name: " + planet.Name);
		Debug.Log ("Planet Civ Type: " + planet.GetCivType());

		sr.sprite = sprite;
	}

	void OnMouseDown()
	{
		starmapUI.Travel (planet);
	}
}
