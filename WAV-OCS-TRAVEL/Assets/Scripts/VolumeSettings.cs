using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSettings : MonoBehaviour
{
    [SerializeField] private AudioMixer myMixer;
    [SerializeField] private Slider AirportNoise;
    [SerializeField] private Slider BingBong;

    private void Start()
    {
        if (PlayerPrefs.HasKey("AiprtNoiseVolume"))
        {
            LoadVolume();
        }
        else
        {
            SetAirportNoiseVolume();
            SetBingBongVolume();
        }


    }
    public void SetAirportNoiseVolume()
    {
        float volume = AirportNoise.value;
        myMixer.SetFloat("AirportNoise", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("AirportNoiseVolume", volume);
    }
    public void SetBingBongVolume()
    {
        float volume = BingBong.value;
        myMixer.SetFloat("BingBong", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("BingBongVolume", volume);
    }

    private void LoadVolume()
    {
        AirportNoise.value = PlayerPrefs.GetFloat("AirportNoiseVolume");
        BingBong.value = PlayerPrefs.GetFloat("BingBongVolume");

        SetAirportNoiseVolume();
    }
}