/*
 * Author: Lim Kai Koon
 * Date: 30/6/24
 * Description: 
 * Shows player's health, maxhealth, damage and heal
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField]
    Transform playerCamera;

    [SerializeField]
    float interactionDistance;

    [SerializeField]
    TextMeshProUGUI interactionText;

    [SerializeField]
    GameObject deathScreen;

    //Player variables for healing and taking damage
    public int maxHealth = 100;
    public int currentHealth;
    public int damage = 0;
    public int heal = 0;

    //Get healthbar
    public HealthBar healthBar;

    //Sets player's healthbar to full
    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }


    private void Update()
    {
        //Player will take damage unless their health drops to 0 or below
        if (currentHealth > 0)
        {
            DamageTaken(damage);
        }
        //Debug.DrawLine(playerCamera.position, playerCamera.position + (playerCamera.forward * interactionDistance), Color.red);
        RaycastHit hitInfo;
        if(Physics.Raycast(playerCamera.position, playerCamera.forward, out hitInfo, interactionDistance))
        {
            //print what i hit
            Debug.Log(hitInfo.transform.name);
            if (hitInfo.transform.TryGetComponent<Interactable>(out currentInteractable))
            {
                //Display interaction text
                interactionText.gameObject.SetActive(true);
            }
            else
            {
                currentInteractable = null;
                interactionText.gameObject.SetActive(false);
            }
        }
        else
        {
            currentInteractable = null;
            interactionText.gameObject.SetActive(false);
        }
        if (currentHealth <= 0)
        {
            Death();
        }
    }

    public TextMeshProUGUI scoreText;

    /// The current score of the player
    int currentScore = 0;

    /// Store the current door in front of the player
    Door currentDoor;

    /// Store the current collectible that the player is touching
    Collectible currentCollectible;

    Interactable currentInteractable;

    /// Increases the score of the player by <paramref name="scoreToAdd"/>
    /// <param name="scoreToAdd">The amount to increase by</param>
    public void IncreaseScore(int scoreToAdd)
    {
        // Increase the score of the player by scoreToAdd
        currentScore += scoreToAdd;

        scoreText.text = "Score: " + currentScore.ToString();
    }

    public void UpdateDoor(Door newDoor)
    {
        currentDoor = newDoor;
    }

    public void UpdateCollectible(Collectible newCollectible)
    {
        currentCollectible = newCollectible;
    }


    void OnInteract()
    {
        // This is "null check"
        if(currentDoor != null)
        {
            currentDoor.OpenDoor();
            currentDoor = null;
        }

        // Do a null check for the currentCollectible
        if(currentCollectible != null)
        {
            IncreaseScore(currentCollectible.myScore);
            currentCollectible.Collected();
        }

        if(currentInteractable != null)
        {
            currentInteractable.Interact(this);
        }
    }

    //Deducts player health and updates the healthbar
    public void DamageTaken(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        damage = 0;
    }
    //Increases player health and updates healthbar
    public void HealPlayer(int heal)
    {
        currentHealth += heal;
        healthBar.SetHealth(currentHealth);
        heal = 0;
    }
    //Player can use their cursor to interact with UI
    void OnUnlockCursor()
    {
        Cursor.lockState = CursorLockMode.None;
    }
    //Player can lock cursor
    void OnLockCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    //Shows the death screen
    public void Death()
    {
        deathScreen.SetActive(true);
    }

}
