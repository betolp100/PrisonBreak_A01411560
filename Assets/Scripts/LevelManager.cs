using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelManager : MonoBehaviour
{

	public void LoadLevel(string name)
	{
		Debug.Log ("Level Load Requested for: "+name);
		SceneManager.LoadScene(name);
	}
	
	public void quitLevel()
	{
		Debug.Log ("Game Finished");
		Application.Quit();
	}
	
}