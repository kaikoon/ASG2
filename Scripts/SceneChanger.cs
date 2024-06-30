/*
 * Author: Lim Kai Koon
 * Date: 30/6/24
 * Description: 
 * Changes to selected scene
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public int targetSceneIndex;
    //After player enters scene changer sends player to selected scene according to targetsceneindex
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            SceneManager.LoadScene(targetSceneIndex);
        }
    }
}
