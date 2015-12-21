using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static GameManager instance;

	private Ship ship;
	private Starmap starmap;
	private Shop shop;
	private CombatManager combat;

	private int turn = 0;

	void Awake()
	{
		// make this 
		if (instance != null)
			Destroy (gameObject);
		else
			instance = this;

		DontDestroyOnLoad();
	}

	public void Init()
	{
		ship.Init();
		starMap.Init();
		shop.Init();
	}

	public void ProcessCrew()
	{
		turn ++;
	}

	public void Travel(Planet planet)
	{
		ship.planet = planet;
		turn ++;
	}

	public void SetBase()
	{
		ship.planet.hasBase = true;
		turn ++;
	}
}
