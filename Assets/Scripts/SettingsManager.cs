using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{
    [SerializeField] Button musicOnButton;
    [SerializeField] Button musicOffButton;

    public Color selectedButtonColor = new Color(18, 24, 38, 255);
    public Color unselectedButtonColor = new Color(22, 32, 59, 255);

    public void MusicOn()
    {
        GameStateManager.musicPlayerOn = true;

        SetButtonColor(musicOnButton, selectedButtonColor);

        SetButtonColor(musicOffButton, unselectedButtonColor);
    }

    public void MusicOff()
    {
        GameStateManager.musicPlayerOn = false;

        SetButtonColor(musicOffButton, selectedButtonColor);

        SetButtonColor(musicOnButton, unselectedButtonColor);
    }

    private void SetButtonColor(Button inButton, Color inColor)
    {
        var cb = inButton.colors;
        cb.normalColor = inColor;
        inButton.colors = cb;
    }
}
