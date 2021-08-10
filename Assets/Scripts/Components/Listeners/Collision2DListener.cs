/* Collision2DListener.cs, CWebb.
 */

using System;
using UnityEngine;
using UnityEngine.Events;

public class Collision2DListener : MonoBehaviour
{
	[Serializable]
	public class CollisionEvent : UnityEvent<Collider2D> { }

	// Members
	[SerializeField] CollisionEvent _onEnter;
	[SerializeField] CollisionEvent _onExit;

	// Callbacks 
	private void OnTriggerExit2D(Collider2D collision)	{ _onExit?.Invoke(collision); }
	private void OnTriggerEnter2D(Collider2D collision) { _onEnter?.Invoke(collision); }
}