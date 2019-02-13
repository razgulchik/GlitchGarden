using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject gun;
    [SerializeField] GameObject projectile;
    AttackerSpawner myLaneSpawner;

    private void Start()
    {
        SetLaneSpawner();
    }

    private void SetLaneSpawner()
    {
        AttackerSpawner[] spawners = FindObjectsOfType<AttackerSpawner>();
        foreach(AttackerSpawner spawner in spawners)
        {
            bool isCloseEnough = 
                (Mathf.Abs(spawner.transform.position.y - transform.position.y) 
                <= Mathf.Epsilon);
            if (isCloseEnough)
            {
                myLaneSpawner = spawner;
            }
        }
    }

    private void Update()
    {
        if (IsAttackerOnTheLane())
        {
            Debug.Log("pew pew pew");
            // TODO change animation to attack
        }
        else
        {
            Debug.Log("Stay still and wait for enimies");
            //TOD change animation to idle
        }
    }

    private bool IsAttackerOnTheLane()
    {
        if(myLaneSpawner.transform.childCount <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
        
    }

    public void Fire()
    {
        Instantiate(projectile, gun.transform.position, gun.transform.rotation);
    }
}
