using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using TMPro;

public class GameManager : MonoBehaviour
{
    private GameOverManager GameOverPopup;

    void Awake()
    {
        // Switch to 800 x 600 windowed
        //Screen.SetResolution(800, 600, false);        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameStateManager.timerIsRunning == false)
        {
            PlayerGameOver(false);
        }

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            GotoMainMenuScene();
        }
    }

    public void OnReload()
    {
        ReloadGame();
    }

    public void GotoMainMenuScene()
    {
        SceneManager.LoadScene("MainScene");
    }

    private void PlayerGameOver(bool playerWon)
    {

        GotoEndGameScene(playerWon);
    }

    private void GotoEndGameScene(bool playerWon)
    {
        if (playerWon)
        {
            GameStateManager.gameOverText = $"You escaped with \n{GameStateManager.timerSeconds:00} seconds left! \nCongrats!";
        }
        else
        {
            GameStateManager.gameOverText = "The darkness engulfs you! \nTry again!";
        }

        SceneManager.LoadScene("EndScene");
    }

    private void ReloadGame()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerGameOver(true);
        }
    }
}
