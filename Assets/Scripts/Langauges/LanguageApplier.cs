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
        textField.text = LanguageManager.Instance.GetText(index);
    }

    private void Start()
    {
        SetAccordingToLanguage();
    }
}
