using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using System;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    public PlayerData data;
    [SerializeField] GameObject infoWindow;
    [SerializeField] Text infoText;
    [SerializeField] float showInfoTimer;
    bool uiActive;
    


    [Header("Windows")]
    [SerializeField] GameObject pauseWindow;
    [SerializeField] GameObject optionsWindow;
    [SerializeField] GameObject exitWindow;
    [SerializeField] GameObject currentWindow;
    [Header("Options")]
    [SerializeField] Slider soundSlider;
    [SerializeField] Slider musicSlider;
    [SerializeField] TMP_Dropdown fpsDropDown;
    [SerializeField] TMP_Dropdown vsyncDropDown;
    [SerializeField] TMP_Dropdown resolutionDropDown;
    [SerializeField] Toggle fullScreenToggle;
    float originalMusicVolume;
    float originalSoundVolume;

    bool windowIsActive;
    float timer;

    private void Start()
    {
        Cursor.visible = false;

    }
    public void ShowText(string text)
    {
        //Debug.Log("SHOW INFO");
        infoWindow.SetActive(true);
        infoText.text = text;
        timer = 0;
        windowIsActive = true;
    }
    public void HideText()
    {
        infoWindow.SetActive(false);
        windowIsActive = false;
    }

    private void Update()
    {
        InfoWindowTimer();
    }

    void InfoWindowTimer()
    {
        if (windowIsActive == false)
            return;
        

        timer += Time.deltaTime;
        if (timer >= showInfoTimer)
        {
            HideText();
        }
    }

    public void ACTION_EscapeButton(InputAction.CallbackContext context)
    {
        if(context.phase != InputActionPhase.Performed)
        {
            return;
        }

        if(uiActive == true)
        {
            if(currentWindow == pauseWindow)
            {
                currentWindow.SetActive(false);
                currentWindow = null;
                uiActive = false;
                Cursor.visible = false;
                data.AllowMovementAndRotation();
            }
            else
            {
                currentWindow.SetActive(false);

                currentWindow = pauseWindow;
                currentWindow.SetActive(true);
            }
        }
        else
        {
            uiActive = true;
            currentWindow = pauseWindow;
            currentWindow.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            data.BlockMovementAndRotation();


            originalMusicVolume = Options.Instance.GetMusicVolume();
            originalSoundVolume = Options.Instance.GetSoundVolume();
        }
    }

    public void BTN_Continue()
    {
        currentWindow.SetActive(false);
        currentWindow = null;
        uiActive = false;
        Cursor.visible = false;

        data.AllowMovementAndRotation();
    }
    public void BTN_Options()
    {
        currentWindow.SetActive(false);
        currentWindow = optionsWindow;
        currentWindow.SetActive(true);
    }
    public void BTN_ToMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void BTN_ExitGame()
    {
        currentWindow.SetActive(false);
        currentWindow = exitWindow;
        currentWindow.SetActive(true);
    }
    public void BTN_ExitGameYES()
    {
        Application.Quit();
    }
    public void BTN_Return()
    {
        currentWindow.SetActive(false);
        currentWindow = pauseWindow;
        currentWindow.SetActive(true);
    }
    public void BTN_SaveSettings()
    {
        SaveSettings();
        currentWindow.SetActive(false);
        currentWindow = pauseWindow;
        currentWindow.SetActive(true);
    }
    public void BTN_ReturnWithoutSaving()
    {
        Options.Instance.ChangeVolumes(originalMusicVolume, originalSoundVolume);
        vsyncDropDown.value = QualitySettings.vSyncCount;
        fullScreenToggle.isOn = Screen.fullScreen;

        currentWindow.SetActive(false);
        currentWindow = pauseWindow;
        currentWindow.SetActive(true);

    }

    public void Slider_ChangeSoundVolume()
    {
        Options.Instance.ChangeSoundVolume(soundSlider.value);
    }
    public void Slider_ChangeMusicVolume()
    {
        Options.Instance.ChangeMusicVolume(musicSlider.value);
    }

    void SaveSettings()
    {
        Options.Instance.ChangeVolumes(musicSlider.value, soundSlider.value);

        bool fullscreen;
        int width, height;
        int fpsLimit;
        int vSync;

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


        Application.targetFrameRate = fpsLimit;
        QualitySettings.vSyncCount = vSync;
        Screen.SetResolution(width, height, fullscreen);
    }
}
