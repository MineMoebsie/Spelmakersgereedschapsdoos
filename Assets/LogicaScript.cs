using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicaScript : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    public GameObject GameOver;
    public bool GameIsOver = false;

    [ContextMenu("Increase Score")]
    public void addScore() {
        score += 1;
        scoreText.text = score.ToString();
    }

    public void restartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver() {
        GameOver.SetActive(true);
        GameIsOver = true;
    }
}
