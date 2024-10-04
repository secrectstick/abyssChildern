using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    //FIELDS
    [SerializeField]
    private GameObject playerObject;

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
            
        }
    }
}
