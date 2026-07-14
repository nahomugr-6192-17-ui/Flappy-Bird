using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicScript : MonoBehaviour
{
    public int scoreCounter;
    public Text scoreText;
    public GameObject GameOver;

    public void addScore()
    {
        scoreCounter += 1;
        scoreText.text = scoreCounter.ToString();
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
