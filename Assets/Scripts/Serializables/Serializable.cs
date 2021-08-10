/* Serializable.cs, CWebb.
 */

using UnityEngine;

public abstract class Serializable<T> : ScriptableObject
{
    // Members
    [SerializeField] T _value; // Only a member to expose it to the editor...

    // Properties
    public virtual T Value 
    {
        get => _value;
        set => _value = value; 
    }

    // Functions
    public static implicit operator T(Serializable<T> serializableT) 
        => serializableT.Value; // Help readability by casting into the type we're serializing when applicable.
}