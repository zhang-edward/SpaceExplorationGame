using UnityEngine;
using System.Collections;

public class Alien : MonoBehaviour {

	/// <summary>
	/// health of the alien.
	/// </summary>
	private int health;

	/// <summary>
	/// The strength of the alien.
	/// </summary>
	private int strength;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	/// <summary>
	/// Gets the health.
	/// </summary>
	/// <returns>The health.</returns>
	public int GetHealth() {
		return health;
	}

	/// <summary>
	/// Sets the health.
	/// </summary>
	public void SetHealth() {
		this.health = health;
	}

	/// <summary>
	/// Gets the strength.
	/// </summary>
	/// <returns>The strength.</returns>
	public int GetStrength() {
		return strength;
	}

	/// <summary>
	/// Sets the strength.
	/// </summary>
	/// <param name="strength">Strength.</param>
	public void SetStrength(int strength) {
		this.strength = strength;
	}
}
