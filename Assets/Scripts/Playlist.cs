using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playlist : MonoBehaviour
{
    [SerializeField] AudioClip mp3;

    // Start is called before the first frame update
    void Start()
    {
        var currentClip = FindObjectOfType<MusicPlayer>().GetComponent<AudioSource>();
        if (currentClip != mp3)
        {
            currentClip.clip = mp3;
            currentClip.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
