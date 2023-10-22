using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Audiotreigger : MonoBehaviour
{
    public AudioSource audioSource;
    private bool hasTriggered = false;
    public string sceneToLoad = "End2";

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            audioSource.Play();
            hasTriggered = true;
            GetComponent<Collider2D>().enabled = false;
            StartCoroutine(DelayedSceneChange());
        }
    }

    IEnumerator DelayedSceneChange()
    {
        yield return new WaitForSeconds(20f); // Wait for 15 seconds.

        // Change the scene.
        SceneManager.LoadScene(sceneToLoad);
    }
}
