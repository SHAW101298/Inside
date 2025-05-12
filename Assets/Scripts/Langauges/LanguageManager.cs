using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class LanguageManager : MonoBehaviour
{
    public static LanguageManager Instance;
    [SerializeField] LanguageBase currentLanguage;
    [SerializeField] Language_Polish pl;
    [SerializeField] Language_English eng;

    public string GetText(int index)
    {
        return currentLanguage.GetText(index);
    }
}
