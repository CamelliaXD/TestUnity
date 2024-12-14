using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    #region singleton
    public static gamemanager Instance;
    private void Awake()
    {
        if (Instance == null) Instance = this;
    }
    #endregion

    public float Score = 0f;
    public bool Playing = false;
    private void Update()
    {
        if (Playing)
        {
            Score += Time.deltaTime;
        }
       
    }
    public void GameOver()
    {
        Score = 0;
        Playing = false;
    }
    public string PrettyScore()
    {
        return Mathf.RoundToInt(Score).ToString();
    }

}
