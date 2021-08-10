/* Scorecard.cs, CWebb.
 */

using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Scorecard : MonoBehaviour
{
	// Members
	[Header("Score")]
	[SerializeField] Text					_display;
	[SerializeField] SerializableInt		_score;
	[SerializeField] SerializableUnityEvent _updateScore;
	
	[Header("Game")]
	[SerializeField] SerializableFloat		_endDelay;
	[SerializeField] SerializableInt		_winningScore;

	[Header("Dispatched Events")]
	[SerializeField] SerializableUnityEvent _gameEndEvent;

	// Callbacks
	private void OnEnable()		{ _updateScore.AddListener(OnScored); }
	private void OnDisable()	{ _updateScore.RemoveListener(OnScored); }

	private void OnScored()
	{
		_score.Value++;

		if (_display) 
			_display.text = $"{_score.Value}";

		if (_score.Value >= _winningScore)
			StartCoroutine(DisplayFinalScores());
	}

	// Iterators
	private IEnumerator DisplayFinalScores()
	{
		yield return new WaitForSeconds(_endDelay);
		_gameEndEvent?.Invoke();
	}
}