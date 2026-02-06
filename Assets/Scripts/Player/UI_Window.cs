using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Window : MonoBehaviour
{
    [SerializeField] GameObject parent;
    [SerializeField] UI_Window parentWindow;
    [SerializeField] bool isOpened;
    public void OpenWindow()
    {
        if(isOpened == false)
        {
            parentWindow.HideWindow();

        }
        else
        {
            HideWindow();
            parentWindow.OpenWindow();
        }
    }
    public void HideWindow()
    {

    }
}
