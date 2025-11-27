using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Note : MonoBehaviour
{
    [SerializeField] List<TMP_Text> textFields;
    List<LanguageApplier> lang;
    [SerializeField] int startIndex;
    List<int> revealedLangIndex;

    private void Start()
    {
        GetLangAppliers();
    }

    public void ChangeLangData(int line, int newIndex)
    {
        lang[line].ChangeIndexTo(newIndex);
    }
    public int GetLangIndex(int line)
    {
        return lang[line].GetIndex();
    }
    void GetLangAppliers()
    {
        lang = new List<LanguageApplier>();
        for(int i = 0; i< textFields.Count; i++)
        {
            lang.Add(textFields[i].GetComponent<LanguageApplier>());
        }
    }
    public void RevealNoteLine(int line)
    {
        int x = startIndex + line;
        lang[line].ChangeIndexTo(x);
    }

}
