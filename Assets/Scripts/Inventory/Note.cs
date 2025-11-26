using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Note : MonoBehaviour
{
    [SerializeField] List<TMP_Text> textFields;
    List<LanguageApplier> lang;
    [SerializeField] bool setIndexOnStart;
    [SerializeField] int startIndex;

    private void Start()
    {
        GetLangAppliers();
        SetIndexes();
    }

    public void ChangeLangData(int line, int newIndex)
    {
        lang[line].ChangeIndexTo(newIndex);
    }
    public int GetLangIndex(int line)
    {
        return lang[line].GetIndex();
    }
    public void SetIndexes()
    {
        if (setIndexOnStart == false)
            return;
        int index = startIndex;
        for(int i = 0; i < lang.Count; i++)
        {
            lang[i].ChangeIndexTo(index);
            index++;
        }
    }
    void GetLangAppliers()
    {
        lang = new List<LanguageApplier>();
        for(int i = 0; i< textFields.Count; i++)
        {
            lang.Add(textFields[i].GetComponent<LanguageApplier>());
        }
    }

}
