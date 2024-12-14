using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Pause : MonoBehaviour
{
    [SerializeField] public GameObject Pausemenu;
    [SerializeField] AudioSource clickSFX;
    
    public void Restart()
    {
        SceneManager.LoadScene("Game_Play");
        clickSFX.Play();
        Time.timeScale = 1;
    }
    public void Menu()
    {
        SceneManager.LoadScene("MenuGame");
        clickSFX.Play();
        Time.timeScale = 1;
    }
    public void Play()
    {
       
        clickSFX.Play();
        Time.timeScale = 1;
    }
    public void Quit()
    {
        Application.Quit();

    }
}
