/*
 * Author: Elyas Chua-Aziz
 * Date: 06/05/2024
 * Description: 
 * The door that opens when the player is near it and presses the interact button.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    /// <summary>
    /// Flags if the door is open
    /// </summary>
    bool opened = false;

    /// <summary>
    /// Flags if the door is locked
    /// </summary>
    bool locked = false;

    /// <summary>
    /// Handles the door opening 
    /// </summary>
    public void OpenDoor()
    {
        if(!locked)
        {
            // Cannot directly modify the transform rotation.
            // transform.eulerAngles.y += 90f;

            // Create a new Vector3 and store the current rotation.
            Vector3 newRotation = transform.eulerAngles;

            // Add 90 degrees to the y axis rotation
            newRotation.y += 90f;

            // Assign the new rotation to the transform
            transform.eulerAngles = newRotation;

            opened = true;
        }
    }

    /// <summary>
    /// Sets the lock status of the door.
    /// </summary>
    /// <param name="lockStatus">The lock status of the door</param>
    public void SetLock(bool lockStatus)
    {
        // Assign the lockStatus value to the locked bool.
        locked = lockStatus;
    }
}
