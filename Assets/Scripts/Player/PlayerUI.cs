using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public static PlayerUI instance;

    public PlayerData data;
    bool uiActive;
    [Header("Systems")]
    public PlayerUI_InteractionSystem interactionSystem;


    [Header("Windows")]
    [SerializeField] UI_Window defaultGameWindow;
    [SerializeField] UI_Window pauseWindow;
    [SerializeField] UI_Window optionsWindow;
    [SerializeField] UI_Window exitWindow;
    [SerializeField] UI_Window itemsWindow;
    [SerializeField] UI_Window notesWindow;
    [SerializeField] UI_Window mapWindow;
    [SerializeField] UI_Window currentWindow;
    [Header("Options")]
    [SerializeField] Slider soundSlider;
    [SerializeField] Slider musicSlider;
    [SerializeField] TMP_Dropdown fpsDropDown;
    [SerializeField] TMP_Dropdown vsyncDropDown;
    [SerializeField] TMP_Dropdown resolutionDropDown;
    [SerializeField] Toggle fullScreenToggle;
    [SerializeField] TMP_Dropdown languageDropDown;
    [Header("More")]
    [SerializeField] List<LanguageApplier> textFieldsToTranslate;
    float originalMusicVolume;
    float originalSoundVolume;

    bool windowIsActive;
    float timer;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        HideUI();
    }

    public void SetCurrentWindow(UI_Window window)
    {
        currentWindow = window;
    }
    public bool CompareWithCurrentWindow(UI_Window tested)
    {
        if (currentWindow == tested)
            return true;
        return false;
    }
    public void ShowPossibleInteractions(InteractionHolder holder)
    {
        //Debug.Log("Interactions is " + holder);
        interactionSystem.ShowPossibleInteractions(holder);
    }


    public void ACTION_EscapeButton(InputAction.CallbackContext context)
    {
        if(context.phase != InputActionPhase.Performed)
        {
            return;
        }

        /*
        if(uiActive == true)
        {
            if(currentWindow == pauseWindow)
            {
                HideUI();
            }
            else if(currentWindow == inventoryWindow)
            {
                HideUI();
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
            ActivateUI();
            currentWindow = pauseWindow;
            currentWindow.SetActive(true);


            originalMusicVolume = Options.Instance.GetMusicVolume();
            originalSoundVolume = Options.Instance.GetSoundVolume();
        }

        */
        currentWindow.OpenParentWindow();
        if(currentWindow == defaultGameWindow)
        {
            HideUI();
        }
        else
        {
            ActivateUI();
        }
        if(DialogManager.Instance.GetChoiceState() == true)
        {
            ActivateUI();
        }
    }

    private void HideUI()
    {
        uiActive = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        data.AllowMovemntAndRotationByUI();
    }

    private void ActivateUI()
    {
        uiActive = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        data.BlockMovementAndRotationByUI();
    }

    public void ACTION_InventoryButton(InputAction.CallbackContext context)
    {
        if (context.phase != InputActionPhase.Performed)
        {
            return;
        }
        BTN_Inventory();
        
    }
    public void ACTION_MapButton(InputAction.CallbackContext context)
    {
        if (context.phase != InputActionPhase.Performed)
        {
            return;
        }
        BTN_Map();
        
    }
    public void ACTION_JournalButton(InputAction.CallbackContext context)
    {
        if (context.phase != InputActionPhase.Performed)
        {
            return;
        }
        BTN_Notes();
        
    }
    public void BTN_Continue()
    {
        defaultGameWindow.OpenWindow();
        HideUI();
    }
    public void BTN_Options()
    {
        optionsWindow.OpenWindow();
    }
    public void BTN_ToMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void BTN_ExitGame()
    {
        exitWindow.OpenWindow();
    }
    public void BTN_ExitGameYES()
    {
        Application.Quit();
    }
    public void BTN_Return()
    {
        currentWindow.HideWindow();
    }
    public void BTN_SaveSettings()
    {
        SaveSettings();
        currentWindow.HideWindow();
    }
    public void BTN_ReturnWithoutSaving()
    {
        Options.Instance.ChangeVolumes(originalMusicVolume, originalSoundVolume);
        vsyncDropDown.value = QualitySettings.vSyncCount;
        fullScreenToggle.isOn = Screen.fullScreen;

        currentWindow.HideWindow();

    }

    public void Slider_ChangeSoundVolume()
    {
        Options.Instance.ChangeSoundVolume(soundSlider.value);
    }
    public void Slider_ChangeMusicVolume()
    {
        Options.Instance.ChangeMusicVolume(musicSlider.value);
    }
    public void BTN_Inventory()
    {
        if (currentWindow == pauseWindow)
            return;
        ActivateUI();
        currentWindow.HideWindow();
        itemsWindow.OpenWindow();
    }
    public void BTN_Notes()
    {
        if (currentWindow == pauseWindow)
            return;
        ActivateUI();
        currentWindow.HideWindow();
        notesWindow.OpenWindow();
    }
    public void BTN_Map()
    {
        if (currentWindow == pauseWindow)
            return;
        ActivateUI();
        currentWindow.HideWindow();
        mapWindow.OpenWindow();
    }

    void SaveSettings()
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
                language = 1;
                break;
        }


        LanguageManager.Instance.ChangeCurrentLanguage(language);
        Application.targetFrameRate = fpsLimit;
        QualitySettings.vSyncCount = vSync;
        Screen.SetResolution(width, height, fullscreen);
        foreach(LanguageApplier field in textFieldsToTranslate)
        {
            field.SetAccordingToLanguage();
        }
    }
}
