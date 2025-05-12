using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Language_Polish : LanguageBase
{
    public static Language_Polish Instance;
    public string[] text;
    public override string GetText(int index)
    {
        return text[index];
    }

    public void Awake()
    {
        if(Instance != this && Instance != null)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }

        
        text = new string[50];
        text[0] = "Rozpocznij Grê";
        text[1] = "Jak graæ";
        text[2] = "Opcje";
        text[3] = "WyjdŸ z gry";
        text[4] = "Wyjœæ z gry ?";
        text[5] = "Tak";
        text[6] = "Nie";
        text[7] = "Muzyka";
        text[8] = "DŸwiêki";
        text[9] = "Pe³en Ekran";
        text[10] = "Rozdzielczoœæ";
        text[11] = "Limit FPS";
        text[12] = "Vsync";
        text[13] = "Powrót";
        text[14] = "Zapisz i WyjdŸ";
        text[15] = "WyjdŸ bez Zapisywania";
        text[16] = "Sterowanie";
        text[17] = "Poruszanie Siê";
        text[18] = "Skok";
        text[19] = "Interakcja";
        text[20] = "Bieg";
        text[21] = "Dotknij  ( E )";
        text[22] = "Wspnij siê  ( E )";
        text[23] = "Wróæ do gry";
        text[24] = "Do Menu";
    }
}
