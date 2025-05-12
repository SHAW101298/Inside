using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Language_English : LanguageBase
{
    public static Language_English Instance;
    public string[] text;

    public override string GetText(int index)
    {
        return text[index];
    }

    public void Awake()
    {
        if (Instance != this && Instance != null)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }

        DontDestroyOnLoad(this);
        text = new string[15];
        text[0] = "Rozpocznij Grê";
        text[1] = "Jak graæ";
        text[2] = "Opcje";
        text[3] = "WyjdŸ z gry";
    }
}
