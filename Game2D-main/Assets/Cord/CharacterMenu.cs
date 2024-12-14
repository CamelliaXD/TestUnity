using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CharacterMenu : MonoBehaviour
{
    [SerializeField] AudioSource clickSFX;
    public void ChaMenu()
    {
        SceneManager.LoadScene("CharactersMenu");
        clickSFX.Play();
    }
}
