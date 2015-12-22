using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Starmap : MonoBehaviour {

	/// <summary>
	/// The planets.
	/// </summary>
	public List<Planet> planets; //TODO: Temp public for testing

	/// <summary>
	/// The planet prefab.
	/// </summary>
	public GameObject planetPrefab;

	/// <summary>
	/// The res prefabs.
	/// </summary>
	public GameObject[] resPrefabs = new GameObject[6];

	// Use this for initialization
	void Start () {
		Init ();
	}

	/// <summary>
	/// Initialize this instance.
	/// </summary>
	public void Init() {
		planets = new List<Planet> ();

		//TODO: Generate the planet randomly
		Planet p = new Planet("MVP tutorial");
		planets.Add (p);

	}

	// Update is called once per frame
	void Update () {
		
	}
}
