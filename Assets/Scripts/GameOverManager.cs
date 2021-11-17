using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public TMP_Text GameOver_TMP;

    private void Start()
    {
        GameOver_TMP.text = GameStateManager.gameOverText;
    }

    public void OnMain()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void OnReload()
    {
        SceneManager.LoadScene("Level2");
    }
}
