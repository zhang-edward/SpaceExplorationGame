using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Shop {

	public Ship ship;

	public Shop(Ship ship)
	{
		this.ship = ship;
	}

	// TODO: generate crew for hire
	private int crewPrice = 10;
	public int CrewPrice {
		get{return crewPrice;}
	}

	public void SellAll()
	{
		Dictionary <Resource, int> resList = ship.Resources;
		List<Resource> keyList = new List<Resource>(ship.Resources.Keys);
		foreach (Resource res in keyList)
		{
			ship.AddMoney(res.ShopValue * resList[res]);
			ship.RemoveResources(res, resList[res]);
		}
	}
}
