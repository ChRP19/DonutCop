using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSpeed : MonoBehaviour
{
    public float timeSpeed = 0f;
    void Start()
    {
        StartCoroutine(SpeedUp());
    }

    IEnumerator SpeedUp()
    {
        yield return new WaitForSeconds(5);
        Runner2D.speed = Runner2D.speed + 0.5f;
        // timeSpeed = Time.timeScale + 0.02f;
        // Time.timeScale = timeSpeed;
        StartCoroutine(SpeedUp());
    }
}
