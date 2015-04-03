using UnityEngine;
using System.Collections;

public class GameOverOnCollide : MonoBehaviour
{
    void OnCollisionEnter2D()
    {
        ScoreManager.gameOver = true;
    }
}
