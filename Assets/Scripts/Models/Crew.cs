using UnityEngine;
using System.Collections;

public class Crew : MonoBehaviour {

	private int health;
	public int Health {
		get{return health;}
		set{health = value;}
	}

	private int strength;
	public int Strength {
		get{return strength;}
	}

	private string name;
	public string Name{
		get{ return name;}
		set{ name = value;}
	}
}
