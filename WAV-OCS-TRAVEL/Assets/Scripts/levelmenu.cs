using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class levelmenu : MonoBehaviour
{

    public void Quit()
    {
        Debug.Log("quit?");
        Application.Quit();
    }
    public void restart1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }


    public void restart21()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
    public void leveiloader1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void leveiloader2()
    {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
    public void leveiloader3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
    }
    public void leveiloader4()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);
    }
    public void leveiloader5()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 9);
    }
    public void leveiloader6()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 11);
    }
    public void leveiloader7()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 13);
    }
    public void leveiloader8()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 15);
    }
    public void leveiloader9()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 17);
    }
}


