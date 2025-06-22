using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LanguageApplier : MonoBehaviour
{
    [SerializeField] TMP_Text textField;
    [SerializeField] int index;

    public void SetAccordingToLanguage()
    {
        string text = LanguageManager.Instance.GetText(index);
        if(text != "")
        {
            textField.text = text;
        }
        else
        {
            text = LanguageManager.Instance.GetText(96);
            textField.text = text;
        }
    }

    private void Start()
    {
        SetAccordingToLanguage();
    }
}
