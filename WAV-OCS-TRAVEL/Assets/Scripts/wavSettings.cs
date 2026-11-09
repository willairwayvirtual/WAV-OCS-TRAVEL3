using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class wavSettings : MonoBehaviour
{
  
        public void SetFullScreen(bool isFullScreen)
        {
            Screen.fullScreen = isFullScreen;
        }
        public void back()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);

        }
    }
