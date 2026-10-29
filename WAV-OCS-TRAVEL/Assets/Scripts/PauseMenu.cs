using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool gameispaused = false;

    public GameObject PauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        {
            if (Input.GetKeyDown(KeyCode.Escape))
                if (gameispaused)

                {
                    Resume();
                }
                else
                {
                    pause();
                }
        }
    }
    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameispaused = false;
    }
    void pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameispaused = true;
    }
    public void Quit()
    {
        {
            SceneManager.LoadScene("START MENU");
        }
    }
    public void all_decks()
    {
        SceneManager.LoadScene("LevelSelectionMenu");
    }
  

}
