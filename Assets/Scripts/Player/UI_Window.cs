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
        PlayerUI.instance.SetCurrentWindow(this);
    }
    public void HideWindow()
    {
        gameObject.SetActive(false);
    }
    public void OpenParentWindow()
    {
        gameObject.SetActive(false);
        parentWindow.gameObject.SetActive(true);
        PlayerUI.instance.SetCurrentWindow(parentWindow);
    }
}
