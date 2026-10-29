using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credit22 : MonoBehaviour
{
   
    public void playgame1()
    {
        SceneManager.LoadScene("START MENU");
    }

    public void Quit()
    {
        Debug.Log("quit?");
        Application.Quit();
    }

}
