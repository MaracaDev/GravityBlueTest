using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInput : MonoBehaviour
{

    [SerializeField] private PlayerInput playerInput;
    

    private void Awake()
    {
        playerInput = new PlayerInput();
        playerInput.PlayerMap.Enable();
    }
    public Vector2 GetMovementNormalized()
    {
        Vector2 inputVector = playerInput.PlayerMap.Movement.ReadValue<Vector2>();
        inputVector = inputVector.normalized;

        return inputVector;
    }
}
