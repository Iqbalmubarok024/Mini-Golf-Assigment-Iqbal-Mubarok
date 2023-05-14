using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelButton : MonoBehaviour
{
    private void OnEnable()
    {
        var currentScene = SceneManager.GetActiveScene();
        int currentLevel = int.Parse (currentScene.name.Split("Level_")[1]);
        int nextLevel = currentLevel + 1;

        var nextSceneBuildIndex = SceneUtility.GetBuildIndexByScenePath("Level_" + nextLevel);
        if(nextSceneBuildIndex == -1)
            this.gameObject.SetActive(false);
    }
    
    public void nextLevel()
    {
        var currentScene = SceneManager.GetActiveScene();
        int currentLevel = int.Parse (currentScene.name.Split("Level_")[1]);
        int nextLevel = currentLevel + 1;
        SceneManager.LoadScene("Level_"+ nextLevel);
    }

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
