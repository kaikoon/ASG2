using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject player;
    private GameObject instance;

    void Start()
    {
        if (FindObjectOfType<Player>() == null)
        {
            instance = Instantiate(player, transform.position, transform.rotation);
        }
    }
}
