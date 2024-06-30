/*
 * Author: Lim Kai Koon
 * Date: 30/6/24
 * Description: 
 * Brings player to win scene
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene(4);
        }
    }
}
