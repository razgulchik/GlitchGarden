using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{

    [SerializeField] Slider volumeSlider;
    [SerializeField] float defaultVolume = 0.4f;

    [SerializeField] Slider difficultySlider;
    [SerializeField] float defaultDifficulty = 2;


    // Start is called before the first frame update
    void Start()
    {
        volumeSlider.value = PlayerPrefsController.GetVolume();
        difficultySlider.value = PlayerPrefsController.GetDifficulty();
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
        PlayerPrefsController.SetDifficulty(difficultySlider.value);
        FindObjectOfType<SceneLoader>().LoadStartScreen();
    }

    public void SetToDefault()
    {
        volumeSlider.value = defaultVolume;
        difficultySlider.value = defaultDifficulty;
    }

}
