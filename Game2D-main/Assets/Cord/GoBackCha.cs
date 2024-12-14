using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoBackCha : MonoBehaviour
{
    [SerializeField] AudioSource clickSFX;
    public void BackChaMenu()
    {
        SceneManager.LoadScene("startGame");
        clickSFX.Play();
    }
}
