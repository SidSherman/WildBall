using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : InteractiveObject
{
    [SerializeField] private Animator _animator;
    private bool _isClose = true;
    
    public bool IsClose => _isClose;

    void Close()
    {
        _isClose = true;
    }

    void Open()
    {
        _isClose = false;
    }

    public override void Activate()
    {
        base.Activate();
        _animator.SetTrigger("Activate");
        _animator.SetBool("IsClose", false);
        
    }
    
    public override void Deactivate()
    {
        base.Deactivate();
        _animator.SetTrigger("Activate");
        _animator.SetBool("IsClose", true);
        
    }

}
