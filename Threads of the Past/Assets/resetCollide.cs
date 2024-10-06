using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class resetCollide : MonoBehaviour
{

    public GameObject adult;
    public GameObject child;
    public int CurIndex;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == adult)
        {
            SceneManager.LoadScene(CurIndex);
        }

        if (collision.gameObject == child)
        {
            SceneManager.LoadScene(CurIndex);
        }

    }
}
