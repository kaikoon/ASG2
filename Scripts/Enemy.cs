using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    bool lookat = false;
    public GameObject player;
    public GameObject bullet;
    Rigidbody rb;
    public float speed = 10;
    public float multiplier = 10;
    public int maxHealth = 100;
    public int currentHealth;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        //if bullet hits enemy take damage if health > 0 else destroy gameobject
        if(currentHealth > 0)
        {
            maxHealth -= damage;
        }
        else
        {

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
            transform.LookAt(player.transform);
            Vector3 vel = rb.velocity;
            if(!DetectPlayer.found && vel.x > -2 && vel.x < 2 && vel.z > -2 && vel.z < 2)
            {
                rb.AddForce(speed * multiplier * Time.deltaTime * transform.forward);
            }
        }
    }
}
