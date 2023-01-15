using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int _score;

    public int Score { get => _score; set => _score = value; }

    [SerializeField] private GameMenu _gameMenu;
    public void UpdateScore(int value)
    {
        _score += value;
        if(_gameMenu)
            _gameMenu.UpdateScoreValue(_score);
    }
}
