using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private PlayerController playerController;

    private int score = 0;

    public TextMeshProUGUI scoreText;
    public GameObject gameOverScreen;

    public GameObject PlayUI;
    public GameObject GameOverUI;


    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        } else
        {
            Destroy(gameObject);
        }


        playerController = FindObjectOfType<PlayerController>();
    }

    // Start is called before the first frame update
    void Start()
    {
        Pause();
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        GameOverUI.SetActive(true);

        Pause();
    }

    public void Pause()
    {
        Time.timeScale = 0;
        playerController.enabled = false;
    }

    public void Play()
    {
        score = 0;
        scoreText.text = score.ToString();

        PlayUI.SetActive(false);
        gameOverScreen.SetActive(false);

        Time.timeScale = 1;
        playerController.enabled = true;

        Pipe[] pipes = FindObjectsOfType<Pipe>();

        foreach(Pipe pipe in pipes)
        {
            Destroy(pipe.gameObject);
        }
    }

    public void AddScore()
    {
        score++;

        scoreText.text = score.ToString();

        Debug.Log("Score: " + score);
    }
}
