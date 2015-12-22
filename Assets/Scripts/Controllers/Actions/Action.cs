using UnityEngine;
using System.Collections;

public abstract class Action {

	/// <summary>
	/// Whether or not this action leads to combat.
	/// </summary>
	protected bool combat;

	/// <summary>
	/// Gets or sets a value indicating whether this instance is combat.
	/// </summary>
	/// <value><c>true</c> if this instance is combat; otherwise, <c>false</c>.</value>
	public bool IsCombat {
		get{return combat;}
		set{combat = value;}
	}

	/// <summary>
	/// Dos the action.
	/// </summary>
	/// <returns>string describing the action</returns>
	/// <param name="crew">Crew.</param>
	/// <param name="planet">Planet.</param>
	/// <param name="ship">Ship.</param>
	public abstract string DoAction(Crew crew, Planet planet, Ship ship);
}
