using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSpeed : MonoBehaviour
{
    public float timeSpeed = 1f;
    void Start()
    {
        StartCoroutine(SpeedUp());
    }

    IEnumerator SpeedUp()
    {
        yield return new WaitForSeconds(3);
        //Runner2D.speed = Runner2D.speed + 0.1f;
        timeSpeed = Time.timeScale + 0.002f;
        Time.timeScale = timeSpeed;
        StartCoroutine(SpeedUp());
    }
}
