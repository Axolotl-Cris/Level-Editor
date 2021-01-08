
using UnityEngine;

public class GameSettings : MonoBehaviour
{
    public int createdTiles = 0;
    public void SaveGame()
    { 
        PlayerPrefs.SetInt("TilesKey", createdTiles);
    }

    public void LoadGame()
    { 
        createdTiles = PlayerPrefs.GetInt("TilesKey", 0);
    }

    public void ResetGame() 
    { 
        PlayerPrefs.DeleteAll();
        PlayerPrefs.DeleteKey("TilesKey");
    }
}