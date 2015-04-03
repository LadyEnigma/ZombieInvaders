using UnityEngine;
using System.Collections;

public class ChangeScoreOnCollide : MonoBehaviour
{
    public int pointValue = 1;
    
    void OnCollisionEnter2D()
    {
        
        ScoreManager.score += pointValue;
    }
}
