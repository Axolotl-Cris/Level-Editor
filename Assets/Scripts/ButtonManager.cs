using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    private int sceneToLoad;
    private int currentSceneIndex;
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadGame()
    {
        sceneToLoad = PlayerPrefs.GetInt("SavedScene");
        if (sceneToLoad != 0)
            SceneManager.LoadScene(sceneToLoad);
        else
        {
            return;
        }
        Debug.Log("Game has loaded");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game Over");
    }

    public void GoToMainMenu()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("SavedScene", currentSceneIndex);
        SceneManager.LoadScene(0);
        Debug.Log("You are in the main menu now");
    }
    
}
