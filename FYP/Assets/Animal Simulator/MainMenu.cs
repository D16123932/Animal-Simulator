using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("PLAY Clicked");
        Application.Quit();
    }
    
    public void GoToSettingMenu()
    {
        Debug.Log("SETTINGS Clicked");
        SceneManager.LoadScene("SettingMenu");
    }

    public void GoToMainMenu()
    {
        Debug.Log("Back Clicked");
        SceneManager.LoadScene("MainMenu");
    }
    public void QuitGame()
    {
        Debug.Log("QUIT Clicked");
        Application.Quit();
    }
}
