using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{

    [SerializeField] Slider volumeSlider;
    [SerializeField] float defaultVolume = 0.4f;


    // Start is called before the first frame update
    void Start()
    {
        volumeSlider.value = PlayerPrefsController.GetVolume();
    }

    // Update is called once per frame
    void Update()
    {
        var musicPlayer = FindObjectOfType<MusicPlayer>();
        if(musicPlayer)
        {
            musicPlayer.SetVolume(volumeSlider.value);
        }
        else
        {
            Debug.LogWarning("No Music Player found");
        }
    }

    public void SaveAndnExit()
    {
        PlayerPrefsController.SetVolume(volumeSlider.value);
        FindObjectOfType<SceneLoader>().LoadStartScreen();
    }

    public void SetToDefault()
    {
        volumeSlider.value = defaultVolume;
    }

}
