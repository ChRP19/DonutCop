using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] private Text scoreLabel;
    [SerializeField] private SettingPopup settingPopup;
    
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
        if (settingPopup.gameObject.activeSelf == false)
        {
            settingPopup.Open();
        }
        else settingPopup.Close();
    }
}
