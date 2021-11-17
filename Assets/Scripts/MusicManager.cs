using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource audioSource;    

    private void Awake()
    {
        //Set the playback time to 3 seconds
        audioSource.time = 10;

        //Play the audio
        audioSource.Play();
        audioSource.volume = GameStateManager.volumeLevel;
    }
}
