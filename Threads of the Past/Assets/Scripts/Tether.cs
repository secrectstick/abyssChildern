using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tether : MonoBehaviour
{

    public GameObject tetherBlock;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 copy = tetherBlock.transform.position;
        copy.x  =   gameObject.transform.position.x;
        tetherBlock.transform.position = copy;
    }
}
