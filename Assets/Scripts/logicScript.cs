using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class logicScript : MonoBehaviour
{
    public int scoreCounter;
    public Text scoreText;
    public GameObject GameOver;

    public void addScore()
    {
        scoreCounter += 1;
        scoreText.text = scoreCounter.ToString("0");
    }

    public void Update()
    {
        if (Keyboard.current.enterKey.wasPressedThisFrame)
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
        GameOver.SetActive(true);
    }
}
