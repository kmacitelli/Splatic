using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextLevel : MonoBehaviour
{
    private Scene scene;

    void OnCollisionEnter2D(Collision2D collision)
    {
        var parametersSingle = new LoadSceneParameters(LoadSceneMode.Single);
        var parametersCommon = new LoadSceneParameters(LoadSceneMode.Additive);

        scene = SceneManager.LoadScene("Level 2", parametersSingle);
        Debug.Log("LoadLevel 2");
        scene = SceneManager.LoadScene("Common", parametersCommon);
        Debug.Log("Load Common");
    }

    
}
