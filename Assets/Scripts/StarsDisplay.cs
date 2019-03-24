using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarsDisplay : MonoBehaviour
{
    [SerializeField] float stars = 100;
    Text starsText;

    void Start()
    {
        stars = 900 / PlayerPrefs.GetFloat("difficulty");
        starsText = GetComponent<Text>();
        UpdateStarsAmount();
    }

    private void UpdateStarsAmount()
    {
        starsText.text = stars.ToString();
    }

    public bool EnoughStars(int amount)
    {
        return stars >= amount;
    }

    public void AddStars(int amountOfEarnedStars)
    {
        stars += amountOfEarnedStars;
        UpdateStarsAmount();
    }

    public void SpentStars(int amountOfSpentStars)
    {
        if (stars >= amountOfSpentStars)
        {
            stars -= amountOfSpentStars;
            UpdateStarsAmount();
        }
    }
}
