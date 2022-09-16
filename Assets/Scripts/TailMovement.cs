using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailMovement : MonoBehaviour
{

    public float Speed;
    public Vector3 tailTarget;
    public GameObject tailTargetObj;
    public SnakeMovement mainSnake;
    public int BoneDistance = 2;
    
    void Start()
    {
        mainSnake = GameObject.FindGameObjectWithTag("SnakeMain").GetComponent<SnakeMovement>();
        Speed = mainSnake.Speed * BoneDistance;
        tailTargetObj = mainSnake.tailObjects[mainSnake.tailObjects.Count-2];
    }

    
    void Update()
    {
        tailTarget = tailTargetObj.transform.position;
        transform.LookAt(tailTarget);
        transform.position = Vector3.Lerp(transform.position,tailTarget,Time.deltaTime*Speed);
    }
}
