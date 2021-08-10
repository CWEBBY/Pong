/* Config.cs, CWebb.
 */

using UnityEngine;

[CreateAssetMenu(menuName = "Paddle/Config", fileName = "New Config")]
public class Config : ScriptableObject
{
    // Members
    [SerializeField] SerializableFloat _speed;
    [SerializeField] SerializableFloat _range;

    // Properties
    public float Speed => _speed;
    public float Range => _range;
}