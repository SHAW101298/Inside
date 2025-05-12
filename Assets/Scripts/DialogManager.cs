using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;

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

    [SerializeField] List<string> textToShow;
    [SerializeField] float delayBetweenLetters;
    [SerializeField] float timeForTextToRemain;
    float timer;
    bool animateText;
    bool awaitingUntilRestart;
    int lettercount;
    int lastLetterIndex;


    [SerializeField] bool DEBUGSTART;
    [SerializeField] string debugText;


    public void ShowText(int index)
    {
        textToShow.Add(LanguageManager.Instance.GetText(index));
        animateText = true;
    }
    public void ShowText(string tekst)
    {
        textToShow.Add(tekst);
        lettercount = tekst.Length;
        animateText = true;
    }

    private void Update()
    {
        if(DEBUGSTART == true)
        {
            DEBUGSTART = false;

            ShowText(debugText);
        }

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
            timer -= delayBetweenLetters;
            dialogField.text += textToShow[0][lastLetterIndex];
            lastLetterIndex++;


            // Finished with this text
            if (lastLetterIndex >= textToShow[0].Length)
            {
                lastLetterIndex = 0;
                timer = 0;
                animateText = false;
                awaitingUntilRestart = true;
            }
        }
    }
    void AwateUntilFinishedWithReading()
    {
        timer += Time.deltaTime;
        if(timer >= timeForTextToRemain)
        {
            timer = 0;
            dialogField.text = "";
            awaitingUntilRestart = false;

            textToShow.RemoveAt(0);

            if(textToShow.Count > 0)
            {
                lettercount = textToShow[0].Length;
                animateText = true;
            }
        }
    }
}
