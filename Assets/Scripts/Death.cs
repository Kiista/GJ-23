using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneTransition : MonoBehaviour
{
    public Image fadeImage;
    public float fadeDuration = 1.0f;

    private void Start()
    {
        // Start the scene with a black screen (full opacity).
        fadeImage.color = Color.black;
        StartCoroutine(FadeOut());
    }

    public void ChangeScene(string sceneName)
    {
        StartCoroutine(FadeInAndLoadScene(sceneName));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            ChangeScene("DinoGR");
        }
    }

    private IEnumerator FadeOut()
    {
        float elapsedTime = 0;

        while (elapsedTime < fadeDuration)
        {
            fadeImage.color = Color.Lerp(Color.black, Color.clear, elapsedTime / fadeDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        fadeImage.color = Color.clear;
    }

    private IEnumerator FadeInAndLoadScene(string sceneName)
    {
        float elapsedTime = 0;

        while (elapsedTime < fadeDuration)
        {
            fadeImage.color = Color.Lerp(Color.clear, Color.black, elapsedTime / fadeDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        fadeImage.color = Color.black;

        // Load the new scene.
        SceneManager.LoadScene(sceneName);
    }
}