using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenu : Menu
{
    [SerializeField] private GameObject _gamePanel;
    
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
    
}
