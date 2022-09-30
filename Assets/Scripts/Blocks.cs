using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {

        if(other.CompareTag("SnakeMain"));
        {
            Destroy(gameObject);
            other.GetComponent<SnakeMovement>().DeleteTail();
        }
    }
}
