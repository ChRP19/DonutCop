using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingPopup : MonoBehaviour
{

    public void Open()
    {
        gameObject.SetActive(true);
        Time.timeScale = 0.0f;
    }

    public void Close()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1.0f;
        // GameObject go = GameObject.Find("Donut");
        // LevelSpeed levelSpeed = go.GetComponent<LevelSpeed>();
        // float currentTime = levelSpeed.timeSpeed;
        // Time.timeScale = currentTime;
    }
}
