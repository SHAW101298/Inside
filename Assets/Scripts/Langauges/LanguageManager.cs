using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class LanguageManager : MonoBehaviour
{
    #region
    public static LanguageManager Instance;
    public void Awake()
    {

        if(Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
            //DontDestroyOnLoad(this);
        } 
    }
    #endregion
    [SerializeField] LanguageBase currentLanguage;
    [SerializeField] List<LanguageBase> languages;
    [SerializeField] Language_Polish pl;
    [SerializeField] Language_English eng;


    public void ChangeCurrentLanguage(int index)
    {
        currentLanguage = languages[index];
    }
    public string GetText(int index)
    {
        return currentLanguage.GetText(index);
    }
}
