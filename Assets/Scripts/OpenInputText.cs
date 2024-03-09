using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;


public class OpenInputText : MonoBehaviour
{
    TouchScreenKeyboard teclado;
    public TMP_InputField txt;
    string apodo;


    public void OpenKeyBoard()
    {
        teclado = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);
    }
    void Update()
    {
        if (TouchScreenKeyboard.visible == false && teclado != null)
        {
            if (teclado.done)
            {
                teclado = null;
            }
            
        }

    }
    public void Vibration()
    {
        Handheld.Vibrate();     
    }
}
