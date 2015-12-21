using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Ship : MonoBehaviour {

	private List<Crew> crew;
	private float money;
	private Dictionary<Resource, int> resources;
	public Planet planet;
}