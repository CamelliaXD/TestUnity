using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Setting : MonoBehaviour
{
    [SerializeField] AudioSource clickSFX;
    public void SettingMenu()
    {
        SceneManager.LoadScene("MenuGame");
        clickSFX.Play();
    }
   
}
