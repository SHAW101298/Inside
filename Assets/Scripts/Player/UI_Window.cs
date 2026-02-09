using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Window : MonoBehaviour
{
    public UI_Window parentWindow;
    [SerializeField] bool isOpened;
    public void OpenWindow()
    {
        gameObject.SetActive(true);
    }
    public void HideWindow()
    {
        gameObject.SetActive(false);
    }
    public void OpenParentWindow()
    {
        parentWindow.OpenWindow();
    }
}
