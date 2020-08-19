using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{

    public Text aiScore, playerScore;
    // Update is called once per frame
    void Update()
    {
        aiScore.text = GameStates.aiScore.ToString();
        playerScore.text = GameStates.playerScore.ToString();
    }
}
