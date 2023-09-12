using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorePanel : MonoBehaviour
{
   
    public Text text1;
    public Text text2;
    

    private void Start()
    {
       
        text2.text = ("Ваш Счет : ") + text1.text.ToString();
    }
}
