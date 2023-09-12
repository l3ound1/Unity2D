using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class music : MonoBehaviour
{
    
    private bool ismuted = false;
    
   


    public void OnSoundButton()
    {
        ismuted = !ismuted;
        if (ismuted)
        {
            AudioListener.volume = 0;
        }
        if (!ismuted)
        {
            AudioListener.volume = 1;
        }

    }
}
