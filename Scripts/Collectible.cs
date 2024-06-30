/*
 * Author: Lim Kai Koon
 * Date: 30/6/24
 * Description: 
 * The Collectible will increase score, play an audio and destroy itself
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : Interactable
{
    [SerializeField]
    private AudioClip collectAudio;

    /// The score value that this collectible is worth.
    public int myScore = 5;

    /// Performs actions related to collection of the collectible
    public void Collected()
    {
        AudioSource.PlayClipAtPoint(collectAudio, transform.position, 1f);
        // Destroy the attached GameObject
        Destroy(gameObject);
    }


    public override void Interact(Player thePlayer)
    {
        base.Interact(thePlayer);
        GameManager.instance.IncreaseScore(myScore);
        Collected();
    }
}
