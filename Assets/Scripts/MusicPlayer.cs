﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
        audioSource = FindObjectOfType<AudioSource>();
        audioSource.volume = PlayerPrefsController.GetVolume();
    }

    public void SetVolume(float volume)
    {
        audioSource.volume = volume;
    }
}
