using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

   
    [SerializeField] AudioSource diesource;

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "enemy")
        {
            Die();
            diesource.Play();
        }
    }
    void Die()
    {
        Destroy(gameObject);
        gamemanager.Instance.GameOver();
    }
}
