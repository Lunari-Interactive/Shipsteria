using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomiseGame : MonoBehaviour
{
    public int playerCount = 1;
    public int sceneToLoad;

    public bool isMainMenuGameScript = true;

    public bool randomShips = false;

    public bool allowPowerups = true;
    public bool allowHealthbar = false;
    public bool allowStartingPowerup = false;
    public bool killOnTouchingSides = false;

    public Slider playerCountSlider;

    int BoolToInt(bool val)
    {
        if (val)
            return 1;
        else
            return 0;
    }

    bool IntToBool(int val)
    {
        if (val != 0)
            return true;
        else
            return false;
    }

    // Start is called before the first frame update
    void Start()
    {
        if (!isMainMenuGameScript)
        {
            LoadData();
        }
    }

    // Update is called once per frame
    void Update()
    {
        playerCount = (int)playerCountSlider.value;
        if (isMainMenuGameScript)
        {
            SaveData();
        }
        else
            return;
    }

    public void SaveData()
    {
        PlayerPrefs.SetInt("PlayerCount", playerCount);
        PlayerPrefs.SetInt("RandomizeShips", BoolToInt(randomShips));
        PlayerPrefs.SetInt("AllowPowerups", BoolToInt(allowPowerups));
        PlayerPrefs.SetInt("AllowHealthbar", BoolToInt(allowHealthbar));
        PlayerPrefs.SetInt("AllowStartingPowerup", BoolToInt(allowStartingPowerup));
        PlayerPrefs.SetInt("KillOnTouchingSides", BoolToInt(killOnTouchingSides));
    }

    public void LoadData()
    {
        randomShips = IntToBool(PlayerPrefs.GetInt("RandomizeShips"));
        randomShips = IntToBool(PlayerPrefs.GetInt("AllowPowerups"));
        randomShips = IntToBool(PlayerPrefs.GetInt("AllowHealthbar"));
        randomShips = IntToBool(PlayerPrefs.GetInt("AllowStartingPowerup"));
        randomShips = IntToBool(PlayerPrefs.GetInt("KillOnTouchingSides"));
    }
}
