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
            if(collision.gameObject.TryGetComponent(out Player player))
            {
                if(!player.IsDead)
                    player.Death();
            }

            StartCoroutine(WaitToReload(3));
            // _sceneManager.ReloadScene();
        }
    }
    
    private IEnumerator WaitToReload(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        _sceneManager.ReloadScene();
    }
}
