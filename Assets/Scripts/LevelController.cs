using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] int numberOfAttackersAlive = 0;
    [SerializeField] GameObject winLable;
    [SerializeField] GameObject loseLable;
    [SerializeField] float delayLevelComplete = 3f;
    bool timerIsOut = false;

    private void Start()
    {
        winLable.SetActive(false);
        loseLable.SetActive(false);
    }

    public void PlusAttacker()
    {
        numberOfAttackersAlive++;
    }

    public void MinusAttacker()
    {
        numberOfAttackersAlive--;
        if (timerIsOut && numberOfAttackersAlive <= 0)
        {
            StartCoroutine(HandleWinCondition());
        }
    }
    IEnumerator HandleWinCondition()
    {
        winLable.SetActive(true);
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(delayLevelComplete);
        FindObjectOfType<SceneLoader>().LoadNextScene();
    }

    public void TimeIsOut()
    {
        timerIsOut = true;
        StopSpawners();
        
    }

    private void StopSpawners()
    {
        AttackerSpawner[] attackerSpawners = FindObjectsOfType<AttackerSpawner>();
        foreach(AttackerSpawner aS in attackerSpawners)
        {
            aS.StopSpawn();
        }
    }

    public void YouLose()
    {
        loseLable.SetActive(true);
        Time.timeScale = 0;
    }
}

