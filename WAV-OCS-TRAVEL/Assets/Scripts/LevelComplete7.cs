
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete7 : MonoBehaviour
{
        public void LoadNextLevel()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -14);
}

}
