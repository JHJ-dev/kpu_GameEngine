using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraMoveController : MonoBehaviour, GameInputAction.IPlayerCameraActions
{
    private GameInputAction _inputAction;

    private Vector2 _mouseDeltaVector;

    [SerializeField] private Transform cameraTransform;
    [SerializeField] private float mouseSensitivity = 100f;
    
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
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
        var horizontalDirection = _mouseDeltaVector.x * Time.deltaTime * mouseSensitivity;
        transform.Rotate(0, horizontalDirection, 0);
    }
    
    public void OnAim(InputAction.CallbackContext context)
    {
        _mouseDeltaVector = context.ReadValue<Vector2>();
    }
}
