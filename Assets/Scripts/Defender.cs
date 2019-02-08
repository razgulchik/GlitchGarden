﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] int starsCost = 100;

    public void AddStars(int amount)
    {
        FindObjectOfType<StarsDisplay>().AddStars(amount);
    }

    public int GetDefenderCost()
    {
        return starsCost;
    }
}
