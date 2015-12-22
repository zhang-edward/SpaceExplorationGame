using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Planet : MonoBehaviour {

	/// <summary>
	/// The name of the planet.
	/// </summary>
	public string Name{get; set;}

	/// <summary>
	/// The resources of this planet.
	/// </summary>
	private Dictionary<Resource, int> resources;

	/// <summary>
	/// The resource types.
	/// </summary>
	private Resource[] resourceTypes;

	/// <summary>
	/// The resource prefabs.
	/// </summary>
	public GameObject[] resPrefabs = new GameObject[6];

	/// <summary>
	/// The types of aliens.
	/// </summary>
	private Alien[] alienTypes;

	/// <summary>
	/// The type of civilization on this planet
	/// </summary>
	public int civType;

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

	/// <summary>
	/// Gets or sets the resource level.
	/// </summary>
	/// <value>The resource level.</value>
	public int ResourceLevel { get; set; }

	/// <summary>
	/// The names of all resources.
	/// </summary>
	private static string[] names = new string[6] 
					{ "Wood", "Stone", "Metal", 
					"Gas", "Plastic", "Gems"};
    
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
		this.civType = GenCivType ();
		int count = 0;
		resourceTypes = GenResources (names);
		resources = new Dictionary<Resource, int> ();
		foreach (Resource res in resourceTypes) {
			if(count > 2) {
				resources.Add(res, 0);
			} else {
				resources.Add(res, 100);
			}
			count++;
		}
		ResourceLevel = 2; 
	}

	/// <summary>
	/// Generate the type of civ
	/// </summary>
	/// <returns>The civ type.</returns>
	int GenCivType() {
		int civ = Random.Range (1, 4);
		Debug.Log ("Civtype =" + civ);
		return civ;
	}

	/// <summary>
	/// Gens the resources.
	/// </summary>
	/// <returns>The resources.</returns>
	Resource[] GenResources(string[] resources) {
		Resource[] defres = new Resource[6];
		for(int i = 0; i < defres.Length; i++) {
			GameObject gobj = Instantiate(resPrefabs[i], transform.position, Quaternion.identity) as GameObject;
			Resource newres = gobj.GetComponent<Resource>();
			newres.Name = resources[i];
			newres.ShopValue = (i + 1) * 10;
			defres[i] = newres;
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

	public void AddResources(Resource res, int num) {
		resources [res] += num;
	}
}
