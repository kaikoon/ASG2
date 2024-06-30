/*
 * Author: Lim Kai Koon
 * Date: 30/6/24
 * Description: 
 * Starting Screen menu
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartingScreen : MonoBehaviour
{
    //When player clicks play send player to level
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("SampleScene");
    }
    //When player clicks on quit, the player exits the game
    public void QuitGame()
    {
        Application.Quit();
    }
}
