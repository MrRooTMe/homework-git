using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bool movingToTarget = false;

        if (Input.GetKeyDown(KeyCode.W))
        {
            movingToTarget = true;
            // OR, if you want to toggle the movement
            // movingToTarget = !movingToTarget ;
        }
        if(movingToTarget)
        {
            transform.position += Vector3.forward * Time.deltaTime;
        }
    }
}