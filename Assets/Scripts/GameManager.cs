using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int createdTiles = 0;

    public void SaveGame()
    {
        PlayerPrefs.SetInt("TilesKey", createdTiles);
    }

    public void LoadGame()
    {
        createdTiles = PlayerPrefs.GetInt("TilesKey", 0);
        if (PlayerPrefs.HasKey("TilesKey"))
        {
            //sample
        }
    }

    public void ResetGame()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.DeleteKey("TilesKey");
    }
}
