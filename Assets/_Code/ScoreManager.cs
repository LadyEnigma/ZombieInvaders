using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static int score = 0;
    private static int hiScore = 0;
    public Text scoreText;
    public Text hiScoreText;
    public Text gameOverText;
    private int oldHighScore;

    public static bool gameOver = false;

    void Awake()
    {
        gameOver = false;
        oldHighScore = PlayerPrefs.GetInt ("highscore", 0);
        hiScore = oldHighScore;
    }

    void StoreHighscore (int newHighscore)
    {
        int oldHighscore = PlayerPrefs.GetInt ("highscore", 0);
        if (newHighscore > oldHighscore)
            PlayerPrefs.SetInt ("highscore", newHighscore);
    }

    void Update()
    {
        scoreText.text = "Score: " + score;
        hiScoreText.text = hiScore + ":HiScore";
        Debug.Log (oldHighScore);
        if (score > hiScore)
        {
            hiScore = score;
            if (hiScore > oldHighScore)
                PlayerPrefs.SetInt ("highscore", hiScore);
        }
        if (gameOver)
        {
            gameOverText.enabled = true;
            if (Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
            {
                score = 0;
                Application.LoadLevel (Application.loadedLevel);
            }
        }
        else
        {
            gameOverText.enabled = false;
        }
    }
}
