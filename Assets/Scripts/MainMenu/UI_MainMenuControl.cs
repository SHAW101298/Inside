using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_MainMenuControl : MonoBehaviour
{

    [Header("WINDOWS")]
    [SerializeField] GameObject menuWindow;
    [SerializeField] GameObject howToPlayWindow;
    [SerializeField] GameObject optionsWindow;
    [SerializeField] GameObject exitWindow;

    [Header("Animation Data")]
    [SerializeField] float windowMovementSpeed;
    [SerializeField] Vector3 openPosition;
    [SerializeField] Vector3 closedPosition;
    GameObject currentWindow;
    GameObject desiredWindow;

    [Header("Options Data")]
    [SerializeField] Slider musicSlider;
    [SerializeField] Slider soundSlider;
    [SerializeField] Toggle fullScreenToggle;
    [SerializeField] Dropdown resolutionDropDown;
    [SerializeField] Dropdown fpsDropDown;

    [Header("Debug")]
    bool animate;
    bool animatecurrent;
    bool animatedesired;
    float currentValue = 0;


    private void Update()
    {
        WindowsAnimation();
    }

    public void BTN_Play()
    {
        SceneManager.LoadScene(1);
    }
    public void BTN_Menu()
    {
        desiredWindow = menuWindow;
        animate = true;
        animatecurrent = true;
    }
    public void BTN_HowToPlay()
    {
        desiredWindow = howToPlayWindow;
        animate = true;
        animatecurrent = true;
    }
    public void BTN_Options()
    {
        desiredWindow = optionsWindow;
        animate = true;
        animatecurrent = true;
    }
    public void BTN_Exit()
    {
        desiredWindow = exitWindow;
        animate = true;
        animatecurrent = true;
    }

    public void BTN_SaveOptions()
    {

    }
    public void BTN_ReturnWithoutSaving()
    {

    }
    

    void WindowsAnimation()
    {
        if (animate == true)
        {
            currentValue += Time.deltaTime * windowMovementSpeed;
            if (animatecurrent == true)
            {
                currentWindow.transform.localPosition = Vector3.Lerp(openPosition, closedPosition, currentValue);

                if (currentValue >= 1)
                {
                    currentValue = 0;
                    animatecurrent = false;
                    animatedesired = true;
                }
            }
            if (animatedesired == true)
            {
                desiredWindow.transform.localPosition = Vector3.Lerp(closedPosition, openPosition, currentValue);

                if (currentValue >= 1)
                {
                    currentValue = 0;
                    animatecurrent = false;
                    animatedesired = false;
                    animate = false;

                    currentWindow = desiredWindow;
                    desiredWindow = null;
                }
            }
        }
    }
}
