using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Note : MonoBehaviour
{
    [SerializeField] List<TMP_Text> textFields;
    List<LanguageApplier> lang;

    public void ChangeLangData(int line, int newIndex)
    {
        lang[line].ChangeIndexTo(newIndex);
    }
    public int GetLangIndex(int line)
    {
        return lang[line].GetIndex();
    }

}
