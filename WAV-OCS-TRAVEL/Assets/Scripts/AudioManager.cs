using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("------ Audio Source -----")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;
    [Header("------ Audio Clip ------")]

    public AudioClip airport;
    public AudioClip bingbong;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
       }
    private void Start()
    {
        musicSource.clip = airport ;
        musicSource.Play();
    }
}