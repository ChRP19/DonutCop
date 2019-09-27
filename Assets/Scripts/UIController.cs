using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] private Text scoreLabel;
    [SerializeField] private SettingPopup settingPopup;
    [SerializeField] private Button resumeButton;
    [SerializeField] private Button restartButton;
    
    void Start()
    {
        settingPopup.Close();
    }
    void Update()
    {
        scoreLabel.text = Time.realtimeSinceStartup.ToString();
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
        Application.LoadLevel("Game");
    }
}
