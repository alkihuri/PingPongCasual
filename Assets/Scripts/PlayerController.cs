using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Transform startPosition;



    private void Start()
    {
        startPosition = transform;
    }
    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") + 0.85f *Input.acceleration.x;
        
        float x = transform.position.x;
        if (x > -5 && x < 8)
            transform.Translate(horizontal, 0, 0);
        else
        {
            Handheld.Vibrate();
            transform.position = Vector3.Slerp(transform.position, new Vector3(0, startPosition.position.y, startPosition.position.z), 1);

        }

    }
}
