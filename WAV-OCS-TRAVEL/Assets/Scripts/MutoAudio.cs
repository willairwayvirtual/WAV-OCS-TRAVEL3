using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MutoAudio : MonoBehaviour


{
    // To toggle mute state
    public void ToggleMute()
    {
        // Check the current volume state
        if (AudioListener.volume == 0)
        {
            // Unmute (set volume to 1)
            AudioListener.volume = 1f;
        }
        else
        {
            // Mute (set volume to 0)
            AudioListener.volume = 0f;
        }
    }
}