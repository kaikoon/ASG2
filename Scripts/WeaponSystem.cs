using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSystem : MonoBehaviour
{
    public GameObject bullet;
    public GameObject player;
    public Camera Cam;
    public RaycastHit RaycastHit;

    public float bullet_speed;
    public float fire_speed;
    public float reload_speed;
    public float max_bullet;
    public float current_bullet;

    bool cooldown = false;

    private void OnReload()
    {
        cooldown = true;
        StartCoroutine(reload_timer());
        current_bullet = max_bullet;
    }

    private void Shoot()
    {
        if (Physics.Raycast(Cam.transform.position, Cam.transform.forward, out RaycastHit))
        {
            Debug.Log(RaycastHit.collider.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0) && current_bullet > 0 && !cooldown)
        {
            GameObject bullet_clone = Instantiate(bullet, transform.position, Quaternion.identity);
            bullet_clone.SetActive(true);
            Rigidbody rb = bullet_clone.GetComponent<Rigidbody>();
            rb.AddForce(player.transform.forward * bullet_speed);
            current_bullet -= 1;
            cooldown = true;
            StartCoroutine(cooldown_timer());
        }
    }
    IEnumerator cooldown_timer()
    {
        yield return new WaitForSeconds(fire_speed);
        cooldown = false;
    }
    IEnumerator reload_timer()
    {
        yield return new WaitForSeconds(reload_speed);
        cooldown = false;
    }
}
