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
    Rigidbody2D rBody;
    public bool IsActive;
    public bool isGrounded;

    public float jumpBufferTime = 0.2f;
    private float jumpBufferCounter;
    private bool jumpBufferCounting;

    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
        IsActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (jumpBufferCounting)
        {
            jumpBufferCounter -= Time.deltaTime;
        }

        if (isGrounded && jumpBufferCounter > 0f)
        {
            jumpVect = Vector3.up * jumpSpeed * 25;
            rBody.AddForce(jumpVect);

            jumpBufferCounter = 0f;
            jumpBufferCounting = false;
        }

        CheckGround();
        if (IsActive)
            transform.position += (moveSpeed.normalized * moveMult) / 1000;
    }

    public void MovePlayer(InputAction.CallbackContext context)
    {
 
            if (context.performed && IsActive && Time.timeScale == 1f)
            {
                moveSpeed = context.ReadValue<Vector2>();
            }
            else
            {
            moveSpeed = new Vector3(0, 0, 0);
            }
        
    }

    public void PlayerJump(InputAction.CallbackContext context)
    {
        if (IsActive)
        {
            if (context.performed)
            {
                jumpBufferCounter = jumpBufferTime;
                jumpBufferCounting = true;
            }

            
        }
        
    }

    void CheckGround()
    {
        // RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 10f);
        // Debug.DrawRay(transform.position, -Vector2.up * 1000, Color.red);

        if(rBody.velocity.y == 0)
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }
}
