using UnityEngine;
using System.Collections;

public class ShopUI : MonoBehaviour {

	public Shop shop;

	void Start()
	{
		shop = new Shop(GameManager.instance.ship);
	}

	public void SellAll()
	{
		shop.SellAll ();
	}
}
