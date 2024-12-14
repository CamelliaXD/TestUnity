using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    [SerializeField] AudioSource clickSFX;
    public void QuitGame()
    {
        Application.Quit();
        clickSFX.Play();
    }
}
