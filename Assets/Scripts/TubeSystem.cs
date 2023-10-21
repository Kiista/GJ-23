using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Cinemachine;

public class TubeSystem : MonoBehaviour
{
    public CinemachineVirtualCameraBase camera1;
    public CinemachineVirtualCameraBase camera2;

    public string targetSceneName = "Alice"; // The name of the scene you want to load

    private void Start()
    {
        // Activate camera1 initially
        camera1.Priority = 10;
        camera2.Priority = 0;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Ensure the player object has a "Player" tag
        {
            camera1.Priority = 0;
            camera2.Priority = 10;
            // Load the target scene
            SceneManager.LoadScene(targetSceneName);
        }
    }
}
