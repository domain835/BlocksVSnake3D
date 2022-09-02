using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMovement : MonoBehaviour
{
    public float MoveSpeed = 5;
    public float DisplacementSpeed = 90;
    public int Gap = 10;


    public GameObject BonePrefab;

    private List<GameObject> BodyParts = new List<GameObject>();
    private List<Vector3> PositionHistory = new List<Vector3>();



    // Start is called before the first frame update
    void Start() {
        GrowSnake();
        GrowSnake();
        GrowSnake();
        GrowSnake();
        GrowSnake();
    }

    // Update is called once per frame
    void Update()
    {
        // move forward
        transform.position += transform.forward * MoveSpeed * Time.deltaTime;

        // displacement
        float displacementDirection = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * displacementDirection * DisplacementSpeed * Time.deltaTime);

        // store position history
        PositionHistory.Insert(0, transform.position);

        // move body parts
        int index = 0;
        foreach (var body in BodyParts) {
            Vector3 point = PositionHistory[Mathf.Min(index * Gap, PositionHistory.Count - 1)];
            body.transform.position = point;
            index++;
        }
    }

    private void GrowSnake() {
        GameObject bone = Instantiate(BonePrefab);
        BodyParts.Add(bone);
    }
}
