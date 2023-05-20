using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private GameInput gameInput;
    

    private void Update()
    {
        Vector2 inputVector = gameInput.GetMovementNormalized();

        Vector3 moveDir = new Vector3(inputVector.x, inputVector.y,0f);
        transform.position += moveDir * moveSpeed * Time.deltaTime;

        
    }


}
