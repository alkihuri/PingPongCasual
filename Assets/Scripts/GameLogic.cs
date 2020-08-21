using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    public GameObject ball;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject onOlaneBall = Instantiate(ball, Vector3.zero,Quaternion.identity);
        onOlaneBall.GetComponent<Rigidbody>().AddForce(transform.forward * 20,ForceMode.Impulse);
    }


    private  void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Ball")
        {
            Destroy(other.gameObject);
            GameObject onPlane  = Instantiate(ball, Vector3.zero, Quaternion.identity);
            onPlane.GetComponent<Rigidbody>().AddForce(transform.forward * 20, ForceMode.Impulse);
            if (GameStates.isPlayerShot)
                GameStates.playerScore++;
            if (GameStates.isAishot)
                {
                    GameObject.FindObjectOfType<CameraController>().ShakeCamera();
                 Handheld.Vibrate();
                    GameStates.aiScore++;
                }
        }  
    }
    // Update is called once per frame
    void Update()
    {
       
    }
}
