using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesDisplay : MonoBehaviour
{
    [SerializeField] float lives = 5;
    Text livesText;


    void Start()
    {
        lives = 15 / PlayerPrefs.GetFloat("difficulty");
        livesText = GetComponent<Text>();
        UpdateDisplayHealth();
    }

    private void UpdateDisplayHealth()
    {
        livesText.text = lives.ToString();
    }

    public void ReduceLive()
    {
        lives -= 1;
        UpdateDisplayHealth();
        if (lives <= 0)
        {
            FindObjectOfType<LevelController>().YouLose();
        }
    }
}
