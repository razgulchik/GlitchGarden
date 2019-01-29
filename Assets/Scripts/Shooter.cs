using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject gun;
    [SerializeField] GameObject projectile;


    public void Fire()
    {
        Instantiate(projectile, gun.transform.position, gun.transform.rotation);
    }
}
