
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete8 : MonoBehaviour
{
        public void LoadNextLevel()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -16);
}

}
