using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [Tooltip("Level time in SECONDS")]
    [SerializeField] float levelTime = 10f;

    // Update is called once per frame
    void Update()
    {
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / levelTime;

        bool timeIsOut = (Time.timeSinceLevelLoad >= levelTime);

        if(timeIsOut)
        {
            Debug.Log("Time is out, level finished");
        }
    }
}
