
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete9 : MonoBehaviour
{
        public void LoadNextLevel()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
}

}
