using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;
    public Button restartButton;
    public Canvas canvas;

    public void ShowGameOverScreen(int finalScore)
    {
        // Toon het game over scherm
        gameObject.SetActive(true);
        // Toon de eindscore
        gameOverText.text = "Game Over!\nFinal Score: " + finalScore.ToString();
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        // Herstart het spel
        SceneManager.LoadScene("Prototype 4");

    }

    public void CloseGame()
    {
        // Quit the application
        Application.Quit();
    }
}
