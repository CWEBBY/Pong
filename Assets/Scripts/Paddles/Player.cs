/* Player.cs, CWebb.
 */

using UnityEngine;

[CreateAssetMenu(menuName = "Paddle/Player", fileName = "New Player")]
public class Player : ScriptableObject
{
	// Members
	[SerializeField] SerializableInt _score;
	[SerializeField] Controller _controller;

	// Properties
	public int Score => _score;
	public float Axis => _controller.Value;

	// Functions
	public void SetController(Controller controller)
		{ _controller = controller; }
}