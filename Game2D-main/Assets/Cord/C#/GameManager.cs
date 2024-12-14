using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public float initialGameSpeed = 5f;
    public float gameSpeedIncrease = 0.1f;
    public float gameSpeed { get; private set; }

    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI HighScoreText;

    public Button retryButton;

    private Jump jump;
    //private Player player;
    private Spawner spawner;
    private float score;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            DestroyImmediate(gameObject);
        }
    }

    private void OnDestroy()
    {
        if(Instance == this)
        {
            Instance = null;
        }
    }

    private void Start()
    {
        jump = FindObjectOfType<Jump>();
        spawner = FindObjectOfType<Spawner>();

        NewGame();
    }

    public void NewGame()
    {
        Obtacle[] obtacles = FindObjectsOfType<Obtacle>();

        foreach (var obtacel in obtacles)
        {
            Destroy(obtacel.gameObject);
        }

        gameSpeed = initialGameSpeed;
        enabled = true;

        jump.gameObject.SetActive(true);
        spawner.gameObject.SetActive(true);

        gameOverText.gameObject.SetActive(false);
        retryButton.gameObject.SetActive(false);
        UpdateScore();
    }

    public void GameOver()
    {
        gameSpeed = 0f;
        enabled = false;

        jump.gameObject.SetActive(false);
        spawner.gameObject.SetActive(false);

        gameOverText.gameObject.SetActive(true);
        retryButton.gameObject.SetActive(true);
        UpdateScore();
    }

    private void Update()
    {
        gameSpeed += gameSpeedIncrease * Time.deltaTime;
        score += gameSpeed * Time.deltaTime;
        ScoreText.text = Mathf.FloorToInt(score).ToString();
    }
    private void UpdateScore()
    {
        float hiscore = PlayerPrefs.GetFloat("hiscore", 0);
        if (score > hiscore)
        {
            hiscore = score;
            PlayerPrefs.SetFloat("hiscore", hiscore);
        }
        HighScoreText.text = Mathf.FloorToInt(hiscore).ToString();
    }
}
