
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete3 : MonoBehaviour
{ 
        public void LoadNextLevel()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -6);
}

}
