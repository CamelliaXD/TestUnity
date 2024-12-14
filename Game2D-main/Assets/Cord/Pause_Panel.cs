using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause_Panel : MonoBehaviour
{
    public GameObject PauseMenu;
    void Start()
    {
        
    }
    public void Pause()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0;
    }
    public void Continue()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
