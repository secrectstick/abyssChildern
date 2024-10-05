using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushableObjs : MonoBehaviour
{
    
    public float pushForce;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionStay2D(Collision2D collision)
    {
        Rigidbody2D rigidBody = collision.collider.GetComponent<Rigidbody2D>();

        if (rigidBody != null)
        {
            Vector2 pushDirection = collision.transform.position - transform.position;
            pushDirection.Normalize();

            // Apply force to the other object
            rigidBody.AddForce(pushDirection * pushForce);

            collision.transform.rotation = new Quaternion(0f, 0f, 0f, 0f);
        }     
    }
}
