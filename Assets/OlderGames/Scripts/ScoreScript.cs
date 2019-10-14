using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class ScoreScript : MonoBehaviour
{
    [SerializeField] private Text scoreLabel;
    public static float score = 0;
    private float scoreTime = 0;

    void Start()
    {
        StartCoroutine(SpeedUp());
    }
    void FixedUpdate()
    {
        scoreTime = Time.timeSinceLevelLoad;
        score = (float)Math.Round(scoreTime, 1) * 10;                           
        scoreLabel.text = score.ToString();
    }

    IEnumerator SpeedUp()
    {
        yield return new WaitForSeconds(1);
        Runner2D.speed = Runner2D.speed + 0.1f;
        StartCoroutine(SpeedUp());
    }
}
