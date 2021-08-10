/* BotController.cs, CWebb.
 */

using UnityEngine;

[CreateAssetMenu(menuName = "Paddle/Controller/Bot", fileName = "New Bot Controller")]
public class BotController : Controller
{
	// Members
	[SerializeField] SerializableVector3 _ballPosition;
	[SerializeField] SerializableVector3 _paddlePosition;

	// Properties
	public override float Value => CalculateAxis();

	// Functions 
	private float CalculateAxis() 
		{ return (_ballPosition.Value - _paddlePosition.Value).normalized.y; }
}