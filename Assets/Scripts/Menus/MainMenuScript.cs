using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuScript : MonoBehaviour
{
    public GameObject OptionsMenu;
    public GameObject MainMenu;
    public GameObject PlayMenu;

    public void Play()
    {
        MainMenu.SetActive(false);
        PlayMenu.SetActive(true);
    }

    public void Options()
    {
        OptionsMenu.SetActive(true);
        MainMenu.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Exiting Application");
    }
}
