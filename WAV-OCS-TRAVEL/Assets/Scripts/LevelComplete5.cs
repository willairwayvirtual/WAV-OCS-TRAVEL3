
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete5 : MonoBehaviour
{
        public void LoadNextLevel()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -10);
}

}
