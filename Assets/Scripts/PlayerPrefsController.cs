using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsController : MonoBehaviour
{
    const string MASTER_VOLUME_KEY = "master volume";
    const string DIFFICULTY_KEY = "difficulty";

    const float MIN_VOLUME = 0f;
    const float MAX_VOLUME = 1f;

    const int MIN_DIFF = 1;
    const int MAX_DIFF = 3;

    public static void SetVolume(float volume)
    {
        if (volume >= MIN_VOLUME && volume <= MAX_VOLUME)
        {
            //Debug.LogError("Master volume set to " + volume);
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
        }
        else
        {
            Debug.LogError("Master volume is out of range");
        }
    }

    public static float GetVolume()
    {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }

    public static void SetDifficulty (float difficulty)
    {
        if (difficulty >= MIN_DIFF && difficulty <= MAX_DIFF)
        {
            //Debug.LogError("Difficulty set to " + difficulty);
            PlayerPrefs.SetFloat(DIFFICULTY_KEY, difficulty);
        }
        else
        {
            Debug.LogError("Difficulty is out of range");
        }
    }

    public static float GetDifficulty()
    {
        return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
    }

}
