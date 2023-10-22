using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    private SceneTransition sceneTransition;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DelayedSceneChange());
    }

   

    IEnumerator DelayedSceneChange()
    {
        yield return new WaitForSeconds(15f); // Wait for 15 seconds.

        // Change the scene.
        sceneTransition.ChangeScene("MAINMENU");
    }
}
