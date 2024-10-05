using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTraverse : MonoBehaviour
{

    public int CurrentSceneIndex;
    public int NextSceneIndex;
    public GameObject Adult;
    public GameObject Child;
    public PlayerManager PM;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(CurrentSceneIndex);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == Adult)
        {
            PM.adultOnDoor = true;
        }
        if (collision.gameObject == Child)
        {
            PM.childOnDoor = true;
        }


        if (PM.adultOnDoor && PM.childOnDoor)
        {
            SceneManager.LoadScene(NextSceneIndex);
        }
        if (!PM.adultOnDoor && PM.childOnDoor)
        {
            PM.age = PlayerManager.AgeState.adult;
        }
        if (PM.adultOnDoor && !PM.childOnDoor)
        {
            PM.age = PlayerManager.AgeState.child;
        }


    }

}
