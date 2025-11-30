using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Note : MonoBehaviour
{
    [SerializeField] List<TMP_Text> textFields;
    List<LanguageApplier> lang;
    [SerializeField] int startIndex;

    private void Awake()
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
        Debug.Log("Getting Lang Appliers");
        lang = new List<LanguageApplier>();
        for(int i = 0; i< textFields.Count; i++)
        {
            lang.Add(textFields[i].GetComponent<LanguageApplier>());
        }
    }
    public void RevealNoteLine(int line)
    {
        int x = startIndex + line;
        Debug.Log("x = " + x + "  ||  Line = " + line);
        Debug.Log("Error because Note is not in active state. Awake not called yet");
        Debug.Log("lang count = " + lang.Count);
        lang[line].ChangeIndexTo(x);
    }

}
