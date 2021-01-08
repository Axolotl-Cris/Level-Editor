using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameSettings : MonoBehaviour
{
    public int createdTiles = 0;
    public void SaveGame()
    { 
        PlayerPrefs.SetInt ("LevelEditorMain", SceneManager.GetActiveScene ().buildIndex);
        PlayerPrefs.Save ();
        Debug.Log("SAVE BUTTON CLICKED");
    }

    public void LoadGame()
    {
        //PlayerPrefs.SetInt ("LevelEditorMain", SceneManager.GetActiveScene ().buildIndex);
        //Debug.Log("LOAD BUTTON CLICKED");
    }

    public void ResetGame() 
    { 
        //SceneManager.LoadScene("LevelEditorMain");
        //Debug.Log("RESET BUTTON CLICKED");
    }
}