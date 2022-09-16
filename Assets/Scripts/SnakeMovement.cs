using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SnakeMovement : MonoBehaviour
{
    public float Speed = 5f;
    public float RotationSpeed = 5f;
    public List<GameObject> tailObjects = new List<GameObject>();
    private float _z_offset = 0.5f;

    public GameObject TailPrefab;

    public TMP_Text scoreText;
    int score = 1;

    void Start()
    {
        tailObjects.Add(gameObject);
        scoreText.text = score.ToString();
    }

    void Update()
    {
        transform.Translate(Vector3.forward*Speed*Time.deltaTime);

        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left*RotationSpeed*Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right*RotationSpeed*Time.deltaTime);
        }
        
    }

    public void AddTail()
    {
        Vector3 newTailPos = tailObjects[tailObjects.Count-1].transform.position;
        newTailPos.z -= _z_offset;
        tailObjects.Add(GameObject.Instantiate(TailPrefab,newTailPos,Quaternion.identity) as GameObject);

        score++;
        scoreText.text = score.ToString();
    }
}
