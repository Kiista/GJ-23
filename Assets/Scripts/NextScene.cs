using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public float changeTime;
    private SceneTransition sceneTransition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        changeTime = Time.deltaTime;
        if(changeTime <= 0)
        {
            sceneTransition.ChangeScene("MAINMENU");
        }
    }
}
