using UnityEngine;
using System.Collections;

public class Resource : MonoBehaviour {

	/// <summary>
	/// The shop value.
	/// </summary>
	private int shopValue;

	/// <summary>
	/// The name.
	/// </summary>
	private string name;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	/// <summary>
	/// Sets the shop value.
	/// </summary>
	public void SetShopValue(int shopValue) {
		this.shopValue = shopValue;
	}

	/// <summary>
	/// Gets the shop value.
	/// </summary>
	/// <returns>The shop value.</returns>
	public int GetShopValue() {
		return shopValue;
	}

	/// <summary>
	/// Sets the name.
	/// </summary>
	/// <param name="name">Name.</param>
	public void SetName(string name) {
		this.name = name;
	}

	/// <summary>
	/// Gets the name.
	/// </summary>
	/// <returns>The name.</returns>
	public string GetName() {
		return name;
	}
}
