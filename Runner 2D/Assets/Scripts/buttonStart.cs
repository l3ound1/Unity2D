using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonStart : MonoBehaviour
{
    public string SampleScene;

    public void LoadScene()
    {
        SceneManager.LoadScene(SampleScene);
    }
}
