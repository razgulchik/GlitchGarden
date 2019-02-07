using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] float starsCost = 100f;

    public void AddStars(int amount)
    {
        FindObjectOfType<StarsDisplay>().AddStars(amount);
    }
}
