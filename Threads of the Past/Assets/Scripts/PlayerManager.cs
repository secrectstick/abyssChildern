using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;





public class PlayerManager : MonoBehaviour
{
    //FIELDS

    public enum AgeState
    {
        child,
        adult
    }


    public GameObject playerBody;

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

    public AgeState age;

    //pass a ref to the controller script?

    // Start is called before the first frame update
    void Start()
    {
        inPast = false;
        age = AgeState.adult;
    }

    // Update is called once per frame
    void Update()
    {
        // make an FSM for child and adult states via enum?
        if (inPast == true)
        {
            playerObject.sprite = childSprite.sprite;
            
        }
        else
        {
            playerObject.sprite = adultSprite.sprite;
        }

        switch (age)
        {
            case AgeState.adult:
                playerObject.sprite = adultSprite.sprite;
                break;
            case AgeState.child:
                playerObject.sprite = childSprite.sprite;
                break;
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
