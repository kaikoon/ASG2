using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{
    public int damage;
    public Collider player;

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
