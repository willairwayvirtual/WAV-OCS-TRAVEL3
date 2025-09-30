using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open_Panel : MonoBehaviour { 

public GameObject Pause_panel;

    public void OpenPanel()
    {
        if (Pause_panel !=null)
            {
            Pause_panel.SetActive(true);
        }
    }
    
}
