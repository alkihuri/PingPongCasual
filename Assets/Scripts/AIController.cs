using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour
{
    public GameObject ball;
    Transform startPosition;


    private void Start()
    {
        startPosition = transform;
    }

    // Update is called once per frame
    void Update()
    {
        ball = GameObject.FindGameObjectWithTag("Ball");
        transform.position = Vector3.Slerp(transform.position, new Vector3(ball.transform.position.x + Random.Range(-1, 1) / 10, startPosition.position.y, startPosition.position.z), 0.8f);
    }
}
