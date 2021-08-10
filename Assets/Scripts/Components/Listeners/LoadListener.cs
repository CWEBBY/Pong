/* LoadListener.cs, CWebb.
 */

using UnityEngine;
using UnityEngine.Events;

public class LoadListener : MonoBehaviour
{
	// Members
	[SerializeField] UnityEvent _onLoad;

	// Callbacks
	private void Awake() 
		{ _onLoad?.Invoke(); }
}