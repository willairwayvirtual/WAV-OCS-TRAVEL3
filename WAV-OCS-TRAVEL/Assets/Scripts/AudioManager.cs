using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("------ Audio Source -----")]
    [SerializeField] AudioSource musicSource;
    [Header("------ Audio Clip ------")]

    public AudioClip wavocstravel3;
    

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
       }
    private void Start()
    {
        musicSource.clip = wavocstravel3;
        musicSource.Play();
    }
 
}