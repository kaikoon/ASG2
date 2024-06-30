/*
 * Author: Lim Kai Koon
 * Date: 30/6/24
 * Description: 
 * Death Screen will let player restart the scene or let the player quit into main menu
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    [SerializeField]
    GameObject deathScreen;
    public int heal = 100;

    //Player will restart the level and closes death screen
    public void Restart()
    {
        deathScreen.SetActive(false);
        SceneManager.LoadScene(2);
        Player player = GetComponent<Player>();
        if (player != null)
        player.HealPlayer(heal);
    }
    //Makes the player go back to main menu and closes death screen
    public void MainMenu()
    {
        deathScreen.SetActive(false);
        SceneManager.LoadScene(0);
    }
}
