using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [Tooltip("Level time in SECONDS")]
    [SerializeField] float levelTime = 10f;
    bool timerHasfinished = false;

    // Update is called once per frame
    void Update()
    {
        if(timerHasfinished) { return; }
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / levelTime;

        bool timeIsOut = (Time.timeSinceLevelLoad >= levelTime);

        if(timeIsOut)
        {
            FindObjectOfType<LevelController>().TimeIsOut();
            timerHasfinished = true;
        }
    }
}
