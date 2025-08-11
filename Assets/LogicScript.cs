using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScript : MonoBehaviour
{
    public float playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToChange)
    {
        playerScore += scoreToChange;
        scoreText.text = playerScore.ToString();
        Debug.Log("Added 1 to the score");
    }

    [ContextMenu("Decrease Score")]
    public void decreaseScore(int scoreToChange)
    {
        playerScore -= scoreToChange;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("Game Restarted");
        Time.timeScale = 1;
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        Debug.Log("Game Over");
        Time.timeScale = 0;
    }

}
