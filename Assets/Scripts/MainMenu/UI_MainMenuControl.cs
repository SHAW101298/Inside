using System.Collections;
using System.Collections.Generic;
using TMPro;
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
    [SerializeField] TMP_Dropdown resolutionDropDown;
    [SerializeField] TMP_Dropdown fpsDropDown;
    [SerializeField] TMP_Dropdown vsyncDropDown;
    [SerializeField] TMP_Dropdown languageDropDown;
    float originalSoundVolume;
    float originalMusicVolume;

    [Header("Debug")]
    bool animate;
    bool animatecurrent;
    bool animatedesired;
    float currentValue = 0;

    private void Start()
    {
        currentWindow = menuWindow;
    }

    private void Update()
    {
        WindowsAnimation();
    }

    public void BTN_Play()
    {
        Cursor.visible = false;
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

        originalMusicVolume = Options.Instance.GetMusicVolume();
        originalSoundVolume = Options.Instance.GetSoundVolume();
    }
    public void BTN_Exit()
    {
        desiredWindow = exitWindow;
        animate = true;
        animatecurrent = true;
    }
    public void BTN_ExitGame()
    {
        Application.Quit();
    }

    public void BTN_SaveOptions()
    {

        Options.Instance.ChangeVolumes(musicSlider.value, soundSlider.value);
         
        bool fullscreen;
        int width, height;
        int fpsLimit;
        int vSync;
        int language;

        fullscreen = fullScreenToggle.isOn;

        switch (resolutionDropDown.value)
        {
            case 0:
                width = 1920;
                height = 1080;
                break;
            case 1:
                width = 1600;
                height = 900;
                break;
            case 2:
                width = 1280;
                height = 720;
                break;
            default:
                width = Screen.currentResolution.width;
                height = Screen.currentResolution.height;
                break;
        }
        switch (fpsDropDown.value)
        {
            case 0:
                fpsLimit = 30;
                break;
            case 1:
                fpsLimit = 60;
                break;
            case 2:
                fpsLimit = 120;
                break;
            case 5:
                fpsLimit = 0;
                break;
            default:
                fpsLimit = 0;
                break;
        }
        switch (vsyncDropDown.value)
        {
            case 0:
                vSync = 0;
                break;
            case 1:
                vSync = 1;
                break;
            case 2:
                vSync = 2;
                break;
            case 3:
                vSync = 3;
                break;
            case 4:
                vSync = 4;
                break;
            default:
                vSync = 0;
                break;
        }
        switch (languageDropDown.value)
        {
            case 0:
                language = 0;
                break;
            case 1:
                language = 1;
                break;
            default:
                language = 0;
                break;
        }

        LanguageManager.Instance.ChangeCurrentLanguage(language);
        Application.targetFrameRate = fpsLimit;
        QualitySettings.vSyncCount = vSync;
        Screen.SetResolution(width, height, fullscreen);
        BTN_Menu();
    }
    public void BTN_ReturnWithoutSavingOptions()
    {
        Options.Instance.ChangeVolumes(originalMusicVolume, originalSoundVolume);
        vsyncDropDown.value = QualitySettings.vSyncCount;
        fullScreenToggle.isOn = Screen.fullScreen;
        BTN_Menu();
    }

    public void Slider_ChangeSoundVolume()
    {
        Options.Instance.ChangeSoundVolume(soundSlider.value);
    }
    public void Slider_ChangeMusicVolume()
    {
        Options.Instance.ChangeMusicVolume(musicSlider.value);
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
