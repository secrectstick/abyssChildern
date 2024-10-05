using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class testPlayerController : MonoBehaviour
{
    Vector3 moveSpeed;
    Vector3 jumpVect;
    public float moveMult;
    public int jumpSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (moveSpeed.normalized * moveMult) / 1000;
    }

    public void MovePlayer(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            moveSpeed = context.ReadValue<Vector2>();
        }
        else
        {
            moveSpeed = new Vector3(0,0,0);
        }
    }

    public void PlayerJump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            jumpVect = context.ReadValue<Vector2>();
        }
    }
}
