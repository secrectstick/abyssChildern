using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchButton : MonoBehaviour
{
    public GameObject objToActivate;
    public Sprite pressedButton;

    // Start is called before the first frame update
    void Start()
    {
        objToActivate.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        objToActivate.SetActive(true);
        gameObject.GetComponent<SpriteRenderer>().sprite = pressedButton;
    }
}
