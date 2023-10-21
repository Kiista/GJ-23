using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TubeSystem : MonoBehaviour
{


    public string targetSceneName = "Alice"; // The name of the scene you want to load


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Ensure the player object has a "Player" tag
        {
            SceneManager.LoadScene(targetSceneName);
        }
    }
}
