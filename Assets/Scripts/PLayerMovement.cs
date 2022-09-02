using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerMovement : MonoBehaviour
{
    CharacterController cc;
    Vector3 moveVec;

    float speed = 5;

    public float SideSpeed;
    
    void Start()
    {
        cc = GetComponent<CharacterController>();
        moveVec = new Vector3(0, 1, 0);
    }

    // void Update()
    // {
    //     moveVec *= speed;
    //     moveVec *= Time.deltaTime;

    //     float input = Input.GetAxis("Horisontal");

    //     Vector3 newPos = transform.positon;
    //     newPos.z = Math.Lerp()
    // }
}
