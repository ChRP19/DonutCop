using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    [SerializeField] private Text scoreLabel;
    [SerializeField] private SettingPopup settingPopup;
    [SerializeField] private Button resumeButton;
    [SerializeField] private Button restartButton;
    
    public int score = 0;
    void Start()
    {
        settingPopup.Close();
    }
    void Update()
    {
        score++;
        scoreLabel.text = score.ToString();
    }

    public void OnOpenSettings()
    {
        settingPopup.Open();  
    }

    public void ResumeGame()
    {
        settingPopup.Close();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Game");
        score = 0;
    }
}
