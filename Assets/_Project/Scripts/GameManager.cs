using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int _score;
    [SerializeField] private GameMenu _gameMenu;
    [SerializeField] private AudioClip _loseSound;
    [SerializeField] private AudioClip _winSound;
    [SerializeField] private AudioClip _coinSound;
    public int Score { get => _score; set => _score = value; }

    

    private void Start()
    {
        Time.timeScale = 1f;
    }

    public void UpdateScore(int value)
    {
        _score += value;
        if (_gameMenu)
        {
            _gameMenu.UpdateScoreValue(_score);
            _gameMenu.AudioSource.PlayOneShot(_coinSound);
        }
          
            
    }

    public void LoadFinishMessage()
    {
        if (_gameMenu)
        {
            _gameMenu.AudioSource.PlayOneShot(_winSound);
            _gameMenu.UpdateMessage("Finish");
        }
            
    }
    
    public void PlayDeathSound()
    {
        if (_gameMenu)
        {
            _gameMenu.AudioSource.PlayOneShot(_loseSound);
        }
            
    }

}
