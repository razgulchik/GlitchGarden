﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject gun;
    [SerializeField] GameObject projectile;
    AttackerSpawner myLaneSpawner;
    Animator animator;

    private void Start()
    {
        SetLaneSpawner();
        animator = GetComponent<Animator>();
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
            // TODO change animation to attack
            animator.SetBool("isAttacking", true);
        }
        else
        {
            //TODO change animation to idle
            animator.SetBool("isAttacking", false);
        }
    }

    private bool IsAttackerOnTheLane()
    {
        if (myLaneSpawner.transform.childCount <= 0)
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
