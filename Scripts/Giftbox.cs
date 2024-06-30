/*
 * Author: Lim Kai Koon
 * Date: 30/6/24
 * Description: 
 * Giftbox after interacted gives player a collectible
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleBox : MonoBehaviour
{
    //What collectible to spawn
    [SerializeField]
    private GameObject collectibleToSpawn;

    [SerializeField]
    private AudioClip openAudio;

    //Spawn collectible and destroys itself
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(openAudio, transform.position, 1f);
            SpawnCollectible();
            Destroy(gameObject);
        }
    }

    //Spawn collectible at giftbox's position
    void SpawnCollectible()
    {
        Instantiate(collectibleToSpawn, transform.position, collectibleToSpawn.transform.rotation);
    }
}
