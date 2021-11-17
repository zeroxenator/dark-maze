using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;

    public void OnPlayButton()
    {
        SceneManager.LoadScene("Level2");
    }

    public void ChangeVolume()
    {
        GameStateManager.volumeLevel = volumeSlider.value;
    }
}
