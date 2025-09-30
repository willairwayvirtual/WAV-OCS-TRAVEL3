using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSettings : MonoBehaviour
{
    [SerializeField] private AudioMixer myMixer;
    [SerializeField] private Slider musicSlider;
    [SerializeField] private Slider BingBongSlider;

    private void Start()
    {
        if (PlayerPrefs.HasKey("musicVolume"))
        {
            LoadVolume();
        }
        else
        {
            SetMusicVolume();
            SetBingBongVolume();
        }
        
        
    }
    public void SetMusicVolume ()
    {
        float volume = musicSlider.value;
        myMixer.SetFloat("AirportNoise", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("musicVolume", volume);
    }
    public void SetBingBongVolume()
    {
        float volume = BingBongSlider.value;
        myMixer.SetFloat("bingbong", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("BingBongVolume", volume);
    }   
        
        private void LoadVolume()
    {
        musicSlider.value = PlayerPrefs.GetFloat("musicVolume");
        BingBongSlider.value = PlayerPrefs.GetFloat("BingBongVolume");

        SetMusicVolume();
    }
}
