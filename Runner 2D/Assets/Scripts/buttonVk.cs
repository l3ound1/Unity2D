using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonVk : MonoBehaviour
{
    public string link = "https://vk.com/alekseyloll";
    public void OpenLink()
    {
        Application.OpenURL(link);
    }
}
