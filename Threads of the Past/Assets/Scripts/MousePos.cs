using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MousePos : MonoBehaviour
{
    public Vector2 mousePosUpdate;
    public Vector3 mouseWorldPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePosUpdate = Mouse.current.position.ReadValue();        
        mouseWorldPosition = Camera.main.ScreenToWorldPoint(mousePosUpdate);
    }
}
