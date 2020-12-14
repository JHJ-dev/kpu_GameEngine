using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraMoveController : MonoBehaviour, GameInputAction.IPlayerCameraActions
{
    public GameState state;
    
    private GameInputAction _inputAction;
    private Vector2 _mouseDeltaVector;
    private float _cameraRotation;

    [SerializeField] private Transform cameraTransform;
    [SerializeField] private float mouseSensitivity = 100f;
    
    void Start()
    {
    }

    private void OnEnable()
    {
        if(_inputAction == null) _inputAction = new GameInputAction();
        
        _inputAction.PlayerCamera.SetCallbacks(this);
        _inputAction.PlayerCamera.Enable();
    }

    private void OnDisable()
    {
        _inputAction.Disable();
    }

    void Update()
    {
        if (GameManager.Instance.state == GameState.Playing)
        {
            var horizontalDirection = _mouseDeltaVector.x * Time.deltaTime * mouseSensitivity;
            transform.Rotate(0, horizontalDirection, 0);

            _cameraRotation = Mathf.Clamp(_cameraRotation - _mouseDeltaVector.y * Time.deltaTime * mouseSensitivity,
                -90f, 60f);
            cameraTransform.localRotation = Quaternion.Euler(_cameraRotation, 0, 0);
        }
    }

    public void OnAim(InputAction.CallbackContext context)
    {
        _mouseDeltaVector = context.ReadValue<Vector2>();
    }
}
