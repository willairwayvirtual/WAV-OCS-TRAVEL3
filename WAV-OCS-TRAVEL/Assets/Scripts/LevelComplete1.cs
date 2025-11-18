using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete1 : MonoBehaviour
{

    public void OnLevelComplete()
    {
        UnlockNewLevel();
        SceneManager.LoadScene("LevelSelectionMenu");
      
    }


    void UnlockNewLevel()
    {
        if (SceneManager.GetActiveScene().buildIndex >= PlayerPrefs.GetInt ("ReachedIndex"))
        {
          PlayerPrefs.SetInt("ReachedIndex", SceneManager.GetActiveScene().buildIndex +1);
          PlayerPrefs.SetInt("UnlockedLevel", PlayerPrefs.GetInt("UnlockedLevel", 1) + 1);
          PlayerPrefs.Save();
        }
    }
    public void Quit()
    {
        {
            UnlockNewLevel();
            SceneManager.LoadScene("LevelSelectionMenu");

        }


        void UnlockNewLevel()
        {
            if (SceneManager.GetActiveScene().buildIndex >= PlayerPrefs.GetInt("ReachedIndex"))
            {
                PlayerPrefs.SetInt("ReachedIndex", SceneManager.GetActiveScene().buildIndex + 1);
                PlayerPrefs.SetInt("UnlockedLevel", PlayerPrefs.GetInt("UnlockedLevel", 1) + 1);
                PlayerPrefs.Save();
            }
        }
    }
}