/*
 * Author: Lim Kai Koon
 * Date: 30/6/24
 * Description: 
 * Hazard that damages player
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{
    public int damage;

    //Will damage the player according to value set and checks if player is null
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Player player = other.GetComponent<Player>();
            Debug.Log("Player collided");
            if (player != null )
            {
                player.DamageTaken(damage);
                Debug.Log("I took damage");
            }
        }
    }

}
