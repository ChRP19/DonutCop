using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScenesController : MonoBehaviour
{
    [SerializeField]private Text coinLabel;
    void Awake() 
    {
        coinLabel.text = (PlayerPrefs.GetInt("coin").ToString());
    }
    public void PressToStart()
    {
        SceneManager.LoadScene("Game");
    }

    public void MainMenu()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Menu");
    }
}
