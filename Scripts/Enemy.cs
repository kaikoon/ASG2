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
    public float speed = 10;
    public float multiplier = 10;
    public int maxHealth = 100;
    public int currentHealth;
    public int damage;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        currentHealth = maxHealth;
    }

    private void ShootPlayer()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        //if bullet hits enemy take damage if health > 0 else destroy gameobject
        if(Collider.tag == "Bullet")
        {
            currentHealth -= damage;
            Defeated();
            Debug.Log("Hit");
        }
    }

    private void Defeated()
    {
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
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
