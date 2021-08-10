/* SerializableUnityEvent.cs, CWebb.
 */

using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Serializable/UnityEvent", fileName = "New Serializable UnityEvent")]
public sealed class SerializableUnityEvent : Serializable<UnityEvent> 
{
	// Functions
	[ContextMenu("Invoke")]
	public void Invoke()								{ Value?.Invoke(); }
	public void AddListener(UnityAction listener)		{ Value.AddListener(listener); }
	public void RemoveListener(UnityAction listener)	{ Value.RemoveListener(listener); }
}