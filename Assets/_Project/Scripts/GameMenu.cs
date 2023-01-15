using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameMenu : Menu
{
    [SerializeField] private GameObject _gamePanel;
    [SerializeField] private TextMeshProUGUI _scoreValue;
    
    public void PauseGame()
    {
        _gamePanel.SetActive(false);
        _menuPanel.SetActive(true);
        Time.timeScale = 0f;
    }
    
    public void ResumeGame()
    {
        _gamePanel.SetActive(true);
        _menuPanel.SetActive(false);
        Time.timeScale = 1f;
    }
    
    public void UpdateScoreValue(int value)
    {
        if(_scoreValue)
            _scoreValue.text = "Score: " + value.ToString();
    }
    
}
