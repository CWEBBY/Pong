/* Ball.cs, CWebb.
 */

using UnityEngine;

public class Ball : MonoBehaviour
{
	private static Vector3 last_score_position = Vector3.left;  // A direction recorded to ...
																// ...  know where to serve the ball next.
							
	// Members												
	[SerializeField] SerializableFloat _speed;

	// Properties
	public Vector3 Velocity { get; set; }
	public bool HasScored { get; private set; }

	// Callbacks
	private void Start()		{ Velocity = last_score_position.normalized * _speed; }
	private void FixedUpdate()	{ transform.position += Velocity * Time.fixedDeltaTime; }

	private void OnTriggerEnter2D(Collider2D collision)
	{
		Transform hit = collision.transform;
		last_score_position = transform.position;

		if (collision.CompareTag("Goal"))			Destroy(gameObject);
		else if (collision.CompareTag("Wall"))		Velocity = new Vector3(Velocity.x, -Velocity.y);

		else if (collision.CompareTag("Paddle"))
		{
			// Step 1: Get psudo-normal from hit.
			Vector3 velocityNormal = Velocity.normalized;
			Vector3 hitNormal =
				(transform.position - hit.position).normalized;

			// Step 2: Add it to the reflection of the paddle.
			Velocity = new Vector3(
				-(velocityNormal.x - hitNormal.x),
				velocityNormal.x + hitNormal.y
			).normalized * _speed;
		}
	}
}