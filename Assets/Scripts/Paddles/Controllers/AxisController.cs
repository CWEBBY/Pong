/* AxisController.cs, CWebb.
 */

using UnityEngine;

[CreateAssetMenu(menuName = "Paddle/Controller/Axis", fileName = "New Axis Controller")]
public class AxisController : Controller
{
	// Members
	[SerializeField] string _axisName;

	// Properties
	public override float Value 
		=> Input.GetAxis(_axisName);
}