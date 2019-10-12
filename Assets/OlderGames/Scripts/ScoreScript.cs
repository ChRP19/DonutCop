using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreScript : MonoBehaviour
{
    [SerializeField] private Text scoreLabel;
    public static float score = 0;
    public float scoreTime = 0;

    void FixedUpdate()
    {
        scoreTime = Time.timeSinceLevelLoad;
        score = (float)Math.Round(scoreTime, 1) * 10;                           //Увеличение счетчика на 1
        scoreLabel.text = score.ToString();
    }
}
