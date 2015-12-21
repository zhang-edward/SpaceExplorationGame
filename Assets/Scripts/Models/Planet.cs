using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Planet : MonoBehaviour {

	/// <summary>
	/// The name of the planet.
	/// </summary>
	private string name;

	/// <summary>
	/// The resources of this planet.
	/// </summary>
	private Dictionary<Resource, int> resources;

	/// <summary>
	/// The resource types.
	/// </summary>
	private Resource[] resourceTypes;

	/// <summary>
	/// The types of aliens.
	/// </summary>
	private Alien[] alienTypes;

	/// <summary>
	/// The type of civilization on this planet
	/// </summary>
	private int civType;

	/// <summary>
	/// True if a base has been established.
	/// </summary>
	private bool hasBase = false; 


	/// <summary>
	/// Amount of explored (Max = 100).
	/// </summary>
	private int explored; 

	public int Explored {
		get{ return explored;}
		set{ explored = value;}
	}

	private static string[] names = new string[6] {"Wood", "Stone", "Metal", "Gas",
		"Plastic", "Gems"};
    
    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	/// <summary>
	/// Initialize with the specified name.
	/// </summary>
	/// <param name="name">Name.</param>
	public void Init(string name) {
		this.name = name;
		civType = GenCivType ();

		//TODO: Figure out resources
	}

	/// <summary>
	/// Generate the type of civ
	/// </summary>
	/// <returns>The civ type.</returns>
	int GenCivType() {
		return Random.Range (1, 3);
	}

	/// <summary>
	/// Gens the resources.
	/// </summary>
	/// <returns>The resources.</returns>
	Resource[] GenResources(Resource[] resources) {
		Resource[] defres = new Resource[3];
		for(int i = 0; i < defres.Length; i++) {
			defres[i] = resources[i];
		}
		return defres;
	}

	/// <summary>
	/// Gets the type of the civ.
	/// </summary>
	/// <returns>The civ type.</returns>
	public int GetCivType() {
		return civType;
	}

	/// <summary>
	/// Sets the type of the civ.
	/// </summary>
	/// <param name="civType">Civ type.</param>
	public void SetCivType(int civType) {
		this.civType = civType;
	}

	/// <summary>
	/// Gets the resource types.
	/// </summary>
	/// <returns>The resource types.</returns>
	public Resource[] GetResourceTypes() {
		return resourceTypes;
	}

	/// <summary>
	/// Fills in resource types.
	/// </summary>
	/// <returns>The resource.</returns>
	public void SetResourceTypes(Resource[] resourceTypes) {
		this.resourceTypes = resourceTypes;
	}

	/// <summary>
	/// Discovers a new resource.
	/// </summary>
	public void DiscoverResource() {
		if (explored > 10) {
			
		}
	}

	/// <summary>
	/// Gets the alien types.
	/// </summary>
	/// <returns>The alien types.</returns>
	public Alien[] GetAlienTypes() {
		return alienTypes;
	}

	/// <summary>
	/// Sets the alien types.
	/// </summary>
	/// <param name="alienTypes">Alien types.</param>
	public void SetAlienTypes(Alien[] alienTypes) {
		this.alienTypes = alienTypes;
	}

	/// <summary>
	/// Gets the bases.
	/// </summary>
	/// <returns><c>true</c>, if there is a base, <c>false</c> otherwise.</returns>
	public bool GetBases() {
		return hasBase;
	}

	/// <summary>
	/// Toggles the base.
	/// </summary>
	public void ToggleBase() {
		hasBase = !hasBase;
	}

	/// <summary>
	/// Gets the name.
	/// </summary>
	/// <returns>The name.</returns>
	public string GetName() {
		return name;
	}

	/// <summary>
	/// Sets the name.
	/// </summary>
	/// <param name="name">Name.</param>
	public void SetName(string name) {
		this.name = name;
	}

	/// <summary>
	/// Removes the resources.
	/// </summary>
	/// <param name="res">Res.</param>
	/// <param name="num">Number.</param>
	public void RemoveResources(Resource res, int num) {
		resources [res] -= num;
	}
}
