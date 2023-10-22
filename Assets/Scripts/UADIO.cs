using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UADIO : MonoBehaviour
{
    public AudioSource audioSource;
    public float startDelay = 2f; // Delay before the first audio play.
    public float audioPlayInterval = 2f; // Time between audio plays.
    public float audioStopTime = 10f; // Time to stop playing audio.

    private float nextAudioPlayTime;
    private float audioStartTime;

    private void Start()
    {
        // Calculate the start time for audio playback.
        audioStartTime = Time.time + startDelay;
    }

    private void Update()
    {
        // Check if it's time to start or stop playing audio.
        if (Time.time >= audioStartTime && Time.time >= nextAudioPlayTime)
        {
            // Play audio.
            audioSource.Play();

            // Calculate the next time to play audio.
            nextAudioPlayTime = Time.time + audioPlayInterval;

            // Check if it's time to stop playing audio.
            if (Time.time >= audioStartTime + audioStopTime)
            {
                // Stop audio.
                audioSource.Stop();
            }
        }
    }
}
