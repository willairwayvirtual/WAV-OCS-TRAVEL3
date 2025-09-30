
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete4 : MonoBehaviour
{
        public void LoadNextLevel()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -8);
}

}
