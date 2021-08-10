/* PositionListener.cs, CWebb.
 */

using UnityEngine;

public class PositionListener : MonoBehaviour
{
	// Members
	[SerializeField] SerializableVector3 _arg;

	// Callbacks
	private void Update()							// This class doesn't follow regular listener ...
		{ _arg.Value = transform.localPosition; }   // ... structure due to how often it is called. 
}