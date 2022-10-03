using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
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

    private AudioSource EatingSound;

    void Start()
    {
        tailObjects.Add(gameObject);
        scoreText.text = score.ToString();
        EatingSound = GetComponent<AudioSource>();
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
        // Debug.Log(score);
        // Debug.Log(gameObject.name);
        // Debug.Log(FoodScore.gameObject.name);
        
    }

    public void AddTail()
    {
        Vector3 newTailPos = tailObjects[tailObjects.Count-1].transform.position;
        newTailPos.z -= _z_offset;
        tailObjects.Add(GameObject.Instantiate(TailPrefab,newTailPos,Quaternion.identity) as GameObject);

        score++;
        scoreText.text = score.ToString();

        EatingSound.Play();
    }

    public void DeleteTail()
    {
        // Vector3 tailPos = tailObjects[tailObjects.[1]].transform.position;

        // Destroy(tailObjects[1].gameObject);
        // tailObjects.RemoveAt(1);
        // tailPos.RemoveAt(1);

        // int lastTail = tailObjects.Count-1;
        // // newTailPos.z -= _z_offset;
        // Destroy(tailObjects[lastTail].gameObject);
    }

}
