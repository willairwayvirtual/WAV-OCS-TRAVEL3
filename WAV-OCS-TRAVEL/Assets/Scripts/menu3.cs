using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menu3 : MonoBehaviour
{
    public void playgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);

    }


    public void Quit()
    {
        Debug.Log("quit?");
        Application.Quit();
    }
}

