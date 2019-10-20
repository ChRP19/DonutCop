using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class ScoreScript : MonoBehaviour
{
    [SerializeField] private Text scoreLabel;
    public static float score = 0;
    private float scoreTime = 0;

    void FixedUpdate()
    {
        scoreTime = Time.timeSinceLevelLoad;
        score = (float)Math.Round(scoreTime, 1) * 10;                           
        scoreLabel.text = score.ToString();
    }
}
