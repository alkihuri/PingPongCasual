using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  static class GameStates  
{
    public static int playerScore = 0;
    public static int aiScore = 0;
    public static  bool isPlayerShot = false;
    public static bool isAishot = false; 
    public static void SetPlayerShot()
    {
        isAishot = false;
        isPlayerShot = true;
    }
    public static void SetAiShot()
    {
        isAishot = true;
        isPlayerShot = false;
    }
}
