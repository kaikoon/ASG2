/*
 * Author: Lim Kai Koon
 * Date: 30/6/24
 * Description: 
 * Pause menu pause time, sends play to main menun or resumes game
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;

    public void Pause()
    {
        //The pause menu will appear on the player's screen
        pauseMenu.SetActive(true);
        //Pause time
        Time.timeScale = 0f;
    }

    public void Home()
    {
        //Sends player to startingscene
        SceneManager.LoadScene("StartingScreen");
        Time.timeScale = 1f;
    }

    public void Resume()
    {
        //Unpause the time and the menu disappears
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }
}
