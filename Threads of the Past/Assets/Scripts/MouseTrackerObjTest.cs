using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseTrackerObjTest : MonoBehaviour
{
    public MousePos mousePos;
    public GameObject hitBoxRef;
    Vector3 swipePlacement;
    Quaternion swipeDirection;
    GameObject spawnedHitBox;
    float deltaDistance;

    // Start is called before the first frame update
    void Start()
    {
        spawnedHitBox = Instantiate(hitBoxRef);
        spawnedHitBox.transform.position = swipePlacement;
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnedHitBox != null)
        {
            Destroy(spawnedHitBox);
        }

        spawnedHitBox = Instantiate(hitBoxRef);

        swipePlacement = new Vector3(mousePos.mouseWorldPosition.x, mousePos.mouseWorldPosition.y, 0);
        spawnedHitBox.transform.position = swipePlacement;

    }
}
