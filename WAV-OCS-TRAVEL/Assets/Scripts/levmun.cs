using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Levmun : MonoBehaviour
{
   
    public Button[] buttons;
    public GameObject levelButtons;
    
    private void Awake()
    {
        ButtonsToArray();
        
        int unlockedLevel = PlayerPrefs.GetInt("UnlockedLevel", 1);
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }
        for(int i = 0; i < unlockedLevel; i++)
        {
            buttons[i].interactable = true;
        }
    }

   public void OpenLevel (int LevelId)
    {
        string levelName = "Level" + LevelId;
        SceneManager.LoadScene(levelName);
    }
   
    void ButtonsToArray()
    {
        int childCount = levelButtons.transform.childCount;
        buttons = new Button[childCount];
        for (int i = 0; i <childCount; i++)
        {
            buttons[i] = levelButtons.transform.GetChild(i).gameObject.GetComponent<Button>();
        }
    }
    
    
        
    public void OnClickBack()
    {
        this.gameObject.SetActive(false);
    }
    // Start is called before the first frame update
    
    public void Controller()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);

    }
    public void Main()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);

    }

    public void Quit()
    {
        Debug.Log("quit?");
        Application.Quit();
    }
    public void Resetprefs()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("Start Menu");
    }


}
