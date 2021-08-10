/* Paddle.cs, CWebb.
 */

using UnityEngine;

public class Paddle : MonoBehaviour
{
	// Members
	[SerializeField] Player	_player;
	[SerializeField] Config	_config;

	// Callbacks
	public void Update()
	{
		Vector3 pos = transform.localPosition;

		pos.y = Mathf.Clamp(
			pos.y + _player.Axis * _config.Speed * Time.deltaTime,
			-_config.Range * .5f,   // The clamp just keeps the pos inside ...
			_config.Range * .5f     // ... the specified range of the paddle. 
		);

		transform.localPosition = pos;
	}
}