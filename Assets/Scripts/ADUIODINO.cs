using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ADUIODINO : MonoBehaviour
{
    public AudioSource audioSource1;
    public AudioSource audioSource2;

    public float startDelay = 2f;
    public float audioPlayInterval = 2f;
    public float audioStopTime = 10f;

    private float nextAudioPlayTime;
    private float audioStartTime;
    private bool isFirstAudioPlaying = true;

    private void Start()
    {
        audioStartTime = Time.time + startDelay;
    }

    private void Update()
    {
        if (Time.time >= audioStartTime && Time.time >= nextAudioPlayTime)
        {
            if (isFirstAudioPlaying)
            {
                audioSource1.Play();
            }
            else
            {
                audioSource2.Play();
            }

            nextAudioPlayTime = Time.time + audioPlayInterval;

            if (Time.time >= audioStartTime + audioStopTime)
            {
                if (isFirstAudioPlaying)
                {
                    audioSource1.Stop();
                }
                else
                {
                    audioSource2.Stop();
                }
            }

            isFirstAudioPlaying = !isFirstAudioPlaying;
        }
    }
}
