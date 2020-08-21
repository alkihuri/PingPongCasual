using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerForce : MonoBehaviour
{
    public Transform oponent;

    private void OnCollisionEnter(Collision collision)
    {
        Handheld.Vibrate();
        GameObject.FindObjectOfType<AudioSource>().Play();
        if (GetComponent<AIController>())
        {
            GameStates.SetAiShot();
            collision.gameObject.GetComponent<Rigidbody>().AddForce(oponent.transform.forward * -20 + transform.right * Random.Range(-2, 2), ForceMode.Impulse);
        }
        else
        {
            GameStates.SetPlayerShot();
            collision.gameObject.GetComponent<Rigidbody>().AddForce(oponent.transform.forward * 20 + transform.right * Random.Range(-2, 2), ForceMode.Impulse);
        }
    } 
}
