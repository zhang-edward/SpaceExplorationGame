﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Ship : MonoBehaviour {

	public static Ship instance;

	private List<Crew> crew;
	private int money;
	private Dictionary<Resource, int> resources;
	public Planet planet;
}