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
    public AudioClip oceanwaves;
    public AudioClip smoothcoldwindlooped1;


    public static AudioManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        musicSource.clip = airport ;
        musicSource.Play();
    }
}