using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class logicScript : MonoBehaviour
{
    public int scoreCounter;
    public Text scoreText;
    public GameObject GameOver;
    public GameObject Bird;
    public GameObject StartGameUI;
    public AudioSource audioSource;
    public AudioClip scoreSound;
    public AudioClip gameOverSound;
    public bool isGameOver = false;
    public bool hasGameStarted = false;

    public void StartGame()
    {
        if (hasGameStarted)
        { 
            return; 
        }

        hasGameStarted = true;
        StartGameUI.SetActive(false);
    }

    public void addScore()
    {
        scoreCounter += 1;
        scoreText.text = scoreCounter.ToString("0");
        audioSource.PlayOneShot(scoreSound);
    }

    public void Update()
    {
        if (isGameOver && Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            restartGame();
        }
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {

        if (isGameOver)
        {
            return;
        }
        isGameOver = true;
        audioSource.PlayOneShot(gameOverSound);
        GameOver.SetActive(true);
    }
}
