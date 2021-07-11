using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class ScoreTracker : MonoBehaviour
{
    [SerializeField] public TMP_Text scoreText;

    private static int score_ = 0;

    private int score
    {
        get
        {
            return score_;
        }
        set
        {
            score_ = value;
            scoreText.text = "Score: " + score_;
        }
    }

    public void AddPoints(int points)
    {
        score += points;
    }
}
