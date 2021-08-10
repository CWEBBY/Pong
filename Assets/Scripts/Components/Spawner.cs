/* Spawner.cs, CWebb.
 */

using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	// Members
	[SerializeField] SerializableFloat	_delay;
	[SerializeField] GameObject			_prefab;

	// Iterators
	private IEnumerator Start()
	{
		yield return
				new WaitForSeconds(_delay);

		Instantiate(_prefab, transform);
	}
}