/*
 * Author: Lim Kai Koon
 * Date: 30/6/24
 * Description: 
 * Find out what player interacted
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public virtual void Interact(Player thePlayer)
    {
        Debug.Log(gameObject.name + "was interacted");
    }
}
