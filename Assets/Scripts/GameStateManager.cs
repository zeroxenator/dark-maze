using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    public static float timerSeconds;
    public static bool timerIsRunning = false;

    public static bool freezePlayer = false;

    public static bool musicPlayerOn = true;

    public static string gameOverText = $"You escaped with \n{timerSeconds:00} seconds left! \nCongrats!";
    public static float volumeLevel = 0.5f;
}
