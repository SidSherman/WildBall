using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collision))]
public class DeathZone : MonoBehaviour
{
    [SerializeField]
    private SceneLoader _sceneManager;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            _sceneManager.ReloadScene();
        }
    }
}
