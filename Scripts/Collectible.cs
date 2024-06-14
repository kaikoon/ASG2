/*
 * Author: Elyas Chua-Aziz
 * Date: 06/05/2024
 * Description: 
 * The Collectible will destroy itself after being collided with.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : Interactable
{
    [SerializeField]
    private AudioClip collectAudio;

    /// <summary>
    /// The score value that this collectible is worth.
    /// </summary>
    public int myScore = 5;

    /// <summary>
    /// Performs actions related to collection of the collectible
    /// </summary>
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
