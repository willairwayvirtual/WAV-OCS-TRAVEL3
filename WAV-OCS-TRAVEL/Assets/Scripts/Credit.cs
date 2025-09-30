using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credit : MonoBehaviour
{

    public void maunLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 22);
    }
}