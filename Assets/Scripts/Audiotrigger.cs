using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audiotreigger : MonoBehaviour
{
    public AudioSource audioSource;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            audioSource.Play();
        }
    }
}
