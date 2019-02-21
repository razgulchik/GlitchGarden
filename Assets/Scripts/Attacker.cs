using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{

    [SerializeField] float walkSpeed;
    GameObject currentTarget;


    void Update()
    {
        transform.Translate(Vector2.left * walkSpeed * Time.deltaTime);
        UpdateAnimationState();
    }

    private void UpdateAnimationState()
    {
        if (!currentTarget) { GetComponent<Animator>().SetBool("isAttacking", false); }
    }

    public void SetMovementSpeed (float speed)
    {
        walkSpeed = speed;
    }

    public void Attack (GameObject target)
    {
        GetComponent<Animator>().SetBool("isAttacking", true);
        currentTarget = target;
    }

    private void StrikeCurrentTatget (float damage)
    {
        if(!currentTarget)
        {
            return;
        }
        Health health = currentTarget.GetComponent<Health>();
        if(health)
        {
            health.DealDamage(damage);
        }

    }
}
