using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;

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

    float timer;
    bool animateText;
    bool awaitingUntilRestart;

    int lastLetterIndex;

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
