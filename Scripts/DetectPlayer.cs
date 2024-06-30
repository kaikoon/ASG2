/*
 * Author: Lim Kai Koon
 * Date: 30/6/24
 * Description: 
 * Detects player for enemy to follow player
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPlayer : MonoBehaviour
{
    //Player at the start is not found yet
    static public bool found = false;

    //Check if player enters trigger zone
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            found = true;
        }
    }
    //Reset found bool to false when player leaves triggerzone
    private void OnTriggerExit(Collider other)
    {
        found = false;
    }
}
