using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using UnityEditor.SearchService;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerLide : MonoBehaviour
{
    private Rigidbody2D rb;
    private SceneTransition sceneTransition;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap2"))
        {
            sceneTransition.ChangeScene("End2");
        }
    }

    private void Die()
    {
        rb.bodyType = RigidbodyType2D.Static;
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
