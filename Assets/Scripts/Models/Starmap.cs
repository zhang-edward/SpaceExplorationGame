﻿using UnityEngine;
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
	void Awake () {
		Init ();
	}

	/// <summary>
	/// Initialize this instance.
	/// </summary>
	public void Init() {
		planets = new List<Planet> ();

		//TODO: Generate the planet randomly
		Planet p = new Planet("MVP tutorial");
		Planet p2 = new Planet("Planet A");
		planets.Add (p);
		planets.Add (p2);
	}

	// Update is called once per frame
	void Update () {
		
	}
}
