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

        
        text = new string[100];
        text[0] = "Rozpocznij GrÍ";
        text[1] = "Jak graÊ";
        text[2] = "Opcje";
        text[3] = "Wyjdü z gry";
        text[4] = "WyjúÊ z gry ?";
        text[5] = "Tak";
        text[6] = "Nie";
        text[7] = "Muzyka";
        text[8] = "DüwiÍki";
        text[9] = "Pe≥en Ekran";
        text[10] = "RozdzielczoúÊ";
        text[11] = "Limit FPS";
        text[12] = "Vsync";
        text[13] = "PowrÛt";
        text[14] = "Zapisz i Wyjdü";
        text[15] = "Wyjdü bez Zapisywania";
        text[16] = "Sterowanie";
        text[17] = "Poruszanie SiÍ";
        text[18] = "Skok";
        text[19] = "Interakcja";
        text[20] = "Bieg";
        text[21] = "Dotknij  ( E )";
        text[22] = "Wspnij siÍ  ( E )";
        text[23] = "WrÛÊ do gry";
        text[24] = "Do Menu";
        text[25] = "ZNAJDè TO !!!";
        text[26] = "????  ( E )";
        text[27] = "JÍzyk";
        text[28] = "* puk puk puk *";
        text[29] = "Co to za düwiÍk ?";
        text[30] = "ZAPOMNIJ !!!";
        text[31] = "Stracone . . .";
        text[32] = "Juø Nied≥ugo";
        text[33] = "Dlaczego";
        text[97] = "1-1 Dno";
        text[98] = "1-2 Bezruch";
        text[99] = "1-2 Cichy åwiat";
    }
}

/* Crow Lines
ZAPOMNIJ !!!
Stracone . . .
Juø Nied≥ugo
Dlaczego

 */
