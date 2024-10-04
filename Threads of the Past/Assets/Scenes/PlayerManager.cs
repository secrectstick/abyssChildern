using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerManager : MonoBehaviour
{
    //FIELDS
    [SerializeField]
    private SpriteRenderer playerObject;

    [SerializeField]
    private Collider2D childCollider;

    [SerializeField]
    private Collider2D adultCollider;

    [SerializeField]
    private SpriteRenderer childSprite;

    [SerializeField]
    private SpriteRenderer adultSprite;

    private bool inPast;

    // Start is called before the first frame update
    void Start()
    {
        inPast = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (inPast == true)
        {
            playerObject.sprite = childSprite.sprite;
        }
        else
        {
            playerObject.sprite = adultSprite.sprite;
        }
    }

    public void OnFire(InputAction.CallbackContext context)
    {
        if ((context.phase == InputActionPhase.Performed))
        {
            if (inPast == false)
            {
                inPast = true;
            }
            else if (inPast == true)
            {
                inPast = false;
            }
            
        }
    }
}
