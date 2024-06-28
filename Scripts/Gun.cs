using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public int damage;
    public int currentammo;
    public int maxammo;
    public float reloadtime;

    bool reloading;

    public Camera cam;
    public Transform ShootingPoint;
    public RaycastHit raycastHit;

    // Update is called once per frame
    void Update()
    {
        
    }
}
