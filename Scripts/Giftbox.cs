using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleBox : MonoBehaviour
{
    [SerializeField]
    private GameObject collectibleToSpawn;

    [SerializeField]
    private AudioClip openAudio;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(openAudio, transform.position, 1f);
            SpawnCollectible();
            Destroy(gameObject);
        }
    }


    void SpawnCollectible()
    {
        Instantiate(collectibleToSpawn, transform.position, collectibleToSpawn.transform.rotation);
    }
}
