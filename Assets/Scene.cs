using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

	public void GantiScene(string scene_name)
	{
		SceneManager.LoadScene(scene_name);
	}

    public void Quit()
    {
        Application.Quit();
    }
}
