using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;
using UnityEngine.InputSystem;

[System.Serializable]
public class DialogData
{
    public DialogPrompt prompt;
    public int index;

    public DialogData(DialogPrompt newPrompt, int newIndex)
    {
        prompt = newPrompt;
        index = newIndex;
    }
    public DialogData()
    {
        prompt = null;
        index = 96;
    }
}

public class DialogManager : MonoBehaviour
{
    public static DialogManager Instance;
    private void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this); 
        }
        else
        {
            Instance = this;
        }
    }

    public TMP_Text dialogField;

    [SerializeField] List<DialogData> promptsToShow;
    [SerializeField] float delayBetweenLetters;
    [SerializeField] float timeForTextToRemain;

    [SerializeField] string currentTextToShow;

    bool pauseWaitTimer;
    float timer;
    bool animateText;
    bool awaitingUntilRestart;

    int lastLetterIndex;

    [Header("Player Dialog Options")]
    [SerializeField] GameObject dialogOptionsWindow;
    [SerializeField] DialogChoice currentChoice;
    [SerializeField] Transform optionsContent;
    [SerializeField] GameObject optionPrefab;
    bool choiceWasAlreadyMade;

    public void ShowText(DialogData data)
    {
        promptsToShow.Add(data);
        if(promptsToShow.Count == 1)
        {
            animateText = true;
            lastLetterIndex = 0;
            currentTextToShow = LanguageManager.Instance.GetText(promptsToShow[0].index);

            if (promptsToShow[0].prompt != null)
            {
                promptsToShow[0].prompt.EVENT_StartShowing.Invoke();
            }
        }

    }
    public void ShowText(int index)
    {
        DialogData data = new DialogData(null, index);
        promptsToShow.Add(data);

        if (promptsToShow.Count == 1)
        {
            lastLetterIndex = 0;
            currentTextToShow = LanguageManager.Instance.GetText(promptsToShow[0].index);
            animateText = true;
        }
    }
    public void ShowDialogOptions(DialogChoice choice)
    {
        dialogOptionsWindow.SetActive(true);
        currentChoice = choice;
        GameObject temp;
        UI_Data ui_Data;

        foreach(Transform child in optionsContent)
        {
            Destroy(child.gameObject);
        }
        for(int i = 0; i < choice.options.Count; i++)
        {
            // Content size fitter and grid layout should work itself there
            temp = Instantiate(optionPrefab);
            temp.transform.SetParent(optionsContent);
            temp.transform.localScale = Vector3.one;
            int index = choice.options[i].GetLangIndex();
            ui_Data = temp.GetComponent<UI_Data>();
            string optionText = (i+1).ToString() + ". ";
            optionText += LanguageManager.Instance.GetText(index);
            ui_Data.SetTextField(optionText);
            ui_Data.intValue = i;
            // Get text component from UI script, and set text according to language

        }
        // Block Player
        PlayerData.instance.BlockMovementAndRotationByUI();
        PlayerData.instance.BlockInteractions();
        PlayerData.instance.ChangeMapToUI();
    }
    public void PauseWaitTimer()
    {
        pauseWaitTimer = true;
    }
    public void UnPauseWaitTimer()
    {
        pauseWaitTimer = false;
    }
    public void ChooseDialogOption(int x)
    {
        PlayerData.instance.AllowMovemntAndRotationByUI();
        PlayerData.instance.AllowInteractions();
        PlayerData.instance.ChangeMapToPlayer();
        Debug.Log("ChooseDialogOption on " + x);
        ShowDialogPromptOnChoice(x);
    }
    public void Action_Number1(InputAction.CallbackContext context)
    {
        if (context.phase != InputActionPhase.Performed)
            return;
        if (currentChoice == null)
            return;

        ChooseDialogOption(0);
    }
    public void Action_Number2(InputAction.CallbackContext context)
    {
        if (context.phase != InputActionPhase.Performed)
            return;
        if (currentChoice == null)
            return;

        ChooseDialogOption(1);
    }
    public void Action_Number3(InputAction.CallbackContext context)
    {
        if (context.phase != InputActionPhase.Performed)
            return;
        if (currentChoice == null)
            return;

        ChooseDialogOption(2);
    }
    public void Action_Number4(InputAction.CallbackContext context)
    {
        if (context.phase != InputActionPhase.Performed)
            return;
        if (currentChoice == null)
            return;

        ChooseDialogOption(3);
    }
    public void Action_Number5(InputAction.CallbackContext context)
    {
        if (context.phase != InputActionPhase.Performed)
            return;
        if (currentChoice == null)
            return;

        ChooseDialogOption(4);
    }
    public void Action_Number6(InputAction.CallbackContext context)
    {
        if (context.phase != InputActionPhase.Performed)
            return;
        if (currentChoice == null)
            return;
        ChooseDialogOption(5);
    }

    void ShowDialogPromptOnChoice(int x)
    {
        if (currentChoice.options.Count < x)
            return;

        Debug.Log("ShowDialogPromptOnChoice on " + x);

        dialogOptionsWindow.SetActive(false);
        int index = currentChoice.options[x].GetLangIndex();
        currentChoice.ChoosenOption(x);
        ShowText(index);
        choiceWasAlreadyMade = true;
    }

    private void Update()
    {
        if(animateText == true)
        {
            AnimateText();
        }
        if(awaitingUntilRestart == true)
        {
            AwateUntilFinishedWithReading();
        }
    }

    void AnimateText()
    {
        timer += Time.deltaTime;
        if (timer >= delayBetweenLetters)
        {
            // Finished with this text
            if (lastLetterIndex >= currentTextToShow.Length)
            {
                lastLetterIndex = 0;
                timer = 0;
                animateText = false;
                awaitingUntilRestart = true;
                return;
            }

            timer -= delayBetweenLetters;
            dialogField.text += currentTextToShow[lastLetterIndex];
            lastLetterIndex++;
        }
    }
    void AwateUntilFinishedWithReading()
    {
        if(pauseWaitTimer == true)
        {
            return;
        }

        timer += Time.deltaTime;
        if (timer >= timeForTextToRemain)
        {
            timer = 0;
            dialogField.text = "";
            awaitingUntilRestart = false;
            if (promptsToShow[0].prompt != null)
            {
                promptsToShow[0].prompt.EVENT_EndShowing.Invoke();
            }

            promptsToShow.RemoveAt(0);

            if (promptsToShow.Count > 0)
            {
                //Debug.Log("Setting new current text");
                currentTextToShow = LanguageManager.Instance.GetText(promptsToShow[0].index);

                if (promptsToShow[0].prompt != null)
                {
                    //Debug.Log("Prompt is present");
                    promptsToShow[0].prompt.EVENT_StartShowing.Invoke();
                }
                animateText = true;
            }
        }
    }


}
