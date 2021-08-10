/* EventListener.cs, CWebb.
 */

using UnityEngine;
using UnityEngine.Events;

public class EventListener : MonoBehaviour
{
    // Members
    [SerializeField] SerializableUnityEvent _event;
    [SerializeField] UnityEvent             _response;

    // Callbacks
    private void OnEvent()      { _response?.Invoke(); }
    private void OnEnable()     { _event?.AddListener(OnEvent); }
    private void OnDisable()    { _event?.RemoveListener(OnEvent); }
}