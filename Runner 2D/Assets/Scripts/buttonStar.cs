using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonStar : MonoBehaviour
{
    public string Shop;

    public void LoadScene()
    {
        SceneManager.LoadScene(Shop);
    }
}
