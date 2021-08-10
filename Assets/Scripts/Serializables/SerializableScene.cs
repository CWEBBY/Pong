/* SerializableScene.cs, CWebb.
 */

using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(menuName = "Serializable/Scene", fileName = "New Serializable Scene")]
public class SerializableScene : Serializable<string> 
{
	// Properties
	private bool IsLoaded => 
		SceneManager.GetSceneByName(Value).isLoaded;

	// Functions
	public void Load()
	{
		if (!IsLoaded) 
			SceneManager.LoadScene(Value, LoadSceneMode.Additive);
	}

	public void Unload()
	{
		if (IsLoaded)
			SceneManager.UnloadSceneAsync(Value);
	}

	public void Reload()
	{
		Unload();
		Load();
	}
}