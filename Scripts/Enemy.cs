/*
 * Author: Lim Kai Koon
 * Date: 30/6/24
 * Description: 
 * Enemy movement and damage it takes
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform player;

    bool lookat = false;
    public Collider Collider;
    Rigidbody rb;
    //Enemy stats
    public float speed = 10;
    public float multiplier = 10;
    public int maxHealth = 100;
    public int currentHealth;
    public int damage;

    //set enemy health to max health
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        currentHealth = maxHealth;
    }

    private void Attack()
    {

    }
    //Check when the bullet hits so that it takes damage
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            currentHealth -= damage;
            Debug.Log("Hit");
            if (currentHealth <= 0 )
            Defeated();
        }
    }
    
    /*private void OnCollisionEnter(Collision collision)
    {
        //if bullet hits enemy take damage if health > 0 else destroy gameobject
        if(Collider.tag == "Bullet")
        {
            currentHealth -= damage;
            Defeated();
            Debug.Log("Hit");
        }
    }*/

    //Destroys itself when its health is <= 0
    private void Defeated()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        //The enemy will look at player if it enters a triggerzone then it will follow the player
        if (DetectPlayer.found)
        {
            lookat = true;
        }
        if(lookat)
        {
            enemy.SetDestination(player.position);
            transform.LookAt(player.transform);
        }
    }
}
