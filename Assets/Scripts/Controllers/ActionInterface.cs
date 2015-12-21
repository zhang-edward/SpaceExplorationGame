using UnityEngine;
using System.Collections;

public abstract class ActionInterface : MonoBehaviour {

	/// <summary>
	/// Whether or not this action leads to combat.
	/// </summary>
	protected bool combat;

	/// <summary>
	/// Gets or sets a value indicating whether this instance is combat.
	/// </summary>
	/// <value><c>true</c> if this instance is combat; otherwise, <c>false</c>.</value>
	protected bool IsCombat {
		get{return combat;}
		set{combat = value;}
	}

	/// <summary>
	/// Dos the action to the crew.
	/// </summary>
	/// <param name="crew">Crew.</param>
	public abstract void DoAction(Crew crew);
}
