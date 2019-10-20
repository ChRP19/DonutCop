using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSpeed : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpeedUp());
    }

    IEnumerator SpeedUp()
    {
        yield return new WaitForSeconds(3);
        //Runner2D.speed = Runner2D.speed + 0.1f;
        Time.timeScale = Time.timeScale + 0.01f;
        StartCoroutine(SpeedUp());
    }
}
