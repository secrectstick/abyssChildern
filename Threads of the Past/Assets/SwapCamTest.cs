using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;

public class SwapCamTest : MonoBehaviour
{
    public GameObject PrevPlayer;
    public GameObject FuturePlayer;
    public Follow followScript;

    public PlayerManager PM;

    // Start is called before the first frame update
    void Start()
    {
        //followScript.objToFollow = PrevPlayer;
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public void SwapPres(InputAction.CallbackContext context)
    {
        Debug.Log("Future");
        if (context.phase == InputActionPhase.Performed)
        {
            followScript.objToFollow = FuturePlayer;
        }
        PM.age = PlayerManager.AgeState.adult;
    }

    public void SwapPast(InputAction.CallbackContext context)
    {
        Debug.Log("Past");
        if (context.phase == InputActionPhase.Performed)
        {
            followScript.objToFollow = PrevPlayer;
        }
        PM.age = PlayerManager.AgeState.child;
    }

}
