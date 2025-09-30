
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete6 : MonoBehaviour
{
        public void LoadNextLevel()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -12);
}

}
