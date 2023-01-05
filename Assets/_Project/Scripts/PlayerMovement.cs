
using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float _goundAcceleration;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _airAcceleration;
    [SerializeField] private float _jumpHeight;
    
    [SerializeField] private FollowCamera _camera;
    
    private Rigidbody _rigidbody;
    private PlayerControlls _input;

    private bool _isFalling = false;
    private Vector2 _inputDirection;

    private float _mouseYDelta;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _input = new PlayerControlls();
        _input.Ball.Move.performed += Move;
        _input.Ball.Move.canceled += StopMove;
        _input.Ball.Jump.started += Jump;
        _input.Ball.Mouse.performed += Rotate;
    }

    private void OnEnable()
    {
        _input.Enable();
    }

    private void OnDisable()
    {
        _input.Disable();
    }

    private void FixedUpdate()
    {
        if (_mouseYDelta > 0)
        {
           _camera.RotateCamera(_rotationSpeed, 1);
          //transform.Rotate(  Vector3.up * _rotationSpeed);
            _mouseYDelta--;
        }

        if (_mouseYDelta < 0)
        {
            _camera.RotateCamera(_rotationSpeed, -1);
            //transform.Rotate( -1 * Vector3.up * _rotationSpeed);
            _mouseYDelta++;
        }
        _camera.MoveCamera(transform.position);
        
        var accelerate = _isFalling ? _airAcceleration : _goundAcceleration;

        var forward = Vector3.ProjectOnPlane(_camera.transform.forward, Vector3.up);
        var right = Vector3.ProjectOnPlane(_camera.transform.right, Vector3.up);

        var direction = forward.normalized * _inputDirection.y + right.normalized * _inputDirection.x;

        var force = direction * accelerate;
        
        _rigidbody.AddForce(force, ForceMode.Acceleration);
        
    }

    public  void Rotate(InputAction.CallbackContext context)
    {
        _mouseYDelta = context.ReadValue<float>();

    }
    
    public  void Move(InputAction.CallbackContext context)
    {
 
        _inputDirection = context.ReadValue<Vector2>();
      
    }
    public  void StopMove(InputAction.CallbackContext context)
    {
        _inputDirection = Vector2.zero;
    }

    public void Jump(InputAction.CallbackContext context)
    {
        Debug.Log("Jump");
        if (!_isFalling)
        {
            _rigidbody.AddForce(Vector3.up * _jumpHeight, ForceMode.Acceleration);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        _isFalling = false;
    }
    
    private void OnCollisionExit(Collision collision)
    {
        _isFalling = true;
    }
}
