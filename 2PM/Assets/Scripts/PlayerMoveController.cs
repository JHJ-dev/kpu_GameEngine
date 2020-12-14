using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMoveController : MonoBehaviour, GameInputAction.IPlayerActions
{
    private CharacterController _characterController;
    private GameInputAction _inputAction;
    private Vector2 _moveActionValue;
    
    [SerializeField] private float characterMoveSpeed = 10f;
    
    private void Awake()
    { 
        _characterController = GetComponent<CharacterController>();
    }
    
    void Start()
    {
    }

    private void OnEnable()
    {
        if (_inputAction == null)
            _inputAction = new GameInputAction();
        
        _inputAction.Player.SetCallbacks(this);
        _inputAction.Player.Enable();
    }

    void Update()
    {
        if (GameManager.Instance.state == GameState.Playing)
        {
            var verticalVector = transform.forward * (_moveActionValue.y * Time.deltaTime * characterMoveSpeed);
            var horizontalVector = transform.right * (_moveActionValue.x * Time.deltaTime * characterMoveSpeed);

            _characterController.Move(verticalVector + horizontalVector);
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            EventManager.Emit("game_paused", null);
        }
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        _moveActionValue = context.ReadValue<Vector2>();
    }
}
