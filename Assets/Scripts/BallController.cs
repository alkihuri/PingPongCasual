using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField, Range(1, 50)] float maxSpeed = 25;
    [SerializeField, Range(1, 50)] float minSpeed = 2;
    // Update is called once per frame
    void Update()
    {
        float currentSpeed = GetComponent<Rigidbody>().velocity.magnitude;
        if(currentSpeed>maxSpeed)
        {
            GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().velocity.normalized * maxSpeed;
        }
        if(currentSpeed<minSpeed)
        {
            GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().velocity.normalized * minSpeed;
        }
    }
}
